using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.ProgramFunctions
{
  internal class CalculationMethods
  {
    public static bool IsDivideableByX(uint number, uint x)
    {
      if (number % x == 0)
      {
        return true;
      }
      return false;
    }

    public static bool IsDivideableByX(int number, int x)
    {
      if (number % x == 0)
      {
        return true;
      }
      return false;
    }

    public static bool IsDivideableByX(long number, long x)
    {
      if (x % number == 0)
      {
        return true;
      }
      return false;
    }

    public static bool IsPrime(long number)
    {
      for (long i = 3; i < number; i += 2)
      {
        if ((number % i) == 0)
        {
          return false;
        }
      }
      return true;
    }
  }
}
