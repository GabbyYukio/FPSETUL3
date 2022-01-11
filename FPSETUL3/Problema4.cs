using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class numarare_min_max:indexare_vector
    {
        public numarare_min_max()
        {
            int nrmin = 0, nrmax = 0;
            int min = vector[0], max = vector[0];

            for(int i=1; i<Lungime; i++)
            {
                if (vector[i] < min)
                {
                    nrmin = 1;
                    min = vector[i];
                }
                else if (vector[i] > max)
                {
                    nrmax = 1;
                    max = vector[i];
                }
                else if (vector[i] == min)
                    nrmin++;
                else if (vector[i] == max)
                    nrmax++;
            }
            Console.WriteLine("Elementul cel mai mic este {0} si apare de {1} ori ", min, nrmin);
            Console.WriteLine("Elementul cel mai mare este {0} si apare de {1} ori ", max, nrmax);

        }
    }
    class Problema4
    {
        public static void rezolvare()
        {
            numarare_min_max solutie = new numarare_min_max();
            UI.run();
        }
    }
}
