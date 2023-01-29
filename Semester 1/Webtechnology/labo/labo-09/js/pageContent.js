//data array

let openingHourArr = [
    "Maandag 08-22u",
    "Dinsdag 08-22u",
    "Woensdag 08-22u",
    "Donderdag 08-22u",
    "Vrijdag 08-18u",
    "Zaterdag gesloten",
    "Zondag gesloten"
];


//functies voor algemeen gebruik
function showText(text, id) {
    let element = document.getElementById(id);
    element.textContent = text;
}


// welkomsbericht na inloggen
function addPersonalMessage(e) { //Een functie die een persoonlijk bericht toont aan de hand van de info ingevuld in een form;
    e.preventDefault(); //Zorg dat de action van de form niet wordt uitgevoerd.
    let loginFormData = new FormData(e.target); //Haal de data uit de form die je uit het event haalt
    let name = loginFormData.get("userName"); //Haal de value op van het element met name="userName"
    let personalMessage = "Dag " + name + ", welkom bij labo 9."; //Stel bericht op
    showText(personalMessage, "welcomeMessage"); //Toon op scherm
}

document.getElementById("loginForm").addEventListener("submit", addPersonalMessage); //Voeg addPersonalMessage() toe als listener op het submit event


// openingsuren tonen
function showOpeningHours(e) { //Een functie om de openingsuren te tonen
    let openingHoursList = document.getElementById("openingHoursList"); //Haal de lijst op
    for (let entry of openingHourArr) { //Voor alle elementen in onze array
        let listElement = document.createElement("li"); //Maak een nieuw li element aan
        listElement.textContent = entry; //Verander de tekst naar hetgeen in onze array staat
        openingHoursList.appendChild(listElement); //Voeg het li element toe aan de lijst
    }
}

window.addEventListener("load", showOpeningHours); //Voeg showOpeningsHours toe als een listener op het load event. 