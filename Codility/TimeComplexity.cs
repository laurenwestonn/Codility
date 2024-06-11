using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Codility
{
    internal class TimeComplexity
    {

        public static int SmallFrog(int X, int Y, int D) 
        {
            double distanceToTravel = Y - X;

            double result = distanceToTravel / D;

            return (int)Math.Ceiling(result);
        }

        public static int PermMissingElement(int[] A)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>(A.Length + 1);

            foreach (int x in A)
            {
                dict[x] = x;
            }

            for (int i = 1; i <= A.Length + 1; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int TapeEquilibrium(int[] A)
        {
            int smallestDifference = int.MaxValue;

            for (int i = 1; i < A.Length; i++)
            {
                int firstSum = 0;
                int j = 0;

                while (j < i)
                {
                    firstSum += A[j];
                    j++;
                }

                int secondSum = 0;
                int k = A.Length - 1;

                while (k >= i)
                {
                    secondSum += A[k];
                    k--;
                }

                int difference = Math.Abs(secondSum - firstSum);
                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                }
            }
            
            return smallestDifference;
        }
    }

}
