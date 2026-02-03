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
    }
}