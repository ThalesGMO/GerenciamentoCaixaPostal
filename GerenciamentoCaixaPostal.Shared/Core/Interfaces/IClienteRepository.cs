using GerenciamentoCaixaPostal.Core.Shared.Models;
using GerenciamentoCaixaPostal.Shared.Core.Models;

namespace GerenciamentoCaixaPostal.Shared.Core.Interfaces;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> ObterTodosAsync();
    Task<Cliente> ObterPorIdAsync(int id);
    Task AdicionarAsync(Cliente cliente);
    Task AtualizarAsync(Cliente cliente);
    Task RemoverAsync(int id);
    Task<Cliente> ObterPorCnpj(string cpfCnpj);
}
