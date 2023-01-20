let demoData = [
    {
      "_id": "5dd21529cdf562a55f3a2122",
      "age": 27,
      "name": "Bird Davis",
      "gender": "male",
      "email": "birddavis@unia.com"
    },
    {
      "_id": "5dd2152949b47064b022e0b2",
      "age": 22,
      "name": "Rosemarie Fields",
      "gender": "female",
      "email": "rosemariefields@unia.com"
    },
    {
      "_id": "5dd2152930a6072a55126d4a",
      "age": 20,
      "name": "Mcgowan Hill",
      "gender": "male",
      "email": "mcgowanhill@unia.com"
    },
    {
      "_id": "5dd215291a9f7b57b5fb6542",
      "age": 21,
      "name": "Marks Parsons",
      "gender": "male",
      "email": "marksparsons@unia.com"
    },
    {
      "_id": "5dd2152977a8756cdea19e51",
      "age": 34,
      "name": "Alexis Britt",
      "gender": "female",
      "email": "alexisbritt@unia.com"
    },
    {
      "_id": "5dd215298100cfa91527522b",
      "age": 36,
      "name": "Aisha Potter",
      "gender": "female",
      "email": "aishapotter@unia.com"
    },
    {
      "_id": "5dd215295a3b0276bd921acc",
      "age": 28,
      "name": "Socorro Atkins",
      "gender": "female",
      "email": "socorroatkins@unia.com"
    },
    {
      "_id": "5dd215298e7ecedae6358f7e",
      "age": 40,
      "name": "Connie Mcmahon",
      "gender": "female",
      "email": "conniemcmahon@unia.com"
    },
    {
      "_id": "5dd21529e8dcda1845babbd6",
      "age": 40,
      "name": "Nadine Stein",
      "gender": "female",
      "email": "nadinestein@unia.com"
    },
    {
      "_id": "5dd21529f657969b374f4673",
      "age": 34,
      "name": "Dollie Patterson",
      "gender": "female",
      "email": "dolliepatterson@unia.com"
    },
    {
      "_id": "5dd215296218d570686e8b6e",
      "age": 31,
      "name": "Helga Rodriquez",
      "gender": "female",
      "email": "helgarodriquez@unia.com"
    },
    {
      "_id": "5dd2152929fa54134dfd01b6",
      "age": 21,
      "name": "Hardin Snider",
      "gender": "male",
      "email": "hardinsnider@unia.com"
    },
    {
      "_id": "5dd21529bc1bb5a0f6a3a5de",
      "age": 33,
      "name": "Foster Bird",
      "gender": "male",
      "email": "fosterbird@unia.com"
    },
    {
      "_id": "5dd215291b27616e6469ed9d",
      "age": 28,
      "name": "Watkins Cash",
      "gender": "male",
      "email": "watkinscash@unia.com"
    },
    {
      "_id": "5dd215295aaccc9f5f63cfb9",
      "age": 27,
      "name": "Jocelyn Blackburn",
      "gender": "female",
      "email": "jocelynblackburn@unia.com"
    },
    {
      "_id": "5dd215293e082a4f5765540b",
      "age": 34,
      "name": "Denise Wilkinson",
      "gender": "female",
      "email": "denisewilkinson@unia.com"
    },
    {
      "_id": "5dd215292f7859bd8c8238f7",
      "age": 35,
      "name": "Roxie Conway",
      "gender": "female",
      "email": "roxieconway@unia.com"
    },
    {
      "_id": "5dd215296324b2bd42823112",
      "age": 35,
      "name": "Finley Mcgee",
      "gender": "male",
      "email": "finleymcgee@unia.com"
    }
  ];
let totalAge = 0;
let women = 0;
let men = 0;
let over30 = 0;
for(let users of demoData){
    console.log(`${users.name}\n${users.age}`);
    totalAge += users.age;
    if(users.gender == "female"){
        women++;
    }
    else{
        men++;
    }
    if(users.age > 30){
        over30++
    }
}
document.getElementById("title").innerHTML = `${totalAge} ${women} ${men} ${over30}`;



for(let i = 1; i <= 100; i++){
    if(i % 3 == 0 && i % 5 == 0){
        console.log("FizzBuzz");
    }
    else if(i % 3 == 0){
        console.log("Fizz");
    }
    else if(i % 5 == 0){
        console.log("Buzz");
    }
    else{
        console.log(i);
    }
}