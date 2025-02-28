namespace LHPet.Models;


public class Cliente
{
    public int id {get; set;}
    public string? Nome {get; set;}
    public string? cpf {get; set;}
    public string? email{get; set;}
    public string? paciente{get; set;}
    public Cliente(int id, string Nome, string cpf, string email, string paciente)
    {
       this.id = id;
       this.Nome = Nome;
       this.cpf = cpf;
       this.email = email;
       this.paciente = paciente; 
    }
}