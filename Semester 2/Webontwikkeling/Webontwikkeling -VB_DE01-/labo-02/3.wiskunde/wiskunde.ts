import Mexp from "math-expression-evaluator";

const input = require("readline-sync");
const mat : any = new Mexp;

let mQuestion = input.question("Geef een berekening die je wilt uitvoeren? ");

const mCalculation = (input : string) : number => {
    return mat.eval(input);
}

console.log(mCalculation(mQuestion));

export{}