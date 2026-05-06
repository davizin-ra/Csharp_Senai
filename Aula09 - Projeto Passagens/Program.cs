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

        while (!login.autenticado){
            Console.Clear();
            Console.WriteLine($"\nSenha incorreta, tente novamente:");
            digitado = Console.ReadLine();
            login.fazerLogin(digitado);
        }

        Console.Clear();
        Console.WriteLine($"\nBem vindo ao agendador de passagens!!");
        
        List<Passageiro> passageiros = new List<Passageiro>();

        passageiros.Add(new Passageiro("asd", "sss", "aaa", "dsd"));

        foreach (Passageiro p in passageiros){
            p.verPassageiro();
        }
    }
}
