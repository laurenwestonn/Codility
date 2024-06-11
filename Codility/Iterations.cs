using System;
using System.Diagnostics;

namespace Codility
{
    internal class Fib
    {
        public static void Fibbo(int until)
        {
            int a = 0; int b = 1; int c;

            while (a <= until)
            {
                Debug.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }

        public static int BinaryGap(int N)
        {
            string binaryString = Convert.ToString(N, 2);
            Debug.WriteLine(binaryString);

            int indexFor1 = -1;
            int largestBinaryGap = 0;
            for (int i = 0; i < binaryString.Length; i++)
            {
                while (binaryString[i] != '1')
                {
                    i++;
                    if (i == binaryString.Length) return largestBinaryGap;
                }
                
                Debug.WriteLine("Reached a 1, at index " + i);

                if (indexFor1 >= 0)
                {
                    int binaryGap = i - indexFor1 - 1;
                    Debug.WriteLine("binaryGap: " + binaryGap);
                    if (binaryGap > largestBinaryGap)
                    {
                        largestBinaryGap = binaryGap;
                    }
                    Debug.WriteLine("largestBinaryGap: " + largestBinaryGap);
                }

               indexFor1 = i;

            }

            return largestBinaryGap;
        }
    }

}
