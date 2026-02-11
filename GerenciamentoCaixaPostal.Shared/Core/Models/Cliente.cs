using GerenciamentoCaixaPostal.Core.Shared.Models;

namespace GerenciamentoCaixaPostal.Shared.Core.Models;

public class Cliente
{
    public int Id { get; }
    public int IdClienteStatus { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }

    public virtual IEnumerable<CaixaPostal> CaixasPostais { get; set; }
    public virtual ClienteStatus ClienteStatus { get; set; }
}