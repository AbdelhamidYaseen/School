
//#region oefening-01
let textH2 = document.getElementsByTagName("h2");
for(let i = 0; i<textH2.length; i++ ){
    console.log(textH2[i].textContent);
}
//#endregion
//#region oefening-02
let textA = document.getElementsByTagName("a");
for(let i = 0; i<textA.length; i++){
    textA[i].setAttribute("target","_blank");
}
//#endregion
//#region oefening-03
let textToConvert = document.querySelectorAll("ul:nth-of-type(2) li");
let textArray = [];
for(let i = 0; i < textToConvert.length; i++){
    textArray.push(textToConvert[i].textContent);
}
console.log(textArray);
//#endregion
//#region oefening-04
let textH1 = document.getElementsByTagName("h1");
for(let i = 0; i < textH1.length; i++){
    textH1[i].addEventListener("click", function(){
        textH1[i].style.color = "red";
    });
}
//#endregion
//#region oefening-05)
let buttonClick = document.getElementsByTagName("button")[0];
buttonClick.addEventListener("click",function(){
    if(buttonClick.textContent=="Klik mij"){
        buttonClick.textContent="JE HEBT OP MIJ GEKLIKT";
    }
    else{
        buttonClick.textContent="Klik mij"
    }
})
//#endregion
//#region oefening-06
let pElements = document.getElementsByTagName("p");
for(let i = 0; i < pElements.length; i++){
    pElements[i].textContent = pElements[i].textContent.substring(0,75) + "...";
}
//#endregion
//#region oefening-07
document.body.insertAdjacentHTML
("afterend",
`<h4>${document.querySelectorAll("li").length}</h4>`);
//#endregion
//#region oefening-08
let words = 
[
    "dog","cat","kitchen",
    "cloud","car","tiger",
    "satue","shoe","computer"
];
let pictures = "<section class='grid'>";
for (let i=0; i<words.length; i++){
    pictures+= `<img src='https://loremflickr.com/320/240/${words[i]}'>`
}
document.body.insertAdjacentHTML(
    "afterbegin",pictures
)
//#endregion




