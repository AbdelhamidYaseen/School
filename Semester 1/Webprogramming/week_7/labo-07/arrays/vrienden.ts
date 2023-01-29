export {}
const input = require("readline-sync");
//===================================================
let vrienden : string [] = [];
let vragen : number = input.question("Hoeveel vrienden wens je in te geven? ");
for(let i : number = 0; i < vragen; i++){
    let vriend : string = input.question(`Geef vriend ${i+1} in: `);
    vrienden.unshift(vriend);
}
for (let y : number = 0; y < vrienden.length; y++){
    console.log(`${vrienden[y]}`);
}