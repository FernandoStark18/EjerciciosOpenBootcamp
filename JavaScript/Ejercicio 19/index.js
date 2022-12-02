let map, markers;

function initMap() {
    const posicion = {
        lat: 22.39869,
        lng: -105.45371,
    };

    map = new google.maps.Map(document.getElementById("map"), {
        zoom: 4,
        center: posicion,
    });
    
    const chapingo = {lat: 19.342525, lng: -98.8448874};
    const tecuala = {lat: 22.39869, lng: -105.45371};
    const yucatan = {lat: 20.97537, lng: -89.61696};

    const marker = new google.maps.Marker({
        position: chapingo,
        map: map,
        title: "Chapingo"
    });

    const marke2 = new google.maps.Marker({
        position: tecuala,
        map: map,
        title: "Tecuala"
    });

    const marke3 = new google.maps.Marker({
        position: yucatan,
        map: map,
        title: "Yucatán"
    });
}

window.initMap = initMap;