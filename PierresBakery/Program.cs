using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("\nWelcome to Pierres Bakery!");
      Console.WriteLine("-_-_-_-_-_-_");
      Console.WriteLine("Bread is $5 per loaf, or buy 2 get 1 free!");
      Console.WriteLine("Pastries are $2 each, or 3 for $5!");

      int breadCost = HandleBreadOrder();
      int pastryCost = HandlePastryOrder();

      if (breadCost == 0 && pastryCost == 0)
      {
        Console.WriteLine("I see that you are not interested in any of our fine baked goods. Good day!\n\nI said Good Day!!");
      } else 
      {
      Console.WriteLine($"\nYour order total is ${breadCost + pastryCost}");
      }
    }

    // Prompts user for Bread order amount, returns bread order cost
    private static int HandleBreadOrder ()
    {
      Console.WriteLine("How many loaves of Bread would you like to purchase?");
      int loafCount = GetOrder();

      if (loafCount % 3 == 2)
      {
        Console.WriteLine("Would you like an additional free loaf of bread with your order?");
        Console.WriteLine("Please submit 'Yes' or 'No'");
        string upsellResponse = Console.ReadLine();

        if(upsellResponse == "Y" || upsellResponse == "Yes" || upsellResponse == "y" || upsellResponse == "yes")
        {
          loafCount++;
          Console.WriteLine("Thank you for your patronage!");
        }
      }

      Bread breadOrder = new Bread(loafCount);
      int breadCost = breadOrder.Cost();
      Console.WriteLine("You have selected {0} loaves of bread for ${1}", breadOrder.BreadCount, breadCost);

      return breadCost;
    }

    //Prompts user for Pastry Order amount and returns pastry order cost
    private static int HandlePastryOrder ()
    {
      Console.WriteLine("\nHow many pastries would you like to purchase?");
      int pastryCount = GetOrder();

      if (pastryCount % 2 == 0 && pastryCount > 0)
      {
        Console.WriteLine("Would you like an additional pastry for only $1?");
        Console.WriteLine("Please submit 'Yes' or 'No'");
        string upsellResponse = Console.ReadLine();

        if(upsellResponse == "Y" || upsellResponse == "Yes" || upsellResponse == "y" || upsellResponse == "yes")
        {
          pastryCount++;
          Console.WriteLine("Thank you for your patronage!");
        }
      }

      Pastries pastryOrder = new Pastries(pastryCount);
      int pastryCost = pastryOrder.Cost();
      Console.WriteLine("You have selected {0} pastries for ${1}", pastryOrder.PastryCount, pastryCost);

      return pastryCost;
    }

    // Recursive function, only accepts int otherwrise calls itself, returns number of items ordered
    private static int GetOrder () {

      string userInput = Console.ReadLine();
      int order;
      bool canBeParsed = int.TryParse(userInput, out order);

      if (canBeParsed)
      {
        if(order < 0)
        {
          Console.WriteLine("\nPlease submit a number 0 or greater:");
          order = GetOrder();
          return order;
        }
        else 
        {
          return order;
        }
      }
      else
      {
        Console.WriteLine("\nNon-number characters are not permitted. Please resubmit:");
        order = GetOrder();
        return order;
      }
    }
  }
}