<?php
session_start();
require'../menu.php';
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
              ​<picture>

                <img class='img-fluid img-thumbnail card-img-right flex-auto d-none d-lg-block' alt='Thumbnail [200x250]' src={$row['kep_eleres']}  alt='Responsive image' >
</picture>

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
    <script src="../validacio.js" charset="UTF-8"></script>
    <link rel="stylesheet" href="../reszponziv.css">



    <title>Szegedi Éttermek</title>


  </head>
  <body>




  <nav>
      <?php echo $menu; ?>
  </nav>



<div style="margin-top:100px;" class="d-flex flex-wrap align-items-center container-fluid col-md-10" >
  <?php
  echo $tabla;
   ?>
</div>


  </body>
</html>
