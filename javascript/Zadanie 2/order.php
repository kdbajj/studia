<!DOCTYPE HTML> <html lang="pl"> <head>
<meta charset="utf-8" />
<title>Podsumowanie zamówienia</title> </head>
<body>
<?php
$kolo = $_POST['kolo']; 
$detka = $_POST['detka']; 
$suma = 100.00 * $kolo + 12.50 * $detka;
echo<<<END