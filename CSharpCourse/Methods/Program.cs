using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result1 = Ebob(128, 24);
            var result2 = Ekok(128, 24);

            Console.WriteLine($"Ebob: {result1}, Ekok: {result2}");
            Console.ReadLine();
        }

        static int Ebob(int num1, int num2)
        {//ÖKLİT ALGORİTMASI. SADECE 2 SAYININ EBOBUNU BULMAK İÇİN KULLANILIR.
            // KALAN 0 DEĞİLSE BÖLENİ KALANA BÖLEREK EBOB BULMA YÖNTEMİ.
            while (num2 != 0)
            {
                var result = num2;

                num2 = num1 % num2;

                num1 = result;
        
            }
            
            
            return num1;
        }

        static int Ekok(int num1, int num2)
        {
            var result = ((num1 * num2) / Ebob(num1, num2));
            return result;
        }
    }
}
