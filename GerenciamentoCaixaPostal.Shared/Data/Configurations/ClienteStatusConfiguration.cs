using GerenciamentoCaixaPostal.Core.Shared.Models;
using GerenciamentoCaixaPostal.Shared.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoCaixaPostal.Shared.Data.Configurations;

public class ClienteStatusConfiguration : IEntityTypeConfiguration<ClienteStatus>
{
    public void Configure(EntityTypeBuilder<ClienteStatus> builder)
    {
        builder.ToTable("ClientesStatus");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        builder.Property(x => x.Nome).IsRequired();
    }
}