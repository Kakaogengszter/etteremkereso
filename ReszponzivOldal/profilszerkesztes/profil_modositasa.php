<?php
session_start();
require'../menu.php';
require_once('../connection.php');
$id = $_SESSION['uid'];
$sql = "SELECT * FROM user WHERE uid=$id";


$res = $conn -> query($sql);

if(!$res){
  die("Hiba a lekérdezés során!");
}
$row = $res -> fetch_assoc();
$username = $row["username"];
 ?>

   <link rel="stylesheet" href="profilmodositas.css">
    <script src="../validacio.js" charset="UTF-8"></script>

</form>
<div class="form" align="center">
   <form class="flex-container" method="post" action="update.php">
        <div class="form-group" id="col-75">
            <label id="label" >Új felhasználónév*</label>
            <input type="username" name = "user" class="form-control" id="exampleFormControlInput1" placeholder="<?php echo $username ?>" required><br>
            <span id="userError"></span>
        <br>
        </div>
        <div class="form-group" id="col-75">
            <label id="label">Új jelszó*</label>
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
        <button type="submit" value="Módosítás" name="mod" class="btn btn-dark" id="submitbtn">Módosítás</button>
        </div>
</div>
