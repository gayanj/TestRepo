<?php

$mysqli = new mysqli("localhost", "Genre", "!1IamBackTo", "fashionquadrant");

/* check connection */
if (mysqli_connect_errno()) {  
   echo "Failed to connect to MySQL: " . mysqli_connect_error();
}

//move to stored procedure with rollback
//echo date("h:i:s");
//echo "yes";

function LoadData($fname, $lname, $email, $add1, $atown, $add1, $atown, $acounty, $apostcode, $ahomeph, $aworkph, $acountry ){

$userid = uniqid();
$password = md5("!Password1");
$candidateid = uniqid();
$serverid = "Facebook";
$preset = null;
$firstname = filter_var($fname,FILTER_SANITIZE_STRING);
$lastname = filter_var($lname,FILTER_SANITIZE_STRING);
$fname = $firstname . " " . $lastname;
$fbookemail = filter_var($email,FILTER_SANITIZE_STRING);
$documentid = uniqid();

//other info
$cAddress1 = filter_var($add1,FILTER_SANITIZE_STRING);
$cTown = filter_var($atown,FILTER_SANITIZE_STRING);
$cCounty = filter_var($acounty,FILTER_SANITIZE_STRING);
$cPostcode = filter_var($apostcode,FILTER_SANITIZE_STRING);
$hphone = filter_var($ahomeph,FILTER_SANITIZE_STRING);
$wphone = filter_var($aworkph,FILTER_SANITIZE_STRING);
$cCountry = filter_var($acountry,FILTER_SANITIZE_STRING);
$uid = null;

$query = "select uusername from users where uusername = '".$fbookemail."' and uusertype = 2 and serverid='Facebook';";

while($row = mysqli_fetch_array($query))
   {
		$uid =  $row['uusername'];
		break;
   }

if($systemid != null)
{
		//nothing just redirect.
}

else
{
		//add to candidates
		$query = "INSERT INTO users(idusers, uusertype, uusername, upassword, upasswordhint, uFirstName, uLastName, uCandidateID, uActivation, serverid) values ('".$userid."' , 2 , '". $fbookemail ."' , '". $password  . "', 'none' , '" . $firstname ."' , '". $lastname . "' , '" . $candidateid . "', null , '". $serverid . "' )";
		$mysqli->query($query);

		$query = "INSERT INTO candidates (idcandidates, ccandidatename, cfirstname, clastname, caddress1, ctown, ccounty, cpostcode, chomephone, cworkphone, ccountry) values ( '". $candidateid ."' , '". $fname ."' , '" . $firstname ."' , '". $lastname ."' , '". $cAddress1 ."' , '". $cTown ."' , '". $cCounty ."' , '". $cPostcode ."' , '". $hphone ."' , '". $wphone ."' , '". $cCountry. "' )";
		$mysqli->query($query);

		$__privstring = "INSERT INTO Privacy(idprivacy, idCandidates, idpolicy) values";

		for($_p = 1; $_p < 12; $_p++)
		{
			$__privstring .= "('". uniqid().$_p ."', '". $candidateid ."', ". $_p ." ),";
		}

		$query = trim($__privstring, ",");
		$mysqli->query($query);

		$query = "INSERT INTO tb_notes(idCandidates,commentdescription) values ( '". $candidateid ."', '' );";
		$mysqli->query($query);

		$query = "INSERT INTO tb_myresumes(documentid, documentname, doc_url, idcandidates) values ( '". $documentid ."', 'default' , 'default', '". $candidateid ."' );";
		$mysqli->query($query);

		$uid = $fbookemail;
}

		/* close connection */
		$mysqli->close();

		header("Location: http://v1.fashionquadrant.com/facebook/Home.aspx?userid=".$uid."&name=".$fname);

}

?>
