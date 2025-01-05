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
        uint count = 0;
        uint sum = 0;
        uint lastFibonacciNumber = 1;
        uint currentFibonacciNumber = 2;
        List<uint> evenFibonacciNumbers = new List<uint> { };
        do
        {
          if (IsEven(currentFibonacciNumber))
          {
            evenFibonacciNumbers = evenFibonacciNumbers.Append(currentFibonacciNumber).ToList();
            count++;
            sum = sum + currentFibonacciNumber;
          }
          (lastFibonacciNumber, currentFibonacciNumber) = FibonacciSequence(lastFibonacciNumber, currentFibonacciNumber);
        } while (currentFibonacciNumber < upperbound);

        Console.WriteLine($"\nThere have been {count} even fibonacci numbers. The last fibonacci number was {currentFibonacciNumber}.");
        Console.WriteLine($"Total sum of those even fibonacci numbers is {sum}.");
        Console.WriteLine("\nFound even fibonacci numbers are:");
        foreach (int n in evenFibonacciNumbers)
        {
          if (n != evenFibonacciNumbers.Last())
          {
            Console.Write(n + ", ");
          }
          else
          { 
          Console.Write(n + ".");
          }
        }
        Console.WriteLine();
      } while (ProgramMethods.AskToContinue());
    }

    private static (uint, uint) FibonacciSequence(uint lastNumber, uint currentNumber)
    {
      return (currentNumber, lastNumber + currentNumber);
    }

    private static bool IsEven(uint number)
    {
      if (number % 2 == 0)
      {
        return true;
      }
      return false;
    }
  }
}
