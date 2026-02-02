using GerenciamentoCaixaPostal.Core.Shared.Models;

namespace GerenciamentoCaixaPostal.Shared.Core.Models;

public class Cobranca
{
    public int Id { get; }
    public int IdCaixaPostal { get; private set; }
    public int IdCobrancaStatus { get; private set; }
    public DateTime DataVencimento { get; private set; }
    public DateTime DataLiquidacao { get; private set; }
    public decimal Valor { get; private set; }

    public virtual CobrancaStatus CobrancaStatus { get; set; }
    public virtual CaixaPostal CaixaPostal { get; set; }
}