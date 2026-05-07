using Aula09___Projeto_Passagens.models.auth;
using Aula09___Projeto_Passagens.models;

namespace Aula09___Projeto_Passagens;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Login login = new Login();
        Console.WriteLine($"\nDigita a sua senha:");
        string digitado = Console.ReadLine();

        login.fazerLogin(digitado);
        login.verAutenticacao();


        Console.Clear();
        Console.WriteLine($"\nBem vindo ao agendador de passagens!!");

        string opcao = "";
        List<Passageiro> passageiros = new List<Passageiro>();

        while (opcao != "3")
        {
            Console.WriteLine($"\nSelecione uma opção: \n 1 - Listar Viagens \n 2 - Cadastrar nova Viagem \n 3 - Sair\n");
            opcao = Console.ReadLine();
            Console.WriteLine($"");

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"Listando Viagens: \n");
                    foreach (Passageiro p in passageiros)
                    {
                        p.verPassageiro();
                    }
                    break;
                case "2":
                    Console.WriteLine($"Cadastro de viagens:");
                    Console.WriteLine($"\nDigite seu nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"\nDigite sua origem:");
                    string origem = Console.ReadLine();
                    Console.WriteLine($"\nDigite seu destino:");
                    string destino = Console.ReadLine();
                    Console.WriteLine($"\nDigite a data:");
                    string data = Console.ReadLine();
                    passageiros.Add(new Passageiro(nome, origem, destino, data));
                    
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine($"Opção inválida");
                    break;
            }
        }
        Console.WriteLine($"Saindo...");

    }
}
