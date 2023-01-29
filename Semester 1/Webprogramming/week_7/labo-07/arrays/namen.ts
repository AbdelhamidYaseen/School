
let voorNamen : string [] = ["David","Els","Mo","Bert","Fatima","Gunther"];
let achterNamen : string [] = ["Verhulst", "Vermeiren", "Michiels", "Legrand", "Errazzouki", "Gunther"];

if(voorNamen.length !== achterNamen.length){
    console.log("DE ARRAYS ZIJN NIET DEZELFDE LENGTE ALLARM DE WERELD GAAT EINDIGEN")
}

for(let i:number = 0 ; i < voorNamen.length; i++){
    console.log(`∘ ${voorNamen[i]} ${achterNamen[i]}`);
}