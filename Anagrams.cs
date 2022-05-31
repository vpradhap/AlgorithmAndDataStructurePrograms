using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDataStructurePrograms
{
    public class Anagrams
    {
        public static void Anagram()
        {
            Console.Write("\nEnter the String 1 : ");
            string str1 = Console.ReadLine();
            Console.Write("\nEnter the String 2 : ");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToUpper().ToCharArray();
            char[] ch2 = str2.ToUpper().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newStr1 = new string(ch1);
            string newStr2 = new string(ch2);
            if (newStr1 == newStr2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nBoth the strings are anagrams");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nBoth the strings are not anagrams");
                Console.ResetColor();
            }
        }
    }
}
