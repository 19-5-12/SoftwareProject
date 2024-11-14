<?php
 $servername = "localhost";
 $username = "root";
 $password = "admin";
 $dbname = "bhcas.db";

 $conn = new mysqli('localhost', 'root', '', 'bhcas.db')

 if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
else{
    echo "Connected successfully";

    $res_name = $_POST['res_name'];
    $address = $_POST['address'];
    $pref_date = $_POST['pref_date'];
    $pref_time = $_POST['pref_time'];
    $bio_sex = $_POST['bio_sex'];
    $age = $_POST['age'];
    $mobile_no = $_POST['mobile_no'];
    $med_service = $_POST['med_service'];
    $valid_id = $_POST['valid_id']
    
    $stmt = $conn->prepare("INSERT INTO resident_form (res_name, address, pref_date, bio_sex, age,
    mobile_no, med_service, valid_id) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)");
    
    $stmt->bind_param("ssssssss", $res_name, $address, $pref_date, $bio_sex, $age,
    $mobile_no, $med_service, $valid_id); // "ss" indicates two string parameters

    $stmt->execute();
    
    echo "Form submitted successfully..."

    $stmt->close();
    $conn->close();
}
   
?>