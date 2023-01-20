export{}
let currentHour = 18;
let changeHour = 33;
let endHour = (currentHour + changeHour%24)%24;

console.log("Het is nu "+ currentHour + ". Over " + changeHour + " uur zal is het " + endHour);