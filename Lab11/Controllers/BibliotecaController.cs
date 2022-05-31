using Microsoft.AspNetCore.Mvc;
using Lab11.Repositories;
using Lab11.Models;

namespace Lab11.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BibliotecaController : ControllerBase
{
    private readonly IRepositoryAutores repositoryAutores;
    private readonly IRepositoryEmprestimos repositoryEmprestimos;
    private readonly IRepositoryLivros repositoryLivros;

    public BibliotecaController(IRepositoryAutores repositoryAutores, IRepositoryEmprestimos repositoryEmprestimos, IRepositoryLivros repositoryLivros)
    {
        this.repositoryAutores = repositoryAutores;
        this.repositoryEmprestimos = repositoryEmprestimos;
        this.repositoryLivros = repositoryLivros;
    }

    [HttpGet("livros/autor/{id}")]
    public async Task<ActionResult<AutorLivrosEmprestimosDTO>> ConsultarLivros(int id)
    {
        var autor = await repositoryAutores.GetById(id);
        if (autor is null)
        {
            return NotFound();
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

    // public async Task<ActionResult<Emprestimo>> EmprestarLivro()
    // {

    // }




}