<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML cementJob Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="9" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="9"><font size="+2" color="blue">Cement Job Information</font></th></tr>
		<xsl:for-each select="witsml:cementJobs">
			<xsl:for-each select="witsml:cementJob">
				<tr>	<td colspan="4"><font size="+1" color="blue">uidWell: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="4"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="4"><font size="-1" color="blue"><b>uidWellbore: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="4"><font size="-1" color="blue"><b>uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="4"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="4"><font size="-1" color="blue"><b>Cement Job Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>	
				<tr><td colspan="2"><font size="-1"><b>Job date: </b><xsl:value-of select="witsml:dTimJob"/></font></td>
					<td colspan="3"><font size="-1"><b>Job type: </b><xsl:value-of select="witsml:jobType"/></font></td>
					<td colspan="3"><font size="-1"><b>Job config.: </b><xsl:value-of select="witsml:jobConfig"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Cemented string: </b><xsl:value-of select="witsml:nameCementedString"/></font></td>
					<td colspan="3"><font size="-1"><b>Work string: </b><xsl:value-of select="witsml:nameWorkString"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Contractor: </b><xsl:value-of select="witsml:contractor"/></font></td>
					<td colspan="2"><font size="-1"><b>Cement Engr: </b><xsl:value-of select="witsml:cementEngr"/></font></td>
					<td colspan="1"><font size="-1"><b>Offshore?: </b><xsl:value-of select="witsml:offshoreJob"/></font></td>
					<td colspan="1"><font size="-1"><b>MD water: </b><xsl:apply-templates select="witsml:mdWater" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Returns to seabed?: </b><xsl:value-of select="witsml:returnsToSeabed"/></font></td>
					<td colspan="1"><font size="-1"><b>Reciprocating?: </b><xsl:value-of select="witsml:reciprocating"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Wait on cement: </b><xsl:apply-templates select="witsml:woc" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD top plug: </b><xsl:apply-templates select="witsml:mdPlugTop" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD bot. plug: </b><xsl:apply-templates select="witsml:mdPlugBot" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD hole: </b><xsl:apply-templates select="witsml:mdHole" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD shoe: </b><xsl:apply-templates select="witsml:mdShoe" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>TVD shoe: </b><xsl:apply-templates select="witsml:tvdShoe" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>MD cement string shoe: </b><xsl:apply-templates select="witsml:mdStringSet" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>TVD  cement string shoe: </b><xsl:apply-templates select="witsml:tvdStringSet" mode="valueWithUomRef"/></font></td></tr>

				<tr><td colspan="2"><font size="-1"><b>Plug type: </b><xsl:value-of select="witsml:typePlug"/></font></td>
					<td colspan="3"><font size="-1"><b>Cementing string: </b><xsl:value-of select="witsml:nameCementString"/></font></td>
					<td colspan="2"><font size="-1"><b>Plug set: </b><xsl:value-of select="witsml:dTimPlugSet"/></font></td></tr>
					
				<!--		see if cement was drilled out	-->
				<xsl:if test="witsml:cementDrillOut">
					<tr><td colspan="2"><font size="-1"><b>Cement drilled out?: </b><xsl:value-of select="witsml:cementDrillOut"/></font></td>
						<td colspan="3"><font size="-1"><b>Date drilled out: </b><xsl:value-of select="witsml:dTimCementDrillOut"/></font></td></tr>
				</xsl:if>
				
				<!--		see if type of sqeeze specified	-->
				<xsl:if test="witsml:typeSqueeze">
					<tr><td colspan="2"><font size="-1"><b>Type squeeze: </b><xsl:value-of select="witsml:typeSqueeze"/></font></td>
						<td colspan="3"><font size="-1"><b>MD Squeeze: </b><xsl:apply-templates select="witsml:mdSqueeze" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Squeeze date: </b><xsl:value-of select="witsml:dTimSqueeze"/></font></td></tr>
				</xsl:if>

				<tr><td colspan="2"><font size="-1"><b>Tool company: </b><xsl:value-of select="witsml:toolCompany"/></font></td>
					<td colspan="3"><font size="-1"><b>Tool type: </b><xsl:value-of select="witsml:typeTool"/></font></td></tr>
					
				<!--		see if pipe rotation specified	-->
				<xsl:if test="witsml:dTimPipeRotStart">
					<tr>	<td colspan="1" align="right"><font size="-1"><b>Pipe rotation: </b></font></td>
						<td colspan="3"><font size="-1"><b>Start time: </b><xsl:value-of select="witsml:dTimPipeRotStart"/></font></td>
						<td colspan="3"><font size="-1"><b>End time: </b><xsl:value-of select="witsml:dTimPipeRotEnd"/></font></td></tr>
					<tr><td colspan="1" align="right"><font size="-1"><b></b></font></td>
						<td colspan="2"><font size="-1"><b>RPM: </b><xsl:apply-templates select="witsml:rpmPipe" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Initial torq.: </b><xsl:apply-templates select="witsml:tqInitPipeRot" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Avg torg.: </b><xsl:apply-templates select="witsml:tqPipeAv" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Max torg.: </b><xsl:apply-templates select="witsml:tqPipeMx" mode="valueWithUomRef"/></font></td></tr>
				</xsl:if>

				<!--		see if pipe recipricating is specified	-->
				<xsl:if test="witsml:dTimRecipStart">
					<tr>	<td colspan="1" align="right"><font size="-1"><b>Pipe reciprocation: </b></font></td>
						<td colspan="3"><font size="-1"><b>Start time: </b><xsl:value-of select="witsml:dTimRecipStart"/></font></td>
						<td colspan="3"><font size="-1"><b>End time: </b><xsl:value-of select="witsml:dTimRecipEnd"/></font></td></tr>
					<tr><td colspan="1" align="right"><font size="-1"><b></b></font></td>
						<td colspan="2"><font size="-1"><b>RPM: </b><xsl:apply-templates select="witsml:rpmPipeRecip" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Stroke length: </b><xsl:apply-templates select="witsml:lenPipeRecipStroke" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Overpull: </b><xsl:apply-templates select="witsml:overPull" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Slackoff: </b><xsl:apply-templates select="witsml:slackOff" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Coil tbg used?: </b><xsl:value-of select="witsml:coilTubing"/></font></td></tr>
				</xsl:if>
				
				<!--		Check for a wbGeometry		-->	
				<xsl:for-each select="witsml:wbGeometry">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Wellbore Geometry</font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a cementStage		-->	
				<xsl:for-each select="witsml:cementStage">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Cement Stage</font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a cementTest		-->	
				<xsl:for-each select="witsml:cementTest">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Cement Test</font></td></tr>
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
	
	<!--									wbGeometry Template							-->
	<xsl:template match="witsml:wbGeometry">				
	</xsl:template>
	
	<!--									cementStage Template							-->
	<xsl:template match="witsml:cementStage">				
				<tr><td colspan="2"><font size="-1"><b>Stage no: </b><xsl:value-of select="witsml:numStage"/></font></td>
					<td colspan="2"><font size="-1"><b>Type: </b><xsl:value-of select="witsml:typeStage"/></font></td>
					<td colspan="2"><font size="-1"><b>MD top of cement: </b><xsl:apply-templates select="witsml:mdTop" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>MD bot. of cement: </b><xsl:apply-templates select="witsml:mdBottom" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Mixing started: </b><xsl:value-of select="witsml:dTimMixStart"/></font></td>
					<td colspan="2"><font size="-1"><b>Pumping started: </b><xsl:value-of select="witsml:dTimPumpStart"/></font></td>
					<td colspan="2"><font size="-1"><b>Pumping ended: </b><xsl:value-of select="witsml:dTimPumpEnd"/></font></td>
					<td colspan="3"><font size="-1"><b>Start displacing cement: </b><xsl:value-of select="witsml:dTimDisplaceStart"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Vol. excess: </b><xsl:apply-templates select="witsml:volExcess" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Displacement: - Avg rate: </b><xsl:apply-templates select="witsml:flowrateDisplaceAv" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>- Max rate: </b><xsl:apply-templates select="witsml:flowrateDisplaceMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>- Final press.: </b><xsl:apply-templates select="witsml:presDisplace" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vol. returns: </b><xsl:apply-templates select="witsml:volReturns" mode="valueWithUomRef"/></font></td></tr>	
				<tr><td colspan="1" align="right"><font size="-1"><b>Mud circulation: </b></font></td>
					<td colspan="2"><font size="-1"><b>Time before job: </b><xsl:apply-templates select="witsml:eTimMudCirculation" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Mud rate: </b><xsl:apply-templates select="witsml:flowrateMudCirc" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Pressure: </b><xsl:apply-templates select="witsml:presMudCirc" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Final displ. pump rate: </b><xsl:apply-templates select="witsml:flowrateEnd" mode="valueWithUomRef"/></font></td></tr>	
				<tr>	<td colspan="2"><font size="-1"><b>Annular flow after displ.: </b><xsl:value-of select="witsml:afterFlowAnn"/></font></td>
					<td colspan="4"><font size="-1"><b>Squeeze Obj.: </b><xsl:value-of select="witsml:squeezeObj"/></font></td>
					<td colspan="2"><font size="-1"><b>Squeeze obtained?: </b><xsl:value-of select="witsml:squeezeObtained"/></font></td></tr>	
				<tr>	<td colspan="1"><font size="-1"><b>MD string: </b><xsl:apply-templates select="witsml:mdString" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD Tool: </b><xsl:apply-templates select="witsml:mdTool" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>MD coil tbg: </b><xsl:apply-templates select="witsml:mdCoilTbg" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vol. inside csg: </b><xsl:apply-templates select="witsml:volCsgIn" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vol. outside csg: </b><xsl:apply-templates select="witsml:volCsgOut" mode="valueWithUomRef"/></font></td></tr>	
				<tr>	<td colspan="1"><font size="-1"><b>Tail pipe used?</b>  <xsl:value-of select="witsml:tailPipeUsed"/></font></td>
					<td colspan="2"><font size="-1"><b>Tail pipe dia.: </b><xsl:apply-templates select="witsml:diaTailPipe" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Perforated tail pipe: </b><xsl:value-of select="witsml:tailPipePerf"/></font></td>
					</tr>	
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Tubing pressure: </b></font></td>
					<td colspan="1"><font size="-1"><b>at start: </b><xsl:apply-templates select="witsml:presTbgStart" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>at end: </b><xsl:apply-templates select="witsml:presTbgEnd" mode="valueWithUomRef"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Casing pressure: </b></font></td>
					<td colspan="1"><font size="-1"><b>at start: </b><xsl:apply-templates select="witsml:presCsgStart" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>at end: </b><xsl:apply-templates select="witsml:presCsgEnd" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Back press. applied when pumping</b>  <xsl:apply-templates select="witsml:prsBackPressure" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Pressure: </b></font></td>
					<td colspan="1"><font size="-1"><b>CTU start: </b><xsl:apply-templates select="witsml:presCoilTbgStart" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>CTU end: </b><xsl:apply-templates select="witsml:presCoilTbgEnd" mode="valueWithUomRef"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Breakdown: </b></font></td>
					<td colspan="2"><font size="-1"><b>pressure: </b><xsl:apply-templates select="witsml:presBreakDown" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>rate: </b><xsl:apply-templates select="witsml:flowrateBreakDown" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Squeeze pressure: </b></font></td>
					<td colspan="1"><font size="-1"><b>avg: </b><xsl:apply-templates select="witsml:presSqueezeAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>final: </b><xsl:apply-templates select="witsml:presSqueezeEnd" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>held?: </b><xsl:apply-templates select="witsml:presBreakHeld" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>left on pipe: </b><xsl:apply-templates select="witsml:presSqueeze" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>time press. held: </b><xsl:apply-templates select="witsml:eTimPresHeld" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Squeeze rate: </b></font></td>
					<td colspan="1"><font size="-1"><b>avg: </b><xsl:apply-templates select="witsml:flowrateSqueezeAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>max: </b><xsl:apply-templates select="witsml:flowrateSqueezeMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Pump rate: </b></font></td>					
					<td colspan="2"><font size="-1"><b>at start: </b><xsl:apply-templates select="witsml:flowratePumpStart" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>at end: </b><xsl:apply-templates select="witsml:flowratePumpEnd" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b>Pill below plug?</b>  <xsl:value-of select="witsml:pillBelowPlug"/></font></td>
					<td colspan="2"><font size="-1"><b>Plug catcher?: </b><xsl:value-of select="witsml:plugCatcher"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Circulate: </b></font></td>	
					<td colspan="2"><font size="-1"><b>out MD: </b><xsl:apply-templates select="witsml:mdCircOut" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>prior to start: </b><xsl:apply-templates select="witsml:volCircPrior" mode="valueWithUomRef"/></font></td></tr>	
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Mud: </b></font></td>
					<td colspan="2"><font size="-1"><b>type in hole: </b><xsl:value-of select="witsml:typeOriginalMud"/></font></td>
					<td colspan="1"><font size="-1"><b>wgt.: </b><xsl:apply-templates select="witsml:wtMud" mode="valueWithUomRef"/></font></td>				
					<td colspan="1"><font size="-1"><b>funnel visc: </b><xsl:apply-templates select="witsml:visFunnelMud" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>plastic visc.: </b><xsl:apply-templates select="witsml:pvMud" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>yield point: </b><xsl:apply-templates select="witsml:ypMud" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Gel 10 sec: </b><xsl:apply-templates select="witsml:gel10Sec" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Gel 10 min: </b><xsl:apply-templates select="witsml:gel10Min" mode="valueWithUomRef"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Bottom hole: </b></font></td>	
					<td colspan="1"><font size="-1"><b>circ. temp: </b><xsl:apply-templates select="witsml:tempBHCT" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>static temp: </b><xsl:apply-templates select="witsml:tempBHST" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1"><b>Method to est. excess vol.: </b><xsl:value-of select="witsml:volExcessMethod"/></font></td>
					<td colspan="3"><font size="-1"><b>Mix Method: </b><xsl:value-of select="witsml:mixMethod"/></font></td>
					<td colspan="3"><font size="-1"><b>Dens. meas. method: </b><xsl:value-of select="witsml:densMeasBy"/></font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b>Fluid returns?</b>  <xsl:value-of select="witsml:annFlowAfter"/></font></td>
					<td colspan="2"><font size="-1"><b>Top plug used?: </b><xsl:value-of select="witsml:topPlug"/></font></td>
					<td colspan="2"><font size="-1"><b>Bottom plug used?: </b><xsl:value-of select="witsml:botPlug"/></font></td>
					<td colspan="1"><font size="-1"><b>No. of bot. plugs: </b><xsl:value-of select="witsml:botPlugNumber"/></font></td>
					<td colspan="3"><font size="-1"><b>Plug bumped?: </b><xsl:value-of select="witsml:plugBumped"/></font></td></tr>	
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Pressure: </b></font></td>
					<td colspan="2"><font size="-1"><b>prior to bump: </b><xsl:apply-templates select="witsml:presPriorBump" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>of bump: </b><xsl:apply-templates select="witsml:presBump" mode="valueWithUomRef"/></font></td>				
					<td colspan="1"><font size="-1"><b>held to: </b><xsl:apply-templates select="witsml:presHeld" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Float held?: </b><xsl:value-of select="witsml:floatHeld"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Total mud lost: </b><xsl:apply-templates select="witsml:volMudLost" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Fluid displaced: </b><xsl:value-of select="witsml:fluidDisplace"/></font></td>				
					<td colspan="2"><font size="-1"><b>Dens. of displ fluid: </b><xsl:apply-templates select="witsml:densDisplaceFluid" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vol. of displ fluid: </b><xsl:apply-templates select="witsml:volDisplaceFluid" mode="valueWithUomRef"/></font></td></tr>

				<!--		Check for a cementFluid tag	-->	
				<xsl:for-each select="witsml:cementingFluid">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Cementing Fluid Information</font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>
	</xsl:template>	

	<!--									cementingFluid Template							-->
	<xsl:template match="witsml:cementingFluid">				
				<tr><td colspan="1"><font size="-1"><b>Fluid index: </b><xsl:value-of select="witsml:fluidIndex"/></font></td>
					<td colspan="2"><font size="-1"><b>Type: </b><xsl:value-of select="witsml:typeFluid"/></font></td>
					<td colspan="3"><font size="-1"><b>Descr.: </b><xsl:value-of select="witsml:descFluid"/></font></td>
					<td colspan="3"><font size="-1"><b>Purpose: </b><xsl:value-of select="witsml:purpose"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b>Slurry class: </b><xsl:value-of select="witsml:classSlurryDryBlend"/></font></td>
					<td colspan="2"><font size="-1"><b>MD at top of slurry: </b><xsl:apply-templates select="witsml:mdFluidTop" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>MD at bot. of slurry: </b><xsl:apply-templates select="witsml:mdFluidBottom" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Water source: </b><xsl:value-of select="witsml:sourceWater"/></font></td>
					<td colspan="2"><font size="-1"><b>Water vol.: </b><xsl:apply-templates select="witsml:volWater" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b>Cement vol.: </b><xsl:apply-templates select="witsml:volCement" mode="valueWithUomRef"/></font></td>					
					<td colspan="2"><font size="-1"><b>Mix water ratio: </b><xsl:apply-templates select="witsml:ratioMixWater" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Fluid/Slurry vol.: </b><xsl:apply-templates select="witsml:volFluid" mode="valueWithUomRef"/></font></td>	</tr>
				<tr><td colspan="1"><font size="-1"><b>Excess Pct: </b><xsl:apply-templates select="witsml:excessPc" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Slurry yield: </b><xsl:apply-templates select="witsml:volYield" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Slurry density: </b><xsl:apply-templates select="witsml:density" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Solid vol. fraction: </b><xsl:apply-templates select="witsml:solidVolumeFraction" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Vol. pumped: </b><xsl:apply-templates select="witsml:volPumped" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vol. other: </b><xsl:apply-templates select="witsml:volOther" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Rheological model: </b><xsl:value-of select="witsml:fluidRheologicalModel"/></font></td>			
					<td colspan="1"><font size="-1"><b>Viscosity: </b><xsl:apply-templates select="witsml:vis" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Yield point: </b><xsl:apply-templates select="witsml:yp" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Power law index: </b><xsl:apply-templates select="witsml:n" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Consistency index: </b><xsl:apply-templates select="witsml:k" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Gel reading: </b></font></td>			
					<td colspan="2"><font size="-1"><b>10 sec read.: </b><xsl:apply-templates select="witsml:gel10SecReading" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>1 min read.: </b><xsl:apply-templates select="witsml:gel1MinReading" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>10 min read.: </b><xsl:apply-templates select="witsml:gel10MinReading" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Gel strength: </b></font></td>			
					<td colspan="2"><font size="-1"><b>10 sec stren.: </b><xsl:apply-templates select="witsml:gel10SecStrength" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>1 min stren.: </b><xsl:apply-templates select="witsml:gel1MinStrength" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>10 min stren.: </b><xsl:apply-templates select="witsml:gel10MinStrength" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Base fluid: </b></font></td>			
					<td colspan="2"><font size="-1"><b>Type: </b><xsl:value-of select="witsml:typeBaseFluid"/></font></td>
					<td colspan="1"><font size="-1"><b>Density: </b><xsl:apply-templates select="witsml:densBaseFluid" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Dry blend: </b></font></td>			
					<td colspan="2"><font size="-1"><b>name: </b><xsl:value-of select="witsml:dryBlendName"/></font></td>
					<td colspan="2"><font size="-1"><b>desc: </b><xsl:value-of select="witsml:dryBlendDescription"/></font></td>
					<td colspan="1"><font size="-1"><b>mass: </b><xsl:apply-templates select="witsml:massDryBlend" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>density: </b><xsl:apply-templates select="witsml:densDryBlend" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>wgt per sack: </b><xsl:apply-templates select="witsml:massSackDryBlend" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b>Foam used?: </b><xsl:value-of select="witsml:foamUsed"/></font></td>
					<td colspan="2"><font size="-1"><b>Type: </b><xsl:value-of select="witsml:typeGasFoam"/></font></td>
					<td colspan="1"><font size="-1"><b>Vol. used: </b><xsl:apply-templates select="witsml:volGasFoam" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Const. gas ratio: </b></font></td>			
					<td colspan="1"><font size="-1"><b>avg: </b><xsl:apply-templates select="witsml:ratioConstGasMethodAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>dens: </b><xsl:apply-templates select="witsml:densConstGasMethod" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>init. ratio: </b><xsl:apply-templates select="witsml:ratioConstGasMethodStart" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>final ratio: </b><xsl:apply-templates select="witsml:ratioConstGasMethodEnd" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>avg. dens.: </b><xsl:apply-templates select="witsml:densConstGasFoam" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Test thickening: </b></font></td>			
					<td colspan="1"><font size="-1"><b>time: </b><xsl:apply-templates select="witsml:eTimThickening" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>temp: </b><xsl:apply-templates select="witsml:tempThickening" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>press.: </b><xsl:apply-templates select="witsml:presTestThickening" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>consist.: </b><xsl:apply-templates select="witsml:consTestThickening" mode="valueWithUomRef"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Test free water: </b></font></td>			
					<td colspan="1"><font size="-1"><b>ratio: </b><xsl:value-of select="witsml:pcFreeWater"/></font></td>
					<td colspan="1"><font size="-1"><b>temp: </b><xsl:apply-templates select="witsml:tempFreeWater" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Test fluid loss: </b></font></td>
					<td colspan="1"><font size="-1"><b>vol.: </b><xsl:apply-templates select="witsml:volTestFluidLoss" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>temp.: </b><xsl:apply-templates select="witsml:tempFluidLoss" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>press: </b><xsl:apply-templates select="witsml:presTestFluidLoss" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>period: </b><xsl:apply-templates select="witsml:timeFluidLoss" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>API fluid loss: </b><xsl:apply-templates select="witsml:volAPIFluidLoss" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Compress. stren.: </b></font></td>
					<td colspan="1"><font size="-1"><b>time 1: </b><xsl:apply-templates select="witsml:eTimComprStren1" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>time 2: </b><xsl:apply-templates select="witsml:eTimComprStren2" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>press 1: </b><xsl:apply-templates select="witsml:presComprStren1" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>press 2: </b><xsl:apply-templates select="witsml:presComprStren2" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>temp 1: </b><xsl:apply-templates select="witsml:tempComprStren1" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>temp 2: </b><xsl:apply-templates select="witsml:tempComprStren2" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Slurry dens at press.: </b><xsl:apply-templates select="witsml:densAtPres" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vol. reserved: </b><xsl:apply-templates select="witsml:volReserved" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Tot. slurry vol.: </b><xsl:apply-templates select="witsml:volTotSlurry" mode="valueWithUomRef"/></font></td></tr>

				<!--		Check for a cementPumpSchedule tag	-->	
				<xsl:for-each select="witsml:cementPumpSchedule">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Cement Pump Schedule</font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--  	Only create heading when additives exist and only show once	-->
				<xsl:if test="witsml:cementAdditive">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Cement Additive</font></td></tr>
				</xsl:if>

				<!--		Check for a cementAdditive tag	-->	
				<xsl:for-each select="witsml:cementAdditive">
					<xsl:apply-templates select="."/>
				</xsl:for-each>
	</xsl:template>

	<!--									cementAdditive Template							-->
	<xsl:template match="witsml:cementAdditive">					
				<tr><td colspan="3"><font size="-1"><b>Name: </b><xsl:value-of select="witsml:nameAdd"/></font></td>
					<td colspan="3"><font size="-1"><b>Type: </b><xsl:value-of select="witsml:typeAdd"/></font></td>
					<td colspan="3"><font size="-1"><b>Form: </b><xsl:value-of select="witsml:formAdd"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Density: </b><xsl:apply-templates select="witsml:densAdd" mode="valueWithUomRef"/></font></td>
					<td colspan="6"><font size="-1"><b>Additive amt: </b><xsl:apply-templates select="witsml:additive" mode="valueWithUomRef"/></font></td>
				</tr>
				<tr>
					<xsl:if test="witsml:typeConc">
						<td colspan="3"><font size="-1"><b>Type concen.: </b><xsl:value-of select="witsml:typeConc"/></font></td>
						<td colspan="6"><font size="-1"><b>Concentration: </b><xsl:apply-templates select="witsml:concentration" mode="valueWithUomRef"/></font></td>
					</xsl:if>
					<xsl:if test="witsml:wtSack">
						<td colspan="9"><font size="-1"><b>Weight per Sack: </b><xsl:apply-templates select="witsml:wtSack" mode="valueWithUomRef"/></font></td>
					</xsl:if>
					<xsl:if test="witsml:volSack">
						<td colspan="9"><font size="-1"><b>Volume per Sack: </b><xsl:apply-templates select="witsml:volSack" mode="valueWithUomRef"/></font></td>
					</xsl:if>
				</tr>
	</xsl:template>		

	<!--									cementPumpSchedule Template							-->
	<xsl:template match="witsml:cementPumpSchedule">					
				<tr><td colspan="2"><font size="-1"><b>Pump period: </b><xsl:apply-templates select="witsml:eTimPump" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Pump rate: </b><xsl:apply-templates select="witsml:ratePump" mode="valueWithUomRef"/></font></td>					
					<td colspan="2"><font size="-1"><b>Vol. pumped: </b><xsl:apply-templates select="witsml:volPump" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Pump stroke: </b><xsl:value-of select="witsml:strokePump"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Back pressure: </b><xsl:apply-templates select="witsml:presBack" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Shutdown period: </b><xsl:apply-templates select="witsml:eTimShutdown" mode="valueWithUomRef"/></font></td></tr>					
				<tr><td colspan="9"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:comments"/></font></td></tr>
	</xsl:template>		

	<!--									cementTest Template							-->
	<xsl:template match="witsml:cementTest">					
				<tr><td colspan="2"><font size="-1"><b>Test press.: </b><xsl:apply-templates select="witsml:presTest" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Test period: </b><xsl:apply-templates select="witsml:eTimTest" mode="valueWithUomRef"/></font></td>					
					<td colspan="2"><font size="-1"><b>Cem. between shoe and collar?: </b><xsl:value-of select="witsml:cementShoeCollar"/></font></td>
					<td colspan="3"><font size="-1"><b>Cet run?: </b><xsl:value-of select="witsml:cetRun"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Cet bond qual?: </b><xsl:value-of select="witsml:cetBondQual"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Cem. bond log: </b></font></td>
					<td colspan="1"><font size="-1"><b>run?: </b><xsl:value-of select="witsml:cblRun"/></font></td>
					<td colspan="1"><font size="-1"><b>qual?: </b><xsl:value-of select="witsml:cblBondQual"/></font></td>
					<td colspan="2"><font size="-1"><b>CBL under press: </b><xsl:apply-templates select="witsml:cblPres" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Temp survey run?: </b><xsl:value-of select="witsml:tempSurvey"/></font></td>
					<td colspan="2"><font size="-1"><b>Hrs before log run, after cem.: </b><xsl:apply-templates select="witsml:eTimCementLog" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Form. press.: </b><xsl:apply-templates select="witsml:formPit" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>PIT tool name: </b><xsl:value-of select="witsml:toolCompanyPit"/></font></td></tr>				
				<tr><td colspan="2"><font size="-1"><b>eTime to PIT start: </b><xsl:apply-templates select="witsml:eTimPitStart" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>MD top cement: </b><xsl:apply-templates select="witsml:mdCementTop" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Method to deter. top: </b><xsl:value-of select="witsml:topCementMethod"/></font></td>
					<td colspan="2"><font size="-1"><b>TOC suff.?: </b><xsl:value-of select="witsml:tocOK"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Job rating: </b><xsl:value-of select="witsml:jobRating"/></font></td>
					<td colspan="2"><font size="-1"><b>Remedial cem. reqd?: </b><xsl:value-of select="witsml:remedialCement"/></font></td>
					<td colspan="2"><font size="-1"><b>No. of remedials: </b><xsl:value-of select="witsml:numRemedial"/></font></td>
					<td colspan="3"><font size="-1"><b>Failure method: </b><xsl:value-of select="witsml:failureMethod"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Liner top: </b><xsl:apply-templates select="witsml:linerTop" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Liner length: </b><xsl:apply-templates select="witsml:linerLap" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Hrs before liner top test: </b><xsl:apply-templates select="witsml:eTimBeforeTest" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>MD DV Tool: </b><xsl:apply-templates select="witsml:mdDVTool" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Test neg.: </b></font></td>
					<td colspan="2"><font size="-1"><b>Tool: </b><xsl:value-of select="witsml:testNegativeTool"/></font></td>
					<td colspan="1"><font size="-1"><b>EMW: </b><xsl:apply-templates select="witsml:testNegativeEmw" mode="valueWithUomRef"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Test pos.: </b></font></td>
					<td colspan="2"><font size="-1"><b>Tool: </b><xsl:value-of select="witsml:testPositiveTool"/></font></td>
					<td colspan="2"><font size="-1"><b>EMW: </b><xsl:apply-templates select="witsml:testPositiveEmw" mode="valueWithUomRef"/></font></td>
				</tr>
	</xsl:template>		


	<!--									Common Data Template							-->
	<xsl:template match="witsml:commonData">					
				<tr><td colspan="3"><font size="-1"><b>User ID: </b><xsl:value-of select="witsml:nameSource"/></font></td>
					<td colspan="3"><font size="-1"><b>Time Stamp: </b><xsl:value-of select="witsml:dTimStamp"/></font></td>
					<td colspan="3"><font size="-1"><b>State: </b><xsl:value-of select="witsml:itemState"/></font></td></tr>
				<tr><td colspan="9"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:comments"/></font></td></tr>
	</xsl:template>	


</xsl:stylesheet>
