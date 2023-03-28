/*
VLOEKKADERTJE
    Soms haat ik mezelf echt want er lukken dingen hierin dat ik geen weet van heb en andere werken terwijl het basis leerstof is
*/
//imports
//import pc from "picocolors"
//interfaces
interface Animal{
    name: string;
    age: number;
    type: string;
}
interface CreateFunction {
 (name: string, age: number): Animal
}
interface TestFunction {
 (animal: Animal): boolean
}
//animal factory
const createAnimalFactory = (type: string) : CreateFunction => {
    return (name,age) =>{
        if(type === 'cat' || type === 'dog' || type === 'hamster'){
            return{name, age, type};
        }
        else{
            throw{
                Error
            }
        }
    }
}
//creation functions
let createDog : CreateFunction = createAnimalFactory("dog");
let createCat : CreateFunction = createAnimalFactory("cat");
let createHamster : CreateFunction = createAnimalFactory("hamster");

//let createCat : CreateFunction = (name:string,age:number) => createAnimalFactory("cat");
//let createHamster = (name:string,age:number) => createAnimalFactory("hamster"); AAAAAAAAAAAAAAAAAHHHH IK ZIT HIET TE LANG VAST

//checking values
const isRodent : TestFunction= (animal) => {
    if(animal.type === "hamster"){
        return true;
    }
    else{
        return false;
    }
}

const isOld : TestFunction = (animal) => {
    if(animal.type === "cat" && animal.age >= 14){
       return true 
    }
    else if(animal.type === "dog" && animal.age >= 12){
       return true 
    }
    else if (animal.type === "hamster" && animal.age >= 2){
       return true 
    }
    else{
        return false;
    }
}
// array & outprint result
let animals : Animal[] =[
    
    createDog("dog1",1),
    createDog("dog2",12),
    createDog("dog3",13),
    createDog("dog4",14),
    
    createCat("cat1",1),
    createCat("cat2",2),
    createCat("cat3",3),

    createHamster("hamster1",1),
    createHamster("hamster2",10),
    createHamster("hamster3",19)

];
//ROADBLOCK NMBR 2
let animalcheck =animals.forEach(element => {
    
});

const contains =(animals: Animal[],func : TestFunction) : Boolean=>{
    for (let index = 0; index < animals.length; index++) {
        const element = animals[index];
        return func(element)
    }
    return true;
}

console.log(contains(animals, isRodent));
console.log(contains(animals, isOld));
/*
// color functions pico [WAAROM WERK DIT WEL MAAR DE BOOLEAN CHECK NIET!!!!!!!!!]
const showAnimals = (animalsInput:Animal[]) =>{
    animalsInput.forEach(element => {
        if(isOld(element)){
            console.log(pc.red(element.name));
        }
        else{
            console.log(pc.green(element.name));
        }   
    });
}
showAnimals(animals);

*/
// export
export{}