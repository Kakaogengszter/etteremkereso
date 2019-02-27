<?php
    session_start();
    require_once("../connection.php");
    if (!isset($_POST["reg"])){
        die();
    }
    $user = trim($_POST["user"]);
    $pwd = trim($_POST["pwd"]);
    $pwdc = trim($_POST["pwdc"]);
    if (($pwd == $pwdc) && ($user != $pwd) && (strlen($user) > 6 ) && (strlen($pwd) > 6)){
        $hash = password_hash($pwd, PASSWORD_DEFAULT);
        $sql = "INSERT INTO user (username,password) VALUES ('$user', '$hash')";
        $conn -> query($sql);
        if ($conn -> connect_errno == 0){
            $_SESSION['reg'] = "Sikeres regisztráció!";
        } else {
            $_SESSION['reg'] = "A regisztráció sikertelen!";
        }
    }
