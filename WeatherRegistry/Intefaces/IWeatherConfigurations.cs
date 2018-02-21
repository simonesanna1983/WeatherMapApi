using Microsoft.Extensions.Options;
using WeatherRegistry.Common;

namespace WeatherRegistry.Intefaces
{
  public interface IWeatherConfigurations
  {
    string OpenWeatherBaseURL { get; }
    string TokenKey { get; }
    string TypeUnits { get; }
    IOptions<Cities> Cities { get; }
    string AppId { get; }
  }
}