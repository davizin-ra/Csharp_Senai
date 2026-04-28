# IF / Else

        Console.WriteLine("Digite um número:");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0){
            Console.WriteLine($"\n{num} é par");
        }
        else{
            Console.WriteLine($"\n{num} é impar");
        }

### Ou

        string resultado = num % 2 == 0 ? "Par" : "Impar";
        Console.WriteLine(resultado);


# Switch case

        Console.WriteLine("Digite um de 1 a 3:");
        int num = int.Parse(Console.ReadLine());

        switch(num){
            case 1:
                Console.WriteLine("Você escolheu a opção 1.");
                break;
                
            case 2:
                Console.WriteLine("Você escolheu a opção 2.");
                break;

            case 3:
                Console.WriteLine("Você escolheu a opção 3.");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }