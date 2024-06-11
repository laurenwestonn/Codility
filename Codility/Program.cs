using System.Diagnostics;

namespace Codility
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Redirect console output to Output window
            var listener = new ConsoleTraceListener();
            Debug.Listeners.Add(listener);

            //PrintPyramid(4);
            //PrintPyramidWithSpaces(4);
            //PrintSimplePyramidWithSpaces(4);

            //Fib.Fibbo(22);

            //Debug.WriteLine(Fib.BinaryGap(9));
            //Debug.WriteLine("");
            //Debug.WriteLine(Fib.BinaryGap(529));
            //Debug.WriteLine("");
            //Debug.WriteLine(Fib.BinaryGap(20));
            //Debug.WriteLine("");

            // Time Complexity
            Debug.WriteLine("Small frog: " + TimeComplexity.SmallFrog(10, 85, 30));
            Debug.WriteLine("Missing Perm element: " + TimeComplexity.PermMissingElement(new int[] { 3, 2, 5, 1 }));
            Debug.WriteLine("Missing Perm element: " + TimeComplexity.PermMissingElement(new int[] { 1 }));
            Debug.WriteLine("Missing Perm element: " + TimeComplexity.PermMissingElement(new int[] { 2 }));
            Debug.WriteLine("Tape Equilibrium: " + TimeComplexity.TapeEquilibrium(new int[] { 3, 1, 2, 4, 3 }));


            // Keep the console window open
            //Console.ReadKey();
        }

        private static void PrintSimplePyramidWithSpaces(int noOfLines)
        {
            for (int i = noOfLines; i > 0; i--)
            {
                for (int j = 0; j < noOfLines - i; j++)
                {
                    Debug.Write("_");
                }

                for (int k = 0; k < (i - 1) * 2 + 1; k++)
                {
                    Debug.Write("*");
                }

                Debug.WriteLine("");
            }
        }

        public static void PrintPyramid(int noOfLines)
        {
            for (int i = noOfLines; i > 0; i--)
            {
                for (int j = 1; j <= (i * 2 - 1); j++)
                {
                    Debug.Write("*");
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("");
        }

        public static void PrintPyramidWithSpaces(int noOfLines)
        {
            int noOfLineIndex = noOfLines - 1;
            int noOfColumns = noOfLineIndex * 2 + 1;
            for (int row = noOfLineIndex; row >= 0; row--)
            {
                int noInThisRow = row * 2 + 1;
                for (int column = 0; column < noOfColumns; column++)
                {
                    if (column >= noOfColumns - noInThisRow)
                    {
                        Debug.Write("*");
                    } else
                    {
                        Debug.Write("_");
                    }
                }
                
                Debug.WriteLine("");
            }
            Debug.WriteLine("");
        }
    }
}
