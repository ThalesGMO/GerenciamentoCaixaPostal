using GerenciamentoCaixaPostal.Shared.Core.Models;

namespace GerenciamentoCaixaPostal.Core.Shared.Models;

public class Cliente
{
    public int Id { get; }
    public int IdClienteStatus { get; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }
    
    public virtual ClienteStatus ClienteStatus { get; set; }
}