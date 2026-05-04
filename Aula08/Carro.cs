using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula08
{
    public class Carro : Veiculo
    {
        public string Modelo;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}