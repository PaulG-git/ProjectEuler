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
        (uint count, uint sum) = (0, 0);
        List<uint> multiples = [];
        
        for (uint i = 1; i < upperbound; i++)
        {
          if(CalculationMethods.IsDivideableByX(i, 3) || CalculationMethods.IsDivideableByX(i, 5))
          {
            multiples = [.. multiples, i];
            sum += i;
            count++;
          }
        }

        Console.WriteLine($"There have been {count} multiples of 3 or 5 found.");
        Console.WriteLine($"Total sum of al those multiples is {sum}.");
        Console.WriteLine("\nThe found multiples are:");
        ProgramMethods.OutputIntList(multiples);
      } while (ProgramMethods.AskToContinue());
    }
  }
}