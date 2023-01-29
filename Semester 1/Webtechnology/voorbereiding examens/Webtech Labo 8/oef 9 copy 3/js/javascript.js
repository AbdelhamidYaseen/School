let input; 

let numberGuess = 8;

if(input < 1 || input > 10){
    console.log("fucking cunt");
}

while(input != numberGuess){
    input = prompt("raad een getal tussen 1 & 10");
}

document.getElementById("title").innerHTML = "juist";