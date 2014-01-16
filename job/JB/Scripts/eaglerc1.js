function querySt(a) {
    var hu = window.location.search.substring(1);
    var gy = hu.split("&");
    for (var i = 0; i < gy.length; i++) {
        var ft = gy[i].split("=");
        if (ft[0] == a) {
            return ft[1];
        }
    }
}

function highlightitem() {
    var l = window.location.toString(), a = []; a = l.split("/");

    for (var i = 0; i < a.length; i++)
        if (a[i].toString().indexOf("home") > -1) {
            var k = document.getElementById("recmenuitem2");
            k.setAttribute("onmouseout", "this.className='mn_recover'");
            k.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("recruiterdetails") > -1) {
            var c = document.getElementById("recmenuitem3");
            c.setAttribute("onmouseout", "this.className='mn_recover'");
            c.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("applications") > -1) {
            var d = document.getElementById("recmenuitem4");
            d.setAttribute("onmouseout", "this.className='mn_recover'");
            d.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("editjobs") > -1) {
            var e = document.getElementById("recmenuitem5");
            e.setAttribute("onmouseout", "this.className='mn_recover'");
            e.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("changepassword") > -1) {
            var f = document.getElementById("recmenuitem6");
            f.setAttribute("onmouseout", "this.className='mn_recover'");
            f.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("jobform") > -1) {
            var g = document.getElementById("recmenuitem7");
            g.setAttribute("onmouseout", "this.className='mn_recover'");
            g.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("audit") > -1) {
            var h = document.getElementById("recmenuitem8");
            h.setAttribute("onmouseout", "this.className='mn_recover'");
            h.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("credits") > -1) {
            var j = document.getElementById("recmenuitem9");
            j.setAttribute("onmouseout", "this.className='mn_recover'");
            j.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("cvsearch") > -1) {
            var b = document.getElementById("recmenuitem10");
            b.setAttribute("onmouseout", "this.className='mn_recover'");
            b.className = "mn_recover";
        }

        else if (a[i].toString().indexOf("bulkimport") > -1) {
            b = document.getElementById("recmenuitem11");
            b.setAttribute("onmouseout", "this.className='mn_recover'");
            b.className = "mn_recover";
        }
}