//oef 1
let h2Tags = document.getElementsByTagName("h2");

for (i = 0; i < h2Tags.length; i++) {
    console.log(h2Tags[i].innerHTML);
}
//oef 2
let aTags = document.getElementsByTagName("a");

for (i = 0; i < aTags.length; i++) {
    console.log(aTags[i].setAttribute("target", "_blank"));
}
//oef 3
let ulTags = document.querySelectorAll("ul:nth-of-type(1) li");
let itemsArray = [];
for(let i = 0; i < ulTags.length; i++){
    itemsArray[i] = ulTags[i].textContent;
}
console.log(itemsArray);
//oef 4
let h1Tags = document.getElementsByTagName("h1")[0];
function changeColor(){
    console.log("clicked <h1>");
    h1Tags.style.color = "red";
}
h1Tags.addEventListener('click', changeColor);
//oef 5
let buttonTags = document.getElementsByTagName("button")[0];
console.log(buttonTags);
const originalText = "Klik mij";
const changedText = "U hebt op mij geklikt";
function changeButton(){
    if(buttonTags.textContent == originalText){
        buttonTags.textContent = changedText;
    }
    else if (buttonTags.textContent == changedText){
        buttonTags.textContent = originalText;
    }
}
buttonTags.addEventListener('click', changeButton);
//oef 6
let pTags = document.querySelectorAll("p");
for(let i = 0; i < pTags.length; i++){
    if(pTags[i].textContent.length > 75){
        pTags[i].textContent = pTags[i].textContent.substring(0,75);
        pTags[i].append("...");
    }
}
//oef 7
document.body.insertAdjacentHTML("beforeend",`<h4>${document.querySelectorAll("li").length}</h4>`);
// oef 8
let words = ["kitchen", "car", "apple", "velcro", "pigeon", "cat", "mango", "pizza", "water"];
let pictures = ""; 
for(let i = 0; i < words.length; i++){
    pictures += `<img src="https://loremflickr.com/320/240/${words[i]}">`;
}
document.body.insertAdjacentHTML("afterbegin",`<section class="grid">${pictures}</section>`);
