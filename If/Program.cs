using System;

namespace If
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Skriv ditt namn:");
      string name = Console.ReadLine();

      if (name == "micke" || name == "niklas")
      {
        Console.WriteLine("Välkommen, mästare!");
      }
      else if (name == "herbert")
      {
        Console.WriteLine("Välkommen, skithög!");
      }
      else
      {
        Console.WriteLine("Vem är du? Du får inte komma in!");
      }

      // if (name != "micke")
      // {
      //   Console.WriteLine("Get lost, ya bum!");
      // }


      Console.ReadLine();
    }
  }
}
