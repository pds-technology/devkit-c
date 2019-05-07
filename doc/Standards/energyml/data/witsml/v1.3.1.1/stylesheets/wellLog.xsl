<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet 
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
  xmlns:witsml="http://www.witsml.org/schemas/131" 
  version="1.0"> 

  <xsl:output method="html"/>
        
  <xsl:template match="/">
    <html>
    <head>
      <link rel="stylesheet" href="witsml.css" type="text/css"/>
    </head>
    <body>    
    <xsl:for-each select="witsml:wellLogs/witsml:wellLog">
      <table align="center">
      <tr>
        <th class="mainheader" colspan="6">WITSML Well Log</th>
      </tr>
      <tr>
      <td class="label">Well Name:</td>
      <td class="dataval"><xsl:value-of select="witsml:nameWell"/> </td>
      <td> </td>
      <td class="label">Well Identifier</td>
      <td class="dataval"><xsl:value-of select="@uidWell"/> </td>
      <td> </td>
      </tr>
      <tr>
      <td class="label">Wellbore Name</td>
      <td class="dataval"><xsl:value-of select="witsml:nameWellbore"/> </td>
      <td> </td>
      <td class="label">Wellbore Identifier</td>
      <td class="dataval"><xsl:value-of select="@uidWellbore"/> </td>
      <td> </td>
      </tr>
      <tr>
      <td class="label">Log Name</td>
      <td class="dataval"><xsl:value-of select="witsml:name"/> </td>
      <td> </td>
      <td class="label">Log Identifier</td>
      <td class="dataval"><xsl:value-of select="@uid"/> </td>
      <td> </td>
      </tr>
        <tr>
        <td class="label">Service Company</td>
        <td class="dataval"><xsl:value-of select="witsml:serviceCompany"/></td>
        <td> </td>
        <td class="label">Run Number</td>
        <td class="dataval"><xsl:value-of select="witsml:runNumber"/> </td>
        <td> </td>
        </tr>
        <tr>
        <td class="label">Description</td>
        <td class="dataval"><xsl:value-of select="witsml:description"/> </td>
        <td> </td>
        <td class="label">Creation Date</td>
        <td class="dataval"><font size="-1">
        <xsl:call-template name="formatdate">
         <xsl:with-param name="strDate" select="witsml:creationDate"/>
        </xsl:call-template>
        </font> </td>
        <td> </td> </tr>
        <tr>
        <td class="label">Index</td>
        <td class="dataval"><xsl:value-of select="witsml:indexType"/> </td>
        <td> </td>
        </tr>
        <tr>
        <td class="label">Minimum Index</td>
        <td class="dataval"><xsl:value-of select="witsml:minIndex"/> </td>
        <td><xsl:apply-templates select="witsml:indexUnits" mode="UnitRef"/> </td>
        <td class="label">Maximum Index</td>
        <td class="dataval"><xsl:value-of select="witsml:maxIndex"/> </td>
        <td><xsl:apply-templates select="witsml:indexUnits" mode="UnitRef"/> </td>
        </tr>
        <xsl:for-each select="witsml:comment">
          <tr><th colspan="6">Comment</th> </tr>
          <tr><td><xsl:value-of select="."/> </td> </tr>
        </xsl:for-each>
    
        <!--
         Output Log Header Parameters if there are any
         -->
        <xsl:choose>
        <xsl:when test="logHeaderParam">
          <tr><th colspan="6">Log Header Parameters</th> </tr>
    
          <tr><td colspan="6" align="center"><table align="center">
          <tr><th>Index</th>
<th>Name</th>
<th>Value</th>
<th>Units</th>
<th colspan="2">Description</th> </tr>
          <xsl:for-each select="witsml:logHeaderParam">  
          <tr class="listtable">
          <td align="center"><xsl:value-of select="@index"/> </td>
          <td align="center"><xsl:value-of select="@name"/> </td>
  
          <td align="center"><xsl:value-of select="."/> </td>
          <td align="center"><xsl:apply-templates select="." mode="UomRef"/></td>
          <td align="center"><xsl:value-of select="@description"/> </td>
          </tr>
          </xsl:for-each>
          </table> <br/> </td> </tr>
        </xsl:when>
        </xsl:choose>
        
        <!--
         Output Log Curve Info Data
         -->
          <tr><th colspan="8">Log Curve Information</th> </tr>
              
        <tr><td colspan="8" align="center">
        <table align="center">
          <tr>
          <th>Mnemonic</th>
          <th>Classification</th>
          <th>Units</th>
          <th>Alias</th>
          <th>Null Value</th>
          <th>State</th>
          <th>Type</th>
          <th>Description</th>
          <th>Axes</th>
          </tr>
        <xsl:for-each select="witsml:logCurveInfo">  
        <xsl:sort select="witsml:columnIndex" data-type="number"/>
          <a name='curve_{position()}'>
            <xsl:value-of select="witsml:curveId"/>
          </a>
        <tr class="listtable">
        <td align="center"><xsl:value-of select="witsml:mnemonic"/> </td>
        <td align="center"><xsl:apply-templates select="witsml:classWitsml" mode="RealTimeData"/> </td>
        <td align="center"><xsl:apply-templates select="witsml:unit" mode="UnitRef"/> </td>
        <td align="center"><xsl:value-of select="witsml:mnemAlias"/> </td>
        <td align="center"><xsl:value-of select="witsml:nullValue"/> </td>
        <td align="center"><xsl:value-of select="witsml:traceState"/> </td>
        <td align="center"><xsl:value-of select="witsml:typeLogData"/> </td>
        <td align="center"><xsl:value-of select="witsml:curveDescription"/></td>
        <td align="center">
          <xsl:if test="witsml:axisDefinition">
                  <table border='3'>

<tr><th><font size='-2'>count</font></th>
<xsl:for-each select="witsml:axisDefinition">
<td><font size='-2'>
<xsl:value-of select="witsml:count"/>
</font></td>
</xsl:for-each></tr>

<tr><th><font size='-2'>name</font></th>
<xsl:for-each select="witsml:axisDefinition">
<td><font size='-2'>
<xsl:value-of select="witsml:name"/>
</font></td>
</xsl:for-each></tr>

<tr><th><font size='-2'>pty type</font></th>
<xsl:for-each select="witsml:axisDefinition">
<td><font size='-2'>
<xsl:value-of select="witsml:propertyType"/>
</font></td>
</xsl:for-each></tr>

<tr><th><font size='-2'>uom</font></th>
<xsl:for-each select="witsml:axisDefinition">
<td><font size='-2'>
<xsl:value-of select="witsml:uom"/>
</font></td>
</xsl:for-each></tr>

<tr><th><font size='-2'>coords</font></th>
<xsl:for-each select="witsml:axisDefinition">
<td><font size='-2'>
<xsl:value-of select="witsml:doubleValues"/>
</font></td>
</xsl:for-each></tr>
</table>

</xsl:if>

        </td>
        </tr>
         </xsl:for-each>
         </table>
         </td> </tr>

        
        <!--
        Output Log Pass, Block Info Data
         -->
          <tr><th colspan="11">Log Pass, Block Information</th> </tr>
              
        <tr><td colspan="11" align="center">
      <xsl:for-each select="witsml:blockInfo">  
        <xsl:sort select="witsml:pass" data-type="number"/>
        <xsl:variable name='blockId'>
          <xsl:value-of select='@blockId'/>
        </xsl:variable>
        <xsl:variable name='startIndex'>
          <xsl:value-of select='witsml:startIndex'/>
        </xsl:variable>
        <xsl:variable name='increment'>
          <xsl:choose>
            <xsl:when test="witsml:direction='Decreasing'">
              <xsl:value-of select='-1*witsml:stepIncrement'/>
            </xsl:when>
            <xsl:otherwise>
              <xsl:value-of select='witsml:stepIncrement'/>
            </xsl:otherwise>
          </xsl:choose>
        </xsl:variable>
        <table align="center">
          <tr>
          <th>Logging Pass</th>
          <th>Data Block Id</th>
          <th>Index</th>
          <th>Start Index</th>
          <th>End Index</th>
          <th>Step Increment</th>
          <th>Units</th>
          <th>direction</th>
          <th>Null Value</th>
          <th>Description</th>
          </tr>
        <tr class="listtable">
        <td align="center"><xsl:value-of select="witsml:pass"/> </td>
          <td align="center"><a name='blockInfo_{@blockId}'>
            <xsl:value-of select="@blockId"/>
          </a></td>
        <td align="center"><xsl:value-of select="witsml:indexType"/> </td>
        <td align="center"><xsl:value-of select="$startIndex"/> </td>
        <td align="center"><xsl:value-of select="witsml:endIndex"/> </td>
        <td align="center"><xsl:value-of select="witsml:stepIncrement"/> </td>
        <td align="center"><xsl:apply-templates select="witsml:indexUnits" mode="UnitRef"/> </td>
        <td align="center"><xsl:value-of select="witsml:direction"/> </td>
        <td align="center"><xsl:value-of select="witsml:nullValue"/></td>
        <td align="center"><xsl:value-of select="witsml:description"/></td>
</tr>

</table><table align="center">
      <!--
        Set up a sub-table to display the logData elements
        -->
      <tr><th colspan="100%">Log Pass Data</th> </tr>

      <tr>
        <xsl:for-each select="witsml:blockCurveInfo">
          <xsl:sort select="witsml:columnIndex" data-type="number"/>
          <xsl:variable name='curveId'>
            <xsl:value-of select='witsml:curveId'/>
          </xsl:variable>
          <th align="center">
            <xsl:value-of select="../../witsml:logCurveInfo[@curveId=$curveId]/witsml:mnemonic"/>
          </th>
        </xsl:for-each>
      </tr>

      <tr>
        <xsl:for-each select="witsml:blockCurveInfo">
          <xsl:sort select="witsml:columnIndex" data-type="number"/>
          <xsl:variable name='curveId'>
            <xsl:value-of select='witsml:curveId'/>
          </xsl:variable>
        <th align="center">
        <xsl:apply-templates select="../../witsml:logCurveInfo[@curveId=$curveId]/witsml:unit" mode="UnitRef"/>
         </th>
      </xsl:for-each>
      </tr>
      
      <tr>
        <xsl:for-each select="witsml:blockCurveInfo">
          <xsl:sort select="witsml:columnIndex" data-type="number"/>
          <th align="center">
            <xsl:value-of select="witsml:minIndex"/> -
            <xsl:value-of select="witsml:maxIndex"/>
           </th>
        </xsl:for-each>
      </tr>
      
      <!--
       Print out the data rows in an HTML table
       -->
       <xsl:choose>
         <xsl:when test="../witsml:logData/witsml:data[@id]">
           <xsl:for-each select="../witsml:logData/witsml:data[@id=$blockId]">
             <tr class="listtable">    
               <xsl:call-template name="splitstring">
                 <xsl:with-param name="string" select="."/>
                 <xsl:with-param name="pattern" select="','"/>
               </xsl:call-template>
             </tr>
           </xsl:for-each>
         </xsl:when>
         <xsl:otherwise>
           <xsl:for-each select="../witsml:logData/witsml:data">
             <tr class="listtable">    
               <xsl:call-template name="splitstring">
                 <xsl:with-param name="string" select="."/>
                 <xsl:with-param name="pattern" select="','"/>
               </xsl:call-template>
             </tr>
           </xsl:for-each>
         </xsl:otherwise>
       </xsl:choose>
      </table>
      </xsl:for-each>
      <br/>
      

         </td>
         </tr>
       </table>

      <br/>
      
      <xsl:for-each select="witsml:commonData">
        <table align="center">
        <tr><th colspan="6">Common Data</th> </tr>
        <tr>
        <td class="label">Source</td>
        <td class="dataval"><xsl:value-of select="witsml:commonData/witsml:nameSource"/> </td>
        <td> </td>
        <td class="label">State (Plan/Actual)</td>
        <td class="dataval"><xsl:value-of select="witsml:commonData/witsml:itemState"/> </td>
        <td> </td>
        </tr>
        <tr>
        <td class="label">Time Stamp</td>
        <td class="dataval"><font size="-1">
        <xsl:call-template name="formatdate">
           <xsl:with-param name="strDate" select="witsml:commonData/witsml:dTimStamp"/>
        </xsl:call-template>
        </font> </td>
        <td> </td>
        <td class="label">Creation Time</td>
        <td class="dataval"><font size="-1">
        <xsl:call-template name="formatdate">
           <xsl:with-param name="strDate" select="witsml:commonData/witsml:dTimCreation"/>
        </xsl:call-template>
        </font> </td>
        </tr>
        <tr>
        <td class="label">Last Changed At</td>
        <td class="dataval"><font size="-1">
        <xsl:call-template name="formatdate">
           <xsl:with-param name="strDate" select="witsml:commonData/witsml:dTimLastChange"/>
        </xsl:call-template>
        </font> </td>
        </tr>
        <tr>
        <th colspan="6">Comments</th>
        </tr>
<tr>
        <td colspan="6"><xsl:value-of select="witsml:commonData/witsml:comments"/> </td>
        </tr>
        </table>
      </xsl:for-each>
 <!-- End of CommonData -->      
    </xsl:for-each>
 <!-- End of foreach logs/log -->  
    </body>
    </html>
  </xsl:template>
    
  
  <!--
    Takes a w3C date in yyyy-mm-ddThh:mm:ss.nnn format and converts it to 
    a string  in the format dd mmm yyyy hh:mm:ss
  -->
  <xsl:template name="formatdate">
    <xsl:param name="strDate"/>
    <xsl:if test="string-length($strDate) &gt;= 10">
    <xsl:value-of select="substring($strDate,9,2)"/>
    <xsl:text> </xsl:text>
    <xsl:choose>
    <xsl:when test="substring($strDate,6,2) = '01'">
      <xsl:text>Jan</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '02'">
      <xsl:text>Feb</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '03'">
      <xsl:text>Mar</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '04'">
      <xsl:text>Apr</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '05'">
      <xsl:text>May</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '06'">
      <xsl:text>Jun</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '07'">
      <xsl:text>Jul</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '08'">
      <xsl:text>Aug</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '09'">
      <xsl:text>Sep</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '10'">
      <xsl:text>Oct</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '11'">
      <xsl:text>Nov</xsl:text>
    </xsl:when>
    <xsl:when test="substring($strDate,6,2) = '12'">
      <xsl:text>Dec</xsl:text>
    </xsl:when>
    </xsl:choose>
    <xsl:text> </xsl:text>
    <xsl:value-of select="substring($strDate,1,4)"/>
    </xsl:if>
    <xsl:if test="string-length($strDate) &gt;= 19">
    <xsl:text> </xsl:text>
    <xsl:value-of select="substring($strDate,12,8)"/>
    </xsl:if>
  </xsl:template>
  
  <!--
  Template to split a delimiter separated string into individual HTML table elements
   -->
  <xsl:template name="splitstring">
    <xsl:param name="string" select="''"/>
    <xsl:param name="pattern" select="' '"/>
    <xsl:choose>
      <xsl:when test="not($string)"/>
      <xsl:when test="not($pattern)">
        <xsl:call-template name="_split-characters">
          <xsl:with-param name="string" select="$string"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:call-template name="_split-pattern">
          <xsl:with-param name="string" select="$string"/>
          <xsl:with-param name="pattern" select="$pattern"/>
        </xsl:call-template>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="_split-characters">
    <xsl:param name="string"/>
    <xsl:if test="$string">
      <td>
        <xsl:variable name='value'>
          <xsl:value-of select="substring($string, 1, 1)"/>
	      </xsl:variable>
				<xsl:value-of select="$value"/>
      </td>
      <xsl:call-template name="_split-characters">
        <xsl:with-param name="string" select="substring($string, 2)"/>
      </xsl:call-template>
    </xsl:if>
  </xsl:template>
  <xsl:template name="_split-pattern">
    <xsl:param name="string"/>
    <xsl:param name="pattern"/>
    <xsl:choose>
      <xsl:when test="contains($string, $pattern)">
        <xsl:if test="not(starts-with($string, $pattern))">
          <td align="center">
            <xsl:value-of select="substring-before($string, $pattern)"/>
          </td>
        </xsl:if>
        <xsl:call-template name="_split-pattern">
          <xsl:with-param name="string" select="substring-after($string, $pattern)"/>
          <xsl:with-param name="pattern" select="$pattern"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <td align="center">
          <xsl:value-of select="$string"/>
        </td>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

<!--       				RealTimeData linked to the enumValues file.  		-->
	<xsl:template match="*" mode="RealTimeData">
		<a href="../ancillary/enumValues.xml#RealTimeData::{.}">
			<xsl:value-of select="."/>
		</a>
	</xsl:template>	

<!--       				Unit of Measure Element linked to the unit file.  		-->
	<xsl:template match="*" mode="UnitRef">
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="string" select="."/>
			<xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
		</xsl:call-template>
	</xsl:template>		

<!--       				Uom attribute linked to the unit file.  		-->
	<xsl:template match="*" mode="UomRef">
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="string" select="@uom"/>
			<xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
		</xsl:call-template>
	</xsl:template>


<!--       				Measure value with a unit of measure linked to the unit file.  		-->
	<xsl:template match="*" mode="valueWithUomRef">
		<xsl:value-of select="."/>
		<xsl:text> </xsl:text>
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
		</xsl:call-template>
		<!-- In case this is a coordinate, check for datum. -->
		<xsl:if test="@datum">
			<xsl:text> </xsl:text>
			(<xsl:value-of select="@datum"/>)
		</xsl:if>
	</xsl:template>


	<!-- Template to create a name anchor or to create an href to a uom in the WITSML unit file. -->
	<!-- Add an underscore in front of Uppercase characters in the string. -->
	<!-- Also substitute T (times) and P (per) for period (.) and slash (/). -->
	<xsl:template name="uomRefString">
		<xsl:param name="string" select="@uom"/>    <!-- The uom string. -->
		<xsl:param name="index"  select="1"/>       <!-- The start index in the string. -->
		<xsl:param name="mode"   select="'href'"/>  <!-- 'href' or 'name'. -->
		<xsl:param name="path"   select="''"/>      <!-- Path to the unit file. Only relevant to 'href'. -->
		<xsl:choose>
			<xsl:when test="not($string)">
			<!-- For whatever reason, this value does not have a uom. -->
			<!-- It may be a unitless quantity or an indexed parameter with an optional uom. -->
			</xsl:when>
			<xsl:when test="$index > string-length($string)">
				-------- This is a bad call ----------
				string='<xsl:value-of select="$string"/>'
				index='<xsl:value-of select="$index"/>'
				mode='<xsl:value-of select="$mode"/>'
				path='<xsl:value-of select="$path"/>'
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template name="_nextChar">
					<xsl:with-param name="string" select="$string"/>
					<xsl:with-param name="index" select="$index"/>
					<xsl:with-param name="mode" select="$mode"/>
					<xsl:with-param name="original" select="$string"/>
					<xsl:with-param name="path" select="$path"/>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<!--Template to examine the next character for an upper case letter. -->
	<xsl:template name="_nextChar">
		<xsl:param name="string"/>
		<xsl:param name="index"/>
		<xsl:param name="mode"/>
		<xsl:param name="original"/>
		<xsl:param name="path"/>
		<xsl:variable name="char"><xsl:value-of select="substring($string,$index,1)"/></xsl:variable>
		<xsl:variable name="len"><xsl:value-of select="string-length($string)"/></xsl:variable>
		<xsl:choose>
			<xsl:when test="not($string)"/>
			<xsl:when test="$index > $len">
				<!-- We are finished -->
				<xsl:if test="$mode = 'href'">
					<a href="{$path}#uom::{translate($string,'./','TP')}"><xsl:value-of select="$original"/></a>
				</xsl:if>
				<xsl:if test="$mode = 'name'">
					<a name="uom::{translate($string,'./','TP')}"/>
				</xsl:if>
			</xsl:when>
			<xsl:when test="$char='A'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='B'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='C'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='D'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='E'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='F'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='G'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='H'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='I'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='J'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='K'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='L'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='M'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='N'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='O'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='P'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='Q'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='R'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='S'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='T'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='U'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='V'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='W'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='X'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='Y'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='Z'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:otherwise>
				<xsl:call-template name="_nextChar">
					<xsl:with-param name="string" select="$string"/>
					<xsl:with-param name="index" select="$index +1"/>
					<xsl:with-param name="mode" select="$mode"/>
					<xsl:with-param name="original" select="$original"/>
					<xsl:with-param name="path" select="$path"/>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<!--Template to insert an underscore at the current index while calling _nextChar. -->
	<xsl:template name="_insertChar">
		<xsl:param name="string"/>
		<xsl:param name="index"/>
		<xsl:param name="mode"/>
		<xsl:param name="original"/>
		<xsl:param name="path"/>
		<xsl:variable name="len"><xsl:value-of select="string-length($string)"/></xsl:variable>
		<xsl:call-template name="_nextChar">
			<xsl:with-param name="string" select="concat(substring($string,1,$index - 1),'_',substring($string,$index,$len - $index +1))"/>
			<xsl:with-param name="index" select="$index +2"/>
			<xsl:with-param name="mode" select="$mode"/>
			<xsl:with-param name="original" select="$original"/>
			<xsl:with-param name="path" select="$path"/>
		</xsl:call-template>
	</xsl:template>

</xsl:stylesheet>
