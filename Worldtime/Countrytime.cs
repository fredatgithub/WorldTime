using System;

namespace Worldtime
{
  internal class CountryTime
  {
    public string CityName { get; }
    public string CountryName { get; }
    public short TimeShift { get; }
    public TimeZone CountryTimeZone { get; }

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