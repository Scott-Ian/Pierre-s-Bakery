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

      Console.WriteLine("How many loaves of Bread would you like to purchase?");
      int loafCount = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(loafCount);
      int breadCost = breadOrder.Cost();
      Console.WriteLine("You have selected {0} loaves of bread for ${1}", breadOrder.BreadCount, breadCost);

      Console.WriteLine("How many pastries would you like to purchase?");
      int pastryCount = int.Parse(Console.ReadLine());
      Pastries pastryOrder = new Pastries(pastryCount);
      int pastryCost = pastryOrder.Cost();
      Console.WriteLine("You have selected {0} pastries for ${1}", pastryOrder.PastryCount, pastryCost);

      Console.WriteLine($"Your order total is ${breadCost + pastryCost}");

    }
  }
}