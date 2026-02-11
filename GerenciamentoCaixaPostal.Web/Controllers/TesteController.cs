using Microsoft.AspNetCore.Mvc;
using GerenciamentoCaixaPostal.Shared.Core.Interfaces;
using GerenciamentoCaixaPostal.Shared.Data.Context;
using GerenciamentoCaixaPostal.Core.Shared.Models;
using GerenciamentoCaixaPostal.Shared.Core.Models;

public class TesteController : Controller
{
    private readonly ICaixaPostalRepository _repositorio;
    private readonly AplicationDbContext _context;

    public TesteController(ICaixaPostalRepository repo, AplicationDbContext context)
    {
        _repositorio = repo;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var dados = await _repositorio.ObterTodosAsync();
        return Json(dados);
    }

    [HttpGet]
    public async Task<IActionResult> CriarCliente()
    {

        var cliente = new Cliente
        {
            Nome = "Cliente Teste da Silva",
            Email = "SexoUchiha@gmail.com",
            IdClienteStatus = 1

        };

        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync(); 

        return Content($"Sucesso! Cliente criado");
    }
}
