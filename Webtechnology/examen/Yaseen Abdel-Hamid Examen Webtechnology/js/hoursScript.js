let contactHourArr = [
    "maandag 10-16u",
    "dinsdag gesloten",
    "woensdag 8-12u",
    "donderdag 13-18u",
    "vrijdag 14-20u",
    "zaterdag gesloten",
    "zondag gesloten"
];

function contactHour() {
    let pList = document.getElementById("hourList");
    for (contact of contactHourArr) {
        let listItem = document.createElement("li");
        listItem.textContent = contact;
        pList.appendChild(listItem);
    }
}

window.addEventListener("load", contactHour);