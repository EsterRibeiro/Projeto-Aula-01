
using ProjetoAula01.Entities;

namespace ProjetoAula01.Repositories;
public class ClienteRepositoy
{
    public void ExportarDados(Cliente cliente)
    {
        var streamWriter = new StreamWriter(@"c:\temp\clientes.txt", true);

        streamWriter.WriteLine("id" + cliente.Id);
        streamWriter.WriteLine("nome" + cliente.Nome);
        streamWriter.WriteLine("email" + cliente.Email);
        streamWriter.WriteLine("cpf" + cliente.Cpf);
        streamWriter.WriteLine("cadastrado em" + cliente.DataHoraCadastro);
 
        streamWriter.Close();
    }
}
