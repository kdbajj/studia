var N = 20; // Liczebność zbioru.
var d = new Array(N);

// Procedura sortowania szybkiego

function Sortuj_szybko(lewy, prawy) {
  var i, j, piwot, x;

  i = Math.floor((lewy + prawy) / 2);
  piwot = d[i];
  d[i] = d[prawy];
  for (j = i = lewy; i < prawy; i++)
    if (d[i] < piwot) {
      x = d[i];
      d[i] = d[j];
      d[j] = x;
      j++;
    }
  d[prawy] = d[j];
  d[j] = piwot;
  if (lewy < j - 1) Sortuj_szybko(lewy, j - 1);
  if (j + 1 < prawy) Sortuj_szybko(j + 1, prawy);
}

// Program główny
//---------------

function main() {
  var i, t;

  // Najpierw wypełniamy tablicę d[] liczbami pseudolosowymi
  // a następnie wyświetlamy jej zawartość

  for (i = 0; i < N; i++) d[i] = Math.floor(Math.random() * 100);

  for (i = 0; i < N; i++) t += d[i] + " ";

  // Sortujemy

  Sortuj_szybko(0, N - 1);

  // Wyświetlamy wynik sortowania

  for (i = 0; i < N; i++) t += d[i] + " ";
  document.getElementById("t_out").innerHTML = t;
}
