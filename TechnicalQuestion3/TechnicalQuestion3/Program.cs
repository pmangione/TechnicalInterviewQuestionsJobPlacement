using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringVariable = "kimes";
            int stringLength = stringVariable.Length;
            string reverseString = "";
            for (int i = stringLength - 1; i >= 0; i --)
            {
                reverseString += stringVariable.ElementAt(i);
            }
            Console.WriteLine(reverseString);
            Console.ReadLine();
        }
    }
}
