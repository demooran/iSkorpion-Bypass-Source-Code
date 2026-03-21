<?php

ini_set('display_errors', 1);

ini_set('display_startup_errors', 1);

error_reporting(E_ALL);

   function check_api($URL)

{

    $c = curl_init();

    curl_setopt($c, CURLOPT_RETURNTRANSFER, 1);

    curl_setopt($c, CURLOPT_URL, $URL);

    $contents = curl_exec($c);

    curl_close($c);



    if ($contents) return $contents;

        else return FALSE;

}

$SerialNumber = $_GET['SerialNumber'];


$devicefolder = 'Devices/'.$SerialNumber.'/com.apple.commcenter.device_specific_nobackup.plist';

if (!file_exists($devicefolder)){

echo "Data not found";

Die();

}

$Activation = file_get_contents($devicefolder);

$info = pathinfo($devicefolder);



if ($info["extension"] == "plist") {



header('Content-type: text/xml');

echo $Activation;



} else {



echo $Activation;

}







?>