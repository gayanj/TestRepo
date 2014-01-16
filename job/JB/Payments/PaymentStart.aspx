<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="PaymentStart.aspx.cs" Inherits="JB.Payments.Paymentstart" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="boxcorner">
        <br />
        <br />
        <div id="wrapjobsbyrectop">
            <div class="ft_notify">
                <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
            </div>
            <div id="wrapjobsbyrecleft">
                <img alt="one" src="/images/nm_one.gif" /><asp:Label ID="Label1" runat="server"
                    Text="FirstName" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textfirstname"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textfirstname" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="two" src="/images/nm_two.gif" />
                <asp:Label ID="Label2" runat="server" Text="LastName" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Textlastname"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textlastname" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="three" src="/images/nm_three.gif" />
                <asp:Label ID="Label3" runat="server" Text="AddressLine1" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Textaddress1"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textaddress1" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="four" src="/images/nm_four.gif" />
                <asp:Label ID="Label4" runat="server" Text="AddressLine2" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Textaddress2"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textaddress2" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="five" src="/images/nm_five.gif" />
                <asp:Label ID="Label5" runat="server" Text="AddressLine3" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Textaddress3"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textaddress3" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="six" src="/images/nm_six.gif" />
                <asp:Label ID="Label6" runat="server" Text="City" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Textcity"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textcity" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="seven" src="/images/nm_seven.gif" />
                <asp:Label ID="Label7" runat="server" Text="County" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Textcounty"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textcounty" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="eight" src="/images/nm_eight.gif" />
                <asp:Label ID="Label8" runat="server" Text="Postcode" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Textpostcode"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="Textpostcode" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="nine" src="/images/nm_nine.gif" />
                <asp:Label ID="Label13" runat="server" Text="Country" CssClass="ft_black"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownCountry" runat="server">
                    <asp:ListItem Value="CAN">Canada</asp:ListItem>
                    <asp:ListItem Value="AUS">Australia</asp:ListItem>
                    <asp:ListItem Value="AFG">Afghanistan</asp:ListItem>
                    <asp:ListItem Value="ALB">Albania</asp:ListItem>
                    <asp:ListItem Value="DZA">Algeria</asp:ListItem>
                    <asp:ListItem Value="ASM">American Samoa</asp:ListItem>
                    <asp:ListItem Value="AND">Andorra</asp:ListItem>
                    <asp:ListItem Value="AGO">Angola</asp:ListItem>
                    <asp:ListItem Value="AIA">Anguilla</asp:ListItem>
                    <asp:ListItem Value="ATA">Antarctica</asp:ListItem>
                    <asp:ListItem Value="ATG">Antigua and Barbuda</asp:ListItem>
                    <asp:ListItem Value="ARG">Argentina</asp:ListItem>
                    <asp:ListItem Value="ARM">Armenia</asp:ListItem>
                    <asp:ListItem Value="ABW">Aruba</asp:ListItem>
                    <asp:ListItem Value="AUS">Australia</asp:ListItem>
                    <asp:ListItem Value="AUT">Austria</asp:ListItem>
                    <asp:ListItem Value="AZE">Azerbaijan</asp:ListItem>
                    <asp:ListItem Value="BHS">Bahamas</asp:ListItem>
                    <asp:ListItem Value="BHR">Bahrain</asp:ListItem>
                    <asp:ListItem Value="BGD">Bangladesh</asp:ListItem>
                    <asp:ListItem Value="BRB">Barbados</asp:ListItem>
                    <asp:ListItem Value="BLR">Belarus</asp:ListItem>
                    <asp:ListItem Value="BEL">Belgium</asp:ListItem>
                    <asp:ListItem Value="BLZ">Belize</asp:ListItem>
                    <asp:ListItem Value="BEN">Benin</asp:ListItem>
                    <asp:ListItem Value="BMU">Bermuda</asp:ListItem>
                    <asp:ListItem Value="BTN">Bhutan</asp:ListItem>
                    <asp:ListItem Value="BOL">Bolivia</asp:ListItem>
                    <asp:ListItem Value="BIH">Bosnia and Herzegovina</asp:ListItem>
                    <asp:ListItem Value="BWA">Botswana</asp:ListItem>
                    <asp:ListItem Value="BVT">Bouvet Island</asp:ListItem>
                    <asp:ListItem Value="BRA">Brazil</asp:ListItem>
                    <asp:ListItem Value="IOT">British Indian Ocean Territory</asp:ListItem>
                    <asp:ListItem Value="BRN">Brunei Darussalam</asp:ListItem>
                    <asp:ListItem Value="BGR">Bulgaria</asp:ListItem>
                    <asp:ListItem Value="BFA">Burkina Faso</asp:ListItem>
                    <asp:ListItem Value="BDI">Burundi</asp:ListItem>
                    <asp:ListItem Value="KHM">Cambodia</asp:ListItem>
                    <asp:ListItem Value="CMR">Cameroon</asp:ListItem>
                    <asp:ListItem Value="CAN">Canada</asp:ListItem>
                    <asp:ListItem Value="CPV">Cape Verde</asp:ListItem>
                    <asp:ListItem Value="CYM">Cayman Islands</asp:ListItem>
                    <asp:ListItem Value="CAF">Central African Republic</asp:ListItem>
                    <asp:ListItem Value="TCD">Chad</asp:ListItem>
                    <asp:ListItem Value="CHL">Chile</asp:ListItem>
                    <asp:ListItem Value="CHN">China</asp:ListItem>
                    <asp:ListItem Value="CXR">Christmas Island</asp:ListItem>
                    <asp:ListItem Value="CCK">Cocos (Keeling) Islands</asp:ListItem>
                    <asp:ListItem Value="COL">Colombia</asp:ListItem>
                    <asp:ListItem Value="COM">Comoros</asp:ListItem>
                    <asp:ListItem Value="COG">Congo</asp:ListItem>
                    <asp:ListItem Value="COD">Congo, the Democratic Republic of the</asp:ListItem>
                    <asp:ListItem Value="COK">Cook Islands</asp:ListItem>
                    <asp:ListItem Value="CRI">Costa Rica</asp:ListItem>
                    <asp:ListItem Value="CIV">Cote D'ivoire</asp:ListItem>
                    <asp:ListItem Value="HRV">Croatia (Hrvatska)</asp:ListItem>
                    <asp:ListItem Value="CUB">Cuba</asp:ListItem>
                    <asp:ListItem Value="CYP">Cyprus</asp:ListItem>
                    <asp:ListItem Value="CZE">Czech Republic</asp:ListItem>
                    <asp:ListItem Value="DNK">Denmark</asp:ListItem>
                    <asp:ListItem Value="DJI">Djibouti</asp:ListItem>
                    <asp:ListItem Value="DMA">Dominica</asp:ListItem>
                    <asp:ListItem Value="DOM">Dominican Republic</asp:ListItem>
                    <asp:ListItem Value="ECU">Ecuador</asp:ListItem>
                    <asp:ListItem Value="EGY">Egypt</asp:ListItem>
                    <asp:ListItem Value="SLV">El Salvador</asp:ListItem>
                    <asp:ListItem Value="GNQ">Equatorial Guinea</asp:ListItem>
                    <asp:ListItem Value="ERI">Eritrea</asp:ListItem>
                    <asp:ListItem Value="EST">Estonia</asp:ListItem>
                    <asp:ListItem Value="ETH">Ethiopia</asp:ListItem>
                    <asp:ListItem Value="FLK">Falkland Islands (Malvinas)</asp:ListItem>
                    <asp:ListItem Value="FRO">Faroe Islands</asp:ListItem>
                    <asp:ListItem Value="FJI">Fiji</asp:ListItem>
                    <asp:ListItem Value="FIN">Finland</asp:ListItem>
                    <asp:ListItem Value="FRA">France</asp:ListItem>
                    <asp:ListItem Value="FXX">France, Metropolitan</asp:ListItem>
                    <asp:ListItem Value="GUF">French Guiana</asp:ListItem>
                    <asp:ListItem Value="PYF">French Polynesia</asp:ListItem>
                    <asp:ListItem Value="ATF">French Southern Territories</asp:ListItem>
                    <asp:ListItem Value="GAB">Gabon</asp:ListItem>
                    <asp:ListItem Value="GMB">Gambia</asp:ListItem>
                    <asp:ListItem Value="GEO">Georgia</asp:ListItem>
                    <asp:ListItem Value="DE">Germany</asp:ListItem>
                    <asp:ListItem Value="GHA">Ghana</asp:ListItem>
                    <asp:ListItem Value="GIB">Gibraltar</asp:ListItem>
                    <asp:ListItem Value="GRC">Greece</asp:ListItem>
                    <asp:ListItem Value="GRL">Greenland</asp:ListItem>
                    <asp:ListItem Value="GRD">Grenada</asp:ListItem>
                    <asp:ListItem Value="GLP">Guadeloupe</asp:ListItem>
                    <asp:ListItem Value="GUM">Guam</asp:ListItem>
                    <asp:ListItem Value="GTM">Guatemala</asp:ListItem>
                    <asp:ListItem Value="GIN">Guinea</asp:ListItem>
                    <asp:ListItem Value="GNB">Guinea-Bissau</asp:ListItem>
                    <asp:ListItem Value="GUY">Guyana</asp:ListItem>
                    <asp:ListItem Value="HTI">Haiti</asp:ListItem>
                    <asp:ListItem Value="HMD">Heard Island and Mcdonald Islands</asp:ListItem>
                    <asp:ListItem Value="HND">Honduras</asp:ListItem>
                    <asp:ListItem Value="HKG">Hong Kong</asp:ListItem>
                    <asp:ListItem Value="HUN">Hungary</asp:ListItem>
                    <asp:ListItem Value="ISL">Iceland</asp:ListItem>
                    <asp:ListItem Value="IND">India</asp:ListItem>
                    <asp:ListItem Value="IDN">Indonesia</asp:ListItem>
                    <asp:ListItem Value="IRN">Iran, Islamic Republic of</asp:ListItem>
                    <asp:ListItem Value="IRQ">Iraq</asp:ListItem>
                    <asp:ListItem Value="IRL">Ireland</asp:ListItem>
                    <asp:ListItem Value="ISR">Israel</asp:ListItem>
                    <asp:ListItem Value="ITA">Italy</asp:ListItem>
                    <asp:ListItem Value="JAM">Jamaica</asp:ListItem>
                    <asp:ListItem Value="JPN">Japan</asp:ListItem>
                    <asp:ListItem Value="JOR">Jordan</asp:ListItem>
                    <asp:ListItem Value="KAZ">Kazakhstan</asp:ListItem>
                    <asp:ListItem Value="KEN">Kenya</asp:ListItem>
                    <asp:ListItem Value="KIR">Kiribati</asp:ListItem>
                    <asp:ListItem Value="PRK">Korea, Democratic People's Republic of</asp:ListItem>
                    <asp:ListItem Value="KOR">Korea, Republic of</asp:ListItem>
                    <asp:ListItem Value="KWT">Kuwait</asp:ListItem>
                    <asp:ListItem Value="KGZ">Kyrgyzstan</asp:ListItem>
                    <asp:ListItem Value="LAO">Lao People's Democratic Republic</asp:ListItem>
                    <asp:ListItem Value="LVA">Latvia</asp:ListItem>
                    <asp:ListItem Value="LBN">Lebanon</asp:ListItem>
                    <asp:ListItem Value="LSO">Lesotho</asp:ListItem>
                    <asp:ListItem Value="LBR">Liberia</asp:ListItem>
                    <asp:ListItem Value="LBY">Libyan Arab Jamahiriya</asp:ListItem>
                    <asp:ListItem Value="LIE">Liechtenstein</asp:ListItem>
                    <asp:ListItem Value="LTU">Lithuania</asp:ListItem>
                    <asp:ListItem Value="LUX">Luxembourg</asp:ListItem>
                    <asp:ListItem Value="MAC">Macao</asp:ListItem>
                    <asp:ListItem Value="MKD">Macedonia</asp:ListItem>
                    <asp:ListItem Value="MDG">Madagascar</asp:ListItem>
                    <asp:ListItem Value="MWI">Malawi</asp:ListItem>
                    <asp:ListItem Value="MYS">Malaysia</asp:ListItem>
                    <asp:ListItem Value="MDV">Maldives</asp:ListItem>
                    <asp:ListItem Value="MLI">Mali</asp:ListItem>
                    <asp:ListItem Value="MLT">Malta</asp:ListItem>
                    <asp:ListItem Value="MHL">Marshall Islands</asp:ListItem>
                    <asp:ListItem Value="MTQ">Martinique</asp:ListItem>
                    <asp:ListItem Value="MRT">Mauritania</asp:ListItem>
                    <asp:ListItem Value="MUS">Mauritius</asp:ListItem>
                    <asp:ListItem Value="MYT">Mayotte</asp:ListItem>
                    <asp:ListItem Value="MEX">Mexico</asp:ListItem>
                    <asp:ListItem Value="FSM">Micronesia, Federated States of</asp:ListItem>
                    <asp:ListItem Value="MDA">Moldova, Republic of</asp:ListItem>
                    <asp:ListItem Value="MCO">Monaco</asp:ListItem>
                    <asp:ListItem Value="MNG">Mongolia</asp:ListItem>
                    <asp:ListItem Value="MNE">Montenegro</asp:ListItem>
                    <asp:ListItem Value="MSR">Montserrat</asp:ListItem>
                    <asp:ListItem Value="MAR">Morocco</asp:ListItem>
                    <asp:ListItem Value="MOZ">Mozambique</asp:ListItem>
                    <asp:ListItem Value="MMR">Myanmar</asp:ListItem>
                    <asp:ListItem Value="NAM">Namibia</asp:ListItem>
                    <asp:ListItem Value="NRU">Nauru</asp:ListItem>
                    <asp:ListItem Value="NPL">Nepal</asp:ListItem>
                    <asp:ListItem Value="NLD">Netherlands</asp:ListItem>
                    <asp:ListItem Value="ANT">Netherlands Antilles</asp:ListItem>
                    <asp:ListItem Value="NCL">New Caledonia</asp:ListItem>
                    <asp:ListItem Value="NZL">New Zealand</asp:ListItem>
                    <asp:ListItem Value="NIC">Nicaragua</asp:ListItem>
                    <asp:ListItem Value="NER">Niger</asp:ListItem>
                    <asp:ListItem Value="NGA">Nigeria</asp:ListItem>
                    <asp:ListItem Value="NIU">Niue</asp:ListItem>
                    <asp:ListItem Value="NFK">Norfolk Island</asp:ListItem>
                    <asp:ListItem Value="MNP">Northern Mariana Islands</asp:ListItem>
                    <asp:ListItem Value="NOR">Norway</asp:ListItem>
                    <asp:ListItem Value="OMN">Oman</asp:ListItem>
                    <asp:ListItem Value="PAK">Pakistan</asp:ListItem>
                    <asp:ListItem Value="PLW">Palau</asp:ListItem>
                    <asp:ListItem Value="PSE">Palestinian Territory, Occupied</asp:ListItem>
                    <asp:ListItem Value="PAN">Panama</asp:ListItem>
                    <asp:ListItem Value="PNG">Papua New Guinea</asp:ListItem>
                    <asp:ListItem Value="PRY">Paraguay</asp:ListItem>
                    <asp:ListItem Value="PER">Peru</asp:ListItem>
                    <asp:ListItem Value="PHL">Philippines</asp:ListItem>
                    <asp:ListItem Value="PCN">Pitcairn</asp:ListItem>
                    <asp:ListItem Value="POL">Poland</asp:ListItem>
                    <asp:ListItem Value="PRT">Portugal</asp:ListItem>
                    <asp:ListItem Value="PRI">Puerto Rico</asp:ListItem>
                    <asp:ListItem Value="QAT">Qatar</asp:ListItem>
                    <asp:ListItem Value="REU">Reunion</asp:ListItem>
                    <asp:ListItem Value="ROU">Romania</asp:ListItem>
                    <asp:ListItem Value="RUS">Russian Federation</asp:ListItem>
                    <asp:ListItem Value="RWA">Rwanda</asp:ListItem>
                    <asp:ListItem Value="SHN">Saint Helena</asp:ListItem>
                    <asp:ListItem Value="KNA">Saint Kitts and Nevis</asp:ListItem>
                    <asp:ListItem Value="LCA">Saint Lucia</asp:ListItem>
                    <asp:ListItem Value="SPM">Saint Pierre and Miquelon</asp:ListItem>
                    <asp:ListItem Value="VCT">Saint Vincent and the Grenadines</asp:ListItem>
                    <asp:ListItem Value="WSM">Samoa</asp:ListItem>
                    <asp:ListItem Value="SMR">San Marino</asp:ListItem>
                    <asp:ListItem Value="STP">Sao Tome and Principe</asp:ListItem>
                    <asp:ListItem Value="SAU">Saudi Arabia</asp:ListItem>
                    <asp:ListItem Value="SEN">Senegal</asp:ListItem>
                    <asp:ListItem Value="SRB">Serbia</asp:ListItem>
                    <asp:ListItem Value="SCG">Serbia and Montenegro</asp:ListItem>
                    <asp:ListItem Value="SYC">Seychelles</asp:ListItem>
                    <asp:ListItem Value="SLE">Sierra Leone</asp:ListItem>
                    <asp:ListItem Value="SGP">Singapore</asp:ListItem>
                    <asp:ListItem Value="SVK">Slovakia</asp:ListItem>
                    <asp:ListItem Value="SVN">Slovenia</asp:ListItem>
                    <asp:ListItem Value="SLB">Solomon Islands</asp:ListItem>
                    <asp:ListItem Value="SOM">Somalia</asp:ListItem>
                    <asp:ListItem Value="ZAF">South Africa</asp:ListItem>
                    <asp:ListItem Value="SGS">South Georgia</asp:ListItem>
                    <asp:ListItem Value="ESP">Spain</asp:ListItem>
                    <asp:ListItem Value="LKA">Sri Lanka</asp:ListItem>
                    <asp:ListItem Value="SDN">Sudan</asp:ListItem>
                    <asp:ListItem Value="SUR">Suriname</asp:ListItem>
                    <asp:ListItem Value="SJM">Svalbard and Jan Mayen Islands</asp:ListItem>
                    <asp:ListItem Value="SWZ">Swaziland</asp:ListItem>
                    <asp:ListItem Value="SWE">Sweden</asp:ListItem>
                    <asp:ListItem Value="CHE">Switzerland</asp:ListItem>
                    <asp:ListItem Value="SYR">Syrian Arab Republic</asp:ListItem>
                    <asp:ListItem Value="TWN">Taiwan</asp:ListItem>
                    <asp:ListItem Value="TJK">Tajikistan</asp:ListItem>
                    <asp:ListItem Value="TZA">Tanzania, United Republic of</asp:ListItem>
                    <asp:ListItem Value="THA">Thailand</asp:ListItem>
                    <asp:ListItem Value="TLS">Timor-Leste</asp:ListItem>
                    <asp:ListItem Value="TGO">Togo</asp:ListItem>
                    <asp:ListItem Value="TKL">Tokelau</asp:ListItem>
                    <asp:ListItem Value="TON">Tonga</asp:ListItem>
                    <asp:ListItem Value="TTO">Trinidad and Tobago</asp:ListItem>
                    <asp:ListItem Value="TUN">Tunisia</asp:ListItem>
                    <asp:ListItem Value="TUR">Turkey</asp:ListItem>
                    <asp:ListItem Value="TKM">Turkmenistan</asp:ListItem>
                    <asp:ListItem Value="TCA">Turks and Caicos Islands</asp:ListItem>
                    <asp:ListItem Value="TUV">Tuvalu</asp:ListItem>
                    <asp:ListItem Value="UGA">Uganda</asp:ListItem>
                    <asp:ListItem Value="UKR">Ukraine</asp:ListItem>
                    <asp:ListItem Value="ARE">United Arab Emirates</asp:ListItem>
                    <asp:ListItem Value="GB" Selected="True">United Kingdom</asp:ListItem>
                    <asp:ListItem Value="US">United States</asp:ListItem>
                    <asp:ListItem Value="UMI">United States Minor Outlying Islands</asp:ListItem>
                    <asp:ListItem Value="URY">Uruguay</asp:ListItem>
                    <asp:ListItem Value="UZB">Uzbekistan</asp:ListItem>
                    <asp:ListItem Value="VUT">Vanuatu</asp:ListItem>
                    <asp:ListItem Value="VAT">Vatican City State (Holy See)</asp:ListItem>
                    <asp:ListItem Value="VEN">Venezuela</asp:ListItem>
                    <asp:ListItem Value="VNM">Viet Nam</asp:ListItem>
                    <asp:ListItem Value="VGB">Virgin Islands, British</asp:ListItem>
                    <asp:ListItem Value="VIR">Virgin Islands, U.S.</asp:ListItem>
                    <asp:ListItem Value="WLF">Wallis and Futuna Islands</asp:ListItem>
                    <asp:ListItem Value="ESH">Western Sahara</asp:ListItem>
                    <asp:ListItem Value="YEM">Yemen</asp:ListItem>
                    <asp:ListItem Value="YUG">Yugoslavia</asp:ListItem>
                    <asp:ListItem Value="ZAR">Zaire</asp:ListItem>
                    <asp:ListItem Value="ZMB">Zambia</asp:ListItem>
                    <asp:ListItem Value="ZWE">Zimbabwe</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <img alt="one" src="/images/nm_one.gif" /><img alt="zero" src="/images/nm_zero.gif" />
                <asp:Label ID="Label9" runat="server" Text="Credit card number" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBoxcnumber"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxcnumber"
                    CssClass="ft_red" ErrorMessage="Not a valid card Number" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                <br />
                <asp:TextBox ID="TextBoxcnumber" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <br />
                <img alt="one" src="/images/nm_one.gif" /><img alt="one" src="/images/nm_one.gif" />
                <asp:Label ID="Label10" runat="server" Text="CVV Code" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBoxcvv"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxcvv"
                    CssClass="ft_red" ErrorMessage="Not a valid CVV" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                <br />
                <asp:TextBox ID="TextBoxcvv" runat="server" CssClass="TextboxSt" Width="50" MaxLength="4"
                    TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <img alt="one" src="/images/nm_one.gif" /><img alt="two" src="/images/nm_two.gif" />
                <asp:Label ID="Label16" runat="server" Text="Card Type" CssClass="ft_black"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownctype" runat="server">
                    <asp:ListItem Selected="True">Visa</asp:ListItem>
                    <asp:ListItem>MasterCard</asp:ListItem>
                    <asp:ListItem>Discover</asp:ListItem>
                    <asp:ListItem>Amex</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <img alt="one" src="/images/nm_one.gif" /><img alt="three" src="/images/nm_three.gif" />
                <asp:Label ID="Label12" runat="server" Text="Expiry Date" CssClass="ft_black"></asp:Label><br />
                <asp:DropDownList ID="DropDownMonth" runat="server" CssClass="ft_black">
                    <asp:ListItem Value="01" Selected="True">01</asp:ListItem>
                    <asp:ListItem Value="02">02</asp:ListItem>
                    <asp:ListItem Value="03">03</asp:ListItem>
                    <asp:ListItem Value="04">04</asp:ListItem>
                    <asp:ListItem Value="05">05</asp:ListItem>
                    <asp:ListItem Value="06">06</asp:ListItem>
                    <asp:ListItem Value="07">07</asp:ListItem>
                    <asp:ListItem Value="08">08</asp:ListItem>
                    <asp:ListItem Value="09">09</asp:ListItem>
                    <asp:ListItem Value="10">10</asp:ListItem>
                    <asp:ListItem Value="11">11</asp:ListItem>
                    <asp:ListItem Value="12">12</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="DropDownYear" runat="server" CssClass="ft_black">
                    <asp:ListItem Value="2012" Selected="True">2012</asp:ListItem>
                    <asp:ListItem Value="2013">2013</asp:ListItem>
                    <asp:ListItem Value="2014">2014</asp:ListItem>
                    <asp:ListItem Value="2015">2015</asp:ListItem>
                    <asp:ListItem Value="2016">2016</asp:ListItem>
                    <asp:ListItem Value="2017">2017</asp:ListItem>
                    <asp:ListItem Value="2018">2018</asp:ListItem>
                    <asp:ListItem Value="2019">2019</asp:ListItem>
                    <asp:ListItem Value="2020">2020</asp:ListItem>
                    <asp:ListItem Value="2021">2021</asp:ListItem>
                    <asp:ListItem Value="2022">2022</asp:ListItem>
                    <asp:ListItem Value="2023">2023</asp:ListItem>
                    <asp:ListItem Value="2024">2024</asp:ListItem>
                    <asp:ListItem Value="2025">2025</asp:ListItem>
                    <asp:ListItem Value="2026">2026</asp:ListItem>
                    <asp:ListItem Value="2027">2027</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <img alt="one" src="/images/nm_one.gif" /><img alt="four" src="/images/nm_four.gif" />
                <asp:Label ID="Label15" runat="server" Text="Service Ordered" CssClass="ft_black"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownOrders" runat="server">
                    <asp:ListItem Value="100" Selected="True">Standard job ad pack for £399</asp:ListItem>
                    <asp:ListItem Value="101">Silver job ad pack for £499</asp:ListItem>
                    <asp:ListItem Value="102">Platinum job ad pack for £599</asp:ListItem>
                    <asp:ListItem Value="103">Login micro job ad pack for £299</asp:ListItem>
                    <asp:ListItem Value="104">Home page stock bar ads for £199</asp:ListItem>
                    <asp:ListItem Value="105">Other</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <img alt="one" src="/images/nm_one.gif" /><img alt="five" src="/images/nm_five.gif" /><asp:Label
                    ID="Label17" runat="server" Text="Promo Code" CssClass="ft_black"></asp:Label>
                <br />
                <asp:TextBox ID="TextBoxPromo" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <br />
                <div class="ln_fixx4">
                </div>
                <div class="ln_444">
                </div>
                <div class="ft_black">
                    By completing this transaction you are agreeing to the policies under which are
                    listed at fashionquadrant
                </div>
                <a href="/jbterms.aspx" class="ft_bluelink">Terms</a> <a href="/jbprivacy.aspx"
                    class="ft_bluelink">Privacy</a>
                <div class="dv_fix">
                </div>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Process Payment" CssClass="button"
                    OnClick="Button1Click" />
                <div class="dv_fix">
                </div>
                <br />
                <br />
            </div>
            <div id="wrapjobsbyrecright">
                <asp:Label ID="Label11" runat="server" Text="Payments powered by:" CssClass="ft_black"></asp:Label>
                <br />
                <!-- PayPal Logo -->
                <table border="0" cellpadding="10" cellspacing="0" align="center">
                    <tr>
                        <td align="center"></td>
                    </tr>
                    <tr>
                        <td align="center">
                            <a href="#" onclick="javascript:window.open('https://www.paypal.com/uk/cgi-bin/webscr?cmd=xpt/Marketing/popup/OLCWhatIsPayPal-outside','olcwhatispaypal','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, width=400, height=500');">
                                <img src="https://www.paypal.com/en_GB/Marketing/i/logo/PayPal_logo_80x35.gif" border="0"
                                    alt="PayPal-Standard-Logo"></a>
                        </td>
                    </tr>
                </table>
                <!-- PayPal Logo -->
                <br />
                <asp:Label ID="Label14" runat="server" Text="Now accepting;" CssClass="ft_black"></asp:Label>
                <br />
                <!-- c card img goes here -->
                <img src="/images/cards.png" alt="cards" /><br />
                <!-- verisign seal goes here-->
                <table width="135" border="0" cellpadding="2" cellspacing="0" title="Click to Verify - This site chose VeriSign Trust Seal to promote trust online with consumers.">
                    <tr>
                        <td width="135" align="center" valign="top">
                            <script type="text/javascript" src="https://seal.verisign.com/getseal?host_name=www.fashionquadrant.com&amp;size=S&amp;use_flash=YES&amp;use_transparent=YES&amp;lang=en"></script>
                            <br />
                            <a href="http://www.verisign.com/verisign-trust-seal" target="_blank" style="color: #000000; text-decoration: none; font: bold 7px verdana,sans-serif; letter-spacing: .5px; text-align: center; margin: 0px; padding: 0px;">ABOUT TRUST ONLINE</a>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="dv_fix">
        </div>
    </div>
</asp:Content>
