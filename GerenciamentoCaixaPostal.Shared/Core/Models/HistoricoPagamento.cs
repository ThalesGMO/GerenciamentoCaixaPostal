namespace GerenciamentoCaixaPostal.Shared.Core.Models;

public class HistoricoPagamento
{
    public int Id { get; }
    public int IdCobranca { get; private set; }
    public int IdFormaPagamento { get; private set; }
    public DateTime DataPagamento { get; private set; }
    public decimal ValorPago { get; private set; }
    public string Observacao { get; private set; }

    public virtual Cobranca Cobranca { get; private set; }
    public virtual FormaPagamento FormaPagamento { get; private set; }
}