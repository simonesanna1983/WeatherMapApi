using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherRegistry.Common
{

  public class Cities
  {
    public IEnumerable<City> City { get; set; }
  }
  public class Coord
  {
    public double lon { get; set; }
    public double lat { get; set; }
  }

  public class City
  {
    public int id { get; set; }
    public string name { get; set; }
    public string country { get; set; }
    public Coord coord { get; set; }
  }



}
