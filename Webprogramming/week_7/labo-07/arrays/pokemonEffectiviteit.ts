export {}
const pokemonTypes: string[] = [
  "normal",
  "fighting",
  "flying",
  "poison",
  "ground",
  "rock",
  "bug",
  "ghost",
  "steel",
  "fire",
  "water",
  "grass",
  "electric",
  "psychic",
  "ice",
  "dragon",
  "dark",
  "fairy",
];
const effectivityMatrix: number[][] = [
  //   nor fig fly poi grd rok bug gho ste fir wat gra ele psy ice dra dar fai
  [
    1.0, 1.0, 1.0, 1.0, 1.0, 0.5, 1.0, 0.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
    1.0, 1.0, 1.0,
  ], // normal
  [
    2.0, 1.0, 0.5, 0.5, 1.0, 2.0, 0.5, 0.0, 2.0, 1.0, 1.0, 1.0, 1.0, 0.5, 2.0,
    1.0, 2.0, 0.5,
  ], // fighting
  [
    1.0, 2.0, 1.0, 1.0, 1.0, 0.5, 2.0, 1.0, 0.5, 1.0, 1.0, 2.0, 0.5, 1.0, 1.0,
    1.0, 1.0, 1.0,
  ], // flying
  [
    1.0, 1.0, 1.0, 0.5, 0.5, 0.5, 1.0, 0.5, 0.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0,
    1.0, 1.0, 2.0,
  ], // poison
  [
    1.0, 1.0, 0.0, 2.0, 1.0, 2.0, 0.5, 1.0, 2.0, 2.0, 1.0, 0.5, 2.0, 1.0, 1.0,
    1.0, 1.0, 1.0,
  ], // ground
  [
    1.0, 0.5, 2.0, 1.0, 0.5, 1.0, 2.0, 1.0, 0.5, 2.0, 1.0, 1.0, 1.0, 1.0, 2.0,
    1.0, 1.0, 1.0,
  ], // rock
  [
    1.0, 0.5, 0.5, 0.5, 1.0, 1.0, 1.0, 0.5, 0.5, 0.5, 1.0, 2.0, 1.0, 2.0, 1.0,
    1.0, 2.0, 0.5,
  ], // bug
  [
    0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0,
    1.0, 0.5, 1.0,
  ], // ghost
  [
    1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 0.5, 0.5, 0.5, 1.0, 0.5, 1.0, 2.0,
    1.0, 1.0, 2.0,
  ], // steel
  [
    1.0, 1.0, 1.0, 1.0, 1.0, 0.5, 2.0, 1.0, 2.0, 0.5, 0.5, 2.0, 1.0, 1.0, 2.0,
    0.5, 1.0, 1.0,
  ], // fire
  [
    1.0, 1.0, 1.0, 1.0, 2.0, 2.0, 1.0, 1.0, 1.0, 2.0, 0.5, 0.5, 1.0, 1.0, 1.0,
    0.5, 1.0, 1.0,
  ], // water
  [
    1.0, 1.0, 0.5, 0.5, 2.0, 2.0, 0.5, 1.0, 0.5, 0.5, 2.0, 0.5, 1.0, 1.0, 1.0,
    0.5, 1.0, 1.0,
  ], // grass
  [
    1.0, 1.0, 2.0, 1.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 0.5, 0.5, 1.0, 1.0,
    0.5, 1.0, 1.0,
  ], // electric
  [
    1.0, 2.0, 1.0, 2.0, 1.0, 1.0, 1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 0.5, 1.0,
    1.0, 0.0, 1.0,
  ], // psychic
  [
    1.0, 1.0, 2.0, 1.0, 2.0, 1.0, 1.0, 1.0, 0.5, 0.5, 0.5, 2.0, 1.0, 1.0, 0.5,
    2.0, 1.0, 1.0,
  ], // ice
  [
    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
    2.0, 1.0, 0.0,
  ], // dragon
  [
    1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2.0, 1.0,
    1.0, 0.5, 0.5,
  ], // dark
  [
    1.0, 2.0, 1.0, 0.5, 1.0, 1.0, 1.0, 1.0, 0.5, 0.5, 1.0, 1.0, 1.0, 1.0, 1.0,
    2.0, 2.0, 1.0,
  ], // fairy
];
const inputEffectiviteit = require("readline-sync");
let aanvalsType : string = inputEffectiviteit.question("Attacker type: ");
let aanvalID : number = pokemonTypes.indexOf(aanvalsType);
let defenderType : string = inputEffectiviteit.question("Defender type: ");
let defenderID : number = pokemonTypes.indexOf(defenderType);
let effectiviteit : number = effectivityMatrix[aanvalID][defenderID];
if(effectiviteit < 1)
{
  console.log("Not very effective...");
}
else if (effectiviteit == 1)
{
  console.log("its ok");
}
else if (effectiviteit > 1)
{
  console.log("Super effective!!!");
}