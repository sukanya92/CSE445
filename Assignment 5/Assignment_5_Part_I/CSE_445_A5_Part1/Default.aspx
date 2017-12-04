<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <style>
            .my_text
            {
                font-family:    Calibri;
                font-size:      17px;
                color: black;
                border-style:solid double;
            }
      </style>
    <div style="background-color: cyan">
        <center><h1 style="color:black; font-family: Calibri; float:center">News Today</h1></center><br><br>
        <table border="2" style=" border-style: solid double; outline: solid double">
        <tr><td valign="top"> <h4 style="color: black; font-family: Calibri">Description: </h4></td><td> <h4 style="color: black; font-family: Calibri">  News Today Application provides location based information and additional utility services to users from multiple news sources</h4></td></tr>
        <tr><td valign="top"> <h4 style="color: black; font-family: Calibri">Group: </h4></td><td> <h4 style="color: black; font-family: Calibri">  37</h4></td></tr>
        <tr><td valign="top"> <h4 style="color: black; font-family: Calibri">Members: </h4></td><td> <h4 style="color: black; font-family: Calibri">  Sukanya Panda, Abhinethri Tumkur Umesh</h4></td></tr>
        </table><br>
        <a style="font-size:18px font-family: Calibri" href="index.aspx" runat="server">Service directory</a>
    </div>

    <div style="background-color: #FAE5D3  ;" class="my_text">
        <br>
        <h3>The following functionalities are offered by the application : </h3>
        <ol>
           <li><h4>News Headlines</h4></li>
           This service provides top 10 news headlines from multiple news agencies 
           <li><h4>News Focus Service</h4></li>
           This service provides news about any particular topic/keywords from across news sources
           <li><h4>Wind Intensity Service</h4></li>
           Wind Intensity Service provides the Annual Wind Intensity for a specific geographic location
           <li><h4>Solar Intensity Service</h4></li>
           Solar Intensity Service provides the Annual Solar Intensity for a specific geographic location
           <li><h4>Weather Information</h4></li>
           Weather information for for a specific geographic location
           <li><h4>TimeZone Information</h4></li>
           Information about Timezone, City and State for a specific geographic location
           <li><h4>Country Information</h4></li>
           This Service provides details of a particular Country like Region, Flag and Other related information
           <li><h4>Top 10 Words</h4></li>
           This service provides top 10 frequently occuring words for a particular website
        </ol>

        <br>
        <h4>How end users can signup for the services ? </h4>
        The end user has to sign up through the Member Registration link which let him obtain access to Member Page. Member Page is a previleged page which contains link to all the above services.
        <br>
        <br>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Memberpage" runat="server" Text="Member Page" OnClick="Memberpage_Click"/>&nbsp;&nbsp;
        <asp:Button ID="RegisterMember" runat="server" Text="Member Registration" OnClick="RegisterMember_Click"/>
        <br>
        <br>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Staffpage" runat="server" Text="Staff Page" OnClick="Staffpage_Click"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="RegisterStaff" runat="server" Text="Staff Registration" OnClick="RegisterStaff_Click"/>
        <br>
        <br>
        <h4>How the user can test the services ? </h4>
        The user can test the services by navigating to the respective pages from Member Page and all the services are listed with links in the service directory. The directory also includes test pages for the Local Component layer like Global.asax and DLL.
        <br>
        <br>
        <h4>What are the test cases or inputs ? </h4>
       <ol>
        <li><h4>News Headlines</h4></li>
        Test case : Select a newsagency from the dropdown
        <li><h4>News Focus Service</h4></li>
        Test case : Any given keyword which then gives relevant information on the same
        <li><h4>Wind Intensity Service</h4></li>
        Test case : Latitude(-90 to +89, no fractions or decimals) ; Longitude(-180 to +179, no fractions or decimals)
        <li><h4>Solar Intensity Service</h4></li>
        Test case : Latitude(-90 to +89, no fractions or decimals) ; Longitude(-180 to +179, no fractions or decimals)
        <li><h4>Weather Information</h4></li>
        Test case :  Enter City/State/Country name to get Weather Information
        <li><h4>TimeZone Information</h4></li>
        Test case :  Enter valid ZipCode to get information about Timezone, City and State
        <li><h4>Country Information</h4></li>
        Test case : Choose a Country name from the dropdown
        <li><h4>Top 10 Words</h4></li>
        Test case : All valid URLs
        <li><h4>DLL</h4></li>
        Test Case : Given a valid plain string, it will encrypt and decrypt the same on clicking the buttons.
        <li><h4>Global.asax for Event handler</h4></li>
        Test Case : A valid event has to be triggered to show the last accessed time and number of access requests made so far.
        <li><h4>User Control</h4></li>
        Test Case :  Enter string length n, an image will be displayed with random string (along with noise) of length n. Enter the String in the image for verification
        <li><h4>XML Manipulation</h4></li>
        Test Case : Enter username and password to add to Users.xml and search the users in Users.xml by providing the Username  <br />
        This page also displays list of usernames, check this list before entering the username as existing username cannot be added
        <li><h3>Cookies and Sessions</h3></li>
        When user logins for the 1st time, username and password will be stored in Cookies. From next time onwards, flow will be MainPage -> Welcome 
        If user clears Cookies(in welcome page) anytime then the flow will be MainPage --> Login --> Welcome
        Test Case : Use the following username and password for testing <br />
        username: abhi <br>
        Password: abhi
     </ol>
     <br>

    <p>Note : The Default.aspx page,Global.asax file with multiple Event Handlers and the DLL class library modules to implement encryption and decryption has been implemented as Part-1. The LogIn/LogOut Page for Member and Staff will be implemented in part-2</p>
    <br>
    <asp:Label ID="AccessRequest" runat="server"/>
    <br>
    <asp:Label ID="LabelStartTime" runat="server"/>
    <br>
</div>

</asp:Content>
