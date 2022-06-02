using Lab11.Models;

namespace Lab11.Repositories;

public interface IRepositoryEmprestimos
{
    Task<Emprestimo?> GetByIdAsync(int id);
    Task<List<Emprestimo>?> GetByLivroId(int id);
    Task<Emprestimo?> GetEmprestimoAtualByLivroId(int id);
    Task CreateAsync(Emprestimo emprestimo);
    Task UpdateAsync(Emprestimo emprestimo);
}