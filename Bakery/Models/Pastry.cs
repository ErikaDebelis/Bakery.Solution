using System;
namespace PierresBakery
{
  public class Pastry
  {
    public int QuantityOrdered  { get; set; }
    public double TotalCost { get; set; }

    public Pastry(int quantityOrdered, double totalCost)
    {
      QuantityOrdered = quantityOrdered;
      TotalCost = totalCost;
      Console.WriteLine($"{QuantityOrdered}");
    }
    public double SetPastryDiscount(int quantityOrdered)
    {
      double convertedQuantityOrdered = Convert.ToDouble(quantityOrdered);

      double freePastry= Math.Floor(convertedQuantityOrdered/3);
      double individualCost = 2;

      if (convertedQuantityOrdered >= 3)
      {
        double totalCost = Math.Ceiling(freePastry * 5);
          return totalCost;
      }
      else
      {
        double totalCost = (individualCost * convertedQuantityOrdered);
          return totalCost;
      }
    }
  }
}