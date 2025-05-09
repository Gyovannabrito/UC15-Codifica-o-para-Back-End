using System;
using System.Collections.Generic;

// Classe base: Pessoa
public class Pessoa
{
    public string Nome { get; set; }
    public string Documento { get; set; }

    public Pessoa(string nome, string documento)
    {
        Nome = nome;
        Documento = documento;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Documento: {Documento}");
    }
}

// Classe Cliente herda de Pessoa
public class Cliente : Pessoa
{
    public string Email { get; set; }
    public string Telefone { get; set; }

    public Cliente(string nome, string documento, string email, string telefone)
        : base(nome, documento)
    {
        Email = email;
        Telefone = telefone;
    }

    // Sobrescrita do método ExibirInfo para mostrar informações do cliente
    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Email: {Email}, Telefone: {Telefone}");
    }
}

// Classe principal para controle de clientes
public class SistemaDeClientes
{
    private List<Cliente> clientes;

    public SistemaDeClientes()
    {
        clientes = new List<Cliente>();
    }

    public void AdicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

    public void ExibirTodosClientes()
    {
        foreach (var cliente in clientes)
        {
            cliente.ExibirInfo();
            Console.WriteLine("----");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SistemaDeClientes sistema = new SistemaDeClientes();

       
        Cliente cliente1 = new Cliente("João Silva", "123456789", "joao@gmail.com", "(11) 98765-4321");
        sistema.AdicionarCliente(cliente1);

        Cliente cliente2 = new Cliente("Maria Oliveira", "987654321", "maria@gmail.com", "(21) 87654-3210");
        sistema.AdicionarCliente(cliente2);


        sistema.ExibirTodosClientes();
    }
}
