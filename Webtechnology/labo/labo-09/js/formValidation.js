/*
 * In dit JS-bestand plaats je de code om met behulp van cleave.js formvalidatie toe te passen op het ticketForm.
 * Gebruik hiervoor de documentatie op https://nosir.github.io/cleave.js/ 
 */

/* 
 * Om cleave te gebruiken moet je per type inputveld een cleave instantie aanmaken.
 * Dit is een bijna exacte kopie van wat er op https://nosir.github.io/cleave.js/ staat.
 * Let op: verander hierbij "var" naar "let".
 */
let date = new Cleave('.dateField', {
    date: true,
    delimiter: '/',
    datePattern: ['d', 'm', 'Y']
});
let phoneNr = new Cleave('.phoneNrField', {
    phone: true,
    phoneRegionCode:'{BE}'
});
let creditCard = new Cleave('.creditCardField', {
    creditCard: true,
    onCreditCardTypeChanged: function (type) {
        // update UI ...
    }
});
// zorg dat de datum wordt aangepast zodat naar dag, maand en jaar
