interface Car{
    name:string;
    year: number;
    type:string;
}
/*
interface TestFunction {
 (car: Car): boolean
}
*/
interface CreateFunction {
 (name: string, year: number): Car
}

const createCarFactory = (type: string): CreateFunction => {
    return (name: string, year: number): Car => {
        if (type === "Sport" || type === "Family"  || type === "Luxury") {
            return { name, year, type };
        } else {
            throw new Error("Foutief auto type");
        }
    };
};
const createSport = createCarFactory("Sport");
const createFamily = createCarFactory("Family");
const createLuxury = createCarFactory("Luxury");

interface TestFunction {
    (car: Car): boolean;
}

const isLuxury: TestFunction = (car: Car): boolean => {
    //return car.type === "Luxury";
    if (car.type ==="Luxury"){
        return true;
    }
    else{
        return false;
    }
};

const isOld: TestFunction = (car: Car): boolean => {
    if (car.type === 'Sport' && car.year <= new Date().getFullYear() - 10) {
        return true;
    } else if (car.type === 'Family' && car.year <= new Date().getFullYear() - 7) {
        return true;
    } else if (car.type === 'Luxury' && car.year <= new Date().getFullYear() - 5) {
        return true;
    } else {
        return false;
    }
};


// Comment out the luxury cars if you want the output to be "true false"
const cars: Car[] = [
    createSport("Ferrari", 2012),
    //createLuxury("Rolls Royce", 2018),
    createFamily("Toyota", 2016),
    createSport("Lamborghini", 2016),
    //createLuxury("Bentley", 2015),
    createFamily("Honda", 2013),
    createSport("Porsche", 2017),
    //createLuxury("Mercedes", 2016), 
    createFamily("Mazda", 2012),
    createSport("Audi", 2015),
];
const none = (cars: Car[], testFunc: TestFunction): boolean => {
    for (const car of cars) {
        if (testFunc(car)) {
            return false;
        }
    }
    return true;
};

console.log(none(cars, isLuxury));
console.log(none(cars, isOld));
