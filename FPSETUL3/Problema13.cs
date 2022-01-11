using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class sortare_insertie:indexare_vector
    {
        public static void insert_sort(int[] v)
        {
            for(int j=2; j<=v.Length; j++)
            {
                int cheie = v[j];
                int i = j - 1;
                while(i>0&&v[i]>cheie)
                {
                    v[i + 1] = v[i];
                    i--;
                }
                v[i + 1] = cheie;
            }
        }
        public sortare_insertie()
        {
            insert_sort(vector);
        }
    }
    class Problema13
    {
        public static void rezolvare()
        {
            sortare_insertie solutie = new sortare_insertie();
            UI.run();
        }
    }
}
