using ProblemSolutions.UiMethods;

namespace ProblemSolutions.ProgramFunctions
{
	internal class ProgramMethods
  {
    public static void ExitProgram()
    {
      Environment.Exit(1);
    }
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
          ExitProgram();
        }
        else if (userAnswer == 'r')
        {
          Console.Clear();
          return false;
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

    public static int CheckInputLine(int maxValue, string promptIfWrong)
    {
      while (true)
      {
        string? answer = Console.ReadLine();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= maxValue)
        {
          Console.Clear();
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearLastTwoLines();
          Console.Write(promptIfWrong);
        }
      }
    }

    public static int CheckInputKey(string prompt, int maxValue = 9, int minValue = 1)
    {
      while (true)
      {
        string? answer = Console.ReadKey().KeyChar.ToString();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= maxValue && evaluatedAnswer >= minValue)
        {
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearCurrentConsoleLine();
          Console.Write(prompt);
        }
      }
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

    public static int CheckInputForInt(string prompt, int maxValue = Int32.MaxValue, int minValue = 1)
    {
      while (true)
      {
        string? answer = Console.ReadLine();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= maxValue && evaluatedAnswer >= minValue)
        {
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearLastTwoLines();
          Console.Write(prompt);
        }
      }
    }

    public static long CheckInputForLargeNumber()
    {
      while (true)
      {
        string? answer = Console.ReadLine();
        if (long.TryParse(answer, out long evaluatedAnswer) && evaluatedAnswer > 0)
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

    public static void OutputLargeNumberList(List<long> list)
    {
      foreach (long n in list)
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

    public static bool CheckIfPalindrome(string text)
    {
      char[] textArray = [];
      string reversedText = "";

      foreach (char chr in text)
        textArray = [.. textArray, chr];

      char[] reversedArray = textArray.Reverse().ToArray();

      foreach (char chr in reversedArray)
        reversedText = $"{reversedText}{chr}";

      if (text == reversedText)
      {  
        return true; 
      }
      return false;
    }
  }
}
