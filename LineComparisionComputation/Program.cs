
using System;
namespace LineComparisionComputation
{
    class Program
    {
        public static void Main(String[] args)
        {
            LineComparisionProgram line1 = new LineComparisionProgram(4, 5, 8, 6);
            double l1 = line1.Equality();
            LineComparisionProgram line2 = new LineComparisionProgram(4, 5, 8, 6);
            double l2 = line2.Equality();
            if (l1.CompareTo(l2) == 0)
            {
                Console.WriteLine("Both Lines are equals ");
            }
            else
            {
                Console.WriteLine("Both Lines are not equals ");
            }
        }
    }
}