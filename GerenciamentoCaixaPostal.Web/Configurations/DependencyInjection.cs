using GerenciamentoCaixaPostal.Shared.Core.Interfaces;
using GerenciamentoCaixaPostal.Shared.Core.Settings;
using GerenciamentoCaixaPostal.Shared.Data.Context;
using GerenciamentoCaixaPostal.Shared.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoCaixaPostal.Web.Configurations;

public static class DependencyInjection
{
    public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
    {
        services.AddSingleton(appSettings);
        services.AddDbContext<AplicationDbContext>(options =>
        options.UseNpgsql(appSettings.Database.ConnectionString));

        services.AddControllersWithViews()
            .AddRazorRuntimeCompilation();

        services.AddScoped<ICaixaPostalRepository, CaixaPostalRepository>();
    }
}
