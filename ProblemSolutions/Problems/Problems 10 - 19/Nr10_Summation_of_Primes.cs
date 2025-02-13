using ProblemSolutions.ProgramFunctions;
using System.Collections;

namespace ProblemSolutions.Problems
{
	internal class Nr10_Summation_of_Primes
	{
		public static void Solution()
		{
			do
			{
				Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
				Console.WriteLine("This program is made for the problem '#10 - Summation of Primes' and displays the sum of all prime numbers up to specified number.");
				Console.Write("\nPlease, specify the number for this problem (from 2 to 2.147.483.645): ");

				int givenNumber = ProgramMethods.CheckInputForInt("Wrong input. Please specify a whole number from 2 up to 2.147.483.645: ", 2_147_483_645, 2);
				ulong sum = 0;
				ulong count = 0;
				BitArray numbers = new BitArray(givenNumber + 1, true);
				numbers[0] = numbers[1] = false;
				numbers[2] = true;

				for (int i = 2; i <= givenNumber; i++)
				{
					if (numbers[i] == true && (long)i * (long)i <= givenNumber)
					{ 
						for (long j = i * i; j <= givenNumber; j += i)
							numbers[(int)j] = false;
					}
				}

				for (int i = 2; i <= givenNumber; i++)
				{
					if (numbers[i])
					{
						sum = sum + (uint)i;
						count++;
					}
				}

				Console.WriteLine($"\nWe found {count} primes in total up to {givenNumber}");
				Console.WriteLine($"\nThe sum of all found primes is {sum}");

			} while (ProgramMethods.AskToContinue());
		}
	}
}
