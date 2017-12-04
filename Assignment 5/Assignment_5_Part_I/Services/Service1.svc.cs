using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Hosting;
using System.Xml;
using System.Drawing;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        // Members

        public string addUser(string User, string password, int role)
        {
            string filename = null;
            if (role == 1)
                filename = "users.xml";
            else if(role==2)
                filename = "members.xml";
            else
                filename = "staffs.xml";
            // string filePath = @"C:\Users\Abhinethri\source\repos\WebApp\WebApp\App_Data\users.xml";
            string p = HostingEnvironment.ApplicationPhysicalPath;
            // string filePath = Path.GetFullPath(Path.Combine(p, @"..\" + "Page7\\App_Data", "users.xml"));
            string filePath = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", filename);
            try
            {

                //create new instance of XmlDocument
                XmlDocument doc = new XmlDocument();

                //load from file
                doc.Load(filePath);

                //create User node
                XmlNode user_node = doc.CreateElement("user");


                XmlNodeList userlst = doc.SelectNodes("users/user/username");
                foreach (XmlNode res in userlst)
                {
                    //pass textbox value for Code
                    if (res.InnerText == User)
                    {

                        return "exist";

                    }
                }


                // Create username element and add it 
                XmlNode username = doc.CreateElement("username");
                username.InnerText = User;   // add value to it
                user_node.AppendChild(username);      //add to parent node

                XmlNode password1 = doc.CreateElement("password");
                password1.InnerText = password;   // add value to it
                user_node.AppendChild(password1);      //add to parent node

                doc.DocumentElement.AppendChild(user_node);

                doc.Save(filePath);


                return "success";

            }
            catch (Exception e)
            {
                return e.Message;

            }

        }


        public string search(string user,int role)
        {
            string filename = null;
            if (role == 1)
                filename = "users.xml";
            else if (role == 2)
                filename = "members.xml";
            else
                filename = "staffs.xml";
            string p = HostingEnvironment.ApplicationPhysicalPath;
            //    string filePath = Path.GetFullPath(Path.Combine(p, @"..\" + "Page7\\App_Data", "users.xml"));
            string filePath = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", filename);
            try
            {

                //create new instance of XmlDocument
                XmlDocument doc = new XmlDocument();

                //load from file
                doc.Load(filePath);

                //create User node
                XmlNode user_node = doc.CreateElement("user");


                XmlNodeList userlst = doc.SelectNodes("users/user/username");
                foreach (XmlNode res in userlst)
                {
                    //pass textbox value for Code
                    if (res.InnerText == user)
                    {

                        return "success";

                    }
                }

                doc.Save(filePath);
                return "unsuccess";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public string searchUser(string User, string password, int role)
        {
            string filename = null;
            if (role == 1)
                filename = "users.xml";
            else if (role == 2)
                filename = "members.xml";
            else
                filename = "staffs.xml";
            // string filePath = @"C:\Users\Abhinethri\source\repos\WebApp\WebApp\App_Data\users.xml";
            string p = HostingEnvironment.ApplicationPhysicalPath;
            //string filePath = Path.GetFullPath(Path.Combine(p, @"..\" + "Page7\\App_Data", "users.xml"));
            string filePath = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", filename);
            try
            {



                XmlTextReader reader = null;
                try
                {
                    reader = new XmlTextReader(filePath);
                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "username"))
                        {
                            string sname;
                            sname = reader.ReadString();
                            if (sname == User)
                            {
                                reader.Read();
                                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "password"))
                                {
                                    string spass;
                                    spass = reader.ReadString();
                                    if (spass == password)
                                    {
                                        return "success";
                                    }

                                }
                            }
                        }

                    }
                    return "unsuccess";
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }


            }
            catch (Exception e)
            {
                return e.Message;

            }

        }



        // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

        // Connect to the service endpoint using HttpWebRequest
        public string[] WeatherInfo(string city)
        {
            string[] answer1 = new string[6];
            // return results;
            try
            {

                // Connect to the service endpoint using HttpWebRequest
                //String city = "Tempe";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://5dayweather.org/api.php?city=" + city);

                // Use Default credentials and get the response
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Get the stream containing content, Open the stream using a StreamReader and convert the content into string
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string content = readStream.ReadToEnd();

                // Reference for the above code: https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-request-data-using-the-webrequest-class



                Rootobject1 res = JsonConvert.DeserializeObject<Rootobject1>(content);
                answer1[0] = res.data.location;
                answer1[1] = res.data.skytext;
                answer1[2] = res.data.temperature;
                answer1[3] = res.data.humidity;
                answer1[4] = res.data.wind;
                answer1[5] = res.data.date + " & " + res.data.day;

                return answer1;
            }
            catch (Exception e)
            {
                answer1[0] = "error";
                answer1[1] = e.Message.ToString();
                return answer1;
            }

        }


        public class Rootobject1
        {
            public Data data { get; set; }
        }

        public class Data
        {
            public string location { get; set; }
            public string temperature { get; set; }
            public string skytext { get; set; }
            public string humidity { get; set; }
            public string wind { get; set; }
            public string date { get; set; }
            public string day { get; set; }
        }



        public string[] TimeZoneInfo(int zipcode)
        {
            string[] answer = new string[6];
            // string zipcode = "85281";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.zipcodeapi.com/rest/IbzilcouCbozWTOJ4JQ03Z9Cr8pzRHglRNTWJPzIt0GGoRXdY7aYnz5caJGMcJWZ/info.json/" + zipcode.ToString() + "/kms");

                // Use Default credentials and get the response

                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                // Get the stream containing content, Open the stream using a StreamReader and convert the content into string
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string content = readStream.ReadToEnd();

                // Reference for the above code: https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-request-data-using-the-webrequest-class


                Rootobject res = JsonConvert.DeserializeObject<Rootobject>(content);


                answer[0] = res.city;
                answer[1] = res.state;
                answer[2] = res.timezone.timezone_identifier;
                answer[3] = res.timezone.timezone_abbr;
                answer[4] = res.timezone.utc_offset_sec.ToString();
                answer[5] = res.timezone.is_dst;

                return answer;
            }
            catch (Exception e)
            {
                answer[0] = "error";
                answer[1] = e.Message.ToString();
                return answer;
            }


        }





        //class to store the JSON data
        public class Rootobject
        {
            public int error_code { get; set; }
            public string error_msg { get; set; }
            public string zip_code { get; set; }
            public float lat { get; set; }
            public float lng { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public Timezone timezone { get; set; }
            public Acceptable_City_Names[] acceptable_city_names { get; set; }
        }

        public class Timezone
        {
            public string timezone_identifier { get; set; }
            public string timezone_abbr { get; set; }
            public int utc_offset_sec { get; set; }
            public string is_dst { get; set; }
        }

        public class Acceptable_City_Names
        {
            public string city { get; set; }
            public string state { get; set; }
        }


        /* public string GetData(int value)
         {
             return string.Format("You entered: {0}", value);
         }

         public CompositeType GetDataUsingDataContract(CompositeType composite)
         {
             if (composite == null)
             {
                 throw new ArgumentNullException("composite");
             }
             if (composite.BoolValue)
             {
                 composite.StringValue += "Suffix";
             }
             return composite;
         } */



        public string[] GetCountryInfo(string CountryName)
        {

            string[] ans = new string[13];
            try
            {
                // Connect to the crimedata service endpoint using HttpWebRequest
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://countryapi.gear.host/v1/Country/getCountries");

                // Use Default credentials and get the response
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Get the stream containing content, Open the stream using a StreamReader and convert the content into string
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                string content = readStream.ReadToEnd();

                // Reference for the above code: https://docs.microsoft.com/en-us/dotnet/framework/network-programming/how-to-request-data-using-the-webrequest-class




                // Used newtonsoft to parse json

                Rootobject2 res = JsonConvert.DeserializeObject<Rootobject2>(content);


                for (int i = 0; i < res.Response.Count(); i++)
                {
                    if ((CountryName.ToLower()).Equals(res.Response[i].Name.ToLower()))
                    {
                        ans[0] = res.Response[i].Alpha2Code;
                        ans[1] = res.Response[i].Alpha3Code;
                        ans[2] = res.Response[i].Region;
                        ans[3] = res.Response[i].SubRegion;
                        ans[4] = res.Response[i].Latitude;
                        ans[5] = res.Response[i].Longitude;
                        ans[6] = "";
                        ans[7] = res.Response[i].NativeLanguage;
                        ans[8] = res.Response[i].CurrencyCode;
                        ans[9] = res.Response[i].CurrencyName;
                        ans[10] = res.Response[i].Flag;
                        ans[11] = res.Response[i].FlagPng;




                        return ans;

                    }

                }
                return ans;

            }
            catch (Exception e)
            {
                ans[0] = "error";
                ans[1] = e.Message.ToString();
                return ans;
            }



        }


        // Following class is used to hold JSON values
        public class Rootobject2
        {
            public bool IsSuccess { get; set; }
            public object UserMessage { get; set; }
            public object TechnicalMessage { get; set; }
            public int TotalCount { get; set; }
            public Response[] Response { get; set; }
        }

        public class Response
        {
            public string Name { get; set; }
            public string Alpha2Code { get; set; }
            public string Alpha3Code { get; set; }
            public string NativeName { get; set; }
            public string Region { get; set; }
            public string SubRegion { get; set; }
            public string Latitude { get; set; }
            public string Longitude { get; set; }
            public int? Area { get; set; }
            public int? NumericCode { get; set; }
            public string NativeLanguage { get; set; }
            public string CurrencyCode { get; set; }
            public string CurrencyName { get; set; }
            public string CurrencySymbol { get; set; }
            public string Flag { get; set; }
            public string FlagPng { get; set; }

        }


        public double SolarIntensity(int latitude, int longitude)
        {
            // These array will help to go to the exact line where information corresponding to given latitude and longitude are present
            int[] array_lat = new int[] { -90, -89, -88, -87, -86, -85, -84, -83, -82, -81, -80, -79, -78, -77, -76, -75, -74, -73, -72, -71, -70, -69, -68, -67, -66, -65, -64, -63, -62, -61, -60, -59, -58, -57, -56, -55, -54, -53, -52, -51, -50, -49, -48, -47, -46, -45, -44, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31, -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17, -16, -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 };
            int[] array_long = new int[] { -180, -179, -178, -177, -176, -175, -174, -173, -172, -171, -170, -169, -168, -167, -166, -165, -164, -163, -162, -161, -160, -159, -158, -157, -156, -155, -154, -153, -152, -151, -150, -149, -148, -147, -146, -145, -144, -143, -142, -141, -140, -139, -138, -137, -136, -135, -134, -133, -132, -131, -130, -129, -128, -127, -126, -125, -124, -123, -122, -121, -120, -119, -118, -117, -116, -115, -114, -113, -112, -111, -110, -109, -108, -107, -106, -105, -104, -103, -102, -101, -100, -99, -98, -97, -96, -95, -94, -93, -92, -91, -90, -89, -88, -87, -86, -85, -84, -83, -82, -81, -80, -79, -78, -77, -76, -75, -74, -73, -72, -71, -70, -69, -68, -67, -66, -65, -64, -63, -62, -61, -60, -59, -58, -57, -56, -55, -54, -53, -52, -51, -50, -49, -48, -47, -46, -45, -44, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31, -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17, -16, -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179 };

            // Formula to the line number
            int value = 360 * Array.IndexOf(array_lat, latitude) + Array.IndexOf(array_long, longitude);

            String line;
            double sum = 0;
            try
            {

                //Pass the file name having solar intensity data under App_Data
                // Data is obtained from https://eosweb.larc.nasa.gov/sse/global/text/dy_cos_sza . 
                //. Following comment as more info

                /*   NASA Surface meteorology and Solar Energy(SSE) Release 6 Data Set(April 2006)
   Parameter: Daylight Average Of Hourly Cosine Solar Zenith Angles(dimensionless)
   Notes: 1) SSE Methodology &Accuracy sections online
          2) na == value not available; see Methodology
          3) Solar geometry computed for the "monthly average day", which is the
             day (in the month) whose declination is closest to the average
             declination for that month[S.A.Klein, Calculation of monthly average
             insolation on tilted surfaces, Solar Energy, 19, 325 - 329, 1977].
   Internet: http://earth-www.larc.nasa.gov/solar/
   Created: October 11, 2006
   Lat Lon  Jan  Feb  Mar Apr May Jun Jul Aug Sep Oct Nov Dec  */


                //Read the data from reuired line
                string myFile = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Solar_test.txt");
                line = File.ReadLines(myFile).Skip(value).Take(1).First();
                // Find the sum of intensities from jan to feb
                String[] res = line.Split(' ');
                Int32 lat = Int32.Parse(res[0]);
                Int32 lon = Int32.Parse(res[1]);

                //  Solar intensity  values are extracted for all the 12 months and average is taken
                if (res[2].Equals("na"))
                {
                    res[2] = "0";
                }
                sum = sum + Convert.ToDouble(res[2]);
                if (res[3].Equals("na"))
                {
                    res[3] = "0";

                }
                sum = sum + Convert.ToDouble(res[3]);
                if (res[4].Equals("na"))
                {
                    res[4] = "0";

                }
                sum = sum + Convert.ToDouble(res[4]);
                if (res[5].Equals("na"))
                {
                    res[5] = "0";

                }
                sum = sum + Convert.ToDouble(res[5]);
                if (res[6].Equals("na"))
                {
                    res[6] = "0";

                }
                sum = sum + Convert.ToDouble(res[6]);
                if (res[7].Equals("na"))
                {
                    res[7] = "0";

                }
                sum = sum + Convert.ToDouble(res[7]);
                if (res[8].Equals("na"))
                {
                    res[8] = "0";

                }
                sum = sum + Convert.ToDouble(res[8]);
                if (res[9].Equals("na"))
                {
                    res[9] = "0";

                }
                sum = sum + Convert.ToDouble(res[9]);
                if (res[10].Equals("na"))
                {
                    res[10] = "0";

                }
                sum = sum + Convert.ToDouble(res[10]);
                if (res[11].Equals("na"))
                {
                    res[11] = "0";

                }
                sum = sum + Convert.ToDouble(res[11]);
                if (res[12].Equals("na"))
                {
                    res[12] = "0";

                }
                sum = sum + Convert.ToDouble(res[12]);
                if (res[13].Equals("na"))
                {
                    res[13] = "0";

                }
                sum = sum + Convert.ToDouble(res[13]);

                double res1 = sum / 12;

                return res1;

            }

            catch (Exception e)
            {
                return -101.00;
            }
        }

        public string WordFilter(string str)
        {
            try
            {
                // Referal for stop words https://www.link-assistant.com/seo-stop-words.html
                // http://xpo6.com/list-of-english-stop-words/
                String[] stop_words = new String[] {"a","able","above", "about","abroad","according","accordingly", "across","actually","adj","after","afterwards","again","against","ago",
        "ahead","ain't","all","am","amid","any","anybody", "anyhow", "anyone","anything",  "anyway","anyways", "anywhere","apart",  "appear",  "appreciate", "are", "awfully" ,
        "allow", "allows","almost","alone", "along", "alongside", "already","also","although", "always", "amidst","among","amongst","an","and", "another", "around", "at",
        "appropriate", "as","available", "a's","aside", "associated","any","anyhow","anyone","anything","anyway", "anywhere", "are", "around",  "ask", "asking", "at","appropriate", "away",

        "back","be","became", "because","become","becomes", "becoming", "been", "before", "beforehand", "behind", "being", "below", "beside", "besides", "between", "beyond",
        "bill", "both", "bottom","but", "by","b","back","backward","backwards","be","became","because","become","becomes","becoming","been","before","beforehand","begin","behind",
        "being","believe","below","beside","besides","best","better","between","beyond","both","brief","but","by","c",

        "call", "co", "con", "could", "couldnt", "cry", "come","came","can","cannot","cant","can't","caption","cause",
        "causes","certain","certainly","changes","clearly","c'mon","co","co.","com","comes","concerning","consequently","consider","considering",
        "contain","containing","contains","corresponding","could","couldn't","course","c's","currently",

        "describe", "detail", "do", "done", "down", "due","de","during","d","dare","daren't","definitely","described","despite","did","didn't","different",
        "directly","do","does","doesn't","doing","done","don't","down","downwards","during",

        "each", "eg", "eight", "either", "eleven","else", "elsewhere", "empty", "enough", "etc", "even", "ever", "every", "everyone", "everything", "everywhere", "except",
        "everybody","ex","exactly","example","except",

        "f","few", "fifteen", "fify", "fill", "find", "fire", "first", "five", "for", "former", "formerly", "forty", "found", "four", "from", "front", "full", "further","fairly",
        "far","farther","few","fewer","fifth","followed","following","follows","forever","former","formerly","forth","forward","furthermore",


        "get", "give", "go","gets","getting","given","gives","go","goes","going","gone","got","gotten","greetings",

         "had", "has", "hasnt", "have", "he", "hence", "her", "here", "hereafter", "hereby", "herein", "hereupon", "hers", "herself", "him", "himself", "his", "how", "however",
                "hundred","hadn't","half","happens","hardly","haven't","having","he'd","he'll","hello","help","hence","here","hereafter","hereby","herein","here's","hereupon",
               "he's","hi","himself","hither","hopefully","howbeit",


        "i","i'd","ie", "if", "in", "inc", "indeed", "interest", "into", "is", "it", "its", "itself","ignored","i'll","i'm","immediate","in","inasmuch","inc","inc.",
         "indeed","indicate","indicated","indicates","inner","inside","insofar","instead","into","inward","isn't","it'd","it'll","its","it's","itself","i've",

        "just",

        "keep","keeps","kept","know","known","knows",

         "last", "latter", "latterly", "least", "less", "ltd","lately","later","latter","latterly","least","less","lest","let","let's","like","liked",
         "likely","likewise","little","look","looking","looks","low","lower","ltd",


        "made", "many", "may", "me", "meanwhile", "might", "mill", "mine", "more", "moreover", "most", "mostly", "move", "much", "must", "my", "myself", "mainly",
         "make","makes","maybe","mayn't","mean","meantime","merely","mightn't","mine","minus","miss","mr","mrs","much","mustn't",


         "name", "namely", "neither", "never", "nevertheless", "next", "nine", "no", "nobody", "none", "noone", "nor", "not", "nothing", "now", "nowhere",
         "nd","near","nearly","necessary","need","needn't","needs","neither","never","neverless","nevertheless","notwithstanding","novel","nowhere","normally",
         "no-one","nonetheless","nobody","non","none","ninety","nine","next","new",


         "of", "off", "often", "on", "once", "one", "only", "onto", "or", "other", "others", "otherwise", "our", "ours", "ourselves", "out", "over", "own",
         "obviously","often","oh","ok","okay","old","ones","one's","opposite","ought","oughtn't","outside","overall",

         "part", "per", "perhaps", "please", "put","per","past","perhaps","particular","particularly","placed","please","plus","possible","presumably","probably","provided","provides",

         "que","quite","qv",

         "rather", "re","rd","really","reasonably","recent","recently","regarding","regardless","regards","relatively","respectively","right","round",

         "s","same", "see", "seem", "seemed", "seeming", "seems", "serious", "several", "she", "should", "show", "side", "since", "sincere", "six", "sixty", "so", "some", "somehow",
         "someone", "something", "sometime", "sometimes", "somewhere", "still", "such", "system","s","said","saw","say","saying","says","second","secondly","seeing","seen",
          "self","selves","sensible","sent","seriously","seven","shall","shan't","she'd","she'll","she's","shouldn't","since","six","so","some","somebody","someday","somewhat",
         "somewhere","soon","sorry","specified","specify","specifying","still","sub","such","sup","sure",


         "take", "taken","taking","tell","tends", "ten", "than","th", "that", "the", "their", "them", "themselves", "then", "thence", "there", "thereafter", "thereby", "therefore", "therein", "thereupon",
         "these", "they", "thickv", "thin", "third", "this", "those", "though", "three", "through", "throughout", "thru", "thus", "to", "together", "too", "top", "toward",
         "towards", "twelve", "twenty", "two","thank","thanks","thanx","that","that'll","thats","that's","that've","theirs","there'd","therein","there'll","there're","theres",
         "there's","thereupon","there've","they'd","they'll","they're","they've","thing","things","think","third","thirty","this","thorough","thoroughly","those",
         "though","three","till","took","towards","tried","tries","truly","try","trying","t's","twice","two",


         "un", "under", "until", "up", "upon", "us","underneath","undoing","unfortunately","u","unless","unlike","unlikely","unto","upon","upwards","us","use","used","useful",
         "uses","using","usually",

          "v","value","various","versus","very","via","viz","vs",

        "was", "we", "well", "were", "what", "whatever", "when", "whence", "whenever", "where", "whereafter", "whereas", "whereby", "wherein", "whereupon", "wherever",
        "whether", "which", "while", "whither", "who", "whoever", "whole", "whom", "whose", "why", "will", "with", "within", "without", "would", "want",
         "wants","wasn't","way","we'd","welcome","we'll","went","we're","weren't","we've","whatever","what'll","what's","what've","where's","whichever","whilst","whither","who'd",
        "who'll","whomever","who's","why","willing","wish","wonder","won't","wouldn't",

         "yet", "you", "your", "yours", "yourself", "yourselves", "the",
         "you'd","you'll","you're","yours","you've",



          "zero" };

                StringBuilder sb = new StringBuilder();

                String[] res = str.Split(' ');  // Split based on space
                for (int i = 0; i < res.Count(); i++)
                {
                    // check whether words are present in stop words list
                    if (!stop_words.Contains(res[i].ToLower()))
                    {
                        sb.Append(res[i]);
                        sb.Append(' ');
                    }

                }
                String final = sb.ToString();
                return final;
            }
            catch (Exception e)
            {
                return "error";
            }
        }

        public string GetVerifierString(string length)
        {
            // This service is used to obtain random string 
            Uri baseUri = new Uri("http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/");
            UriTemplate myTemplate = new UriTemplate("GetRandomString/{len}");
            Uri completeUri = myTemplate.BindByPosition(baseUri, length); // Assign value to variable to obtain complete URI
            WebClient proxy = new WebClient();
            byte[] response = proxy.DownloadData(completeUri);
            Stream strm = new MemoryStream(response); // Convert to memory stream
            DataContractSerializer obj = new DataContractSerializer(typeof(string));
            string randstring = obj.ReadObject(strm).ToString();
            return randstring;
        }

        public Stream GetImage(string myString)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            int mapwidth = (int)(myString.Length * 25);  // Create bitmap
            Bitmap bmap = new Bitmap(mapwidth, 40); // Based on string length
            Graphics graph = Graphics.FromImage(bmap);
            graph.Clear(Color.Azure);  // Background Color
            graph.DrawRectangle(new Pen(Color.LightBlue, 0), 0, 0, bmap.Width - 1, bmap.Height - 1); // draw an image
            Random rand = new Random();
            Pen badPen = new Pen(Color.LightGreen, 0);
            for (int i = 0; i < 100; i++)  // Create noise pattern
            {
                int x = rand.Next(1, bmap.Width - 1);
                int y = rand.Next(1, bmap.Height - 1);
                graph.DrawRectangle(badPen, x, y, 4, 3);
                graph.DrawEllipse(badPen, x, y, 2, 3);
            }

            char[] charstring = myString.ToCharArray();
            Font font = new Font("Boopee", 18, FontStyle.Bold);
            Color[] clr = { Color.Black, Color.Red, Color.DarkGreen, Color.DarkViolet, Color.DarkOrange, Color.Brown, Color.DarkGoldenrod, Color.Plum };
            // Draw chraaters as graphic objects
            for (int i = 0; i < myString.Length; i++)
            {
                int d = rand.Next(20, 25); // distance between characters
                int p = rand.Next(1, 15); // up and down position
                int c = rand.Next(0, 7);  // Randomly choose a color
                string strl = Convert.ToString(charstring[i]);
                Brush b = new System.Drawing.SolidBrush(clr[c]);
                graph.DrawString(strl, font, b, 1 + i * d, p);

            }
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            ms.Position = 0;
            graph.Dispose();
            bmap.Dispose();
            return ms;
        }










        public string[] GetTop10Words(string URL)
        {
            Web2StringService.ServiceClient clientWeb2String = new Web2StringService.ServiceClient();
            string url = URL;
            string originalString = clientWeb2String.GetWebContent(url);
            string[] res = new string[10];

            //The following 12 regular expressions filter the original web page source to extract the most valuable words of interest
            Regex reg1 = new Regex(@"<script[^>]*>[\s\S]*?</script>");
            Regex reg2 = new Regex(@"<style[^>]*>[\s\S]*?</style>");
            Regex reg3 = new Regex(@"<.*?>");
            Regex reg4 = new Regex(@"&.*?;");
            Regex reg5 = new Regex(@"<p[^>]*>[\s\S]*?</p>");
            Regex reg6 = new Regex(@"<[^>]+>|&nbsp;");
            Regex reg7 = new Regex(@"\ +(?= (\n |\r ?$))");
            Regex reg8 = new Regex(@"[' ']*?$");
            Regex reg9 = new Regex(@"\p{C}+");
            Regex reg10 = new Regex(@"\s+");
            Regex reg11 = new Regex(@"http[^\s]+");
            Regex reg12 = new Regex(@"[^a-zA-Z]");

            string s2 = reg1.Replace(originalString, " ");
            s2 = reg2.Replace(s2, " ");
            s2 = reg3.Replace(s2, " ");
            s2 = reg4.Replace(s2, " ");
            s2 = reg5.Replace(s2, " ");
            s2 = reg6.Replace(s2, " ");
            s2 = reg7.Replace(s2, "");
            s2 = reg8.Replace(s2, "");
            s2 = reg9.Replace(s2, "");
            s2 = reg10.Replace(s2, " ");
            s2 = reg11.Replace(s2, " ");
            s2 = reg12.Replace(s2, " ");


            //The following lines of code sorts all the words in descending order
            s2 = s2.ToLower();
            var words = s2.Split(' ')
                .Where(w => w.Length > 3)
                .GroupBy(w => w)
                .Select(w => new { Count = w.Count(), word = w.Key })
                .OrderByDescending(w => w.Count);
            int counter = 0;

            //The following loop stores the result in the string array
            foreach (var item in words)
            {
                if (counter < 10)
                {
                    Console.WriteLine("{0}x {1}", item.Count, item.word);
                    res[counter] = item.word + "(" + item.Count + ")";
                    counter++;
                }
                else break;

            }
            return res;
        }

        public double GetWindEnergyIndex(Int32 lattitude, Int32 longitude)
        {
            //Generic Formulae to find the Required Row from the data source corresponding to the input Lattitude and Longitude
            int rowNo = ((lattitude + 90) * 360) + (longitude + 180) + 1;
            int actualRowNo = rowNo + 7;
            int rowsTobeSkipped = actualRowNo - 1;
            string annualIndex = "";
            string path = Path.Combine(System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath, "App_Data", "10yr_wspd50m");

            //Gets the appropriate Line from the Source File And Returns the Last column which corresponds to the Annual Wind Intensity
            if (File.Exists(path))
            {
                string rowContent = File.ReadLines(path).Skip(rowsTobeSkipped).Take(1).First();
                annualIndex = rowContent.Substring(rowContent.LastIndexOf(" "));
            }
            return Convert.ToDouble(annualIndex);

        }

    /// <summary> 
    /// This function returns a list of top 10 URLs where the search keyword occurs
    /// </summary>
    /// <param name="Keywords"> The input keyword(s)</param>
    /// <return>array of URLs where above search term occurs</return>
    public string[] GetNewsFocus(string[] keywords)
        {
            string[] titles;
            String searchQuery = "";
            foreach (string s in keywords)
                searchQuery += s + " ";
            searchQuery = searchQuery.Trim();
            //working recent  // const string accessKey = "9e82d9bb720f4b85a94f680734db9385";
            const string accessKey = "9e82d9bb720f4b85a94f680734db9385";
            const string uriBase = "https://api.cognitive.microsoft.com/bing/v7.0/news/search";
            string searchTerm = searchQuery;
            var uriQuery = uriBase + "?q=" + Uri.EscapeDataString(searchTerm);
            WebRequest request = HttpWebRequest.Create(uriQuery);
            request.Headers["Ocp-Apim-Subscription-Key"] = accessKey;
            HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
            string json = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var searchResult = new SearchResult();
            searchResult.jsonResult = json;
            var errors = new List<string>();
            RootObjectFocus root = JsonConvert.DeserializeObject<RootObjectFocus>(json,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs earg)
                    {
                        errors.Add(earg.ErrorContext.Member.ToString());
                        earg.ErrorContext.Handled = true;
                    }
                });

            var ArticleList = root.value;
            int len = ArticleList.Count;
            titles = new string[len];
            int counter = 0;
            while (counter < len)
            {
                titles[counter] = ArticleList.ElementAt<Value>(counter).url;
                counter++;
            }

            return titles;

        }

        /// <summary> 
        /// This function returns a list of top 10 headlines in a news website
        /// </summary>
        /// <param name="URL"> The input URL</param>
        /// <return>array of news title coming as headlines in the respective news site</return>
        public string[] GetNewsHeadlines(string URL)
        {
            string[] titles = new string[10];
            var json = "";
            using (WebClient client = new WebClient())
            {
                json = client.DownloadString(URL);
            }

            var errors = new List<string>();
            RootObjectHeadlines root = JsonConvert.DeserializeObject<RootObjectHeadlines>(json,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include,
                    Error = delegate (object sender, Newtonsoft.Json.Serialization.ErrorEventArgs earg)
                    {
                        errors.Add(earg.ErrorContext.Member.ToString());
                        earg.ErrorContext.Handled = true;
                    }
                });

            var ArticleList = root.articles;
            int counter = 0;
            while (counter < 10)
            {
                titles[counter] = ArticleList.ElementAt<Article>(counter).title;
                counter++;
            }
            return titles;
        }

        struct SearchResult
        {
            public String jsonResult;
            public Dictionary<String, String> relevantHeaders;
        }
    }

    public class Instrumentation
    {
        public string pingUrlBase { get; set; }
        public string pageLoadPingUrl { get; set; }
    }

    public class Sort
    {
        public string name { get; set; }
        public string id { get; set; }
        public bool isSelected { get; set; }
        public string url { get; set; }
    }

    public class Thumbnail
    {
        public string contentUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Image
    {
        public Thumbnail thumbnail { get; set; }
    }

    public class About
    {
        public string readLink { get; set; }
        public string name { get; set; }
    }

    public class Thumbnail2
    {
        public string contentUrl { get; set; }
    }

    public class Image2
    {
        public Thumbnail2 thumbnail { get; set; }
    }

    public class Provider
    {
        public string _type { get; set; }
        public string name { get; set; }
        public Image2 image { get; set; }
    }

    public class Thumbnail3
    {
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Video
    {
        public string name { get; set; }
        public string thumbnailUrl { get; set; }
        public string embedHtml { get; set; }
        public bool allowHttpsEmbed { get; set; }
        public Thumbnail3 thumbnail { get; set; }
    }

    public class Value
    {
        public string name { get; set; }
        public string url { get; set; }
        public string urlPingSuffix { get; set; }
        public Image image { get; set; }
        public string description { get; set; }
        public List<About> about { get; set; }
        public List<Provider> provider { get; set; }
        public DateTime datePublished { get; set; }
        public string category { get; set; }
        public Video video { get; set; }
    }

    public class RootObjectFocus
    {
        public string _type { get; set; }
        public Instrumentation instrumentation { get; set; }
        public string readLink { get; set; }
        public int totalEstimatedMatches { get; set; }
        public List<Sort> sort { get; set; }
        public List<Value> value { get; set; }
    }

    public class Article
    {
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
    }

    public class RootObjectHeadlines
    {
        public string status { get; set; }
        public string source { get; set; }
        public string sortBy { get; set; }
        public List<Article> articles { get; set; }
    }











}

