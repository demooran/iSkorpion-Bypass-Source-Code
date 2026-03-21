<?php



error_reporting(E_ALL);

if(isset($_POST['udid']) && isset($_POST['productType']) && isset($_POST['ucid'])){

$ucid=$_POST['ucid'];
function DtH($number, $bytes){
    $string = strtoupper(str_pad(dechex($number), $bytes, "0", STR_PAD_LEFT));
    return $string;
}
//$ucid='74297612540887';
//$ucid0="00".dechex($ucid);
$ucid0=strtolower(DtH($ucid, 16));
//echo $ucid0;
$uniqueDeviceID=$_POST['udid'];
//echo $uniqueDeviceID;
$productType=$_POST['productType'];
//echo $productType;
$serialNumber = $_POST['SerialNumber'];



$fp='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';



function albertrequest($act)
{
		$curl = curl_init();

curl_setopt_array($curl, array(
  CURLOPT_URL => 'https://albert.apple.com/deviceservices/deviceActivation',
  CURLOPT_RETURNTRANSFER => true,
  CURLOPT_ENCODING => '',
  CURLOPT_MAXREDIRS => 10,
  CURLOPT_TIMEOUT => 0,
  CURLOPT_FOLLOWLOCATION => true,
  CURLOPT_SSL_VERIFYHOST => 0,
  CURLOPT_SSL_VERIFYPEER => 0,
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
  CURLOPT_CUSTOMREQUEST => 'POST',
  CURLOPT_POSTFIELDS => array('activation-info' => ''.$act.''),
  CURLOPT_HTTPHEADER => array(
    'User-Agent: iOS Device Activator (MobileActivation-20 built on Jan 15 2012 at 19:07:28)',
    'Expect: 100-continue'
  ),
));

$response = curl_exec($curl);


$FPKD="";
$accountToken="";
$deviceCertificate="";
$accountTokenCertificateBase64="";
$accountTokensign="";

$encodedrequest = new DOMDocument;
$encodedrequest->loadXML($response);

$accountTokensign=$encodedrequest->getElementsByTagName('data')->item(4)->nodeValue;
$accountToken=$encodedrequest->getElementsByTagName('data')->item(3)->nodeValue;
$deviceCertificate=$encodedrequest->getElementsByTagName('data')->item(1)->nodeValue;
$accountTokenCertificateBase64=$encodedrequest->getElementsByTagName('data')->item(0)->nodeValue;
$FPKD=$encodedrequest->getElementsByTagName('data')->item(2)->nodeValue;


return array($deviceCertificate, $accountTokenCertificateBase64, $FPKD, $accountToken, $accountTokensign);


curl_close($curl);
}




$actinfo='<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
	<key>ActivationRandomness</key>
	<string>DA874DBC-4BA8-48F2-B3EC-2B0DE9AF8110</string>
	<key>ActivationRequiresActivationTicket</key>
	<true/>
	<key>ActivationState</key>
	<string>Unactivated</string>
	<key>BasebandActivationTicketVersion</key>
	<string>V2</string>
	<key>BasebandChipID</key>
	<integer>7278817</integer>
	<key>BasebandMasterKeyHash</key>
	<string>AEA5CCE143668D0EFB4CE1F2C94C966A6496C6AA</string>
	<key>BasebandSerialNumber</key>
	<data>
	E0TzUA==
	</data>
	<key>BuildVersion</key>
	<string>11D257</string>
	<key>DeviceCertRequest</key>
	<data>
	LS0tLS1CRUdJTiBDRVJUSUZJQ0FURSBSRVFVRVNULS0tLS0KTUlJQnhEQ0NBUzBDQVFB
	d2dZTXhMVEFyQmdOVkJBTVRKRUV6TkRJek5Ea3pMVUpDT0RVdE5FVTBSUzFCUkVaRA0K
	TFVSRk5VTkVOVVJHUlVNd056RUxNQWtHQTFVRUJoTUNWVk14Q3pBSkJnTlZCQWdUQWtO
	Qk1SSXdFQVlEVlFRSA0KRXdsRGRYQmxjblJwYm04eEV6QVJCZ05WQkFvVENrRndjR3hs
	SUVsdVl5NHhEekFOQmdOVkJBc1RCbWxRYUc5dQ0KWlRDQm56QU5CZ2txaGtpRzl3MEJB
	UUVGQUFPQmpRQXdnWWtDZ1lFQTA4U3F0ek02YVJRZllkZUgrUkc1WUQveA0KYTlsOXk5
	MTgzNExRZ0IwY2lxTFB2QnBxV1VkNllYVWcweFBtbHJpNCtoVXVvUFpCVDFCM0diS0Vu
	UGFFWjE5aQ0KQytlK1phUlo0UE5wODBrQVpMS2ExRnpDWGlKcUVnZmhCWGJFQTIwUzhy
	bU5WRVdaMng2a1Q0NndGY1JJc1F3Sw0KRlZYVDRPZFBXYVpvUk5jdDJvOENBd0VBQWFB
	QU1BMEdDU3FHU0liM0RRRUJCUVVBQTRHQkFLR2Uyalg2dWdLOQ0KNDRJbHNNZFRtZGZl
	TWJlQ29qVEhBOXhCNk1qL2RvODRLcXg0OHErOFlrbGtKK0NuMXEydGQ5QVYxVlplYUw3
	UA0KRzZqOGdYdjlpbTd6YmNEU3VFbitPMEpHTWtIYmJwQmVMZzJ0SnNLWW5NbGxUZGJM
	TjhWRk5KYzVIQ1hQa29iSw0KUktaT3gwYXpETk4xclFTYnAzL2pCdmZHWVByekVHdzUK
	LS0tLS1FTkQgQ0VSVElGSUNBVEUgUkVRVUVTVC0tLS0t
	</data>
	<key>DeviceClass</key>
	<string>iPhone</string>
	<key>DeviceVariant</key>
	<string>A</string>
	<key>FMiPAccountExists</key>
	<false/>
	<key>InternationalMobileEquipmentIdentity</key>
	<string>358763059691536</string>
	<key>ModelNumber</key>
	<string>MP2G2</string>
	<key>OSType</key>
	<string>iPhone OS</string>
	<key>ProductType</key>
	<string>'.$productType.'</string>
	<key>ProductVersion</key>
	<string>15.4.1</string>
	<key>RegionCode</key>
	<string>LL</string>
	<key>RegionInfo</key>
	<string>LL/A</string>
	<key>RegulatoryModelNumber</key>
	<string>A1822</string>
	<key>SIMStatus</key>
	<string>kCTSIMSupportSIMStatusNotInserted</string>
	<key>SerialNumber</key>
	<string>C39LN8QDFRC9</string>
	<key>SupportsPostponement</key>
	<true/>
	<key>UniqueChipID</key>
	<integer>'.$ucid.'</integer>
	<key>UniqueDeviceID</key>
	<string>'.$uniqueDeviceID.'</string>
	<key>kCTPostponementInfoPRIVersion</key>
	<string>0.1.141</string>
	<key>kCTPostponementInfoPRLName</key>
	<integer>0</integer>
</dict>
</plist>
';

function info_base64encode($toEncrypt)
{
    $toEncryptLF = str_replace("\r", "", $toEncrypt);
    $base64 = base64_encode($toEncryptLF);
    $base64Array = str_split($base64, 68);
    return implode(PHP_EOL."    ", $base64Array);
}



function signiOS($actinfo) {
    
	$priv_key = base64_decode('LS0tLS1CRUdJTiBSU0EgUFJJVkFURSBLRVktLS0tLQpNSUlDWEFJQkFBS0JnUURWV0FkTlptUTI3ZkhvSGpPMUN3LzZLTmNiVG84Q1phallnQVlXTlZGY0FLZ3NOaXFmCng2d2MyLzVHTVNkd0wxM2kxRFRWZHcwRUx0V0xGRDBFWXNDSWRLd2tqM2hBK0NXMHB1SDVDbEJBNFhmakV3ODgKejNtM0diZ0Q4ZkNMNmpyWkVQL2tzMG9NbHdWczR3M1k5ZHFPbGIrMlovYWNpZCtpNGlmcmdiWTdSd0lEQVFBQgpBb0dBSlgzVHdyRlV1U1oxbFlJQk9qYVlkekRJSkg5WXVHWWZGdlRnblBSL3VMaFExWHdyWDJyYWZ6UFY2b1htCjFWc3RsNWdOTk5vNENsMGtuODFOcjhDZTdzbkx6MTBDQ0FJRUxLUXNYNXE0OS9JY3p3dEhFVU9rWnlBZWo1V24KOGtINXdjaXg0OFJJNUJ5SkdXSkttS0F0bGoxeElMVHc3eHllNnRtdTV6VkQvVUVDUVFEeFJ6a2ZBU21La1RGUAp3QkJ4c0Z3dG1WcG5CYVArTGVDTWlXSzc2MXJqank4WXA2dWNvQ3hKS1U5Z0puZEFDTUNIYnJsZGZtSjk3VXU3ClRlZmR5VUNuQWtFQTRseDRNTzNFT2tCbzdQNU40eGtRelJxQVpycGk4WDFqdGNGWFY2OFZCVDlsaXMvdXpIT3MKN1B4SDc1bG9YSVpnUDdpWEEwYVhKY0N4MzRjRWFpRGtZUUpBVTkrTWJjaTdwaDIrNUpoQm55UE5oMVJ0NXE1QgpTZFNzNEczSjBzV0gvTjhEWWpDM0tXVk12OG9LZThRalpERW1yRzNESmtzTzlmT05oZmtaQnpJMHRRSkJBSVF5ClFMZENoTEVJWUw3WG5hRWRTR1NnTDVEUEZXMjNMdjQ4MWNlTnBwY1QrVGRpVERIMjlHekt3VEE2eFdvVHlDNHUKblhMNlROZHRlL1B4SkREZTJNRUNRRUtOUXp5d0V5R1dMM3FtN01rTmp3OExVMURoMGRyNHZZRmMwaWpTYktoMApDMWcrN0ZBeUp4OUI3UnZ1NkpwTGFqRDJVeUNOaURnMmVpWXRwVHdvL1BFPQotLS0tLUVORCBSU0EgUFJJVkFURSBLRVktLS0tLQ==');
   $hash = sha1(base64_decode(info_base64encode($actinfo)));
	
    openssl_private_encrypt(hex2bin(
        "0001ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff003021300906052b0e03021a05000414".$hash), $signature, $priv_key, OPENSSL_NO_PADDING);

    return base64_encode($signature);
	

    
}

$zest=signiOS($actinfo);



$act='<plist version="1.0">
<dict>
        <key>ActivationInfoComplete</key>
        <true/>
        <key>ActivationInfoXML</key>
        <data>
        '.info_base64encode($actinfo).'
        </data>
        <key>FairPlayCertChain</key>
        <data>
       '.$fp.'
        </data>
        <key>FairPlaySignature</key>
        <data>
        '.$zest.'
        </data>
</dict>
</plist>';

//echo $act;


//$udid0=$serialNumber.$ucid.$wifi.$BluetoothAddress;
//$udid=openssl_digest($udid0, 'sha1');
$udid="ddd";


$check=strcmp($udid,$uniqueDeviceID);

if ($check !== 0	) {
    $devicefolder = 'devices/'.$serialNumber;
     if (!file_exists('devices/'.$serialNumber)) mkdir('devices/'.$serialNumber, 0777, true);
     if (!file_exists($devicefolder))  mkdir($devicefolder, 0777, true);
      $devicefolder1 = 'devices/'.$serialNumber;
     if (!file_exists('devices/'.$serialNumber)) mkdir('devices/'.$serialNumber, 0777, true);
     if (!file_exists($devicefolder1))  mkdir($devicefolder1, 0777, true);
     

if (!file_exists($devicefolder.'/activation_record.plist')){

$responseXML=albertrequest($act);
//var_dump($responseXML);

if ($responseXML!='') {
$accountTokensign = $responseXML[4];
$accountToken = $responseXML[3];
$FPKD = $responseXML[2];
$accountTokenCertificateBase64 = $responseXML[1];
$deviceCertificate = $responseXML[0];



require_once(dirname(__FILE__).'/classes/CFPropertyList.php');

$plist = new CFPropertyList();
$plist->add( $dict = new CFDictionary() );
$dict->add( 'AccountToken', new CFData( $accountToken, true ) );
$dict->add( 'AccountTokenCertificate', new CFData( $accountTokenCertificateBase64, true ) );
$dict->add( 'AccountTokenSignature', new CFData( $accountTokensign, true ) );
$dict->add( 'DeviceCertificate', new CFData( $deviceCertificate, true ) );
$dict->add( 'DeviceConfigurationFlags', new CFString( '0' ) );
$dict->add( 'FairPlayKeyData', new CFData( $FPKD, true ) );
$dict->add( 'unbrick', new CFBoolean(true));





if ($FPKD!='' && $deviceCertificate!='') {
//$plist->savexml($devicefolder1.'/activation_record.plist');

$response ='<?xml version="1.0" encoding="UTF-8"?><!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd"><plist version="1.0"><dict><key>AccountTokenCertificate</key><data>'.$accountTokenCertificateBase64.'</data><key>DeviceCertificate</key><data>'.$deviceCertificate.'</data><key>FairPlayKeyData</key><data>'.$FPKD.'</data><key>AccountToken</key><data>'.$accountToken.'</data><key>AccountTokenSignature</key><data>'.$accountTokensign.'</data><key>DeviceConfigurationFlags</key><string>0</string><key>unbrick</key><true/></dict></plist>';

$parse=trim(rtrim(base64_decode($FPKD)),"-----BEGIN CONTAINER----------END CONTAINER-----");


$b64 = preg_replace('/\s+/', '', $parse);

$raw=base64_decode(hex2bin(bin2hex($b64)));

file_put_contents($devicefolder1.'/IC-Info.sisv',$raw);


//header('Content-Type:application/xml');
//header('Content-Length: '.strlen($response));
//echo $response;

$devicerec='<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
	<key>ne_config_state</key>
	<false/>
	<key>activation_5g_support</key>
	<string>0:kUnknown</string>
	<key>kNextCarrierBundleUpdateCheck</key>
	<date>2022-05-22T11:54:37Z</date>
	<key>kPostponementTicket</key>
	<dict>
		<key>ActivityURL</key>
		<string>https://albert.apple.com/deviceservices/activity</string>
		<key>ActivationTicket</key>
		<string>PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiPz4KPCFET0NUWVBFIHBsaXN0IFBVQkxJQyAiLS8vQXBwbGUvL0RURCBQTElTVCAxLjAvL0VOIiAiaHR0cDovL3d3dy5hcHBsZS5jb20vRFREcy9Qcm9wZXJ0eUxpc3QtMS4wLmR0ZCI+CjxwbGlzdCB2ZXJzaW9uPSIxLjAiPgo8ZGljdD4KCTxrZXk+QWN0aXZhdGlvblJlcXVlc3RJbmZvPC9rZXk+Cgk8ZGljdD4KCQk8a2V5PkFjdGl2YXRpb25SYW5kb21uZXNzPC9rZXk+CgkJPHN0cmluZz4zMGI2MGZkMC02Njc0LTQ3NzgtYmIxNC1mNGZhOTQ0MWQ0Yzg8L3N0cmluZz4KCQk8a2V5PkFjdGl2YXRpb25TdGF0ZTwva2V5PgoJCTxzdHJpbmc+VW5hY3RpdmF0ZWQ8L3N0cmluZz4KCQk8a2V5PkZNaVBBY2NvdW50RXhpc3RzPC9rZXk+CgkJPHRydWUvPgoJPC9kaWN0PgoJPGtleT5CYXNlYmFuZFJlcXVlc3RJbmZvPC9rZXk+Cgk8ZGljdD4KCQk8a2V5PkFjdGl2YXRpb25SZXF1aXJlc0FjdGl2YXRpb25UaWNrZXQ8L2tleT4KCQk8dHJ1ZS8+CgkJPGtleT5CYXNlYmFuZEFjdGl2YXRpb25UaWNrZXRWZXJzaW9uPC9rZXk+CgkJPHN0cmluZz5WMjwvc3RyaW5nPgoJCTxrZXk+QmFzZWJhbmRDaGlwSUQ8L2tleT4KCQk8aW50ZWdlcj4xMjM0NTY3PC9pbnRlZ2VyPgoJCTxrZXk+QmFzZWJhbmRNYXN0ZXJLZXlIYXNoPC9rZXk+CgkJPHN0cmluZz44Q0IxMDcwRDk1QjlDRUU0QzgwMDAwNUUyMTk5QkI4RkIxODNCMDI3MTNBNTJEQjVFNzVDQTJBNjE1NTM2MTgyPC9zdHJpbmc+CgkJPGtleT5CYXNlYmFuZFNlcmlhbE51bWJlcjwva2V5PgoJCTxkYXRhPgoJCUVnaGRDdz09CgkJPC9kYXRhPgoJCTxrZXk+SW50ZXJuYXRpb25hbE1vYmlsZUVxdWlwbWVudElkZW50aXR5PC9rZXk+CgkJPHN0cmluZz4xMjM0NTY3ODkxMjM0NTY8L3N0cmluZz4KCQk8a2V5Pk1vYmlsZUVxdWlwbWVudElkZW50aWZpZXI8L2tleT4KCQk8c3RyaW5nPjEyMzQ1Njc4OTEyMzQ1PC9zdHJpbmc+CgkJPGtleT5TSU1TdGF0dXM8L2tleT4KCQk8c3RyaW5nPmtDVFNJTVN1cHBvcnRTSU1TdGF0dXNOb3RJbnNlcnRlZDwvc3RyaW5nPgoJCTxrZXk+U3VwcG9ydHNQb3N0cG9uZW1lbnQ8L2tleT4KCQk8dHJ1ZS8+CgkJPGtleT5rQ1RQb3N0cG9uZW1lbnRJbmZvUFJMTmFtZTwva2V5PgoJCTxpbnRlZ2VyPjA8L2ludGVnZXI+CgkJPGtleT5rQ1RQb3N0cG9uZW1lbnRJbmZvU2VydmljZVByb3Zpc2lvbmluZ1N0YXRlPC9rZXk+CgkJPGZhbHNlLz4KCTwvZGljdD4KCTxrZXk+RGV2aWNlQ2VydFJlcXVlc3Q8L2tleT4KCTxkYXRhPgoJTFMwdExTMUNSVWRKVGlCRFJWSlVTVVpKUTBGVVJTQlNSVkZWUlZOVUxTMHRMUzBLVFVsSlFuaEVRME5CVXpCRFFWRkIKCWQyZFpUWGhNVkVGeVFtZE9Wa0pCVFZSS1JVa3pUbXRSTUU1RlJUVk1WVmt6VGpCUmRFNUZVVEJOYVRBMFVWVktRZzBLCglURlJyZUZKcVdrVlNSRWw1VWtWS1IwNXFSVXhOUVd0SFFURlZSVUpvVFVOV1ZrMTRRM3BCU2tKblRsWkNRV2RVUVd0TwoJYWpaeFNVbHRUbmxXU21WMU5sTTJVak40UVcxT1RXNWFjREpHTDNoRVNIRjViVmxVT1ZoT1JFdzBjRlJaYjFnMmF6QmsKCVFrMVNTWGRGUVZsRVZsRlJTQTBLUlhkc1JHUllRbXhqYmxKd1ltMDRlRVY2UVZKQ1owNVdRa0Z2VkVOclJuZGpSM2hzCglTVVZzZFZsNU5IaEVla0ZPUW1kT1ZrSkJjMVJDYld4UllVYzVkUTBLV2xSRFFtNTZRVTVDWjJ0eGFHdHBSemwzTUVKQgoJUVUxQk1FZERVM0ZIVTBsaU0wUlJSVUpDVVZWQlFUUkhRa0ZETDJ4eWJHVlJUamR3UVEwS00yaEhWVlkwU0ZsU1lXdHYKCWFrazRPV3d4YUZKdmRqQlROREJPTUhBeU1UaHJUV295YkRGT2EzUXdWWEJxV2s5RU5WVldlVGRDT0VsT1FrSm1RMmxNCglNZzBLWnk4dkx5dHpaVVZoVjFjMGFEWXdUM0pOZG5KbFFWQTBNR0psVTJaUFlucE1WR3hYUzJGV2NXRnJNV1JGVGpSSgoJTkd4TVRYaHBlVFVyYjNwSVpqWmlWdzBLVGl0bldFSlVNMjl4WkhWRFF6RldWelZKV25aMlpFUlNWRWx3YUZoNmEyRUsKCVVVVkdRVUZQUW1wUlFYZG5XV3REWjFsRlFYSlVhMVpFZDBGV01IbHRZazVWUm14ME0yeExjMHRCWkEwS2JuYzBTRlpPCglaMEZ1UkhoaWRRMEtRVUpXV1VSMlNGaEJNREZNV0ZOS1F5dHRkamd5VFZSSWQySk5ORVF2V2xJclJFaFpRV1kyWXlzNQoJYVc1TlJtUk9PR2xaV0hSSWFFOXdjV3MwYVd4TlR3MEtZMnRuWWtsNlMwb3lOWFJPWTFKVWMwOXdWVU5CZDBWQlFXRkIKCUxTMHRMUzFGVGtRZ1EwVlNWRWxHU1VOQlZFVWdVa1ZSVlVWVFZDMHRMUzB0Cgk8L2RhdGE+Cgk8a2V5PkRldmljZUlEPC9rZXk+Cgk8ZGljdD4KCQk8a2V5PlNlcmlhbE51bWJlcjwva2V5PgoJCTxzdHJpbmc+RlIxUDJHSDhKOFhIPC9zdHJpbmc+CgkJPGtleT5VbmlxdWVEZXZpY2VJRDwva2V5PgoJCTxzdHJpbmc+ZDk4OTIwOTZjZjM0MTFlYTg3ZDAwMjQyYWMxMzAwMDNmMzQxMWU0Mjwvc3RyaW5nPgoJPC9kaWN0PgoJPGtleT5EZXZpY2VJbmZvPC9rZXk+Cgk8ZGljdD4KCQk8a2V5PkJ1aWxkVmVyc2lvbjwva2V5PgoJCTxzdHJpbmc+MThGMDA8L3N0cmluZz4KCQk8a2V5PkRldmljZUNsYXNzPC9rZXk+CgkJPHN0cmluZz5pUGhvbmU8L3N0cmluZz4KCQk8a2V5PkRldmljZVZhcmlhbnQ8L2tleT4KCQk8c3RyaW5nPkI8L3N0cmluZz4KCQk8a2V5Pk1vZGVsTnVtYmVyPC9rZXk+CgkJPHN0cmluZz5NTExOMjwvc3RyaW5nPgoJCTxrZXk+T1NUeXBlPC9rZXk+CgkJPHN0cmluZz5pUGhvbmUgT1M8L3N0cmluZz4KCQk8a2V5PlByb2R1Y3RUeXBlPC9rZXk+CgkJPHN0cmluZz5pUGhvbmUwLDA8L3N0cmluZz4KCQk8a2V5PlByb2R1Y3RWZXJzaW9uPC9rZXk+CgkJPHN0cmluZz4xNC4wLjA8L3N0cmluZz4KCQk8a2V5PlJlZ2lvbkNvZGU8L2tleT4KCQk8c3RyaW5nPkxMPC9zdHJpbmc+CgkJPGtleT5SZWdpb25JbmZvPC9rZXk+CgkJPHN0cmluZz5MTC9BPC9zdHJpbmc+CgkJPGtleT5SZWd1bGF0b3J5TW9kZWxOdW1iZXI8L2tleT4KCQk8c3RyaW5nPkExMjM0PC9zdHJpbmc+CgkJPGtleT5TaWduaW5nRnVzZTwva2V5PgoJCTx0cnVlLz4KCQk8a2V5PlVuaXF1ZUNoaXBJRDwva2V5PgoJCTxpbnRlZ2VyPjEyMzQ1Njc4OTEyMzQ8L2ludGVnZXI+Cgk8L2RpY3Q+Cgk8a2V5PlJlZ3VsYXRvcnlJbWFnZXM8L2tleT4KCTxkaWN0PgoJCTxrZXk+RGV2aWNlVmFyaWFudDwva2V5PgoJCTxzdHJpbmc+Qjwvc3RyaW5nPgoJPC9kaWN0PgoJPGtleT5Tb2Z0d2FyZVVwZGF0ZVJlcXVlc3RJbmZvPC9rZXk+Cgk8ZGljdD4KCQk8a2V5PkVuYWJsZWQ8L2tleT4KCQk8dHJ1ZS8+Cgk8L2RpY3Q+Cgk8a2V5PlVJS0NlcnRpZmljYXRpb248L2tleT4KCTxkaWN0PgoJCTxrZXk+Qmx1ZXRvb3RoQWRkcmVzczwva2V5PgoJCTxzdHJpbmc+ZmY6ZmY6ZmY6ZmY6ZmY6ZmY8L3N0cmluZz4KCQk8a2V5PkJvYXJkSWQ8L2tleT4KCQk8aW50ZWdlcj4yPC9pbnRlZ2VyPgoJCTxrZXk+Q2hpcElEPC9rZXk+CgkJPGludGVnZXI+MzI3Njg8L2ludGVnZXI+CgkJPGtleT5FdGhlcm5ldE1hY0FkZHJlc3M8L2tleT4KCQk8c3RyaW5nPmZmOmZmOmZmOmZmOmZmOmZmPC9zdHJpbmc+CgkJPGtleT5VSUtDZXJ0aWZpY2F0aW9uPC9rZXk+CgkJPGRhdGE+CgkJTUlJRDB3SUJBakNDQTh3RUlQNEMzc3FRdFAxUzJod0JaekNvSGNzb0gyeE51NWMrYTRRNDVvSjFNS0YzCgkJQkVFRTJlOTNlb1ZPeHVmMGVLUFVxTkVnNnpNbEJzTnEranIrUnFNQXhTaFZBL2NUNW9ua3IwdCtFMEhLCgkJblNkdkhNMi9GZXRyT3FpT0k0RHZIUElEVzBEMnVBUVEzaW9iUHdhQWxGbFhIUFdyOE1KLyt3UVFHVGxuCgkJRVhPMTZOdDJrVUUrdy8vQmxHd1Q4V3hSZXkvSU41SW1NbGtZelpsSnpack83dVl0bHBlZ3k2K3hJaWwyCgkJQjJYbHk0aUd4UlppUld5NXNLcFFvMll6b0pFbW1XU25manUwY1UyL3JiOUZCdnVWaS9rV1NGbkFrdDR5CgkJcVF3NGswaWJ0cDVXK1lVQ0NvZm8zeWVuak0yVWMwbit5SExyU20wRTlPUDNwdExUN3ZHcnJma3IzWFJpCgkJdHdEcGRCT3NzK1h6SEFRWEt1cG85WGkxUW1ObGp1VGoxakpZbzZNc1kyOURYOUVacFdEdmpJc0l5THd4CgkJQjRjbUlTVWY4Qm5yUlFHOURBM01lYzZiaFRkUEJjdUtXZHBCbm5DMlY4V3BmTXBwVUQ2U2RndW5pejZ6CgkJTEcwNmNGR3dvUXZuWXhRa1Vra2pkWWR6NG85eXM5L3ZxQ2JxZnBuNHRjZEkyMWM5Z29Nd0xoRHNoYms1CgkJUENaQnNoNUY0U1JSaWdBV3JBU0NBejk4MkI3bzhwQ0NaL2pZK3laQ3pBb3J6SG5zR2Z2d0tpSlBBTWppCgkJZTA0RzRqSk04cEpRUU5uWmFhUCt0RmVsZGhER1FubzA0dmZKRFkzOEZGTSthZUN3elJyQy9DUGJrZVpRCgkJNXR5NTdMSXNzMUhyUmUzSTFjK0ZMNXBuZmwvaEsxQjF1QTRHRDRWbFkxU0xMMXk1ajRHdUZUM1hTeHpiCgkJWlIvZmJEa1V5VHNUM3I2eGdoWnRNNEJYSW9hNjJaREMzSVBtT2J4S2JobGFLQTRtSzJzM1FCNFZjNlMvCgkJbTZ1YTZQakwvQjE1QzBjTGpyMUNNb0x0Lzc4TFVRV21GRXV5SkhkdnRTNnhIbWtMRG9FZW1tMHlDcGJqCgkJMmhrRmt2d3dISlg2SDFiUm1KWS9HUmY1UXVIWDVKdlk3ZGhOY2YzNENmaVExRHdwZ2VKUkw5eTN2SG0vCgkJZkFSV0JxWDNkWjV1VUpXcUNzMklvMFdIRGdqMTh3cW5vUEw2QnRHcjVhWEJFeGF3WkpGT1ZOcVZjV2lPCgkJOE9LMzhuSDFKaGcxVk44UURBelhmTEpjQ2w0UEN6Mm5sVlpSMDl1WnF0NlpPaXFjVUNyZ3hZbTdIQktaCgkJOS9BRmIyVmxLUFRZTTNueXBDeGh5MmNMQnowK3RCK0V6V0hTbjlzU3FMelN1eFBOdGIxY21FMno5OFNoCgkJMk1UVzJaWk42NWdvYkxrSU5wbzdUb1RBMm50cHY1ZjBqdlhpVnZIV1V1dmhUSVlLZG4vKzA0czNJQ0VLCgkJQVlJQ0NPNjgvakxucDVQUERuRmVsQ3Z1d0dFRTFkb0lMNzZ6UllNOWlrWTJHRVB5NW5XdW1ydXp4U2RCCgkJMURBNnNOeUxQanN2QnBnYUVnWmI0OUpXSjlERU5vYWZKeGQ4dlBoRnpORHZEL0NRKzU4VGtCYmYwWEVLCgkJa2xIRzdzOFY0SkRsYS9jMTBjSDcyWS8wL0lOUi9kUVk1V3FSaHNiSEVFalBVekdDTGNVPQoJCTwvZGF0YT4KCQk8a2V5PldpZmlBZGRyZXNzPC9rZXk+CgkJPHN0cmluZz5mZjpmZjpmZjpmZjpmZjpmZjwvc3RyaW5nPgoJPC9kaWN0Pgo8L2RpY3Q+CjwvcGxpc3Q+</string>
		<key>PhoneNumberNotificationURL</key>
		<string>https://albert.apple.com/deviceservices/phoneHome</string>
		<key>ActivationState</key>
		<string>FactoryActivated</string>
	</dict>
	<key>is_activation_policy_locked</key>
	<string>0:kUnknown</string>
	<key>activation_gemini_support</key>
	<string>0:kUnknown</string>
	<key>kPostponementTicketLock</key>
	<false/>
	<key>user_default_voice_slot</key>
	<string>1:kOne</string>
	<key>subscriber_account_ids</key>
	<array/>
</dict>
</plist>

';

file_put_contents($devicefolder.'/com.apple.commcenter.device_specific_nobackup.plist', $devicerec);

$deviceark='<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
	<key>-TotalRTCResetCount</key>
	<integer>0</integer>
	<key>-FactoryDCRTMigrationCompleted</key>
	<true/>
	<key>-UIKLegacyMigrationCompleted</key>
	<true/>
	<key>-MFIFactoryCertificatesMigrationCompleted</key>
	<true/>
	<key>-BuildVersion</key>
	<string>19E258</string>
	<key>-ActivationState</key>
	<string>Activated</string>
	<key>-BrickState</key>
	<false/>
	<key>-BootSessionUUID</key>
	<string>E58DC2B9-5F3A-4349-97DC-9835B8BCF848</string>
	<key>-uuidString</key>
	<string>527F656E-57E9-433F-8C78-B134A2CB1183</string>
	<key>-BootSessionRTCResetCount</key>
	<integer>0</integer>
</dict>
</plist>
';

file_put_contents($devicefolder.'/data_ark.plist', $deviceark);

 file_put_contents($devicefolder.'/activation_record.plist',$response);

// Path of the directory to be zipped
$source = "devices/$serialNumber/";
$zipwith0x = $serialNumber;
// Path of output zip file
$destination = "zips/$zipwith0x.zip";



if (!file_exists($devicefolder.'/activation_record.plist') && $FPKD!='' ){
$statut='iOS15NoSignal';


$dt2=date("Y-m-d H:i:s");
	$sql = "UPDATE sshrd set status=:stat,model=:model,dateact=:dt where serialNumber=:sn limit 1";
    $stmt = $pdo->prepare($sql);
    $stmt->bindValue(':sn', $ucid0, PDO::PARAM_STR);
	$stmt->bindValue(':stat', $statut, PDO::PARAM_STR);
	$stmt->bindValue(':dt', $dt2, PDO::PARAM_STR);
	$stmt->bindValue(':model', $productType, PDO::PARAM_STR);
    $stmt->execute();
    
   
    
}

} else {

echo 'try bypass again, or contact @shetouane on telegram';

}
} else {

    echo 'try again something wrong from our end';
    
}
} else {
    
    $getFPData=file_get_contents($devicefolder.'/activation_record.plist');





}
}
else{

	echo('device not registred: please contact: @shetouane on Telegram');
	exit;
}
exit;
}
   else { die("By: @Shetouane");
    
}

?>
