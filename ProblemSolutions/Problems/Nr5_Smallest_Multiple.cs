using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
  internal class Nr5_Smallest_Multiple
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#5 - Smallest Multiple' and displays the smallest that is evenly divisible by all the numbers up to the specified number 'n'.");
        Console.Write("\nPlease, specify the number 'n': ");

        int n = ProgramMethods.CheckInputForInt("Wrong input. Please specify a whole number from 2 up to 20: ", 20, 2);
        int counter = 0;
        int[] numbers = Enumerable.Range(1, n).ToArray();
        numbers = numbers.Reverse().ToArray();
        int smallestMultiple = numbers[0] * numbers[1];
        bool multipleFound = false;

        foreach (int i in numbers)
        {
          counter++;
          foreach (int j in numbers.Skip(counter))
          {
            if (CalculationMethods.IsDivideableByX(i, j))
              numbers = numbers.Where(val => val != j).ToArray();
          }
        }
        
        while (true)
        {
          foreach (int i in numbers)
          {
            if (CalculationMethods.IsDivideableByX(smallestMultiple, i) == false)
            {
              smallestMultiple = smallestMultiple + (i - (smallestMultiple % i)) ;
              smallestMultiple = smallestMultiple + (numbers.First() - (smallestMultiple % numbers.First()));
              break;
            }
            
            else if (i == numbers.Last())
              multipleFound = true;
          }

          if (multipleFound)
            break;
        }

        Console.WriteLine(smallestMultiple);

      } while (ProgramMethods.AskToContinue());
    }
  }
}
