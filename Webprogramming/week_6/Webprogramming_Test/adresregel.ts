const input = require("readline-sync");
console.log("====================================================================");
let voornaam : string = input.question("Voornaam?\n");
let voornaamLength : number = voornaam.length;
let familienaam : string = input.question("Familienaam?\n");
let familienaamLength : number = familienaam.length;
let adress : string = input.question("Straat en huisnummer?\n");
let adressLength : number = adress.length;
let postcode : number = input.question("Postcode?\n");
let postString : string = postcode.toString() ;
let postcodeLength : number = postString.length; 
let gemeente : string = input.question("Gemeente?\n");
let gemeenteLength : number = gemeente.length;

let maxlength : number = 0;
let dash : string = "-";
let empty : string = " ";

if ( voornaamLength > familienaamLength && voornaamLength > adressLength && voornaamLength > postcodeLength && voornaamLength > gemeenteLength){let maxlength : number = voornaamLength}
else if ( familienaamLength > voornaamLength && familienaamLength > adressLength && familienaamLength > postcodeLength && familienaamLength > gemeenteLength){let maxlength : number =familienaamLength}
else if ( adressLength > familienaamLength && adressLength > voornaamLength && voornaamLength > adressLength && voornaamLength > gemeenteLength){let maxlength : number = adressLength}
else if ( postcodeLength > familienaamLength && postcodeLength > adressLength && postcodeLength > voornaamLength && voornaamLength > gemeenteLength){let maxlength : number = postcodeLength}
else if ( gemeenteLength > familienaamLength && gemeenteLength > adressLength && gemeenteLength > postcodeLength && gemeenteLength > voornaamLength){let maxlength : number = gemeenteLength}

console.log("====================================================================");
if(postcode == null || postcode > 9900 || postcode < 1000){
    console.log("Minstens 1 van de ingevulde velden is niet geldig!");
}
else if(maxlength > 40){
    console.log("Kader is te breed. Gebruik afkortingen in de breedste stukken")
}
else{
console.log(`${dash.repeat(maxlength+2)}`)
console.log(`
|
${voornaam.substring(0,1).concat(".")}
${familienaam}
${empty.repeat(maxlength-(voornaam.substring(0,1).concat(".").length + familienaam.length))}|\n
|
${adress}
${empty.repeat(maxlength-adress.length)}|\n
|
${postcode} 
${gemeente.toUpperCase()}
${empty.repeat(maxlength-(gemeente.length+postString.length+1))}|`);
console.log(`${dash.repeat(maxlength+2)}`)
}
console.log("====================================================================");