using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherRegistry.CompositionPath
{
    public static class Composition
    {

      public static string MakePath(this string endPoints, int cityId, string typeUnits, string appId)
      {
        return $"{endPoints}{cityId}&units={typeUnits}&{appId}";
      }



    }
}
