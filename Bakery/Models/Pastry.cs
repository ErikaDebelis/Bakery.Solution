using System;
namespace PierresBakery
{
  public class Pastry
  {
    public int QuantityOrdered  {get; set; }
    public double TotalCost {get; set; }

    public Pastry(int quantityOrdered, int totalCost)
    {
      QuantityOrdered = quantityOrdered;
      TotalCost = totalCost;
    }
    public double SetPastryDiscount(int quantityOrdered)
    {
      var convertedQuantityOrdered = Convert.ToDouble(quantityOrdered);

      double freePastry= Math.Floor(convertedQuantityOrdered/3);
      double totalCost = Math.Ceiling(freePastry * 5);

      return TotalCost;
    }
  }
}