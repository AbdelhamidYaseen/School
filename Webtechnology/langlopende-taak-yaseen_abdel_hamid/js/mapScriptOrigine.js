let map = L.map('leafletMap').setView( [52.940876, -1.173899], 17);
L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);
var popup = L.popup()
    .setLatLng([52.94078, -1.174])
    .setContent("Games Workshop HQ")
    .openOn(map);
    


