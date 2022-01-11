using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class reversare_elemente:indexare_vector
    {
        public reversare_elemente()
        {
            for (int i = 0; i < Lungime / 2; i++)
            {
                vector[i] = vector[i] + vector[Lungime -1- i];
                vector[Lungime -1-i] = vector[i] - vector[Lungime-1 - i];
                vector[i] = vector[i]-vector[Lungime-1 - i];
            }
            Console.WriteLine("Elementele dupa inversare: ");
            afisare_elemente(Lungime, vector);
            UI.run();
        }
    }
    class Problema7
    {
        public static void rezolvare()
        {
            reversare_elemente solutie=new reversare_elemente();
        }
    }
}
