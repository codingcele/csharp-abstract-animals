using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    internal class Cane : Animale
    {

        public override void Verso(int nrVolte)
        {
            for (int i = 0; i < nrVolte; i++)
                Console.WriteLine("Bau");
        }

        public override void Mangia()
        {
            Console.WriteLine("Osso");
        }

    }
}