using GerenciamentoCaixaPostal.Shared.Core.Models;

namespace GerenciamentoCaixaPostal.Core.Shared.Models;

public class CaixaPostal
{
    public int Id { get; }
    public int IdSocio { get; set; }
    public int IdCliente { get; set; }
    public int IdStatusCaixa { get; set; }
    public string Codigo { get; set; }
    public string NomeEmpresa { get; set; }
    public string CpfCnpj { get; set; }
    public DateTime DataAluguel { get; set; }
    public int DiaVencimento { get; set; }
    public decimal ValorMensal { get; set; }

    public virtual Socio Socio { get; set; }
    public virtual Cliente Cliente { get; set; }
    public virtual CaixaStatus CaixaStatus { get; set; }
    public virtual ICollection<Cobranca> Cobrancas { get; set; }
}