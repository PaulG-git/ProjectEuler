using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
  internal class Nr7_10_001st_Prime
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#7 - 10 001st Prima' and displays the specified 'n'-th prime number.");
        Console.Write("\nPlease, specify what prime you want to display (up to 50 000st prime): ");

        int givenNumber = ProgramMethods.CheckInputForInt("Wrong input. Please specify a whole number from 1 up to 50 000: ", 50000, 1);
        int primeNumber = 2;
        int primeCounter = 1;

        for (int i = 3; primeCounter != givenNumber; i++)
        {
          if (CalculationMethods.IsDivideableByX(i, 2))
            continue;
          if (CalculationMethods.IsPrime(i))
          {
            primeNumber = i;
            primeCounter++;
          }
        }
        
        Console.WriteLine($"The {primeCounter} prime number is {primeNumber}.");
      } while (ProgramMethods.AskToContinue());
    }
  }
}
