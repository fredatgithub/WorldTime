using System;

namespace ConsoleAppTest
{
  internal static class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Time Zone");
      TimeZone localZone = TimeZone.CurrentTimeZone;
      DateTime currentDate = DateTime.Now;
      string currentTime = DateTime.Now.ToLongTimeString();
      display($"standard name is {localZone.StandardName}");
      display($"day light name is {localZone.DaylightName}");
      display($"get daylight changes is {localZone.GetDaylightChanges(DateTime.Now.Year)}");
      display($"Universal time is {localZone.ToUniversalTime(DateTime.Now)}");
      display($"current time is {currentTime}");
      display($"current date is {currentDate}");

      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}