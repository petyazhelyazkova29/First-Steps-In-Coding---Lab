using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numInch = double.Parse(Console.ReadLine());
            double cent = numInch * 2.54;
            Console.WriteLine(cent);
        }
    }
}
