using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructurePrograms
{
    public class FindYourNumber
    {
        public static void FindNumber()
        {
            int start = 1;
            int end = 100;
            int middle = (start + end) / 2;
            Console.WriteLine("\nThink a number between 1 to 100");

            int flag = 0;
            while (flag == 0)
            {
                Console.WriteLine("\n1. Is your number > " + middle);
                Console.WriteLine("2. Is your number < " + middle);
                Console.WriteLine("3. Is your number = " + middle);
                Console.Write("\nPick one choice from above :");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        start = middle;
                        break;
                    case 2:
                        end = middle;
                        break;
                    case 3:
                        flag = 1;
                        Console.WriteLine("\nThe number you thiked is : "+middle);
                        break;
                    default:
                        flag = 1;
                        Console.WriteLine("\nInvalid choice");
                        break;
                }
                middle = (start + end) / 2;
            }
        }
    }
}
