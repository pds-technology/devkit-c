// ----------------------------------------------------------------------------
// XSLT REC Compliant Version of IE5 Default Stylesheet
//
// Original version by Jonathan Marsh (jmarsh@microsoft.com)
// http://msdn.microsoft.com/xml/samples/defaultss/defaultss.xsl
//
// Conversion to XSLT 1.0 REC Syntax by Steve Muench (smuench@xxxxxxxxxx)
//
// 8 August 2005 Gary Masters
//   Conversion to support both Mozilla and MSIE behaviors.
//   For example, search for nodes rather than assuming where they exist.
//   Use getElementById.
//   Split javascript out into separate file.
// ----------------------------------------------------------------------------

              //<!--<![CDATA[              ]]>
                  function f(e){
			// if this element is an inline comment, and contains more than a single
			//  line, turn it into a block comment.
                     if (e.className=="ci") {
                       for( var i = 0; i < e.childNodes.length; i++ ) {
                         if (e.childNodes[i].nodeName.toLowerCase()=='pre') {
                           if (e.childNodes[i].childNodes[0].nodeValue.indexOf('\n') > 0 ||    // For Mozilla
                               e.childNodes[i].childNodes[0].nodeValue.indexOf('\r') > 0 ) {   // For MSIE
                             fix(e,"cb");
                           }
                         }
                       }
                     }
			// if this element is an inline cdata, and contains more than a single
			//  line, turn it into a block cdata.
                     if (e.className=="di") {
                       for( var i = 0; i < e.childNodes.length; i++ ) {
                         if (e.childNodes[i].nodeName.toLowerCase()=='pre') {
                           if (e.childNodes[i].childNodes[0].nodeValue.indexOf('\n') > 0 ||    // For Mozilla
                               e.childNodes[i].childNodes[0].nodeValue.indexOf('\r') > 0 ) {   // For MSIE
                             fix(e,"db");
                           }
                         }
                       }
                     }
			// remove the id since we only used it for cleanup
                     e.id="";
                  }

		// Fix up the element as a "block" display and enable expand/collapse on it
                  function fix(e,cl){
	            var j,k;
			 // change the class name and display value
                    e.className=cl;
                    e.style.display="block";
			// mark the comment or cdata display as a expandable container
                    if (e.parentNode) {
                      j=e.parentNode.childNodes[0];     // For Mozilla
                    } else if (e.parentElement) {
                      j=e.parentElement.childNodes[0];  // For MSIE
                    } else return;
                    j.className="c";
			// find the +/- symbol and make it visible - the dummy link enables tabbing
                    for( var i = 0; i < j.childNodes.length; i++ ) {
                      if (j.childNodes[i].nodeName.toLowerCase()=="a") {
                        k=j.childNodes[i];
                        k.style.visibility="visible";
                        k.href="#";
                      }
                    }
                  }

		// Change the +/- symbol and hide the children.  
		// This function works on "element" displays
                  function ch(e) {
	            var i,mark,div;
			// find the node containing the +/- symbol
                    for( var i = 0; i < e.childNodes.length; i++ ) {
                      if( e.childNodes[i].nodeName.toLowerCase() == 'div' &&  e.childNodes[i].className.toLowerCase() == 'c') {
                        div=e.childNodes[i];
                      }
                    }
                    for( var i = 0; i < div.childNodes.length; i++ ) {
                      // Ignore anchors without a class because they represent anchors for type names.
                      if( div.childNodes[i].nodeName.toLowerCase() == 'a' && div.childNodes[i].className ) {
                        mark=div.childNodes[i];
                      }
                    }
			// if it is already collapsed, expand it by showing the children
                    if (mark.childNodes[0].nodeValue=="+") {
                      mark.childNodes[0].nodeValue="-";
                      for (var i=1;i<e.childNodes.length;i++) {
                        if ( e.childNodes[i].nodeType != 3 && e.childNodes[i].className.toLowerCase() != 'c') {
                          e.childNodes[i].style.display="block";
                        }
                      }
                    }
			// if it is expanded, collapse it by hiding the children
                    else if (mark.childNodes[0].nodeValue=="-") {
                      mark.childNodes[0].nodeValue="+";
                      for (var i=1;i<e.childNodes.length;i++) {
                        if ( e.childNodes[i].nodeType != 3 && e.childNodes[i].className.toLowerCase() != 'c') {
                          e.childNodes[i].style.display="none";
                        }
                      }
                    }
                  }

		// Change the +/- symbol and hide the children.  
		// This function works on "comment" and "cdata" displays
                  function ch2(e) {
	            var mark,contents;
			// find the +/- symbol, and the "PRE" element that contains the content
                    for( var i = 0; i < e.childNodes.length; i++ ) {
                      if( e.childNodes[i].nodeType != 3 &&  e.childNodes[i].className.toLowerCase() == 'c') {
                        div=e.childNodes[i];
                      }
                    }
                    for( var i = 0; i < div.childNodes.length; i++ ) {
                      if( div.childNodes[i].nodeName.toLowerCase() == 'a' ) {
                        mark=div.childNodes[i];
                      }
                    }
                    contents=e.childNodes[1];
			// if it is already collapsed, expand it by showing the children
                    if (mark.childNodes[0].nodeValue=="+") {
                      mark.childNodes[0].nodeValue="-";
			// restore the correct "block"/"inline" display type to the PRE
                      if (contents.className=="db"||contents.className=="cb") {
                        contents.style.display="block";
                      }
                      else {
                        contents.style.display="inline";
                      }
                    }
			// if it is expanded, collapse it by hiding the children
                    else if (mark.childNodes[0].nodeValue=="-") {
                      mark.childNodes[0].nodeValue="+";
                      contents.style.display="none";
                    }
                  }

		 // Handle a mouse click
                  function cl(e) {
                    if (e) {
                      // for Mozilla
                      e = e.target;
                    } else {
                      // for IE
                      e=window.event.srcElement;
                    }
			// make sure we are handling clicks upon expandable container elements
                    if (e.className!="c") {
                      if (e.parentNode)  { 
                        e=e.parentNode;     // for Mozilla
                      } else if (e.parentElement) {
                        e=e.parentElement;  // for IE
                      } else return;
                      if (e.className!="c") {
                        return;
                      }
                    }
                    if (e.parentNode)  { 
                      e=e.parentNode;     // for Mozilla
                    } else if (e.parentElement) {
                      e=e.parentElement;  // for IE
                    } else return;
			// call the correct function to change the collapse/expand state and display
                    if (e.className=="e") {
                      ch(e);
                    }
                    if (e.className=="k") {
                      ch2(e);
                    }
                  }

		// Dummy function for expand/collapse link navigation - trap onclick events instead
                  function ex(){}

		// Erase bogus link info from the status window
                  function h(){window.status=" ";}

		// Set the onclick handler
                  document.onclick=cl;
              //-->
