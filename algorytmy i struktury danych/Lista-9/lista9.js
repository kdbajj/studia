function transitiveClosure(matrix) {
  // Inicjalizacja macierzy D0
  //  za pomocą funkcji slice kopiujemy macierz
  let D0 = matrix.map((arr) => arr.slice());
  for (let i = 0; i < matrix.length; i++) {
    D0[i][i] = 1;
  }

  // Algorytm Floyda-Warshalla
  for (let k = 0; k < matrix.length; k++) {
    for (let i = 0; i < matrix.length; i++) {
      for (let j = 0; j < matrix.length; j++) {
        D0[i][j] = D0[i][j] || (D0[i][k] && D0[k][j]);
      }
    }
  }
  return D0; // tu zwracamy macierz sąsiedztwa grafu G* (wejściowego)
}

// Przykładowe wykorzystanie funkcji
let matrix = [
  [0, 1, 0, 0],
  [0, 0, 1, 1],
  [0, 0, 0, 1],
  [1, 0, 0, 0],
];
let G_star = transitiveClosure(matrix);
console.log(G_star);
