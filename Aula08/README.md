# Programação Orientada a Objeto

## Classe (Carro.cs)

Atributos

    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

Metodos

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }

### Chamando (main)

Instanciando

    Carro meuCarro = newCarro();

Definindo valores

    meuCarro.Marca = "Toyota";
    meuCarro.Modelo = "Corolla";
    meuCarro.Ano = 2022;

Chamando método

    meuCarro.ExibirInformacoes();

## Molde (Classe pai)

### Classe base

    public class Veiculo
    {
        public string Marca;
        public int Ano;

        public void ExibirDetalhes(){
            Console.WriteLine($"Veiculo: {Marca}, Ano: {Ano}");
        }
    }

### Chamando na classe filha

    public class Moto : Veiculo
    {
        public bool TemPartidaEletrica;

        public void ExibirDetalhesMoto(){
            ExibirDetalhes(); // Método herdado de veículo
            Console.WriteLine($"Partida elétrica: {TemPartidaEletrica}");
        }
    }

### Program

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