using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete.Models
{
    public class Bebida : Produto
    {
        public Bebida(string nomeProduto, decimal precoBase) : base(nomeProduto, precoBase) { }

        public override decimal calcularPrecoFinal()
        {
            return precoBase;
        }

        public override void exibirResultado(){
            Console.WriteLine($"Tipo: Bebida");
            base.exibirResultado();
            Console.WriteLine();
        }
    }
}