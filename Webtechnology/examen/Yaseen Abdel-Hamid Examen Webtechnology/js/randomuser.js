/**
 * Haal 6 pseudo-gebruikers op met behulp van de fetch-methode.
 * Gebruik hiervoor de https://randomuser.me/ API.
 * Geef voor elke user zijn/haar profiel foto (large), volledige naam, geslacht, leeftijd, land en stad weer.
 */

fetch('https://randomuser.me/api/?results=12')
.then(function (response) {
    if (response.ok) {
        return response.json();
    } else {
        return Promise.reject(response.status);
}
})
.then(function (response) {
    let html = "<section class='clients'>";
    
    for (let i = 0; i < 6; i++) {
        const user = response.results[i];
        html += `<article>
                <p class='h2'>${user.name.first}</p>
                <img src="${user.picture.large}"/>
                <p> - ${user.dob.age}<br>
                ${user.location.city}<br>
                ${user.location.country}</p>
                </article>`;
    }
    
    html += '</section>';
    document.querySelector("main").insertAdjacentHTML('beforeend', html);
})
.catch(function (error) {
    console.error('Error with message: ' + error);
});