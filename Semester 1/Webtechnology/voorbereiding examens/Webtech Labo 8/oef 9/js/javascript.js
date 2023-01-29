let score = prompt("Wat is je score: ");

if(score < 50){
    document.getElementById("title").innerHTML = "Je bent niet geslaagd";
}
else if(score > 50){
    document.getElementById("title").innerHTML ="Je bent geslaagd";
}


