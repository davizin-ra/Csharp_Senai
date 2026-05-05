using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09
{
    public class Cachorro:Animal
    {

        public override void comer()
        {
            Console.WriteLine($"Comeu ração!!");
        }
        public override void emitirSom()
        {
            Console.WriteLine($"Au au");
        }

    }
}