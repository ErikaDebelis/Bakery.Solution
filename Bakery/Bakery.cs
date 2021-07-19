using System;

namespace PierresBakery
{
  public class Bakery
  {
    public int GetNumberOfLoavesOrdered(string breadOrder) {
        int result = 0;

        try
        {
            result = Int32.Parse(breadOrder);
            return result;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse '{breadOrder}'");
        }

        return result;
    }

  }
}