using System;
using System.Collections.Generic;
using System.Linq;

namespace DrawTriangle
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter width of triangle:");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please eneter number you want to print: ");

            var number = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i <= width; i++)
            {
                for (var j = 1; j <= width - i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
