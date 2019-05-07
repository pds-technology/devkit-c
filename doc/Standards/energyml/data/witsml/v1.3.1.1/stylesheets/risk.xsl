<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:output method="html" />

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Risk Object
		</title>
	</head>

	<body>
	<table  border="2" align="center">
	<xsl:for-each select="witsml:risks/witsml:risk">
		<tr>
			<th colspan="6" >
				<font size="+2" color="blue">
					WITSML Risk Object
				</font>
			</th>
		</tr>
				
		<tr>	<td colspan="1"><font size="+1" color="blue"><b>Well</b></font></td>
			<td colspan="3"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:nameWell"/></font></td>
			<td colspan="2"><font size="-1"><b>uid: </b> <xsl:value-of select="@uidWell"/></font></td></tr>
			
		<tr>	<td colspan="1"><font size="+1" color="blue"><b>Wellbore</b></font></td>
			<td colspan="3"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:name"/></font></td>
			<td colspan="2"><font size="-1"><b>uid: </b> <xsl:value-of select="@uid"/></font></td></tr>
			
		<tr>	<td colspan="1"><font size="+1" color="blue"><b>Message</b></font></td>
			<td colspan="3"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:name"/></font></td>
			<td colspan="2"><font size="-1"><b>uid: </b> <xsl:value-of select="@uid"/></font></td></tr>

		<tr>	<td colspan="1"><font size="+1" color="blue"><b>Object: <xsl:value-of select="witsml:objectReference/@object"/></b></font></td>
			<td colspan="3"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:objectReference"/></font></td>
			<td colspan="2"><font size="-1"><b>uidRef: </b> <xsl:value-of select="witsml:objectReference/@uidRef"/></font></td></tr>
		<tr>
			<td colspan="2"><B>Type: </B><xsl:value-of select="witsml:type"/></td>
			<td colspan="2"><B>Sub Category: </B><xsl:value-of select="witsml:subCategory"/></td>
			<td colspan="2"><B>Extended Category: </B><xsl:value-of select="witsml:extendCategory"/></td>
		</tr>
		<tr>
			<td colspan="2"><B>Affected Personnel: </B><xsl:value-of select="witsml:affectedPersonnel"/></td>
			<td colspan="2"><B>Start Time Stamp: </B><xsl:value-of select="witsml:dTimStart"/></td>
			<td colspan="2"><B>End Time Stamp: </B><xsl:value-of select="witsml:dTimEnd"/></td>
		</tr>
		<tr>
			<td colspan="2"><B>Start MD of Hole: </B><xsl:apply-templates select="witsml:mdHoleStart" mode="valueWithUomRef"/></td>
			<td colspan="2"><B>End MD of Hole: </B><xsl:apply-templates select="witsml:mdHoleEnd" mode="valueWithUomRef"/></td>
			<td colspan="2"><B>Hole Diameter: </B><xsl:apply-templates select="witsml:diaHole" mode="valueWithUomRef"/></td>
		</tr>
		<tr>
			<td colspan="2"><B>Start TVD of Hole: </B><xsl:apply-templates select="witsml:tvdHoleStart" mode="valueWithUomRef"/></td>
			<td colspan="2"><B>End TVD of Hole: </B><xsl:apply-templates select="witsml:tvdHoleEnd" mode="valueWithUomRef"/></td>
			<td colspan="2"><B>Severity Level: </B><xsl:value-of select="witsml:severityLevel"/></td>
		</tr>
		<tr>
			<td colspan="2"><B>Start MD of Bit: </B><xsl:apply-templates select="witsml:mdBitStart" mode="valueWithUomRef"/></td>
			<td colspan="2"><B>End MD of Bit: </B><xsl:apply-templates select="witsml:mdBitEnd" mode="valueWithUomRef"/></td>
			<td colspan="2"><B>Probability Level: </B><xsl:value-of select="witsml:probabilityLevel"/></td>
		</tr>
		<tr>
			<td colspan="6"><B>Summary: </B><xsl:value-of select="witsml:summary"/></td>
		</tr>
		<tr>
			<td colspan="6"><B>Details: </B><xsl:value-of select="witsml:details"/></td>
		</tr>
		<tr>
			<td colspan="6"><B>Identification: </B><xsl:value-of select="witsml:identification"/></td>
		</tr>
		<tr>
			<td colspan="6"><B>Contingency: </B><xsl:value-of select="witsml:contingency"/></td>
		</tr>
		<tr>
			<td colspan="6"><B>Mitigation: </B><xsl:value-of select="witsml:mitigation"/></td>
		</tr>


				<!--      Common Data   -->
				<tr><td colspan="8" align="center"><font size="+1" color="blue">Common Data</font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Creation Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></font></td>
					<td colspan="2"><font size="-1"><b>Last Chg Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></font></td>
					<td colspan="4"><font size="-1"><b>State: </b><xsl:value-of select="witsml:commonData/witsml:itemState"/></font></td></tr>
				<tr><td colspan="8"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:commonData/witsml:comments"/></font></td></tr>
	</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>


</xsl:stylesheet>
