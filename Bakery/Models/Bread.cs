namespace PierresBakery
{
  public class Bread
  {
    public int QuantityOrdered  { get; set; }
    public int TotalCost { get; set; }

    public Bread(int result, int totalCost)
    {
      QuantityOrdered = result;
      TotalCost =totalCost;
    }
  }
}