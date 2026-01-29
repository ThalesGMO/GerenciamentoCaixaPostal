using GerenciamentoCaixaPostal.Core.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoCaixaPostal.Shared.Data.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().IsRequired();
        builder.Property(x => x.Nome);
        builder.Property(x => x.Email);
        builder.Property(x => x.Telefone);
        builder.Property(x => x.IdClienteStatus);

        builder.HasOne(x => x.ClienteStatus)
            .WithMany(x => x.Clientes)
            .HasForeignKey(x => x.IdClienteStatus)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

