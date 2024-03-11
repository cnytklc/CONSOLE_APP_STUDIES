using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalSayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            AsalSayı(number);

        }

        public static int AsalSayı(int number)
        {
            
            bool asal = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Asal Değil");
                    asal = false;
                    break;
                }

            }

            if (asal == true)
            {
                Console.WriteLine("Asal");

            }


            Console.ReadLine();
            return number;
        }
    }
}
