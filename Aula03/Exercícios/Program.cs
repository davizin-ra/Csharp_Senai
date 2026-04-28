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

    /* -- 6
        Console.WriteLine("Digite a primeira nota");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota");
        double num2 = double.Parse(Console.ReadLine());

        double media = (num1 + num2) / 2;

        Console.WriteLine($"A média das suas notas é: {media}");
        Console.WriteLine($"Aprovado: {(media) >= 6}");
    */

    /* -- 7
        Console.WriteLine("Digite um número");
        double num = double.Parse(Console.ReadLine());
        bool intvl = (50 < num) && (num < 100);

        Console.WriteLine("Está entre 50 e 100: " + intvl);
    */

    /* -- 8
        Console.WriteLine("Digite o valor");
        decimal val = decimal.Parse(Console.ReadLine());
        decimal valFin = val * (90M/100M);

        Console.WriteLine($"valor com desconto: {valFin}");
    */

    /* -- 9
        Console.WriteLine("Digite um numero:");
        double num = double.Parse(Console.ReadLine());

        Console.WriteLine($"Negativo {num < 0}");
        Console.WriteLine($"Positivo {num > 0}");
        Console.WriteLine($"Zero {num == 0}");
    */

    /* -- 10
        Console.WriteLine("Digite sua idade");
        double idade = double.Parse(Console.ReadLine());

        Console.WriteLine($"Pode votar: {idade >= 16}");
    */

    /* -- 11
        Console.WriteLine("Digite o usuario");
        string usuario = Console.ReadLine();
        Console.WriteLine("Digite a senha");
        double senha = double.Parse(Console.ReadLine());

        Console.WriteLine($"Usuário correto: {usuario == "admin" && senha == 1234}");
    */

    /* -- 12
        Console.WriteLine("Digite um número");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número");
        double num3 = double.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} é o maior número? {num1 > num2 && num1 > num3}");
        Console.WriteLine($"{num2} é o maior número? {num2 > num1 && num2 > num3}");
        Console.WriteLine($"{num2} é o maior número? {num3 > num1 && num3 > num2}");
        Console.WriteLine($"Os números são iguais? {num3 == num1 && num3 == num2}");
    */

    /* -- 14
        Console.WriteLine("Digite o salário");
        decimal salario = decimal.Parse(Console.ReadLine());

        decimal salal10 = salario * 1.10M;
        decimal salal20 = salario * 1.20M;

        Console.WriteLine($"Salário com 10%: {salal10}, ativo: {salario > 2000M}");
        Console.WriteLine($"Salário com 20%: {salal20}, ativo: {salario <= 2000M}");
    */

    /* -- 15
        Console.WriteLine("Digite o ano bissexto");
        double ano = double.Parse(Console.ReadLine);

        Console.WriteLine($"O ano é bissexto: {ano % 4 == 0}");
    */

    /* -- 16
        Console.WriteLine("Digite sua idade");
        double idade = double.Parse(Console.ReadLine());

        Console.WriteLine("Possúi convite?");
        bool convite = bool.Parse(Console.ReadLine());

        Console.WriteLine($"Acesso: {idade >= 18 && convite}");
    */

    }
}
