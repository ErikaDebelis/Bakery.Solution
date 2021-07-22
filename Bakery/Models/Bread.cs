namespace PierresBakery
{
  public class Bread
  {
    public int QuantityOrdered  { get; set; }
    public int TotalCost { get; set; }

    public Bread(int quantityOrdered, int totalCost)
    {
      QuantityOrdered = quantityOrdered;
      TotalCost =totalCost;
    }
    public int SetBreadDiscount(int quantityOrdered)
    {
      int freeLoaf= QuantityOrdered/3;
      int individualCost = 5;
      TotalCost = individualCost * QuantityOrdered;
        return TotalCost;
    }
  }
}