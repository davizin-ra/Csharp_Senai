# Funções

## Função sem parâmetro e retorno

    static void MostrarMensagem(){
        Console.WriteLine("Olá mundo");
    }

    MostrarMensagem();

## Função com paramâtro

    static void Saudacao(string nome){
        Console.WriteLine($"Olá, {nome}");
    }

    Saudacao("davizin");

## Função com retorno

    static int Somar (int a, int b){
        int soma = a + b;
        return(soma);
    }

    Console.WriteLine(Somar(1, 2));

# Arrays

#### Armazena vários valores do mesmo tipo em uma única variável.

Criando a lista

    int[] numeros = new int[3];

Adicionando nas posições

    numeros[0] = 2;
    numeros[1] = 5;
    numeros[2] = 8;

Exibindo

    Console.WriteLine(numeros[2]);

<div/>

    Console.WriteLine(string.Join(", ", numeros));

### Funções do C#

Ver tamanho

    int tamanho = numeros.Length;

Ler lista completa

    Console.WriteLine(string.Join(", ", numeros));

# Função + Array

    static double CalcularMedia(double[] notas){
        double soma = 0;

        for(int i = 0; i < notas.Length; i++){
            soma += notas[i];
        }

        return soma / notas.Length;
    }

<div/>

    double[] lista = {1, 2, 3, 4, 5};

    double media = CalcularMedia(lista);
    Console.WriteLine($"Média: {media}");
