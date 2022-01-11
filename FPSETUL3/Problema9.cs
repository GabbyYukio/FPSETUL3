using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class rotire_stanga_de_k:indexare_vector
    {
        public rotire_stanga_de_k(int k)
        {
            int copie = k;
            while (k > 0)
            {
                rotire_stanga(Lungime, vector);
                k--;
            }
            Console.WriteLine("Vectorul dupa {0} rotiri: ");
            afisare_elemente(Lungime, vector);
            UI.run();
        }
    }
    class Problema9
    {
        public static void rezolvare()
        {
            Console.WriteLine("Dati valoarea de cate ori doriti sa rotiti vectorul spre stanga: ");
            Console.WriteLine(">>> ");
            rotire_stanga_de_k solutie = new rotire_stanga_de_k(int.Parse(Console.ReadLine()));
        }
    }
}
