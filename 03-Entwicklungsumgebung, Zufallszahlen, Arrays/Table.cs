using System;
using System.Globalization;

namespace Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parse input from CLI:
            double a, e, s;

            try
            {
                Console.Write("Enter interval start -> ");
                a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Enter interval end -> ");
                e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Enter step size -> ");
                s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow!");
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Format!");
                return;
            }

            //Sanity checks:
            if (s <= 0)
            {
                Console.WriteLine("Need a positive step size!");
                return;
            }

            if (e < a)
            {
                Console.WriteLine("Interval end must be >= start!");
                return;
            }

            //Print table:
            var x = a;
            Console.WriteLine("     x     |     y     ");
            Console.WriteLine("-----------------------");

            while (x <= e)
            {
                //Print x:
                Console.Write("{0,-10:f7} | ", x);

                //Calculate denominator:
                var denom = (x + 2) * (x - 1) * (x - 1);

                if (Math.Abs(denom) < 1e-15)
                {
                    Console.WriteLine("singul.");
                }
                else
                {
                    var y = ((3 * x) - 6) / denom;
                    Console.WriteLine("{0,-10:f7}", y);
                }

                //Increase by step size:
                x += s;
            }
        }
    }
}
