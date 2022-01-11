using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class sortare_selectie:indexare_vector
    {
        public static void select_sort(int[] v)
        {
            for(int i=0;i<v.Length;i++)
            {
                int min = i;
                for (int j = i + 1; j < v.Length; j++)
                    if (v[j] < v[min])
                        min = j;
                if(i!=min)
                {
                    v[i] = v[i] + v[min];
                    v[min] = v[i] - v[min];
                    v[i] = v[min];
                }
            }
        }

        public sortare_selectie()
        {
            select_sort(vector);
        }
    }
    class Problema12
    {
        public static void rezolvare()
        {
            sortare_selectie solutie = new sortare_selectie();
            UI.run();
        }
    }
}
