using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Activity_week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

           
            int number;
            if (Int32.TryParse(input, out number))
            {
                // Use a loop to print all numbers from 0 to the entered number
                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            
        }
            }
        
}
}
