namespace Lab11.Repositories.Implementations;

using Models;

using Microsoft.EntityFrameworkCore;

public class RepositoryEmprestimos : IRepositoryEmprestimos
{

    private readonly BibliotecaContext _context;

    public RepositoryEmprestimos(BibliotecaContext context)
    {
        _context = context;
    }

    public async Task<Emprestimo?> GetByIdAsync(int id)
    {
        return await _context.Emprestimos.Include(emp => emp.Livro).Where(emp => emp.Id == id).FirstOrDefaultAsync();
    }
    public async Task CreateAsync(Emprestimo emprestimo)
    {
        await _context.Emprestimos.AddAsync(emprestimo);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(Emprestimo emprestimo)
    {
        _context.Emprestimos.Update(emprestimo);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Emprestimo>?> GetByLivroId(int id)
    {
        return await _context.Emprestimos.Where(emp => emp.Livro.Id == id).ToListAsync();
    }

    public async Task<Emprestimo?> GetEmprestimoAtualByLivroId(int id)
    {
        return await _context.Emprestimos.Where(emp => emp.Livro.Id == id && emp.Entregue == false).FirstOrDefaultAsync();
    }
}