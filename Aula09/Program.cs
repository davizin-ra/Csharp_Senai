namespace Aula09;

class Program
{
    static void Main(string[] args)
    {

        // ContaBancaria conta = new ContaBancaria();
        
        // conta.Sacar(20);
        // conta.MostrarSaldo();

        Cachorro cachorro = new Cachorro();
        cachorro.nome = "Rebeca";
        cachorro.idade = 13;
        cachorro.raca = "Yorkshire";
        cachorro.cor = "Preto";

        cachorro.mostratDados();
        cachorro.emitirSom();

        Gato gato = new Gato();
        gato.nome = "Nena";
        gato.idade = 5;
        gato.raca = "Gato";
        gato.cor = "Amarelo";

        gato.mostratDados();
        gato.emitirSom();

        gato.comer();
        cachorro.comer();

        
    }
}
