using GerenciamentoCaixaPostal.Core.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoCaixaPostal.Shared.Data.Configurations;

public class CaixaPostalConfiguration : IEntityTypeConfiguration<CaixaPostal>
{
    public void Configure(EntityTypeBuilder<CaixaPostal> builder)
    {
        builder.ToTable("CaixasPostais");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.IdSocio).IsRequired();
        builder.Property(x => x.IdCliente).IsRequired();
        builder.Property(x => x.IdStatusCaixa).IsRequired();
        builder.Property(x => x.Codigo).IsRequired();
        builder.Property(x => x.CpfCnpj).IsRequired().HasMaxLength(14);
        builder.Property(x => x.DataAluguel).IsRequired();
        builder.Property(x => x.DiaVencimento).IsRequired();
       
        builder.HasOne(x => x.Cliente)
            .WithMany(x => x.CaixasPostais)
            .HasForeignKey(x => x.IdCliente);

        builder.HasOne(x => x.Socio)
            .WithMany(x => x.CaixasPostais)
            .HasForeignKey(x => x.IdSocio);

        builder.HasOne(x => x.CaixaStatus)
            .WithMany(x => x.CaixasPostais)
            .HasForeignKey(x => x.IdStatusCaixa);
    }
}