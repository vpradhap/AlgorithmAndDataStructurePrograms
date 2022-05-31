using AlgorithmAndDataStructurePrograms;

Console.WriteLine("\n\t\tAlgorithm and Data structure programs");

int flag =0;
while(flag == 0)
{
    Console.WriteLine("\n1 - Anagram program");
    Console.Write("\nEnter your choice : ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Anagrams.Anagram();
            break;
        default :
            flag = 1;
            Console.WriteLine("\nEnter valid number");
            break;
    }
}