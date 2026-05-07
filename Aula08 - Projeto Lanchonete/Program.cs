using System;
using System.Collections.Generic;
using ProjetoLanchonete.Models;

namespace ProjetoLanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Produto> pedido = new List<Produto>();

            pedido.Add(new Lanche("X-Salada", 16m));
            pedido.Add(new Bebida("Água", 2m));
            pedido.Add(new Sobremesa("Pudim", 8m));

            Console.Clear();
            Console.WriteLine("\n\n========== Resumo Pedido ==========\n\n");

            decimal total = 0;

            foreach (Produto produto in pedido)
            {
                produto.exibirResultado();
                total += produto.calcularPrecoFinal();
            }

            Console.WriteLine($"Total do pedido:\nR$: {total:f2}");
        }
    }
}
