using System;
using System.Reflection.Metadata;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packageDogFood = int.Parse(Console.ReadLine());
            int packageCatFood = int.Parse(Console.ReadLine());
            double totalSum = packageDogFood * 2.50 + packageCatFood * 4;
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
