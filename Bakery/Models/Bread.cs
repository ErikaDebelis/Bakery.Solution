namespace PierresBakery
{
  public class Bread
  {
    public int QuantityOrdered  { get; set; }
    public int TotalCost { get; set; }

    public Bread(int result)
    {
      QuantityOrdered = result;
      IndividualCost = 5;
      Discount = 0;
      TotalCost = 0;
    }
  }
}



