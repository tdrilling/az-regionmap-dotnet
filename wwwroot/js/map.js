document.addEventListener("DOMContentLoaded", function () {
    var map = L.map('map').setView([20, 0], 2);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '© OpenStreetMap contributors'
    }).addTo(map);

    fetch('/api/regions')
        .then(response => response.json())
        .then(data => {
            data.forEach(region => {
                var marker = L.marker([region.latitude, region.longitude]).addTo(map);
                marker.bindPopup(`<b>${region.name}</b><br>${region.location}<br>AZ: ${region.availabilityZones}`);
            });
        });
});