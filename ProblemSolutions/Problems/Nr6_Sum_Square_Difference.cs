using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
  internal class Nr6_Sum_Square_Difference
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#6 - Sum Square Difference' and displays the differece between the sum of the squares and square of the sum of defined 'n' number of natural numbers.");
        Console.Write("\nPlease, specify the number 'n' from 2 to 100: ");

        int n = ProgramMethods.CheckInputForInt("Wrong input. Please specify a whole number from 2 up to 100: ", 100, 2);
        int[] numbers = Enumerable.Range(1, n).ToArray();
        int sumOfNum = 0;
        int sumOfSquares = 0;
        int difference;

        foreach (int i in numbers)
        { 
          sumOfNum = sumOfNum + i;
          sumOfSquares = sumOfSquares + (int)Math.Pow(i, 2);
        }

        difference = (int)Math.Pow(sumOfNum, 2) - sumOfSquares;

        Console.WriteLine($"\nThe sum of squares is {sumOfSquares}.");
        Console.WriteLine($"The quare of the sum of numbers is {Math.Pow(sumOfNum, 2)}.");
        Console.WriteLine($"\nThe difference is {difference}.");

      } while (ProgramMethods.AskToContinue());
    }
  }
}
