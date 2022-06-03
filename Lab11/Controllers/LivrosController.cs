namespace Lab11.Controllers;

using Lab11.Repositories;
using Microsoft.AspNetCore.Mvc;
using Lab11.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase
{
    private readonly IRepositoryLivros repositoryLivros;
    private readonly IRepositoryAutores repositoryAutores;
    private readonly IRepositoryEmprestimos repositoryEmprestimos;

    public LivrosController(IRepositoryLivros repositoryLivros, IRepositoryAutores repositoryAutores, IRepositoryEmprestimos repositoryEmprestimos)
    {
        this.repositoryLivros = repositoryLivros;
        this.repositoryAutores = repositoryAutores;
        this.repositoryEmprestimos = repositoryEmprestimos;
    }

    [HttpGet("{livroId}")]
    public async Task<ActionResult<Livro?>> GetLivroById(int livroId)
    {
        Livro? livro = await repositoryLivros.GetById(livroId).FirstOrDefaultAsync(); ;
        if (livro is null)
        {
            return NotFound();
        }
        return livro;
    }

    [HttpGet()] // /api/livros?autorId=1
    public async Task<ActionResult<AutorLivrosEmprestimosDTO>> ConsultarLivrosByAutorId([FromQuery] int autorId)
    {
        if (autorId == 0)
        {
            return BadRequest("autorId deve ser informado.");
        }
        Autor? autor = await repositoryAutores.GetById(autorId);
        if (autor is null)
        {
            return NotFound($"Autor {autorId} não encontrado.");
        }

        AutorLivrosEmprestimosDTO autorLivrosEmprestimosDTO = new AutorLivrosEmprestimosDTO(autor.PrimeiroNome, autor.UltimoNome);

        if (autor.Livros is not null)
        {
            foreach (Livro livro in autor.Livros)
            {
                List<Emprestimo>? emprestimos = await repositoryEmprestimos.GetByLivroId(livro.Id);
                if (emprestimos is not null)
                {
                    foreach (Emprestimo emprestimo in emprestimos)
                    {
                        if (emprestimo.Entregue == false)
                        { //Indisponível
                            autorLivrosEmprestimosDTO.AddListEmprestimo(livro, emprestimo.Entregue, emprestimo.DataDevolucao);
                        }
                        else
                        { //Disponível
                            autorLivrosEmprestimosDTO.AddListEmprestimo(livro, emprestimo.Entregue, null);
                        }
                    }
                }

            }
        }
        return autorLivrosEmprestimosDTO;
    }

    [HttpPatch("{livroId}")]
    public async Task<ActionResult<Livro>> UpdateLivro([FromRoute] int livroId, [FromBody] LivroUpdateDTO livroUpdateDTO)
    {
        Livro? livro = await repositoryLivros.GetById(livroId).Include(livro => livro.Autores).FirstOrDefaultAsync();
        if (livro is not null)
        {
            if (livroUpdateDTO.Titulo is not null)
            {
                livro.Titulo = livroUpdateDTO.Titulo;
            }

            if (livroUpdateDTO.AutoresIds is not null)
            {
                livro.Autores.Clear();
                foreach (int autorId in livroUpdateDTO.AutoresIds)
                {
                    Autor? autor = await repositoryAutores.GetById(autorId);
                    if (autor is not null)
                    {
                        if (!livro.Autores.Any(autor => autor.Id == autorId))
                        {
                            livro.Autores.Add(autor);
                        }
                    }
                    else
                    {
                        return NotFound($"Autor com id {autorId} não encontrado.");
                    }
                }
            }
            await repositoryLivros.UpdateAsync(livro);
            return livro;
        }
        return NotFound($"Livro {livroId} não encontrado.");
    }

    [HttpDelete("{livroId}")]
    public async Task<ActionResult<Livro>> DeleteLivro([FromRoute] int livroId)
    {
        Livro? livro = await repositoryLivros.GetById(livroId).FirstOrDefaultAsync();
        if (livro is not null)
        {
            await repositoryLivros.DeleteAsync(livro);
            return NoContent();
        }
        return NotFound($"Livro {livroId} não encontrado.");
    }

    // [HttpGet]
    // public async Task<ActionResult<List<Livro>>> GetAll()
    // {
    //     return await repositoryLivros.GetAll();
    // }
}