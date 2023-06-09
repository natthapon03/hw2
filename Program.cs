﻿class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the DNA sequence (half):");
            string dnaSequence = Console.ReadLine();

            if (IsValidSequence(dnaSequence))
            {
                Console.WriteLine("Current half DNA sequence: " + dnaSequence);

                Console.Write("Do you want to replicate it? (Y/N): ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == 'Y' || choice == 'y')
                {
                    string replicatedSequence = ReplicateSeqeunce(dnaSequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice == 'N' || choice == 'n')
                {
                    // Skip DNA synthesis
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char restartChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (restartChoice == 'N' || restartChoice == 'n')
            {
                break;
            }
            else if (restartChoice != 'Y' && restartChoice != 'y')
            {
                Console.WriteLine("Please input Y or N.");
            }
        }
    }

    static bool IsValidSequence(string halfDNASequence)
{
	foreach(char nucleotide in halfDNASequence)
	{
    	if(!"ATCG".Contains(nucleotide))
    	{
        	return false;
    	}
	}
	return true;
}
static string ReplicateSeqeunce(string halfDNASequence)
{
	string result = "";
	foreach(char nucleotide in halfDNASequence)
	{
    	result += "TAGC"["ATCG".IndexOf(nucleotide)];
	}
	return result;
}

    }
