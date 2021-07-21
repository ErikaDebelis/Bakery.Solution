namespace PierresBakery
{
  public class Pastry
  {
    public int QuantityOrdered  {get; set; }
    public int TotalCost {get; set; }

    public Pastry(int result)
    {
      int QuantityOrdered = result;
      int IndivdualCost = 2;
      int Discount = 0;
      int TotalCost = 0;
    }
  }
}