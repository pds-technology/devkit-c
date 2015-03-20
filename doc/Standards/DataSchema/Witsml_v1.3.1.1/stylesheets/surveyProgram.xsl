<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Survey Program Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="9" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="9"><font size="+2" color="blue">Survey Program</font></th></tr>
		<xsl:for-each select="witsml:surveyPrograms">
			<xsl:for-each select="witsml:surveyProgram">
				<tr>	<td colspan="3"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Program uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Program Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b>Survey version: </b> <xsl:value-of select="witsml:surveyVer"/></font></td>
					<td colspan="2"><font size="-1"><b>Traj. created: </b> <xsl:value-of select="witsml:dTimTrajProg"/></font></td>
					<td colspan="2"><font size="-1"><b>Engineer: </b> <xsl:value-of select="witsml:engineer"/></font></td>
					<td colspan="4"><font size="-1"><b>Final: </b>  <xsl:value-of select="witsml:final"/></font></td>
					</tr>

				<tr><td colspan="9" align="center"><font size="+1" color="blue">Survey Sections</font></td></tr>
				<!--		Check for a survey section	-->	
				<xsl:for-each select="witsml:surveySection">
					<xsl:apply-templates select="."/>
				</xsl:for-each>

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
	
	<!--									section Template							-->
	<xsl:template match="witsml:surveySection">				
				<tr><td colspan="1"><font size="-1"><b>Section seq.: </b>  <xsl:value-of select="witsml:sequence"/></font></td>
					<td colspan="8"><font size="-1"><b>Name: </b>  <xsl:value-of select="witsml:nameSect"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b></b></font></td>
					<td colspan="2"><font size="-1"><b>MD survey begins: </b>  <xsl:apply-templates select="witsml:mdStart" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>MD survey ends: </b>  <xsl:apply-templates select="witsml:mdEnd" mode="valueWithUomRef"/></font></td>
					<td colspan="4"><font size="-1"><b>Survey company: </b>  <xsl:value-of select="witsml:nameSurveyCompany"/></font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b></b></font></td>
					<td colspan="2"><font size="-1"><b>Tool name: </b>  <xsl:value-of select="witsml:nameTool"/></font></td>
					<td colspan="2"><font size="-1"><b>Tool type: </b>  <xsl:value-of select="witsml:typeTool"/></font></td>
					<td colspan="2"><font size="-1"><b>Overwrite: </b>  <xsl:value-of select="witsml:overwrite"/></font></td>
					<td colspan="2"><font size="-1"><b>Max depth freq.: </b>  <xsl:apply-templates select="witsml:frequencyMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b></b></font></td>
					<td colspan="8"><font size="-1"><b>Model error: </b>  <xsl:value-of select="witsml:modelError"/></font></td></tr>
				<xsl:for-each select="witsml:commonData">
				<tr><td colspan="1"><font size="-1"><b></b></font></td>
					<td colspan="8"><font size="-1"><b>Section state: </b>  <xsl:value-of select="witsml:itemState"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b></b></font></td>
					<td colspan="8"><font size="-1"><b>Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>
				</xsl:for-each>
	</xsl:template>	


	<!--									Common Data Template							-->
	<xsl:template match="witsml:commonData">					
				<tr><td colspan="3"><font size="-1"><b>User ID: </b>  <xsl:value-of select="witsml:nameSource"/></font></td>
					<td colspan="3"><font size="-1"><b>Time Stamp: </b>  <xsl:value-of select="witsml:dTimStamp"/></font></td>
					<td colspan="3"><font size="-1"><b>State: </b> <xsl:value-of select="witsml:itemState"/></font></td></tr>
				<tr><td colspan="9"><font size="-1"><b>Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>
	</xsl:template>		


</xsl:stylesheet>
