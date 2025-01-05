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
        Console.WriteLine("This program is made for the problem '#1 - Multiples of 3 or 5' and displays the sum of al the multiples.");
        Console.Write("\nPlease, specify the upper bound for the problem: ");
        
        int upperbound = ProgramMethods.CheckInputForInt();
        uint count = 0;
        uint sum = 0;
        
        for (uint i = 0; i < upperbound; i++)
        {
          uint evaluatedNumber = IsMultipleOf3Or5(i);
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

    private static uint IsMultipleOf3Or5(uint number)
    {
      if (number % 3 == 0 || number % 5 == 0)
      {
        return number;
      }
      return 0;
    }
  }
}
