<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131"> 

      <!-- Author: John Shields, BHI, 2004  -->      

	<xsl:include href="all_object_utility_templates.xsl"/>    

  <xsl:output method="html"/>	
	<xsl:template match="/">
		<html>
		<head>
		  <link rel='stylesheet' href='../stylesheets/witsml.css' type='text/css' />
		</head>
		<body>
		<xsl:for-each select="witsml:logs/witsml:log">
			<table align="center">
			<tr >
				<th class='mainheader' colspan="6">WITSML Log</th>
			</tr>
			<tr>
			<td class='label'>Well Name:</td>
			<td class='dataval'><xsl:value-of select="witsml:nameWell"/></td>
			<td class='label'>Well Identifier</td>
			<td class='dataval'><xsl:value-of select="@uidWell"/></td>
			</tr>
			<tr>
			<td class='label'>Wellbore Name</td>
			<td class='dataval'><xsl:value-of select="witsml:nameWellbore"/></td>
			<td class='label'>Wellbore Identifier</td>
			<td class='dataval'><xsl:value-of select="@uidWellbore"/></td>
			</tr>
			<tr>
			<td class='label'>Log Name</td>
			<td class='dataval'><xsl:value-of select="witsml:name"/></td>
			<td class='label'>Log Identifier</td>
			<td class='dataval'><xsl:value-of select="@uid"/></td>
			</tr>


			<tr><th colspan='4'>Log Header</th></tr>	
			<tr>
			<td class='label'>Service Company</td>
			<td class='dataval'><xsl:value-of select="witsml:serviceCompany"/></td>
			<td class='label'>Run Number</td>
			<td class='dataval'><xsl:value-of select="witsml:runNumber"/></td>
			</tr>
			<tr>
			<td class='label'>Description</td>
			<td class='dataval'><xsl:value-of select="witsml:description"/></td>
			<td class='label'>Creation Date</td>
			<td class='dataval'><font size='-1'>
			<xsl:call-template name="formatdate">
			 <xsl:with-param name="strDate" select="witsml:creationDate" />
			</xsl:call-template></font></td>
			</tr>
			  <tr>
			  <td class='label'>Step Increment</td>
			  <td class='dataval'><xsl:value-of select="witsml:stepIncrement"/> <xsl:apply-templates select="witsml:indexUnits" mode="UnitRef"/></td>
			  <td class='label'>Index</td>
			  <td class='dataval'><xsl:value-of select="witsml:indexType"/></td>
			  <td> </td>
			  </tr>
			<tr>
			<td class='label'>Index Curve: Mnemonic</td>
			<td class='dataval'><xsl:value-of select="witsml:indexCurve"/></td>
			<td class='label'>Index Curve: Column</td>
			<td class='dataval'><xsl:value-of select="witsml:indexCurve/@columnIndex"/></td>
			</tr>
			<tr>
			<td class='label'>Start Index</td>
			<td class='dataval'><xsl:apply-templates select="witsml:startIndex" mode="valueWithUomRef"/></td>
			<td class='label'>End Index</td>
			<td class='dataval'><xsl:apply-templates select="witsml:endIndex" mode="valueWithUomRef"/></td>
			</tr>
			<tr>
			<td class='label'>Direction</td>
			<td class='dataval'><xsl:value-of select="witsml:direction"/></td>
			<td class='label'>Null Value</td>
			<td class='dataval'><xsl:value-of select="witsml:nullValue"/></td>
			</tr>		
			<!--
			 Output Log Header Parameters if there are any
			 -->
			<xsl:choose>
			<xsl:when test="logParam">
				<tr><th colspan='6'>Log Header Parameters</th></tr>		
				<tr><td colspan='6' align='center'><table align='center'>
				<tr><th>Index</th><th>Name</th><th>Value</th><th>Units</th><th colspan='2'>Description</th></tr>
				<xsl:for-each select="witsml:logParam">	
					<tr class='listtable'>
					<td align='center'><xsl:value-of select="@index"/></td>
					<td align='center'><xsl:value-of select="@name"/></td>	
					<td align='center'><xsl:value-of select="."/></td>
					<td align='center'><xsl:apply-templates select="." mode="UomRef"/></td>
					<td align='center'><xsl:value-of select="@description"/></td>
					</tr>
				</xsl:for-each>
				</table><br /></td></tr>
			</xsl:when>
			</xsl:choose>
			
			<!--
			 Output Log Curve Info Data
			 -->
			<tr><th colspan='6'>Log Curve Information</th></tr>   
			<tr><td colspan='6' align='center'>
			<table>
			<tr>	<th>Index</th>
				<th>Mnemonic</th>
				<th>Class</th>
				<th>Units</th>
				<th>Alias</th>
				<th>Null Val</th>
				<th>Min</th>
				<th>Max</th>
				<th>State</th>
				<th>Type</th>
				<th>Offset</th>
				<th>Description</th></tr> 
			<xsl:for-each select="witsml:logCurveInfo">	
			<xsl:sort select="witsml:columnIndex" data-type="number"/>
				<tr class='listtable'>
				<td align='center'><xsl:value-of select="witsml:columnIndex"/></td>
				<td align='center'><xsl:value-of select="witsml:mnemonic"/></td>
				<td align='center'><xsl:apply-templates select="witsml:classWitsml" mode="RealTimeData"/></td>	
				<td align='center'><xsl:apply-templates select="witsml:unit" mode="UnitRef"/></td>
				<td align='center'><xsl:value-of select="witsml:mnemAlias"/></td>
				<td align='center'><xsl:value-of select="witsml:nullValue"/></td>
				<td align='center'><xsl:apply-templates select="witsml:minIndex" mode="valueWithUomRef"/></td>
				<td align='center'><xsl:apply-templates select="witsml:maxIndex" mode="valueWithUomRef"/></td>
				<td align='center'><xsl:value-of select="witsml:traceState"/></td>
				<td align='center'><xsl:value-of select="witsml:typeLogData"/></td>
				<td align='center'><xsl:apply-templates select="witsml:sensorOffset" mode="valueWithUomRef"/></td>
				<td align='center'><xsl:value-of select="witsml:curveDescription"/></td>
				</tr>
		 	</xsl:for-each>
		 	</table>

		 	</td></tr>
		 	</table>

		 	<br/>
			<!--
			  Set up a sub-table to display the logData elements
			  -->
			<table>
			<tr><th colspan='100%'>Log Data</th></tr>
			<tr>
			<xsl:for-each select="witsml:logHeader/witsml:logCurveInfo">
				<xsl:sort select="witsml:columnIndex" data-type="number"/>
				<th align='center'><xsl:value-of select="witsml:mnemonic" /></th>
			</xsl:for-each>
			</tr>
			<tr>
			<xsl:for-each select="witsml:logHeader/witsml:logCurveInfo">
				<xsl:sort select="witsml:columnIndex" data-type="number"/>
				<th align='center'><xsl:apply-templates select="witsml:unit" mode="UnitRef"/></th>
			</xsl:for-each>
			</tr>
			
			<!--
			 Print out the data rows in an HTML table
			 -->
			<xsl:for-each select="witsml:logData/witsml:data">
				<tr class='listtable'>		
				<xsl:call-template name="splitstring">
					<xsl:with-param name="string" select="."/>
					<xsl:with-param name="pattern" select="','"/>
				</xsl:call-template>			
				
				</tr>
			</xsl:for-each>
			</table>
			<br/>
			
			<table align="center">
				<tr><th colspan='3'>Common Data</th></tr>
				<tr>
				<td class='label'>State (Plan/Actual)</td>
				<td class='dataval'><xsl:value-of select="witsml:commonData/witsml:itemState"/></td>
				<td> </td>
				</tr>
				<tr>
				<td class='label'>Creation Time</td>
				<td class='dataval'><font size='-1'>
				<xsl:call-template name="formatdate">
				   <xsl:with-param name="strDate" select="witsml:commonData/witsml:dTimCreation" />
				</xsl:call-template>
				</font></td>
				</tr>
				<tr>
				<td class='label'>Last Changed At</td>
				<td class='dataval'><font size='-1'>
				<xsl:call-template name="formatdate">
				   <xsl:with-param name="strDate" select="witsml:commonData/witsml:dTimLastChange" />
				</xsl:call-template>
				</font></td>
				</tr>
				<tr>
				<th colspan='6'>Comments</th>
				</tr><tr>
				<td colspan='6'><xsl:value-of select="witsml:commonData/witsml:comments"/></td>
				</tr>
			</table> <!-- End of CommonData -->			
		</xsl:for-each> <!-- End of foreach logs/log -->	
		</body>
		</html>
	</xsl:template>	
	
	
	<!--
	  Takes a w3C date in yyyy-mm-ddThh:mm:ss.nnn format and converts it to 
	  a string  in the format dd mmm yyyy hh:mm:ss
	-->
	<xsl:template name="formatdate">
	  <xsl:param name="strDate" />
	  <xsl:if test="string-length($strDate) &gt;= 10">
		<xsl:value-of select="substring($strDate,9,2)" />
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
		<xsl:value-of select="substring($strDate,1,4)" />
	  </xsl:if>
	  <xsl:if test="string-length($strDate) &gt;= 19">
		<xsl:text> </xsl:text>
		<xsl:value-of select="substring($strDate,12,8)" />
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
				<xsl:value-of select="substring($string, 1, 1)"/>
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

</xsl:stylesheet>
