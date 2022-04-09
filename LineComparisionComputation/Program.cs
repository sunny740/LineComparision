
using System;
namespace LineComparisionComputation
{
    class Program
    {
        public static void Main(String[] args)
        {
            LineComparisionProgram line1 = new LineComparisionProgram(3, 9, 2, 5);
            double l1 = line1.CalculationOfLength();
            LineComparisionProgram line2 = new LineComparisionProgram(3, 9, 2, 5);
            double l2 = line2.CalculationOfLength();
            if (l1.CompareTo(l2) == 0)
            {
                Console.WriteLine("Both Lines are equals ");
            }
            if (l1.CompareTo(l2) > 0)
            {
                Console.WriteLine(" Line-1 Is Greater! ");
            }
            else
            {
                Console.WriteLine(" Line-2 Is Greater! ");
            }
        }
    }
}