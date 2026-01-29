namespace GerenciamentoCaixaPostal.Core.Shared.Models;

public class Cliente
{
    public int Id { get; }
    public int IdClienteStatus { get; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }
}