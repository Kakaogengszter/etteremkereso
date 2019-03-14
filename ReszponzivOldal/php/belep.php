<?php
session_start();

require_once('../connection.php');
require_once('../functions.php');



if (isset($_POST['belep'])){
    $userName = $_POST['username'];
    $pwd = $_POST['password'];
    //$hash = password_hash($pwd, PASSWORD_DEFAULT);
    $sql = "SELECT * FROM user WHERE username = '$userName' /*AND password='$pwd'*/ ";
    $res = $conn -> query($sql);




    if ($res) {

        if($res -> num_rows == 1){
            //belépett
            $row = $res -> fetch_row();

            if (password_verify($pwd, $row[2])) {


            $_SESSION['uid'] = $row[0];
            header("Location: ../Ettermek/etterem.php");
            echo ("Hello");
        } else {
            //érvénytelen belépés
            $_SESSION['error'] = 'Helytelen felhasználónév vagy jelszó!';
            echo "<p>Helytelen felhasználónév vagy jelszó</p>";

        }
    }
}

}
echo "</body>";

?>
