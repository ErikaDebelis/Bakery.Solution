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
      Program program = new Program();

      program.TakeOrder();
      program.OrderBread();
      program.OrderPastry();
      program.SecondOrderQuestion();
      program.Checkout();
    }

    public void TakeOrder()
    {
      Console.WriteLine("Welcome to Pierre's Bakery Web Application");
      Console.WriteLine("**__________________________________________**");
      Console.WriteLine("Would you like to order bread? Type 'bread' for bread and 'no' if you'd like to order something else.");

      string bakeryChoice = Console.ReadLine().ToUpper();
      bread = new Bread(0, 0);
      pastry = new Pastry(0, 0);

      try
      {
        if (bakeryChoice == "BREAD")
        {
          OrderBread();
        }
        else if (bakeryChoice == "NO")
        {
          SecondOrderQuestion();
        }
      }
      catch
      {
        Console.WriteLine($"{error}");
      }
    }


    public void SecondOrderQuestion()
    {
      Console.WriteLine("Would you like to order any pastries? Type 'pastry' to add pastries to your order and 'no' if you'd rather skip it");
      
      string bakeryChoice = Console.ReadLine().ToUpper();
      
      try
      {
        if (bakeryChoice == "PASTRY")
        {
          OrderPastry();
        }
        else if (bakeryChoice == "NO")
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
        quantityOrdered += int.Parse(breadOrder);

        bread.TotalCost = bread.SetBreadDiscount(quantityOrdered);
        Console.WriteLine($"Your total cost for bread is ${bread.TotalCost}" );

      }
      catch
      {
        Console.WriteLine($"Unable to parse '{breadOrder}'");
      }
    SecondOrderQuestion();

    }

    public void OrderPastry()
    {
      Console.WriteLine("We're currently running an PHENOMENAL pastry special! Buy 1 pastry for $2 or 3 pastries for $5!");
      Console.WriteLine("How many pastries would you like to purchase?");
      
      string pastryOrder = Console.ReadLine();
      int quantityOrdered = 0;

      try
      {
        quantityOrdered += int.Parse(pastryOrder);

        pastry.TotalCost = pastry.SetPastryDiscount(quantityOrdered);
        Console.WriteLine($"Your total cost for pastry is ${pastry.TotalCost}" );

      }
      catch
      {
        Console.WriteLine($"Unable to parse '{pastryOrder}'");
      }
    Checkout();
    }

    public void Checkout()
    {
      Console.WriteLine("Would you like to checkout? Type 'checkout' to checkout and click 'Enter' to restart our program");
      
      string bakeryChoice = Console.ReadLine().ToUpper();
      
      if (bakeryChoice == "CHECKOUT")
          {
            double finalTotal = bread.TotalCost + pastry.TotalCost;
            Console.WriteLine($"Your order total comes to ${finalTotal}");
            Console.WriteLine($"Thank you for choosing Pierre's Bakery! - See you again soon!");
            Console.WriteLine("NEXT!- Lets move it people! I've got a business to run here!");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            TakeOrder();
          }
      else
      {
        Console.WriteLine($"Thank you for choosing Pierre's Bakery! - See you again soon!");
        Console.WriteLine("NEXT!- Lets move it people! I've got a business to run here!");
        Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
        TakeOrder();
      }
    }
  }
}
