using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class quicksort_vector:indexare_vector
    {
        public static void quick_sort(int[] v, int stanga, int dreapta)
        {
            if(stanga<dreapta)
            {
                int pivot = Partitie(v, stanga, dreapta);
                if (pivot > 1)
                    quick_sort(v, stanga, pivot - 1);
                if (pivot + 1 < dreapta)
                    quick_sort(v, pivot + 1, dreapta);
            }
        }
        private static int Partitie(int[] v, int stanga, int dreapta)
        {
            int pivot = v[stanga];
            while(true)
            {
                while (v[stanga] < pivot)
                    stanga++;
                while (v[dreapta] > pivot)
                    dreapta++;
                if (stanga < dreapta)
                {
                    if (v[dreapta] == v[stanga]) return dreapta;
                    v[dreapta] = v[stanga] + v[dreapta];
                    v[stanga] = v[dreapta] - v[stanga];
                    v[dreapta] = v[dreapta] - v[stanga];
                }
                else
                    return dreapta;
            }
        }
        public quicksort_vector()
        {
            quick_sort(vector, 0, Lungime-1);
            Console.Write("Elementele dupa ordonare sunt: ");
            afisare_elemente(Lungime, vector);
            UI.run();
        }
    }
    class Problema29
    {
        public static void rezolvare()
        {
            quicksort_vector solutie = new quicksort_vector();
        }
    }
}
