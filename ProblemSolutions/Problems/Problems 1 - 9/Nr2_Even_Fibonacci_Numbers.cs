using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
  internal class Nr2_Even_Fibonacci_Numbers
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#2 - Even Fibonacci Numbers' and displays the sum of those even numbers.");
        Console.Write("\nPlease, specify the upper bound for this program: ");
        
        int upperbound = ProgramMethods.CheckInputForInt();
        (uint count, uint sum, uint lastFibonacciNumber, uint currentFibonacciNumber) = (0, 0, 1, 2);
        List<uint> evenFibonacciNumbers = [];
        
        do
        {
          if (CalculationMethods.IsDivideableByX(currentFibonacciNumber, 2))
          {
            evenFibonacciNumbers = [.. evenFibonacciNumbers, currentFibonacciNumber];
            count++;
            sum += currentFibonacciNumber;
          }
          (lastFibonacciNumber, currentFibonacciNumber) = (currentFibonacciNumber, lastFibonacciNumber + currentFibonacciNumber);
        } while (currentFibonacciNumber < upperbound);

        Console.WriteLine($"\nThere have been {count} even fibonacci numbers. The last fibonacci number was {currentFibonacciNumber}.");
        Console.WriteLine($"Total sum of those even fibonacci numbers is {sum}.");
        Console.WriteLine("\nFound even fibonacci numbers are:");
        ProgramMethods.OutputIntList(evenFibonacciNumbers);
      } while (ProgramMethods.AskToContinue());
    }
  }
}