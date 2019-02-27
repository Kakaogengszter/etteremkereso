<?php
$host = "localhost";
$user = "szoftverf";
$pwd = "szoftverf";
$db = "ettermek";
$port = "3306";

$conn = new mysqli($host,$user,$pwd,$db,$port);

if($conn -> connect_errno){
  die("Hiba");
}
$conn -> set_charset("utf8");


 ?>
