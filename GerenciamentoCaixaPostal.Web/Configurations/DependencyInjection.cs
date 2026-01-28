using GerenciamentoCaixaPostal.Shared.Core.Settings;

namespace GerenciamentoCaixaPostal.Web.Configurations;

public static class DependencyInjection
{
    public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
    {
        services.AddSingleton(appSettings);
        services.AddControllersWithViews()
            .AddRazorRuntimeCompilation();
    } 
}