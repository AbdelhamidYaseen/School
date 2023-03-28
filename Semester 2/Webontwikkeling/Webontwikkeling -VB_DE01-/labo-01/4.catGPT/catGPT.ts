const input = require('readline-sync');
const sloth = require('sloth-log');

const repeatWord = (word:string, count: number, delimiter: string) =>{
    let result:string = "";
    let random: number;
    for(let i = 0; i < count-1; i++){
        result += `${word.replace(word, "Meow")}${delimiter}`;
    }
    result += `${word.replace(word, "Meow")}`;
    random = Math.floor(Math.random() * 3)+1;
    if(random === 1){
        result += "?";
    }else if(random === 2){
        result += "!";
    }else{
        result += ".";
    }
    sloth.log(result, { speed: 200, maxWordsAtOnce: 4});
}
let question : string = "";
do{
    question = input.question("> ");
    repeatWord(question, question.length, " ");
}while(question !== "bye")