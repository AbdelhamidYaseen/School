const input = require("readline-sync");
let pokemon: string[] = 
[
    "Bulbasaur",
    "Ivysaur",
    "Venusaur",
    "Charmander",
    "Charmeleon",
    "Charizard",
    "Squirtle",
    "Wartortle",
    "Blastoise",
    "Caterpie",
    "Metapod",
    "Butterfree",
    "Weedle",
    "Kakuna",
    "Beedrill",
    "Pidgey",
    "Pidgeotto",
    "Pidgeot",
    "Rattata",
    "Raticate",
    "Spearow",
]
;
let team : string [] = [];
let i : number = 1; 
for(let unit of pokemon)
{
    console.log(`${i}: ${unit}`);
    i++;
}
let collecting : boolean = true;
do
{
    let selected : string = input.question("Welke pokemon wil je in je team? [0-20]:");
    let selectedID : number = parseInt(selected);
    let selectedName : string = pokemon[selectedID];
    if(selected !== "NONE"){

        if(selectedID<0 || selectedID>20)
        {
            console.log("This is out of bounds");
        }
        else{
            if(team.includes(selectedName))
            {
                console.log("Deze pokemon heb je al in je bezit");
            }
            else
            {
                team.push(selectedName);
            }
        }    
    }
    else{
        collecting = false;
    }
}
while(collecting);
let y : number = 1; 
for(let unit of team)
{
    console.log(`${y}: ${unit}`);
    y++;
}
