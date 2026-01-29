using GerenciamentoCaixaPostal.Core.Shared.Models;
using GerenciamentoCaixaPostal.Shared.Core.Models;
using GerenciamentoCaixaPostal.Shared.Core.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GerenciamentoCaixaPostal.Shared.Data.Context;

public class AplicationDbContext(AppSettings appSettings, ILogger<AplicationDbContext> logWriter) : BaseDbContext(appSettings)
{
    public DbSet<ClienteStatus> ClientesStatus { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<CaixaStatus> CaixasStatus { get; set; }
    public DbSet<CobrancaStatus> CobrancasStatus { get; set; }
    public DbSet<FormaPagamento> FormasPagamentos { get; set; }
    public DbSet<Socio> Socios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder);
    }
}