let map = L.map('leafletMap').setView( [51.22998, 4.41438], 17);
L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);
let bounds = [[51.23041, 4.4155], [51.22991, 4.41675]];
var popup = L.popup()
    .setLatLng([51.23016, 4.41438])
    .setContent("AP-Hogeschool Noorderplaats 2.")
    .openOn(map);
    


