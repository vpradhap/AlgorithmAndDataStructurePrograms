using AlgorithmAndDataStructurePrograms;

Console.WriteLine("\n\t\tAlgorithm and Data structure programs");

int flag =0;
while(flag == 0)
{
    Console.WriteLine("\n1 - Anagram program");
    Console.WriteLine("2 - Prime numbers between 1 to 1000 program");
    Console.WriteLine("3 - Prime numbers 1 to 1000 that are anagram and palindrome program");
    Console.WriteLine("4 - Find your number program");
    Console.Write("\nEnter your choice : ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Anagrams.Anagram();
            break;
        case "2":
            PrimeNumber.Prime();
            Console.WriteLine();
            break;
        case "3":
            PrimeNumberExtended.PrimeNumbers();
            Console.WriteLine();
            break;
        case "4":
            FindYourNumber.FindNumber();
            break;
        default :
            flag = 1;
            Console.WriteLine("\nEnter valid number");
            break;
    }
}