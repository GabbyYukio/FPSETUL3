using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class inserare_e:indexare_vector
    {
        public inserare_e(int e, int k)
        {
            for(int i=Lungime; i>k; i--)
                vector[i]=vector[i-1];
            vector[k] = e;
            afisare_elemente(Lungime + 1, vector);
        }
    }
    class Problema5
    {
        public static void rezolvare()
        {
            Console.WriteLine("Dati valoarea pe care o doriti sa o inserati: ");
            Console.Write(">>> ");
            int userinput=int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valoarea pozitiei pe care doriti sa introduceti numarul: ");
            Console.Write(">>> ");

            inserare_e solutie=new inserare_e(userinput, int.Parse(Console.ReadLine()));
            UI.run();
        }
    }
}
