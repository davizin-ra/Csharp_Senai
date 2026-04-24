namespace Aula03;

class Program
{
    static void Main(string[] args)
    {

        /* -- 1
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());
            int db = num*2;
            Console.WriteLine($"O dobro de {num} é {db}");
        */

        /* -- 2
            Console.WriteLine("Digite um número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double num2 = double.Parse(Console.ReadLine());
            double sm = num1 + num2;

            Console.WriteLine($"A soma desses números é: {sm}");
        */

        /* -- 3
            Console.WriteLine("Digite um número");
            double num = double.Parse(Console.ReadLine());
            bool par = num % 2 == 0;
            Console.WriteLine($"{num} é par? {par}");
        */

        
        /* -- 4
            Console.WriteLine("Digite um número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            double num2 = double.Parse(Console.ReadLine());

            bool mr = num1 > num2;
            Console.WriteLine($"{num1} é o maior número? {mr}");
        */

        /* -- 5
            Console.WriteLine("Digite sua idade");
            double idade = double.Parse(Console.ReadLine());

            bool maiorDeIdade = idade >= 18;
            bool menorDeIdade = idade < 18;

            Console.WriteLine("Maior de idade: " + maiorDeIdade);
            Console.WriteLine("Menor de idade: " + menorDeIdade);
        */
    }
}
