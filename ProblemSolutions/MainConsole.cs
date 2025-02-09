using ProblemSolutions.Problems;
using ProblemSolutions.ProgramFunctions;
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
      {4, new (nameof(Nr4_Largest_Palindrome_Product), Nr4_Largest_Palindrome_Product.Solution)},
      {5, new (nameof(Nr5_Smallest_Multiple), Nr5_Smallest_Multiple.Solution)},
      {6, new (nameof(Nr6_Sum_Square_Difference), Nr6_Sum_Square_Difference.Solution)},
      {7, new (nameof(Nr7_10_001st_Prime), Nr7_10_001st_Prime.Solution)},
      {8, new (nameof(Nr8_Largest_Product_in_a_Series), Nr8_Largest_Product_in_a_Series.Solution)},
      {9, new (nameof(Nr9_Special_Pythagorean_Triplet), Nr9_Special_Pythagorean_Triplet.Solution)},
      {0, ("Exit program", ProgramMethods.ExitProgram)}
    };

    public static void Main()
    {
      while (true)
      {
        Console.WriteLine("Welcom to Project Euler solver program.");
        Console.WriteLine("Which problem do you want to view?");
        foreach (var action in _actions)
        {
          if (action.Key == 0)
          {
            Console.WriteLine();
            Console.WriteLine(action.Key + ". " + action.Value.Item1);
            continue;
          }
          string problemName = StringMethods.ClassNameToString(action.Value.Item1, action.Key);
          problemName = StringMethods.ReplaceSpace(problemName);
          Console.WriteLine(action.Key + "." + problemName);
        }

        Console.Write("\nType the number of the program and then hit 'ENTER': ");
        _actions[ProgramMethods.CheckInputLine(_actions.Count - 1, "Wrong input. Please specify the program that you want to run, then hit 'ENTER': ")].Item2.Invoke();
      }
    }
  }
}