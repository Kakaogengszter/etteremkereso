<?php
session_start();
require'../menu.php';
require_once('../connection.php');
if (!isset($_SESSION['uid'])){
  
    //Nincs belépve
    $menu = file_get_contents('../In-Out/menu_out.html');
}


?>




<?php echo $menu; ?>
  <link rel="stylesheet" href="fooldal.css">
	<header class="w3-container w3-center w3-padding-48 w3-white" style="margin-top:50px">
  <h1 class="w3-xxxlarge" ><b>Finom ételek</b></h1>

    <div class="container6">
      <h1>Üdvözöllek <span class="w3-tag">az éttermek világában</span></h1>
    </div>

  </header>



    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
  </body>
</html>
