using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLanchonete.Models
{
    public abstract class Produto
    {
        public string nomeProduto { get; set;}
        private decimal precoBaseProduto;

        public decimal precoBase
        {
            get { return precoBaseProduto; }
            set
            {
                if (value >= 0m)
                {
                    precoBaseProduto = value;
                }
                else
                {
                    precoBaseProduto = 0;
                }
            }
        }

        public Produto(string nome, decimal precoBase)
        {
            nomeProduto = nome;
            precoBaseProduto = precoBase;
        }

        public abstract decimal calcularPrecoFinal();

        public virtual void exibirResultado()
        {
            Console.WriteLine($"Produto: {nomeProduto}");
            Console.WriteLine($"Preço final: R$:{calcularPrecoFinal():f2}");
        }
    }
}