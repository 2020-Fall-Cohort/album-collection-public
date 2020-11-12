import Header from './components/Header';
import Home from './components/Home';
import Albums from './components/Albums';

export default () => {
    header();
    navHome();
    navAlbums();
}

const appDiv = document.querySelector('.app');

function header(){
    const headerElement = document.querySelector('.header');
    headerElement.innerHTML = Header();
}

function navHome(){
    const homeButton = document.querySelector('.nav-home');
    homeButton.addEventListener('click', function(){
        appDiv.innerHTML = Home();
    })
}

function navAlbums() {
    const albumsButton = document.querySelector('.nav-albums');
    albumsButton.addEventListener('click', function(){
        console.log("click")
        fetch("https://localhost:44313/api/album")
            .then(response => response.json())
            .then(albums => {
                appDiv.innerHTML = Albums(albums);
            })
            .catch(err => console.log(err))
    })
}