namespace Lab11.Repositories.Implementations;

using Models;

using Microsoft.EntityFrameworkCore;

public class RepositoryLivros : IRepositoryLivros
{

    private readonly BibliotecaContext _context;

    public RepositoryLivros(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<List<Livro>> GetAll()
    {
        return await _context.Livros.ToListAsync();
    }
    public async Task<List<Livro>> GetAllByAutorIdAsync(int autorId)
    {
        return await _context.Livros.Include(livro => livro.Autores.Where(autor => autor.Id == autorId)).ToListAsync();
    }
    public async Task CreateAsync(Livro livro)
    {
        await _context.Livros.AddAsync(livro);
        await _context.SaveChangesAsync();
    }

    public IQueryable<Livro> GetById(int id)
    {
        return _context.Livros.Where(l => l.Id == id);
    }

    public async Task UpdateAsync(Livro livro)
    {
        _context.Livros.Update(livro);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Livro livro)
    {
        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();
    }
}