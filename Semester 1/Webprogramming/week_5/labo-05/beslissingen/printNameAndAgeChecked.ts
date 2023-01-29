export{}
const input = require("readline-sync");

let voornaam : string = input.question("Wat is uw voornaam? ");
let achternaam : string = input.question("Wat is uw achternaam? ");
let leeftijd : number = parseInt(input.question("Wat is uw leeftijd? "));

if(voornaam !== "" && achternaam !== "" && leeftijd < 18 && leeftijd > 60){
    console.log(`U bent ${voornaam.charAt(0).toUpperCase() + voornaam.slice(1)} ${achternaam.charAt(0).toUpperCase() + achternaam.slice(1)} en u ben ${leeftijd} jaar oud`);
}
else if(voornaam == ""){
    console.log("Vul zowel je voornaam als achternaam in");
}
else if (achternaam == ""){
    console.log("Vul zowel je voornaam als achternaam in");
}
else if (leeftijd < 18 || leeftijd > 60 ){
    console.log("Vul je leeftijd correct in");
}
export{}

