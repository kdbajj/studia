<!DOCTYPE html>
<head>
    <link rel="icon" type="image/png" href="img/ksiazka.png">
    <meta charset="UTF-8">
    <title>Formularz z danymi osobistymi</title>
    <h1><center>Formularz-wypełnij danymi :) </center></h1>
   
</head>
<body>
    
<body bgcolor="Lavender"

    <?php
    if(isset($_POST["imie"]) ){
       $imie = $_POST["imie"]; 
       $nazwisko = $_POST["nazwisko"];
       $telefon = $_POST["numer"];
       $email = $_POST["email"];

        if(empty ($imie) || empty ($nazwisko) || empty($telefon) || empty ($email) ) {
            echo "Wypełnij wszystkie pola";

        } else {
            
            $conn = new mysqli ("localhost", "root", "", "ogloszenia");

            $odp = $conn->query("INSERT INTO uzytkownik (imie, nazwisko, telefon, email) VALUES ('$imie', '$nazwisko', '$telefon', '$email')");

            

            if($odp){
                echo "Dodano użytkownika";
            }else{
                echo "Nie udało się dodać użytkownika";
            }
            }

            $conn->close();

        }

    

    ?>
   <form method="POST" action="zap.php">

    Imie: <input name="imie" type="text"><br>
    Nazwisko: <input name="nazwisko" type="text"><br>
    Numer telefonu: <input name="numer" type="number"><br>
    E-mail: <input name="email" type="email"><br>

    <input type="submit" value="Zapisz"><br>
                                                                <img src="img\ludzie2.jpg" alt="" width="350" height="250">

    <img src="img\ludzie.jpg" alt="" width="550" height="250"> 
    
    
</form>

</body>

</html>