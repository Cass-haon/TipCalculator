using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double tipRate = 0.18;
            double billTotal = 0; //passing as argument
            // if args are not passed or amounnt is not getting converted into a double
            if (args.Length == 0 || !double.TryParse(args[0], out billTotal))
            {
                Console.WriteLine("Please enter the numeric value in this way: TipCalculator amount");
                Console.ReadKey();

            }
            double tip = billTotal * tipRate;
            Console.WriteLine();
            Console.WriteLine(" ****************************************");
            Console.WriteLine($"Bill Total :\t{billTotal,8:c}");
            Console.WriteLine($"Tip Total/rate \t {tip,8:c} ({tipRate:p1})");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine($"Grand Total :\t{billTotal + tip,8:c}");
            Console.ReadKey();
        }
    }
}
