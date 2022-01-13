using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class interclasare
    {
        public static void interclasare_vector (indexare_vector x, indexare_vector y)
        {
            int[] v= new int[x.Lungime+y.Lungime];
            int i = 0, j = 0;
            for(int k=0; k<=x.Lungime+y.Lungime; k++)
            {
                if(x.vector[i]<=y.vector[j])
                {
                    v[k] = x.vector[i];
                    i++;
                }
                else
                {
                    v[k] = y.vector[j];
                    j++;
                }
            }
            for(int k=0; i<v.Length; i++)
                Console.WriteLine("{0} ",v[k]);
        }
    }
    
    class Problema25
    {
        public static void rezolvare()
        {
            indexare_vector x = new indexare_vector();
            indexare_vector y = new indexare_vector();
            interclasare.interclasare_vector(x, y);
            UI.run();
        }




    }
}
