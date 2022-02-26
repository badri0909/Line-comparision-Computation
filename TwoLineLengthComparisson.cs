using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class TwoLineLengthComparisson
    {
        /// <summary>
        ///UC-3 Length Comparison of Two Lines.
        /// </summary>

        public static void LengthComparisson()
        {
            string comparison;

            double L1x1, L1x2, L1y1, L1y2;
            Console.WriteLine("Enter Values for Line 1");
            Console.WriteLine("Enter a value for Line1 x1");
            L1x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line1 x2");
            L1x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line1 y1");
            L1y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line1 y2");
            L1y2 = Convert.ToDouble(Console.ReadLine());

            double LengthOfLine1;
            LengthOfLine1 = Math.Sqrt(Math.Pow(L1x2 - L1x1, 2) + Math.Pow(L1y2 - L1y1, 2));

            Console.WriteLine("Length of Line1 = " + LengthOfLine1 + "\n");

            double L2x1, L2x2, L2y1, L2y2;
            Console.WriteLine("Enter Values for Line 2");
            Console.WriteLine("Enter a value for Line2 x1");
            L2x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line2 x2");
            L2x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line2 y1");
            L2y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line2 y2");
            L2y2 = Convert.ToDouble(Console.ReadLine());

            double LengthOfLine2;
            LengthOfLine2 = Math.Sqrt(Math.Pow(L2x2 - L2x1, 2) + Math.Pow(L2y2 - L2y1, 2));

            Console.WriteLine("Length of Line2 = " + LengthOfLine2 + "\n");

            Console.WriteLine("Comparing the Lengths of Two Lines");
            if (LengthOfLine1 < LengthOfLine2)
            {
                comparison = "less than";
            }
            else if (LengthOfLine1 == LengthOfLine2)
            {
                comparison = "equal to";
            }
            else
            {
                comparison = "greater than";
            }

            Console.WriteLine("The Length Of First Line " + LengthOfLine1 + " is {0} The Second Line " + LengthOfLine2, comparison);
        }
    }
}