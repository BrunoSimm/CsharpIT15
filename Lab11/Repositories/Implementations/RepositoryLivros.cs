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

    public async Task<Livro?> GetById(int id)
    {
        return await _context.Livros.Include(l => l.Emprestimos).Where(l => l.Id == id).FirstOrDefaultAsync();
    }
}