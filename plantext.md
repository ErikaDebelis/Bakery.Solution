    Bread.cd plan :


    public int GetDiscount()
    {
      return Discount;
    }
  }

    ---------------------------------------------------------------------
    public static int SetBreadDiscount(int result)
    {
      int freeLoaf = QuantityOrdered / 3;
      if (PierresBakery.Bread.QuantityOrdered !% 3 = 0)
      {
        TotalCost = IndividualCost * QuantityOrdered;
          return TotalCost;
      }
    }
      }
      else if (PierresBakery.Bread.QuantityOrdered % 3 = 0)
      {
        TotalCost = (IndividualCost * QuantityOrdered) - (IndividualCost * freeLoaf);
          return TotalCost;
      }
      else
      {
        return TotalCost;
      }
    }


    --------------------------------------------------------

    Pastry.cs plan :





    public static int SetPastryDiscount(int result)
    {
      int freePastry = Math.Floor(QuantityOrdered / 3);
      TotalCost = Math.Ceiling(freePastry * 5);
        return TotalCost;
      }
    }


    ---------------------------------------------------------


    Program.cs plan:



using System;
using Bakery.Breads;
using Bakery.Pastries;
namespace Bakery
{
  public class Program
  {
    string error = "Invalid response; please try again.";
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery Web Application");
      Console.WriteLine("__________________________________________");
      Console.WriteLine("Would you like to order bread? Type 'bread' for bread and 'no' if you'd like to order something else.");
      string bakeryChoice = Console.ReadLine().ToUpper();
      try
      {
        if (bakeryChoice == "bread");
        {
          OrderBread();
        }
        else if (bakeryChoice == "no");
        {
          OrderPastry();
        }
      }
      catch
      {
        Console.WriteLine("$error");
      }
    public static void OrderBread()
    {
      Console.WriteLine("We're currently running an AMAZING bread special! Buy 2 loaves- get one FREE");
      Console.WriteLine("How many loaves would you like to purchase?");
      int inputtedBreadOrder= Console.ReadLine();
      int totalBreadCost = Bread.BreadTotal(inputtedBreadOrder);
      Console.WriteLine("Would you like to checkout? Type 'pastry' to add pastries to your order and 'checkout' to checkout.");
      string bakeryChoice = Console.ReadLine().ToUpper();
      try
      {
        if (bakeryChoice == "pastry");
        {
          OrderPastry();
        }
        else if (bakeryChoice == "checkout");
        {
          Checkout();
        }
      }
      catch
      {
        Console.WriteLine("$error");
      }
    public static void OrderPastry()
    {
      Console.WriteLine("We're currently running an PHENOMENAL pastry special! Buy 1 pastry for $2 or 3 pastries for $5!");
      Console.WriteLine("How many pastries would you like to purchase?");
      inputtedPastryOrder= Console.ReadLine();
      int totalPastryCost = Pastry.PastryTotal(inputtedPastryOrder);
      Console.WriteLine("Would you like to checkout? Type 'checkout' to checkout and click 'Enter' to restart our program");
      string bakeryChoice = Console.ReadLine().ToUpper();
      if (bakeryChoice == "checkout")
          {
            Checkout();
          }
      else
      {
        Main();
      }
    }
    public static void Checkout()
    {
      finalTotal = totalBreadCost + totalPastryCost;
      Console.WriteLine("Your order total comes to $finalTotal");
    }
  }
}



----------------

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