using ProblemSolutions.UiMethods;

namespace ProblemSolutions.ProgramFunctions
{
  internal class ProgramMethods
  {
    public static bool AskToContinue()
    {
      Console.WriteLine("\nDo you want to run the program again? Type 'y' for 'yes' or 'n' for 'no'. To go back to main menu, please press 'r'.");

      bool looped = false;
      while (true)
      {
        char userAnswer = Console.ReadKey().KeyChar;
        if (userAnswer == 'y')
        {
          Console.Clear();
          return true;
        }
        else if (userAnswer == 'n')
        {
          return false;
        }
        else if (userAnswer == 'r')
        {
          Console.Clear();
          ProjectEuler.MainConsole.Main();
        }

        if (looped)
        {
          ConsoleUIMethods.ClearLastXLines(2);
        }
        else
        {
          ConsoleUIMethods.ClearLastTwoLines();
        }
        looped = WrongAnswer();
      }
    }

    private static bool WrongAnswer()
    {
      Console.WriteLine("You entered the wrong answer!");
      Console.WriteLine("Please answer with 'y' for 'yes' or 'n' for 'no'. To return to main menu press 'r'.");
      return true;
    }

    public static int CheckInputForInt()
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

    public static void OutputIntList(List<uint> list)
    {
      foreach (uint n in list)
      {
        if (n != list.Last())
        {
          Console.Write(n + ", ");
        }
        else
        {
          Console.Write(n + ".\n");
        }
      }
    }
    public static bool IsDivideableByX(uint number, uint x)
    {
      if (number % x == 0)
      { 
        return true;
      }
      return false;
    }

    public static bool IsPrime(uint number) //WRONG!!!!! Stupid mistake! Rework tomorrow
    {
      for (int i = 2; i < number; i++)
      {
        if ((number % i) == 0)
        { 
          return false;
        }
      }
      return true;
    }

    public static List<uint> FindPrimeFactors(List<uint> primesList, int upperNumber)
    {
      List<uint> primeFactors = [];
      foreach (uint n in primesList)
      {
        if (upperNumber % n == 0)
        { 
          primeFactors = [.. primeFactors, n]; 
        }
      }
      return primeFactors;
    }
  }
}
