using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalQuestion4
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringVariable = "kscottscco";
            string newStringVariable = stringVariable;

            for (int i = 0; i < stringVariable.Length; i++)
            {
                int repeatCount = 0;
                for (int j=i; j < stringVariable.Length; j++)
                {
                    if (stringVariable.ElementAt(i) == stringVariable.ElementAt(j))
                    {
                        repeatCount += 1;
                    }
                    
                }
                if (repeatCount >= 2)
                {
                    newStringVariable = newStringVariable.Replace(stringVariable.ElementAt(i).ToString(), "");
                }
                
            }
            Console.WriteLine(newStringVariable);
            Console.ReadLine();

        }

    }
}
