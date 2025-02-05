using ProblemSolutions.Problems;
using ProblemSolutions.UiMethods;

namespace ProjectEuler
{
  internal class MainConsole
  {
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(Nr1_Multiples_of_3_or_5), Nr1_Multiples_of_3_or_5.Solution)},
      {2, new (nameof(Nr2_Even_Fibonacci_Numbers), Nr2_Even_Fibonacci_Numbers.Solution)},
      {3, new (nameof(Nr3_Largest_Prime_Factor), Nr3_Largest_Prime_Factor.Solution)},
      {4, new (nameof(Nr4_Largest_Palindrome_Product), Nr4_Largest_Palindrome_Product.Solution)}
    };

    public static void Main()
    {
      Console.WriteLine("Welcom to Project Euler solver program.");
      Console.WriteLine("Which problem do you want to view?");
      foreach (var action in _actions)
      {
        string problemName = StringMethods.ClassNameToString(action.Value.Item1, action.Key);
        problemName = StringMethods.ReplaceSpace(problemName);
        Console.WriteLine(action.Key + "." + problemName);
      }

      _actions[CheckInputKey("Wrong input. Please specify the program that you want to run: ", _actions.Count)].Item2.Invoke();
    }

    private static int CheckInputKey(string prompt, int maxValue = Int32.MaxValue, int minValue = 1)
    {
      while (true)
      {
        string? answer = Console.ReadKey().KeyChar.ToString();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= maxValue && evaluatedAnswer >= minValue)
        {
          Console.Clear();
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearCurrentConsoleLine();
          Console.Write(prompt);
        }
      }
    }
  }
}