using GerenciamentoCaixaPostal.Shared.Core.Models;

namespace GerenciamentoCaixaPostal.Core.Shared.Models;

public class CaixaPostal
{
    public int Id { get; }
    public int IdSocio { get; private set; }
    public int IdCliente { get; private set; }
    public int IdStatusCaixa { get; private set; }
    public string Codigo { get; private set; }
    public string NomeEmpresa { get; private set; }
    public string CpfCnpj { get; private set; }
    public DateTime DataAluguel { get; private set; }
    public int DiaVencimento { get; private set; }
    public decimal ValorMensal { get; private set; }

    public virtual Socio Socio { get; set; }
    public virtual Cliente Cliente { get; set; }
    public virtual CaixaStatus CaixaStatus { get; set; }
    public virtual ICollection<Cobranca> Cobrancas {get; set;}
}