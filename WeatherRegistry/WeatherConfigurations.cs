using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherRegistry.Common;
using WeatherRegistry.Intefaces;

namespace WeatherRegistry
{
  public class WeatherConfigurations : IWeatherConfigurations
  {
    private readonly IConfiguration _configuration;

    public WeatherConfigurations(IConfiguration configuration, IOptions<Cities> cities)
    {
      _configuration = configuration;
      Cities = cities;
    }

    public string OpenWeatherBaseURL => _configuration["OpenWeatherBaseURL"]; //OpenWeatherBaseURL
    public string TokenKey => _configuration["TokenKey"];
    public string TypeUnits => _configuration["units"];

    public string AppId => $"APPID={TokenKey}";

    public IOptions<Cities> Cities { get; }
  }
}
