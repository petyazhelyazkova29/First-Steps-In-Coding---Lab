using System;
using System.Reflection.Metadata;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double price = meters * 7.61;
            double discount = price * 0.18;
            double sumTotal = price - discount;
            Console.WriteLine($"The final price is: {sumTotal} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
