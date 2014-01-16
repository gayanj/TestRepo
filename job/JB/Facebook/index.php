<html lang="en" dir="ltr">

<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link href="/facebook/styles/seagull.css" rel="stylesheet" type="text/css" />

</head>

<body>

<?php
  // Remember to copy files from the SDK's src/ directory to a
  // directory in your application on the server, such as php-sdk/
  require_once('/src/facebook.php');
  include('dataloader.php');

  $config = array(
    'appId' => '176918945800573',
    'secret' => '24f6c777e42beb23b59a1d6e983af16d',
  );

  $facebook = new Facebook($config);
  $user_id = $facebook->getUser();

  //get data
    if($user_id) {

      // We have a user ID, so probably a logged in user.
      // If not, we'll get an exception, which we handle below.
      try {

    $user_profile = $facebook->api('/me','GET');
    /*
	echo "Name: " . $user_profile['name'];
	echo "<br/>";
	echo "First Name:". $user_profile['first_name'];
	echo "<br/>";
	echo "Last Name:". $user_profile['last_name'];
	echo "<br/>";
	echo "Town:". $user_profile['hometown']['name'];
	echo "<br/>";
	echo "Location:". $user_profile['location']['name'];
	echo "<br/>";
	
	//import first contacts in array only. we need people in our system, then we can ask them to fill up things when we want
	
	echo "Employer Name:". $user_profile['work'][0]['employer']['name'];
	echo "<br/>";
	echo "Employer location:". $user_profile['work'][0]['employer']['name']['location']['name'];
	echo "<br/>";
	echo "Employement Title:". $user_profile['work'][0]['employer']['position']['name'];
	echo "<br/>";
	echo "Start Date:". $user_profile['work'][0]['employer']['start_date'];
	echo "<br/>";
	echo "End Date:". $user_profile['work'][0]['employer']['end_date'];
	echo "<br/>";

	//education
	echo "Name:". $user_profile['education'][0]['school']['name'];
	echo "<br/>";
	echo "Type:". $user_profile['education'][0]['school']['type'];
	echo "<br/>";
	echo "year:". $user_profile['education'][0]['school']['classes']['name'];
	echo "<br/>";
	*/

	$email = $user_profile['email'];
	$fname =  $user_profile['first_name'];
	$lname = $user_profile['last_name'];
	$add1 = $user_profile['hometown']['name'];
	$atown = "";
	$acounty = "";
	$apostcode = "";
	$ahomeph = "";
	$aworkph = "";
	$acountry = "";
		
	LoadData($fname, $lname, $email, $add1, $atown, $add1, $atown, $acounty, $apostcode, $ahomeph, $aworkph, $acountry );

	//print_r($user_profile);

      } catch(FacebookApiException $e) {
        // If the user is logged out, you can have a 
        // user ID even though the access token is invalid.
        // In this case, we'll get an exception, so we'll
        // just ask the user to login again here.
        //$login_url = $facebook->getLoginUrl(); 
        //echo 'Please <a href="' . $login_url . '">login.</a>';
        //error_log($e->getType());
        //error_log($e->getMessage());

		echo "please login";


      }   
    } 
	
	else {

      // No user, print a link for the user to login
     // $login_url = $facebook->getLoginUrl();
     // echo 'Please <a href="' . $login_url . '">login.</a>';
	 echo "please login;
    }

?>


<div id="ux_start" class="ux_cover">
	<img src="/facebook/images/sprite.gif" alt="loading data" class="ux_loadertop" />
	<div class="ux_loaderbottom">
			<img src="/facebook/images/sprite.gif" alt="bar" class="ux_bar" />	
	</div>	
</div>
</body>
</html>