namespace GerenciamentoCaixaPostal.Shared.Core.Models;

public class FormaPagamento
{
    public int Id { get; }
    public string Nome { get; private set; }

    public IEnumerable<HistoricoPagamento> historicoPagamentos { get; set; }
}