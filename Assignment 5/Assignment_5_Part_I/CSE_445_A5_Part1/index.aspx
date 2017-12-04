﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <html><head></head><body>
<table style="width:100%" border="1">
  <h1><center> This page is deployed at: <a href="http://webstrar37.fulton.asu.edu/page1/index.html">http://webstrar37.fulton.asu.edu/page1/index.html</a>  <br /> 
  </center></h1>
  <tr>
    <th>Provider name</th>
    <th>Component name</th>
    <th>Operation name, with input and output types</th>
	<th>TryIt link</th>
	<th width="200px">Operation/Service description</th>
	<th>Actual resources used to implement the service</th>
  </tr>
  
    <tr>
     <td>Sukanya</td>
    <td>DLL</td>
    <td>Method: Encrypt/Decrypt<br/>
Input: Plain/Encrypted String ( Type: String ) <br/> 
Output: Encrypted/Plain String ( Type: String )  </td>
<td> <a href="http://webstrar37.fulton.asu.edu/page1/TryItDll.aspx">TryIt Page</a></td>
	<td>This component provides a Library to be used in the web application</td>
	<td>The code for Encryption and Decryption has been used<br/> </td>
         
  </tr>
    <tr>
	
	
     <td>Sukanya</td>
    <td>Global.asax</td>
    <td>Method: Application_Start/Application_End/Application_BeginRequest</br>  
These are global Event Handlers which gets triggered from application context</br> 
</td>
	
	<td><a href= "http://webstrar37.fulton.asu.edu/page1/TryItGlobal.aspx">TryIt Page</td>
	<td>This file contains all the Global Event Handlers</td>
	<td>All Application level Event Handlers are used</td>
  </tr>
  
  
    <tr>
     <td>Sukanya</td>
    <td>Service</td>
     <td>Method: GetTop10Words<br>Input: URL(Type - String)<br>Output: List of words(Type - String[])<br></td>
	 <td><a href="http://webstrar37.fulton.asu.edu/page1/Top10Words.aspx">TryIt Page</a></td><br>
	 <td>Analyzes page content of a webpage at a given URL and returns top 10 most frequent words with descending order</td>
	 <td>Referred Web2StringService from <a href="http://neptune.fulton.ad.asu.edu/WSRepository/Services/Web2StringSVC/Service.svc">ASU Service Link</a><br>Used multiple regex for filtering out unwanted words
     </td>
    </tr>
    <tr>
     <td>Sukanya</td>
    <td>Service</td>
     <td>Method: GetWindEnergyIndex<br>Input: lat, long(Type - (Int32, Int32) Range - lat:-90 to 89, long:-180 to 179 )<br>Output: Wind Intensity(Type - double)<br></td>
     <td><a href="http://webstrar37.fulton.asu.edu/page1/WindEnergyIndex.aspx">TryIt Page</a></td><br>
     <td>This service returns the annual Wind intensity index for a specific location identified by pair of latitude and longitude</td>
     <td>Retrieved the data source from <a href="https://eosweb.larc.nasa.gov/sse/global/text/10yr_wspd50m">Text File</a></td>
    </tr>
     <td>Sukanya</td>
    <td>Service</td>
     <td>Method: GetNewsFocus<br>Input: keyword(s)(Type - String[])<br>Output: List of URLs(Type - String[])<br></td>
     <td><a href="http://webstrar37.fulton.asu.edu/page1/NewsFocus.aspx">TryIt Page</a></td><br>
     <td>This service returns the a list of news URLs where a given topic identified by list of keywords are reported</td>
     <td>Referred News search API provided by Microsoft Bing at <a href="https://api.cognitive.microsoft.com/bing/v7.0/news/search">News Focus API</a><br>Used newtonsoft libray to parse JSON
     </td>
   </tr>
   <tr>
    <td>Sukanya</td>
    <td>Service</td>
    <td>Method: GetNewsHeadlines<br>Input: URL(Type - String)<br>Output: List of News Titles(Type - String[])<br></td>
    <td><a href="http://webstrar37.fulton.asu.edu/page1/NewsHeadLines.aspx">TryIt Page</a></td><br>
    <td>This service returns the a list of news topics or news headlines from a specific news source identified by a unique URL</td>
    <td>Referred News API provided by NewsAPI at <a href="https://newsapi.org/">News Headlines API</a><br>Used newtonsoft libray to parse JSON
    </td>
  </tr>














                             <tr>
                                 <td>Abhinethri</td>
                                 <td>Web Service</td>
                                 <td>
                                     <b>Method:</b> TimeZoneInfo
                                     <br />
                                     <b>Input:</b> ZipCode ( Type: Integer )
                                     <br />
                                     <b>Output:</b> Information about Timezone, City and State ( Type: Array of String )
                                 </td>
                                 <td><a href="http://webstrar37.fulton.asu.edu/page7/TimeZoneInfo">TryIt Page</a></td>
                                 <td>Displays City, State and TimeZone information based on Zipcodes of United States  </td>
                                 <td>
                                     The timeZone Info has been retrieved from <a href="https://www.zipcodeapi.com/">https://www.zipcodeapi.com/ </a>
                                     <br />
                                     Have used newtonsoft libray to parse JSON
                                 </td>
                             </tr>
                             <tr>
                                 <td>Abhinethri</td>
                                 <td>Web Service</td>
                                 <td>
                                     <b>Method:</b> WeatherInfo
                                     <br />
                                     <b>Input:</b> City/State/Country ( Type: string )
                                     <br />
                                     <b> Output:</b> Information about Temperature, SkyText, Humidity and wind ( Type: Array of String )
                                 </td>
                                 <td><a href="http://webstrar37.fulton.asu.edu/page7/WeatherInfo">TryIt Page</a></td>
                                 <td>Displays Weather information based on City/State/Country name  </td>
                                 <td>
                                     The Weather info has been retrieved from <a href="https://www.zipcodeapi.com/">https://5dayweather.org/api.php/ </a>
                                     <br />
                                     Have used newtonsoft libray to parse JSON
                                 </td>

                             </tr>
                             <tr>
                                 <td>Abhinethri</td>
                                 <td>Web Service</td>
                                 <td>
                                     <b>Method:</b> GetCountryInfo
                                     <br />
                                     <b>Input:</b> Country Name ( Type: string )
                                     <br />
                                     <b>Output:</b> Information related to the country chosen ( Type: Array of strings )
                                 </td>
                                 <td><a href="http://webstrar37.fulton.asu.edu/page7/CountryInfo">TryIt Page </a></td>
                                 <td>Provides details of a particular Country like Region, Flag and Other related information based on the country name </td>
                                 <td>
                                     The Country Info has been retrievedved from <a href="http://countryapi.gear.host/v1/Country/getCountries">http://countryapi.gear.host/v1/Country/getCountries </a>
                                     <br />
                                 </td>



                             </tr>


                             <tr>


                                 <td>Abhinethri</td>
                                 <td>Web Service</td>
                                 <td>
                                     <b> Method:</b> SolarIntensity  </br>
                                     <b>Input:</b> latitude and longitude ( Type: Integer, Range: -90 to 89 )  </br>
                                     <b>Output:</b> Solar Intensity ( Type: Double, Range: -180 to 179 )
                                 </td>

                                 <td><a href="http://webstrar37.fulton.asu.edu/page7/Solarintensity">TryIt Page </td>
                                 <td>The Solar Energy Service in this TryIt page returns the annual solar geometry of a given position </td>
                                 <td>
                                     Retrieved the annual solar geometry from <a href="https://eosweb.larc.nasa.gov/cgi-bin/sse/global.cgi?email=skip@larc.nasa.gov">https://eosweb.larc.nasa.gov/cgi-bin/sse/global.cgi?email=skip@larc.nasa.gov </a>
                                     <br />
                                 </td>
                             </tr>


                             <tr>
                                 <td>Abhinethri </td>
                                 <td>UserControl </td>
                                 <td>
                                     <b>Method:</b> Image Verifier
                                     <br />
                                     <b>Input:</b> Length of the String ( Type: Integer )
                                     <br />
                                     <b>Output:</b> An Image with noise will be displayed based on the length of the string, user has to re-enter the string for verification
                                 </td>
                                 <td><a href="http://webstrar37.fulton.asu.edu/page7/UserControlDemo">TryIt Page </td>
                                 <td>Image Verifier has been implemented as UserControl which is required for Staff and member SignUp (Length of the string will be 6 by default in the final applications) </td>
                                 <td>Random string is being obtained from <a>http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/ </a></td>
                             </tr>


                             <tr>
                                 <td>Abhinethri</td>
                                 <td>XML Manipulation</td>
                                 <td>
                                     <b>Method:</b> Add and Search User   <br />
                                     <b>For add user, Input:</b> Enter Username and Password ( Type: string,string )   <br />
                                     <b>Output:</b> Success/Unsuccess ( Type: string ) <br />
                                     <b>For Search User, Input:</b> Username  ( Type: string )   <br />
                                     <b> Output: </b> User Exist or not ( Type: string )   <br />
                                     <br />
                                 </td>
                                 <td><a href="http://webstrar37.fulton.asu.edu/page7/AddandSearch">TryIt Page</td>
                                 <td>
                                     User can be added by giving username and password <br />
                                     Also, can search for user
                                 </td>
                                 <td>
                                     XML Manipulation, Reference: CHEN  YINONG, TSAI  WEI-TEK-Service-Oriented Computing and Web Software Integration_ From Principles to Development </a>
                                     <br />
                                 </td>
                             </tr>

                             <tr>
                             <td>Abhinethri</td>
                             <td>Cookies and Session</td>
                             <td>
                                 <b>Method:</b> Clear Cookies
                                 <br />
                                 Clear the cookies by clicking 'Clear Cookies' <br />
                                 <b>
                                     Use the following username and password for testing:     <br />
                                     <u> username: abhi  </u>     <br />
                                     <u>   Password: abhi </u>
                                 </b>  <br />
                                 <br />
                                 Session is used to display the username in 'Welcome' page
                             </td>

                             <td><a href="http://webstrar37.fulton.asu.edu/page7/MainPage"> TryIt Page </td>
                             <td>
                                 When user logins for the 1st time, username and password will be stored in Cookies. From 2nd time onwards, flow will be <b>MainPage -> Welcome</b> <br />
                                 If user clears Cookies(in welcome page) anytime then the flow will be <b>MainPage --> Login --> Welcome</b>
                             </td>
                             <td>
                                 Cookies and Session implementation,  Reference: CHEN  YINONG, TSAI  WEI-TEK-Service-Oriented Computing and Web Software Integration_ From Principles to Development
                                 <br />

                             </td>
                             </tr>
</table>
    </body>
</html>
    
</asp:Content>
