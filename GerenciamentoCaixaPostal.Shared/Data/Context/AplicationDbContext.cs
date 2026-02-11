using GerenciamentoCaixaPostal.Core.Shared.Models;
using GerenciamentoCaixaPostal.Shared.Core.Models;
using GerenciamentoCaixaPostal.Shared.Core.Settings;
using GerenciamentoCaixaPostal.Shared.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GerenciamentoCaixaPostal.Shared.Data.Context;

public class AplicationDbContext(AppSettings appSettings, ILogger<AplicationDbContext> logWriter) : BaseDbContext(appSettings)
{
    public DbSet<ClienteStatus> ClientesStatus { get; set; }
    public DbSet<CaixaPostal> CaixasPostais { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<CaixaStatus> CaixasStatus { get; set; }
    public DbSet<CobrancaStatus> CobrancasStatus { get; set; }
    public DbSet<FormaPagamento> FormasPagamento { get; set; }
    public DbSet<Socio> Socios { get; set; }
    public DbSet<Cobranca> Cobrancas { get; set; }
    public DbSet<HistoricoPagamento> HistoricoPagamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new ClienteStatusConfiguration());
        modelBuilder.ApplyConfiguration(new CaixaPostalConfiguration());
        modelBuilder.ApplyConfiguration(new CaixaStatusConfiguration());
        modelBuilder.ApplyConfiguration(new CobrancaStatusConfiguration());
        modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
        modelBuilder.ApplyConfiguration(new HistoricoPagamentoConfiguration());
        modelBuilder.ApplyConfiguration(new SocioConfiguration());
        modelBuilder.ApplyConfiguration(new CobrancaConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
