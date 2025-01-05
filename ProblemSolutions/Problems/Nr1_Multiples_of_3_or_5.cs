using ProblemSolutions.UiMethods;
using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
  internal class Nr1_Multiples_of_3_or_5
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#1 - Multiples of 3 or 5' and displays the sum of al the multoples.");
        Console.Write("\nSpecify the upper bound for the problem: ");
        int upperbound = CheckInputForInt();
        int count = 0;
        int sum = 0;
        for (int i = 0; i < upperbound; i++)
        {
          int evaluatedNumber = IsMultipleOf3Or5(i);
          if (evaluatedNumber != 0)
          {
            sum = sum + evaluatedNumber;
            count++;
          }
        }
        Console.WriteLine($"There have been {count} multiples of 3 or 5 found.");
        Console.WriteLine($"Total sum of al those multiples is {sum}.");
      } while (ProgramMethods.AskToContinue());
    }

    private static int IsMultipleOf3Or5(int number)
    {
      if (number % 3 == 0 || number % 5 == 0)
      {
        return number;
      }
      else 
      {
        return 0;
      }
    }

    private static int CheckInputForInt()
    {
      while (true)
      {
        string? answer = Console.ReadLine();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer > 0)
        {
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearLastTwoLines();
          Console.Write("Wrong input. Please specify a whole number for the upper bound: ");
        }
      }
    }
  }
}
