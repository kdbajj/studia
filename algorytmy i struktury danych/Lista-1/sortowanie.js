let liczbaPorownan = 0;

function sortowanie(array) {
  for (let i = 1; i < array.length; i++) {
    // O(n)
    let current = array[i]; // O(1)
    let j = i - 1; // O(1)
    while (j >= 0 && array[j] > current) {
      // O(n)

      array[j + 1] = array[j]; // O(1) // wstawienie zmiennej do miejsca w tablicy gdy jest większa od current
      j--; // O(1)
      liczbaPorownan++; // O(1)
    }
    array[j + 1] = current; // O(1)
  }
  console.log(
    `Liczba wykonanych porównań: ${liczbaPorownan},
  natomiast wartość a wynosi: ${liczbaPorownan / Math.pow(array.length, 2)} :))`
  );
  return array;
}
console.log(sortowanie([8, 2, 4, 1, 3, 5, 6, 4, 3, 4, 5]));

// Złożoność algorytmiczna
// T: O(n^2) - czasowa (time)
// S: O(n) - wielkościowa (space)

// n = array.length

//1.(2,8,4,1,3)
//2.(8,8,4,1,3)
//3.
