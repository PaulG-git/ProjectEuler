using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
  internal class Nr4_Largest_Palindrome_Product
  {
    public static void Solution()
    {
      do
      {
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#4 - Largest Palindrome Product' and displays the largest product pair for the given n-digit numbers up to 4 digits.");
        Console.Write("\nPlease, specify the number of digits between 1 and 4: ");

        int n = ProgramMethods.CheckInputKey("Wrong input. Please specify a whole number between 1 and 4: ", 4);

        int.TryParse(new string('1' + new string('0', (n - 1))), out int lowerBound);
        int.TryParse(new string('9', n), out int upperBound);
        bool isPalindrome = false;
        Dictionary<int, (int, int, int)> palindromes = new();

        for (int i = upperBound; i >= lowerBound; i--)
        {
          for (int j = upperBound; j >= i; j--)
          {
            isPalindrome = ProgramMethods.CheckIfPalindrome(Convert.ToString(i*j));
            if (isPalindrome == true)
              palindromes.Add(int.Parse(i.ToString() + j.ToString()), (i * j, i, j));
          }
        }
        int largestPalindromeKey = palindromes.MaxBy(entry => entry.Value.Item1).Key;
        int firstNumber = palindromes[largestPalindromeKey].Item2;
        int secondNumber = palindromes[largestPalindromeKey].Item3;

        Console.WriteLine($"\n\nThe largest palindrome product of {n}-digit numbers is {firstNumber * secondNumber}.");
        Console.WriteLine($"The numbers that result in this product are {firstNumber} and {secondNumber}.");

      } while (ProgramMethods.AskToContinue());
    }
  }
}
