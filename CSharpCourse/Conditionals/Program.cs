using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            /* if (number != 10)
             {
                 Console.WriteLine("NUMBER IS NOT 10");
                 Console.ReadLine();

             }
             else
             {
                 Console.WriteLine("NUMBER IS 10 :)");
                 Console.ReadLine();
             } */

            // Console.WriteLine(number==10 ? "true" : "false");
            // Console.ReadLine();

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("NUMBER IS 10 ");
            //        break;

            //    case 20:
            //        Console.WriteLine("NUMBER IS 20 ");
            //        break;

            //    default:
            //        Console.WriteLine("Number Is not 10 or 20");
            //        break;
            //}
            //Console.ReadLine();

            //
            var num1 = 20;
            var num2 = 80;
            var num3 = 50;
            var bigNumber = 0;

            //if(num1 > num2 && num1>num3)
            //{
            //    bigNumber=num1;
            //    Console.WriteLine("Big Number is : num1: {0}",bigNumber);

            //}
            //else if (num1 < num2 && num1 > num3 || num1 < num3 && num1 > num2)
            //{
            //    Console.WriteLine("middle is: num1: {0} ", num1);
            //}
            //else
            //{
            //    Console.WriteLine("smallest is: num1: {0} ",num1);
            //}

            //if (num2 > num1 && num2 > num3)
            //{
            //    bigNumber = num2;
            //    Console.WriteLine("Big Number is: num2: {0}", bigNumber);

            //}
            //else if (num2 < num1 && num2 > num3 || num2 < num3 && num2 > num1)
            //{
            //    Console.WriteLine("middle is: num2: {0} ", num2);
            //}
            //else
            //{
            //    Console.WriteLine("smallest is: num2: {0} ", num2);
            //}

            //if (num3 > num1 && num3 > num2)
            //{
            //    bigNumber = num3;
            //    Console.WriteLine("Big Number is: num3: {0}", bigNumber);

            //}
            //else if (num3 < num1 && num3 > num2 || num3 < num2 && num3 > num1)
            //{
            //    Console.WriteLine("middle is: num3: {0} ", num3);
            //}
            //else
            //{
            //    Console.WriteLine("smallest is: num3: {0} ", num3);
            //}

            for (int i = 0; i < 3; i++)
            {
                if (num1 > bigNumber)
                {
                    bigNumber = num1;
                }
                else if (num2 > bigNumber)
                {
                    bigNumber = num2;
                }
                else if (num3 > bigNumber)
                {
                    bigNumber = num3;
                }
            }
            Console.WriteLine(bigNumber);
            Console.ReadLine();
        }
    }
}
