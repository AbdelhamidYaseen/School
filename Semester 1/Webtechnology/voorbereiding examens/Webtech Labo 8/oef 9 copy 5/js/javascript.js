let input = parseInt(prompt("geef een getal voor een faculteit!"));
let total = 1;
for(let i=1;i<=input;i++){
    total = total*i;
}
document.getElementById("title").innerHTML = total;