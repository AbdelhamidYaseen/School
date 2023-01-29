let numbers : number [] = [1,2,3,4,5,6];
let som : number = 0;

for(let i of numbers){
    console.log(i);
    som += i;
}

console.log(`De som is ${som}`);