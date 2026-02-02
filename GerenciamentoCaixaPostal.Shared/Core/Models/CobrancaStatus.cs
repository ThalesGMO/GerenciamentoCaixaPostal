namespace GerenciamentoCaixaPostal.Shared.Core.Models;

public class CobrancaStatus
{
    public int Id { get; }
    public string Nome { get; private set; }
     public virtual IEnumerable<Cobranca> Cobrancas { get; set; }
}