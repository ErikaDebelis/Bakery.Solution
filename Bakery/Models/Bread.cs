namespace PierresBakery
{
  public class Bread
  {
    public int QuantityOrdered  { get; set; }
    public int IndividualCost { get; set; }
    public int Discount { get; set; }
    public int TotalCost { get; set; }

    public int GetNumberOfLoavesOrdered(string breadOrder)
    {
      int result = 0;
      try
      {
        result =int.Parse(breadOrder);
          return result;
      }
      catch
      {
        Console.WriteLine($"Unable to parse '{breadOrder}'");
      }
      return result;
    }

    public Bread(int result)
    {
      QuantityOrdered = result;
      IndivdualCost = 5;
      Discount = 0;
      TotalCost = 0;
    }
    public int GetDiscount()
    {
      return Discount;
    }
  }
}
