<?php
session_start();
require_once("../connection.php");
if (!isset($_POST["mod"])){
    die();
}
$user = trim($_POST["user"]);
$pwd = trim($_POST["pwd"]);
$pwdc = trim($_POST["pwdc"]);
$id = $_SESSION['uid'];
if (($pwd == $pwdc) && ($user != $pwd) && (strlen($user) > 6 ) && (strlen($pwd) > 6)){
    $hash = password_hash($pwd, PASSWORD_DEFAULT);

    $jelszo = "SELECT password FROM user WHERE uid = $id";
    $res = $conn -> query($jelszo);
    $row = $res -> fetch_assoc();
    if(password_verify($_POST['apwd'],$row['password'])){
      $sql = " UPDATE user SET username= '$user', password='$hash' WHERE uid=$id ";
      $conn -> query($sql);
      if ($conn -> connect_errno == 0){
          $_SESSION['mod'] = "Sikeres módosítás!";
      } else {
          $_SESSION['mod'] = "A módosítás sikertelen!";
      }
    }else
      $_SESSION['mod'] = "A jelenlegi jelszó nem megfelelő";



}
header("Location: ../Ettermek/etterem.php")
 ?>
