<?php
session_start();
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


<!doctype html>
<html lang="hu">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="belepes.css">
    <script src="belepes.js"></script>
	<link rel="stylesheet" href="../reszponziv.css">

    <title>Belépés</title>
  </head>
  <body>

  <nav class="navbar navbar-expand-lg navbar-dark bg-dark" >
  <a class="navbar-brand" href="#"></a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="../Fooldal/fooldal.php">Főoldal <span class="sr-only">(current)</span></a>
      </li>

      <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Éttermek
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
          <a class="dropdown-item" href="../Ettermek/ettermek.php">Összes étterem</a>
          <div class="dropdown-divider"></div>
          <a class="dropdown-item" href="#">Pontozás</a>
        </div>
		<li class="nav-item">
        <a class="nav-link" href="belepes.php">Belépés</a>
		<li class="nav-item">
        <a class="nav-link" href="../Regisztracio/regisztracio.php">Regisztráció</a>
      </li>
      </li>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input class="form-control mr-sm-2" type="search" placeholder="Étterem kereső" aria-label="Search">
      <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Keresés</button>
    </form>
  </div>
</nav>

<!-- Inspired by https://codepen.io/transportedman/pen/NPWRGq -->

<div class="carousel slide carousel-fade" data-ride="carousel">

    <!-- Wrapper for slides -->
    <div class="carousel-inner" role="listbox">
        <div class="item active">
        </div>
        <div class="item">
        </div>
        <div class="item">
        </div>
    </div>
</div>

<!-- Remeber to put all the content you want on top of the slider below the slider code -->



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
        </form>
 </div>





    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
