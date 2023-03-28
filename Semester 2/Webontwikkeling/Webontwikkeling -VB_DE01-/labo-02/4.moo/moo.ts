const cowsay = require("cowsay");
const input = require("readline-sync");

interface iCowsayThingy {
    (str: string): void,
}


const say : iCowsayThingy = (str) =>{
    console.log(cowsay.say({
        text : str,
        e : "\\",
        T : "U "
    }));
    

}

while(true){
    let inp: string = input.question("What should the cow say? ");
    if(inp.length === 0){
        console.log("text field is mandatory.");
    }else{
        say(inp);
        break;
    }
}