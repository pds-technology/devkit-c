<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Message Stylesheet
		</title>
	</head>

	<body>
	<table  border="1" align="center">
		<tr><th colspan="16" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="16"><font size="+2" color="blue">Messages</font></th></tr>
	<xsl:for-each select="witsml:messages">
		<xsl:for-each select="witsml:message">	
				
			<tr>	<td colspan="2"><font size="+1" color="blue"><b>Well</b></font></td>
				<td colspan="4"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:nameWell"/></font></td>
				<td colspan="7"><font size="-1"><b>uid: </b> <xsl:value-of select="@uidWell"/></font></td></tr>
				
			<tr>	<td colspan="2"><font size="+1" color="blue"><b>Wellbore</b></font></td>
				<td colspan="4"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:name"/></font></td>
				<td colspan="7"><font size="-1"><b>uid: </b> <xsl:value-of select="@uid"/></font></td></tr>
				
			<tr>	<td colspan="2"><font size="+1" color="blue"><b>Message</b></font></td>
				<td colspan="4"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:name"/></font></td>
				<td colspan="7"><font size="-1"><b>uid: </b> <xsl:value-of select="@uid"/></font></td></tr>

			<tr>	<td colspan="2"><font size="+1" color="blue"><b>Object: <xsl:value-of select="witsml:objectReference/@object"/></b></font></td>
				<td colspan="4"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:objectReference"/></font></td>
				<td colspan="7"><font size="-1"><b>uidRef: </b> <xsl:value-of select="witsml:objectReference/@uidRef"/></font></td></tr>

			<tr>	<td colspan="2"><font size="+1" color="blue"><b>Sub-Object: <xsl:value-of select="witsml:subObjectReference/@object"/></b></font></td>
				<td colspan="4"><font size="-1"><b>name: </b>   <xsl:value-of select="witsml:subObjectReference"/></font></td>
				<td colspan="7"><font size="-1"><b>uidRef: </b> <xsl:value-of select="witsml:subObjectReference/@uidRef"/></font></td></tr>


			<tr><td colspan="2"></td>
				<td colspan="3"><font size="-1"><b>Act. code: </b>  <xsl:value-of select="witsml:activityCode"/></font></td>
				<td colspan="3"><font size="-1"><b>Probability: </b>  <xsl:value-of select="witsml:warnProbability"/></font></td></tr>
			<tr><td colspan="2"><font size="-1"></font></td>
				<td colspan="3"><font size="-1"><b>MD: </b>  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/></font></td>
				<td colspan="3"><font size="-1"><b>MD bit: </b>  <xsl:apply-templates select="witsml:mdBit" mode="valueWithUomRef"/></font></td></tr>
			<tr><td colspan="2"><font size="-1"></font></td>
				<td colspan="3"><font size="-1"><b>Msg type: </b>  <xsl:value-of select="witsml:typeMessage"/></font></td>
				<td colspan="3"><font size="-1"><b>Severity: </b>  <xsl:value-of select="witsml:severity"/></font></td></tr>
			<tr><td colspan="2"></td>
				<td colspan="1" align="right"><font size="-1"><b>Param: </b></font></td>
				<td colspan="1"><font size="-1"><b>index: </b>  <xsl:value-of select="witsml:param/@index"/></font></td>
				<td colspan="2"><font size="-1"><b>name: </b>  <xsl:value-of select="witsml:param/@name"/></font></td>
				<td colspan="3"><font size="-1"><b>value: </b>  <xsl:apply-templates select="witsml:param" mode="valueWithUomRef"/></font></td></tr>
			<tr><td colspan="2"></td>
				<td colspan="14"><font size="-1"><b>Message: </b>  <xsl:value-of select="witsml:messageText"/></font></td></tr>
				
				<!--      Common Data   -->
				<tr><td colspan="2"></td>
					<td colspan="12" align="center"><font size="-1" color="blue">Common Data</font></td></tr>
				<tr><td colspan="2"></td>
					<td colspan="2"><font size="-1"><b>Creation Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></font></td>
					<td colspan="2"><font size="-1"><b>Last Chg Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></font></td>
					<td colspan="4"><font size="-1"><b>State: </b><xsl:value-of select="witsml:commonData/witsml:itemState"/></font></td></tr>
				<tr><td colspan="2"></td>
					<td colspan="8"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:commonData/witsml:comments"/></font></td></tr>

			</xsl:for-each>
		</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>

	
</xsl:stylesheet>
