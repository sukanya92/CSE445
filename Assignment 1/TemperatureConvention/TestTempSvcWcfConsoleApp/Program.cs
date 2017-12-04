using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTempSvcWcfConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureServiceReference.Service1Client temperatureService = new TemperatureServiceReference.Service1Client();
            Int32 inputc = 40;
            Int32 inputf = 112;
            Int32 resultf = temperatureService.c2f(inputc);
            Int32 resultc = temperatureService.f2c(inputf);
            Console.WriteLine("The temperature of {0} in celcius scale is equal to {1} in farenheit scale",inputc,resultf);
            Console.WriteLine("The temperature of {0} in farenheit scale is equal to {1} in celsius scale", inputf, resultc);
            temperatureService.Close();
        }
    }
}
