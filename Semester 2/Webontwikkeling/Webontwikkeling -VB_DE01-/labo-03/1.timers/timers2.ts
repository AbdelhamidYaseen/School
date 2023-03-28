/*
Verwachte input met een interval van 1 seconde
1
2
3
4
5
...
*/
let second : number = 0;
const timer = () =>{
    second++;
    console.log(second);
} 


console.log(setInterval(timer,1000));