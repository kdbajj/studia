
const btnClick=document.getElementById("btn-1");

const wypisz =function(){
    let number1=Number(document.getElementById("pole1").value);
    let number2=Number(document.getElementById("pole2").value);

    const sendInput=[];
    if(number1>number2){
        [number2,number1]=[number1,number2];
        console.log("test");


    }

    for (let i=number1;i<=number2;i++){
        sendInput.push(i);
    }
    document.getElementById("wynik").innerHTML=sendInput.join(", ")
};
btnClick.addEventListener("click",wypisz);