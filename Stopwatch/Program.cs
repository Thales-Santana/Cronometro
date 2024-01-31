using System;
using System.Runtime.Intrinsics.Arm;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("digite S para segundos ou M para minutos");
      string userType = Console.ReadLine().ToLower();

      Console.WriteLine("Quanto tempo deseja contar?");
      int userTime = int.Parse(Console.ReadLine());

      Start(userTime, userType);
    }

    static void PreStart()
    {
      Console.Clear();
      Console.WriteLine("Ready?");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("GO!");
      Thread.Sleep(1500);
    }
    static void Start(int time, string type)
    {
      PreStart();
      int currentTime = 0;

      if(type == "m"){
        time *= 60;
      }

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }
      Console.Clear();
      Console.WriteLine("Finished");
    }
  }
}