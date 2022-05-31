using Lab11.Models;

namespace Lab11.Repositories;

public interface IRepositoryAutores
{
    Task<List<Autor>> GetAllByUltimoNameAsync(string ultimoNome);
    Task<Autor?> GetById(int id);
    Task CreateAsync(Autor autor);
    Task UpdateAsync(Autor autor);
}