using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            
            var numquery = from num in numbers
                           where (num % 2) == 0
                           select num;

           
            Console.WriteLine("Even numbers:");
            foreach (int num in numquery) 
            {
                Console.Write("{0,1}  ", num);
            }

            
            Console.ReadLine();
        }
    }
}