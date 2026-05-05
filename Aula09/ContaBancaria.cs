using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09
{
    public class ContaBancaria
    {
        private decimal saldo = 20.53m;

        public void Sacar(decimal valor){
            if(valor <= saldo){
                saldo -= valor;
            }else{
                Console.WriteLine($"Saldo insuficiente!!");
                
            }
        }

        public void MostrarSaldo(){
            Console.WriteLine($"Saldo: {saldo}");
            
        }
    }
}