<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Wellbore Geometry Stylesheet
		</title>
	</head>
	<body>
	<table  border="1" align="center">
		<tr><th colspan="9" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="9"><font size="+2" color="blue">Wellbore Geometry Information</font></th></tr>
		<xsl:for-each select="witsml:wbGeometrys">
			<xsl:for-each select="witsml:wbGeometry">
			<tr>	<td colspan="3"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
				<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
			<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
				<td colspan="5"><font size="-1" color="blue"><b>WbGeometry uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
			<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>WB Geometry Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
			<tr>	<td colspan="4"><font size="-1"><b>Date/time of report: </b></font>  <xsl:value-of select="witsml:dTimReport"/></td></tr>
				
			<tr>	<td colspan="2"><font size="-1"><b>MD at bottom: </b></font>  <xsl:apply-templates select="witsml:mdBottom" mode="valueWithUomRef"/></td>
				<td colspan="2"><font size="-1"><b>Air gap: </b></font>  <xsl:apply-templates select="witsml:gapAir" mode="valueWithUomRef"/></td>
				<td colspan="2"><font size="-1"><b>Water depth: </b></font>  <xsl:apply-templates select="witsml:depthWaterMean" mode="valueWithUomRef"/></td>
			</tr>	

				<!--		Check for Wellbore Geometry Section	-->	
				<xsl:for-each select="witsml:wbGeometrySection">
					<tr><td colspan="9" align="center"><font size="-1" color="blue"><b>Wellbore Geometry Section - </b>(uid= <xsl:value-of select="@uid"/>)</font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--      Common Data   -->
				<tr><td colspan="8" align="center"><font size="-1" color="blue">Common Data</font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Creation Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></font></td>
					<td colspan="2"><font size="-1"><b>Last Chg Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></font></td>
					<td colspan="4"><font size="-1"><b>State: </b><xsl:value-of select="witsml:commonData/witsml:itemState"/></font></td></tr>
				<tr><td colspan="8"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:commonData/witsml:comments"/></font></td></tr>

				<tr><td colspan="8" align="center"><font size="-1"><b>--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------</b></font></td></tr>

			</xsl:for-each>
			
		</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>

	
	<!--									Wellbore Geometry Section Template							-->
	<xsl:template match="witsml:wbGeometrySection">					
				<tr><td colspan="4"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeHoleCasing"/></font></td>
					<td colspan="2"><font size="-1"><b>Grade: </b>  <xsl:value-of select="witsml:grade"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>MD top: </b></font>  <xsl:apply-templates select="witsml:mdTop" mode="valueWithUomRef"/></td>
					<td colspan="2"><font size="-1"><b>MD bottom: </b></font>  <xsl:apply-templates select="witsml:mdBottom" mode="valueWithUomRef"/></td>
					<td colspan="2"><font size="-1"><b>TVD top: </b></font>  <xsl:apply-templates select="witsml:tvdTop" mode="valueWithUomRef"/></td>
					<td colspan="2"><font size="-1"><b>TVD bottom: </b></font>  <xsl:apply-templates select="witsml:tvdBottom" mode="valueWithUomRef"/></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Inner diameter: </b></font>  <xsl:apply-templates select="witsml:idSection" mode="valueWithUomRef"/></td>
					<td colspan="2"><font size="-1"><b>Outer diameter: </b></font>  <xsl:apply-templates select="witsml:odSection" mode="valueWithUomRef"/></td>
					<td colspan="3"><font size="-1"><b>Wt. per unit length of casing section: </b></font>  <xsl:apply-templates select="witsml:wtPerLen" mode="valueWithUomRef"/></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Curve Conductor?: </b></font>  <xsl:value-of select="witsml:curveConductor"/></td>
					<td colspan="2"><font size="-1"><b>Max pass through dia.: </b></font>  <xsl:apply-templates select="witsml:diaDrift" mode="valueWithUomRef"/></td>
					<td colspan="3"><font size="-1"><b>Friction factor: </b></font>  <xsl:value-of select="witsml:factFric"/></td></tr>
	</xsl:template>		


</xsl:stylesheet>
