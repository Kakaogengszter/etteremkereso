<!DOCTYPE html>
<html lang="hu">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
	<link rel="stylesheet" href="../reszponziv.css">
  <link rel="stylesheet"  type="text/css" href="fooldal.css">

    <title>Szegedi Éttermek</title>

    <style>
        table, td, th{
            border: 1px solid black;
              border-collapse: collapse;
        }
    </style>

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
          <a class="nav-link" href="fooldal.html">Főoldal <span class="sr-only">(current)</span></a>
        </li>

        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            Éttermek
          </a>
          <div class="dropdown-menu" aria-labelledby="navbarDropdown">
            <a class="dropdown-item" href="#">Összes étterem</a>
            <div class="dropdown-divider"></div>
            <a class="dropdown-item" href="#">Pontozás</a>
          </div>
  		<li class="nav-item">
          <a class="nav-link" href="../Belepes/belepes.html">Belépés</a>
        </li>
  	  <li class="nav-item">
          <a class="nav-link" href="../Regisztracio/regisztracio.html">Regisztráció</a>
        </li>
        </li>
      </ul>
      <form class="form-inline my-2 my-lg-0" id="kereses">
        <input class="form-control mr-sm-2" type="search" placeholder="Étterem kereső" aria-label="Search">
        <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Keresés</button>
      </form>
    </div>
  </nav>

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

  <div id="jatekosok">
  </div>

  <div id="adatok"></div>


</body>
</html>
