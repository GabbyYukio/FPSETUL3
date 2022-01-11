using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class indexare_numar
    {
        public int n;
        public indexare_numar()
        {
            Console.WriteLine("Dati valoarea lui n: ");
            Console.WriteLine(">>> ");

            n = int.Parse(Console.ReadLine());
        }
        public static int oglindit(int x)
        {
            int reverse=0;
            while (x != 0)
            {
                reverse = reverse * 10 + x % 10;
                x--;
            }
            return reverse;
        }
    }

    class ciurul_Eratostene:indexare_numar
    {
        public int[] vector = new int[99999999];

        public ciurul_Eratostene()
        {
            vector[0] = 1;
            vector[1] = 0;
            for(int i=0; i*i<=(n); i++)
            {
                if (vector[i] == 0)
                    for (int j = 2; j <= n / i; j++)
                        vector[i * j] = 1;
            }
        }
    }
    class Problema11
    {
        public static void rezolvare()
        {
            ciurul_Eratostene solutie = new ciurul_Eratostene();
            UI.run();
        }
    }
}
