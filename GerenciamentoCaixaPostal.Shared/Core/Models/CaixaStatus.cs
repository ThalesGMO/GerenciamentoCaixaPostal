using GerenciamentoCaixaPostal.Core.Shared.Models;

namespace GerenciamentoCaixaPostal.Shared.Core.Models;

public class CaixaStatus
{
    public int Id { get; }
    public string Nome { get; private set; }
    
    public virtual IEnumerable<CaixaPostal> CaixasPostais { get; set; }
}