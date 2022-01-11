using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class indexare_vector
    {
        public int Lungime;
        public int[] vector = new int[99999999];

        public indexare_vector()
        {
            Console.WriteLine("Dati lungimea vectorului: ");
            Console.Write(">>> ");
            try
            {
                Lungime= int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Valoare invalida. ");
            }

            Console.WriteLine("Dati valorile vectorului: ");
            for (int i = 0; i < Lungime; i++)
            {
                Console.Write(">>> ");
                try
                {
                    vector[i]=int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Valoare invalida. Incercati din nou.");
                    i--;
                }
            }
            
        }
        public static void afisare_elemente(int n, int[] v)
        {
            for (int i = 0; i <n; i++)
                Console.Write("{0} ",v[i]);
            Console.ReadLine();
        }
        public static void rotire_stanga(int n, int[] v)
        {
            int aux = v[n];
            for (int i = 1; i < n; i++)
                v[i] = v[i - 1];
            v[0] = aux;
        }
    }
    class suma_elem:indexare_vector
    {
        public suma_elem()
        {
            int s = 0;
            for(int i = 0; i < Lungime; i++)
                s=s+vector[i];
            Console.WriteLine("Suma elementelor este {0}", s);
        }
    }
    class Problema1
    {
        public static void rezolvare()
        {
            suma_elem solutie=new suma_elem();
            UI.run();
        }
    }
}
