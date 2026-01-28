using GerenciamentoCaixaPostal.Shared.Core.Settings;

namespace GerenciamentoCaixaPostal.Shared.Data.Context;

public class BaseDbContext(AppSettings appSettings) : Dbcontext
{
    public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (string.IsNullOrWhitespace(appSettings.Database.ConnectionString))
            throw new InvaldOperationException("Connection string não está configurada");
            
        base.OnConfiguring(optionsBuilder);
    }
}
