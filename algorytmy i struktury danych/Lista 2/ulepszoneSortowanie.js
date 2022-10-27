let liczbaPorownan = 0;

function shellSort(array) {
  let n = array.length;

  for (let gap = Math.floor(n / 2); gap > 0; gap = Math.floor(gap / 2)) {
    for (let i = gap; i < n; i++) {
      let temp = array[i];

      let j;
      for (j = i; j >= gap && array[j - gap] > temp; j -= gap) {
        liczbaPorownan++;
        array[j] = array[j - gap];
      }
      array[j] = temp;
    }
  }
  console.log(
    `Liczba wykonanych porównań: ${liczbaPorownan},
    natomiast wartość a wynosi: ${
      liczbaPorownan / Math.pow(array.length, 2)
    } :))`
  );
  return array;
}

console.log(shellSort([8, 2, 4, 1, 3, 5, 6, 4, 3, 4, 5]));

// Złożoność algorytmiczna
// T: O(n^2) - czasowa (time)
// S: O(n) - wielkościowa (space)

// n = array.length
