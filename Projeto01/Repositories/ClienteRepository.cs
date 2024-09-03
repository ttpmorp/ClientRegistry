using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Repositories
{
    // Classe para exercer o papel de repositório de dados de cliente
    public class ClienteRepository
    {
        // Método (função) para receber os dados de um objeto cliente
        // e gravá-los em um arquivo de extensão .txt
        public void GravarArquivo(Cliente cliente)
        {
            // Definindo o nome do arquivo
            var path = $@"C:\temp\cliente_{cliente.Id}.txt";

            // Obtendo o diretório do caminho do arquivo
            var directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Usando a diretiva 'using' para garantir que o StreamWriter seja fechado corretamente
            using (var streamWriter = new StreamWriter(path))
            {
                // Escrevendo o conteúdo do arquivo
                streamWriter.WriteLine($"ID: {cliente.Id}");
                streamWriter.WriteLine($"NOME: {cliente.Name}");
                streamWriter.WriteLine($"CPF: {cliente.Cpf}");
                streamWriter.WriteLine($"EMAIL: {cliente.Email}");
                streamWriter.WriteLine($"DATA DE NASCIMENTO: {cliente.DataNascimento}");

                //salvando e fechando o arquivo
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
    }
}
