using System;

namespace ConsoleAppTest
{
  internal static class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("Time Zone");
      TimeZoneInfo tzi = TimeZoneInfo.Local;
      display($"time zone Info standard name is {tzi.StandardName}");
      display($"time zone Info ID is {tzi.Id}");

      display($"{TimeZoneInfo.GetSystemTimeZones()}");
      display($"time zone Info standard name is {tzi.StandardName}");
      display($"time zone Info ID is {tzi.Id}");


      TimeZone localZone = TimeZone.CurrentTimeZone;
      DateTime currentDate = DateTime.Now;
      string currentTime = DateTime.Now.ToLongTimeString();
      display($"standard name is {localZone.StandardName}");
      display($"day light name is {localZone.DaylightName}");
      display($"get daylight changes is {localZone.GetDaylightChanges(DateTime.Now.Year)}");
      display($"Universal time is {localZone.ToUniversalTime(DateTime.Now)}");
      display($"current time is {currentTime}");
      display($"current date is {currentDate}");
      //foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
      //  Console.WriteLine(z.Id);

      TimeZoneInfo timeZone1;

      display($"US Mountain Standard Time");
      DateTime dateTime;
      //Set the time zone information to US Mountain Standard Time 
      timeZone1 = TimeZoneInfo.FindSystemTimeZoneById("US Mountain Standard Time");
      //Get date and time in US Mountain Standard Time 
      dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone1);
      //Print out the date and time
      Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH-mm-ss"));

      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}