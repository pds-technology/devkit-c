<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML tubular Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="9" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="9"><font size="+2" color="blue">Tubular Assembly Information</font></th></tr>
		<xsl:for-each select="witsml:tubulars">
			<xsl:for-each select="witsml:tubular">
				<tr>	<td colspan="3"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Tubular uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Tubular Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
				<tr><td colspan="4"><font size="-1"><b>Type: </b> <xsl:value-of select="witsml:typeTubularAssy"/></font></td>
					<td colspan="2"><font size="-1"><b>Float valve present?: </b> <xsl:value-of select="witsml:valveFloat"/></font></td>
					<td colspan="2"><font size="-1"><b>Nuclear tool present?: </b> <xsl:value-of select="witsml:sourceNuclear"/></font></td>
					<td colspan="1"><font size="-1"><b>Hole Dia.: </b> <xsl:apply-templates select="witsml:diaHoleAssy" mode="valueWithUomRef"/></font></td></tr>
			
				<!--		Check for a tubularComponent	-->	
				<xsl:for-each select="witsml:tubularComponent">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Tubular Component</font></td></tr>
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

	
	<!--									tubularComponent Template							-->
	<xsl:template match="witsml:tubularComponent">				
				<tr><td colspan="2"><font size="-1"><b>Sequence: </b>  <xsl:value-of select="witsml:sequence"/></font></td>
					<td colspan="3"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeTubularComp"/></font></td>
					<td colspan="4"><font size="-1"><b>Descr: </b>  <xsl:value-of select="witsml:description"/></font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b>id: </b>  <xsl:apply-templates select="witsml:id" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>od: </b>  <xsl:apply-templates select="witsml:od" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>length: </b>  <xsl:apply-templates select="witsml:len" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Avg joint length: </b>  <xsl:apply-templates select="witsml:lenJointAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>No. joints per stand: </b>  <xsl:value-of select="witsml:numJointStand"/></font></td>
					<td colspan="2"><font size="-1"><b>Wgt. per len: </b>  <xsl:apply-templates select="witsml:wtPerLen" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Grade: </b>  <xsl:value-of select="witsml:grade"/></font></td>
					<td colspan="2"><font size="-1"><b>Drift od: </b>  <xsl:apply-templates select="witsml:odDrift" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Yield stress: </b>  <xsl:apply-templates select="witsml:tensYield" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Torque yield: </b>  <xsl:apply-templates select="witsml:tqYield" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Fatigue stress: </b>  <xsl:apply-templates select="witsml:odDrift" mode="valueWithUomRef"/></font></td>
					<td colspan="1" align="right"><font size="-1"><b>Fish neck: </b></font></td>
					<td colspan="2"><font size="-1"><b>Length: </b>  <xsl:apply-templates select="witsml:lenFishneck" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>id: </b>  <xsl:apply-templates select="witsml:idFishneck" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>od: </b>  <xsl:apply-templates select="witsml:odFishneck" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Closed end displ: </b>  <xsl:apply-templates select="witsml:disp" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Burst press.: </b>  <xsl:apply-templates select="witsml:presBurst" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Collapse press.: </b>  <xsl:apply-templates select="witsml:presCollapse" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Serv. class: </b>  <xsl:value-of select="witsml:classService"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Wall thickness: </b>  <xsl:apply-templates select="witsml:thickWall" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>% Wall wear: </b>  <xsl:apply-templates select="witsml:wearWall" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>MD Top casing: </b>  <xsl:apply-templates select="witsml:mdTop" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Pin/Box config.: </b>  <xsl:value-of select="witsml:configCon"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Stiffness: </b></font></td>
					<td colspan="1"><font size="-1"><b>Bend: </b>  <xsl:apply-templates select="witsml:bendStiffness" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Axial: </b>  <xsl:apply-templates select="witsml:axialStiffness" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Torsional: </b>  <xsl:apply-templates select="witsml:torsionalStiffness" mode="valueWithUomRef"/></font></td>
					</tr>
				<tr>	<td colspan="2"><font size="-1"><b>Max. dogleg severity: </b>  <xsl:apply-templates select="witsml:doglegMx" mode="valueWithUomRef"/></font></td>
					<td colspan="4"><font size="-1"><b>Matl Type: </b>  <xsl:value-of select="witsml:typeMaterial"/></font></td>
					<td colspan="3"><font size="-1"><b>Vendor: </b>  <xsl:value-of select="witsml:vendor"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Name Tag: </b>  <xsl:value-of select="witsml:nameTag/witsml:numberingScheme"/>=<xsl:value-of select="witsml:nameTag/witsml:name"/></font></td>
					<td colspan="2"><font size="-1"><b>Model: </b>  <xsl:value-of select="witsml:model"/></font></td>
					<td colspan="1"><font size="-1"><b>Nozzle area flow: </b>  <xsl:apply-templates select="witsml:areaNozzleFlow" mode="valueWithUomRef"/></font></td></tr>

				<!--		Check for a nozzle tag	-->	
				<xsl:for-each select="witsml:nozzle">
					<tr><td colspan="1" align="right"><font size="-1"><b>Nozzle: </b></font></td>
						<td colspan="1"><font size="-1"><b>index: </b>  <xsl:value-of select="witsml:index"/></font></td>
						<td colspan="1"><font size="-1"><b>dia.: </b>  <xsl:apply-templates select="witsml:diaNozzle" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Len: </b>  <xsl:apply-templates select="witsml:len" mode="valueWithUomRef"/></font></td>
						<td colspan="3"><font size="-1"><b>type: </b>  <xsl:value-of select="witsml:typeNozzle"/></font></td>
						<td colspan="3"><font size="-1"><b>orient.: </b>  <xsl:value-of select="witsml:orientation"/></font></td></tr>
				</xsl:for-each>

				<!--		Check for a bitRecord tag	-->	
				<xsl:for-each select="witsml:bitRecord">
					<tr><td colspan="9" align="center"><font size="-1"><b>Bit Record Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a jar tag	-->	
				<xsl:for-each select="witsml:jar">
					<tr><td colspan="9" align="center"><font size="-1"><b>Jar Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a connection tag	-->	
				<xsl:for-each select="witsml:connection">
					<tr><td colspan="9" align="center"><font size="-1"><b>Connection Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a mwdTool tag	-->	
				<xsl:for-each select="witsml:mwdTool">
					<tr><td colspan="9" align="center"><font size="-1"><b>MWD Tool Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a motor tag	-->	
				<xsl:for-each select="witsml:motor">
					<tr><td colspan="9" align="center"><font size="-1"><b>Motor Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a stabilizer tag	-->	
				<xsl:for-each select="witsml:stabilizer">
					<tr><td colspan="9" align="center"><font size="-1"><b>Stabilizer Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a bend tag	-->	
				<xsl:for-each select="witsml:bend">
					<tr><td colspan="9" align="center"><font size="-1"><b>Bend Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a holeOpener tag	-->	
				<xsl:for-each select="witsml:holeOpener">
					<tr><td colspan="9" align="center"><font size="-1"><b>Hole Opener Information</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

	</xsl:template>	

	<!--									bend Template							-->
	<xsl:template match="witsml:bend">
				<tr>	<td colspan="2"><font size="-1"><b>Angle of bend: </b>  <xsl:apply-templates select="witsml:angle" mode="valueWithUomRef"/></font></td>
					<td colspan="4"><font size="-1"><b>Distance from bottom of component: </b>  <xsl:apply-templates select="witsml:distBendBot" mode="valueWithUomRef"/></font></td></tr>
	</xsl:template>	

	<!--									bitRecord Template							-->
	<xsl:template match="witsml:bitRecord">
				<tr>	<td colspan="3"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeBit"/></font></td>	
					<td colspan="4"><font size="-1"><b>Mfr: </b>  <xsl:value-of select="witsml:manufacturer"/></font></td></tr>

				<tr>	<td colspan="1"><font size="-1"><b>Bit dia.: </b>  <xsl:apply-templates select="witsml:diaBit" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Min. pass thru dia.: </b>  <xsl:apply-templates select="witsml:diaPassThru" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Pilot dia.: </b>  <xsl:apply-templates select="witsml:diaPilot" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Cost: </b>  <xsl:value-of select="witsml:cost"/><xsl:text> </xsl:text><xsl:value-of select="witsml:cost/@witsmlcurrency"/></font></td>
					<td colspan="2"><font size="-1"><b>IADC bit code: </b>  <xsl:value-of select="witsml:codeIADC"/></font></td>
					<td colspan="2"><font size="-1"><b>Bit drive type: </b>  <xsl:value-of select="witsml:drive"/></font></td>
					<td colspan="1"><font size="-1"><b>New/Used: </b>  <xsl:value-of select="witsml:bitClass"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Init Cond: </b></font></td>
					<td colspan="1"><font size="-1"><b>Inner tooth: </b>  <xsl:value-of select="witsml:condInitInner"/></font></td>
					<td colspan="2"><font size="-1"><b>Outer Tooth: </b>  <xsl:value-of select="witsml:condInitOuter"/></font></td>
					<td colspan="1"><font size="-1"><b>Dull code: </b>  <xsl:value-of select="witsml:condInitDull"/></font></td>
					<td colspan="1"><font size="-1"><b>locn: </b>  <xsl:value-of select="witsml:condInitLocation"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b></b></font></td>
					<td colspan="1"><font size="-1"><b>Bit bearings: </b>  <xsl:value-of select="witsml:condInitBearing"/></font></td>
					<td colspan="2"><font size="-1"><b>Bit gauge: </b>  <xsl:value-of select="witsml:condInitGauge"/></font></td>
					<td colspan="2"><font size="-1"><b>Other: </b>  <xsl:value-of select="witsml:condInitOther"/></font></td>
					<td colspan="2"><font size="-1"><b>Reason: </b>  <xsl:value-of select="witsml:condInitReason"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Final Cond: </b></font></td>
					<td colspan="1"><font size="-1"><b>Inner tooth: </b>  <xsl:value-of select="witsml:condFinalInner"/></font></td>
					<td colspan="2"><font size="-1"><b>Outer Tooth: </b>  <xsl:value-of select="witsml:condFinalOuter"/></font></td>
					<td colspan="1"><font size="-1"><b>Dull code: </b>  <xsl:value-of select="witsml:condFinalDull"/></font></td>
					<td colspan="1"><font size="-1"><b>locn: </b>  <xsl:value-of select="witsml:condFinalLocation"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b></b></font></td>
					<td colspan="1"><font size="-1"><b>Bit bearings: </b>  <xsl:value-of select="witsml:condFinalBearing"/></font></td>
					<td colspan="2"><font size="-1"><b>Bit gauge: </b>  <xsl:value-of select="witsml:condFinalGauge"/></font></td>
					<td colspan="2"><font size="-1"><b>Other: </b>  <xsl:value-of select="witsml:condFinalOther"/></font></td>
					<td colspan="2"><font size="-1"><b>Reason: </b>  <xsl:value-of select="witsml:condFinalReason"/></font></td></tr>
	</xsl:template>	

	<!--									connection Template							-->
	<xsl:template match="witsml:connection">
				<tr>	<td colspan="1"><font size="-1"><b>id: </b>  <xsl:apply-templates select="witsml:id" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>od: </b>  <xsl:apply-templates select="witsml:od" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>length: </b>  <xsl:apply-templates select="witsml:len" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Type thread: </b>  <xsl:value-of select="witsml:typeThread"/></font></td>
					<td colspan="2"><font size="-1"><b>Size thread: </b>  <xsl:apply-templates select="witsml:sizeThread" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Tensile yield: </b>  <xsl:apply-templates select="witsml:tensYield" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Torque yield: </b>  <xsl:apply-templates select="witsml:tqYield" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Position: </b>  <xsl:value-of select="witsml:position"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Crit. cross sect.: </b>  <xsl:apply-templates select="witsml:criticalCrossSection" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Leak press. rating: </b>  <xsl:apply-templates select="witsml:presLeak" mode="valueWithUomRef"/>: </font></td>
					<td colspan="3"><font size="-1"><b>Make up torque: </b>  <xsl:apply-templates select="witsml:tqMakeup" mode="valueWithUomRef"/></font></td></tr>
	</xsl:template>	

	<!--									Hole Opener Template							-->
	<xsl:template match="witsml:holeOpener">
				<tr>	<td colspan="5"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeHoleOpener"/></font></td>
					<td colspan="4"><font size="-1"><b>Mfr: </b>  <xsl:value-of select="witsml:manufacturer"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>No. of cutters: </b>  <xsl:value-of select="witsml:numCutter"/></font></td>
					<td colspan="3"><font size="-1"><b>Reamer hole diameter: </b>  <xsl:apply-templates select="witsml:diaHoleOpener" mode="valueWithUomRef"/></font></td></tr>
				<!--		Check for a nozzle tag	-->	
				<xsl:for-each select="witsml:nozzle">
					<tr><td colspan="1" align="right"><font size="-1"><b>Bit nozzle: </b></font></td>
						<td colspan="1"><font size="-1"><b>index: </b>  <xsl:value-of select="witsml:index"/></font></td>
						<td colspan="1"><font size="-1"><b>dia.: </b>  <xsl:apply-templates select="witsml:diaNozzle" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Len: </b>  <xsl:apply-templates select="witsml:len" mode="valueWithUomRef"/></font></td>
						<td colspan="3"><font size="-1"><b>type: </b>  <xsl:value-of select="witsml:typeNozzle"/></font></td>
						<td colspan="3"><font size="-1"><b>orient.: </b>  <xsl:value-of select="witsml:orientation"/></font></td></tr>
				</xsl:for-each>

	</xsl:template>	


	<!--									jar Template							-->
	<xsl:template match="witsml:jar">
				<tr>	<td colspan="5"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeJar"/></font></td>
					<td colspan="4"><font size="-1"><b>Action: </b>  <xsl:value-of select="witsml:jarAction"/></font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b>Force: </b></font></td>
					<td colspan="2"><font size="-1"><b>Up set: </b>  <xsl:apply-templates select="witsml:forUpSet" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Down set: </b>  <xsl:apply-templates select="witsml:forDownSet" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Up trip: </b>  <xsl:apply-templates select="witsml:forUpTrip" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Down trip: </b>  <xsl:apply-templates select="witsml:forDownTrip" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="1" align="right"><font size="-1"><b></b></font></td>
					<td colspan="2"><font size="-1"><b>Pump open: </b>  <xsl:apply-templates select="witsml:forPmpOpen" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Seal friction: </b>  <xsl:apply-templates select="witsml:forSealFric" mode="valueWithUomRef"/></font></td></tr>
	</xsl:template>	

	<!--									motor Template							-->
	<xsl:template match="witsml:motor">
				<tr>	<td colspan="3"><font size="-1"><b>Tool offset from bottom: </b>  <xsl:apply-templates select="witsml:offsetTool" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Pressure loss factor: </b>  <xsl:apply-templates select="witsml:presLossFact" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Min. flow rate: </b>  <xsl:apply-templates select="witsml:flowrateMn" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Max. flow rate: </b>  <xsl:apply-templates select="witsml:flowrateMx" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Rotor dia. at nozzle: </b>  <xsl:apply-templates select="witsml:diaRotorNozzle" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Clearance in bearing box: </b>  <xsl:apply-templates select="witsml:clearanceBearBox" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>No. of rotor lobes: </b>  <xsl:value-of select="witsml:lobesRotor"/></font></td>
					<td colspan="3"><font size="-1"><b>No. of stator lobes: </b>  <xsl:value-of select="witsml:lobesStator"/></font></td>
					<td colspan="2"><font size="-1"><b>Bearing type: </b>  <xsl:value-of select="witsml:typeBearing"/></font></td>
					<td colspan="2"><font size="-1"><b>Max oper. temp.: </b>  <xsl:apply-templates select="witsml:tempOpMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Has rotor catch?: </b>  <xsl:value-of select="witsml:rotorCatcher"/></font></td>
					<td colspan="3"><font size="-1"><b>Has dump valve?: </b>  <xsl:value-of select="witsml:dumpValve"/></font></td>
					<td colspan="2"><font size="-1"><b>Motor rotatable?: </b>  <xsl:value-of select="witsml:rotatable"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Dia. nozzle: </b>  <xsl:apply-templates select="witsml:diaNozzle" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Bend settings Min: </b>  <xsl:apply-templates select="witsml:bendSettingsMn" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Bend settings Max: </b>  <xsl:apply-templates select="witsml:bendSettingsMx" mode="valueWithUomRef"/></font></td></tr>
	</xsl:template>	


	<!--									mwdTool Template							-->
	<xsl:template match="witsml:mwdTool">
				<tr>	<td colspan="2"><font size="-1"><b>Min. flow rate: </b>  <xsl:apply-templates select="witsml:flowrateMn" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Max. flow rate: </b>  <xsl:apply-templates select="witsml:flowrateMx" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Max. temper.: </b>  <xsl:apply-templates select="witsml:tempMx" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Equiv inner dia.: </b>  <xsl:apply-templates select="witsml:idEquv" mode="valueWithUomRef"/></font></td></tr>
				<xsl:for-each select="witsml:sensor">
					<tr><td colspan="1" align="right"><font size="-1"><b>MWD Sensor: </b></font></td>
						<td colspan="6"><font size="-1"><b>Measurement type: </b>  <xsl:value-of select="witsml:typeMeasurement"/></font></td>
						<td colspan="2"><font size="-1"><b>Offset from bottom: </b>  <xsl:apply-templates select="witsml:offsetBot" mode="valueWithUomRef"/></font></td></tr>
					<tr>	<td colspan="1"><font size="-1"><b></b></font></td>
						<td colspan="8"><font size="-1"><b>Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>
				</xsl:for-each>
	</xsl:template>	

	<!--									stabilizer Template							-->
	<xsl:template match="witsml:stabilizer">
				<tr>	<td colspan="1" align="right"><font size="-1"><b>Blade: </b></font></td>
					<td colspan="1"><font size="-1"><b>length: </b>  <xsl:apply-templates select="witsml:lenBlade" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max. OD: </b>  <xsl:apply-templates select="witsml:odBladeMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min. OD: </b>  <xsl:apply-templates select="witsml:odBladeMn" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>dist from bot: </b>  <xsl:apply-templates select="witsml:distBladeBot" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b>Friction factor: </b>  <xsl:apply-templates select="witsml:odBladeMx" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Shape: </b>  <xsl:value-of select="witsml:shapeBlade"/></font></td>
					<td colspan="4"><font size="-1"><b>Type blade: </b>  <xsl:value-of select="witsml:typeBlade"/></font></td></tr>
	</xsl:template>	

	<!--									Common Data Template							-->
	<xsl:template match="witsml:commonData">					
				<tr><td colspan="3"><font size="-1"><b>User ID: </b>  <xsl:value-of select="witsml:nameSource"/></font></td>
					<td colspan="3"><font size="-1"><b>Time Stamp: </b>  <xsl:value-of select="witsml:dTimStamp"/></font></td>
					<td colspan="3"><font size="-1"><b>State: </b> <xsl:value-of select="witsml:itemState"/></font></td></tr>
				<tr><td colspan="9"><font size="-1"><b>Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>
	</xsl:template>		
	

</xsl:stylesheet>
