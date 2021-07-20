namespace PierresBakery
{
  public class Pastry
  {
    public int GetNumberOfPastriesOrdered(string pastryOrder)
    {
      int result = 0;
      try
      {
        result =int.Parse(pastryOrder);
          return result;
      }
      catch
      {
        Console.WriteLine($"Unable to parse '{pastryOrder}'");
      }
      return result;
    }
    public Pastry(int result)
    {
      int QuantityOrdered = result;
      int IndivdualCost = 5;
      int Discount = 0;
      int TotalCost = 0;
    }
  }
}