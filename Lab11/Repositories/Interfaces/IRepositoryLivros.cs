using Lab11.Models;

namespace Lab11.Repositories;

public interface IRepositoryLivros
{
    Task<List<Livro>> GetAll();
    Task<Livro?> GetById(int id);
    Task<List<Livro>> GetAllByAutorIdAsync(int autorId);
    Task CreateAsync(Livro livro);
}