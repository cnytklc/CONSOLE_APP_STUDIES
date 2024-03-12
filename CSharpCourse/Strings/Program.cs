using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "HELLO WORLD";
           var result = sentence.EndsWith("D");
           var result1 = sentence.StartsWith("H");
           var result2 = sentence.Substring(3,2);
           var result3 = sentence = sentence.Replace(" ", "+");
           var result4 = sentence.ToUpper();
            Console.WriteLine(result2);
            Console.ReadLine();

        }
    }
}
