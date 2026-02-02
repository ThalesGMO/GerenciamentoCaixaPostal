using GerenciamentoCaixaPostal.Shared.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoCaixaPostal.Shared.Data.Configurations;

public class CobrancaStatusConfiguration : IEntityTypeConfiguration<CobrancaStatus>
{
    public void Configure(EntityTypeBuilder<CobrancaStatus> builder)
    {
        builder.ToTable("CobrancasStatus");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.Nome).IsRequired();
    }
}