<?php
session_start();
require'../menu.php';
require_once('../connection.php');

if (isset($_SESSION['uid'])){

    die();
} else {
    $menu = file_get_contents('../In-Out/menu_out.html');
}
  //header('Location: ../Fooldal/fooldal.php');

?>
<!DOCTYPE html>
<html lang="hu">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
      <script src="../jquery-3.3.1.min.js" charset="UTF-8"></script>

    <!-- Bootstrap CSS -->

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js" type="text/javascript"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <link rel="stylesheet" href="regisztracio.css">
    <script src="../validacio.js" charset="UTF-8"></script>
    <link rel="stylesheet" href="../reszponziv.css">



    <title>Szegedi Éttermek</title>


  </head>
  <body>



<nav>
    <?php echo $menu; ?>
</nav>




</form>
<div class="form" align="center">
   <form class="flex-container" method="post" action="../php/reg.php">
        <div class="form-group" id="col-75">
            <label id="label" >Felhasználónév*</label>
            <input type="username" name = "user" class="form-control" id="exampleFormControlInput1" placeholder="Kakaógengszter" required><br>
            <span id="userError"></span>
        <br>
        </div>
		<div class="form-group" id="col-75">
            <label id="label">Email cím*</label>
            <input type="email" name = "email" class="form-control" id="exampleFormControlInput1" placeholder="valami@valami.com" required><br>
            <span id="emailError"></span>
            <br>
        </div>
        <div class="form-group" id="col-75">
            <label id="label">Jelszó*</label>
            <input type="password" name = "pwd" class="form-control" id="exampleFormControlInput1" required><br>
            	<span id="pwdError"></span>
              <br>
        </div>
		 <div class="form-group" id="col-75">
            <label id="label">Jelszó megerősítése</label>
            <input type="password" name = "pwdc" class="form-control" id="exampleFormControlInput1" required><br>
            <span id="pwdcError"></span>
            <br>
        </div>

        <div class="form-group" id="col-75">
        <button type="submit" value="Regisztráció" name="reg" class="btn btn-dark" id="submitbtn">Regisztráció</button>
        </div>
</div>





    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
