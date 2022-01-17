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
            if (a < b)
                return -1;
            if (v[m] == k)
                return m;
            else if (k < v[m])
                return cautare(k, a, (a + m) / 2, m - 1, v);
            else
                return cautare(k, m + 1, (m + b) / 2, b, v);
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
