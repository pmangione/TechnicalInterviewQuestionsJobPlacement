using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = new int[] {1,2,4,2147483647};
            double sumOfElements = 0;
            foreach (int integerItem in arrayOfIntegers)
            {
                sumOfElements += integerItem;
            }
            Console.WriteLine(sumOfElements);
            Console.ReadLine();
        }
    }
}
