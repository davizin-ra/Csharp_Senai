using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09
{
    public class Gato : Animal
    {
        public override void comer()
        {
            Console.WriteLine($"Comeu sachê!!");
        }

        public override void emitirSom()
        {
            Console.WriteLine($"Miau");
        }
    }
}