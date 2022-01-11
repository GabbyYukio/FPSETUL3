using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class rotire_stanga:indexare_vector
    {
        public rotire_stanga()
        {
            rotire_stanga(Lungime, vector);
            Console.WriteLine("Elementele dupa rotire spre stanga sunt" );
            afisare_elemente(Lungime,vector);
            UI.run();
        }
    }
    class Problema8
    {
        public static void rezolvare()
        {
            rotire_stanga solutie = new rotire_stanga();

        }
    }
}
