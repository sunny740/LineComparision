using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    public class LineComparisionProgram
    {
        public void length()
        {
            Console.WriteLine("This is UC1-Length OF Line");
            Console.WriteLine();
            Console.WriteLine("Enter the coordinates");

            double x1, y1, x2, y2, length;

            Console.WriteLine("enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("Length of line is: " + length);
            Console.ReadLine();
        }
    }
}
