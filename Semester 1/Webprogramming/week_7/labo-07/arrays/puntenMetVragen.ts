//const input = require("readline-sync");
//==================================================
let active : boolean = true;
let yourGrades : number[] = []; 
let amount : number = 1;
while(active){
    let answer : string = input.question(`Grade ${amount}: `);
    let answerModified : number = parseInt(answer);
    if(answer === ""){
        active = false;
    }
    else{
        yourGrades.unshift(answerModified);
        amount++;
    }
}
//==================================================
let totalGrades : number = 0;
let totalFails : number = 0;
for (let gradeYourGrades of yourGrades){
    totalGrades += gradeYourGrades;
    if(gradeYourGrades < 10){totalFails++}
}
//==================================================
let gemiddeldeGrades : number = totalGrades/(yourGrades.length); 
let percentageGrades : number = gemiddeldeGrades/20*100;
//==================================================
console.log(`Het gemiddelde is ${gemiddeldeGrades}`);
console.log(`Het aantal fails is ${totalFails}`);
console.log(`Het percentage is ${percentageGrades}%`);




