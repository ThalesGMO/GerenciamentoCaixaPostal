using GerenciamentoCaixaPostal.Shared.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoCaixaPostal.Shared.Data.Configurations;

public class CobrancaConfiguration : IEntityTypeConfiguration<Cobranca>
{
    public void Configure(EntityTypeBuilder<Cobranca> builder)
    {
        builder.ToTable("Cobrancas");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
        builder.Property(x => x.IdCaixaPostal).IsRequired();
        builder.Property(x => x.IdCobrancaStatus).IsRequired();
        builder.Property(x => x.DataLiquidacao).IsRequired();
        builder.Property(x => x.DataVencimento).IsRequired();
        builder.Property(x => x.Valor).IsRequired();

        builder.HasOne(x => x.CaixaPostal)
            .WithMany(x => x.Cobrancas)
            .HasForeignKey(x => x.IdCaixaPostal);

        builder.HasOne(x => x.CobrancaStatus)
            .WithMany(x => x.Cobrancas)
            .HasForeignKey(x => x.IdCobrancaStatus);
    }
}
