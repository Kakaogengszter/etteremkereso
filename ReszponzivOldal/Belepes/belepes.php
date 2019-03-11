<?php
session_start();
require'../menu.php';
require_once('../connection.php');
if (isset($_SESSION['uid'])){
    //Belépve
    $menu = file_get_contents('../In-Out/menu_in.html');
  }
  else {
      //Nincs belépve
      $menu = file_get_contents('../In-Out/menu_out.html');
  }


?>




<!-- Remeber to put all the content you want on top of the slider below the slider code -->


  <link rel="stylesheet" href="belepes.css">
<div class="form" align="center">
   <form class="flex-container" action="../php/belep.php" method="post">
        <div class="form-group" id="col-75">
            <label id="label">Felhasználónév</label>
            <input type="username" class="form-control" name="username" id="exampleFormControlInput1">
        </div>
        <div class="form-group" id="col-75">
            <label id="label">Jelszó</label>
            <input type="password" class="form-control" name="password" id="exampleFormControlInput1">
        </div>
        <div class="form-group" id="col-75">
        <button type="submit" name="belep" value="Belép" class="btn btn-dark" id="submitbtn">Belépés</button>

        </div>
         <button type="submit" name="regist" value="Regiszrű" class="btn btn-dark" id="submitbtn" href="Regisztracio/regisztracio.php">Regisztráció</button>
        </form>
 </div>






    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
