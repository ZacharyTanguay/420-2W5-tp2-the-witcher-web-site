// (C) 2022 Maxime Gagnon. All rights reserved.
// Use granted under specific terms to Zachary Tanguay

function getFunInfoStr(target) {
	return `${target.nodeName.toLowerCase()}${target.id != "" ? "#" + target.id : ""}${target.classList.length > 0 ? "." + target.classList.toString() : ""}`;
}

// select element
function $(sel, parent) {
	if (!DEBUG)
		return (parent ? parent : document).querySelector(sel);
	let elem = (parent ? parent : document).querySelector(sel);
	if (elem === null) {
		if (parent)
			console.warn(`[WARN] No element matched selector "${sel}" inside "${getFunInfoStr(parent)}".`);
		else
			console.warn(`[WARN] No element matched selector "${sel}" in the document.`);
		return document.createElement("invalid");
	}
	return elem;
}

// register links with special class
function registerLinks() {
	let buttons = $$(".link");
	for (let i = 0; i < buttons.length; i++) {
		buttons[i].addEventListener("click", (e) => {
			let target = e.currentTarget;
			redirect($a("data-href", target));
		});
	}
}

function $$(sel, parent) {
	if (!DEBUG)
		(parent ? parent : document).querySelectorAll(sel);
	let elems = (parent ? parent : document).querySelectorAll(sel);
	if (elems.length === 0)
		if (parent)
			console.warn(`[WARN] No collection matched selector "${sel}" in "${getFunInfoStr(parent)}".`);
		else
			console.warn(`[WARN] No collection matched selector "${sel}" in document.`);
	return elems;
}
function $a(attr, parent) {
	if (!DEBUG)
		return parent.getAttribute(attr);
	let val = parent.getAttribute(attr);
	if (val === null || val == undefined) {
		console.warn(`[WARN] No attribute "${attr}" was found in "${getFunInfoStr(parent)}".`);
		return "invalid";
	}
	return val;
}


const html = `
<style>@import url('https://fonts.googleapis.com/css2?family=MedievalSharp&family=Pathway+Gothic+One&display=swap');#collabPopup{position:fixed;color:white;right:-450px;bottom:50px;z-index:10;width:420px;height:min-content;display:grid;grid-template-rows:15% 3% 63% 3% 10%;border:ridge 4px #8b8787;border-right:0;border-top-left-radius:10px;border-bottom-left-radius:10px;box-shadow:0 0 10px #d3d3d3;font-family:'Pathway Gothic One';font-size:21px;outline:solid 0 #ffb4b491;transition:right 2.5s cubic-bezier(.2,.6,.35,1),transform .5s ease-in,outline .5s ease-out;animation:ad-float 1s ease-in-out infinite}#collabPopup h2{position:relative;z-index:4;display:flex;align-items:center;justify-content:center;text-align:center;padding:10px 0 10px 0;margin:0;background:#000;box-shadow:-4px 6px 6px #3c2b2b5c,-3px -11px 6px #3c2b2b5c,-5px 8px 6px #2f25258a;border-top-left-radius:10px;font-size:25px;animation:ad-h2-shadow 1s cubic-bezier(.93,-.71,.63,1.88) infinite}#collabPopup .geralt{font-family:MedievalSharp;font-size:29px;text-shadow:0 0 4px #b34f10f0;animation:ad-h2-color .5s cubic-bezier(.93,-.71,.63,1.88) infinite}#collabPopup article{display:flex;flex-direction:row;background:#080808;box-shadow:0 5px 10px white}#collabPopup p{padding:12px;margin:0;text-align:left;font-size:16px}#collabPopup .geraltImg{width:40%;object-fit:cover;border-right:ridge 3px #2e020f;box-shadow:2px -2px 8px white}#collabPopup marquee{line-height:1px;filter:blur(5px)}#collabPopup .swordTop{width:101%;height:17px;position:absolute;top:-11px;right:-4px;transform:scaleX(-1);z-index:7}#collabPopup .swordBottom{width:101%;height:17px;position:absolute;bottom:-11px;right:-4px;transform:scaleX(-1);z-index:7}#collabPopup button{height:min-content;font-size:1.4em;font-family:'Pathway Gothic One';white-space:nowrap;background:#000;border:none;border-bottom-left-radius:10px;box-shadow:0 -10px 10px white;animation:ad-button-shadow 1s cubic-bezier(.93,-.71,.63,1.88) infinite}#collabPopup button b{color:transparent;background-image:linear-gradient(0deg,#fff,white);background-clip:text;-webkit-background-clip:text;-webkit-text-fill-color:transparent;transition:text-shadow .2s ease-out,letter-spacing .2s ease-out}#collabPopup button b:hover{text-shadow:0 0 6px #941a1a;letter-spacing:4px}#collabPopup .closeBtn{position:absolute;right:0;z-index:5;color:#fff;background:#ffffff00;box-shadow:none;font-size:1.5em;animation:none}#collabPopup .overlay{width:100%;height:100%;position:absolute;left:0;top:0;z-index:5;opacity:0;border-radius:10px;background:#333131d1;box-shadow:inset 0 0 10px #830000;backdrop-filter:blur(3px);pointer-events:none;animation:ad-overlay-vignette 3s ease-in-out infinite;transition:opacity 1s linear,filter 1s linear}#collabPopup .progressHeader{margin-top:5%;text-shadow:0 0 5px white;font-size:25px;text-align:center}.throbber{position:absolute;top:50%;left:50%;object-fit:contain;width:40%;height:40%;transform:translate(-50%,-50%) rotate(0);zoom:.7;z-index:6;border: 0;filter:drop-shadow(0 0 10px white);animation:ad-throbber 1s ease-in-out infinite}#collabPopup progress{height:30px;margin:0;padding:5px;position:absolute;left:50%;bottom:6%;transform:translateX(-50%);z-index:6;appearance:none;-webkit-appearance:none;border:solid 1px #8b0000;border-radius:20px;background:#fff;box-shadow:0 0 10px #000;transition:transform .5s linear}#collabPopup progress::-moz-progress-bar{border-radius:20px;background:white}#collabPopup progress::-webkit-progress-bar{border:0;border-radius:20px;background:#fff}#collabPopup progress::-webkit-progress-value{border-radius:20px;background:white;box-shadow:0 0 10px white}#collabPopup .progressText{margin:0;padding:0;position:absolute;left:50%;bottom:6.5%;transform:translateX(-50%);z-index:6;color:#000;text-shadow:0 0 3px #000;font-size:15px;transition:transform .5s linear,opacity .3s ease-in-out}@keyframes ad-h2-color{from{color:white}to{color:lightgrey}}@keyframes ad-h2-shadow{0%{box-shadow:0 6px 20px 2px white}50%{box-shadow:0 6px 20px 2px lightgrey}100%{box-shadow:0 6px 20px 2px white}}@keyframes ad-float{0%{transform:translateY(0)}50%{transform:translateY(-10px)}100%{transform:translateY(0)}}@keyframes ad-button-shadow{0%{box-shadow:0 -10px 20px 2px white}50%{box-shadow:0 -10px 20px 2px lightgrey}100%{box-shadow:0 -10px 20px 2px white}}@keyframes ad-throbber{from{transform:translate(-50%,-50%) rotate(0)}to{transform:translate(-50%,-50%) rotate(360deg)}}@keyframes ad-throbber-reverse{from{transform:translate(-50%,-50%) rotate(0)}to{transform:translate(-50%,-50%) rotate(-360deg)}}@keyframes ad-overlay-vignette{0%{box-shadow:inset 0 0 10px #830000}50%{box-shadow:inset 0 0 20px red}100%{box-shadow:inset 0 0 10px #830000}}@keyframes ad-progress-rainbow{from{filter:hue-rotate(0)}to{filter:hue-rotate(360deg)}}</style>
<section id=collabPopup>
<button class=closeBtn>&times;</button>
<img class=swordTop src=/images/Épée.png>
<img class=swordBottom src=/images/Épée.png>
<div class=overlay>
<h4 class=progressHeader>Processing request...</h4>
<img class=throbber src=/images/wolfSchoolMedallion.png>
<progress min=-1 max=100></progress>
<p class=progressText>Loading...</p>
</div>
<h2><span class=geralt>&nbsp;</span> a besoin de toi!</h2>
<marquee bgcolor=#222 scrolldelay=10 truespeed><font color=white>█ █ █ █ █ █ █ █</font></marquee>
<article>
<img class=geraltImg src=/images/guard.webp>
<p>Sauras-tu triompher de tes ennemis? Joins-moi dans mon aventure épique à la recherche de <em>l'Épée de la Lune ! &nbsp;</em> Monstres et humains ne sauront résister à notre duo inséparable.<br><br><small><i>Lances-toi dans mon récit dès maintenant et court la chance de gagner une PS5.</i></small></p>
</article>
<marquee bgcolor=#222 scrolldelay=10 truespeed><font color=white>█ █ █ █ █ █ █ █</font></marquee>
<button class="collabBtn link" data-href=https://420-2w5-bethesdafollowers.azurewebsites.net/ ><b>ACCÉDER AU SITE</b></button>
</section>`;

document.body.innerHTML += html; // dumb
// display popup
function showPopup() {
	AD.style.right = "0";
	setTimeout(function () {
		if (canClosePopup)
			AD.style.right = "-430px";
	}, 15000);
}
// redirect to other website
function redirect(href) {
	if (!isRedirectEnabled)
		return;
	document.body.style.opacity = "0";
	setTimeout(() => {
		window.location.href = href;
	}, 500);
}

const DEBUG = false;
const AD = $("#collabPopup");
const ADIMG = $("#collabPopup .geraltImg");
let isRedirectEnabled = true;
let canClosePopup = true;


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////

let ITEMS = $$(".col"); // ADD CSS SELECTOR OF POPUP TRIGGERS HERE (E.G. ".carteEnfant")
let CHANCE = 0.20;  // % CHANCE FOR POPUP DISPLAY (1 = 100%)


window.onscroll = (e) => {
	AD.style.bottom = window.scrollY + "px";
}

const PROGRESS_TEXTS = [ // can be customised...
	"Checking for null pointers...",
	"Loading closure data...",
	"Ensuring academical integrity...",
	"Analysing TS sourcemap concordance...",
	"Checking on Ciri...",
	"Loading Havok Behavior(TM)...",
	"Generating Kevin Leduc...",
	"Garbage collecting JS code...",
	"Validating microtransactions...",
	"Polishing Gerald's silver sword...",
	"Fetching available essays...",
	"Handling exceptions too hard...",
	"Handshaking IIS Express Server...",
	"Contacting Microsoft support...",
	"Checking Visual Studio profiles...",
	"Establishing connection over SSMS...",
	"No shutdowning Cisco connection...",
	"Switching interface to VLAN1...",
	"Answering Zachary's questions...",
	"Collecting legal telemetry data...",
	"Auto-generating XML profiles...",
	"Asking Lydia to carry burdens...",
	"Brushing Ciri's hair...",
	"Sending Geralt to beat up furries...",
	"Generating initial SSL definitions...",
	"Purchasing something from Billy Mays...",
	"Checking your HDD for suspicious data...",
	"Downloading optional furry theme...",
	"Have you heard of the high elves?",
	"Parsing YAML markup data...",
	"Initiating nomming of a burger...",
	"Sending Ciri in mission with Ezio...",
	"Calling tech support...",
	"Searching for Dog Meat...",
	"Mapping Altair's furrydom...",
	"Contacting Abstergo's tech support...",
	"Exposing Theo's pyramid scheme...",
	"Analysing average Pokemon repartition...",
	"Testing for misclored fur strands...",
	"Finding the escaped fox (he's sneaky!)...",
	"Sharpening the Edge of Glory...",
	"Praising our Master, Todd Howard...",
	"May the Father of Understanding Guide Us.",
	"Replacing spaces in Python file...",
	"Studying for maths exam (I should be)...",
	"Stealing the Boots of Springheel Jack...",
	"Fetching 16 times the details...",
	"Sketching anthropomorphic foxes...",
	"Consolidating the Linux foundations...",
	"6-spaces tabs are superior cmm."
];

//////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////

for (let i = 0; i < ITEMS.length; i++) {
	ITEMS[i].onmouseover = () => {
		if (Math.random() < CHANCE)
			showPopup();
	};
}



document.body.style.opacity = "0";
document.body.style.transition = "opacity 0.5s ease-out";

window.addEventListener("load", function () {
	document.body.style.opacity = "1";
	registerLinks();




	// change image on hover
	AD.onmouseover = function () { ADIMG.src = "/images/guard2.webp"; };
	AD.onmouseleave = function () { ADIMG.src = "/images/guard.webp"; };

	// redirect to website on btn click
	$(".collabBtn", AD).onclick = function () {

		let foreground = $("#foreground_witcherCollab");
		foreground.style.display = "block";
		setTimeout(function () {
			foreground.style.opacity = "1";
			foreground.style.filter = "blur(100px) brightness(100)";
		}, 1000);
	};

	$(".closeBtn", AD).onclick = function () {
		const MAX_ITERATIONS = DEBUG ? 0 : 1;
		let nbIterations = 0;
		let progress = $("progress", AD);
		let progressText = $(".progressText", AD);
		let progressTextIndex = 0;
		let throbber = $(".throbber", AD);
		let progressAmount = 1;
		let decreaseMode = false;
		let decreaseModeIterations = -1;
		let decreaseModeCurrentIterations = 0;
		let progressHeader = $("#collabPopup .progressHeader");
		progressHeader.innerText = "Processing request...";
		let nbEllipsis = 3;
		$(".overlay", AD).style.opacity = "1";
		canClosePopup = false;
		function ellipsis() {
			if (nbEllipsis === 3) {
				progressHeader.innerText = progressHeader.innerText.slice(0, -3);
				nbEllipsis = 0;
			}
			else {
				progressHeader.innerText += ".";
				nbEllipsis++;
			}
		}
		function setProgressTextIndex() {
			progressText.style.opacity = "0";
			setTimeout(() => {
				progressTextIndex = Math.round(Math.random() * (PROGRESS_TEXTS.length - 1));
				progressText.style.opacity = "1";
			}, 300);
		}
		function setProgress() {
			if (decreaseMode) {
				progress.value -= progressAmount;
				decreaseModeCurrentIterations++;
			}
			else {
				progress.value += progressAmount;
			}
			if (progress.value >= 100) {
				setProgressTextIndex();
				progress.value = 0;
				nbIterations++;
			}
			if (progress.value === 0 && decreaseMode) {
				decreaseMode = false;
				decreaseModeCurrentIterations = 0;
				progress.style.animation = "none";
				throbber.style.animation = "ad-throbber 1s ease-in-out infinite";
			}
			progressText.innerText = PROGRESS_TEXTS[progressTextIndex] + " " + Math.round(progress.value) + "%";
			if (Math.random() < 0.1)
				progressAmount = Math.random() * Math.random();
			if (Math.random() < 0.005) {
				if (!decreaseMode) {
					decreaseMode = true;
					decreaseModeIterations = Math.random() * 200;
					progress.style.animation = "ad-progress-rainbow 1s linear infinite";
					throbber.style.animation = "ad-throbber-reverse 1s ease-in-out infinite";
				}
			}
			if (decreaseModeCurrentIterations >= decreaseModeIterations) {
				decreaseMode = false;
				decreaseModeCurrentIterations = 0;
				progress.style.animation = "none";
				throbber.style.animation = "ad-throbber 1s ease-in-out infinite";
			}
			if (nbIterations === MAX_ITERATIONS) {
				nbIterations = 0;
				progressHeader.innerText = "Closing popup...";
				progressText.innerText = "Request approved. Have a nice day!";
				setTimeout(() => {
					$(".overlay", AD).style.opacity = "0";
					AD.style.right = "-450px";
				}, 1000);
				return;
			}
			setTimeout(setProgress, 10);
		}
		setProgressTextIndex();
		setProgress();
		setInterval(() => {
			ellipsis();
		}, 500);
	};
});