//#region ---HOME---
const imageHome1 = document.getElementById('first-image');
const textHome1 = document.getElementById('self-introduction');
function handleRadioClick(){
    if (document.getElementById('first-radio').checked){
        imageHome1.style.display = "block";
        textHome1.style.display = "block";
    }   
    else{
        imageHome1.style.display = "none"
        textHome1.style.display = "none";
    }
}
const imageHome2 = document.getElementById('second-image');
const textHome2 = document.getElementById('hobby-introduction');
function handleRadioClick2(){
    if (document.getElementById('second-radio').checked){
        imageHome2.style.display = "block";
        textHome2.style.display = "block";
    }   
    else{
        imageHome2.style.display = "none"
        textHome2.style.display = "none";
    }
}
const imageHome3 = document.getElementById('third-image');
const textHome3 = document.getElementById('end-introduction');
function handleRadioClick3(){
    if (document.getElementById('third-radio').checked){
        imageHome3.style.display = "block";
        textHome3.style.display = "block";
    }   
    else{
        imageHome3.style.display = "none"
        textHome3.style.display = "none";
    }
}
const radioButtonsHome = document.querySelectorAll('input[name="transport"]');
radioButtonsHome.forEach(radio => {
    radio.addEventListener('click', handleRadioClick);
})
radioButtonsHome.forEach(radio => {
    radio.addEventListener('click', handleRadioClick2);
})
radioButtonsHome.forEach(radio => {
    radio.addEventListener('click', handleRadioClick3);
})
//#endregion
