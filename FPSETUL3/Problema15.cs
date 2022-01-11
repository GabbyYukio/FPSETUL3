using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class eliminare_dubluri:indexare_vector
    {
        public static void eliminare_element(int k,int n, int[] v)
        {
            for(int i=k; i<n-1;i++)
            {
                v[i] = v[i + 1];
            }
            n--;
        }
        public eliminare_dubluri()
        {
            for(int i=0; i<=vector.Length; i++)
                for(int j=0; j<=vector.Length; j++)
                {
                    if(vector[i]==vector[j]&&i!=j)
                    {
                        eliminare_element(j, Lungime, vector);
                    }
                }
        }
            
    }
    class Problema15
    {
    }
}
