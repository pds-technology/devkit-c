<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Wellbore Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="8" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="8"><font size="+2" color="blue">Wellbore Information</font></th></tr>
		<xsl:for-each select="witsml:wellbores">
			<xsl:for-each select="witsml:wellbore">
				<tr>	<td colspan="4"><font size="+1" color="blue">uidWell: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="4"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="4"><font size="-1" color="blue"><b>uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td>
				 	<td colspan="4"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>	
				<tr>	<td colspan="2"></td>
					<td colspan="2"><font size="-1"><b>Parent Wellbore uid: </b>  <xsl:value-of select="witsml:nameWellbore/@uidRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Parent Wellbore name: </b>  <xsl:value-of select="witsml:nameWellbore"/></font></td></tr>
				<tr>	<td colspan="2"></td>	
					<td colspan="2"><font size="-1"><b>Wellbore no.: </b></font>  <font size="-1" color="black"><xsl:value-of select="witsml:number"/></font></td>						
					<td colspan="2"><font size="-1"><b>Govt no.: </b>  <xsl:value-of select="witsml:numGovt"/></font></td></tr>		
				<tr>	<td colspan="2"></td>
					<td colspan="2"><font size="-1"><b>API Suffix: </b>  <xsl:value-of select="witsml:suffixAPI"/></font></td>
					<td colspan="2"><font size="-1"><b>Status: </b>  <xsl:value-of select="witsml:statusWellbore"/></font></td>
					<td colspan="2"><font size="-1"><b>Purpose: </b>  <xsl:value-of select="witsml:purposeWellbore"/></font></td></tr>
				<tr>	<td colspan="2"></td>
					<td colspan="2"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeWellbore"/></font></td>
					<td colspan="2"><font size="-1"><b>Shape: </b>  <xsl:value-of select="witsml:shape"/></font></td></tr>
 				<tr>	<td colspan="2"></td><td align="right"><font size="-1"><b>Kickoff: </b></font></td>
					<td><font size="-1"><b>date: </b>  <xsl:value-of select="witsml:dTimKickoff"/></font></td>
					<td><font size="-1"><b>md: </b>  <xsl:apply-templates select="witsml:mdKickoff" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>tvd</b>  <xsl:apply-templates select="witsml:tvdKickoff" mode="valueWithUomRef"/></font></td>				
					<td colspan="2"><font size="-1"><b>Planned days: </b>  <xsl:apply-templates select="witsml:dayTarget" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"></td><td align="right"><font size="-1"><b>Planned: </b></font></td>
					<td><font size="-1"><b>md</b>  <xsl:apply-templates select="witsml:mdPlanned" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>tvd</b>  <xsl:apply-templates select="witsml:tvdPlanned" mode="valueWithUomRef"/></font></td>	
					<td align="right"><font size="-1"><b>Subsea Planned: </b></font></td>
					<td><font size="-1"><b>md: </b>  <xsl:apply-templates select="witsml:mdSubSeaPlanned" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>tvd: </b>  <xsl:apply-templates select="witsml:tvdSubSeaPlanned" mode="valueWithUomRef"/></font></td></tr>
 				<tr>	<td colspan="2"></td><td align="right"><font size="-1"><b>Current: </b></font></td>
					<td><font size="-1"><b>md: </b>  <xsl:apply-templates select="witsml:mdCurrent" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>tvd</b>  <xsl:apply-templates select="witsml:tvdCurrent" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td></tr>
				<tr><td></td></tr>
				<tr><td></td></tr>
				<tr><td colspan="2"></td>
					<td colspan="6" align="center"><b>--------------------------------------------------------------------------Common Data-------------------------------------------------------------------------</b></td>
				</tr>
				<tr>	<td colspan="2"></td>
					<td><b>Creation Time Stamp: </b></td><td><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></td>
					<td><b>Last Chg Time Stamp: </b></td><td><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></td>
					<td><b>Item State: </b></td><td><xsl:value-of select="witsml:commonData/witsml:itemState"/></td>
				</tr>
				<tr>	<td colspan="2"></td>
					<td><b>Comments: </b></td><td colspan="5"><xsl:value-of select="witsml:commonData/witsml:comments"/></td>
				</tr>
			</xsl:for-each>	
		</xsl:for-each>	
	</table>
	</body>
	</html>
	</xsl:template>


</xsl:stylesheet>
