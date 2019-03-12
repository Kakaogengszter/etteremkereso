


  <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top" >

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
        <a class="dropdown-item" href="../Ettermek/etterem.php">Összes étterem</a>
        <div class="dropdown-divider"></div>
        <a class="dropdown-item" href="#">Pontozás</a>
      </div>

  </ul>
<ul class="navbar-nav ml-auto">
  <?php

  if(isset($_SESSION['uid'])){
        echo '<li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
          Beállítások
        </a>
        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
          <a class="dropdown-item" href="../profilszerkesztes/profil_modositasa.php">Profil módosítása</a>
          <a class="dropdown-item" href="#">funkció2</a>
          <div class="dropdown-divider"></div>
          <a class="dropdown-item" href="#">Hibabejelentés</a>
        </div>
      </li>
        <li class="nav-item" id="reg">
        <a class="nav-link" href="../php/kilep.php"> Kilépés </a>
        </li>';
      }
      else {
        echo '<li class="nav-item" id="reg">
        <a class="nav-link" href="../Belepes/belepes.php"> Bejelentkezés/Regisztráció </a>
        </li>';
      }


   ?>
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
