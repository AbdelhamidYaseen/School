//#region ---CONTACT---
let section1Contact = document.getElementById('find');
function handleRadioClickContact1(){
    if (document.getElementById('first-contact-radio').checked){
        section1Contact.style.display = "block";
    }   
    else{
        section1Contact.style.display = "none"
    }
}
let section2Contact = document.getElementById('question');
function handleRadioClickContact2(){
    if (document.getElementById('second-contact-radio').checked){
        section2Contact.style.display = "block";
    }   
    else{
        section2Contact.style.display = "none"
    }
}
let section3Contact = document.getElementById('details');
function handleRadioClickContact3(){
    if (document.getElementById('third-contact-radio').checked){
        section3Contact.style.display = "block";
    }   
    else{
        section3Contact.style.display = "none"
    }
}
let radioButtonsContact = document.querySelectorAll('input[name="transport-contact"]');
radioButtonsContact.forEach(radio => {
    radio.addEventListener('click', handleRadioClickContact1);
})
radioButtonsContact.forEach(radio => {
    radio.addEventListener('click', handleRadioClickContact2);
})
radioButtonsContact.forEach(radio => {
    radio.addEventListener('click', handleRadioClickContact3);
})
//#endregion
//#region ---OPTIONS---
const select = document.getElementById('contact-option');
const owner = 
select.addEventListener('change', function handleChange(event) {
    console.log(event.target.value);
    let elementsOwner = document.getElementsByClassName('owner');
    let elementsCreator = document.getElementsByClassName('creator');

    if(select.value =="owner"){
        for( let i = 0; i<elementsOwner.length;i+=1){
            elementsOwner[i].style.display = "block";
            elementsCreator[i].style.display = "none";
        }
    }
    else if(select.value == "creator"){
        for( let i = 0; i<elementsOwner.length;i+=1){
            elementsCreator[i].style.display = "block";
            elementsOwner[i].style.display = "none";

        }
    }
    console.log(select.options[select.selectedIndex].value);
      
     console.log(select.options[select.selectedIndex].text);
});
//#endregion