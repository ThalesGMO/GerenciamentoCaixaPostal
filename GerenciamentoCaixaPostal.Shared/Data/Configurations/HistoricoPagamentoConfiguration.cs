using GerenciamentoCaixaPostal.Shared.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoCaixaPostal.Shared.Data.Configurations;

public class HistoricoPagamentoConfiguration : IEntityTypeConfiguration<HistoricoPagamento>
{
    public void Configure(EntityTypeBuilder<HistoricoPagamento> builder)
    {
        builder.ToTable("HistoricosPagamento");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
        builder.Property(x => x.IdFormaPagamento).IsRequired();
        builder.Property(x => x.IdCobranca).IsRequired();
        builder.Property(x => x.DataPagamento).IsRequired();
        builder.Property(x => x.ValorPago).IsRequired();
        builder.Property(x => x.Observacao);

        builder.HasOne(x => x.Cobranca)
            .WithMany(x => x.historicoPagamentos)
            .HasForeignKey(x => x.IdCobranca);
        
        builder.HasOne(x => x.FormaPagamento)
            .WithMany(x => x.historicoPagamentos)
            .HasForeignKey(x => x.IdFormaPagamento);
    }
}