using ProblemSolutions.ProgramFunctions;
using ProblemSolutions.UiMethods;
using System.Reflection;

namespace ProjectEuler
{
	internal class MainConsole
  {
		private static readonly Dictionary<int, (string, MethodBase)> _actions = [];
		
    private static readonly List<System.Type> FileList = Assembly.GetExecutingAssembly().GetTypes()
											.Where(t => t.Namespace == "ProblemSolutions.Problems")
											.Where(ca => !ca.CustomAttributes.Any())
											.ToList();
    
    internal static void PopulateDictionary()
    {
      foreach (var File in FileList)
      {
        var method = File.GetMethod("Solution");
        if (method != null)
				  _actions.Add(FileList.IndexOf(File) + 1, (File.Name, method.GetBaseDefinition()));
      }
      var exitMethod = typeof(ProgramMethods).GetMethod("ExitProgram");
			if (exitMethod != null)
			  _actions.Add(0, ("Exit program", exitMethod.GetBaseDefinition()));
    }

    public static void Main()
    {
      PopulateDictionary();
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
        _actions[ProgramMethods.CheckInputLine(_actions.Count - 1, "Wrong input. Please specify the program that you want to run, then hit 'ENTER': ")].Item2.Invoke(null, null);
      }
    }
  }
}