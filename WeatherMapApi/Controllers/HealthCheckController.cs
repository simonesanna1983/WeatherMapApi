using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeatherMapApi.Controllers
{
    [Produces("application/json")]
    [Route("api/HealthCheck")]
    public class HealthCheckController : Controller
    {

      [HttpGet]
      public string HealtCheck()
      {

        //throw new HttpStatusCodeException(StatusCodes.Status400BadRequest, @"You sent bad stuff");
        //int a = 2 , b = 0;
        //int c = a / b;
        //try
        //{
        //  int c = a / b;
        //}
        //catch (Exception ex)
        //{
        //  throw new HttpStatusCodeException(StatusCodes.Status500InternalServerError, ex.Message);
        //}

        return "Ok";
      }
  }
}