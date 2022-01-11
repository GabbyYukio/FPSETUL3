using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class min_max:indexare_vector
    {
        public min_max()
        {
            int min = vector[0], max = vector[0];
            for(int i=1; i<Lungime; i++)
            {
                if (vector[i] < min)
                    min = vector[i];
                else if (vector[i] > max)
                    max = vector[i];
            }
            Console.WriteLine("Minimul si maximul din vector sunt {0} si {1}", min,max);
        }
    }
    class Problema3
    {
        public static void rezolvare()
        {
            min_max solutie=new min_max();
            UI.run();
        }
    }
}
