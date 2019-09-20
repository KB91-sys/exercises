using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
			//Uppgift 2

            Console.Write("Skriv in ett decimaltal tal:");
            double num = Double.Parse(Console.ReadLine());

            Console.Write("Talet " + num + " avrundat till heltal: " + Math.Round(num));


        }
    }
}
