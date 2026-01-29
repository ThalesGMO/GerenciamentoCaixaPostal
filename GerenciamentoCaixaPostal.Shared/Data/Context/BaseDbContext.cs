using GerenciamentoCaixaPostal.Shared.Core.Settings;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoCaixaPostal.Shared.Data.Context;

public class BaseDbContext(AppSettings appSettings) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (string.IsNullOrWhiteSpace(appSettings.Database.ConnectionString))
            throw new InvalidOperationException("Connection string não está configurada");
            
        optionsBuilder.UseNpgsql(appSettings.Database.ConnectionString, options =>
        {
            options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        });

        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution);

        base.OnConfiguring(optionsBuilder);
    }
}
