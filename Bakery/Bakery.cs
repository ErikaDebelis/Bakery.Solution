using System.Collections.Generic;
using System;

namespace PierresBakery
{
  public class Bakery
  {
    public int QuantityOrdered  { get; set; }
    public int IndividualCost { get; set; }
    public int Discount { get; set; }
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
    public int GetNumberOfPastriesOrdered(string pastryOrder)
    {
      int result = 0;
      try
      {
        result =int.Parse(pastryOrder);
          return result;
      }
      catch
      {
        Console.WriteLine($"Unable to parse '{pastryOrder}'");
      }
      return result;
    }
    // public static int SetBreadDiscount(int result)
    // {
    //   if (PierresBakery.Bread.QuantityOrdered % 3 = 0)
    //   {
    //     int freeLoaf = QuantityOrdered / 3;
    //     TotalCost = (QuantityOrdered - freeLoaf) * IndividualCost;
    //       return TotalCost;
    //   }
    //   else if (PierresBakery.Bread.QuantityOrdered % 3 != 0)
    //   {
    //     TotalCost = IndividualCost * QuantityOrdered;// not sure how to do this....
    //       return TotalCost;
    //   }
    //   else
    //   {
    //     return TotalCost;
    //   }
    // }
  }
}