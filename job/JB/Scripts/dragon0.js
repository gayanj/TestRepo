$(document).ready(function () {
    //hidedivs("locdiv");
    //hidedivs("saldiv");

    //alert(readCookie("fq_policy"));

});

function settabova(c) {
    var a = document.getElementById(c), b = a.getAttribute("class"); b != "tb_headfourselected" && a.setAttribute("class", "tb_headthree")
}

function setActiveTab(b) {
    var a = document.getElementById(b), c = document.getElementById("tbind"), d = document.getElementById("tbloc"), e = document.getElementById("tbsal");
    if (b == "tbloc") { a.setAttribute("class", "tb_headfourselected"); c.setAttribute("class", "tb_headfour"); e.setAttribute("class", "tb_headfour") }

    else if (b == "tbind") { a.setAttribute("class", "tb_headfourselected"); e.setAttribute("class", "tb_headfour"); d.setAttribute("class", "tb_headfour") }

    else { a.setAttribute("class", "tb_headfourselected"); c.setAttribute("class", "tb_headfour"); d.setAttribute("class", "tb_headfour") }
}

/*avoid repetition on default+searched pages, move to single doc, start global*/

function showdivs(a) {
    $('#' + a).show();
}

function hidedivs(a) {
    $('#' + a).hide();
}

function createCookie(e, d, b) { if (b) { var a = new Date; a.setTime(a.getTime() + b * 864e5); var c = "; expires=" + a.toGMTString() } else var c = ""; document.cookie = e + "=" + d + c + "; path=/" }

function readCookie(e) { for (var c = e + "=", d = document.cookie.split(";"), b = 0; b < d.length; b++) { var a = d[b]; while (a.charAt(0) == " ") a = a.substring(1, a.length); if (a.indexOf(c) == 0) return a.substring(c.length, a.length) } return null }

function eraseCookie(a) { createCookie(a, "", -1) }

/*end global*/