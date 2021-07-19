using System.Collections.Generic;
using System;
namespace PierresBakery
{
  public class Pastry
  {
    public int QuantityOrdered  { get; set; }
    public int IndividualCost { get; set; }
    public int Discount { get; set; }
    public int TotalCost { get; set; }
    // Pastry newPastry = new Pastry();

    // public static void PastryTotal(int result)
    // {
    //   int QuantityOrdered = result;
    //   int IndividualCost = 2;
    //   int Discount = 0;
    //   int TotalCost = 0;
    // }
  }
}