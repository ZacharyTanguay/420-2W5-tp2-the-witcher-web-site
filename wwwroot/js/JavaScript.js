const DIFF = 15;
const BASE = 26; //Emplacement par défault de l'épée
let navBarLinks = document.getElementsByClassName("nav-link"); //[Retourne un ARRAY de HTML du navbar]
let links = document.getElementsByClassName("links"); //[Retourne un ARRAY de HTML de la classe lienInvisible]
let searchCardWrapper = document.getElementsByClassName("searchCardWrapper"); //[Retourne un ARRAY de HTML de la classe searchCardWrapper]
let carouselSlide = document.getElementsByClassName("carousel");

let sword = document.getElementById("sword");
let nomPersonnageRecherche = document.getElementsByClassName("searchCharacterName");
let rolePersonnageRecherche = document.getElementsByClassName("searchCharacterRole");

for (let i = 0; i < navBarLinks.length; i++) {
    navBarLinks[i].addEventListener("mouseover", function () {
        sword.style.top = BASE + DIFF * i + "%";
    })
}

for (let i = 0; i < links.length; i++) {
    links[i].addEventListener("mouseover", function () {
        links[i].style.color = "red";
    })
    links[i].addEventListener("mouseleave", function () {
        links[i].style.color = "white";
    })
}


window.onload = function () {
    for (let i = 0; i < carouselSlide.length; i++) {
        links[i].addEventListener("mouseover", function () {
            $("#" + i).carousel('cycle');
            console.log($("#" + i))
        })

        links[i].addEventListener("mouseleave", function () {
            $("#" + i).carousel('pause');
        })
    }
}