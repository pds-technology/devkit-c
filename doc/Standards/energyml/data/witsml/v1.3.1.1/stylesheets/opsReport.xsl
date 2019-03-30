<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
		xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

  <xsl:template match="/">
  <html>
  <head>
  <title>WITSML opsReport Data Object</title> 
  </head>
  <body>
  <table border="2" align="center">
  <tr>
  <th colspan="9">
  <font size="+2" color="blue">WITSML</font> 
  </th>
  </tr>
  <tr>
  <th colspan="9">
  <font size="+2" color="blue">Operations Report</font> 
  </th>
  </tr>
  <xsl:for-each select="witsml:opsReports">
  <xsl:for-each select="witsml:opsReport">
  <tr>	<td colspan="3"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
  	<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
  <tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
  	<td colspan="5"><font size="-1" color="blue"><b>Report uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
  <tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellore"/></font></td>
	<td colspan="5"><font size="-1" color="blue"><b>Report Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Report date: </b> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Days Oper.: </b> 
  <xsl:apply-templates select="witsml:eTimStart" mode="valueWithUomRef"/> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>DFS: </b> 
  <xsl:apply-templates select="witsml:eTimSpud" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Days Rig on Loc: </b> 
  <xsl:apply-templates select="witsml:eTimSpud" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>MD: </b> 
  <xsl:apply-templates select="witsml:mdReport" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>TVD: </b> 
  <xsl:apply-templates select="witsml:tvdReport" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Distance drilled: </b> 
  <xsl:apply-templates select="witsml:distDrill" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Drilling time: </b> 
  <xsl:apply-templates select="witsml:eTimDrill" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>MD Plan: </b> 
  <xsl:apply-templates select="witsml:mdPlanned" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Avg ROP: </b> 
 <xsl:apply-templates select="witsml:ropAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>ROP at Rpt time: </b> 
  <xsl:apply-templates select="witsml:ropCurrent" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="3">
  <font size="-1">
  <b>Supervisor: </b> 
  <xsl:value-of select="witsml:supervisor" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Engineer: </b> 
  <xsl:value-of select="witsml:engineer" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Geologist: </b> 
  <xsl:value-of select="witsml:geologist" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Rot Hours: </b> 
  <xsl:apply-templates select="witsml:eTimDrillRot" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Time from start of bit run: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Sliding: </b> 
  <xsl:apply-templates select="witsml:eTimDrillSlid" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Circulating: </b> 
  <xsl:apply-templates select="witsml:eTimCirc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Reaming: </b> 
  <xsl:apply-templates select="witsml:eTimReam" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Distance: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Drilled Rot.: </b> 
  <xsl:apply-templates select="witsml:distDrillRot" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Drilled Sliding: </b> 
  <xsl:apply-templates select="witsml:distDrillSlid" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Reamed: </b> 
  <xsl:apply-templates select="witsml:distReam" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Hold Drilling: </b> 
  <xsl:apply-templates select="witsml:distHold" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Steering: </b> 
  <xsl:apply-templates select="witsml:distSteering" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>POB: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Total: </b> 
  <xsl:value-of select="witsml:numPob" />
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Contractor: </b> 
  <xsl:value-of select="witsml:numContract" />
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Operator: </b> 
  <xsl:value-of select="witsml:numOperator" />
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Service Co.: </b> 
  <xsl:value-of select="witsml:numService" />
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>AFE No.: </b> 
  <xsl:value-of select="witsml:numAFE" /> 
  </font>
  </td>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Daily: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Cost: </b> 
  <xsl:value-of select="witsml:costDay" />
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:costDay/@currency" />
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Mud Cost: </b> 
  <xsl:value-of select="witsml:costDayMud" /> 
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:costDayMud/@currency" />
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Hole Size: </b> 
  <xsl:apply-templates select="witsml:diaHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Hole Cond.: </b> 
  <xsl:value-of select="witsml:conditionHole" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="4">
  <font size="-1">
  <b>Lithology: </b> 
  <xsl:value-of select="witsml:lithology" /> 
  </font>
  </td>
  <td colspan="5">
  <font size="-1">
  <b>Formation: </b> 
  <xsl:value-of select="witsml:nameFormation" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Last casing: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>dia.: </b> 
  <xsl:apply-templates select="witsml:diaCsgLast" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>md: </b> 
  <xsl:apply-templates select="witsml:mdCsgLast" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>tvd: </b> 
  <xsl:apply-templates select="witsml:tvdCsgLast" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>LOT TVD: </b> 
  <xsl:apply-templates select="witsml:tvdLot" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Tub. Assy: </b> 
  <xsl:if test="witsml:nameTubular">
    <xsl:value-of select="witsml:nameTubular"/> (uid: <xsl:value-of select="witsml:nameTubular/@uidRef"/>)
  </xsl:if>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Leak off test EMW: </b> 
  <xsl:apply-templates select="witsml:presLotEmw" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Kick tol. press.: </b> 
  <xsl:apply-templates select="witsml:presKickTol" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Kick tol. vol.: </b> 
  <xsl:apply-templates select="witsml:volKickTol" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>MAASP.: </b> 
 <xsl:apply-templates select="witsml:maasp" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <xsl:if test="witsml:sum24Hr">
  <tr>
  <td colspan="9">
  <font size="-1">
  <b>24 hr summary: </b> 
  <xsl:value-of select="witsml:sum24Hr" /> 
  </font>
  </td>
  </tr>
  </xsl:if>
  <xsl:if test="witsml:forecast24Hr">
  <tr>
  <td colspan="9">
  <font size="-1">
  <b>24 hr Forecast: </b> 
  <xsl:value-of select="witsml:forecast24Hr" /> 
  </font>
  </td>
  </tr>
  </xsl:if>
  <xsl:if test="witsml:statusCurrent">
  <tr>
  <td colspan="9">
  <font size="-1">
  <b>Curr. status: </b> 
  <xsl:value-of select="witsml:statusCurrent" /> 
  </font>
  </td>
  </tr>
  </xsl:if>
  <!--  		Check for activity information	  --> 
  <xsl:for-each select="witsml:activity">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Activity Breakdown</font> 
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for dayCost information	
  --> 
  <xsl:if test="witsml:dayCost">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Day Costs</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:dayCost">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for hse information	
  --> 
  <xsl:for-each select="witsml:hse">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Health, Safety, and Environmental Data</font> 
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for drillingParams information	
  --> 
  <xsl:if test="witsml:drillingParams">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Drilling Parameters</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:drillingParams">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for fluid information	
  --> 
  <xsl:for-each select="witsml:fluid">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for trajectoryStation information	
  --> 
  <xsl:if test="witsml:trajectoryStation">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Trajectory Stations</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:trajectoryStation">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for pitVolume information	
  --> 
  <xsl:if test="witsml:pitVolume">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Pit Volumes</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:pitVolume">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Pit: </b> 
  <xsl:value-of select="witsml:indexPit" /> 
  <b>uid: </b> <xsl:value-of select="witsml:indexPit/@uidRef" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Vol. taken: </b> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Vol.: </b> 
  <xsl:apply-templates select="witsml:volPit" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Density: </b> 
  <xsl:apply-templates select="witsml:densFluid" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Funnel vis.: </b> 
  <xsl:apply-templates select="witsml:visFunnel" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" /> 
  <td colspan="7">
  <font size="-1">
  <b>Description: </b> 
  <xsl:value-of select="witsml:descFluid" /> 
  </font>
  </td>
  </tr>
  </xsl:for-each>
  <!--  		Check for mudVolume information	
  --> 
  <xsl:for-each select="witsml:mudVolume">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Mud Volumes</font> 
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for mudInventory information	
  --> 
  <xsl:if test="witsml:mudInventory">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Mud Inventory</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:mudInventory">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for bulk information	
  --> 
  <xsl:if test="witsml:bulk">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Bulk</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:bulk">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for pumpOp information	
  --> 
  <xsl:if test="witsml:pumpOp">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Pump Operations</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:pumpOp">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Pump: </b> 
  <xsl:value-of select="witsml:indexPump" />  (uid=
  <xsl:value-of select="indexPump/@uidRef" /> )
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Measured: </b> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="4">
  <font size="-1">
  <b>Type oper.: </b> 
  <xsl:value-of select="witsml:typeOperation" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td /> 
  <td colspan="1">
  <font size="-1">
  <b>Liner id.: </b> 
  <xsl:apply-templates select="witsml:idLiner" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Stroke len.: </b> 
  <xsl:apply-templates select="witsml:lenStroke" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Stroke rate: </b> 
  <xsl:apply-templates select="witsml:rateStroke" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td /> 
  <td colspan="2">
  <font size="-1">
  <b>Pump press.: </b> 
  <xsl:apply-templates select="witsml:pressure" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Efficiency: </b> 
  <xsl:apply-templates select="witsml:pcEfficiency" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Pump o/p: </b> 
  <xsl:apply-templates select="witsml:pumpOutput" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Bit md: </b> 
  <xsl:apply-templates select="witsml:mdBit" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:for-each>
  <!--  		Check for shakerOp information	
  --> 
  <xsl:for-each select="witsml:shakerOp">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">
  Shaker Operations for shaker: 
  <xsl:value-of select="@uidShaker" /> 
  </font>
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for scr information	
  --> 
  <xsl:if test="witsml:scr">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Slow Circulation Rates (SCR)</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:scr">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for incident information	
  --> 
  <xsl:for-each select="witsml:incident">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Incidents</font> 
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for personnel information	
  --> 
  <xsl:if test="witsml:personnel">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Personnel</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:personnel">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for supportCraft information	
  --> 
  <xsl:if test="witsml:supportCraft">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">
  Support Craft: 
  <xsl:value-of select="witsml:supportCraft/@uid" /> 
  </font>
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:supportCraft">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!--  		Check for rigResponse information	
  --> 
  <xsl:if test="witsml:rigResponse">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">
  Rig Response 
  </font>
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:rigResponse">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!-- 		Check for weather information	
  --> 
  <xsl:if test="witsml:weather">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Weather</font> 
  </td>
  </tr>
  </xsl:if>
  <xsl:for-each select="witsml:weather">
  <xsl:apply-templates select="." /> 
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
  <!-- 				activity Template       --> 
  <xsl:template match="witsml:activity">
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Activity: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>started: </b> 
  <xsl:value-of select="witsml:dTimStart" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>ended: </b> 
  <xsl:value-of select="witsml:dTimEnd" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>duration: </b> 
  <xsl:apply-templates select="witsml:duration" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Item State: </b> 
  <xsl:value-of select="witsml:itemState" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Phase: </b> 
  <xsl:value-of select="witsml:phase" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Type: </b> 
  <xsl:value-of select="witsml:typeActivityClass" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>State: </b> 
  <xsl:value-of select="witsml:state" /> 
  </font>
  </td>
  </tr>
  <!-- 		Check for a activityCode information	
  --> 
  <xsl:for-each select="witsml:activityCode">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Hole: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>MD start: </b> 
  <xsl:apply-templates select="witsml:mdHoleStart" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>MD end: </b> 
  <xsl:apply-templates select="witsml:mdHoleEnd" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>TVD start: </b> 
 <xsl:apply-templates select="witsml:tvdHoleStart" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>TVD end: </b> 
  <xsl:apply-templates select="witsml:tvdHoleStart" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1" align="right">
  <font size="-1">
  <b>MD of bit at: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>start: </b> 
  <xsl:apply-templates select="witsml:mdBitStart" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>end: </b> 
  <xsl:apply-templates select="witsml:mdBitEnd" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Operator: </b> 
  <xsl:value-of select="witsml:operator" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Tub. Assy ID: </b> 
  <xsl:if test="witsml:nameTubular">
    <xsl:value-of select="witsml:nameTubular"/> (uid: <xsl:value-of select="witsml:nameTubular/@uidRef"/>)
  </xsl:if>  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Activity optimum?: </b> 
  <xsl:value-of select="witsml:optimum" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Productive?: </b> 
  <xsl:value-of select="witsml:productive" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="9">
  <font size="-1">
  <b>Comments: </b> 
  <xsl:value-of select="witsml:comments" /> 
  </font>
  </td>
  </tr>
  </xsl:template> <!--   end Activity Template -->
  <!-- 							activityCode Template  --> 
  <xsl:template match="witsml:activityCode">
  <td colspan="2">
  <font size="-1">
  <b>Activity Code: </b> 
  <xsl:value-of select="witsml:activityCode" /> 
  </font>
  </td>
  <td colspan="4">
  <font size="-1">
  <b>Detail: </b> 
  <xsl:value-of select="witsml:detailActivity" /> 
  </font>
  </td>
  </xsl:template>
  <!-- 									dayCost Template							
  --> 
  <xsl:template match="witsml:dayCost">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>AFE: </b> 
  <xsl:value-of select="witsml:numAFE" /> 
  </font>
  </td>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Cost: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>group: </b> 
  <xsl:value-of select="witsml:costGroup" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>class: </b> 
  <xsl:value-of select="witsml:costClass" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>code: </b> 
  <xsl:value-of select="witsml:costCode" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>subcode: </b> 
  <xsl:value-of select="witsml:costSubCode" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Desc: </b> 
  <xsl:value-of select="witsml:costItemDescription" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cost/item: </b> 
  <xsl:value-of select="witsml:costPerItem" /> 
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:costPerItem/@currency" />
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Item qty: </b> 
  <xsl:value-of select="witsml:qtyItem" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Amt used: </b> 
  <xsl:value-of select="witsml:itemSize" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cost: </b> 
  <xsl:value-of select="witsml:costAmount" />
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:costAmount/@currency" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Invoice: </b> 
  <xsl:value-of select="witsml:numInvoice" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>P.O.: </b> 
  <xsl:value-of select="witsml:numPO" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Ticket: </b> 
  <xsl:value-of select="witsml:numTicket" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Carry over?: </b> 
  <xsl:value-of select="witsml:isCarryOver" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Rental?: </b> 
  <xsl:value-of select="witsml:isRental" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Serial no: </b> 
  <xsl:value-of select="witsml:numSerial" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Vendor: </b> 
  <xsl:value-of select="witsml:nameVendor" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Vendor no.: </b> 
  <xsl:value-of select="witsml:numVendor" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="4">
  <font size="-1">
  <b>Pool: </b> 
  <xsl:value-of select="witsml:pool" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cost estimated?: </b> 
  <xsl:value-of select="witsml:estimated" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									hse Template							
  --> 
  <xsl:template match="witsml:hse">
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Last csg press. test: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>date: </b> 
  <xsl:value-of select="witsml:lastCsgPressTest" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>pressure: </b> 
  <xsl:apply-templates select="witsml:presLastCsg" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Incident free days: </b> 
  <xsl:value-of select="witsml:daysIncFree" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>BOP pressure test: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>last: </b> 
  <xsl:value-of select="witsml:lastBopPresTest" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>next: </b> 
  <xsl:value-of select="witsml:nextBopPresTest" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Press. tested to: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>stdpipe man.: </b> 
  <xsl:apply-templates select="witsml:presStdPipe" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>kelly hose: </b> 
  <xsl:apply-templates select="witsml:presKellyHose" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>bop div: </b> 
  <xsl:apply-templates select="witsml:presDiverter" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>bop ann.: </b> 
  <xsl:apply-templates select="witsml:presAnnular" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>bop ram: </b> 
  <xsl:apply-templates select="witsml:presRams" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>chkln: </b> 
  <xsl:apply-templates select="witsml:presChokeLine" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>chkman.: </b> 
  <xsl:apply-templates select="witsml:presChokeMan" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Last: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>fire/boat drill: </b> 
  <xsl:value-of select="witsml:lastFireBoatDrill" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>aband. drill: </b> 
  <xsl:value-of select="witsml:lastAbandonDrill" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>rig inspect.: </b> 
  <xsl:value-of select="witsml:lastRigInspection" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>safety mtg: </b> 
  <xsl:value-of select="witsml:lastSafetyMeeting" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>trip drill: </b> 
  <xsl:value-of select="witsml:lastTripDrill" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>diverter drill: </b> 
  <xsl:value-of select="witsml:lastDiverterDrill" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>bop drill: </b> 
  <xsl:value-of select="witsml:lastBopDrill" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Govt Regul. Agency inspect.?: </b> 
  <xsl:value-of select="witsml:regAgencyInsp" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Non-compliance notice served?: </b> 
  <xsl:value-of select="witsml:nonComplianceIssued" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Num STOP Cards Issued: </b> 
  <xsl:value-of select="witsml:numStopCards" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Vol. discharged: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>daily mud: </b> 
  <xsl:apply-templates select="witsml:fluidDischarged" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>cuttings: </b> 
  <xsl:apply-templates select="witsml:volCtgDischarged" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>daily oil on cuttings: </b> 
  <xsl:apply-templates select="witsml:volOilCtgDischarge" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>vol. sanitary waste: </b> 
  <xsl:apply-templates select="witsml:wasteDischarged" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <!-- 		Check for a incident information	
  --> 
  <xsl:for-each select="witsml:incident">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <tr>
  <td colspan="9">
  <font size="-1">
  <b>Comments: </b> 
  <xsl:value-of select="witsml:comments" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									drillingParams Template							
  --> 
  <xsl:template match="witsml:drillingParams">
  <tr>
  <td colspan="3">
  <font size="-1">
  <b>Trip Reason: </b> 
  <xsl:value-of select="witsml:reasonTrip" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Objective BHA: </b> 
  <xsl:value-of select="witsml:objectiveBha" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>UID Tub Assy: </b> 
  <xsl:value-of select="witsml:uidTubularAssy" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>MD at: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Start: </b> 
  <xsl:apply-templates select="witsml:mdHoleStart" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Stop: </b> 
  <xsl:apply-templates select="witsml:mdHoleStop" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Bit oper time: </b> 
  <xsl:apply-templates select="witsml:eTimOpBit" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Hookload: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Rotating: </b> 
  <xsl:apply-templates select="witsml:hkldRot" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Overpull: </b> 
  <xsl:apply-templates select="witsml:overPull" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Slackoff: </b> 
  <xsl:apply-templates select="witsml:slackOff" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>String moving up: </b> 
  <xsl:apply-templates select="witsml:hkldUp" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>String moving down: </b> 
  <xsl:apply-templates select="witsml:hkldUp" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Torque on Bottom: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Avg: </b> 
  <xsl:apply-templates select="witsml:tqOnBotAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Max: </b> 
  <xsl:apply-templates select="witsml:tqOnBotMx" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Min: </b> 
  <xsl:apply-templates select="witsml:tqOnBotMn" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Avg Off Bottom: </b> 
  <xsl:apply-templates select="witsml:tqOffBotAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Avg Torque Downhole: </b> 
  <xsl:apply-templates select="witsml:tqDhAv" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Weight: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Above Jar: </b> 
  <xsl:apply-templates select="witsml:wtAboveJar" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Below Jar: </b> 
  <xsl:apply-templates select="witsml:wtBelowJar" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Mud: </b> 
  <xsl:apply-templates select="witsml:wtMud" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Pump flowrate: </b> 
  <xsl:apply-templates select="witsml:flowratePump" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Bit Hydraulic: </b> 
  <xsl:apply-templates select="witsml:powBit" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Bit nozzle avg velocity: </b> 
  <xsl:apply-templates select="witsml:velNozzleAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Pressure drop in Bit: </b> 
  <xsl:apply-templates select="witsml:presDropBit" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Time spent from start of bit run: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>On hold: </b> 
  <xsl:apply-templates select="witsml:cTimHold" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Steering: </b> 
  <xsl:apply-templates select="witsml:cTimSteering" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Rotary Drilling: </b> 
  <xsl:apply-templates select="witsml:cTimDrillRot" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Slide Drilling: </b> 
  <xsl:apply-templates select="witsml:cTimDrillSlid" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Circulating: </b> 
  <xsl:apply-templates select="witsml:cTimCirc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Reaming: </b> 
  <xsl:apply-templates select="witsml:cTimReam" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Distance drilled while: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>rotating: </b> 
  <xsl:apply-templates select="witsml:distDrillRot" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>sliding: </b> 
  <xsl:apply-templates select="witsml:distDrillSlid" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>reamed: </b> 
  <xsl:apply-templates select="witsml:distReam" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>on hold: </b> 
  <xsl:apply-templates select="witsml:distHold" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>steering: </b> 
  <xsl:apply-templates select="witsml:distSteering" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>ROP: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Avg: </b> 
  <xsl:apply-templates select="witsml:ropAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Max: </b> 
  <xsl:apply-templates select="witsml:ropMx" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Min: </b> 
  <xsl:apply-templates select="witsml:ropMn" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Avg ROP: </b> 
  <xsl:apply-templates select="witsml:rpmAvDh" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>WOB: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Avg: </b> 
  <xsl:apply-templates select="witsml:wobAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Max: </b> 
  <xsl:apply-templates select="witsml:wobMx" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Min: </b> 
  <xsl:apply-templates select="witsml:wobMn" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Avg WOB: </b> 
  <xsl:apply-templates select="witsml:wobAvDh" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Inclination: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>@ Start MD: </b> 
  <xsl:apply-templates select="witsml:wobAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Max: </b> 
  <xsl:apply-templates select="witsml:wobMx" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Min: </b> 
  <xsl:apply-templates select="witsml:wobMn" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>@ Stop MD: </b> 
  <xsl:apply-templates select="witsml:wobAvDh" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="4">
  <font size="-1">
  <b>Max mud temp downhole</b> 
  <xsl:apply-templates select="witsml:tempMudDhMx" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Azimuth @</b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Top MD</b> 
  <xsl:apply-templates select="witsml:aziTop" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Bot. MD</b> 
  <xsl:apply-templates select="witsml:aziBottom" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Avg Pump Press.</b> 
  <xsl:apply-templates select="witsml:presPumpAv" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="4">
  <font size="-1">
  <b>Flowrate @ bit</b> 
  <xsl:apply-templates select="witsml:flowrateBit" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td /> 
  <td colspan="8">
  <font size="-1">
  <b>Comments</b> 
  <xsl:value-of select="witsml:comments" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									bulk Template							
  --> 
  <xsl:template match="witsml:bulk">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Item: </b> 
  <xsl:value-of select="witsml:name" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
     Wt Per Item: <xsl:apply-templates select="witsml:itemWtPerUnit" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
     Vol Per Item: <xsl:apply-templates select="witsml:itemVolPerUnit" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Price per unit: </b> 
  <xsl:value-of select="witsml:pricePerUnit" /> 
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:pricePerUnit/@currency" />
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Daily Cost: </b> 
  <xsl:value-of select="witsml:costItem" /> 
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:costItem/@currency" />
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Qty: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>at start: </b> 
  <xsl:value-of select="witsml:qtyStart" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>adjust: </b> 
  <xsl:value-of select="witsml:qtyAdjustment" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>recvd: </b> 
  <xsl:value-of select="witsml:qtyReceived" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>returned: </b> 
  <xsl:value-of select="witsml:qtyReturned" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>used: </b> 
  <xsl:value-of select="witsml:qtyUsed" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>on location (end of rpt): </b>  
  <xsl:value-of select="witsml:qtyOnLocation" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									fluid Template							
  --> 
  <xsl:template match="witsml:fluid">
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Fluid Properties</font>  (uid: <xsl:value-of select="@uid" />)
  </td>
  </tr>
  <tr>
  <td colspan="3">
  <font size="-1">
  <b>Company: </b> 
  <xsl:value-of select="witsml:company" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Engineer: </b> 
  <xsl:value-of select="witsml:engineer" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="3">
  <font size="-1">
  <b>Type: </b> 
  <xsl:value-of select="witsml:type" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Sample location: </b> 
  <xsl:value-of select="witsml:locationSample" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Density: </b> 
  <xsl:apply-templates select="witsml:density" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Funnel Viscosity: </b> 
  <xsl:apply-templates select="witsml:visFunnel" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Funnel Viscosity Temp: </b> 
  <xsl:apply-templates select="witsml:tempVis" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Plastic Viscosity: </b> 
  <xsl:apply-templates select="witsml:pv" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Yield Point: </b> 
  <xsl:apply-templates select="witsml:yp" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>10 sec. gels: </b> 
  <xsl:apply-templates select="witsml:gel10Sec" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>10 min. gels: </b> 
  <xsl:apply-templates select="witsml:gel10Min" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>30 min. gels: </b> 
  <xsl:apply-templates select="witsml:gel30Min" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Filter cake thickness: </b> 
  <xsl:apply-templates select="witsml:filterCakeLtlp" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>API water loss: </b> 
  <xsl:apply-templates select="witsml:filtrateLtlp" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>HTHP: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Temp.: </b> 
  <xsl:apply-templates select="witsml:tempHthp" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Pressure: </b> 
  <xsl:apply-templates select="witsml:presHthp" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Filtrate: </b> 
  <xsl:apply-templates select="witsml:filtrateHthp" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Filter cake thickness: </b> 
  <xsl:apply-templates select="witsml:filterCakeHthp" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Percent: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Solids from retort: </b> 
  <xsl:apply-templates select="witsml:solidsPc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Water: </b> 
  <xsl:apply-templates select="witsml:waterPc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Oil: </b> 
  <xsl:apply-templates select="witsml:oilPc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Sand: </b> 
  <xsl:apply-templates select="witsml:sandPc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Low grav solids: </b> 
  <xsl:apply-templates select="witsml:solidsLowGravPc" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Solids (calc.): </b> 
  <xsl:apply-templates select="witsml:solidsCalcPc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Barite: </b> 
  <xsl:apply-templates select="witsml:baritePc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Brine: </b> 
  <xsl:apply-templates select="witsml:brinePc" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Loss Circ Matl: </b> 
  <xsl:apply-templates select="witsml:lcm" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>CEC of Mud Sample meas. by MBT: </b> 
  <xsl:apply-templates select="witsml:mbt" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Mud pH: </b> 
  <xsl:apply-templates select="witsml:ph" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mud pH meas. temp: </b> 
 <xsl:apply-templates select="witsml:tempPh" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Phenolpthalein alkalinity: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>of whole mud: </b> 
  <xsl:apply-templates select="witsml:pm" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>of mud filtrate: </b> 
  <xsl:apply-templates select="witsml:pmFiltrate" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Methyl orange alkalinity of filtrate: </b> 
  <xsl:apply-templates select="witsml:mf" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mud alkalinity P1: </b> 
  <xsl:apply-templates select="witsml:alkalinityP1" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mud alkalinity P2: </b> 
  <xsl:apply-templates select="witsml:alkalinityP2" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Content: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Chloride: </b> 
  <xsl:apply-templates select="witsml:chloride" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Calcium: </b> 
  <xsl:apply-templates select="witsml:calcium" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Magnesium: </b> 
  <xsl:apply-templates select="witsml:magnesium" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Potassium: </b> 
  <xsl:apply-templates select="witsml:potassium" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Lime: </b> 
  <xsl:apply-templates select="witsml:lime" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Sulfide: </b> 
  <xsl:apply-templates select="witsml:sulfide" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Emulsion stability: </b> 
  <xsl:apply-templates select="witsml:electStab" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Calcium chloride: </b> 
  <xsl:apply-templates select="witsml:calciumChloride" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Avg spec grav of solids: </b> 
  <xsl:apply-templates select="witsml:asg" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Solid high grav.: </b> 
  <xsl:apply-templates select="witsml:solidsHiGravPc" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Polymer in mud: </b> 
  <xsl:apply-templates select="witsml:polymer" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="4">
  <font size="-1">
  <b>Type of polymers: </b> 
  <xsl:value-of select="witsml:polyType" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Solids corr. for chloride: </b> 
  <xsl:apply-templates select="witsml:solCorPc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Oil cuttings: </b> 
 <xsl:apply-templates select="witsml:oilCtg" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Calcium hardness: </b> 
  <xsl:apply-templates select="witsml:hardnessCa" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <!-- 		Check for Fluid Property Common Data			
  --> 
  <tr>
  <td colspan="8">
  <font size="-1">
  <b>Fluid Property Comments: </b> 
  <xsl:value-of select="witsml:comments" /> 
  </font>
  </td>
  </tr>
  <!-- 		Check for Rheometer Readings	
  --> 
  <tr>
  <td colspan="9" align="center">
  <font size="+1" color="blue">Rheometer Readings</font> 
  </td>
  </tr>
  <xsl:for-each select="witsml:rheometer">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  </xsl:template>

  <!-- 									rheometer Template							
  --> 
  <xsl:template match="witsml:rheometer">
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Reading: </b>
  </font>
  </td>
  <td colspan="2" align="center">
  <font size="-1">
  <b>uid: </b> 
  <xsl:value-of select="@uid" />
  </font>
  </td>
  <td colspan="2" align="center">
  <font size="-1">
  <b>Temperature: </b> 
  <xsl:apply-templates select="witsml:tempRheom" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2" align="center">
  <font size="-1">
  <b>Pressure: </b> 
  <xsl:apply-templates select="witsml:presRheom" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Viscometer: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>3 RPM: </b> 
  <xsl:value-of select="witsml:vis3Rpm" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>6 RPM: </b> 
  <xsl:value-of select="witsml:vis6Rpm" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>100 RPM: </b> 
  <xsl:value-of select="witsml:vis100Rpm" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>200 RPM: </b> 
  <xsl:value-of select="witsml:vis200Rpm" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>300 RPM: </b> 
  <xsl:value-of select="witsml:vis300Rpm" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>600 RPM: </b> 
  <xsl:value-of select="witsml:vis600Rpm" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									incident Template							
  --> 
  <xsl:template match="witsml:incident">
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Incident: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Occurred: </b> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Reporter: </b> 
  <xsl:value-of select="witsml:reporter" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="1" align="right">
  <font size="-1">
  <b>No. of personnel: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>minor injuries: </b> 
  <xsl:value-of select="witsml:numMinorInjury" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>major injuries: </b> 
  <xsl:value-of select="witsml:numMajorInjury" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>killed: </b> 
  <xsl:value-of select="witsml:numFatality" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Near misses?: </b> 
  <xsl:value-of select="witsml:isNearMiss" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Locn: </b> 
  <xsl:value-of select="witsml:descLocation" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Resp. company: </b> 
  <xsl:value-of select="witsml:responsibleCompany" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Lost time: </b> 
  <xsl:apply-templates select="witsml:eTimLostGross" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cost: </b> 
  <xsl:apply-templates select="witsml:costLostGross" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="8">
  <font size="-1">
  <b>Description: </b> 
  <xsl:value-of select="witsml:descAccident" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="8">
  <font size="-1">
  <b>Remedial action: </b> 
  <xsl:value-of select="witsml:remedialActionDesc" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="8">
  <font size="-1">
  <b>Cause: </b> 
  <xsl:value-of select="witsml:causeDesc" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									mudInventory Template							
  --> 
  <xsl:template match="witsml:mudInventory">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Product: </b> 
  <xsl:value-of select="witsml:name" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
     Wt Per Item: <xsl:apply-templates select="witsml:itemWtPerUnit" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
     Vol Per Item: <xsl:apply-templates select="witsml:itemVolPerUnit" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Price per unit: </b> 
  <xsl:value-of select="witsml:pricePerUnit" />
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:pricePerUnit/@currency" />
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Daily Cost: </b> 
  <xsl:value-of select="witsml:costItem" /> 
  <xsl:text> </xsl:text>
  <xsl:value-of select="witsml:costItem/@currency" />
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Qty: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>at start: </b> 
  <xsl:value-of select="witsml:qtyStart" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>adjust: </b> 
  <xsl:value-of select="witsml:qtyAdjustment" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>recvd: </b> 
  <xsl:value-of select="witsml:qtyReceived" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>returned: </b> 
  <xsl:value-of select="witsml:qtyReturned" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>used: </b> 
  <xsl:value-of select="witsml:qtyUsed" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>on location (end of rpt): </b> 
  <xsl:value-of select="witsml:qtyOnLocation" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									mudVolume Template							
  --> 
  <xsl:template match="witsml:mudVolume">
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Vol. of mud: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>at start: </b> 
  <xsl:apply-templates select="witsml:volTotMudStart" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>at end: </b> 
  <xsl:apply-templates select="witsml:volTotMudEnd" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>dumped: </b> 
  <xsl:apply-templates select="witsml:volMudDumped" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>received: </b> 
  <xsl:apply-templates select="witsml:volMudReceived" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>returned: </b> 
  <xsl:apply-templates select="witsml:volMudReturned" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>built: </b> 
  <xsl:apply-templates select="witsml:volMudBuilt" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Vol. of mud contained in</b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>act. string: </b> 
  <xsl:apply-templates select="witsml:volMudString" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>casing: </b> 
  <xsl:apply-templates select="witsml:volMudCasing" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>open hole: </b> 
  <xsl:apply-templates select="witsml:volMudHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>riser: </b> 
  <xsl:apply-templates select="witsml:volMudRiser" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <!-- 		Check for mudLosses information	
  --> 
  <xsl:for-each select="witsml:mudLosses">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  </xsl:template>
  <!-- 									mudLosses Template							
  --> 
  <xsl:template match="witsml:mudLosses">
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Vol. mud lost at surface at/in: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>shakers: </b> 
  <xsl:apply-templates select="witsml:volLostShakerSurf" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>cleaning eq.: </b> 
  <xsl:apply-templates select="witsml:volLostMudCleanerSurf" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>pit room: </b> 
  <xsl:apply-templates select="witsml:volLostPitsSurf" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>tripping: </b> 
  <xsl:apply-templates select="witsml:volLostTrippingSurf" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>other: </b> 
  <xsl:apply-templates select="witsml:volLostOtherSurf" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>total: </b> 
  <xsl:apply-templates select="witsml:volTotMudLostSurf" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Vol. mud lost downhole: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>circ.: </b> 
  <xsl:apply-templates select="witsml:volLostCircHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>run csg: </b> 
  <xsl:apply-templates select="witsml:volLostCsgHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>cement.: </b> 
  <xsl:apply-templates select="witsml:volLostCmtHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>behind csg: </b> 
  <xsl:apply-templates select="witsml:volLostBhdCsgHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>abandon: </b> 
  <xsl:apply-templates select="witsml:volLostAbandonHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>other: </b> 
  <xsl:apply-templates select="witsml:volLostOtherHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>total: </b> 
  <xsl:apply-templates select="witsml:volTotMudLostHole" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									personnel Template							
  --> 
  <xsl:template match="witsml:personnel">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Company: </b> 
  <xsl:value-of select="witsml:company" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Serv. provided: </b> 
  <xsl:value-of select="witsml:typeService" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>No. people: </b> 
  <xsl:value-of select="witsml:numPeople" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Tot. hrs worked: </b> 
  <xsl:apply-templates select="witsml:totalTime" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									pumpOp Template							
  --> 
  <xsl:template match="witsml:pumpOp">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Measured: </b> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Type oper.: </b> 
  <xsl:value-of select="witsml:typeOperation" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Liner id.: </b> 
  <xsl:apply-templates select="witsml:idLiner" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Stroke len.: </b> 
  <xsl:apply-templates select="witsml:lenStroke" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Stroke rate: </b> 
  <xsl:apply-templates select="witsml:rateStroke" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b /> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Pump press.: </b> 
  <xsl:apply-templates select="witsml:pressure" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Efficiency: </b> 
  <xsl:apply-templates select="witsml:pcEfficiency" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Pump o/p: </b> 
  <xsl:apply-templates select="witsml:pumpOutput" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Bit md: </b> 
  <xsl:apply-templates select="witsml:mdBit" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									rigResponse Template							
  --> 
  <xsl:template match="witsml:rigResponse">
  <xsl:for-each select="witsml:anchorTension">
    <tr>
    <td colspan="1" align="right">
    <font size="-1">
    <b>Anchor tension: </b> 
    </font>
    </td>
    <td colspan="1">
    <font size="-1">
    <b>index: </b> 
    <xsl:value-of select="@index" /> 
    </font>
    </td>
    <td colspan="2">
    <font size="-1">
    <b>name: </b> 
    <xsl:value-of select="@name" /> 
    </font>
    </td>
    <td colspan="1">
    <font size="-1">
    <b>value: </b> 
    <xsl:apply-templates select="." mode="valueWithUomRef"/>
    </font>
    </td>
    <td colspan="1">
    <font size="-1">
    <b>desc: </b> 
    <xsl:value-of select="@description" /> 
    </font>
    </td>
    </tr>
  </xsl:for-each>
  <xsl:for-each select="witsml:anchorAngle">
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Anchor angle: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>index: </b> 
  <xsl:value-of select="@index" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>name: </b> 
  <xsl:value-of select="@name" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>value: </b> 
  <xsl:apply-templates select="." mode="valueWithUomRef"/>
  </font>
  </td>
    <td colspan="1">
    <font size="-1">
    <b>desc: </b> 
    <xsl:value-of select="@description" />
    </font>
    </td>
  </tr>
  </xsl:for-each>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b>Heading</b> 
  <xsl:apply-templates select="witsml:rigHeading" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Heave: </b> 
  <xsl:apply-templates select="witsml:rigHeave" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Pitch angle: </b> 
  <xsl:apply-templates select="witsml:rigPitchAngle" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Roll angle: </b> 
  <xsl:apply-templates select="witsml:rigRollAngle" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Riser: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Angle: </b> 
  <xsl:apply-templates select="witsml:riserAngle" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Direction: </b> 
  <xsl:apply-templates select="witsml:riserDirection" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Tension: </b> 
  <xsl:apply-templates select="witsml:riserTension" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Var. deck load</b> 
  <xsl:apply-templates select="witsml:variableDeckLoad" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Tot. deck load: </b> 
  <xsl:apply-templates select="witsml:totalDeckLoad" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Dir. base guide: </b> 
  <xsl:apply-templates select="witsml:guideBaseAngle" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Ball joint angle: </b> 
  <xsl:apply-templates select="witsml:ballJointAngle" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Ball joint dir: </b> 
  <xsl:apply-templates select="witsml:ballJointDirection" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Rig offset: </b> 
  <xsl:apply-templates select="witsml:offsetRig" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Jackup load: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>leg 1: </b> 
  <xsl:apply-templates select="witsml:loadLeg1" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>leg 2: </b> 
  <xsl:apply-templates select="witsml:loadLeg2" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>leg 3: </b> 
 <xsl:apply-templates select="witsml:loadLeg3" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>leg 4: </b> 
  <xsl:apply-templates select="witsml:loadLeg4" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Penetration in seabed: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>leg 1: </b> 
  <xsl:apply-templates select="witsml:penetrationLeg1" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>leg 2: </b> 
  <xsl:apply-templates select="witsml:penetrationLeg2" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>leg 3: </b> 
  <xsl:apply-templates select="witsml:penetrationLeg3" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>leg 4: </b> 
  <xsl:apply-templates select="witsml:penetrationLeg4" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Vessel disp: </b> 
  <xsl:apply-templates select="witsml:dispRig" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mean Dft: </b> 
  <xsl:apply-templates select="witsml:meanDraft" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									scrTemplate							
  --> 
  <xsl:template match="witsml:scr">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>SCR recorded: </b> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Pump: </b> 
  <xsl:value-of select="witsml:indexPump" /> (uid=
  <xsl:value-of select="witsml:indexPump/@uidRef" /> )
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Type: </b> 
  <xsl:value-of select="witsml:typeScr" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Pump stroke rate: </b> 
  <xsl:value-of select="witsml:rateStroke" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Recorded Pump press.: </b> 
  <xsl:apply-templates select="witsml:presRecorded" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Bit md: </b> 
  <xsl:apply-templates select="witsml:mdBit" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									shakerOp Template							
  --> 
  <xsl:template match="witsml:shakerOp">
  <tr>
  <td colspan="3">
  <font size="-1">
  <b>When shaker oper. measured: </b> 
  <xsl:value-of select="witsml:dTim" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Hole md: </b> 
  <xsl:apply-templates select="witsml:mdHole" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Hours run: </b> 
  <xsl:apply-templates select="witsml:hoursRun" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Pct screen covered by cuttings: </b> 
  <xsl:apply-templates select="witsml:pcScreenCovered" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <!-- 		Check for shakerScreen information	
  --> 
  <xsl:for-each select="witsml:shakerScreen">
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  </xsl:template>
  <!-- 									shakerScreen Template							
  --> 
  <xsl:template match="witsml:shakerScreen">
  <tr>
  <td colspan="1">
  <font size="-1">
  <b>Shaker screen: </b>  
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mesh installed: </b> 
  <xsl:value-of select="witsml:dTimStart" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mesh removed: </b> 
  <xsl:value-of select="witsml:dTimEnd" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mfg: </b> 
  <xsl:value-of select="witsml:manufacturer" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Model: </b> 
  <xsl:value-of select="witsml:model" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Deck no.: </b> 
  <xsl:value-of select="witsml:numDeck" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mesh size x dir: </b> 
  <xsl:apply-templates select="witsml:meshX" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mesh size y dir: </b> 
  <xsl:apply-templates select="witsml:meshY" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cut pt.: </b> 
  <xsl:apply-templates select="witsml:cutPoint" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									supportCraft Template							
  --> 
  <xsl:template match="witsml:supportCraft">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Name: </b> 
  <xsl:value-of select="witsml:name" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Type craft: </b> 
  <xsl:value-of select="witsml:typeSuppCraft" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Arrived: </b> 
  <xsl:value-of select="witsml:dTimArrived" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Departed: </b> 
  <xsl:value-of select="witsml:dTimDeparted" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="9">
  <font size="-1">
  <b>Comments: </b> 
  <xsl:value-of select="witsml:comments" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									trajectoryStation Template							
  --> 
  <xsl:template match="witsml:trajectoryStation">
  <tr>
  <td colspan="3">
  <font size="-1">
  <b>Station Uid: </b> 
  <xsl:value-of select="@uid" />
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Measurements made at: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>MD: </b> 
  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>TVD: </b> 
  <xsl:apply-templates select="witsml:tvd" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Type: </b> 
  <xsl:value-of select="witsml:typeTrajStation" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Hole inclination: </b> 
  <xsl:apply-templates select="witsml:inc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Hole Azimuth: </b> 
  <xsl:apply-templates select="witsml:azi" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Mag. toolface angle: </b> 
  <xsl:apply-templates select="witsml:mtf" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Gravity toolface angle: </b> 
  <xsl:apply-templates select="witsml:gtf" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>NS offset: </b> 
  <xsl:apply-templates select="witsml:dispNs" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>EW offset: </b> 
  <xsl:apply-templates select="witsml:dispEw" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Vert distance on azi plane: </b> 
  <xsl:apply-templates select="witsml:vertSect" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Dogleg Severity: </b> 
  <xsl:apply-templates select="witsml:dls" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="2" align="right">
  <font size="-1">
  <b>Turn rate: </b> 
  <xsl:apply-templates select="witsml:rateTurn" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Build rate: </b> 
  <xsl:apply-templates select="witsml:rateBuild" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Delta MD from prev stn: </b> 
  <xsl:apply-templates select="witsml:mdDelta" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Delta TVD from prev stn: </b> 
  <xsl:apply-templates select="witsml:tvdDelta" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Survey tool: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Gavity uncert.: </b> 
  <xsl:apply-templates select="witsml:gravTotalUncert" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Dip uncert.: </b> 
  <xsl:apply-templates select="witsml:dipAngleUncert" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Magnetic uncert.: </b> 
  <xsl:apply-templates select="witsml:magTotalUncert" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Corr. used?: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Accelerometer align.?: </b> 
  <xsl:value-of select="witsml:gravAccelCorUsed" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Magnetometer align.?: </b> 
  <xsl:value-of select="witsml:magXAxialCorUsed" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>BHA sag?: </b> 
  <xsl:value-of select="witsml:sagCorUsed" /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Drl str mag.?: </b> 
  <xsl:value-of select="witsml:magDrlstrCorUsed" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td /> 
  <td colspan="8">
  <font size="-1">
  <b>Tool error model: </b> 
  <xsl:apply-templates select="witsml:modelToolError" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <!-- 		Check for a rawData	
  --> 
  <xsl:for-each select="witsml:rawData">
  <tr>
  <td colspan="9" align="center">
  <font size="-1">
  <b>Raw Data</b> 
  </font>
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!-- 		Check for a corUsed	
  --> 
  <xsl:for-each select="witsml:corUsed">
  <tr>
  <td colspan="9" align="center">
  <font size="-1">
  <b>Corrections Used</b> 
  </font>
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!-- 		Check for a valid (Validation data)	
  --> 
  <xsl:for-each select="witsml:valid">
  <tr>
  <td colspan="9" align="center">
  <font size="-1">
  <b>Validation Data</b> 
  </font>
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!-- 		Check for a matrixCov	
  --> 
  <xsl:for-each select="witsml:matrixCov">
  <tr>
  <td colspan="9" align="center">
  <font size="-1">
  <b>Covariance Matrix</b> 
  </font>
  </td>
  </tr>
  <xsl:apply-templates select="." /> 
  </xsl:for-each>
  <!-- 		Check for a location	
  --> 
  <xsl:if test="witsml:location">
    <tr>
      <td colspan="9" align="center">
        <font size="-1">
          <b>Trajectory Station Locations</b> 
        </font>
      </td>
    </tr>
    <xsl:for-each select="witsml:location">
      <xsl:apply-templates select="." /> 
    </xsl:for-each>
  </xsl:if>
  </xsl:template>
  <!-- 									rawData Template							
  --> 
  <xsl:template match="witsml:rawData">
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Uncorrected gravity field strength: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Axial dir.: </b> 
  <xsl:apply-templates select="witsml:gravAxialRaw" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 1: </b> 
  <xsl:apply-templates select="witsml:gravTran1Raw" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 2: </b> 
  <xsl:apply-templates select="witsml:gravTran2Raw" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Uncorrected magnetic field field strength: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Axial dir.: </b> 
  <xsl:apply-templates select="witsml:magAxialRaw" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 1: </b> 
  <xsl:apply-templates select="witsml:magTran1Raw" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 2: </b> 
  <xsl:apply-templates select="witsml:magTran2Raw" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									corUsed (Corrections Used) Template							
  --> 
  <xsl:template match="witsml:corUsed">
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Calc. grav. field Corrections used: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Axial dir.: </b> 
  <xsl:apply-templates select="witsml:gravAxialAccelCor" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 1: </b> 
  <xsl:apply-templates select="witsml:gravTran1AccelCor" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 2: </b> 
  <xsl:apply-templates select="witsml:gravTran2AccelCor" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Magnetic Drillstr corrections used: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Axial dir.: </b> 
  <xsl:apply-templates select="witsml:magAxialDrlstrCor" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 1: </b> 
  <xsl:apply-templates select="witsml:magTran1DrlstrCor" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Transverse dir. 2: </b> 
  <xsl:apply-templates select="witsml:magTran2DrlstrCor" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Magnetic declin. corr used: </b> 
  <xsl:apply-templates select="witsml:stnMagDeclUsed" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Grid corr. used</b> 
  <xsl:apply-templates select="witsml:stnGridCorUsed" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									valid (validation data) Template							
  --> 
  <xsl:template match="witsml:valid">
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Validation Data Used: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Calc. total mag. field: </b> 
  <xsl:apply-templates select="witsml:magTotalFieldCalc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Calc. mag. dip: </b> 
  <xsl:apply-templates select="witsml:magDipAngleCalc" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Calc. total grav. field: </b> 
  <xsl:apply-templates select="witsml:gravTotalFieldCalc" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									matrixCov Template							
  --> 
  <xsl:template match="witsml:matrixCov">
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Covariances/Crossvariances: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cov NN: </b> 
  <xsl:apply-templates select="witsml:varianceNN" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Crossvar NE: </b> 
  <xsl:apply-templates select="witsml:varianceNE" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Crossvar NV: </b> 
  <xsl:apply-templates select="witsml:varianceNVert" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b /> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cov EE: </b> 
  <xsl:apply-templates select="witsml:varianceEE" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Crossvar EV: </b> 
  <xsl:apply-templates select="witsml:varianceEVert" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Cov VV: </b> 
  <xsl:apply-templates select="witsml:varianceVertVert" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="3" align="right">
  <font size="-1">
  <b>Bias: </b> 
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>North: </b> 
  <xsl:apply-templates select="witsml:biasN" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>East: </b> 
  <xsl:apply-templates select="witsml:biasE" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Vertical: </b> 
  <xsl:apply-templates select="witsml:biasVert" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 					Location Template									
  --> 
  <xsl:template match="witsml:location">
  <tr>
  <td colspan="1" /> 
  <td colspan="1">
    <font size="-1">
      <b>uid: </b> 
      <xsl:value-of select="@uid" /> 
    </font>
  </td>
  <td colspan="1">
    <font size="-1">
      <b>CRS Name: </b> 
      <xsl:value-of select="witsml:nameWellCRS" /> 
    </font>
  </td>
  <td colspan="1">
    <font size="-1">
      <b>CRS uid: </b> 
      <xsl:value-of select="witsml:nameWellCRS/@uidRef" /> 
    </font>
  </td>
  <xsl:if test="witsml:latitude">
    <td colspan="1">
      <font size="-1">
        <b>Latitude: </b> 
        <xsl:apply-templates select="witsml:latitude" mode="valueWithUomRef"/>
      </font>
    </td>
    <td colspan="1">
      <font size="-1">
        <b>Longitude: </b> 
        <xsl:apply-templates select="witsml:longitude" mode="valueWithUomRef"/>
      </font>
    </td>
  </xsl:if>
  <xsl:if test="witsml:easting">
    <td colspan="1">
      <font size="-1">
        <b>Easting: </b> 
        <xsl:apply-templates select="witsml:easting" mode="valueWithUomRef"/>
      </font>
    </td>
    <td colspan="1">
      <font size="-1">
        <b>Northing: </b> 
        <xsl:apply-templates select="witsml:northing" mode="valueWithUomRef"/>
      </font>
    </td>
  </xsl:if>
  <xsl:if test="witsml:westing">
    <td colspan="1">
      <font size="-1">
        <b>Westing: </b> 
        <xsl:apply-templates select="witsml:westing" mode="valueWithUomRef"/>
      </font>
    </td>
    <td colspan="1">
      <font size="-1">
        <b>Southing: </b> 
        <xsl:apply-templates select="witsml:southing" mode="valueWithUomRef"/>
      </font>
    </td>
  </xsl:if>
  <xsl:if test="witsml:projectedX">
    <td colspan="1">
      <font size="-1">
        <b>Projected X: </b> 
        <xsl:apply-templates select="witsml:projectedX" mode="valueWithUomRef"/>
      </font>
    </td>
    <td colspan="1">
      <font size="-1">
        <b>Projected Y: </b> 
        <xsl:apply-templates select="witsml:projectedY" mode="valueWithUomRef"/>
      </font>
    </td>
  </xsl:if>
  <xsl:if test="witsml:localX">
    <td colspan="1">
      <font size="-1">
        <b>Local X: </b> 
        <xsl:apply-templates select="witsml:localX" mode="valueWithUomRef"/>
      </font>
    </td>
    <td colspan="1">
      <font size="-1">
        <b>Local Y: </b> 
        <xsl:apply-templates select="witsml:localY" mode="valueWithUomRef"/>
      </font>
    </td>
  </xsl:if>
  <td>
    <font size="-1">
      <b>Original?: </b>
      <xsl:choose>
        <xsl:when test="witsml:original='true'" >yes</xsl:when>
        <xsl:when test="witsml:original='1'"    >yes</xsl:when>
        <xsl:when test="witsml:original='false'">no</xsl:when>
        <xsl:when test="witsml:original='0'"    >no</xsl:when>
        <xsl:otherwise                          >no</xsl:otherwise>
      </xsl:choose>
    </font>
  </td>
  <td colspan="2">
    <font size="-1">
      <b>Description: </b> 
      <xsl:value-of select="witsml:description" /> 
    </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									weather Template							
  --> 
  <xsl:template match="witsml:weather">
  <tr>
  <td colspan="2">
  <font size="-1">
  <b>Precipitation: </b> 
  <xsl:value-of select="witsml:typePrecip" /> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Amt precip.: </b> 
  <xsl:apply-templates select="witsml:amtPrecip" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>Wind vel.: </b> 
  <xsl:apply-templates select="witsml:velWind" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1" align="right">
  <font size="-1">
  <b>Cloud: </b> 
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>cover: </b> 
  <xsl:apply-templates select="witsml:coverCloud" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="1">
  <font size="-1">
  <b>ceiling: </b> 
  <xsl:apply-templates select="witsml:ceilingCloud" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td /> 
  <td colspan="2">
  <font size="-1">
  <b>Curr. speed: </b> 
  <xsl:apply-templates select="witsml:currentSea" mode="valueWithUomRef"/>
  </font>
  </td>
  <td colspan="2">
  <font size="-1">
  <b>Azi. Curr. Sea: </b> 
  <xsl:apply-templates select="witsml:aziCurrentSea" mode="valueWithUomRef"/>
  </font>
  </td>
  </tr>
  <tr>
  <td /> 
  <td colspan="9">
  <font size="-1">
  <b>Comments: </b> 
  <xsl:value-of select="witsml:comments" /> 
  </font>
  </td>
  </tr>
  </xsl:template>
  <!-- 									Common Data Template							
  --> 
  <xsl:template match="witsml:commonData">
  <tr>
  <td colspan="3">
  <font size="-1">
  <b>User ID: </b> 
  <xsl:value-of select="witsml:nameSource" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>Time Stamp: </b> 
  <xsl:value-of select="witsml:dTimStamp" /> 
  </font>
  </td>
  <td colspan="3">
  <font size="-1">
  <b>State: </b> 
  <xsl:value-of select="witsml:itemState" /> 
  </font>
  </td>
  </tr>
  <tr>
  <td colspan="9">
  <font size="-1">
  <b>Comments: </b> 
  <xsl:value-of select="witsml:comments" /> 
  </font>
  </td>
  </tr>
  </xsl:template>


  </xsl:stylesheet>
