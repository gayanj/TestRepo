<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="UserApplication.aspx.cs" Inherits="JB.Jobseekers.Userapplication" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="cn_header">
        <asp:Label ID="Label27" runat="server" Text="Basic Information" CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Change your profile information, a complete profile has better options of securing
            a job.
        </div>
    </div>
    <div class="time_right">
        <!-- middle wrapup -->
        <div id="cn_canbasmid">
            <div class="ft_notify">
                <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
            </div>
            <!--end nts-->
            <div class="cn_appdvleft">
                <asp:Label ID="Label10" runat="server" CssClass="ft_black" Text="First Name"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" CssClass="cn_txtbox" MaxLength="255"></asp:TextBox>

                <br />
                <asp:Label ID="Label11" runat="server" CssClass="ft_black" Text="Last Name"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox3" runat="server" CssClass="cn_txtbox" MaxLength="255"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label12" runat="server" CssClass="ft_black" Text="Address1"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox4" runat="server" CssClass="cn_txtbox" MaxLength="255"></asp:TextBox>
                <br />
                <asp:Label ID="Label13" runat="server" CssClass="ft_black" Text="Address2"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox5" runat="server" CssClass="cn_txtbox" MaxLength="255"></asp:TextBox>
                <br />
                <asp:Label ID="Label14" runat="server" CssClass="ft_black" Text="Address3"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox6" runat="server" CssClass="cn_txtbox" MaxLength="255"></asp:TextBox>
                <br />
                <asp:Label ID="Label15" runat="server" CssClass="ft_black" Text="Town"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox7" runat="server" CssClass="cn_txtbox" MaxLength="45"></asp:TextBox>
                <br />
                <asp:Label ID="Label16" runat="server" CssClass="ft_black" Text="County"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox8" runat="server" CssClass="cn_txtbox" MaxLength="45"></asp:TextBox>

                <br />


                <asp:Label ID="Label24" runat="server" CssClass="ft_black" Text="Country"></asp:Label>
                <br />
                <asp:DropDownList ID="CountrySelect" runat="server">
                    <asp:ListItem Value="AF">Afghanistan</asp:ListItem>
                    <asp:ListItem Value="AX">Åland Islands</asp:ListItem>
                    <asp:ListItem Value="AL">Albania</asp:ListItem>
                    <asp:ListItem Value="DZ">Algeria</asp:ListItem>
                    <asp:ListItem Value="AS">American Samoa</asp:ListItem>
                    <asp:ListItem Value="AD">Andorra</asp:ListItem>
                    <asp:ListItem Value="AO">Angola</asp:ListItem>
                    <asp:ListItem Value="AI">Anguilla</asp:ListItem>
                    <asp:ListItem Value="AQ">Antarctica</asp:ListItem>
                    <asp:ListItem Value="AG">Antigua and Barbuda</asp:ListItem>
                    <asp:ListItem Value="AR">Argentina</asp:ListItem>
                    <asp:ListItem Value="AM">Armenia</asp:ListItem>
                    <asp:ListItem Value="AW">Aruba</asp:ListItem>
                    <asp:ListItem Value="AU" Selected="True">Australia</asp:ListItem>
                    <asp:ListItem Value="AT">Austria</asp:ListItem>
                    <asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>
                    <asp:ListItem Value="BS">Bahamas</asp:ListItem>
                    <asp:ListItem Value="BH">Bahrain</asp:ListItem>
                    <asp:ListItem Value="BD">Bangladesh</asp:ListItem>
                    <asp:ListItem Value="BB">Barbados</asp:ListItem>
                    <asp:ListItem Value="BY">Belarus</asp:ListItem>
                    <asp:ListItem Value="BE">Belgium</asp:ListItem>
                    <asp:ListItem Value="BZ">Belize</asp:ListItem>
                    <asp:ListItem Value="BJ">Benin</asp:ListItem>
                    <asp:ListItem Value="BM">Bermuda</asp:ListItem>
                    <asp:ListItem Value="BT">Bhutan</asp:ListItem>
                    <asp:ListItem Value="BO">Bolivia</asp:ListItem>
                    <asp:ListItem Value="BQ">Bonaire</asp:ListItem>
                    <asp:ListItem Value="BA">Bosnia and Herzegovina</asp:ListItem>
                    <asp:ListItem Value="BW">Botswana</asp:ListItem>
                    <asp:ListItem Value="BV">Bouvet Island</asp:ListItem>
                    <asp:ListItem Value="BR">Brazil</asp:ListItem>
                    <asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>
                    <asp:ListItem Value="BN">Brunei</asp:ListItem>
                    <asp:ListItem Value="BG">Bulgaria</asp:ListItem>
                    <asp:ListItem Value="BF">Burkina Faso</asp:ListItem>
                    <asp:ListItem Value="BI">Burundi</asp:ListItem>
                    <asp:ListItem Value="KH">Cambodia</asp:ListItem>
                    <asp:ListItem Value="CM">Cameroon</asp:ListItem>
                    <asp:ListItem Value="CA">Canada</asp:ListItem>
                    <asp:ListItem Value="CV">Cape Verde</asp:ListItem>
                    <asp:ListItem Value="KY">Cayman Islands</asp:ListItem>
                    <asp:ListItem Value="CF">Central African Republic</asp:ListItem>
                    <asp:ListItem Value="TD">Chad</asp:ListItem>
                    <asp:ListItem Value="CL">Chile</asp:ListItem>
                    <asp:ListItem Value="CN">China</asp:ListItem>
                    <asp:ListItem Value="CX">Christmas Island</asp:ListItem>
                    <asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>
                    <asp:ListItem Value="CO">Colombia</asp:ListItem>
                    <asp:ListItem Value="KM">Comoros</asp:ListItem>
                    <asp:ListItem Value="CG">Congo</asp:ListItem>
                    <asp:ListItem Value="CD">Congo (DRC)</asp:ListItem>
                    <asp:ListItem Value="CK">Cook Islands</asp:ListItem>
                    <asp:ListItem Value="CR">Costa Rica</asp:ListItem>
                    <asp:ListItem Value="HR">Croatia</asp:ListItem>
                    <asp:ListItem Value="CU">Cuba</asp:ListItem>
                    <asp:ListItem Value="CW">Curaçao</asp:ListItem>
                    <asp:ListItem Value="CY">Cyprus</asp:ListItem>
                    <asp:ListItem Value="CZ">Czech Republic</asp:ListItem>
                    <asp:ListItem Value="DK">Denmark</asp:ListItem>
                    <asp:ListItem Value="DJ">Djibouti</asp:ListItem>
                    <asp:ListItem Value="DM">Dominica</asp:ListItem>
                    <asp:ListItem Value="DO">Dominican Republic</asp:ListItem>
                    <asp:ListItem Value="EC">Ecuador</asp:ListItem>
                    <asp:ListItem Value="EG">Egypt</asp:ListItem>
                    <asp:ListItem Value="SV">El Salvador</asp:ListItem>
                    <asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>
                    <asp:ListItem Value="ER">Eritrea</asp:ListItem>
                    <asp:ListItem Value="EE">Estonia</asp:ListItem>
                    <asp:ListItem Value="ET">Ethiopia</asp:ListItem>
                    <asp:ListItem Value="FK">Falkland Islands (Islas Malvinas)</asp:ListItem>
                    <asp:ListItem Value="FO">Faroe Islands</asp:ListItem>
                    <asp:ListItem Value="FJ">Fiji Islands</asp:ListItem>
                    <asp:ListItem Value="FI">Finland</asp:ListItem>
                    <asp:ListItem Value="FR">France</asp:ListItem>
                    <asp:ListItem Value="GF">French Guiana</asp:ListItem>
                    <asp:ListItem Value="PF">French Polynesia</asp:ListItem>
                    <asp:ListItem Value="TF">French Southern and Antarctic Lands</asp:ListItem>
                    <asp:ListItem Value="GA">Gabon</asp:ListItem>
                    <asp:ListItem Value="GM">Gambia, The</asp:ListItem>
                    <asp:ListItem Value="GE">Georgia</asp:ListItem>
                    <asp:ListItem Value="DE">Germany</asp:ListItem>
                    <asp:ListItem Value="GH">Ghana</asp:ListItem>
                    <asp:ListItem Value="GI">Gibraltar</asp:ListItem>
                    <asp:ListItem Value="GR">Greece</asp:ListItem>
                    <asp:ListItem Value="GL">Greenland</asp:ListItem>
                    <asp:ListItem Value="GD">Grenada</asp:ListItem>
                    <asp:ListItem Value="GP">Guadeloupe</asp:ListItem>
                    <asp:ListItem Value="GU">Guam</asp:ListItem>
                    <asp:ListItem Value="GT">Guatemala</asp:ListItem>
                    <asp:ListItem Value="GG">Guernsey</asp:ListItem>
                    <asp:ListItem Value="GN">Guinea</asp:ListItem>
                    <asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>
                    <asp:ListItem Value="GY">Guyana</asp:ListItem>
                    <asp:ListItem Value="HT">Haiti</asp:ListItem>
                    <asp:ListItem Value="HM">Heard Island and McDonald Islands</asp:ListItem>
                    <asp:ListItem Value="HN">Honduras</asp:ListItem>
                    <asp:ListItem Value="HK">Hong Kong SAR</asp:ListItem>
                    <asp:ListItem Value="HU">Hungary</asp:ListItem>
                    <asp:ListItem Value="IS">Iceland</asp:ListItem>
                    <asp:ListItem Value="IN">India</asp:ListItem>
                    <asp:ListItem Value="ID">Indonesia</asp:ListItem>
                    <asp:ListItem Value="IR">Iran</asp:ListItem>
                    <asp:ListItem Value="IQ">Iraq</asp:ListItem>
                    <asp:ListItem Value="IE">Ireland</asp:ListItem>
                    <asp:ListItem Value="IM">Isle of Man</asp:ListItem>
                    <asp:ListItem Value="IL">Israel</asp:ListItem>
                    <asp:ListItem Value="IT">Italy</asp:ListItem>
                    <asp:ListItem Value="JM">Jamaica</asp:ListItem>
                    <asp:ListItem Value="SJ">Jan Mayen</asp:ListItem>
                    <asp:ListItem Value="JP">Japan</asp:ListItem>
                    <asp:ListItem Value="JE">Jersey</asp:ListItem>
                    <asp:ListItem Value="JO">Jordan</asp:ListItem>
                    <asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>
                    <asp:ListItem Value="KE">Kenya</asp:ListItem>
                    <asp:ListItem Value="KI">Kiribati</asp:ListItem>
                    <asp:ListItem Value="KR">Korea</asp:ListItem>
                    <asp:ListItem Value="KW">Kuwait</asp:ListItem>
                    <asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>
                    <asp:ListItem Value="LA">Laos</asp:ListItem>
                    <asp:ListItem Value="LV">Latvia</asp:ListItem>
                    <asp:ListItem Value="LB">Lebanon</asp:ListItem>
                    <asp:ListItem Value="LS">Lesotho</asp:ListItem>
                    <asp:ListItem Value="LR">Liberia</asp:ListItem>
                    <asp:ListItem Value="LY">Libya</asp:ListItem>
                    <asp:ListItem Value="LI">Liechtenstein</asp:ListItem>
                    <asp:ListItem Value="LT">Lithuania</asp:ListItem>
                    <asp:ListItem Value="LU">Luxembourg</asp:ListItem>
                    <asp:ListItem Value="MO">Macao SAR</asp:ListItem>
                    <asp:ListItem Value="MK">Macedonia</asp:ListItem>
                    <asp:ListItem Value="MG">Madagascar</asp:ListItem>
                    <asp:ListItem Value="MW">Malawi</asp:ListItem>
                    <asp:ListItem Value="MY">Malaysia</asp:ListItem>
                    <asp:ListItem Value="MV">Maldives</asp:ListItem>
                    <asp:ListItem Value="ML">Mali</asp:ListItem>
                    <asp:ListItem Value="MT">Malta</asp:ListItem>
                    <asp:ListItem Value="MH">Marshall Islands</asp:ListItem>
                    <asp:ListItem Value="MQ">Martinique</asp:ListItem>
                    <asp:ListItem Value="MR">Mauritania</asp:ListItem>
                    <asp:ListItem Value="MU">Mauritius</asp:ListItem>
                    <asp:ListItem Value="YT">Mayotte</asp:ListItem>
                    <asp:ListItem Value="MX">Mexico</asp:ListItem>
                    <asp:ListItem Value="FM">Micronesia</asp:ListItem>
                    <asp:ListItem Value="MD">Moldova</asp:ListItem>
                    <asp:ListItem Value="MC">Monaco</asp:ListItem>
                    <asp:ListItem Value="MN">Mongolia</asp:ListItem>
                    <asp:ListItem Value="ME">Montenegro</asp:ListItem>
                    <asp:ListItem Value="MS">Montserrat</asp:ListItem>
                    <asp:ListItem Value="MA">Morocco</asp:ListItem>
                    <asp:ListItem Value="MZ">Mozambique</asp:ListItem>
                    <asp:ListItem Value="MM">Myanmar</asp:ListItem>
                    <asp:ListItem Value="NA">Namibia</asp:ListItem>
                    <asp:ListItem Value="NR">Nauru</asp:ListItem>
                    <asp:ListItem Value="NP">Nepal</asp:ListItem>
                    <asp:ListItem Value="NL">Netherlands</asp:ListItem>
                    <asp:ListItem Value="NC">New Caledonia</asp:ListItem>
                    <asp:ListItem Value="NZ">New Zealand</asp:ListItem>
                    <asp:ListItem Value="NI">Nicaragua</asp:ListItem>
                    <asp:ListItem Value="NE">Niger</asp:ListItem>
                    <asp:ListItem Value="NG">Nigeria</asp:ListItem>
                    <asp:ListItem Value="NU">Niue</asp:ListItem>
                    <asp:ListItem Value="NF">Norfolk Island</asp:ListItem>
                    <asp:ListItem Value="KP">North Korea</asp:ListItem>
                    <asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>
                    <asp:ListItem Value="NO">Norway</asp:ListItem>
                    <asp:ListItem Value="OM">Oman</asp:ListItem>
                    <asp:ListItem Value="PK">Pakistan</asp:ListItem>
                    <asp:ListItem Value="PW">Palau</asp:ListItem>
                    <asp:ListItem Value="PS">Palestinian Authority</asp:ListItem>
                    <asp:ListItem Value="PA">Panama</asp:ListItem>
                    <asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>
                    <asp:ListItem Value="PY">Paraguay</asp:ListItem>
                    <asp:ListItem Value="PE">Peru</asp:ListItem>
                    <asp:ListItem Value="PH">Philippines</asp:ListItem>
                    <asp:ListItem Value="PN">Pitcairn Islands</asp:ListItem>
                    <asp:ListItem Value="PL">Poland</asp:ListItem>
                    <asp:ListItem Value="PT">Portugal</asp:ListItem>
                    <asp:ListItem Value="PR">Puerto Rico</asp:ListItem>
                    <asp:ListItem Value="QA">Qatar</asp:ListItem>
                    <asp:ListItem Value="CI">Republic of Cote d Ivoire</asp:ListItem>
                    <asp:ListItem Value="RE">Reunion</asp:ListItem>
                    <asp:ListItem Value="RO">Romania</asp:ListItem>
                    <asp:ListItem Value="RU">Russia</asp:ListItem>
                    <asp:ListItem Value="RW">Rwanda</asp:ListItem>
                    <asp:ListItem Value="XS">Saba</asp:ListItem>
                    <asp:ListItem Value="WS">Samoa</asp:ListItem>
                    <asp:ListItem Value="SM">San Marino</asp:ListItem>
                    <asp:ListItem Value="ST">Sao Tome and Principe</asp:ListItem>
                    <asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>
                    <asp:ListItem Value="SN">Senegal</asp:ListItem>
                    <asp:ListItem Value="RS">Serbia</asp:ListItem>
                    <asp:ListItem Value="SC">Seychelles</asp:ListItem>
                    <asp:ListItem Value="SL">Sierra Leone</asp:ListItem>
                    <asp:ListItem Value="SG">Singapore</asp:ListItem>
                    <asp:ListItem Value="XE">Sint Eustatius</asp:ListItem>
                    <asp:ListItem Value="SX">Sint Maarten</asp:ListItem>
                    <asp:ListItem Value="SK">Slovakia</asp:ListItem>
                    <asp:ListItem Value="SI">Slovenia</asp:ListItem>
                    <asp:ListItem Value="SB">Solomon Islands</asp:ListItem>
                    <asp:ListItem Value="SO">Somalia</asp:ListItem>
                    <asp:ListItem Value="ZA">South Africa</asp:ListItem>
                    <asp:ListItem Value="GS">South Georgia / South Sandwich Islands</asp:ListItem>
                    <asp:ListItem Value="ES">Spain</asp:ListItem>
                    <asp:ListItem Value="LK">Sri Lanka</asp:ListItem>
                    <asp:ListItem Value="BL">St. Barthélemy</asp:ListItem>
                    <asp:ListItem Value="SH">St. Helena</asp:ListItem>
                    <asp:ListItem Value="KN">St. Kitts and Nevis</asp:ListItem>
                    <asp:ListItem Value="LC">St. Lucia</asp:ListItem>
                    <asp:ListItem Value="MF">St. Martin</asp:ListItem>
                    <asp:ListItem Value="PM">St. Pierre and Miquelon</asp:ListItem>
                    <asp:ListItem Value="VC">St. Vincent and the Grenadines</asp:ListItem>
                    <asp:ListItem Value="SD">Sudan</asp:ListItem>
                    <asp:ListItem Value="SR">Suriname</asp:ListItem>
                    <asp:ListItem Value="SZ">Swaziland</asp:ListItem>
                    <asp:ListItem Value="SE">Sweden</asp:ListItem>
                    <asp:ListItem Value="CH">Switzerland</asp:ListItem>
                    <asp:ListItem Value="SY">Syria</asp:ListItem>
                    <asp:ListItem Value="TW">Taiwan</asp:ListItem>
                    <asp:ListItem Value="TJ">Tajikistan</asp:ListItem>
                    <asp:ListItem Value="TZ">Tanzania</asp:ListItem>
                    <asp:ListItem Value="TH">Thailand</asp:ListItem>
                    <asp:ListItem Value="TL">Timor-Leste</asp:ListItem>
                    <asp:ListItem Value="TG">Togo</asp:ListItem>
                    <asp:ListItem Value="TK">Tokelau</asp:ListItem>
                    <asp:ListItem Value="TO">Tonga</asp:ListItem>
                    <asp:ListItem Value="TT">Trinidad and Tobago</asp:ListItem>
                    <asp:ListItem Value="TN">Tunisia</asp:ListItem>
                    <asp:ListItem Value="TR">Turkey</asp:ListItem>
                    <asp:ListItem Value="TM">Turkmenistan</asp:ListItem>
                    <asp:ListItem Value="TC">Turks and Caicos Islands</asp:ListItem>
                    <asp:ListItem Value="TV">Tuvalu</asp:ListItem>
                    <asp:ListItem Value="UG">Uganda</asp:ListItem>
                    <asp:ListItem Value="UA">Ukraine</asp:ListItem>
                    <asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>
                    <asp:ListItem Value="UK">United Kingdom</asp:ListItem>
                    <asp:ListItem Value="US">United States</asp:ListItem>
                    <asp:ListItem Value="UM">United States Outlying Islands</asp:ListItem>
                    <asp:ListItem Value="UY">Uruguay</asp:ListItem>
                    <asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>
                    <asp:ListItem Value="VU">Vanuatu</asp:ListItem>
                    <asp:ListItem Value="VA">Vatican City</asp:ListItem>
                    <asp:ListItem Value="VE">Venezuela</asp:ListItem>
                    <asp:ListItem Value="VN">Vietnam</asp:ListItem>
                    <asp:ListItem Value="VG">Virgin Islands, British</asp:ListItem>
                    <asp:ListItem Value="VI">Virgin Islands, U.S.</asp:ListItem>
                    <asp:ListItem Value="WF">Wallis and Futuna</asp:ListItem>
                    <asp:ListItem Value="YE">Yemen</asp:ListItem>
                    <asp:ListItem Value="ZM">Zambia</asp:ListItem>
                    <asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label17" runat="server" CssClass="ft_black" Text="PostCode"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox9" runat="server" CssClass="cn_txtbox" MaxLength="10"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label22" runat="server" CssClass="ft_black" Text="Home Phone"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox14" runat="server" CssClass="cn_txtbox" MaxLength="45"></asp:TextBox>
                <br />
                <asp:Label ID="Label23" runat="server" CssClass="ft_black" Text="Work Phone"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox15" runat="server" CssClass="cn_txtbox" MaxLength="45"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx6">
                <asp:Button ID="Button2" runat="server" Text="Save" CssClass="button" OnClick="Button2Click" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" Text="Cancel" CssClass="button" OnClick="Button3Click"
                    CausesValidation="False" />
            </div>
            <!-- close middle wrapup-->
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
