const grades: number[] = [16,12,16,7,17,14,9,8,18,12];
let total : number = 0;
let fails : number = 0;
for(let grade of grades){
    total += grade;
    console.log(grade);
    if(grade < 10){
        fails ++;
        console.log("ADD FAIL");
    }
}
let gemiddelde : number = total/(grades.length);
let percentage : number = gemiddelde/20*100;



console.log(`Het gemiddelde is ${gemiddelde}`);
console.log(`Het aantal fails is ${fails}`);
console.log(`Het percentage is ${percentage}%`);