using GerenciamentoCaixaPostal.Core.Shared.Models;

namespace GerenciamentoCaixaPostal.Shared.Core.Models;

public class ClienteStatus
{
    public int Id { get; }
    public string Nome { get; private set; }
    
    public virtual IEnumerable<Cliente> Clientes { get; set; }
}