interface Calculation {(a:number, b:number):number}
const printCalculationResult = (a:number,b:number, calculation : Calculation) => {
    console.log(calculation(a,b));
}
const add : Calculation = (a,b) => {
    return a+b ;
}
const mult : Calculation = (a,b) => {
    return a*b ;
}
printCalculationResult(2,4,add); //print 6
printCalculationResult(2,4,mult); // print 8