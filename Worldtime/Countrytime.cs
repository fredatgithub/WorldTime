using System;

namespace Worldtime
{
  internal class CountryTime
  {
    private string CityName { get; }
    private string CountryName { get; }
    private short TimeShift { get; }
    private TimeZone CountryTimeZone { get; }

    public CountryTime(string cityName, string countryName, short timeShift, TimeZone countryTimeZone)
    {
      CityName = cityName;
      CountryName = countryName;
      TimeShift = timeShift;
      CountryTimeZone = countryTimeZone;
    }

    public override string ToString()
    {
      return $"{CityName} - {CountryName} : {DateTime.Now.ToLongTimeString()}";
    }
  }
}