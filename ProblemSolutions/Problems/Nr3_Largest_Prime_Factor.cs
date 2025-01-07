using ProblemSolutions.ProgramFunctions;

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

        long givenNumber = ProgramMethods.CheckInputForLargeNumber();
        List<long> primeFactors = [];

        if (givenNumber % 2 == 0)
        {
          primeFactors = [.. primeFactors, 2];
        }

        for (long i = 3; i < Math.Sqrt(givenNumber); i += 2)
        {
          if (CalculationMethods.IsFactor(i, givenNumber))
          {
            if (CalculationMethods.IsPrime(i))
            {
              primeFactors = [.. primeFactors, i];
            }
            if (CalculationMethods.IsPrime(givenNumber/i))
            {
              primeFactors = [.. primeFactors, i];
            }
          }
        }

        if (givenNumber % givenNumber / 2 == 0 && CalculationMethods.IsPrime(givenNumber / 2))
        {
          primeFactors = [.. primeFactors, givenNumber / 2];
        }

        Console.WriteLine($"\nWe have found {primeFactors.Count} prime factors");
        Console.WriteLine("\nAll found prime factors are:");
        ProgramMethods.OutputLargeNumberList(primeFactors);
        Console.WriteLine($"\nThe largest prime factor of the number {givenNumber} is {primeFactors.Last()}.");
      } while (ProgramMethods.AskToContinue());
    }
  }
}
