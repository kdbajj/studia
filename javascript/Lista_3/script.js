"use strict";

const btnClick = document.getElementById("btn-1");

const sprawdz = function () {
  let inputVal = document.getElementById("pole").value;
  let sendInput;

  if (isNaN) sendInput = "To nie jest liczba";
  if (inputVal > 0) sendInput = "Dodatnia";
  if (inputVal == 0) sendInput = "Zero";
  if (inputVal < 0) sendInput = "Ujemna";

  document.getElementById("wynik").innerHTML = sendInput;
};

btnClick.addEventListener("click", sprawdz);
