using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete.Models
{
    public class Lanche : Produto
    {
        private decimal taxaEmbalagem = 2m;

        public Lanche(string nomeProduto, decimal precoBase) : base(nomeProduto, precoBase){}

        public override decimal calcularPrecoFinal(){
            return precoBase + taxaEmbalagem;
        }

        public override void exibirResultado(){
            Console.WriteLine($"Tipo: Lanche");
            base.exibirResultado();
            Console.WriteLine($"");
        }
    }
}