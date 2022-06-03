using Lab11.Models;

namespace Lab11.Repositories;

public interface IRepositoryLivros
{
    Task<List<Livro>> GetAll();
    IQueryable<Livro> GetById(int id);
    Task<List<Livro>> GetAllByAutorIdAsync(int autorId);
    Task CreateAsync(Livro livro);
    Task UpdateAsync(Livro livro);
    Task DeleteAsync(Livro livro);
}