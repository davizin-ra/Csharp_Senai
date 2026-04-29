namespace Aula05;

class Program
{
    static void Main(string[] args)
    {


    //! Fácil


    /* -- 1
        Console.WriteLine("Digite a temperatura.");
        int temp = int.Parse(Console.ReadLine());

        if (temp < 15){
            Console.WriteLine("Está frio");
        }
        else if (temp > 25){
            Console.WriteLine("Está calor");
        }
        else{
            Console.WriteLine("Está um clima agradável");
        }
    */

    /* -- 2
        Console.WriteLine("Digite um numero maior que 100.");
        int num = int.Parse(Console.ReadLine());

        string resultado = num > 100 ? "maior" : "menor";
        Console.WriteLine($"\n{num} é {resultado} que 100");
    */

    /* -- 3
        Console.WriteLine("Digite sua senha:");
        string senha = Console.ReadLine();

        if (senha == "123"){
            Console.WriteLine("\nAcesso permitido.");
        }
        else{
            Console.WriteLine("\nAcesso negado.");
        }
    */

    /* -- 4
        Console.WriteLine("Digite um número positivo:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(num > 0 ? "\nNúmero válido." : "\nNúmero inválido.");
    */

    /* -- 5
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine(idade >= 16 ? "\nCadastro permitido." : "\nCadastro não permitido.");
    */

    /* -- 6
        Console.WriteLine("Escolha um período: \n 1 - Manhã \n 2 - Tarde \n 3 - Noite\n");
        int periodo = int.Parse(Console.ReadLine());

        switch (periodo){
            case 1:
                Console.WriteLine("\nVocê escolheu o período da manhã");
                break;
            case 2:
                Console.WriteLine("\nVocê escolheu o período da tarde");
                break;
            case 3:
                Console.WriteLine("\nVocê escolheu o período da noite");
                break;
            default:
                Console.WriteLine("\nOpção inválida");
                break;
        }
    */

    /* -- 7
        Console.WriteLine("Menu: \n 1 - Novo Jogo \n 2 - Carregar Jogo \n 3 - Sair\n");
        int menu = int.Parse(Console.ReadLine());

        switch (menu){
            case 1:
                Console.WriteLine("\nCriando novo jogo...");
                break;
            case 2:
                Console.WriteLine("\nCarregando jogo...");
                break;
            case 3:
                Console.WriteLine("\nSaindo");
                break;
            default:
                Console.WriteLine("\nOpção inválida");
                break;
        }
    */


    //! Médio


    /* -- 1
        Console.WriteLine("Digite a idade");
        int idade = int.Parse(Console.ReadLine());

        switch (idade){
            case <= 0:
                Console.WriteLine("Idade inválida");
                break;
            case <= 12:
                Console.WriteLine("\nCriança");
                break;
            case <= 17:
                Console.WriteLine("\nAdolescente");
                break;
            default:
                Console.WriteLine("\nAdulto");
                break;
        }
    */

    /* -- 2
        Console.WriteLine("Digite o primeiro número:");
        int num1 = int.Parse(Console.ReadLine());   
        Console.WriteLine("\nDigite o segundo número:");
        int num2 = int.Parse(Console.ReadLine());    

        Console.WriteLine(num1 > num2 ? $"\n{num1} é maior que {num2}" : $"\n{num2} é maior que {num1}");
    */

    /* -- 3
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());   
        Console.WriteLine("\nPossúi ingresso? (true/false):");
        bool ent = bool.Parse(Console.ReadLine());

        if (idade >= 18 || ent){
            Console.WriteLine("\nEntrada permitida.");
        }
        else{
            Console.WriteLine("\nEntrada negada.");
        }
    */

    /* -- 4
        Console.WriteLine("Digite um número de 0 a 10:");
        int num = int.Parse(Console.ReadLine()); 

        Console.WriteLine(num >= 0 && num <= 10 ? "\nValor válido." : "\nValor inválido");
    */

    /* -- 5
        Console.WriteLine("Digite o valor:");
        decimal val = decimal.Parse(Console.ReadLine());   
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade <= 0){
            Console.WriteLine("Idade inválida");
        }
        else if (idade < 18){
            Console.WriteLine("Sem desconto");
        }
        else if (idade <= 59){
            Console.WriteLine($"O valor com 10% de deconto é: {val * 0.9m}");
        }
        else{
            Console.WriteLine($"O valor com 20% de deconto é: {val * 0.8m}");
        }
    */

    /* -- 6
        Console.WriteLine("Digite o valor da compra:");
        decimal val = decimal.Parse(Console.ReadLine());

        Console.WriteLine( val < 200 ?  $"\nO valor com 5% de desconto é: {val*0.95m}" : $"\nO valor com 15% de desconto é: {val*0.85m}");
    */

    /* -- 7
        Console.WriteLine("Calculadora");
        Console.WriteLine("\nDigite o primeiro número");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo número");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEscolha uma operação: \n * \n / \n + \n - \n");
        string op = Console.ReadLine();

        switch (op){
            case "+":
                Console.WriteLine(num1 + num2);
                break;
            case "-":
                Console.WriteLine(num1 - num2);
                break;
            case "*":
                Console.WriteLine(num1 * num2);
                break;
            case "/":
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    */

    /* -- 8
        Console.WriteLine("Digite o dia da semana:");
        int dia = int.Parse(Console.ReadLine());

        if (dia > 0 && dia <= 7){
            switch(dia){
                case 1 or 7:
                    Console.WriteLine("\nFinal de semana.");
                    break;
                default:
                    Console.WriteLine("\nDia útil.");
                    break;
            }
        }
        else{
            Console.WriteLine("\nDia inválido");
        }
    */

    /* -- 9
        Console.WriteLine("Escolha um Plano:\n \n  Básico \n  Intermediáro \n  Premium \n");
        string plano = Console.ReadLine().ToLower();

        switch (plano){
            case "basico":
                Console.WriteLine("\nRecarga de 10mb feita!!");
                break;
            case "intermediario":
                Console.WriteLine("\nRecarga de 50mb feita!!");
                break;
            case "premium":
                Console.WriteLine("\nRecarga de 100mb feita!!");
                break;
            default:
                Console.WriteLine("\nPlano Inválido");
                break;
        }
    */

    //! Difícil

    /* -- 1
        Console.WriteLine("Digite sua nota:");
        double nota = double.Parse(Console.ReadLine());

        if (nota < 0 || nota > 10){
            Console.WriteLine("Nota inválida");
        }
        else if (nota >= 7){
            Console.WriteLine("Aprovado");
        }
        else if (nota >= 5 && nota < 7){
            Console.WriteLine("Recuperação");
        }
        else{
            Console.WriteLine("Reprovado");
        }
    */

    /* -- 2
        Console.WriteLine("Digite um dos lados");
        double l1 = double.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite outro dos lados");
        double l2 = double.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite outro dos lados");
        double l3 = double.Parse(Console.ReadLine());

        if(l1 > 0 && l2 > 0 && l2 > 0){
            Console.WriteLine("\nPode formar um triângulo");
        }
        else{
            Console.WriteLine("Valor inválido");
        }
    */

    /* -- 3
        Console.WriteLine("Calculadora");
        Console.WriteLine("\nDigite o primeiro número");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo número");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEscolha uma operação: \n * \n / \n + \n - \n");
        string op = Console.ReadLine();

        if (op == "*"){
            Console.WriteLine(num1 * num2);
        }
        else if (op == "+"){
            Console.WriteLine(num1 + num2);
        }
        else if (op == "-"){
            Console.WriteLine(num1 - num2);
        }
        else if (op == "/"){
            Console.WriteLine(num1 / num2);
        }
        else{
            Console.WriteLine("Operação inválida");
        }
    */

    /* -- 4
        Console.WriteLine("Digite o usuário:");
        string user = Console.ReadLine();
        Console.WriteLine("Digite sua senha:");
        string senha = Console.ReadLine();

        if (senha == "123" && user == "admin"){
            Console.WriteLine("\nAcesso permitido.");
        }
        else{
            Console.WriteLine("\nAcesso negado.");
        }
    */

    /* -- 5
        Console.WriteLine("Digite um número:");
        int num = int.Parse(Console.ReadLine());

        string resultado = num > 0 ? "Positivo" : num == 0 ? "Zero" : "Negativo";

        Console.WriteLine(resultado);
    */

    /* -- 6
        Console.WriteLine("Calculadora");
        Console.WriteLine("\nDigite o primeiro número");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo número");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEscolha uma operação: \n * \n / \n + \n - \n");
        string op = Console.ReadLine();

        switch (op){
            case "+":
                Console.WriteLine(num1 + num2);
                break;
            case "-":
                Console.WriteLine(num1 - num2);
                break;
            case "*":
                Console.WriteLine(num1 * num2);
                break;
            case "/":
                if (num1 == 0 || num1 == 0){
                    Console.WriteLine("ERRO!, não é possível a divisão por 0");
                }
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    */

    /*
        Console.WriteLine("Menu: \n 1 - Água \n 2 - Suco \n 3 - Refrigerante\n");
        int menu = int.Parse(Console.ReadLine());

        switch (menu){
            case 1:
                Console.WriteLine("\nÁgua - R$:2,00");
                break;
            case 2:
                Console.WriteLine("\nSuco - R$:4,00");
                break;
            case 3:
                Console.WriteLine("\nRefrigerante - R$:6,00");
                break;
            default:
                Console.WriteLine("\nOpção inválida");
                break;
        }
    */

    }
}
