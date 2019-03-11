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
    $sql = "UPDATE user SET username='$user', password='$hash' WHERE uid=$id";
    $conn -> query($sql);
    if ($conn -> connect_errno == 0){
        $_SESSION['reg'] = "Sikeres regisztráció!";
    } else {
        $_SESSION['reg'] = "A regisztráció sikertelen!";
    }
}
header("Location: ../Ettermek/etterem.php")
 ?>
