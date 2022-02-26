using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LineComparison
{
    public class LengthCalculation
    {
        /// <summary>
        ///UC-3 Calculate Length of Lne.
        /// </summary>

        public static void LineLengthCalculation()
        {
            double L1x1, L1y1, L1x2, L1y2;
            Console.WriteLine("Enter a value for Line1 x1");
            L1x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line1 y1");
            L1y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line1 x2");
            L1x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a value for Line1 y2");
            L1y2 = Convert.ToDouble(Console.ReadLine());
            double LengthOfLine;
            LengthOfLine = Math.Sqrt(Math.Pow(L1x2 - L1x1, 2) + Math.Pow(L1y2 - L1y1, 2));
            Console.WriteLine("Length of Line= " + LengthOfLine);
        }
    }
}