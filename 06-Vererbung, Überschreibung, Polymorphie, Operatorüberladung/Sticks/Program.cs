using System;

namespace Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets start!
            var num1 = new Number(5);
            var num2 = new Number("III");

            Console.WriteLine($"{ num1 + num2 }");
            Console.WriteLine(num1.Equals(num2));
            Console.WriteLine(num1.Equals(num1));
            Console.WriteLine(num1.Equals("moepp"));
        }
    }
}
