/*
function updatecartdisplay() { var a = document.getElementById("Labelcount"); a.innerHTML = getjobbasketitems() } function addjobbasket(b) { if (getjobbasketitems() < 5) { var a = readCookie("fq_jobcart"); if (a == null) { createCookie("fq_jobcart", b, 10); a = readCookie("fq_jobcart") } else { var c = b + "," + a; createCookie("fq_jobcart", c, 10) } updatecartdisplay() } else return alert("Maximum of " + getjobbasketitems() + " jobs can be applied at a time") }

function addgrdjobbasket(a, b) { if (getjobbasketitems() < 5) document.getElementById(b).style.display = "none"; addjobbasket(a); return false }

function clearjobbasket() { eraseCookie("fq_jobcart"); updatecartdisplay() }

function getjobbasketitems() { if (readCookie("fq_jobcart") == null) return 0; else { var b = readCookie("fq_jobcart"), a = b.split(","); for (i = 0; i < a.length; i++); return i } }

function searchjobcart(c, b) { var a = c.split(); for (o = 0; o < a.length; o++) if (a[o] == b) return true }
*/

