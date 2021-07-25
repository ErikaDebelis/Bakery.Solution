using System;
using PierresBakery;
namespace Bakery
{
  public class Program
  {
    public Bread bread;
    public Pastry pastry;
    string error = "Invalid response; please try again.";
    public static void Main()
    {
      var program = new Program();

      program.TakeOrder();
    }

    public void TakeOrder() {

      Console.WriteLine("Welcome to Pierre's Bakery Web Application");
      Console.WriteLine("__________________________________________");
      Console.WriteLine("Would you like to order bread? Type 'bread' for bread and 'no' if you'd like to order something else.");

      string bakeryChoice = Console.ReadLine().ToUpper();
      bread = new Bread(0, 0);
      pastry = new Pastry(0, 0);

      try
      {
        if (bakeryChoice == "bread")
        {
          OrderBread();
        }
        else if (bakeryChoice == "no")
        {
          OrderPastry();
        }
      }
      catch
      {
        Console.WriteLine($"{error}");
      }
    }

public void FinalizeOrder() {
      //int totalBreadCost = SetBreadDiscount(quantityOrdered);
      
      Console.WriteLine("Would you like to checkout? Type 'pastry' to add pastries to your order and 'checkout' to checkout.");
      
      string bakeryChoice = Console.ReadLine().ToUpper();
      
      try
      {
        if (bakeryChoice == "pastry")
        {
          OrderPastry();
        }
        else if (bakeryChoice == "checkout")
        {
          Checkout();
        }
      }
      catch
      {
        Console.WriteLine($"{error}");
      }
    }

    public void OrderBread()
    {
      Console.WriteLine("We're currently running an AMAZING bread special! Buy 2 loaves- get one FREE");
      Console.WriteLine("How many loaves would you like to purchase?");
      
      string breadOrder = Console.ReadLine();
      int quantityOrdered = 0;

      try
      {
        quantityOrdered = int.Parse(breadOrder);

        bread.TotalCost = bread.SetBreadDiscount(quantityOrdered);
        bread.QuantityOrdered = quantityOrdered;
      }
      catch
      {
        Console.WriteLine($"Unable to parse '{breadOrder}'");
      }

    }

      

    public void OrderPastry()
    {
      Console.WriteLine("We're currently running an PHENOMENAL pastry special! Buy 1 pastry for $2 or 3 pastries for $5!");
      Console.WriteLine("How many pastries would you like to purchase?");
      
      string pastryOrder = Console.ReadLine();
      int quantityOrdered = 0;

      try
      {
        quantityOrdered = int.Parse(pastryOrder);

        pastry.TotalCost = pastry.SetPastryDiscount(quantityOrdered);
        pastry.QuantityOrdered = quantityOrdered;
      }
      catch
      {
        Console.WriteLine($"Unable to parse '{pastryOrder}'");
      }
      
     
    }
    public void Checkout()
    {
      Console.WriteLine("Would you like to checkout? Type 'checkout' to checkout and click 'Enter' to restart our program");
      
      string bakeryChoice = Console.ReadLine().ToUpper();
      
      if (bakeryChoice == "checkout")
          {
            double finalTotal = bread.TotalCost + pastry.TotalCost;
      Console.WriteLine("Your order total comes to $finalTotal");
      Console.WriteLine("Thank you for choosing Pierre's Bakery! - See you again soon!");
          }
      else
      {
        TakeOrder();
      }
    }
  }
}
