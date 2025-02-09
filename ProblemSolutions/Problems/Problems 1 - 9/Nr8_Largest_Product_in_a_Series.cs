using ProblemSolutions.ProgramFunctions;

namespace ProblemSolutions.Problems
{
  internal class Nr8_Largest_Product_in_a_Series
  {
    private static byte[] Number()
    {
      string Number = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532" +
                      "0880551112540698747158523863050715693290963295227443043557668966489504452445231617318564030987111217223831136222989342338030813533627661428280" +
                      "6444486645238749303589072962904915604407723907138105158593079608667017242712188399879790879227492190169972088809377665727333001053367881220235" +
                      "4218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560" +
                      "5749026140797296865241453510047482166370484403199890008895243450658541227588666881164271714799244429282308634656748139191231628245861786645835" +
                      "9124566529476545682848912883142607690042242190226710556263211111093705442175069416589604080719840385096245544436298123098787992724428490918884" +
                      "5801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
      byte[] numArray = [];
      foreach (char chr in Number)
      {
        numArray = [.. numArray, Convert.ToByte(chr.ToString())];
      }
      return numArray;
    }
    public static void Solution()
    {
      do
      {
        byte[] numArray = Number();
        Console.WriteLine("Welcom to this problem solving program. This program is made to solve problems from Project Euler website.");
        Console.WriteLine("This program is made for the problem '#8 - Largest Product in a Series' and displays the product specified 'n' adjacent digits of the 1000-digit number.");
        Console.WriteLine("The 1000-digit number is:");
        for (int i = 0; i < 20; i++)
        {
          Console.WriteLine();
          for (int j = 0; j < 50; j++)
          {
            Console.Write(numArray[i * 50 + j]);
          }
        }
        Console.Write("\n\nPlease, specify how many adjacent digits do you want to check: ");

        int givenNumber = ProgramMethods.CheckInputForInt("Wrong input. Please specify a whole number from 2 up to 1000: ", 1000, 2);
        short[] tempArray;
        short[] finalArray = [];
        long tempProduct;
        long product = 0;

        for (int i = 0; i < numArray.Count() - givenNumber + 1; i++)
        {
          tempArray = [];
          for (int j = 0; j < givenNumber; j++)
          {
            tempArray = [.. tempArray, numArray[i + j]];
          }
          
          tempProduct = 1;
          foreach (short j in tempArray)
            tempProduct = tempProduct * j;
          
          if (tempProduct > product)
          {
            product = tempProduct;
            finalArray = tempArray;
          } 
        }

        Console.WriteLine($"\nLargest found product of {givenNumber} adjacent digits is {product}.");
        Console.WriteLine("The digits are: ");
        foreach (short i in finalArray)
          Console.Write(i + " ");
        Console.WriteLine();
      } while (ProgramMethods.AskToContinue());
    }

  }
}
