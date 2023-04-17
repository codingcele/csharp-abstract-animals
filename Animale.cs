using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    public abstract class Animale
    {

        public void dormi()
        {
            Console.WriteLine("ZZZZZ");
        }

        public abstract void Verso(int nrVolte);

        public abstract void Mangia();


    }
}
