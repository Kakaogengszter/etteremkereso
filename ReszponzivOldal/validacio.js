$(document).ready(function(){
	
    $("input[name='submit']").click(function(event){

        
        event.preventDefault();
    });
    $("input").focus(function(){
        $(this).addClass("aktiv");
    });
    $("input").blur(function(){
        $(this).removeClass("aktiv");
    });
    $("input[name='user']").blur(function(){
		$("#userError").html("");
        if($(this).val().length < 6){
            $("#userError").text("Legalább 6 karakter hosszúnak kell lennie!");
			
			document.getElementById('submitbtn').disabled='disabled';
		}

    });
	$("input[name='pwd']").blur(function(){
		$("#pwdError").html("");
		let minta = /(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[_%?!$@\.]).{6,}/;
		let joJelszo = false;
		let jelszo = $(this).val();
		joJelszo = minta.test(jelszo);
		if(!joJelszo){
			$("#pwdError").text("Legalább 6 karakter és szám, és speciális karakter!");
		}
	});
	$("input[name='pwdc']").keyup(function(){
		$("#pwdcError").html("");
		let pwd = $("input[name='pwd']").val();
		let pwdc = $(this).val();

		if(pwd !== pwdc){
			$("#pwdcError").text("A két jelszó nem egyezik!");
			document.getElementById('submitbtn').disabled='disabled';
		}else
			document.getElementById('submitbtn').disabled=false;
			
	});

	$("input[name='email']").blur(function(){
		$("#emailError").html("");
		let minta = /(?=.*[a-z])(?=.*[@])(?=.*[\.])/;
		let joEmail = false;
		let email = $(this).val();
		joEmail = minta.test(email);

		if(!joEmail){
			$("#emailError").html("Hibás email");
		}
	});
});
