//#region ---CONTACT---
const section1Contact = document.getElementById('find');
function handleRadioClickContact1(){
    if (document.getElementById('first-contact-radio').checked){
        section1Contact.style.display = "block";
    }   
    else{
        section1Contact.style.display = "none"
    }
}
const section2Contact = document.getElementById('question');
function handleRadioClickContact2(){
    if (document.getElementById('second-contact-radio').checked){
        section2Contact.style.display = "block";
    }   
    else{
        section2Contact.style.display = "none"
    }
}
const section3Contact = document.getElementById('details');
function handleRadioClickContact3(){
    if (document.getElementById('third-contact-radio').checked){
        section3Contact.style.display = "block";
    }   
    else{
        section3Contact.style.display = "none"
    }
}
const radioButtonsContact = document.querySelectorAll('input[name="transport-contact"]');
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