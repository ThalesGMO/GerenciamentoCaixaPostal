using GerenciamentoCaixaPostal.Shared.Core.Settings;
using GerenciamentoCaixaPostal.Web.Configurations;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var appSettings = builder.
    Configuration.
    AddEnvironmentVariables()
    .Build()
    .Get<AppSettings>();

builder.Services.AddDependencies(appSettings);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

await app.RunAsync();
