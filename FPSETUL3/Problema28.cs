using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSETUL3
{
    class mergesort_vector:indexare_vector
    {
        public static void mergesort(int n, int[] X)
        {
            if(n==2)
            {
                if(X[0]>X[1])
                {
                    X[0] = X[0] + X[1];
                    X[1] = X[0] - X[1];
                    X[0] = X[0] - X[1];
                }
            }
            else
            {
                int m = n / 2;
                int[] A = new int[m - 1];
                for(int i = 0; i <= m-1; i++ )
                    A[i]=X[i];
                int[] B = new int[n - 1 - m];
                for (int i = m; i <= n - 1; i++)
                    B[i - m] = X[i];
                mergesort(m, A);
                mergesort(n - m, B);
                int j = 0;
                int k = 0;

                for(int i=0; i < n-1; i++)
                {
                    if(A[j]<=B[k])
                    {
                        X[i] = A[j];
                        j++;
                    }
                    else
                    {
                        X[i] = B[k];
                        k++;
                    }
                }
            }
        }
        public mergesort_vector()
        {
            mergesort(Lungime, vector);
        }
    }
    class Problema28
    {
        public static void rezolvare()
        {
            mergesort_vector solutie=new mergesort_vector();
            UI.run();
        }
    }
}
