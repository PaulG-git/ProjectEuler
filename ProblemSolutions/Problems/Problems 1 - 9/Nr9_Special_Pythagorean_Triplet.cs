using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
	internal class Nr9_Special_Pythagorean_Triplet
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#9 - Special Pythagorean Triplet' and displays the product of the pythagorean triplet which sum is equal to specified number.");
        Console.Write("\nPlease, specify the number for this problem (from 6 to 1000): ");

        int givenNumber = ProgramMethods.CheckInputForInt("Wrong input. Please specify a whole number from 6 up to 1000: ", 1000, 6);
        int a;
        int b;
        int c;
        int product;

        (a, b, c) = FindTriplet(givenNumber);
        product = a * b * c;

        if (product != 0)
					Console.WriteLine($"\nThe product of pythagorean triplet for the number {a + b + c} is {product} and consistc of following number: {a}, {b}, {c}.");
        else
					Console.WriteLine("No solution was found for the specified number.");
      } while (ProgramMethods.AskToContinue());
    }
    private static (int, int, int) FindTriplet(int limit)
    {
			for (int i = 1; i <= limit; i++)
			{
				for (int j = i + 1; j <= limit; j++)
				{
					int c = (int)Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
					if (Math.Pow(i, 2) + Math.Pow(j, 2) != Math.Pow(c, 2))
            continue;
          if (i + j + c != limit)
						continue;
					else
					{
            return (i, j, c);
					}
				}
			}
      return (0, 0, 0);
		}
  }
}
