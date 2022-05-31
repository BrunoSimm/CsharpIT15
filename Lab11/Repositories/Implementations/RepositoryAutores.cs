namespace Lab11.Repositories.Implementations;

using Models;

using Microsoft.EntityFrameworkCore;

public class RepositoryAutores : IRepositoryAutores
{
    private readonly BibliotecaContext _context;

    public RepositoryAutores(BibliotecaContext context)
    {
        _context = context;
    }

    public Task<List<Autor>> GetAllByUltimoNameAsync(string ultimoNome)
    {
        return _context.Autores.Where(autor => autor.UltimoNome.Equals(ultimoNome))
            .Include(autor => autor.Livros)
            //.ThenInclude(livro => livro.Emprestimos)
            .ToListAsync();
    }
    public async Task CreateAsync(Autor autor)
    {
        await _context.Autores.AddAsync(autor);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Autor autor)
    {
        _context.Autores.Update(autor);
        await _context.SaveChangesAsync();
    }

    public async Task<Autor?> GetById(int id)
    {
        return await _context.Autores.Include(a => a.Livros).Where(aut => aut.Id == id).FirstOrDefaultAsync();
    }


}