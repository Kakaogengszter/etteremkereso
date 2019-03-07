<?php
require_once('../connection.php');
  $sql = "SELECT * FROM etterem";

  $res = $conn -> query($sql);

  if(!$res){
    die("Hiba a lekérdezés során!");
  }

$tabla = "";
while ($row = $res -> fetch_assoc()){
$tabla .= "   <link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.2.0/css/all.css' integrity='sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ' crossorigin='anonymous'>

        <div class='col-md-5 '>
          <div class='row'>
           <div class='card flex-md-row mb-3 shadow-sm h-md-250'>
              <div class='card-body d-flex flex-column align-items-start'>";

$tabla .=                 "<h6 class='mb-0'>
                    <a class='text-dark' href='#'>{$row['Nev']}</a>
                 </h6>
                 <div class='mb-1 text-muted small'>{$row['Tipus']}</div>
                 <p class='card-text mb-auto'>This is a wider card with supporting text below as a natural lead-in to additional content.</p>
                 <a class='btn btn-outline-primary btn-sm' role='button' href ='https://www.google.com/maps/search/{$row['Cim']}'>{$row['Cim']}</a>
              </div>
              <img class='card-img-right flex-auto d-none d-lg-block' alt='Thumbnail [200x250]' src={$row['kep_eleres']} class='img-fluid' alt='Responsive image' >
           </div>
        </div>
      </div>'";



}

/*$tabla.="<tr>"
  ."<td scope='row' >{$row['Nev']} , {$row['Tipus']} , <a href ='https://www.google.com/maps/search/{$row['Cim']}'>{$row['Cim']}</a></td> <td></td>"
  ."</tr>";
  }
$tabla.="</table>";*/


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
  <link rel="stylesheet" href="etterem.css">
    <link rel="stylesheet" href="../reszponziv.css">



    <title>Szegedi Éttermek</title>


  </head>
  <body>
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top" >

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
        <a class="dropdown-item" href="../Ettermek/index.php">Összes étterem</a>
        <div class="dropdown-divider"></div>
        <a class="dropdown-item" href="#">Pontozás</a>
      </div>
  <li class="nav-item">
      <a class="nav-link" href="../Belepes/belepes.php">Belépés</a>
    </li>
  <li class="nav-item">
      <a class="nav-link" href="../Regisztracio/regisztracio.php">Regisztráció</a>
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


<div style="margin-top:100px;" class="d-flex flex-wrap align-items-center container-fluid col-md-10" >
  <?php
  echo $tabla;
   ?>
</div>


  </body>
</html>
