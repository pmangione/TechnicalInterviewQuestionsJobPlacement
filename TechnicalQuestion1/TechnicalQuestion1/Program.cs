using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestion1
{
    class Program
    {
       
            static void Main(string[] args)
            {
                int[] arrayOfIntegers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int sumOfOddIntegers = 0;
                foreach (int integerItem in arrayOfIntegers)
                {
                    if (integerItem % 2 != 0)
                    {
                    sumOfOddIntegers += integerItem;
                    }
                }
                Console.WriteLine(sumOfOddIntegers);
                Console.ReadLine();

            }
        }
    }









