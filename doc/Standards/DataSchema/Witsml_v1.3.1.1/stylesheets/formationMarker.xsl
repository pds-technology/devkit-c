<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Formation Marker Stylesheet
		</title>
	</head>
	<body>
	<table  border="1" align="center">
		<tr><th colspan="9" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="9"><font size="+2" color="blue">Formation Marker Information</font></th></tr>
		<xsl:for-each select="witsml:formationMarkers">
			<xsl:for-each select="witsml:formationMarker">
			<tr>	<td colspan="3"><font size="+1" color="blue">uidWell: </font>  <xsl:value-of select="@uidWell"/></td>
				<td colspan="6"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
			<tr><td colspan="3"><font size="-1" color="blue"><b>Wellbore: </b></font>  <xsl:value-of select="@uidWellbore"/></td>
				<td colspan="6"><font size="-1" color="blue"><b>Marker: </b></font>  <xsl:value-of select="@uid"/></td></tr>
			<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
				<td colspan="6"><font size="-1" color="blue"><b>Marker Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
			<tr><td colspan="1" align="right"><font size="-1"><b>MD: </b></font></td>
				<td colspan="2"><font size="-1">Prognosed: </font>  <xsl:apply-templates select="witsml:mdPrognosed" mode="valueWithUomRef"/></td>
				<td colspan="2"><font size="-1">Top Sample: </font>  <xsl:apply-templates select="witsml:mdTopSample" mode="valueWithUomRef"/></td>
				<td colspan="4"><font size="-1">Top Log: </font>  <xsl:apply-templates select="witsml:mdLogSample" mode="valueWithUomRef"/></td></tr>
			<tr><td colspan="1" align="right"><font size="-1"><b>TVD: </b></font></td>
				<td colspan="2"><font size="-1">Prognosed: </font>  <xsl:apply-templates select="witsml:tvdPrognosed" mode="valueWithUomRef"/></td>
				<td colspan="2"><font size="-1">Top Sample: </font>  <xsl:apply-templates select="witsml:tvdTopSample" mode="valueWithUomRef"/></td>
				<td colspan="4"><font size="-1">Top Log: </font>  <xsl:apply-templates select="witsml:tvdLogSample" mode="valueWithUomRef"/></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Bed Thickness: </b>  <xsl:apply-templates select="witsml:thicknessBed" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Apparent Thickness: </b>  <xsl:apply-templates select="witsml:thicknessApparent" mode="valueWithUomRef"/></font></td>
					<td colspan="4"><font size="-1"><b>Perpen. Thickness: </b>  <xsl:apply-templates select="witsml:thicknessPerpen" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Interpreted Dip: </b>  <xsl:apply-templates select="witsml:dip" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Interpreted Down Dip Dir.: </b>  <xsl:apply-templates select="witsml:dipDirection" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="4"><font size="-1"><b>Geological Age Class.: </b>  <xsl:value-of select="witsml:chronostratigraphic"/></font></td>
					<td colspan="5"><font size="-1"><b>Formation: </b>  <xsl:value-of select="witsml:nameFormation"/></font></td></tr>
				<tr>	<td colspan="9"><font size="-1"><b>Description: </b>  <xsl:value-of select="witsml:description"/></font></td></tr>
				
				<!--      Common Data   -->
				<tr><td colspan="8" align="center"><font size="+1" color="blue">Common Data</font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Creation Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></font></td>
					<td colspan="2"><font size="-1"><b>Last Chg Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></font></td>
					<td colspan="4"><font size="-1"><b>State: </b><xsl:value-of select="witsml:commonData/witsml:itemState"/></font></td></tr>
				<tr><td colspan="8"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:commonData/witsml:comments"/></font></td></tr>

			</xsl:for-each>
		</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>
	
</xsl:stylesheet>
