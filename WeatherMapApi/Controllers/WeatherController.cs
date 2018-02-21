using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging.AzureAppServices.Internal;
using Newtonsoft.Json;
using WeatherRegistry.CompositionPath;
using WeatherRegistry.Intefaces;

namespace WeatherMapApi.Controllers
{
  [Route("api/[controller]")]
  public class WeatherController : Controller
  {
    private readonly IWeatherConfigurations _weatherConfigurations;

    public WeatherController(IWeatherConfigurations weatherConfigurations)
    {
      _weatherConfigurations = weatherConfigurations;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      using (HttpClient client = new HttpClient())
      {
        client.BaseAddress = new Uri(_weatherConfigurations.OpenWeatherBaseURL);
        MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
        client.DefaultRequestHeaders.Accept.Add(contentType);
        var path = EndPoints.CurrentWeatherData.MakePath(id, _weatherConfigurations.TypeUnits, _weatherConfigurations.AppId);
        HttpResponseMessage response = client.GetAsync(path).Result;
        string stringData = response.Content.ReadAsStringAsync().Result;

        //List<Customer> data = JsonConvert.DeserializeObject
        //  <List<Customer>>(stringData);
        //return View(data);

        return stringData;
      }
    }





  }
}
