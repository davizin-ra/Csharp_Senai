namespace Aula07;

class Program
{
    static void Main(string[] args)
    {

    /* -- 1
        string frase = "Estou aprendendo C# no senai de sao caetano";
        int tamanho1 = frase.Length;
        frase = frase.Replace("a", "");
        int tamanho2 = frase.Length;

        int total = tamanho1 - tamanho2;


        Console.WriteLine(total);
    */

    /* -- 2
        string[] nomes = {"Davi", "Iago", "Vinicius"};

        Console.WriteLine(string.Join(", ", nomes));
        Array.Reverse(nomes);
        Console.WriteLine();
        foreach(string n in nomes){
            Console.WriteLine(n);
        }
    */



        static void funcaoRepeat(string a, int b){
            for (int i = 0; i < b; ++i){
                Console.WriteLine(a);
            }
        }

        Console.WriteLine("Digite uma palavra");
        string e1 = Console.ReadLine();
        Console.WriteLine("Quer repetir quantas vezes?");
        int e2 = int.Parse(Console.ReadLine());

        funcaoRepeat(e1, e2);

    }
}
