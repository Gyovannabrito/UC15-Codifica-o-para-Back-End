namespace  LHPet.Models;

public class Fornecedor
{
    public int id {get; set;}
    public string? Nome {get; set;}
    public string? cnpj {get; set;}
    public string? Email {get; set;}

    public Fornecedor(int id, string Nome, string cnpj, string Email)
    {
        this.id = id;
        this.Nome = Nome;
        this.cnpj = cnpj;
        this.Email = Email;       
    }
}