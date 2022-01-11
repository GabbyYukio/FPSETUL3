using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class stergere_k : indexare_vector
    {
        public stergere_k(int k)
        {
            while(k<0)
            {
                Console.WriteLine("Pozitie invalida. Incercati din nou: ");
                Console.Write(">>> ");
                k = int.Parse(Console.ReadLine());
            }
            while(k>Lungime)
            {
                Console.WriteLine("Pozitie invalida. Incercati din nou: ");
                Console.Write(">>> ");
                k = int.Parse(Console.ReadLine());
            }
            for (int i = k; i < Lungime - 1; i++)
                vector[i] = vector[i + 1];
            Lungime--;
            afisare_elemente(Lungime, vector);

        }
    }
    class Problema6
    {
        public static void rezolvare()
        {
            Console.WriteLine("Dati valoarea pozitiei pe care doriti sa stergeti elementul din vector");
            Console.Write(">>> ");
            stergere_k solutie=new stergere_k(int.Parse(Console.ReadLine()));
        }
    }
}
