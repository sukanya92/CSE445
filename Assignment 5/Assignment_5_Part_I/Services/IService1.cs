using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;



namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Services Developed by Sukanya
        [OperationContract]
        string[] GetNewsFocus(String[] keywords);
        [OperationContract]
        string[] GetNewsHeadlines(string URL);
        [OperationContract]
        double GetWindEnergyIndex(Int32 lattitude, Int32 longitude);
        [OperationContract]
        string[] GetTop10Words(string URL);




        // Services Developed by Abhinethri
        [OperationContract]
        string addUser(string User, string password,int role);

        [OperationContract]
        string searchUser(string User, string password,int role);

        [OperationContract]
        string search(string user,int role);





        [OperationContract]
        string GetVerifierString(string myLength);

        [OperationContract]
        Stream GetImage(string myString);



        [OperationContract]
        string WordFilter(string str);

        [OperationContract]
        string[] GetCountryInfo(string CountryName);

        [OperationContract]
        string[] TimeZoneInfo(int zipcode);

        [OperationContract]
        string[] WeatherInfo(string city);


        [OperationContract]
        double SolarIntensity(int latitude, int longitude);
    }

}
