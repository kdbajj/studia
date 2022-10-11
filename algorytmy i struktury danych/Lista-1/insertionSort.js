let t = 0;
function sortowanie(array) {
  for (let i = 1; i < array.length; i++) {
    let current = array[i];
    let j = i - 1;
    while (j >= 0 && array[j] > current) {
      array[j + 1] = array[j];
      j--;
      t++;
    }
    array[j + 1] = current;
  }
  console.log(
    `Liczba wykonanych porównań: ${t},
  natomiast wartość a wynosi: ${t / Math.pow(array.length, 2)} :))`
  );
  return array;
}

console.log(sortowanie([5, 4, 3, 2, 1]));
