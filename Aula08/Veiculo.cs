using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula08
{
    public class Veiculo
    {
        public string Marca;
        public int Ano;

        public void ExibirDetalhes(){
            Console.WriteLine($"Veiculo: {Marca}, Ano: {Ano}");
        }
    }
}