let liczbaPorownan = 0;

function sortowanie(array) {
  for (let i = 1; i < array.length; i++) {
    
    let current = array[i]; 
    let j = i - 1; 
    while (j >= 0 && array[j] > current) {
      

      array[j + 1] = array[j]; // wstawienie zmiennej do miejsca w tablicy gdy jest większa od current
      j--; 
      liczbaPorownan++;
    }
    array[j + 1] = current;
  }
  console.log(
    `Liczba wykonanych porównań: ${liczbaPorownan},
  natomiast wartość a wynosi: ${liczbaPorownan / Math.pow(array.length, 2)} :)`
  );
  return array;
}
console.log(sortowanie([8, 2, 4, 1, 3]));