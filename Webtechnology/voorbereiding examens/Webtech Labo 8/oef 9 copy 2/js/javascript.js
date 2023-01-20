let input = prompt("wat soort bewerking wil je maken? (+,-,*,/)");
let firstNumber = parseInt(prompt("eerste nummer: "));
let secondNumber = parseInt(prompt("second number: "));
let result;
if(input == "*"){
    result = firstNumber * secondNumber;
}
else if(input == "/"){
    result = firstNumber / secondNumber;
}
else if(input == "-"){
    result = firstNumber - secondNumber;
}
else if(input == "+"){
    result = firstNumber + secondNumber;
}
else{
    result = "fuck you, you fkin cunt";
}

let tilte = document.getElementById("title");
tilte.innerHTML = result;
