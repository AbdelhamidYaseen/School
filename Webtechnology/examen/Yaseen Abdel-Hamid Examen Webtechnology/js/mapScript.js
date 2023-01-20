/* In dit script plaats je de code om de kaart in de id apMap te tekenen, zodat de AP-Hogeschool met adres Ellermanstraat 33 gecentreerd staat.  
Gebruik hiervoor de documentatie op https://leafletjs.com/ 
*/
// Verander het icoon van de marker naar "logo.jpg". Let hierbij op de afmetingen ([40, 40]).

let map = L.map('mapContainer').setView([51.22992, 4.41612], 15);
L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);


let wolIcon = L.icon({
    iconUrl: 'assets/images/logo.jpg',
    iconSize:    [40,40],
    iconAnchor:   [0,40], 
    popupAnchor:  [0,0]
});

let marker = L.marker([51.22992, 4.41612], {icon: wolIcon}).addTo(map);