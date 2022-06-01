using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructurePrograms
{
    public class PrimeNumber
    {
        public static void Prime()
        {
            int count = 0;
            Console.Write("\nPrime numbers between 1 to 1000 \n\n");
            //Logic
            for (int num = 2;num < 1000;num++)
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.Write(num + "  ");
                }
                count = 0;
            }
        }
    }
}
