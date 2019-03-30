
	function ExpandCollapse(suffix)
	{
		var oTbl = document.getElementById('tbl-' + suffix);
		var oBtn = document.getElementById('btn-' + suffix);
		if (oBtn.getAttribute("value") == "+")
		{	oBtn.setAttribute("value", "-");
			oTbl.style.visibility = "collapse"; //  "hidden";
		}
		else
		{	oBtn.setAttribute("value", "+");
			oTbl.style.visibility = "visible"; //  "show";
		}
	}
	function CollapseAll()
	{
		var elems = document.getElementsByTagName("*");
		var m=elems.length;
		for (var i=0; i<m; i++) {
			if (elems[i].id) {
				if (elems[i].id.indexOf("btn-") != -1) {
					elems[i].setAttribute("value", "-");;
				}
				else if (elems[i].id.indexOf("tbl-") != -1) {
					elems[i].style.visibility = "collapse"; //  "hidden";
				}
			}


		}
	}
	function ExpandAll()
	{
		var elems = document.getElementsByTagName("*");
		var m=elems.length;
		for (var i=0; i<m; i++) {
			if (elems[i].id) {
				if (elems[i].id.indexOf("btn-") != -1) {
					elems[i].setAttribute("value", "+");;
				}
				else if (elems[i].id.indexOf("tbl-") != -1) {
					elems[i].style.visibility = "visible"; //  "show";
				}
			}


		}
	}
