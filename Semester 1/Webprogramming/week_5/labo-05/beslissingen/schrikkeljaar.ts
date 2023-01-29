export{}
const input = require("readline-sync");

let jaar : number = parseInt(input.question("Geef het jaartal in "));

if(jaar/4){
    if(jaar/100){
        if(jaar/400){
            console.log(`${jaar} is een schrikkeljaar`);
        }
        else{
            console.log(`${jaar} is geen schrikkeljaar`);
        }
    }
    else{
        console.log(`${jaar} is een schrikkeljaar`);        
    }
}
else{
    console.log(`${jaar} is geen schrikkeljaar`);
}

export{}