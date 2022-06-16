<!DOCTYPE html>
<head>
    <link rel="icon" type="image/png" href="img/ksiazka.png">
    <meta charset="UTF-8">
    <title>Przegląd produktów na sprzedaż</title>
    <style>
    td{
        border: solid #000 1px;
        padding: 6px;
    }
    </style>    
    <h1><center>Produkty</center></h1>
</head>
<body>
<body bgcolor="Lavender">

    <?php

   
   $conn = new mysqli ("localhost", "root", "", "ogloszenia") or die("Błąd") ;

    $wynik = $conn->query("SELECT * FROM ogloszenie");


    if($wynik->num_rows > 0) {

    echo "<table>";
    echo "<tr>";

    echo "<th>id</th>";
    echo "<th>tytul</th>";
    echo "<th>tresc</th>";

    echo "</tr>";  

    while($wiersz = $wynik->fetch_assoc()  ) {
    echo "<tr>";

    echo "<td>". $wiersz["id"]    . "</td>";
    echo "<td>". $wiersz["tytul"] . "</td>";
    echo "<td>". $wiersz["tresc"] . "</td>";
    
    echo"</tr>";
    }

    echo "</table>";

    } else{
        echo "W bazie danych nic nie ma";
    }
    /*echo "<pre>";

    print_r ($wynik);

    echo "</pre>";

    $conn->close() ; */
    

    ?>
    <img src="img\ksiazka.jpg" alt="" width="500" height="350"> <img src="img\cd.jpg" alt="" width="500" height="350">
</body>
</html>