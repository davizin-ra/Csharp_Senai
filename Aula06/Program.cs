namespace Aula06;

class Program
{
    static void Main(string[] args)
    {

    //! Fácil

    /* -- 1
        for (int i = 1; i <= 10; i++){
            Console.WriteLine(i);
        }
    */

    /* -- 2
        for (int i = 10; i >= 0; i--){
            Console.WriteLine(i);
        }
    */

    /* -- 3
        Console.WriteLine("Digite um número");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++){
            Console.WriteLine(i * num);
        }
    */

    /* -- 4
        int num = 1;

        while (num <= 5){
            Console.WriteLine(num);
            num++;
        }
    */

    /* -- 5
        int soma = 0;

        for(int i = 0; i <= 5; i++){
            soma += i;
        }

        Console.WriteLine("Soma: " + soma);
    */

    //! Médio

    /* -- 1
        int soma = 0;

        for(int i = 1; i <= 5; i++){
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());

            soma += num;
        }

        Console.WriteLine("Soma: " + soma);
    */

    /* -- 2
        for(int i = 0; i <= 20; i += 2){
            Console.WriteLine(i);
        }
    */

    /* -- 3
        Console.WriteLine("Digite a senha");
        string senha = Console.ReadLine();

        while(senha != "1234"){
            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();
        }
    */

    /* -- 4
        Console.WriteLine("1 - Ver mensagem \n2 - Sair");
        string opcao = Console.ReadLine();

        do {
            Console.WriteLine("\nMensagem!!\n");
            Console.WriteLine("1 - Ver mensagem \n2 - Sair\n");
            opcao = Console.ReadLine();
        }
        while(opcao != "2");
        Console.WriteLine("Você saiu");
    */

    /* -- 5
        int soma = 0;

        for(int i = 1; i <= 4; i++){
            Console.WriteLine("Digite um valor");
            int num = int.Parse(Console.ReadLine());

            soma += num;
        }

        Console.WriteLine("Média: " + soma/4);
    */

    //! Difícil

    /* -- 1
        int maior = 0;

        for(int i = 1; i <= 5; i++){
            Console.WriteLine("\nDigite um valor positivo");
            int num = int.Parse(Console.ReadLine());

            if(num > maior){
                maior = num;
            }
            else if(num < 0){
                Console.WriteLine("\nNúmero inválido");
            }
        }
        Console.WriteLine("\nO maior número é: " + maior);
    */

    /* -- 2
        int contador = 0;

        Console.WriteLine("Digite 0");
        string num = Console.ReadLine();

        while(num != "0"){
            Console.WriteLine("\nDigite 0");
            num = Console.ReadLine();
            contador ++;
        }

        Console.WriteLine($"\nVocê errou {contador} vezes.");
    */

        int soma = 0;

        Console.WriteLine("Digite um número positivo");
        int num = int.Parse(Console.ReadLine());

        while(num >= 0){
            Console.WriteLine("Digite um número positivo");
            num = int.Parse(Console.ReadLine());
            soma = soma + num;
        }

        Console.WriteLine($"\nProcesso finalizado, você digitou um número negativo.");
        Console.WriteLine($"\nSoma: {soma}");

    }
}

