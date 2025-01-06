using ProblemSolutions.ProgramFunctions;
using ProblemSolutions.UiMethods;

namespace ProblemSolutions.Problems
{
  internal class Nr3_Largest_Prime_Factor
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#3 - Largest Prime Factor' and displays the largest prime factor for the given number.");
        Console.Write("\nPlease, specify the number for this program: ");
        
        int givenNumber = ProgramMethods.CheckInputForInt();
        List<uint> primes = [];
        
        for (uint i = 1; i < givenNumber; i++)
        {
          if (ProgramMethods.IsPrime(i)) //False!!!! Rework tomorrow
          {
            primes = [.. primes, i]; 
          }
        }
        List<uint> primeFactors = ProgramMethods.FindPrimeFactors(primes, givenNumber);

        Console.WriteLine("\nAll found primes are:");
        ProgramMethods.OutputIntList(primes);
        Console.WriteLine("\nAll found prime factors are:");
        ProgramMethods.OutputIntList(primeFactors);
        Console.WriteLine($"\nThe largest prime factor of the number {givenNumber} is {primeFactors.Last()}.");
      } while (ProgramMethods.AskToContinue());
    }
  }
}
