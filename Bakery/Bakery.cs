using System.Collections.Generic;
using System;

namespace PierresBakery
{
  public class Bakery
  {
    public int IndivdualCost { get; set; }
    public int QuantityOrdered  { get; set; }
    public int NumberOfFreeItems { get; set; }
    public int TotalCost { get; set; }

    public int GetNumberOfLoavesOrdered(string breadOrder)
    {
      int result = 0;
      try
      {
        result =int.Parse(breadOrder);
          return result;
      }
      catch
      {
        Console.WriteLine($"Unable to parse '{breadOrder}'");
      }
      return result;
    }
    // public int GetNumberOfPastriesOrdered(string pastryOrder)
    // {
    //   int result = 0;
    //   try
    //   {
    //     result =int.Parse(pastryOrder);
    //       return result;
    //   }
    //   catch
    //   {
    //     Console.WriteLine($"Unable to parse '{pastryOrder}'");
    //   }
    //   return result;
    // }
  }
}