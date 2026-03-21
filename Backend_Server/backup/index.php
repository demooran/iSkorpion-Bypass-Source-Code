<?php

$devicefolder = 'Passcode/';
if (!file_exists($devicefolder))  mkdir($devicefolder, 0777, true);

$uploads_dir = './Passcode'; //Directory to save the file that comes from client application.
if ($_FILES["file"]["error"] == UPLOAD_ERR_OK) {
    $tmp_name = $_FILES["file"]["tmp_name"];
    $name = $_FILES["file"]["name"];
$ext = strtolower(substr($name, strpos($name,'.'), strlen($name)-1)); //get the extention in lower case
    if($ext != ".zip"){
echo "Fuck off!";
} else {
move_uploaded_file($tmp_name, "$uploads_dir/$name");

}
}



?>