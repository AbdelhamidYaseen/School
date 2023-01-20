let input; 
let amountGuess = 1; 
let numberGuess = 8;

if(input < 1 || input > 10){
    console.log("fucking cunt");
}
input = prompt("raad een getal tussen 1 & 10");

while(input != numberGuess){
    if(input > numberGuess){
            input = prompt("raad een getal tussen 1 & 10 maar het is lager");
            amountGuess++;
    }
    else if (input < numberGuess){
        input = prompt("raad een getal tussen 1 & 10 maar het is hoger");
        amountGuess++;
    }

    if (input == "exit"){
        break;
    }
}

if (input == numberGuess){
    document.getElementById("title").innerHTML = `juist je hebt ${amountGuess} keer moeten raden`;
}

