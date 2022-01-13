using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class eliminare_dubluri:indexare_vector
    {
        public static void eliminare_element(int k,ref int n, int[] v)
        {
            for(int i=k; i<n-1; i++)
            {
                v[i] = v[i + 1];
            }
            n--;
        }
        public eliminare_dubluri()
        {
            for (int i = 0; i < Lungime; i++)
                for (int j = 0; j < Lungime; j++)
                    if (vector[i] == vector[j] && i != j)
                        eliminare_element(j, ref Lungime, vector);
            afisare_elemente(Lungime, vector);
        }
            
    }
    class Problema15
    {
        public static void rezolvare()
        {
            eliminare_dubluri solutie=new eliminare_dubluri();
        }
    }
}
