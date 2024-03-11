using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {//ONE DIMENSION ARRAYS
         //int[] numbers = new int[5];
         //numbers[0] = 1; 
         //numbers[1] = 2;
         //numbers[2] = 3;
         //numbers[3] = 4;
         //numbers[4] = 5;

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //string[] names = { "ALİ", "AHMET", "HASAN", "HÜSEYİN" };

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            ///////////////////////////////////////////////////////////////////////////////

            // MORE THAN 1 DIMENTIONS

            //string[,] citys = new string[2, 3]
            //{
            //    {"Istanbul","Izmir","Ankara" },
            //    {"Manisa","Antalya","Ağrı" }
            //};

            //for (int i = 0; i <= citys.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= citys.GetUpperBound(1); j++)
            //        Console.WriteLine(citys[i,j]);
            //}
            //Console.ReadLine();


            ////////////////////////////////////////////////////////////////////////////


            // EXAMPLE OF DUBLICATE LETTER IN A WORD 
           // DublicateLetter();

        }

        private static void DublicateLetter()
        {
            List<char> notDublicate = new List<char>();
            List<char> dublicate = new List<char>();

            Console.Write("Enter a word: ");
            var word = Console.ReadLine();

            foreach (var letter in word)
            {
                if (!notDublicate.Contains(letter))
                {
                    notDublicate.Add(letter);
                }
                else
                {
                    dublicate.Add(letter);
                }
            }
            Console.Write("Dublicated letter is: ");
            foreach (var dub in dublicate)
            {
                Console.Write(dub);
            }
            Console.ReadLine();
        }
    }
}
