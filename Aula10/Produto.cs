using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete
{
    public abstract class Produto
    {
        public string nome { get; set; }
        public decimal precoBase { get; set; }

        public abstract void calcularPrecoFinal();,
        

        public void exibirResultado()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço final: ");
        }
    }
}