const namePi = ["pizza", "pizza", "job", "kor"];

const newName = [...new Set(namePi)];
const newArray = [...namePi];
namePi.push(1);

console.log(newName);
console.log(namePi);
console.log(newArray);


