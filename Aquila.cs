using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    public class Aquila : Animale, IVolante
    {

        public override void Verso(int nrVolte)
        {
            for (int i = 0; i < nrVolte; i++)
                Console.WriteLine("Iiiii");
        }

        public override void Mangia()
        {
            Console.WriteLine("Coniglio");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!");
        }

    }
}