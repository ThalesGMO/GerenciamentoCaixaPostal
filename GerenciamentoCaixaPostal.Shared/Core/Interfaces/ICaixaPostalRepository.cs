using GerenciamentoCaixaPostal.Core.Shared.Models;

namespace GerenciamentoCaixaPostal.Shared.Core.Interfaces;

public interface ICaixaPostalRepository
{
    Task<IEnumerable<CaixaPostal>> ObterTodosAsync();
    Task<CaixaPostal> ObterPorIdAsync(int id);
    Task AdicionarAsync(CaixaPostal caixaPostal);
    Task AtualizarAsync(CaixaPostal caixaPostal);
    Task RemoverAsync(int id);
    Task<IEnumerable<CaixaPostal>> ObterPorClienteAsync(int clienteId);
}
