<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Realtime Stylesheet
		</title>
	</head>

	<body>
	<table  border="1" align="center">
		<tr><th colspan="16" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="16"><font size="+2" color="blue">Well Realtime Information</font></th></tr>

		<!--     First do all of the headers     -->
		<tr><th colspan="16"><font size="+2" color="blue">Realtime Headers</font></th></tr>
		<xsl:for-each select="/witsml:realtimes/witsml:realtime">
			<xsl:apply-templates select="witsml:realtimeHeader"/>
		</xsl:for-each>

		<!--     Now do everything without the headers.     -->
		<tr><th colspan="16"><font size="+2" color="blue">Individual Realtimes</font></th></tr>
		<xsl:for-each select="/witsml:realtimes/witsml:realtime">
			<tr>	<td colspan="4"><font size="+1" color="blue">Well Uid: <xsl:value-of select="@uidWell"/></font></td>
				<td colspan="4"><font size="+1" color="blue">Wellbore Uid: <xsl:value-of select="@uidWellbore"/></font></td>
				<td colspan="4"><font size="+1" color="blue">Subscription: <xsl:value-of select="@idSub"/></font></td>
				<td colspan="4"><font size="+1" color="blue">Sequence: <xsl:value-of select="witsml:sequence"/></font></td>
			</tr>
			<tr>	<td colspan="1"/>
				<td colspan="5"><font size="-1"><b>Time Stamp: </b> <xsl:value-of select="witsml:dTim"/></font></td>
				<td colspan="5"><font size="-1"><b>Measured Depth: </b>  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/></font></td>
				<td colspan="5"><font size="-1"><b>Activity Code: </b> <xsl:value-of select="witsml:activityCode"/></font></td>
			</tr>
			<xsl:apply-templates select="witsml:channel"/>
			<xsl:apply-templates select="witsml:record"/>

		</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>


	<!--				Header Template	-->
	<xsl:template match="witsml:realtimeHeader">
			<tr>	<td colspan="2"><font size="+1" color="blue">Header: </font></td>
				<td colspan="7"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td>
				<td colspan="7"><font size="+1" color="blue">Wellbore Name: </font>  <xsl:value-of select="witsml:nameWellbore"/></td>
			</tr>
			<tr>	<td colspan="2"/>
				<td colspan="3"><font size="+1" color="blue">Well Uid: <xsl:value-of select="../@uidWell"/></font></td>
				<td colspan="4"><font size="+1" color="blue">Subscription: <xsl:value-of select="../@idSub"/></font></td>
				<td colspan="7"><font size="+1" color="blue">Wellbore Uid: <xsl:value-of select="../@uidWellbore"/></font></td>
			</tr>
			<tr>	<td colspan="2"/>
				<td colspan="5"><font size="-1"><b>Service Company: </b> <xsl:value-of select="witsml:serviceCompany"/></font></td>
				<td colspan="5"><font size="-1"><b>Creation Date: </b> <xsl:value-of select="witsml:creationDate"/></font></td>
				<td colspan="4"><font size="-1"><b>Run Number: </b> <xsl:value-of select="witsml:runNumber"/></font></td>
			</tr>
			<tr>	<td colspan="2"/>
				<td colspan="14"><font size="-1"><b>Desc: </b> <xsl:value-of select="witsml:description"/></font></td>
			</tr>
			<xsl:for-each select="witsml:interval">
				<tr>	<td colspan="2"/>
					<xsl:apply-templates select="."/>
				</tr>
			</xsl:for-each>
			<xsl:for-each select="witsml:groupDefinition">
				<xsl:apply-templates select="."/>
			</xsl:for-each>
	</xsl:template>

	<xsl:template match="witsml:groupDefinition">
			<tr>	<td colspan="1"/>
				<td colspan="2"><font size="-1"><b>Group ID: </b>   <xsl:value-of select="witsml:id"/></font></td>
				<td colspan="2"><font size="-1"><b>Multiplexed: </b>  <xsl:value-of select="witsml:multiplexed"/></font></td>
				<td colspan="3"><font size="-1"><b>Persisted As log: </b>  <xsl:apply-templates select="witsml:persistedAsLog" mode="refNameString"/></font></td>
				<td colspan="3"><font size="-1"><b>Persisted As wellLog: </b>  <xsl:apply-templates select="witsml:persistedAsLog" mode="persistedAsWellLog"/></font></td>
				<td colspan="5"><font size="-1"><b>comment: </b>  <xsl:value-of select="witsml:comment"/></font></td>
			</tr>
			<xsl:for-each select="witsml:interval">
				<tr>	<td colspan="2"/>
					<xsl:apply-templates select="."/>
				</tr>
			</xsl:for-each>
			<xsl:for-each select="witsml:channelDefinition">
				<xsl:apply-templates select="."/>
			</xsl:for-each>
	</xsl:template>

	<xsl:template match="*" mode="refNameString">
		<xsl:value-of select="."/>
		<xsl:text>(uidRef=</xsl:text><xsl:value-of select="@uidRef"/><xsl:text>)</xsl:text>
	</xsl:template>

	<xsl:template match="witsml:channelDefinition">
			<tr>	<td colspan="2"/>
				<td colspan="2"><font size="-1"><b>Channel Def: </b></font></td>
				<td colspan="2"><font size="-1"><b>Mnemonic: </b>  <xsl:value-of select="witsml:mnemonic"/></font></td>
				<td colspan="2"><font size="-1"><b>Data Type: </b>  <xsl:value-of select="witsml:dataType"/></font></td>
				<td colspan="4"><font size="-1"><b>Witsml Class: </b>  <xsl:apply-templates select="witsml:classWitsml" mode="RealTimeData"/></font></td>
				<td colspan="4"><font size="-1"><b>Alias: </b>  <xsl:value-of select="witsml:mnemAlias"/></font></td>
			</tr>
			<tr>	<td colspan="4"/>
				<td colspan="4"><font size="-1"><b>Column Index: </b>  <xsl:value-of select="witsml:columnIndex"/></font></td>
				<td colspan="4"><font size="-1"><b>Unit: </b>  <xsl:value-of select="witsml:unit"/></font></td>
			</tr>
			<tr>	<td colspan="4"/>
				<td colspan="4"><font size="-1"><b>Sensor Offset: </b>  <xsl:apply-templates select="witsml:sensorOffset" mode="valueWithUomRef"/></font></td>
				<td colspan="4"><font size="-1"><b>Data Source: </b>  <xsl:value-of select="witsml:dataSource"/></font></td>
			</tr>
			<tr>	<td colspan="4"/>
				<td colspan="12"><font size="-1"><b>Desc: </b>  <xsl:value-of select="witsml:description"/></font></td>
			</tr>
			<xsl:call-template name="axisDefinition"/>
			<xsl:for-each select="witsml:interval">
				<tr>	<td colspan="4"/>
					<xsl:apply-templates select="."/>
				</tr>
			</xsl:for-each>
	</xsl:template>

	<xsl:template name="axisDefinition">
		<xsl:if test="witsml:axisDefinition">
			<tr>	<td colspan="4"/>
				<td colspan="4">
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
				</td>
			</tr>
		</xsl:if>
	</xsl:template>

	<xsl:template match="witsml:interval">
				<td colspan="2"><font size="-1"><b>Interval: </b></font></td>
				<td colspan="2"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:type"/></font></td>
				<td colspan="2"><font size="-1"><b>Method: </b>  <xsl:value-of select="witsml:method"/></font></td>
				<td colspan="4"><font size="-1"><b>Distance Interval: </b>  <xsl:apply-templates select="witsml:distanceInterval" mode="valueWithUomRef"/></font></td>
				<td colspan="4"><font size="-1"><b>Time Interval: </b>  <xsl:apply-templates select="witsml:timeInterval" mode="valueWithUomRef"/></font></td>
	</xsl:template>
	

	<xsl:template match="witsml:channel">				
			<tr>	<td colspan="1"></td>
				<td colspan="2"><font size="-1"><b>Channel: </b></font></td>
				<td colspan="3"><font size="-1"><b>Group ID: </b></font>  <xsl:value-of select="witsml:id"/></td>
				<td colspan="3"><font size="-1"><b>Mnemonic: </b></font>  <xsl:value-of select="witsml:mnemonic"/></td>
				<td colspan="5"><font size="-1"><b>Data Density: </b>  <xsl:apply-templates select="witsml:densData" mode="valueWithUomRef"/></font></td>
			</tr>			
			<tr>	<td colspan="3"></td>
				<td colspan="6"><font size="-1"><b>Time Stamp: </b></font>  <xsl:value-of select="witsml:dTim"/></td>
				<td colspan="5"><font size="-1"><b>Measured Depth: </b>  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/></font></td>
			</tr>
			<tr>	<td colspan="3"></td>
				<td colspan="3"><font size="-1"><b>Value: </b>  <xsl:apply-templates select="witsml:value" mode="valueWithUomRef"/></font></td>
				<td colspan="6"><font size="-1"><b>Data Qaulity: </b></font>  <xsl:value-of select="witsml:qualData"/></td>
				<td colspan="5"><font size="-1"><b>fet: </b>  <xsl:apply-templates select="witsml:fet" mode="valueWithUomRef"/></font></td>
			</tr>
	</xsl:template>	
	

	<xsl:template match="witsml:record">
		<tr>	<td colspan="1"></td>
			<td colspan="2"><font size="-1"><b>Record: </b></font></td>
			<td colspan="2"><font size="-1"><b>Group ID: </b></font>  <xsl:value-of select="witsml:id"/></td>
			<td colspan="2"><font size="-1"><b>Sequence #: </b></font>  <xsl:value-of select="witsml:seq"/></td>
			<td colspan="5"><font size="-1"><b>Time Stamp: </b></font>  <xsl:value-of select="witsml:dTim"/></td>
			<td colspan="4"><font size="-1"><b>Measured Depth: </b>  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/></font></td>
		</tr>
		<tr>	<td colspan="3"></td>
			<xsl:call-template name="record-mne">
				<xsl:with-param name="group"><xsl:value-of select="witsml:id"/></xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="witsml:value"/></xsl:with-param>
			</xsl:call-template>
		</tr>
		<tr>	<td colspan="3"></td>
			<xsl:call-template name="record-value">
				<xsl:with-param name="group"><xsl:value-of select="witsml:id"/></xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="witsml:value"/></xsl:with-param>
			</xsl:call-template>
		</tr>
	</xsl:template>	


	<!-- Recursive template to do a heading for each value in a record string. -->
	<xsl:template name="record-mne">
		<xsl:param name="group"/>	<!-- The group id. -->
		<xsl:param name="value"/>	<!-- Comma delimited string of values. -->
		<xsl:param name="column">1</xsl:param>
		<xsl:choose>
			<xsl:when test="$value=''">
				<!-- We are finished. -->
			</xsl:when>
			<xsl:when test="contains($value,',')">
				<!-- More than one value remaining. -->
				<td>
					<xsl:value-of select="/witsml:realtimes/witsml:realtime/witsml:realtimeHeader/witsml:groupDefinition[witsml:id=$group]/witsml:channelDefinition[witsml:columnIndex=$column]/witsml:mnemonic"/>
				</td>
				<xsl:call-template name="record-mne">
					<xsl:with-param name="group"><xsl:value-of select="$group"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="substring-after($value,',')"/></xsl:with-param>
					<xsl:with-param name="column"><xsl:value-of select="$column +1"/></xsl:with-param>
				</xsl:call-template>		
			</xsl:when>
			<xsl:otherwise>
				<!-- One more value. -->
				<td>
					<xsl:value-of select="/witsml:realtimes/witsml:realtime/witsml:realtimeHeader/witsml:groupDefinition[witsml:id=$group]/witsml:channelDefinition[witsml:columnIndex=$column]/witsml:mnemonic"/>
				</td>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<!-- Recursive template to do each value in a record string. -->
	<xsl:template name="record-value">
		<xsl:param name="group"/>	<!-- The group id. -->
		<xsl:param name="value"/>
		<xsl:param name="column">1</xsl:param>
		<xsl:choose>
			<xsl:when test="$value=''">
				<!-- We are finished. -->
			</xsl:when>
			<xsl:when test="contains($value,',')">
				<!-- More than one value remaining. -->
				<td>
					<xsl:value-of select="substring-before($value,',')"/>
					<xsl:text> </xsl:text>
					<xsl:apply-templates select="/witsml:realtimes/witsml:realtime/witsml:realtimeHeader/witsml:groupDefinition[witsml:id=$group]/witsml:channelDefinition[witsml:columnIndex=$column]/witsml:unit" 
						mode="UnitRef"/>
				</td>
				<xsl:call-template name="record-value">
					<xsl:with-param name="group"><xsl:value-of select="$group"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="substring-after($value,',')"/></xsl:with-param>
					<xsl:with-param name="column"><xsl:value-of select="$column +1"/></xsl:with-param>
				</xsl:call-template>		
			</xsl:when>
			<xsl:otherwise>
				<!-- One more value. -->
				<td>
					<xsl:value-of select="$value"/>
					<xsl:text> </xsl:text>
					<xsl:apply-templates select="/witsml:realtimes/witsml:realtime/witsml:realtimeHeader/witsml:groupDefinition[witsml:id=$group]/witsml:channelDefinition[witsml:columnIndex=$column]/witsml:unit" 
						mode="UnitRef"/>
				</td>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>


	<!-- RealTimeData linked to the enumValues file. -->
	<xsl:template match="*" mode="RealTimeData">
		<a href="../ancillary/enumValues.xml#RealTimeData::{.}">
			<xsl:value-of select="."/>
		</a>
	</xsl:template>



</xsl:stylesheet>
