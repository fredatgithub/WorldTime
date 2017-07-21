using System;

namespace Worldtime
{
  internal class CountryTime
  {
    public string CityName { get; set; }
    public string CountryName { get; set; }
    public short TimeShift { get; set; }

    public CountryTime(string cityName, string countryName, short timeShift)
    {
      CityName = cityName;
      CountryName = countryName;
      TimeShift = timeShift;

    }
  }
}