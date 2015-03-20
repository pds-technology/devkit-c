<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Rig Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="6" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="6"><font size="+2" color="blue">Rig Information</font></th></tr>
		<xsl:for-each select="witsml:rigs">
			<xsl:for-each select="witsml:rig">
				<tr>	<td colspan="2"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="6"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">Rig Data</font></td></tr>
				<tr>	<td colspan="2"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="6"><font size="-1" color="blue"><b>Rig uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="6"><font size="-1" color="blue"><b>Rig Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
				<tr><td colspan="2"><b>Owner:  </b><xsl:value-of select="witsml:owner"/></td>
					<td><b>Type: </b>  <xsl:value-of select="witsml:typeRig"/></td>
					<td><b>Yr in Service:  </b><xsl:value-of select="witsml:yearEntService"/></td>
					<td><b>State:  </b><xsl:value-of select="witsml:itemState"/></td></tr>
				<tr><td colspan="2"><b>Mfgr:  </b><xsl:value-of select="witsml:manufacturer"/></td>
					<td colspan="2"><b>Rig class: </b>  <xsl:value-of select="witsml:classRig"/></td></tr>
				<tr><td colspan="2"><b>Approvals:  </b><xsl:value-of select="witsml:approvals"/></td>
					<td colspan="2"><b>Registration: </b>  <xsl:value-of select="witsml:registration"/></td></tr>
				<tr><td colspan="2"><b>Contact:  </b><xsl:value-of select="witsml:nameContact"/></td></tr>
				<tr><td><b>Tel: </b><xsl:value-of select="witsml:telNumber"/></td><td><b>Fax: </b><xsl:value-of select="witsml:faxNumber"/></td><td colspan="3"><b>email: </b><xsl:value-of select="witsml:emailAddress"/></td></tr>
				<tr><td colspan="2"><b>Rig Operations Started: </b>   <xsl:value-of select="witsml:dTimStartOp"/></td>
					<td colspan="2"><b>Rig Operations Ended: </b> <xsl:value-of select="witsml:dTimEndOp"/></td></tr>

				<tr><td colspan="6" align="center"><font size="+1" color="blue">Rig References, Ratings, Capacities, and Specifications</font></td></tr>

				<tr><td><b>Water Depth Rating: </b>  <xsl:apply-templates select="witsml:ratingWaterDepth" mode="valueWithUomRef"/></td>
					<td><b>Is Offshore?</b>  <xsl:value-of select="witsml:isOffshore"/></td>
					<td><b>Air gap: </b>  <xsl:apply-templates select="witsml:airGap" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Max. hole depth rating: </b>  <xsl:apply-templates select="witsml:ratingDrillDepth" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Rotary System: </b></td>
					<td colspan="2"><xsl:value-of select="witsml:rotSystem"/></td>
					<td colspan="2"><b>Desc.</b>  <xsl:value-of select="witsml:descRotSystem"/></td></tr>
				<tr><td><b> </b></td>
					<td><b>Rating: </b>  <xsl:apply-templates select="witsml:ratingRotSystem" mode="valueWithUomRef"/></td>
					<td><b>Torque rating: </b>  <xsl:apply-templates select="witsml:ratingTqRotSys" mode="valueWithUomRef"/></td>
					<td><b>Rotary size opening: </b>  <xsl:apply-templates select="witsml:rotSizeOpening" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Pipe handling system: </b></td>
					<td colspan="3" ><xsl:value-of select="witsml:pipeHandlingSystem"/></td></tr>		
				<tr><td align="right"><b>Power system: </b></td>
					<td colspan="2"><xsl:value-of select="witsml:mainEngine"/></td>
					<td colspan="2"><b>Generator: </b>  <xsl:value-of select="witsml:generator"/></td></tr>
				<tr><td align="right"><b>Derrick: </b></td><td><b>Number: </b>  <xsl:value-of select="witsml:numDerricks"/></td>
					<td><b>Type: </b>  <xsl:value-of select="witsml:typeDerrick"/></td>
					<td><b>Rating: </b>  <xsl:apply-templates select="witsml:ratingDerrick" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b> </b></td>
					<td><b>Height: </b>  <xsl:apply-templates select="witsml:htDerrick" mode="valueWithUomRef"/></td>
					<td><b>Wind cap.: </b>  <xsl:apply-templates select="witsml:capWindDerrick" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Block: </b></td>
					<td><b>No. Block Lines: </b>  <xsl:value-of select="witsml:numBlockLines"/></td>
					<td><b>Block wt: </b>  <xsl:apply-templates select="witsml:wtBlock" mode="valueWithUomRef"/></td>
					<td><b>Block rating: </b>  <xsl:apply-templates select="witsml:ratingBlock" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b> </b></td>
					<td><b>Drill line size: </b>  <xsl:apply-templates select="witsml:sizeDrillLine" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Hook: </b></td>
					<td><b>Type: </b>  <xsl:value-of select="witsml:typeHook"/></td>
					<td><b>Max load rating: </b>  <xsl:apply-templates select="witsml:ratingHkld" mode="valueWithUomRef"/></td>
					<td><b>Rating: </b>  <xsl:apply-templates select="witsml:ratingHook" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Drawworks: </b></td><td colspan="2"><b>Type: </b>  <xsl:value-of select="witsml:typeDrawWorks"/></td>
					<td><b>Power: </b>  <xsl:apply-templates select="witsml:powerDrawWorks" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b> </b></td>
					<td colspan="2"><b>Motor: </b>  <xsl:value-of select="witsml:motorDrawWorks"/></td>
					<td><b>Rating: </b>  <xsl:apply-templates select="witsml:ratingDrawWorks" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Brake: </b></td><td colspan="2"><xsl:value-of select="witsml:descBrake"/></td></tr>
				<tr><td align="right"><b>Swivel: </b></td>
					<td colspan="2"><b>Type: </b>  <xsl:value-of select="witsml:typeSwivel"/></td>
					<td><b>Rating: </b>  <xsl:apply-templates select="witsml:ratingSwivel" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>SCR System: </b></td>
					<td colspan="3"><xsl:value-of select="witsml:scrSystem"/></td></tr>
				<tr><td align="right"><b>Cement unit: </b></td>  
					<td colspan="3"><xsl:value-of select="witsml:cementUnit"/></td></tr>
				<tr><td align="right"><b>Capacity: </b></td><td><b>Bulk Mud: </b>  <xsl:apply-templates select="witsml:capBulkMud" mode="valueWithUomRef"/></td>
					<td><b>Liquid Mud: </b>  <xsl:apply-templates select="witsml:capLiquidMud" mode="valueWithUomRef"/></td>
					<td><b>Drill Water: </b>  <xsl:apply-templates select="witsml:capDrillWater" mode="valueWithUomRef"/></td></tr>
				<tr><td></td><td><b>Potable Water: </b>  <xsl:apply-templates select="witsml:capPotableWater" mode="valueWithUomRef"/></td>
					<td><b>Fuel: </b>  <xsl:apply-templates select="witsml:capFuel" mode="valueWithUomRef"/></td>
					<td><b>Bulk Cement: </b>  <xsl:apply-templates select="witsml:capBulkCement" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Number: </b></td><td><b>Bunks: </b>  <xsl:value-of select="witsml:numBunks"/></td>
					<td><b>Bunks per room: </b>  <xsl:value-of select="witsml:bunksPerRoom"/></td>
					<td><b>Cranes: </b>  <xsl:value-of select="witsml:numCranes"/></td>
					<td><b>Anchors: </b>  <xsl:value-of select="witsml:numAnch"/></td></tr>
				<tr><td></td>
					<td><b>Guideline tensioners: </b>  <xsl:value-of select="witsml:numGuideTens"/></td>
					<td><b>Riser tensioners: </b>  <xsl:value-of select="witsml:numRiserTens"/></td>
					<td><b>Thrusters: </b>  <xsl:value-of select="witsml:numThrusters"/></td></tr>
				<tr><td align="right"><b>Mooring type: </b></td><td colspan="2"><xsl:value-of select="witsml:moorType"/></td><td><b>Thrusters azmimuth?</b>  <xsl:value-of select="witsml:azimuthing"/></td></tr>
				<tr><td align="right"><b>Variable deck load: </b></td><td><b>Maximum: </b>  <xsl:apply-templates select="witsml:varDeckLdMx" mode="valueWithUomRef"/></td>
					<td><b>Storm rating: </b>  <xsl:apply-templates select="witsml:vdlStorm" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Motion Compensation: </b></td><td><b>Min: </b>  <xsl:apply-templates select="witsml:motionCompensationMn" mode="valueWithUomRef"/></td>
					<td><b>Max: </b>  <xsl:apply-templates select="witsml:motionCompensationMx" mode="valueWithUomRef"/></td>
					<td><b>Stroke: </b>  <xsl:apply-templates select="witsml:strokeMotionCompensation" mode="valueWithUomRef"/></td></tr>
				<tr><td></td><td><b>Riser angle limit: </b>  <xsl:apply-templates select="witsml:riserAngleLimit" mode="valueWithUomRef"/></td>
					<td><b>Max heave: </b>  <xsl:apply-templates select="witsml:heaveMx" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="2"><b>Gantry: </b>  <xsl:value-of select="witsml:gantry"/></td><td colspan="2"><b>Flares: </b>  <xsl:value-of select="witsml:flares"/></td></tr>

				<!--		Check for bop data	-->	
				<xsl:for-each select="bop">
				<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for pit data	-->	
				<xsl:for-each select="witsml:pit">
				<xsl:apply-templates select="."/>
				</xsl:for-each>
				
				<!--		Check for pump data	-->	
				<xsl:for-each select="witsml:pump">
				<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for shaker data	-->	
				<xsl:for-each select="witsml:shaker">
				<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for centrifuge data	-->	
				<xsl:for-each select="witsml:centrifuge">
				<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for hydrocyclone data	-->	
				<xsl:for-each select="witsml:hydrocyclone">
				<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for degasser data	-->	
				<xsl:for-each select="witsml:degasser">
				<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for surfaceEquipment data	-->	
				<xsl:for-each select="witsml:surfaceEquipment">
				<xsl:apply-templates select="."/>
				</xsl:for-each>


				<!--      Common Data   -->
				<tr><td colspan="8" align="center"><font size="+1" color="blue">Common Data</font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Creation Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></font></td>
					<td colspan="2"><font size="-1"><b>Last Chg Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></font></td>
					<td colspan="4"><font size="-1"><b>State: </b><xsl:value-of select="witsml:commonData/witsml:itemState"/></font></td></tr>
				<tr><td colspan="8"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:commonData/witsml:comments"/></font></td></tr>


				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">------------------------------------------------------------------------------------------------------------------------</font></td></tr>
			</xsl:for-each>	
		</xsl:for-each>	
	</table>
	</body>
	</html>
	</xsl:template>

	
	<!--									bop Template							-->
	<xsl:template match="witsml:bop">				
				<tr><td colspan="6" align="center"><font size="+1" color="blue">BOP Configuration</font></td></tr>
				<tr><td colspan="2"><b>Mfgr: </b>  <xsl:value-of select="witsml:manufacturer"/></td>
					<td colspan="2"><b>Model: </b>  <xsl:value-of select="witsml:model"/></td></tr>
				<tr><td colspan="2"><b>Installed: </b>  <xsl:value-of select="witsml:dTimInstall"/></td>
					<td colspan="2"><b>Removed: </b> <xsl:value-of select="witsml:dTimRemove"/></td></tr>
				<tr><td colspan="1" align="right"><b>Connection: </b></td>
					<td colspan="2"><b>Type: </b>  <xsl:value-of select="witsml:typeConnectionBop"/></td>
					<td><b>Size: </b>  <xsl:apply-templates select="witsml:sizeConnectionBop" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="2"><b>BOP Pressure Rating: </b>  <xsl:apply-templates select="witsml:presBopRating" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Size BOP System</b><xsl:apply-templates select="witsml:sizeBopSys" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Rotating BOP?</b>  <xsl:value-of select="witsml:rotBop"/></td></tr>
				<tr><td colspan="2"><b>Accumulator: </b> <xsl:value-of select="witsml:accumulator"/></td>
					<td><b>Acc. Pre-charge Press.</b> <xsl:apply-templates select="witsml:presAccPreCharge" mode="valueWithUomRef"/></td>
					<td colspan="3"><b>Acc. Pre-charge Vol.: </b> <xsl:apply-templates select="witsml:volAccPreCharge" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="2"></td>
					<td><b>Capacity: </b> <xsl:apply-templates select="witsml:capAccFluid" mode="valueWithUomRef"/></td>
					<td colspan="3"><b>Oper. Pressure Rating: </b> <xsl:apply-templates select="witsml:presAccOpRating" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Booster Line</b></td><td><b>ID: </b> <xsl:apply-templates select="witsml:idBoosterLine" mode="valueWithUomRef"/></td>
					<td><b>OD: </b>  <xsl:apply-templates select="witsml:odBoosterLine" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenBoosterLine" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Surface Line</b></td><td><b>ID: </b> <xsl:apply-templates select="witsml:idSurfLine" mode="valueWithUomRef"/></td>
					<td><b>OD: </b>  <xsl:apply-templates select="witsml:odSurfLine" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenSurfLine" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Choke Line</b></td>	<td><b>ID: </b> <xsl:apply-templates select="witsml:idChkLine" mode="valueWithUomRef"/></td>
					<td><b>OD: </b> <xsl:apply-templates select="witsml:odChkLine" mode="valueWithUomRef"/></td>
					<td><b>Length: </b> <xsl:apply-templates select="witsml:lenChkLine" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Kill Line</b></td><td><b>ID: </b> <xsl:apply-templates select="witsml:idKillLine" mode="valueWithUomRef"/></td>
					<td><b>OD: </b> <xsl:apply-templates select="witsml:odKillLine" mode="valueWithUomRef"/></td>
					<td><b>Length: </b> <xsl:apply-templates select="witsml:lenKillLine" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Diverter</b></td>
					<td colspan="2"><b>Type: </b> <xsl:value-of select="witsml:typeDiverter"/></td>
					<td><b>Dia.: </b>  <xsl:apply-templates select="witsml:diaDiverter" mode="valueWithUomRef"/></td>
					<td><b>Work Press.: </b>  <xsl:apply-templates select="witsml:presWorkDiverter" mode="valueWithUomRef"/></td></tr>
				<tr><td align="right"><b>Control manifold</b></td>
					<td colspan="2"><b>Type: </b> <xsl:value-of select="witsml:typeControlManifold"/></td>
					<td colspan="2"><b>Desc: </b> <xsl:value-of select="witsml:descControlManifold"/></td></tr>
				<tr><td align="right"><b>Choke manifold</b></td>
					<td colspan="2"><b>Type: </b> <xsl:value-of select="witsml:typeChokeManifold"/></td>
					<td colspan="2"><b>Pressure: </b> <xsl:apply-templates select="witsml:presChokeManifold" mode="valueWithUomRef"/></td></tr>

				<!--		Check for bopComponent data							-->	
				<xsl:for-each select="witsml:bopComponent">
					<xsl:apply-templates select="."/>
				</xsl:for-each>
	</xsl:template>	
	
	<!--									bopComponent Template							-->
	<xsl:template match="witsml:bopComponent">				
				<tr><td colspan="2"><font size="+1">BOP Component - </font>  <xsl:value-of select="./@witsmluidBopComponent"/></td>
					<td colspan="2"><b>Type: </b>  <xsl:value-of select="witsml:typeBopComp"/></td>
					<td><b>Pressure: </b>  <xsl:apply-templates select="witsml:presWork" mode="valueWithUomRef"/></td></tr>
				<tr><td></td>
					<td colspan="1"><b>Min. Dia. can seal: </b>  <xsl:apply-templates select="witsml:diaCloseMn" mode="valueWithUomRef"/></td>
					<td colspan="1"><b>Max. Dia. can seal: </b>  <xsl:apply-templates select="witsml:diaCloseMx" mode="valueWithUomRef"/></td></tr>
				<tr><td></td>
					<td><b>Arrangement: </b>  <xsl:value-of select="witsml:nomenclature"/></td><td><b>Ram variable?: </b>  <xsl:value-of select="witsml:isVariable"/></td></tr>
				<tr><td></td><td colspan="2"><b>Desc.: </b>  <xsl:value-of select="witsml:descComp"/></td>
					<td colspan="1"><b>ID dia. pass thru: </b>  <xsl:apply-templates select="witsml:idPassThru" mode="valueWithUomRef"/></td>
</tr>

</xsl:template>	
	
	<!--									Rig Pit template 							-->
	<xsl:template match="witsml:pit">		
				<tr><td colspan="6" align="center"><font size="+1" color="blue">Rig Pit Configuration</font> -  <xsl:value-of select="./@witsmluidPit"/></td></tr>
				<tr>	<td><b>Pit Index: </b>  <xsl:value-of select="witsml:indexPit"/></td>
					<td><b>Capacity: </b>  <xsl:apply-templates select="witsml:capMx" mode="valueWithUomRef"/></td>
					<td><b>Active?</b>  <xsl:value-of select="witsml:isActive"/></td></tr>
				<tr>	<td colspan="2"><b>Installed: </b> <xsl:value-of select="witsml:dTimInstall"/></td>
					<td colspan="2"><b>Removed: </b>  <xsl:value-of select="witsml:dTimRemove"/></td></tr>
				<tr>	<td colspan="2"><b>Owner: </b>  <xsl:value-of select="witsml:owner"/></td><td colspan="2"><b>Type: </b>  <xsl:value-of select="witsml:typePit"/></td></tr>
	</xsl:template>	
				
	<!--									Rig Pump template 							-->
	<xsl:template match="witsml:pump">		
				<!--				Rig Pump Configuration 				-->
				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">Rig Pump Configuration</font> - <xsl:value-of select="./@witsmluidPump"/></td></tr>
				<tr>	<td	colspan="2"><b>Make: </b> <xsl:value-of select="witsml:manufacturer"/></td>
					<td colspan="2"><b>Model: </b><xsl:value-of select="witsml:model"/></td><td colspan="2"><b>Pump Index: </b>  <xsl:value-of select="witsml:index"/></td></tr>
				<tr>	<td colspan="2"><b>Installed: </b>  <xsl:value-of select="witsml:dTimInstall"/></td>
					<td colspan="2"><b>Removed: </b>  <xsl:value-of select="witsml:dTimRemove"/></td></tr>
				<tr>	<td colspan="2"><b>Owner: </b> <xsl:value-of select="witsml:owner"/></td>
					<td colspan="3"><b>Type: </b> <xsl:value-of select="witsml:typePump"/></td></tr>
				<tr>	<td><b>Number of Cylinders: </b>  <xsl:value-of select="witsml:numCyl"/></td>
					<td><b>Rod OD: </b>  <xsl:apply-templates select="witsml:odRod" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Liner ID: </b>  <xsl:apply-templates select="witsml:idLiner" mode="valueWithUomRef"/></td></tr>
				<tr><td><b>Action: </b>  <xsl:value-of select="witsml:pumpAction"/></td>
					<td><b>Efficiency: </b>  <xsl:apply-templates select="witsml:eff" mode="valueWithUomRef"/></td>
					<td colspan="1"><b>Stroke Length: </b>  <xsl:apply-templates select="witsml:lenStroke" mode="valueWithUomRef"/></td>
					<td colspan="1"><b>Displacement: </b>  <xsl:apply-templates select="witsml:displacement" mode="valueWithUomRef"/></td></tr>
				<tr>	<td colspan="2"><b>Max. Pressure: </b>  <xsl:apply-templates select="witsml:presMx" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Max. Hydralics HP: </b>  <xsl:apply-templates select="witsml:powHydMx" mode="valueWithUomRef"/></td>
					<td colspan="1"><b>Max SPM: </b>  <xsl:apply-templates select="witsml:spmMx" mode="valueWithUomRef"/></td></tr>
				<tr>	<td colspan="1"><b>Damp. Pressure: </b>  <xsl:apply-templates select="witsml:presDamp" mode="valueWithUomRef"/></td>
					<td colspan="1"><b>Damp. Volume: </b>  <xsl:apply-templates select="witsml:volDamp" mode="valueWithUomRef"/></td>
					<td colspan="1"><b>Max Mech. Power: </b>  <xsl:apply-templates select="witsml:powMechMx" mode="valueWithUomRef"/></td></tr>
	</xsl:template>	
	
	<!--									shaker template 							-->
	<xsl:template match="witsml:shaker">										
				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">Shaker Configuration</font> -  <xsl:value-of select="./@witsmluidShaker"/></td></tr>
				<tr>	<td colspan="2"><b>Make: </b>  <xsl:value-of select="witsml:manufacturer"/></td>
					<td colspan="2"><b>Model: </b>  <xsl:value-of select="witsml:model"/></td></tr>
				<tr>	<td colspan="2"><b>Installed: </b>  <xsl:value-of select="witsml:dTimInstall"/></td>
					<td colspan="2"><b>Removed: </b>  <xsl:value-of select="witsml:dTimRemove"/></td></tr>
				<tr>	<td colspan="2"><b>Owner: </b>  <xsl:value-of select="witsml:owner"/></td>
					<td colspan="3"><b>Type: </b> <xsl:value-of select="witsml:type"/></td></tr>
				<tr><td colspan="2"><b>Location: </b>  <xsl:value-of select="witsml:locationShaker"/></td>
					<td colspan="2"><b>Flow cap: </b>  <xsl:apply-templates select="witsml:capFlow" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="2"><b>Number of Decks: </b>  <xsl:value-of select="witsml:numDecks"/></td>
					<td colspan="2"><b>No. of Casc. Levels: </b>  <xsl:value-of select="witsml:numCascLevel"/></td></tr>
				<tr><td colspan="2"><b>Min. Size Mesh: </b>  <xsl:apply-templates select="witsml:sizeMeshMn" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Mud Cleaner?: </b>  <xsl:value-of select="witsml:mudCleaner"/></td></tr>
	</xsl:template>	
	
	<!--									centrifuge template 							-->
	<xsl:template match="witsml:centrifuge">										
				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">Centrifuge Configuration</font> -  <xsl:value-of select="./@witsmluidCentrifuge"/></td></tr>
				<tr>	<td colspan="2"><b>Make: </b>  <xsl:value-of select="witsml:manufacturer"/></td>
					<td colspan="2"><b>Model: </b>  <xsl:value-of select="witsml:model"/></td></tr>
				<tr>	<td colspan="2"><b>Installed: </b>  <xsl:value-of select="witsml:dTimInstall"/></td>
					<td colspan="2"><b>Removed: </b>  <xsl:value-of select="witsml:dTimRemove"/></td></tr>
				<tr>	<td colspan="2"><b>Owner: </b>  <xsl:value-of select="witsml:owner"/></td>
					<td colspan="3"><b>Type: </b>  <xsl:value-of select="witsml:type"/></td></tr>
				<tr>	<td colspan="2"><b>Flow Capacity: </b>  <xsl:apply-templates select="witsml:capFlow" mode="valueWithUomRef"/></td></tr>
	</xsl:template>	
	
	<!--									hydroCyclone template 							-->
	<xsl:template match="witsml:hydrocyclone">										
				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">Hydrocyclone Configuration</font> -  <xsl:value-of select="./@witsmluidHydrocyclone"/></td></tr>
				<tr>	<td colspan="2"><b>Make: </b>  <xsl:value-of select="witsml:manufacturer"/></td>
					<td colspan="2"><b>Model: </b>  <xsl:value-of select="witsml:model"/></td></tr>
				<tr>	<td colspan="2"><b>Installed: </b>  <xsl:value-of select="witsml:dTimInstall"/></td>
					<td colspan="2"><b>Removed: </b>  <xsl:value-of select="witsml:dTimRemove"/></td></tr>
				<tr>	<td colspan="2"><b>Owner: </b>  <xsl:value-of select="witsml:owner"/></td>
					<td colspan="3"><b>Type: </b>  <xsl:value-of select="witsml:type"/></td></tr>
				<tr>	<td colspan="2"><b>Cone desc.: </b>  <xsl:value-of select="witsml:descCone"/></td></tr>

	</xsl:template>	
					
	<!--									degasser template 							-->
	<xsl:template match="witsml:degasser">										
				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">Degasser Configuration</font> -  <xsl:value-of select="./@witsmluidDegasser"/></td></tr>
				<tr>	<td colspan="2"><b>Make: </b>  <xsl:value-of select="witsml:manufacturer"/></td>
					<td colspan="2"><b>Model: </b><xsl:value-of select="witsml:model"/></td></tr>
				<tr>	<td colspan="2"><b>Installed: </b>  <xsl:value-of select="witsml:dTimInstall"/></td>
					<td colspan="2"><b>Removed: </b>  <xsl:value-of select="witsml:dTimRemove"/></td></tr>
				<tr>	<td colspan="2"><b>Owner: </b>  <xsl:value-of select="witsml:owner"/></td>
					<td colspan="3"><b>Type: </b>  <xsl:value-of select="witsml:type"/></td></tr>
				<tr>	<td><b>Height: </b>  <xsl:apply-templates select="witsml:height" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:len" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Internal Dia.: </b>  <xsl:apply-templates select="witsml:id" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="2"><b>Flow cap: </b>  <xsl:apply-templates select="witsml:capFlow" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Flow Area: </b>  <xsl:apply-templates select="witsml:areaSeparatorFlow" mode="valueWithUomRef"/></td>
</tr>
				<tr><td colspan="2"><b>Height Mud Seal: </b>  <xsl:apply-templates select="witsml:htMudSeal" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Inlet ID: </b>  <xsl:apply-templates select="witsml:idInlet" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="2"><b>Vent Line ID: </b>  <xsl:apply-templates select="witsml:idVentLine" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Vent Line Length: </b>  <xsl:apply-templates select="witsml:lenVentLine" mode="valueWithUomRef"/></td></tr>
				<tr>	<td colspan="2"><b>Gas Sep. Capacity: </b>  <xsl:apply-templates select="witsml:capGasSep" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Blowdown Capacity: </b>  <xsl:apply-templates select="witsml:capBlowdown" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="2"><b>Pressure Rating: </b>  <xsl:apply-templates select="witsml:presRating" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Temp. Rating: </b>  <xsl:apply-templates select="witsml:tempRating" mode="valueWithUomRef"/></td></tr>
	</xsl:template>	
	
	<!--									surfaceEquipment template 							-->
	<xsl:template match="witsml:surfaceEquipment">						
				<tr>	<td colspan="6" align="center"><font size="+1" color="blue">Surface Equipment Configuration</font></td></tr>
				<tr>	<td colspan="6"><b>Description: </b>  <xsl:value-of select="witsml:description"/></td></tr>
				<tr><td colspan="2"><b>Pressure Rating: </b>  <xsl:apply-templates select="witsml:presRating" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>EquipmentType: </b>  <xsl:value-of select="witsml:typeSurfEquip"/></td></tr>
				<tr>	<td><b>Use Pump Discharge?</b>  <xsl:value-of select="witsml:usePumpDischarge"/></td>
					<td><b>Use Standpipe?</b>  <xsl:value-of select="witsml:useStandpipe"/></td>
					<td><b>Use Hose?</b>  <xsl:value-of select="witsml:useHose"/></td>
					<td><b>Use Swivel?</b>  <xsl:value-of select="witsml:useSwivel"/></td></tr>
				<tr>	<td><b>Use Kelly?</b>  <xsl:value-of select="witsml:useKelly"/></td>
					<td><b>Use Top Stack?</b>  <xsl:value-of select="witsml:useTopStack"/></td>
					<td><b>Use Inj. Stack?</b>  <xsl:value-of select="witsml:useInjStack"/></td>
					<td><b>Use Surface Iron?</b>  <xsl:value-of select="witsml:useSurfaceIron"/></td></tr>
				<tr>	<td align="right"><b>Standpipe: </b></td><td><b>ID: </b>  <xsl:apply-templates select="witsml:idStandpipe" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenStandpipe" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Hose: </b></td><td><b>ID: </b>  <xsl:apply-templates select="witsml:idHose" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenHose" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Swivel: </b></td><td><b>ID: </b>  <xsl:apply-templates select="witsml:idSwivel" mode="valueWithUomRef"/></td>
				 	<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenSwivel" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Kelly: </b></td><td><b>ID: </b>  <xsl:apply-templates select="witsml:idKelly" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenKelly" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Discharge Line: </b></td><td><b>ID: </b>  <xsl:apply-templates select="witsml:idDischargeLine" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenDischargeLine" mode="valueWithUomRef"/></td></tr>
				<tr>	<td><b>Coiled Tubing Wrap Type</b></td><td><xsl:value-of select="witsml:ctWrapType"/></td></tr>
				<tr>	<td align="right"><b>Reel: </b></td><td><b>OD: </b>  <xsl:apply-templates select="witsml:odReel" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenReel" mode="valueWithUomRef"/></td>
					<td><b>Core OD: </b>  <xsl:apply-templates select="witsml:odCore" mode="valueWithUomRef"/></td>
					<td colspan="2"><b>Wrap Width: </b>  <xsl:apply-templates select="witsml:widReelWrap" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Injector: </b></td><td><b>Stackup?</b>  <xsl:value-of select="witsml:injStkUp"/></td>
					<td><b>Stackup Height: </b>  <xsl:apply-templates select="witsml:htInjStk" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Umbilical: </b></td><td><b>Inside?</b>  <xsl:value-of select="witsml:umbInside"/></td>
					<td><b>OD: </b>  <xsl:apply-templates select="witsml:odUmbilical" mode="valueWithUomRef"/></td>
					<td><b>Length: </b>  <xsl:apply-templates select="witsml:lenUmbilical" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Top Stack: </b></td><td><b>ID: </b>  <xsl:apply-templates select="witsml:idTopStk" mode="valueWithUomRef"/></td>
					<td><b>Height: </b><xsl:apply-templates select="witsml:htTopStk" mode="valueWithUomRef"/></td></tr>
				<tr>	<td align="right"><b>Flange Height: </b></td><td><xsl:apply-templates select="witsml:htFlange" mode="valueWithUomRef"/></td></tr>
		</xsl:template>

		
</xsl:stylesheet>
