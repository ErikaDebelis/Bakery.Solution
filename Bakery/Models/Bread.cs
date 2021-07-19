using System;
using System.Collections.Generic;
namespace PierresBakery
{
  public class Bread
  {
    public int QuantityOrdered  { get; set; }
    public int IndividualCost { get; set; }
    public int Discount { get; set; }
    public int TotalCost { get; set; }
    Bread newBread = new Bread();

    public static void BreadTotal(int result)
    {
      int QuantityOrdered = result;
      int IndivdualCost = 5;
      int Discount = 0;
      int TotalCost = 0;
    }
  }
}

