using System;
using System.Diagnostics;

namespace Codility
{
    internal class Sorting
    {
        public static int Triangle(int[] A)
        {
            Debug.WriteLine(string.Join(" ", A));

            Array.Sort(A);

            Debug.WriteLine(string.Join(" ", A));

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i] + A[i+1] > A[i+2])
                {
                    return 1;
                }
            }

            return 0;
        }
    }

}
