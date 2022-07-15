using System;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! We sell bread and pastries. Would you like to buy a Bread or Pastry? [b or p. Press q to leave store]");
      string answer = Console.ReadLine();
      if (answer.ToLower() == "p") {
        Console.WriteLine("Great! The current deal is buy 3 for $5! Regular price is $2 each. How many would you like?");
        int pastryNum = int.Parse(Console.ReadLine());
        Pastry pastry = new Pastry(2);
        pastry.SetPastryPrice(pastryNum);
        Console.WriteLine("Your bread total cost is: $" + pastry.pastryPrice + " Thank you for shopping with us!"); 
      } else if (answer.ToLower() == "b") {
        Console.WriteLine("Great! The current deal is buy 2 get 1 free! Regular price is $5 each. How many would you like?");
        int breadNum = int.Parse(Console.ReadLine());
        Bread bread = new Bread(5);
        bread.SetBreadPrice(breadNum);
        Console.WriteLine("Your bread total cost is: $" + bread.breadPrice + " Thank you for shopping with us!"); 
      } else if (answer.ToLower() == "q") {
        Console.WriteLine("Thank you for visiting Pierre's Bakery! We hope you have a wonderful day!");
      } else {
        Console.WriteLine("Sorry I didn't understand that. Please enter b for bread or p for pastry.");
        Main();
      }
    }
  }
}