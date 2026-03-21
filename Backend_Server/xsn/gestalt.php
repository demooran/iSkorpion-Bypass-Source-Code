<?php
// Error reporting - only for development
ini_set('display_startup_errors', 1);
ini_set('display_errors', 1);
error_reporting(-1);

// Security: Define allowed product types
$allowedProductTypes = [
    'iPhone8,1', 'iPhone8,2', 'iPhone8,4',
    'iPhone9,1', 'iPhone9,3', 'iPhone9,2', 'iPhone9,4',
    'iPhone10,3', 'iPhone10,6', 'iPhone10,1', 'iPhone10,4',
    'iPhone10,2', 'iPhone10,5', 'iPad7,11', 'iPad7,12',
    'iPad5,4', 'iPad5,3', 'iPad7,5', 'iPad7,6',
    'iPad6,12', 'iPad6,11', 'iPad6,4', 'iPad6,3',
    'iPad5,1', 'iPad5,2', 'iPad7,3', 'iPad7,4'
];

// Validate and sanitize input
function sanitizeInput($input) {
    return htmlspecialchars(trim($input), ENT_QUOTES, 'UTF-8');
}

// Get POST data with validation
$ProductType = isset($_POST['ProductType']) ? sanitizeInput($_POST['ProductType']) : '';
$iOSVersion = isset($_POST['iOSVersion']) ? sanitizeInput($_POST['iOSVersion']) : '';
$DeviceClass = isset($_POST['DeviceClass']) ? sanitizeInput($_POST['DeviceClass']) : '';
$Arch = isset($_POST['Arch']) ? sanitizeInput($_POST['Arch']) : '';
$BuildNumber = isset($_POST['BuildNumber']) ? sanitizeInput($_POST['BuildNumber']) : '';
$Model = isset($_POST['Model']) ? sanitizeInput($_POST['Model']) : '';
$HardwareX = isset($_POST['Hardware']) ? sanitizeInput($_POST['Hardware']) : '';
$Hardware = strtoupper($HardwareX);
$CPU = isset($_POST['Platform']) ? sanitizeInput($_POST['Platform']) : '';
$SerialNumber = isset($_POST['SerialNumber']) ? sanitizeInput($_POST['SerialNumber']) : '';
$ProductName = isset($_POST['ProductName']) ? sanitizeInput($_POST['ProductName']) : '';
$ECID = isset($_POST['ecid']) ? sanitizeInput($_POST['ecid']) : '';

// Validate required fields - using ECID instead of SerialNumber
if (empty($ProductType)) {
    http_response_code(400);
    echo "Error: ProductType is required";
    exit;
}

// Validate ProductType
if (!in_array($ProductType, $allowedProductTypes)) {
    http_response_code(400);
    echo "Error: Invalid ProductType";
    exit;
}

// Device folder configuration - adjust path based on your structure
$devicefolder = 'devices/';
$basePath = $_SERVER['DOCUMENT_ROOT'] . '/bypass/xsn/';

// Ensure directory exists and is writable
if (!is_dir($basePath . $devicefolder) && !mkdir($basePath . $devicefolder, 0755, true)) {
    http_response_code(500);
    echo "Error: Cannot create device folder";
    exit;
}

// Use ECID as primary identifier, fallback to SerialNumber if ECID is empty
$identifier = $SerialNumber;

// If both ECID and SerialNumber are empty, generate a unique ID
if (empty($identifier)) {
    $identifier = uniqid('device_', true);
}

// Security: Prevent directory traversal
// Use only alphanumeric characters and underscores for safety
$safeIdentifier = preg_replace('/[^A-Za-z0-9_\-]/', '_', $identifier);
$filename = $safeIdentifier . '.plist';
$filepath = $basePath . $devicefolder . $filename;

// Include gestalt files based on product type
$Gestalt = '';
$gestaltMap = [
    'iPhone8,1' => '6s.php',
    'iPhone8,2' => '6sp.php',
    'iPhone8,4' => 'SE.php',
    'iPhone9,1' => '7only.php',
    'iPhone9,3' => '7only.php',
    'iPhone9,2' => '7plus.php',
    'iPhone9,4' => '7plus.php',
    'iPhone10,3' => 'X.php',
    'iPhone10,6' => 'X.php',
    'iPhone10,1' => '8only.php',
    'iPhone10,4' => '8only.php',
    'iPhone10,2' => '8plus.php',
    'iPhone10,5' => '8plus.php',
    'iPad7,11' => 'iPad7.php',
    'iPad7,12' => 'iPad7.php',
    'iPad5,4' => 'iPadAir2.php',
    'iPad5,3' => 'iPadAir2.php',
    'iPad7,5' => 'iPad6.php',
    'iPad7,6' => 'iPad6.php',
    'iPad6,12' => 'iPad5.php',
    'iPad6,11' => 'iPad5.php',
    'iPad6,4' => 'iPad5.php',
    'iPad6,3' => 'iPad5.php',
    'iPad5,1' => 'iPadMini4.php',
    'iPad5,2' => 'iPadMini4.php',
    'iPad7,3' => 'iPad105.php',
    'iPad7,4' => 'iPad105.php'
];

// Include the appropriate gestalt file
if (isset($gestaltMap[$ProductType])) {
    $gestaltFile = $basePath . 'addons/' . $gestaltMap[$ProductType];
    if (file_exists($gestaltFile)) {
        // Include the file - these files should define the Gestalt variables
        include($gestaltFile);
    } else {
        http_response_code(500);
        echo "Error: Gestalt configuration file not found: " . $gestaltMap[$ProductType];
        exit;
    }
} else {
    http_response_code(500);
    echo "Error: No gestalt mapping found for ProductType: " . $ProductType;
    exit;
}

// Map product type to gestalt variable name
$gestaltVariableMap = [
    'iPhone8,1' => 'Gestalt6s',
    'iPhone8,2' => 'Gestalt6sp',
    'iPhone8,4' => 'GestaltSE',
    'iPhone9,1' => 'Gestalt7',
    'iPhone9,3' => 'Gestalt7',
    'iPhone9,2' => 'Gestalt7p',
    'iPhone9,4' => 'Gestalt7p',
    'iPhone10,3' => 'GestaltX',
    'iPhone10,6' => 'GestaltX',
    'iPhone10,1' => 'Gestalt8',
    'iPhone10,4' => 'Gestalt8',
    'iPhone10,2' => 'Gestalt8plus',
    'iPhone10,5' => 'Gestalt8plus',
    'iPad7,11' => 'Gestalt7Pad',
    'iPad7,12' => 'Gestalt7Pad',
    'iPad5,4' => 'GestaltAir2',
    'iPad5,3' => 'GestaltAir2',
    'iPad7,5' => 'Gestalt6Pad',
    'iPad7,6' => 'Gestalt6Pad',
    'iPad6,12' => 'Gestalt5Pad',
    'iPad6,11' => 'Gestalt5Pad',
    'iPad6,4' => 'Gestalt5Pad',
    'iPad6,3' => 'Gestalt5Pad',
    'iPad5,1' => 'GestaltMini4',
    'iPad5,2' => 'GestaltMini4',
    'iPad7,3' => 'Gestalt105Pad',
    'iPad7,4' => 'Gestalt105Pad'
];

// Get the gestalt data
if (isset($gestaltVariableMap[$ProductType])) {
    $gestaltVarName = $gestaltVariableMap[$ProductType];
    if (isset($$gestaltVarName)) {
        $Gestalt = $$gestaltVarName;
    } else {
        http_response_code(500);
        echo "Error: Gestalt variable '$gestaltVarName' not defined in included file";
        exit;
    }
} else {
    http_response_code(500);
    echo "Error: No gestalt variable mapping for ProductType: " . $ProductType;
    exit;
}

// Write gestalt data to file
try {
    if (file_put_contents($filepath, $Gestalt, LOCK_EX) === false) {
        throw new Exception('Failed to write gestalt data');
    }
    
    // Set appropriate permissions
    chmod($filepath, 0644);
    
    // Verify file was created
    if (!file_exists($filepath)) {
        throw new Exception('File was not created');
    }
    
    // Return success response
    echo "Data Generated Successfully";
    echo "\nFile saved as: " . $filename;
    echo "\nFull path: " . $filepath;
    echo "\n\nDevice Info:";
    echo "\n- Product Type: " . $ProductType;
    echo "\n- Model: " . $Model;
    echo "\n- ECID: " . $ECID;
    echo "\n- Serial Number: " . $SerialNumber;
    echo "\n- iOS Version: " . $iOSVersion;
    
} catch (Exception $e) {
    http_response_code(500);
    echo "Error: Failed to generate data - " . $e->getMessage();
}
?>