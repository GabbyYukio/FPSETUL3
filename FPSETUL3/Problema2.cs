using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class cautare_k:indexare_vector
    {
        public cautare_k(int k)
        {
            int copie = k;
            for(int i=0;i<k;i++)
                if(vector[i]==k)
                {
                    k = i;
                    break;
                }
            if (copie == k)
                Console.WriteLine("{0} nu se afla in vector. ", k);
            else
                Console.WriteLine("{0} se afla pe pozitia {1}. ", copie, k);
        }
    }
    class Problema2
    {
        public static void rezolvare()
        {
            Console.WriteLine("Introduceti valoarea pe care doriti sa o cautati: ");
            Console.Write(">>> ");
            cautare_k run = new cautare_k(int.Parse(Console.ReadLine()));
            UI.run();
        }
    }
}
