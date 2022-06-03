using Microsoft.AspNetCore.Mvc;
using Lab11.Repositories;
using Lab11.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab11.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BibliotecaController : ControllerBase
{
    private readonly ILogger<BibliotecaController> _logger;
    private readonly IRepositoryAutores repositoryAutores;
    private readonly IRepositoryEmprestimos repositoryEmprestimos;
    private readonly IRepositoryLivros repositoryLivros;

    public BibliotecaController(ILogger<BibliotecaController> logger, IRepositoryAutores repositoryAutores, IRepositoryEmprestimos repositoryEmprestimos, IRepositoryLivros repositoryLivros)
    {
        _logger = logger;
        this.repositoryAutores = repositoryAutores;
        this.repositoryEmprestimos = repositoryEmprestimos;
        this.repositoryLivros = repositoryLivros;
    }

    [HttpPost("emprestimos")] //api/biblioteca/emprestimos?livroId=12
    public async Task<ActionResult<EmprestimoDTO>> EmprestarLivro(int livroId)
    {
        Livro? livro = await repositoryLivros.GetById(livroId).FirstOrDefaultAsync();
        if (livro is not null)
        {
            Emprestimo? emprestimo = await repositoryEmprestimos.GetEmprestimoAtualByLivroId(livro.Id);
            if (emprestimo is null)
            {
                Emprestimo novoEmprestimo = new Emprestimo() { DataRetirada = DateTime.Now, DataDevolucao = DateTime.Now.AddDays(7), Entregue = false, Livro = livro };
                await repositoryEmprestimos.CreateAsync(novoEmprestimo);
                EmprestimoDTO emprestimoDTO = new EmprestimoDTO() { DataDevolucao = novoEmprestimo.DataDevolucao, DataRetirada = novoEmprestimo.DataRetirada, TituloLivro = novoEmprestimo.Livro.Titulo };
                return emprestimoDTO;
            }
            else
            {
                return BadRequest($"Livro não está disponível para emprestimo. Data da devolução esperada: {emprestimo.DataDevolucao}");
            }
        }
        return NotFound($"Livro {livroId} não encontrado.");
    }

    [HttpPut("emprestimos/{emprestimoId}")] // /api/biblioteca/emprestimos/22
    public async Task<ActionResult<EmprestimoDTO>> DevolverLivro(int emprestimoId)
    {
        Emprestimo? emprestimo = await repositoryEmprestimos.GetByIdAsync(emprestimoId);
        if (emprestimo is not null)
        {
            if (emprestimo.Entregue == true)
            {
                return BadRequest($"Emprestimo {emprestimoId} já devolvido.");
            }
            double multa = 0;
            if (DateTime.Now > emprestimo.DataDevolucao)
            {
                multa = (DateTime.Now - emprestimo.DataDevolucao).Days * 2.50;
            }
            emprestimo.DataDevolucao = DateTime.Now;
            emprestimo.Entregue = true;
            await repositoryEmprestimos.UpdateAsync(emprestimo);
            return new EmprestimoDTO() { DataDevolucao = emprestimo.DataDevolucao, DataRetirada = emprestimo.DataRetirada, Multa = multa, TituloLivro = emprestimo.Livro.Titulo };
        }
        return NotFound($"Emprestimo {emprestimoId} não encontrado.");
    }


}