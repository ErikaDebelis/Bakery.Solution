namespace PierresBakery
{
  public class Pastry
  {
    public int QuantityOrdered  {get; set; }
    public int TotalCost {get; set; }

    public Pastry(int result, int totalCost)
    {
      QuantityOrdered = result;
      TotalCost = totalCost;
    }
  }
}