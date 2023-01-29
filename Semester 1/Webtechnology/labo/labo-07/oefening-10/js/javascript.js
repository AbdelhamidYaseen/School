let pricePerLetter = 5;
let inputName = "Joske";
let total = inputName.length * pricePerLetter;
let costEll = document.getElementById("price");
let nameEll = document.getElementById("name");
nameEll.textContent = inputName;
costEll.textContent = total;
