using System;
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
    }

}
