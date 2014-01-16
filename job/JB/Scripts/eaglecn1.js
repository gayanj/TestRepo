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
    var j = window.location.toString(), a = []; a = j.split("/");

    for (var i = 0; i < a.length; i++)
        if (a[i].toString().indexOf("home") > -1) {
            var h = document.getElementById("cnmenuitem2");
            h.setAttribute("onmouseout", "this.className='mn_canover'");
            h.className = "mn_canover";
        }

        else if (a[i].toString().indexOf("myapplications") > -1) {
            var c = document.getElementById("cnmenuitem3");
            c.setAttribute("onmouseout", "this.className='mn_canover'");
            c.className = "mn_canover";
        }

        else if (a[i].toString().indexOf("userdetails") > -1) {
            var d = document.getElementById("cnmenuitem4");
            d.setAttribute("onmouseout", "this.className='mn_canover'");
            d.className = "mn_canover";
        }

        else if (a[i].toString().indexOf("changepassword") > -1) {
            var e = document.getElementById("cnmenuitem5");
            e.setAttribute("onmouseout", "this.className='mn_canover'");
            e.className = "mn_canover";
        }

        else if (a[i].toString().indexOf("privacy") > -1) {
            var f = document.getElementById("cnmenuitem6");
            f.setAttribute("onmouseout", "this.className='mn_canover'");
            f.className = "mn_canover";
        }

        else if (a[i].toString().indexOf("notes") > -1) {
            var g = document.getElementById("cnmenuitem7");
            g.setAttribute("onmouseout", "this.className='mn_canover'");
            g.className = "mn_canover";
        }

        else if (a[i].toString().indexOf("resumes") > -1) {
            var b = document.getElementById("cnmenuitem8");
            b.setAttribute("onmouseout", "this.className='mn_canover'");
            b.className = "mn_canover";
        }

        else if (a[i].toString().indexOf("audit") > -1) {
            b = document.getElementById("cnmenuitem9");
            b.setAttribute("onmouseout", "this.className='mn_canover'");
            b.className = "mn_canover";
        }
}