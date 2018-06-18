$(document).ready(function () {
    if (localStorage.getItem("popup") != "visited") {
        localStorage.setItem("popup", "visited");
        setTimeout(function () {
            document.getElementById("popup").style.display = "block";
            document.getElementById("popup").style.width = "100%";

        }, 12000)
        document.getElementById("close_popup").onclick = function () {
            document.getElementById("popup").style.display = "none"
        }
        setTimeout(function () {

        }, 500)
    }
   


})



