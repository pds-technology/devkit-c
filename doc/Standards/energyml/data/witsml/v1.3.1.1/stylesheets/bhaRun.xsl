<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/><xsl:output method="html" />

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML BHA Run Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="8" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="8"><font size="+2" color="blue">BHA Run Information</font></th></tr>
		<xsl:for-each select="witsml:bhaRuns">
			<xsl:for-each select="witsml:bhaRun">
				<tr>	<td colspan="2"><font size="-1"><b>Well uid: </b></font><font size="-1" color="black"> <xsl:value-of select="@uidWell"/></font></td>
					<td><b>Well Name: </b></td><td colspan="4"><xsl:value-of select="witsml:nameWell"/></td></tr>

				<tr>	<td colspan="2"><font size="-1"><b>Wellbore uid: </b></font><font size="-1" color="black"><xsl:value-of select="@uidWellbore"/></font></td>
					<td><b>Wellbore Name: </b></td><td colspan="4"><xsl:value-of select="witsml:nameWellbore"/></td></tr>

				<tr>	<td colspan="2"><font size="-1"><b>Run uid: </b></font><font size="-1" color="black"> <xsl:value-of select="@uid"/></font></td>
					<td><b>Run Name: </b></td><td colspan="4"><xsl:value-of select="witsml:name"/></td></tr>

				<tr>	
					<td><b><font size="-1" color="blue">Tubular Assembly Used in Run: </font> </b></td>
					<td colspan="2"><font size="-1"><b>uid: </b></font><font size="-1" color="black"> <xsl:value-of select="witsml:nameTubular/@uidRef"/></font></td>
					<td colspan="4"><b>Name: </b><xsl:value-of select="witsml:nameTubular"/></td></tr>
	

				<tr><td colspan="2"><font size="-1"><b>Start Time: </b><xsl:value-of select="witsml:dTimStart"/></font></td>
					<td colspan="2"><font size="-1"><b>Stop Time: </b><xsl:value-of select="witsml:dTimStop"/></font></td>
					<td colspan="2"><font size="-1"><b>Status: </b><xsl:value-of select="witsml:statusBha"/></font></td></tr>

				<tr><td colspan="2"><font size="-1"><b>Start Drilling: </b><xsl:value-of select="witsml:dTimStartDrilling"/></font></td>
					<td colspan="2"><font size="-1"><b>Stop Drilling: </b><xsl:value-of select="witsml:dTimStopDrilling"/></font></td>
					<td colspan="2"><font size="-1"><b>String Run: </b><xsl:value-of select="witsml:numStringRun"/></font></td></tr>

				<tr><td align="right"><font size="-1"><b>Dogleg Severity: </b></font></td>
					<td><font size="-1"><b>Planned: </b><xsl:value-of select="witsml:planDogleg"/></font></td>
					<td><font size="-1"><b>Actual: </b><xsl:value-of select="witsml:actDogleg"/></font></td>
					<td><font size="-1"><b>Actual  Max: </b><xsl:value-of select="witsml:actDoglegMx"/></font></td>
					<td colspan="2"><font size="-1"><b>Bit Run: </b><xsl:value-of select="witsml:numBitRun"/></font></td></tr>

				<tr>	<td colspan="3"><font size="-1"><b>Trip Reason: </b><xsl:value-of select="witsml:reasonTrip"/></font></td>
				<td colspan="3"><font size="-1"><b>Objective BHA: </b><xsl:value-of select="witsml:objectiveBha"/></font></td></tr>
				<!--		Check for Geology Interval data	-->	
				<xsl:for-each select="witsml:drillingParams">
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
	
	<!--									drillingParams Template							-->
	<xsl:template match="witsml:drillingParams">				
				<tr><td colspan="8" align="center"><font size="+1" color="blue">Drilling Parameters</font></td></tr>
				<tr>	<td colspan="3"><font size="-1"><b>Trip Reason: </b><xsl:value-of select="witsml:reasonTrip"/></font></td>
					<td colspan="3"><font size="-1"><b>Objective BHA: </b><xsl:value-of select="witsml:objectiveBha"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1"><b>UID Tub Assy: </b><xsl:value-of select="witsml:nameTubular/@uidRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>MD at: </b></font></td>
					<td colspan="1"><font size="-1"><b>Start: </b><xsl:apply-templates select="witsml:mdHoleStart" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Stop: </b><xsl:apply-templates select="witsml:mdHoleStop" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Bit oper time: </b><xsl:apply-templates select="witsml:eTimOpBit" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>Hookload: </b></font></td>
					<td colspan="1"><font size="-1"><b>Rotating: </b><xsl:apply-templates select="witsml:hkldRot" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Overpull: </b><xsl:apply-templates select="witsml:overPull" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Slackoff: </b><xsl:apply-templates select="witsml:slackOff" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>String moving up: </b><xsl:apply-templates select="witsml:hkldUp" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>String moving down: </b><xsl:apply-templates select="witsml:hkldDn" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>Torque on Bottom: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b><xsl:apply-templates select="witsml:tqOnBotAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b><xsl:apply-templates select="witsml:tqOnBotMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b><xsl:apply-templates select="witsml:tqOnBotMn" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Avg Off Bottom: </b><xsl:apply-templates select="witsml:tqOffBotAv" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Avg Torq Downhole: </b><xsl:apply-templates select="witsml:tqDhAv" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>Weight: </b></font></td>
					<td colspan="1"><font size="-1"><b>Above Jar: </b><xsl:apply-templates select="witsml:wtAboveJar" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Below Jar: </b><xsl:apply-templates select="witsml:wtBelowJar" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Mud: </b><xsl:apply-templates select="witsml:wtMud" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>Pump flowrate: </b><xsl:apply-templates select="witsml:flowratePump" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Bit Hydraulic: </b><xsl:apply-templates select="witsml:powBit" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Bit nozzle avg velocity: </b><xsl:apply-templates select="witsml:velNozzleAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Pressure drop in Bit: </b><xsl:apply-templates select="witsml:presDropBit" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="2" align="right"><font size="-1"><b>Time spent from start of bit run: </b></font></td>
					<td colspan="1"><font size="-1"><b>On hold: </b><xsl:apply-templates select="witsml:cTimHold" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Steering: </b><xsl:apply-templates select="witsml:cTimSteering" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Rotary Drilling: </b><xsl:apply-templates select="witsml:cTimDrillRot" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="2"><font size="-1"><b></b></font></td>
					<td colspan="1"><font size="-1"><b>Slide Drilling: </b><xsl:apply-templates select="witsml:cTimDrillSlid" mode="valueWithUomRef"/></font></td>					
					<td colspan="1"><font size="-1"><b>Circulating: </b><xsl:apply-templates select="witsml:cTimCirc" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Reaming: </b><xsl:apply-templates select="witsml:cTimReam" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>Distance: </b></font></td>
					<td colspan="1"><font size="-1"><b>Drilled rotating: </b><xsl:apply-templates select="witsml:distDrillRot" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Drilled sliding: </b><xsl:apply-templates select="witsml:distDrillSlid" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Reamed: </b><xsl:apply-templates select="witsml:distReam" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>While on hold: </b><xsl:apply-templates select="witsml:distHold" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>While steering: </b><xsl:apply-templates select="witsml:distSteering" mode="valueWithUomRef"/>: </font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>ROP: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b><xsl:apply-templates select="witsml:ropAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b><xsl:apply-templates select="witsml:ropMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b><xsl:apply-templates select="witsml:ropMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Avg RPM Dh: </b><xsl:apply-templates select="witsml:rpmAvDh" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>WOP: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b><xsl:apply-templates select="witsml:wobAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b><xsl:apply-templates select="witsml:wobMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b><xsl:apply-templates select="witsml:wobMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Avg WOB Dh: </b><xsl:apply-templates select="witsml:wobAvDh" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="1" align="right"><font size="-1"><b>Inclination: </b></font></td>
					<td colspan="1"><font size="-1"><b>at Start MD: </b><xsl:apply-templates select="witsml:inclStart" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b><xsl:apply-templates select="witsml:inclMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b><xsl:apply-templates select="witsml:inclMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>at Stop MD: </b><xsl:apply-templates select="witsml:inclStop" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Max mud temp downhole: </b><xsl:apply-templates select="witsml:tempMudDhMx" mode="valueWithUomRef"/></font></td></tr>

				<tr>	<td colspan="1" align="right"><font size="-1"><b>Azimuth at</b></font></td>
					<td colspan="1"><font size="-1"><b>Top MD: </b><xsl:apply-templates select="witsml:aziTop" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Bot MD: </b><xsl:apply-templates select="witsml:aziBottom" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Avg Pump Pressure: </b><xsl:apply-templates select="witsml:presPumpAv" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Flowrate at bit: </b><xsl:apply-templates select="witsml:flowrateBit" mode="valueWithUomRef"/></font></td></tr>
					<tr><td colspan="8"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:comments"/></font></td></tr>

	</xsl:template>	
	
</xsl:stylesheet>
