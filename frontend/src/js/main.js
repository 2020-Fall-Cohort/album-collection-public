import Header from './components/Header';
import Home from './components/Home';
import Albums from './components/Albums';
import Artists from './components/Artists';
import Artist from './components/Artist'; 


export default () => {
    header();
    navHome();
    navAlbums();
    navArtists();
}

const appDiv = document.querySelector('.app');

function header() {
    const headerElement = document.querySelector('.header');
    headerElement.innerHTML = Header();
}

function navHome() {
    const homeButton = document.querySelector('.nav-home');
    homeButton.addEventListener('click', function () {
        appDiv.innerHTML = Home();
    })
}

function navAlbums() {
    const albumsButton = document.querySelector('.nav-albums');
    albumsButton.addEventListener('click', function () {
        console.log("click")
        fetch("https://localhost:44313/api/album")
            .then(response => response.json())
            .then(albums => {
                appDiv.innerHTML = Albums(albums);
            })
            .catch(err => console.log(err))
    })
}

function navArtists() {
    const artistsButton = document.querySelector('.nav-artists');
    artistsButton.addEventListener('click', function () {
        fetch("https://localhost:44313/api/artist")
            .then(response => response.json())
            .then(artists => {
                appDiv.innerHTML = Artists(artists);
                artistNameButton();
            })
            .catch(err => console.log(err))
    })
}

function artistNameButton() {
    const artistNameElements = document.querySelectorAll('.artist-name');
    artistNameElements.forEach(element => {
        element.addEventListener('click', function () {
            const artistId = element.id;
            console.log(`click artist id: ${artistId}`)
            fetch(`https://localhost:44313/api/artist/${artistId}`)
            .then(response => response.json())
            .then(artist => {
                appDiv.innerHTML = Artist(artist);
                artistAddAlbum();
                artistDeleteAlbum();
            })
            .catch(err => console.log(err))
        })
    })
}

function artistAddAlbum(){
    const artistAddAlbumButton = document.querySelector('.artist-album-submit');
    artistAddAlbumButton.addEventListener('click', function(){
        const artistId = artistAddAlbumButton.id;
        const albumName = event.target.parentElement.querySelector('.artist-album-input').value;
        console.log(`artist id: ${artistId}, album name: ${albumName}`)

        const requestBody ={
            Name: albumName,
            ArtistId: artistId
        }
        fetch(`https://localhost:44313/api/album`, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(requestBody)
        })
        .then(response => response.json())
        .then(albums => {
            appDiv.innerHTML = Albums(albums)
        })
        .catch(err => console.log(err))
    })
}

function artistDeleteAlbum(){
    const artistDeleteAlbumButtons = document.querySelectorAll('.artist-delete-album');
    artistDeleteAlbumButtons.forEach(button => {
        button.addEventListener('click', function(){
            const albumId = event.target.parentElement.querySelector('.artist-album-id').value;
            console.log(albumId);
            fetch(`https://localhost:44313/api/album/${albumId}`, {
                method: "DELETE",
                headers: {
                    "Content-Type": "application/json"
                }
            })
            .then(response => response.json())
            .then(albums => {
                appDiv.innerHTML = Albums(albums)
            })
            .catch(err => console.log(err))
        })
    })
}
