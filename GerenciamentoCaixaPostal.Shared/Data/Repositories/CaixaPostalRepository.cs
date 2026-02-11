using GerenciamentoCaixaPostal.Core.Shared.Models;
using GerenciamentoCaixaPostal.Shared.Core.Interfaces;
using GerenciamentoCaixaPostal.Shared.Core.Models;
using GerenciamentoCaixaPostal.Shared.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoCaixaPostal.Shared.Data.Repositories;

public class CaixaPostalRepository : ICaixaPostalRepository
{
    public CaixaPostalRepository(AplicationDbContext context)
    {
        _context = context;
    }
    private readonly AplicationDbContext _context;

    public async Task AdicionarAsync(CaixaPostal caixaPostal)
    {
        _context.CaixasPostais.Add(caixaPostal);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(CaixaPostal caixaPostal)
    {
        _context.CaixasPostais.Update(caixaPostal);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<CaixaPostal>> ObterPorClienteAsync(int clienteId)
    {
        return await _context.CaixasPostais
            .Where(x => x.IdCliente == clienteId)
            .Include(x => x.Cobrancas)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<CaixaPostal> ObterPorIdAsync(int id)
    {
        return await _context.CaixasPostais
            .Include(x => x.Cliente)
            .Include(x => x.Cobrancas)
            .FirstOrDefaultAsync(x => x.Id == id);
    }  
    
    public async Task<IEnumerable<CaixaPostal>> ObterTodosAsync()
    {
        return await _context.CaixasPostais
            .Include(x => x.Cliente)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var caixa = await _context.CaixasPostais.FindAsync(id);
            if (caixa != null)
            {
                _context.CaixasPostais.Remove(caixa);
                await _context.SaveChangesAsync();
            }
    }
}
