let input = prompt("Geef je wachtwoord in: ")

if(input != "wireframe"){
    document.getElementById("title").innerHTML = "toegang geweigerd";
}
else{
    document.getElementById("title").innerHTML = "toegang toegestaan";
}
