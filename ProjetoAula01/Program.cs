// See https://aka.ms/new-console-template for more information
using ProjetoAula01.Entities;
using ProjetoAula01.Repositories;

Console.WriteLine("\nCADASTRO DE CLIENTES:  ***\n");

//criando um objeto do tipo cliente
var cliente = new Cliente();

cliente.Id = Guid.NewGuid();
cliente.DataHoraCadastro = DateTime.Now;

Console.Write("INFORME O NOME DO CLIENTE: ");
cliente.Nome = Console.ReadLine(); 

Console.Write("INFORME O EMAIL DO CLIENTE: ");
cliente.Email = Console.ReadLine();

Console.Write("INFORME O CPF DO CLIENTE: ");
cliente.Cpf = Console.ReadLine();

var clienteRepository = new ClienteRepositoy();

//exportar os dados do cliente para arquivo
clienteRepository.ExportarDados(cliente);

Console.WriteLine("\nDADOS DO CLIENTE:");
Console.WriteLine("\tid: " + cliente.Id);
Console.WriteLine("\tnome: " + cliente.Nome);
Console.WriteLine("\temail: " + cliente.Email);
Console.WriteLine("\tcpf: " + cliente.Cpf);
Console.WriteLine("\tcadastrado em: " + cliente.DataHoraCadastro);

