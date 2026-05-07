using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09___Projeto_Passagens.models
{
    public class Passageiro
    {
        public string nomeViagem;
        public string origemViagem;
        public string destinoViagem;
        public string dataViagem;

    public Passageiro(string nome, string origem, string destino, string data){
        nomeViagem = nome;
        origemViagem = origem;
        destinoViagem = destino;
        dataViagem = data;
    }

    public void verPassageiro(){
        Console.WriteLine($"Nome: {nomeViagem} \nOrigem: {origemViagem} \nDestino: {destinoViagem} \nData: {dataViagem}");
        
    }
    }
}