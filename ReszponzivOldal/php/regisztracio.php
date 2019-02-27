<?php
require_once('../connection.php');

if (isset($_SESSION['uid'])){
    header('Location: ../Fooldal/fooldal.php');
    die();
} else {
    $menu = file_get_contents('../In-Out/menu_out.html');
}
$regForm = file_get_contents("reg_form.html");

?>

<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Regisztráció</title>
        <link rel="stylesheet" type="text/css" href="../style.css">
    </head>
    <body>
        <nav>
            <?php echo $menu; ?>
        </nav>
        <?php
            echo $regForm;

              

        ?>
    </body>
</html>
