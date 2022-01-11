using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class eliminare_0: indexare_vector
    {
        public eliminare_0()
        {            
            for(int i = 0; i < Lungime; i++)
            {
                if(vector[i]==0)
                {
                    vector[i] = vector[Lungime - 1];
                    vector[Lungime-1] = 0;
                    Lungime--;
                    i--;
                }
            }
        }
    }
    class Problema14
    {
        public static void rezolvare()
        {
            eliminare_0 solutie = new eliminare_0();
            UI.run();
        }
    }
}
