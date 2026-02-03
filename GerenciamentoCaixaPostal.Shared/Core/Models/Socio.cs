using System.Data;

namespace GerenciamentoCaixaPostal.Core.Shared.Models;

public class Socio
{
    public int Id { get; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }

    public virtual IEnumerable<CaixaPostal> CaixasPostais { get; set; }
}