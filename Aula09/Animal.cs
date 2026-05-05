using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09
{
    public abstract class Animal
    {
        public string nome; public int idade; public string raca; public string cor;

        public virtual void emitirSom()
        {
            Console.WriteLine($"O animal faz um som");

        }

        public void mostratDados(){
            Console.WriteLine($"\nO animal {nome}, tem {idade} anos");
        }

        public abstract void comer();
    }
}