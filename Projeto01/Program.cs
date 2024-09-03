// Definir o namespace da classe (localização)
using Projeto01.Entities;
using Projeto01.Repositories;
using System.Windows.Markup;

namespace Projeto01
{
    // Declaração da classe
    public class Program
    {
        // Método para execução / inicialização do projeto
        public static void Main(string[] args)
        {
            // Imprimir mensagem (console do DOS)
            Console.WriteLine("\n *** CADASTRO DE CLIENTE *** \n");

            // criando um objeo da classe Cliente (variável de instância)
            var cliente = new Cliente();

            // Preenchendo os dados dos clientes
            cliente.Id = Guid.NewGuid();

            try // tentativa
            {
                Console.Write("Informe o nome do cliente: ");
                cliente.Name = Console.ReadLine();

                Console.Write("Informe o CPF do cliente: ");
                cliente.Cpf = Console.ReadLine();

                Console.Write("Informe o Email do cliente: ");
                cliente.Email = Console.ReadLine();

                Console.Write("Informe a data de nascimento do cliente: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());


                // criando um objeto (variável deinstancia) para a classe ClienteRepository
                var clienteRepository = new ClienteRepository();

                //executar a gravação do arquivo
                clienteRepository.GravarArquivo(cliente);


                //imprimindo os campos atalhos
                //cw -> tab tab
                Console.WriteLine("\n CLIENTE CADASTRADO COM SUCESSO! \n");
                Console.WriteLine($"Id do cliente: {cliente.Id}");
                Console.WriteLine($"Nome: {cliente.Name}");
                Console.WriteLine($"Email: {cliente.Email}");
                Console.WriteLine($"CPF: {cliente.Cpf}");
                Console.WriteLine($"Data de nascimento: {cliente.DataNascimento}");


            }
            catch (Exception e) //captura a exceçao(erro)
            {

                Console.WriteLine("\n FALHA AO CADASTRAR O CLIENTE");
                Console.WriteLine($"ERRO: {e.Message}");


            }
           

            // Pausar o prompt de comandos
            Console.ReadKey();
        }
    }
}
