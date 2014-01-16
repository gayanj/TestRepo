$(document).ready(function () {
    loader();
});

function loader() {

    /*version 2.x
    switch to jquery*/

    /* done via css, js is way to expensive for us
    hidedivs("dftimprovert");
    hidedivs("indp");
    hidedivs("locp");
    hidedivs("salp");
    hidedivs("contp");
    hidedivs("emplp");
    hidedivs("hrsp");
    hidedivs("secp");
    hidedivs("radp");
    hidedivs("comp");
    hidedivs("datep");
    hidedivs("carp");
    hidedivs("edup");
    */

    if (readCookie("fq_options") != 1) {
        hidedivs("optionspanels");
    }

    else {
        showdivs("optionspanels");
    }

    if (readCookie("fq_details") == 1) {
        var b = document.getElementsByTagName("p");
        for (var a = 0; a < b.length; a++) {
            //b[a].style.display = "";
            $(b[a]).show();
        }
    }

    else {
        var c = document.getElementsByTagName("p");
        for (a = 0; a < c.length; a++) {
            //c[a].style.display = "none";
            $(c[a]).hide();
        }
    }

    if (readCookie("fq_browse") != 1) {
        hidedivs("brhidetop");
        hidedivs("browsedetails");
    }

    else {
        hidedivs("brshowtop");        
    }

    if (readCookie("fq_suggest") != 1) {
        showdivs("suggests");
    }

    else {
        hidedivs("suggests");
    }

    //set scroll
    customscroll();
}

function gotohome() {
    window.location = "/searched.aspx";
}

function showhideoptions() {
    var a = document.getElementById("optionspanels");
    if (a.style.display == "none") {
        createCookie("fq_options", 1, 10);
        //showdivs("optionspanels");
        $("#optionspanels").slideDown();
    }

    else {
        //hidedivs("optionspanels");
        $("#optionspanels").slideUp();
        createCookie("fq_options", 0, 10);
    }

}

function showgriddesc() {
    createCookie("fq_details", 1, 10);
    var b = document.getElementsByTagName("p");
    for (var a = 0; a < b.length; a++) {
        //b[a].style.display = "";        
        $(b[a]).show();
    }
}

function hidegriddesc() {
    createCookie("fq_details", 2, 10);
    var b = document.getElementsByTagName("p");
    for (var a = 0; a < b.length; a++) {
        //b[a].style.display = "none";        
        $(b[a]).hide();
    }
}

/*avoid repetition on default+searched pages, move to single doc, start global*/

function showdivs(a) {
    $('#' + a).show();
}

function hidedivs(a1) {
    $('#' + a1).hide();
}

function createCookie(e, d, b) {
    if (b) { var a = new Date; a.setTime(a.getTime() + b * 864e5); var c = "; expires=" + a.toGMTString() } else var c = ""; document.cookie = e + "=" + d + c + "; path=/"
}

function readCookie(e) {
    for (var c = e + "=", d = document.cookie.split(";"), b = 0; b < d.length; b++) { var a = d[b]; while (a.charAt(0) == " ") a = a.substring(1, a.length); if (a.indexOf(c) == 0) return a.substring(c.length, a.length) } return null
}

function eraseCookie(a) {
    createCookie(a, "", -1)
}

/*end global*/

function changecss() {
    var did = document.getElementById('dv_savedsearch');
    did.className = 'centeredshow';
    scroll(0, 0);
    return false;
}

function changecssoff() {
    var did = document.getElementById('dv_savedsearch');
    did.className = 'centered';
    return false;
}

/*scroll*/

function customscroll() {
    var a = $(window), b = false; a.bind("resize", function () { if (!b) { b = true; var c = $("#full-page-container"); c.css({ width: 1, height: 1 }); c.css({ width: a.width(), height: a.height() }); b = false; c.jScrollPane({ showArrows: false }); } }).trigger("resize"); $("body").css("overflow", "hidden"); $("#full-page-container").width() != a.width() && a.trigger("resize"); $(".scroll-pane").jScrollPane({ showArrows: false });
}
