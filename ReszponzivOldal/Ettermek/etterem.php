<?php
require_once('../connect.php');
if(isset($_GET['Id'])){
  $mez = $_GET['Id'];
  $sql = "SELECT * FROM etterem";

  $res = $connect -> query($sql);

  if(!$res){
    die("Hiba a lekérdezés során!");
  }
  $row = $res -> fetch_assoc();

  $html = "<h3>Név: {$row['Nev']}</h3>"
  ."<ul>"
  ."<li>Mez: {$row['Tipus']}</li>"
  ."<li>Magasság: {$row['Cim']}</li>"
  ."</ul><br>"
  ."<h3>Éttermek</h3>";

$tabla = "<table>"
."<th>Név</th><th>Típus</th><th>Cím</th>";
while ($row = $res -> fetch_assoc()){
$tabla.="<tr>"
."<td>{$row['Nev']}</td><td>{$row['Tipus']}</td><td>{$row['Cim']}</td>"
."</tr>";
}
$tabla.="</table>";

echo $html;
echo $tabla;
$connect -> close();
}
