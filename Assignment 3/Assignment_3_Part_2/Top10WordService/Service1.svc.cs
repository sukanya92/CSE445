using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace Top10WordService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string[] GetTop10Words(string URL)
        {
            Web2StringService.ServiceClient proxy = new Web2StringService.ServiceClient();
            string[] result = new string[10];
            string pageSource = proxy.GetWebContent(URL);
            Console.WriteLine(pageSource);
            Regex removeScript = new Regex(@"<script[^>]*>[\s\S]*?</script>");
            Regex removeStyle = new Regex(@"<style[^>]*>[\s\S]*?</style>");
            Regex removeTags = new Regex(@"<.*?>");
            Regex removeNonbrkSpc = new Regex(@"&.*?;");
            Regex removePara = new Regex(@"<p[^>]*>[\s\S]*?</p>");
            Regex removeBraces = new Regex(@"<[^>]+>|&nbsp;");
            Regex removeLine= new Regex(@"\ +(?= (\n |\r ?$))");
            Regex removeSpace = new Regex(@"[' ']*?$");
            Regex removeNonPrintChar = new Regex(@"\p{C}+");
            Regex removeMultispace = new Regex(@"\s+");
            Regex removeURL = new Regex(@"http[^\s]+");
            Regex removeNonChar = new Regex(@"[^a-zA-Z]");

            string filteredString1 = removeScript.Replace(pageSource, " ");
            string filteredString2 = removeStyle.Replace(filteredString1, " ");
            string filteredString3 = removeTags.Replace(filteredString2, " ");
            string filteredString4 = removeNonbrkSpc.Replace(filteredString3, " ");
            string filteredString5 = removePara.Replace(filteredString4, " ");
            string filteredString6 = removeBraces.Replace(filteredString5, " ");
            string filteredString7 = removeLine.Replace(filteredString6, " ");
            string filteredString8 = removeSpace.Replace(filteredString7, " ");
            string filteredString9 = removeNonPrintChar.Replace(filteredString8, " ");
            string filteredString10 = removeMultispace.Replace(filteredString9, " ");
            string filteredString11 = removeURL.Replace(filteredString10, " ");
            string filteredString12 = removeNonChar.Replace(filteredString11, " ");

            string filteredString13 = filteredString12.ToLower();

            var words = filteredString13.Split(' ')
                .Where(w => w.Length > 3)
                .GroupBy(w => w)
                .Select(w => new { Count = w.Count(), word = w.Key })
                .OrderByDescending(w => w.Count);
            int counter = 0;

            foreach(var item in words)
            {
                if (counter < 10)
                {
                    result[counter] = item.word + " : " + item.Count;
                }
                else break;
            }
            return result;

        }


    }
}
