using System;
namespace PierresBakery
{
  public class Bread
  {
    public int QuantityOrdered  { get; set; }
    public double TotalCost { get; set; }

    public Bread(int quantityOrdered, double totalCost)
    {
      QuantityOrdered = quantityOrdered;
      TotalCost = totalCost;
    }
    public double SetBreadDiscount(int quantityOrdered)
    {
      double convertedQuantityOrdered = Convert.ToDouble(quantityOrdered);
      double freeLoaf= convertedQuantityOrdered/3;
      double individualCost = 5;

      if (convertedQuantityOrdered % 3 == 0)
      {
        double totalCost = (individualCost * convertedQuantityOrdered) - (individualCost * freeLoaf);
          return totalCost;
      }
      else if (convertedQuantityOrdered < 3)
      {
        double totalCost = (individualCost * convertedQuantityOrdered);
          return totalCost;
      }
      else
      {
        double totalCost = (individualCost * convertedQuantityOrdered) - individualCost;
          return totalCost;
      }
    }
  }
}