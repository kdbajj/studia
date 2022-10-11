//let array = [];
let t = 0;
function inserionSort(array) {
  for (let i = 1; i < array.length; i++) {
    let current = array[i];
    let j = i - 1;
    while (j >= 0 && array[j] > current) {
      array[j + 1] = array[j];
      j--;
      t++;
    }
  }
  console.log(
    `Liczba wykonanych porównań: ${t}, 
  a wartość a wynosi: ${t / Math.pow(array.length, 2)}`
  );

  return array;
}

console.log(inserionSort([4, 5, 62, 7, 6, 5]));
