export{}
const input = require("readline-sync");

let nmbrFirst : number = parseInt(input.question("Geef je eerste getal in:\n"));
let nmbrSecond : number = parseInt(input.question("Geef je tweede getal in:\n"));
let methode : string = input.question("Welke berekening wil je maken? (+,-,*,/)");

if(methode !== "+"  && methode !== "*" && methode !== "/" && methode !== "-"){
    console.log("GEBRUIK IETS CORRECT JIJ INCAPABLE PERSOON");
}
else if(methode == "+"){
    console.log(nmbrFirst+nmbrSecond);
}
else if (methode == "-"){
    console.log(nmbrFirst-nmbrSecond);
}
else if (methode == "*"){
    console.log(nmbrFirst*nmbrSecond);
}
else if (methode == "/"){
    if(nmbrSecond === 0){
        console.log("DELEN DOOR 0 KAN NIET MISLUKKING");
    }
    else{
        console.log(nmbrFirst/nmbrSecond);
    }
}
export{}