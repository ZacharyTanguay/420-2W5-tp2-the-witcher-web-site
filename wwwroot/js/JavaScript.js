const DIFF = 18;
const BASE = 38; //Emplacement par défault de l'épée
let navBarLinks = document.getElementsByClassName("nav-link"); //[Retourne un ARRAY de HTML du navbar]
let sword = document.getElementById("sword");

for (let i = 0; i < navBarLinks.length; i++) {
    navBarLinks[i].addEventListener("mouseover", function () {
        sword.style.top = BASE + DIFF * i + "%";
        console.log(BASE + DIFF * i + "%");
    })
}