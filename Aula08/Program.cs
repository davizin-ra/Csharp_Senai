namespace Aula08;

class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro();   

        meuCarro.Marca = "Toyota";
        meuCarro.Modelo = "Corolla";
        meuCarro.Ano = 2022;

        meuCarro.ExibirInformacoes();

        Moto minhaMoto = new Moto();

        minhaMoto.Marca = "Honda";
        minhaMoto.Ano = 2021;
        minhaMoto.TemPartidaEletrica = true;

        minhaMoto.ExibirDetalhesMoto();
    }
}
