using ProblemSolutions.Problems;
using ProblemSolutions.UiMethods;

namespace ProjectEuler
{
  internal class MainConsole
  {
    private static readonly Dictionary<int, (string, Action)> _actions = new()
    {
      {1, new (nameof(Nr1_Multiples_of_3_or_5), Nr1_Multiples_of_3_or_5.Solution)}
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

      _actions[CheckInput()].Item2.Invoke();
    }
    private static int CheckInput()
    {
      while (true)
      {
        string? answer = Console.ReadKey().KeyChar.ToString();
        if (int.TryParse(answer, out int evaluatedAnswer) && evaluatedAnswer <= _actions.Count && evaluatedAnswer > 0)
        {
          Console.Clear();
          return evaluatedAnswer;
        }
        else
        {
          ConsoleUIMethods.ClearCurrentConsoleLine();
          Console.Write("Wrong input. Please specify the program that you want to run: ");
        }
      }
    }
  }
}