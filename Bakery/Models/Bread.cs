namespace PierresBakery
{
  public class Bread
  {
    public int QuantityOrdered  { get; set; }
    public int TotalCost { get; set; }

    public Bread(int quantityOrdered, int totalCost)
    {
      QuantityOrdered = quantityOrdered;
      TotalCost = totalCost;
    }
    public int SetBreadDiscount(int quantityOrdered)
    {
      int freeLoaf= quantityOrdered/3;
      int individualCost = 5;

      if (quantityOrdered % 3 == 0)
      {
        TotalCost = (individualCost * quantityOrdered) - (individualCost * freeLoaf);
          return TotalCost;
      }
      else
      {
        TotalCost = (individualCost * quantityOrdered) - individualCost;
          return TotalCost;
      }
    }
  }
}