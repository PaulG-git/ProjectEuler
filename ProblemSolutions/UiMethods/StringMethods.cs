using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.UiMethods
{
  internal class StringMethods
  {
    public static string ClassNameToString(string className, int keyNumber)
    {
      string convertedString;
      if (keyNumber < 10)
      {
        convertedString = className[3..];
      }
      else if (keyNumber >= 10 && keyNumber < 100)
      {
        convertedString = className[4..];
      }
      else if (keyNumber >= 100 && keyNumber < 1000)
      {
        convertedString = className[5..];
      }
      else
      {
        convertedString = "Something went wrong with string conversion!";
      }
      return convertedString;
    }

    public static string ReplaceSpace(string rawString)
    {
      string convertedString = rawString.Replace('_', ' ');
      return convertedString;
    }
  }
}
