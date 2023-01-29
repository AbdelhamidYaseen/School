export{}

let periode : number = 7
let startBezit : number = 100
let rente : number = 2
let renteVerhoging : number = (startBezit/100) + (2/100)
let eindBezit : number = startBezit*renteVerhoging**periode

console.log(`OP een periode van ${periode} jaar stijgt je bezit van ${startBezit} naar ${eindBezit} bij een rentevoet van ${rente}`)












