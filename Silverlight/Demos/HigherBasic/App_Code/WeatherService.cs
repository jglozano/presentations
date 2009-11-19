using System;
using System.Web.Script.Services;
using System.Web.Services;

namespace App_Code
{
    /// <summary>
    /// Summary description for WeatherService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/ws/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    public class WeatherService : WebService
    {

        [WebMethod]
        public string GetWeatherForecast(string zipcode)
        {
            string ret = "Sunny and warm";
            switch ((new Random(Environment.TickCount)).Next(3))
            {
                case 0:
                    ret = "Rain and thunderstorms";
                    break;
                case 1:
                    ret = "Blizzard!!";
                    break;
                case 2:
                    ret = "Overcast";
                    break;
            }
            return ret;
        }

    }
}