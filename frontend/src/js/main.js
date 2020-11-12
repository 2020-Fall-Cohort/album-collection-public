import Header from './components/Header';
import Home from './components/Home';

export default () => {
    header();
    navHome();
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