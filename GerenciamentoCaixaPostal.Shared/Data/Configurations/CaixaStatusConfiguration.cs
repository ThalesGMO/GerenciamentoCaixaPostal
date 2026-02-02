using GerenciamentoCaixaPostal.Shared.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoCaixaPostal.Shared.Data.Configurations;

public class CaixaStatusConfiguration : IEntityTypeConfiguration<CaixaStatus>
{
    public void Configure(EntityTypeBuilder<CaixaStatus> builder)
    {
        builder.ToTable("CaixasStatus");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.Nome).IsRequired();
    }
}