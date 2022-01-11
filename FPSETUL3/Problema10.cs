using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class cautare_binara:indexare_vector
    {
        public static int cautare(int k,int a,int m,int b, int[] v)
        {
            if (v[m] == k)
                return m;
            else
            {
                if (k > v[m])
                {
                    return cautare(k, m, (m + b) / 2, b, v);
                }
                else
                    return cautare(k, 0, m / 2, m, v);
            }
        }
        public cautare_binara(int k)
        {
            Console.WriteLine("Pozitia in care se afla {0} este {1} ",k, cautare(k, 0, Lungime / 2, Lungime, vector)); 
        }
    }
    class Problema10
    {
        public static void rezolvare()
        {
            Console.WriteLine("Dati valoarea pe care doriti sa o cautati: ");
            Console.WriteLine(">>> ");
            cautare_binara solutie = new cautare_binara(int.Parse(Console.ReadLine()));
        }
    }
}
