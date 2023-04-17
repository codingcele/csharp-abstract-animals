using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    public class Delfino : Animale, INuotante
    {

        public override void Verso(int nrVolte)
        {
            for (int i = 0; i < nrVolte; i++)
                Console.WriteLine("Tctctctc");
        }

        public override void Mangia()
        {
            Console.WriteLine("Pesce");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }

    }
}