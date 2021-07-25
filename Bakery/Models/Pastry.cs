using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Pastry
  {
    public int QuantityOrdered  {get; set; }
    public int TotalCost {get; set; }

    public Pastry(int quantityOrdered, int totalCost)
    {
      QuantityOrdered = quantityOrdered;
      TotalCost = totalCost;
    }
    public double SetPastryDiscount(double quantityOrdered)
    {
      double freePastry= Math.Floor(quantityOrdered/3);
      double totalCost = Math.Ceiling(freePastry * 5);
        return TotalCost;
    }
  }
}