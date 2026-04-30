https://sparkling-link-662.notion.site/Exerc-cios-de-Repeti-o-35116837961280569be4defa4eca8e8a

# Estruturas de repetição

## For

    for (int i = 1; i <= 5; i++){
        Console.WriteLine(i);
    }

## While

    int contador = 1;

    while (contador <= 5){
        Console.WriteLine(contador);
        contador++;
    }

### Do/While

    int num = 5;

    do{
        Console.WriteLine("Digite um número");
        num = int.Parse(Console.ReadLine());
    }
    while (num <= 0);

## Foreach

    string[] nomes = {"Da", "Go", "Lu", "Pe", "Cin", "Wes" };

    foreach(string nome in nomes){
        Console.WriteLine(nome);
    }
