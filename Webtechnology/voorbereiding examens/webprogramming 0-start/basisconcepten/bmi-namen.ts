export{}

let heightA : number = 1.6
let weightA : number = 120
let BMIA : number = weightA/(heightA*heightA)

let heightJ : number = 2.5
let weightJ : number = 100
let BMIJ : number = weightJ/(heightJ*heightJ)

console.log(`BMI: ${Math.round(BMIA)}`)
console.log(`BMI: ${Math.round(BMIJ)}`)