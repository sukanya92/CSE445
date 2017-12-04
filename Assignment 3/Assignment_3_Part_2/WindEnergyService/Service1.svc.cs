using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace WindEnergyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double GetWindEnergyIndex(Int32 lattitude, Int32 longitude)
        {
            int rowNo = ((lattitude+90)*360) + (longitude+180) + 1 ;
            int actualRowNo = rowNo + 7;
            int rowsTobeSkipped = actualRowNo - 1;
            string annualIndex = "";
            string path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", "10yr_wspd50m");

            if (File.Exists(path))
            {
                string rowContent = File.ReadLines(path).Skip(rowsTobeSkipped).Take(1).First();
                annualIndex = rowContent.Substring(rowContent.LastIndexOf(" "));
            }
            return Convert.ToDouble(annualIndex);
            
        }

        
    }
}
