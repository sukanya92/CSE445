using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;

namespace NaturalHazardService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /// <summary> 
        /// This function returns the earthquake index/ occurances of a particular location
        /// </summary>
        /// <param name="latitude"> latitude of the location</param>
        /// <param name="longitude"> longitude of the location</param>
        /// <return> Earthquake Index </return>
        public Int32 GetEarthquakeIndex(Int32 latitude,Int32 longitude)
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string URL = "https://earthquake.usgs.gov/fdsnws/event/1/count?starttime=1917-09-23&endtime="+today+"&latitude="+latitude+"&longitude="+longitude+"&maxradiuskm=100&minmagnitude=2.5&eventtype=earthquake&orderby=time";
            Int32 countIncidence = 0;
            var response = "";

            using (WebClient client = new WebClient())
            {
                response = client.DownloadString(URL);
            }
            countIncidence = Convert.ToInt32(response);
            return countIncidence;
        }


        
    }
}
