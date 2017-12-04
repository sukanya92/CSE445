<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CountryInfo.aspx.cs" Inherits="CountryInfo" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <br />
    <br />

            <span style="color:blue; font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"><u>Method: GetCountryInfo</u> <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        
            
                    <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Provides details of a particular Country like Region, Flag and Other related information based on the country name<span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
         
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Input: Country Name ( Type: string ) <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Output: Information related to the country chosen  ( Type: Array of strings ) <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        
            <br />
                       
            <div>

                
	   <asp:Label ID="Label_choosecountry" runat="server" Text="Choose the Country Name:"  ></asp:Label>  &nbsp;     
       <asp:DropDownList ID="Country" runat="server">

            <asp:ListItem Enabled="true" Text="United States of America" Value="United States of America"></asp:ListItem>

       <asp:ListItem Text="Afghanistan" Value="Afghanistan"></asp:ListItem>
       <asp:ListItem Text="Åland Islands" Value="Åland Islands"></asp:ListItem>
       <asp:ListItem Text="Albania" Value="Albania"></asp:ListItem>
       <asp:ListItem Text="Algeria" Value="Algeria"></asp:ListItem>
       <asp:ListItem Text="American Samoa" Value="American Samoa"></asp:ListItem>

       <asp:ListItem Text="Andorra" Value="Andorra"></asp:ListItem>
       <asp:ListItem Text="Angola" Value="Angola"></asp:ListItem>
       <asp:ListItem Text="Anguilla" Value="Anguilla"></asp:ListItem>
       <asp:ListItem Text="Antarctica" Value="Antarctica"></asp:ListItem>
       <asp:ListItem Text="Antigua and Barbuda" Value="Antigua and Barbuda"></asp:ListItem>

           <asp:ListItem Text="Argentina" Value="Argentina"></asp:ListItem>
       <asp:ListItem Text="Armenia" Value="Armenia"></asp:ListItem>
       <asp:ListItem Text="Aruba" Value="Aruba"></asp:ListItem>
       <asp:ListItem Text="Australia" Value="Australia"></asp:ListItem>
       <asp:ListItem Text="Austria" Value="Austria"></asp:ListItem>



       <asp:ListItem Text="Azerbaijan" Value="Azerbaijan"></asp:ListItem>
       <asp:ListItem Text="Bahamas" Value="Bahamas"></asp:ListItem>
       <asp:ListItem Text="Bahrain" Value="Bahrain"></asp:ListItem>
       <asp:ListItem Text="Bangladesh" Value="Bangladesh"></asp:ListItem>
       <asp:ListItem Text="Barbados" Value="Barbados"></asp:ListItem>

               <asp:ListItem Text="Belarus" Value="Belarus"></asp:ListItem>
       <asp:ListItem Text="Belgium" Value="Belgium"></asp:ListItem>
       <asp:ListItem Text="Belize" Value="Belize"></asp:ListItem>
       <asp:ListItem Text="Benin" Value="Benin"></asp:ListItem>
       <asp:ListItem Text="Bermuda" Value="Bermuda"></asp:ListItem>

       <asp:ListItem Text="Bhutan" Value="Bhutan"></asp:ListItem>
       <asp:ListItem Text="Bolivia (Plurinational State of)" Value="Bolivia (Plurinational State of)"></asp:ListItem>
       <asp:ListItem Text="Bonaire, Sint Eustatius and Saba" Value="Bonaire, Sint Eustatius and Saba"></asp:ListItem>
       <asp:ListItem Text="Bosnia and Herzegovina" Value="Bosnia and Herzegovina"></asp:ListItem>
       <asp:ListItem Text="Botswana" Value="Botswana"></asp:ListItem>


     

       <asp:ListItem Text="Bouvet Island" Value="Bouvet Island"></asp:ListItem>
       <asp:ListItem Text="Brazil" Value="Brazil"></asp:ListItem>
       <asp:ListItem Text="British Indian Ocean Territory" Value="British Indian Ocean Territory"></asp:ListItem>
       <asp:ListItem Text="Brunei Darussalam" Value="Brunei Darussalam"></asp:ListItem>
       <asp:ListItem Text="Bulgaria" Value="Bulgaria"></asp:ListItem>

       <asp:ListItem Text="Burkina Faso" Value="Burkina Faso"></asp:ListItem>
       <asp:ListItem Text="Burundi" Value="Burundi"></asp:ListItem>
       <asp:ListItem Text="Cabo Verde" Value="Cabo Verde"></asp:ListItem>
       <asp:ListItem Text="Cambodia" Value="Cambodia"></asp:ListItem>
       <asp:ListItem Text="Cameroon" Value="Cameroon"></asp:ListItem>

               <asp:ListItem Text="Canada" Value="Canada"></asp:ListItem>
       <asp:ListItem Text="Cayman Islands" Value="Cayman Islands"></asp:ListItem>
       <asp:ListItem Text="Central African Republic" Value="Central African Republic"></asp:ListItem>
       <asp:ListItem Text="Chad" Value="Chad"></asp:ListItem>
       <asp:ListItem Text="Chile" Value="Chile"></asp:ListItem>

       <asp:ListItem Text="China" Value="China"></asp:ListItem>
       <asp:ListItem Text="Christmas Island" Value="Christmas Island"></asp:ListItem>
       <asp:ListItem Text="Cocos (Keeling) Islands" Value="Cocos (Keeling) Islands"></asp:ListItem>
       <asp:ListItem Text="Colombia" Value="Colombia"></asp:ListItem>
       <asp:ListItem Text="Comoros" Value="Comoros"></asp:ListItem>


          
           <asp:ListItem Text="Congo" Value="Congo"></asp:ListItem>
       <asp:ListItem Text="Congo (Democratic Republic of the)" Value="Congo (Democratic Republic of the)"></asp:ListItem>
       <asp:ListItem Text="Cook Islands" Value="Cook Islands"></asp:ListItem>
       <asp:ListItem Text="Costa Rica" Value="Costa Rica"></asp:ListItem>
       <asp:ListItem Text="Côte d'Ivoire" Value="Côte d'Ivoire"></asp:ListItem>

       <asp:ListItem Text="Croatia" Value="Croatia"></asp:ListItem>
       <asp:ListItem Text="Cuba" Value="Cuba"></asp:ListItem>
       <asp:ListItem Text="Curaçao" Value="Curaçao"></asp:ListItem>
       <asp:ListItem Text="Cyprus" Value="Cyprus"></asp:ListItem>
       <asp:ListItem Text="Czech Republic" Value="Czech Republic"></asp:ListItem>

               <asp:ListItem Text="Denmark" Value="Denmark"></asp:ListItem>
       <asp:ListItem Text="Djibouti" Value="Djibouti"></asp:ListItem>


       <asp:ListItem Text="Dominica" Value="Dominica"></asp:ListItem>
       <asp:ListItem Text="Dominican Republic" Value="Dominican Republic"></asp:ListItem>
       <asp:ListItem Text="Ecuador" Value="Ecuador"></asp:ListItem>

       <asp:ListItem Text="Egypt" Value="Egypt"></asp:ListItem>
       <asp:ListItem Text="El Salvador" Value="El Salvador"></asp:ListItem>
       <asp:ListItem Text="Equatorial Guinea" Value="Equatorial Guinea"></asp:ListItem>
       <asp:ListItem Text="Eritrea" Value="Eritrea"></asp:ListItem>
       <asp:ListItem Text="Estonia" Value="Estonia"></asp:ListItem>


               <asp:ListItem Text="Ethiopia" Value="Ethiopia"></asp:ListItem>
       <asp:ListItem Text="Falkland Islands (Malvinas)" Value="Falkland Islands (Malvinas)"></asp:ListItem>
       <asp:ListItem Text="Faroe Islands" Value="Faroe Islands"></asp:ListItem>
       <asp:ListItem Text="Fiji" Value="Fiji"></asp:ListItem>
       <asp:ListItem Text="Finland" Value="Finland"></asp:ListItem>

       <asp:ListItem Text="France" Value="France"></asp:ListItem>
       <asp:ListItem Text="French Guiana" Value="French Guiana"></asp:ListItem>
       <asp:ListItem Text="French Polynesia" Value="French Polynesia"></asp:ListItem>
       <asp:ListItem Text="French Southern Territories" Value="French Southern Territories"></asp:ListItem>
       <asp:ListItem Text="Gabon" Value="Gabon"></asp:ListItem>


               <asp:ListItem Text="Gambia" Value="Gambia"></asp:ListItem>
       <asp:ListItem Text="Georgia" Value="Georgia"></asp:ListItem>
       <asp:ListItem Text="Germany" Value="Germany"></asp:ListItem>
       <asp:ListItem Text="Ghana" Value="Ghana"></asp:ListItem>
       <asp:ListItem Text="Gibraltar" Value="Gibraltar"></asp:ListItem>

       <asp:ListItem Text="Greece" Value="Greece"></asp:ListItem>
       <asp:ListItem Text="Greenland" Value="Grenada"></asp:ListItem>
       <asp:ListItem Text="Grenada" Value="Grenada"></asp:ListItem>
       <asp:ListItem Text="Guadeloupe" Value="Guadeloupe"></asp:ListItem>
       <asp:ListItem Text="Guam" Value="Guam"></asp:ListItem>
               <asp:ListItem Text="Guatemala" Value="Guatemala"></asp:ListItem>
       <asp:ListItem Text="Guernsey" Value="Guernsey"></asp:ListItem>
       <asp:ListItem Text="Guinea" Value="Guinea"></asp:ListItem>
       <asp:ListItem Text="Guinea-Bissau" Value="Guinea-Bissau"></asp:ListItem>
       <asp:ListItem Text="Guyana" Value="Guyana"></asp:ListItem>

       <asp:ListItem Text="Haiti" Value="Haiti"></asp:ListItem>
       <asp:ListItem Text="Heard Island and McDonald Islands" Value="Heard Island and McDonald Islands"></asp:ListItem>
       <asp:ListItem Text="Holy See" Value="Holy See"></asp:ListItem>
       <asp:ListItem Text="Honduras" Value="Honduras"></asp:ListItem>
       <asp:ListItem Text="Hong Kong" Value="Hong Kong"></asp:ListItem>

             <asp:ListItem Text="Hungary" Value="Hungary"></asp:ListItem>
       <asp:ListItem Text="Iceland" Value="Iceland"></asp:ListItem>
       <asp:ListItem Text="India" Value="India"></asp:ListItem>
       <asp:ListItem Text="Indonesia" Value="Indonesia"></asp:ListItem>
       <asp:ListItem Text="Iran (Islamic Republic of)" Value="Iran (Islamic Republic of)"></asp:ListItem>

       <asp:ListItem Text="Iraq" Value="Iraq"></asp:ListItem>
       <asp:ListItem Text="Ireland" Value="Ireland"></asp:ListItem>
       <asp:ListItem Text="Isle of Man" Value="Isle of Man"></asp:ListItem>
       <asp:ListItem Text="Israel" Value="Israel"></asp:ListItem>
       <asp:ListItem Text="Italy" Value="Italy"></asp:ListItem>

           <asp:ListItem Text="Jamaica" Value="Jamaica"></asp:ListItem>
       <asp:ListItem Text="Japan" Value="Japan"></asp:ListItem>
       <asp:ListItem Text="Jersey" Value="Jersey"></asp:ListItem>
       <asp:ListItem Text="Jordan" Value="Jordan"></asp:ListItem>
       <asp:ListItem Text="Kazakhstan" Value="Kazakhstan"></asp:ListItem>

          

       <asp:ListItem Text="Kenya" Value="Kenya"></asp:ListItem>
       <asp:ListItem Text="Kiribati" Value="Kiribati"></asp:ListItem>
       <asp:ListItem Text="Korea (Democratic People's Republic of)" Value="Korea (Democratic People's Republic of)"></asp:ListItem>
       <asp:ListItem Text="Korea (Republic of)" Value="Korea (Republic of)"></asp:ListItem>
     

               <asp:ListItem Text="Kuwait" Value="Kuwait"></asp:ListItem>
       <asp:ListItem Text="Kyrgyzstan" Value="Kyrgyzstan"></asp:ListItem>
       <asp:ListItem Text="Lao People's Democratic Republic" Value="Lao People's Democratic Republic"></asp:ListItem>
       <asp:ListItem Text="Latvia" Value="Latvia"></asp:ListItem>
       <asp:ListItem Text="Lebanon" Value="Lebanon"></asp:ListItem>


       <asp:ListItem Text="Lesotho" Value="Lesotho"></asp:ListItem>
       <asp:ListItem Text="Liberia" Value="Liberia"></asp:ListItem>
       <asp:ListItem Text="Libya" Value="Libya"></asp:ListItem>
       <asp:ListItem Text="Liechtenstein" Value="Liechtenstein"></asp:ListItem>
       <asp:ListItem Text="Lithuania" Value="Lithuania"></asp:ListItem>

               <asp:ListItem Text="Luxembourg" Value="Luxembourg"></asp:ListItem>
       <asp:ListItem Text="Macao" Value="Macao"></asp:ListItem>
       <asp:ListItem Text="Macedonia (the former Yugoslav Republic of)" Value="Macedonia (the former Yugoslav Republic of)"></asp:ListItem>
       <asp:ListItem Text="Madagascar" Value="Madagascar"></asp:ListItem>
       <asp:ListItem Text="Malawi" Value="Malawi"></asp:ListItem>

       <asp:ListItem Text="Malaysia" Value="Malaysia"></asp:ListItem>

        
       <asp:ListItem Text="Maldives" Value="Maldives"></asp:ListItem>
       <asp:ListItem Text="Mali" Value="Mali"></asp:ListItem>
       <asp:ListItem Text="Malta" Value="Malta"></asp:ListItem>
       <asp:ListItem Text="Marshall Islands" Value="Marshall Islands"></asp:ListItem>

               <asp:ListItem Text="Martinique" Value="Martinique"></asp:ListItem>
       <asp:ListItem Text="Mauritania" Value="Mauritania"></asp:ListItem>
       <asp:ListItem Text="Mauritius" Value="Mauritius"></asp:ListItem>
       <asp:ListItem Text="Mayotte" Value="Mayotte"></asp:ListItem>
       <asp:ListItem Text="Mexico" Value="Mexico"></asp:ListItem>

       <asp:ListItem Text="Micronesia (Federated States of)" Value="Micronesia (Federated States of)"></asp:ListItem>
       <asp:ListItem Text="Moldova (Republic of)" Value="Moldova (Republic of)"></asp:ListItem>
       <asp:ListItem Text="Monaco" Value="Monaco"></asp:ListItem>
       <asp:ListItem Text="Mongolia" Value="Mongolia"></asp:ListItem>
       <asp:ListItem Text="Montenegro" Value="Montenegro"></asp:ListItem>
               <asp:ListItem Text="Montserrat" Value="Montserrat"></asp:ListItem>
       <asp:ListItem Text="Morocco" Value="Morocco"></asp:ListItem>
       <asp:ListItem Text="Mozambique" Value="Mozambique"></asp:ListItem>
       <asp:ListItem Text="Myanmar" Value="Myanmar"></asp:ListItem>
       <asp:ListItem Text="Namibia" Value="Namibia"></asp:ListItem>

       <asp:ListItem Text="Nauru" Value="Nauru"></asp:ListItem>
       <asp:ListItem Text="Nepal" Value="Nepal"></asp:ListItem>
       <asp:ListItem Text="Netherlands" Value="Netherlands"></asp:ListItem>
       <asp:ListItem Text="New Caledonia" Value="New Caledonia"></asp:ListItem>
       <asp:ListItem Text="New Zealand" Value="New Zealand"></asp:ListItem>

               <asp:ListItem Text="Nicaragua" Value="Nicaragua"></asp:ListItem>
       <asp:ListItem Text="Niger" Value="Niger"></asp:ListItem>
       <asp:ListItem Text="Nigeria" Value="Nigeria"></asp:ListItem>
       <asp:ListItem Text="Niue" Value="Niue"></asp:ListItem>
       <asp:ListItem Text="Norfolk Island" Value="Norfolk Island"></asp:ListItem>

       <asp:ListItem Text="Northern Mariana Islands" Value="Northern Mariana Islands"></asp:ListItem>



       <asp:ListItem Text="Norway" Value="Norway"></asp:ListItem>
       <asp:ListItem Text="Oman" Value="Oman"></asp:ListItem>
       <asp:ListItem Text="Pakistan" Value="Pakistan"></asp:ListItem>
       <asp:ListItem Text="Palau" Value="Palau"></asp:ListItem>
               <asp:ListItem Text="Palestine, State of" Value="Palestine, State of"></asp:ListItem>

       <asp:ListItem Text="Panama" Value="Panama"></asp:ListItem>
       <asp:ListItem Text="Papua New Guinea" Value="Papua New Guinea"></asp:ListItem>
       <asp:ListItem Text="Paraguay" Value="Paraguay"></asp:ListItem>
       <asp:ListItem Text="Philippines" Value="Philippines"></asp:ListItem>

       <asp:ListItem Text="Peru" Value="Peru"></asp:ListItem>
       <asp:ListItem Text="Pitcairn" Value="Pitcairn"></asp:ListItem>
       <asp:ListItem Text="Poland" Value="Poland"></asp:ListItem>
       <asp:ListItem Text="Portugal" Value="Portugal"></asp:ListItem>



       <asp:ListItem Text="Puerto Rico" Value="Puerto Rico"></asp:ListItem>
               <asp:ListItem Text="Qatar" Value="Qatar"></asp:ListItem>
       <asp:ListItem Text="Republic of Kosovo" Value="Republic of Kosovo"></asp:ListItem>
       <asp:ListItem Text="Réunion" Value="Réunion"></asp:ListItem>
       <asp:ListItem Text="Romania" Value="Romania"></asp:ListItem>
       <asp:ListItem Text="Russian Federation" Value="Russian Federation"></asp:ListItem>



       <asp:ListItem Text="Rwanda" Value="Rwanda"></asp:ListItem>
       <asp:ListItem Text="Saint Barthélemy" Value="Saint Barthélemy"></asp:ListItem>
       <asp:ListItem Text="Saint Helena, Ascension and Tristan da Cunha" Value="Saint Helena, Ascension and Tristan da Cunha"></asp:ListItem>
       <asp:ListItem Text="Saint Kitts and Nevis" Value="Saint Kitts and Nevis"></asp:ListItem>
       <asp:ListItem Text="Saint Lucia" Value="Saint Lucia"></asp:ListItem>
               <asp:ListItem Text="Saint Martin (French part)" Value="Saint Martin (French part)"></asp:ListItem>
       <asp:ListItem Text="Saint Pierre and Miquelon" Value="Saint Pierre and Miquelon"></asp:ListItem>
       <asp:ListItem Text="Saint Vincent and the Grenadines" Value="Saint Vincent and the Grenadines"></asp:ListItem>
       <asp:ListItem Text="Samoa" Value="Samoa"></asp:ListItem>
       <asp:ListItem Text="San Marino" Value="San Marino"></asp:ListItem>

       <asp:ListItem Text="Sao Tome and Principe" Value="Sao Tome and Principe"></asp:ListItem>



       <asp:ListItem Text="Saudi Arabia" Value="Saudi Arabia"></asp:ListItem>
       <asp:ListItem Text="Senegal" Value="Senegal"></asp:ListItem>
       <asp:ListItem Text="Serbia" Value="Serbia"></asp:ListItem>
       <asp:ListItem Text="Seychelles" Value="Seychelles"></asp:ListItem>

             <asp:ListItem Text="Sierra Leone" Value="Sierra Leone"></asp:ListItem>
       <asp:ListItem Text="Singapore" Value="Singapore"></asp:ListItem>
       <asp:ListItem Text="Sint Maarten (Dutch part)" Value="Sint Maarten (Dutch part)"></asp:ListItem>
       <asp:ListItem Text="Slovakia" Value="Slovakia"></asp:ListItem>
       <asp:ListItem Text="Slovenia" Value="Slovenia"></asp:ListItem>

          


       <asp:ListItem Text="Solomon Islands" Value="Solomon Islands"></asp:ListItem>
       <asp:ListItem Text="Somalia" Value="Somalia"></asp:ListItem>
       <asp:ListItem Text="South Africa" Value="South Africa"></asp:ListItem>
       <asp:ListItem Text="South Georgia and the South Sandwich Islands" Value="South Georgia and the South Sandwich Islands"></asp:ListItem>
       <asp:ListItem Text="South Sudan" Value="South Sudan"></asp:ListItem>

           <asp:ListItem Text="Spain" Value="Spain"></asp:ListItem>
       <asp:ListItem Text="Sri Lanka" Value="Sri Lanka"></asp:ListItem>
       <asp:ListItem Text="Sudan" Value="Sudan"></asp:ListItem>
       <asp:ListItem Text="Suriname" Value="Suriname"></asp:ListItem>
       <asp:ListItem Text="Svalbard and Jan Mayen" Value="Svalbard and Jan Mayen"></asp:ListItem>

       <asp:ListItem Text="Swaziland" Value="Swaziland"></asp:ListItem>
       <asp:ListItem Text="Sweden" Value="Sweden"></asp:ListItem>
       <asp:ListItem Text="Switzerland" Value="Switzerland"></asp:ListItem>
       <asp:ListItem Text="Syrian Arab Republic" Value="Syrian Arab Republic"></asp:ListItem>
       <asp:ListItem Text="Taiwan, Province of China" Value="Taiwan, Province of China"></asp:ListItem>

               <asp:ListItem Text="Tajikistan" Value="Tajikistan"></asp:ListItem>

           


       <asp:ListItem Text="Tanzania, United Republic of" Value="Tanzania, United Republic of"></asp:ListItem>
       <asp:ListItem Text="Thailand" Value="Thailand"></asp:ListItem>
       <asp:ListItem Text="Timor-Leste" Value="Timor-Leste"></asp:ListItem>
       <asp:ListItem Text="Togo" Value="Togo"></asp:ListItem>

       <asp:ListItem Text="Tokelau" Value="Tokelau"></asp:ListItem>
       <asp:ListItem Text="Tonga" Value="Tonga"></asp:ListItem>
       <asp:ListItem Text="Trinidad and Tobago" Value="Trinidad and Tobago"></asp:ListItem>
       <asp:ListItem Text="Tunisia" Value="Tunisia"></asp:ListItem>
       <asp:ListItem Text="Turkey" Value="Turkey"></asp:ListItem>

     


           <asp:ListItem Text="Turkmenistan" Value="Turkmenistan"></asp:ListItem>

               <asp:ListItem Text="Turks and Caicos Islands" Value="Turks and Caicos Islands"></asp:ListItem>
       <asp:ListItem Text="Tuvalu" Value="Tuvalu"></asp:ListItem>
       <asp:ListItem Text="Uganda" Value="Uganda"></asp:ListItem>
       <asp:ListItem Text="Ukraine" Value="Ukraine"></asp:ListItem>
       <asp:ListItem Text="United Arab Emirates" Value="United Arab Emirates"></asp:ListItem>

       <asp:ListItem Text="United Kingdom of Great Britain and Northern Ireland" Value="United Kingdom of Great Britain and Northern Ireland"></asp:ListItem>
       <asp:ListItem Text="United States Minor Outlying Islands" Value="United States Minor Outlying Islands"></asp:ListItem>
      
       <asp:ListItem Text="Uruguay" Value="Uruguay"></asp:ListItem>
       <asp:ListItem Text="Uzbekistan" Value="Uzbekistan"></asp:ListItem>

               <asp:ListItem Text="Vanuatu" Value="Vanuatu"></asp:ListItem>
       <asp:ListItem Text="Venezuela (Bolivarian Republic of)" Value="Venezuela (Bolivarian Republic of)"></asp:ListItem>
       <asp:ListItem Text="Viet Nam" Value="Viet Nam"></asp:ListItem>
       <asp:ListItem Text="Virgin Islands (British)" Value="Virgin Islands (British)"></asp:ListItem>
       <asp:ListItem Text="Virgin Islands (U.S.)" Value="Virgin Islands (U.S.)"></asp:ListItem>

       <asp:ListItem Text="Wallis and Futuna" Value="Wallis and Futuna"></asp:ListItem>
       <asp:ListItem Text="Western Sahara" Value="Western Sahara"></asp:ListItem>
       <asp:ListItem Text="Yemen" Value="Yemen"></asp:ListItem>
       <asp:ListItem Text="Zambia" Value="Zambia"></asp:ListItem>
       <asp:ListItem Text="Zimbabwe" Value="Zimbabwe"></asp:ListItem>
            

             





       </asp:DropDownList>  &nbsp;   &nbsp;  

     

     
              <asp:Button ID="button3" runat="server" Width="80px" OnClick="button3_Click" Text="Submit" />

                	</div>  

	 

        

        <asp:Label ID="Label14" runat="server" Text="Alpha2Code:" Width="100px" ></asp:Label>   &nbsp; 
        <asp:Label ID="Alpha2Code" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  
          
        <asp:Label ID="Label15" runat="server" Text="Alpha3Code:" Width="100px" ></asp:Label>   &nbsp;  
        <asp:Label ID="Alpha3Code" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  

         <asp:Label ID="Label16" runat="server" Text="CurrencyCode:" Width="100px" ></asp:Label>   &nbsp; 
        <asp:Label ID="CurrencyCode" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  

         <asp:Label ID="Label17" runat="server" Text="CurrencyName:" Width="100px" ></asp:Label>   &nbsp; 
        <asp:Label ID="CurrencyName" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>
    
         <asp:Label ID="Label18" runat="server" Text="Region:" Width="100px"></asp:Label>   &nbsp; 
        <asp:Label ID="Region" text-align="center"    ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  
    
         <asp:Label ID="Label19" runat="server" Text="SubRegion:" Width="100px" ></asp:Label>   &nbsp;  
        <asp:Label ID="SubRegion" text-align="center"  ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  

         <asp:Label ID="Label20" runat="server" Text="Latitude:" Width="100px" ></asp:Label>   &nbsp;  
        <asp:Label ID="Latitude" text-align="center"    ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  

         <asp:Label ID="Label21" runat="server" Text="Longitude:" Width="100px" ></asp:Label>   &nbsp;  
        <asp:Label ID="Longitude" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  

         <asp:Label ID="Label22" runat="server" Text="NativeLanguage:" Width="100px" ></asp:Label>   &nbsp;  
        <asp:Label ID="NativeLanguage" text-align="center"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  

        <asp:Label ID="Label23" runat="server" Text="Flag:" Width="100px" ></asp:Label>   &nbsp; 
       <asp:Label ID="Flag" text-align="center"    ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>  

       <asp:Label ID="Error1" text-align="center" font-size="20px"   ForeColor="red"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>    


               
    
    




    
    

</asp:Content>
