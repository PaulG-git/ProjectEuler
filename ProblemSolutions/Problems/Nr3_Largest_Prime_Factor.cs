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
        Console.Write("\nPlease, specify the upper bound for this program: ");
        
        int givenNumber = ProgramMethods.CheckInputForInt();
        List<uint> primeFactors = [];
        
        for (uint i = 1; i < givenNumber; i++)
        {
          if (ProgramMethods.IsPrime(i)) //Finish IsPrime function
          {
            primeFactors = [.. primeFactors, i]; 
          }
        }

        //code the ending
      } while (ProgramMethods.AskToContinue());
    }
  }
}
