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
        Console.WriteLine("Great! The current deal is buy 3 for $5! Regular price is $2 each. Would you like a Danish or an Apple Struddel? [d or a]");
        string pastryAnswer = Console.ReadLine();
        if (pastryAnswer == "d"){
          Pastry pastry = new Pastry(2, "Danish");
          Console.WriteLine("How many Danish pastries would you like?")
          int pastryNum = int.Parse(Console.ReadLine());
          pastry.SetPastryPrice(pastryNum);
          Console.WiteLine("The total cost for your Danish Pastries is: $" + pastry.pastryPrice + " Thank you for shopping with us!" )
        } else if (pastryAnswer == "a") {
          Pastry pastry = new Pastry(2, "Apple Strudel");
          Console.WriteLine("How many Apple Strudel pastries would you like?")
          int pastryNum = int.Parse(Console.ReadLine());
          pastry.SetPastryPrice(pastryNum);
          Console.WiteLine("The total cost for your Danish Pastries is: $" + pastry.pastryPrice + " Thank you for shopping with us!" )
        } else {
          Console.WriteLine("Sorry I didn't understand that. Please enter d for Danish or a for Apple Strudel.");
        Main();
        }
        // Pastry pastry = new Pastry(2);
        // pastry.SetPastryPrice(pastryNum);
        // Console.WriteLine("Your bread total cost is: $" + pastry.pastryPrice + " Thank you for shopping with us!"); 
      } else if (answer.ToLower() == "b") {
        Console.WriteLine("Great! The current deal is buy 2 get 1 free! Regular price is $5 each. Would you like Anpan bread or a Bagel? [a or b]");
        string breadAnswer = Console.ReadLine();
        if (breadAnswer == "a"){
          Bread bread = new Bread(5, "Anpan");
          Console.WriteLine("How many Anpan would you like?")
          int breadNum = int.Parse(Console.ReadLine());
          bread.SetBreadPrice(breadNum);
          Console.WiteLine("The total cost for your Anpan bread is: $" + bread.breadPrice + " Thank you for shopping with us!" )
        } else if (pastryAnswer == "b") {
          Bread bread = new Bread(5, "Bagel");
          Console.WriteLine("How many Bagels would you like?")
          int breadNum = int.Parse(Console.ReadLine());
          bread.SetBreadPrice(breadNum);
          Console.WiteLine("The total cost for your Bagels is: $" + bread.breadPrice + " Thank you for shopping with us!" )
        } else {
          Console.WriteLine("Sorry I didn't understand that. Please enter d for Danish or a for Apple Strudel.");
        Main();
        }
        // int breadNum = int.Parse(Console.ReadLine());
        // Bread bread = new Bread(5);
        // bread.SetBreadPrice(breadNum);
        // Console.WriteLine("Your bread total cost is: $" + bread.breadPrice + " Thank you for shopping with us!"); 
      } else if (answer.ToLower() == "q") {
        Console.WriteLine("Thank you for visiting Pierre's Bakery! We hope you have a wonderful day!");
      } else {
        Console.WriteLine("Sorry I didn't understand that. Please enter b for bread or p for pastry.");
        Main();
      }
    }
  }
}