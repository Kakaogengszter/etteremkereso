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


  <link rel="stylesheet" href="etterem.css">

<div style="margin-top:100px;" class="d-flex flex-wrap align-items-center container-fluid col-md-10" >
  <?php
  echo $tabla;
   ?>
</div>


  </body>
</html>
