var egeButton = document.getElementById("egeButton");
var uneversityButton = document.getElementById("uneversityButton");
var dopZanaytiayButton = document.getElementById("dopZanaytiayButton");
var workButton = document.getElementById("workButton");

var showPodrobnosti = document.getElementById("podrobnostiView");
var showDarkness = document.getElementById("darkness");

showDarkness.onclick = function() {
    showPodrobnosti.style.display = "none";
    showDarkness.style.display = "none";
}

egeButton.onclick = function() {
    showPodrobnosti.style.display = "block";
    showDarkness.style.display = "block";
}
uneversityButton.onclick = function() {
    showPodrobnosti.style.display = "block";
    showDarkness.style.display = "block";
}
dopZanaytiayButton.onclick = function() {
    showPodrobnosti.style.display = "block";
    showDarkness.style.display = "block";
}
workButton.onclick = function() {
    showPodrobnosti.style.display = "block";
    showDarkness.style.display = "block";
}