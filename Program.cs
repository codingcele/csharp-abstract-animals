using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Animale pitbull, aquila, delfino;

            Cane pitbull = new Cane();
            pitbull.Dormi();
            pitbull.Mangia();
            pitbull.Verso(2);
;
            Aquila aquila = new Aquila();
            aquila.Dormi();
            aquila.Mangia();
            aquila.Verso(1);

            Delfino delfino = new Delfino();
            delfino.Dormi();
            delfino.Mangia();
            delfino.Verso(6);


            static void FaiVolare(IVolante animale)
            {
                animale.Vola();
            }

            static void FaiNuotare(INuotante animale)
            {
                animale.Nuota();
            }

            FaiVolare(aquila);

            FaiNuotare(delfino);

        }
    }
}