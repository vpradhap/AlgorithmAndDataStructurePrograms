using AlgorithmAndDataStructurePrograms;

Console.WriteLine("\n\t\tAlgorithm and Data structure programs");

int flag =0;
while(flag == 0)
{
    Console.WriteLine("\n1 - Anagram program");
    Console.WriteLine("2 - Prime numbers between 1 to 1000 program");
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
        default :
            flag = 1;
            Console.WriteLine("\nEnter valid number");
            break;
    }
}