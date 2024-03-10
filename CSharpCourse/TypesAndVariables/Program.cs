using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {//VARIABLE TYPES
         //  Console.WriteLine("HELLO WORLD. I AM CUNEYT KILIC AND I AM 25 YEARS OLD. I LOVE CODES");
            char character = 'A';

            int number1 = 10;
            int number2 = 20;
            //(int is from 2147483647 to -2147483648. 32 bit)
            bool condition = false;
            long number3 = 9223372036854775807;
            short number4 = 32767;
            byte number5 = 255;
            double number6 = 10.5; //(64 bit)
            //(numbers after comma 15 is double. numbers after comma 29 is decimal. )
            decimal number7 = 10.8m;
            Console.WriteLine("Number1 and Number2 is {0}, {1}",number1,number2);
            Console.ReadLine();
            Days days = Days.Wednesday;
            if (Days.Wednesday == days)
            {
                Console.WriteLine("DAY IS WEDNESDAY   {0}", Days.Wednesday);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("DAY IS NOT WEDNESDAY  {0}",Days.Wednesday);
                Console.ReadLine();

            }
        }
        public enum Days
        {
            Mon=1,
            Tue=2, 
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }
    }
}
