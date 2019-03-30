<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Conventional Core Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="8" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="8"><font size="+2" color="blue">Conventional Core Information</font></th></tr>
		<xsl:for-each select="witsml:convCores">
			<xsl:for-each select="witsml:convCore">
				<tr>	<td colspan="3"><font size="+1" color="blue">uidWell: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>uidWellbore: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Core Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Desc: </b>  <xsl:value-of select="witsml:coreDescription"/></font></td>
					<td colspan="2"><font size="-1"><b>Core Started: </b>  <xsl:value-of select="witsml:dTimCoreStart"/></font></td>
					<td colspan="3"><font size="-1"><b>Core Ended: </b>  <xsl:value-of select="witsml:dTimCoreEnd"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Contractors: </b></font></td>
					<td colspan="3"><font size="-1"><b>Coring: </b>  <xsl:value-of select="witsml:coringContractor"/></font></td>
					<td colspan="3"><font size="-1"><b>Analysis: </b>  <xsl:value-of select="witsml:analysisContractor"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>MD Core Top:  </b><xsl:apply-templates select="witsml:mdCoreTop" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>MD Core Bottom:  </b><xsl:apply-templates select="witsml:mdCoreBottom" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Reference: </b>  <xsl:value-of select="witsml:coreReference"/></font></td></tr>
				<tr><td><font size="-1"><b>Barrel Core: </b>  <xsl:value-of select="witsml:coreBarrel"/></font></td>
					<td><font size="-1"><b>Barrel Length: </b>  <xsl:apply-templates select="witsml:lenBarrel" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>Inner Barrel Used?: </b>  <xsl:value-of select="witsml:innerBarrelUsed"/></font></td>
					<td colspan="2"><font size="-1"><b>Inner Barrel Type: </b>  <xsl:value-of select="witsml:innerBarrelType"/></font></td>
					<td colspan="2"><font size="-1"><b>Hole Angle: </b>  <xsl:apply-templates select="witsml:inclHole" mode="valueWithUomRef"/></font></td></tr>
				<tr><td><font size="-1"><b>Bit Type: </b>  <xsl:value-of select="witsml:coreBitType"/></font></td>
					<td><font size="-1"><b>Bit Diameter: </b>  <xsl:apply-templates select="witsml:diaBit" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>Core Diameter: </b>  <xsl:apply-templates select="witsml:diaCore" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>Length Cored: </b>  <xsl:apply-templates select="witsml:xxxxxxxxxxx" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>Length Recovered: </b>  <xsl:apply-templates select="witsml:xxxxxxxxxxx" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Recovered Pct: </b>  <xsl:apply-templates select="witsml:xxxxxxxxxxx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Core: </b></font></td>
					<td><font size="-1"><b>Orientation: </b>  <xsl:value-of select="witsml:coreOrientation"/></font></td>
					<td><font size="-1"><b>Method: </b>  <xsl:value-of select="witsml:coreMethod"/></font></td>
					<td colspan="2"><font size="-1"><b>Treatment Method: </b>  <xsl:value-of select="witsml:coreTreatmentMethod"/></font></td>
					<td colspan="2"><font size="-1"><b>Fluid Used: </b>  <xsl:value-of select="witsml:coreFluidUsed"/></font></td></tr>

				<tr><td colspan="3"><font size="-1"><b>Formation name: </b>  <xsl:value-of select="witsml:nameFormation"/></font></td></tr>

				<!--		Check for Geology Interval data	-->	
				<xsl:for-each select="witsml:geologyInterval">
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

	
	<!--									geologyInterval Template							-->
	<xsl:template match="witsml:geologyInterval">				
				<tr><td colspan="8" align="center"><font size="+1" color="blue">Geology Interval</font>  <font size="-1">(uid: <xsl:value-of select="./@uid"/>)</font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:type"/></font></td>
					<td colspan="2"><font size="-1"><b>Sample cut: </b>  <xsl:value-of select="witsml:dTim"/></font></td>
				</tr>
				<tr><td colspan="1"><font size="-1"><b>MD Top: </b>  <xsl:apply-templates select="witsml:mdTop" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD Bottom: </b>  <xsl:apply-templates select="witsml:mdBottom" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>TVD Top: </b>  <xsl:apply-templates select="witsml:tvdTop" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>TVD Base: </b>  <xsl:apply-templates select="witsml:tvdBase" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b>ROP Avg: </b>  <xsl:apply-templates select="witsml:ropAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>ROP Min: </b>  <xsl:apply-templates select="witsml:ropMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>ROP Max: </b>  <xsl:apply-templates select="witsml:ropMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>WOB Avg: </b>  <xsl:apply-templates select="witsml:wobAv" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b>Torque Avg: </b>  <xsl:apply-templates select="witsml:tqAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>RPM Avg: </b>  <xsl:apply-templates select="witsml:ropMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Mud Wgt Avg: </b>  <xsl:apply-templates select="witsml:ropMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Avg ECD at TD: </b>  <xsl:apply-templates select="witsml:ecdTdAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Avg Drilling Expon: </b>  <xsl:value-of select="witsml:dxcAv"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Sample: </b></font></td>
					<td><font size="-1"><b>Bulk Density: </b>  <xsl:apply-templates select="witsml:densBulk" mode="valueWithUomRef"/></font></td>
					<td><font size="-1"><b>Shale Density: </b>  <xsl:apply-templates select="witsml:densShale" mode="valueWithUomRef"/></font></td></tr>
					
				<tr><td colspan="1"><font size="-1"><b>Calcite: </b>  <xsl:value-of select="witsml:calcite"/></font></td>
					<td><font size="-1"><b>Dolomite: </b>  <xsl:value-of select="witsml:dolomite"/></font></td>
					<td colspan="2"><font size="-1"><b>Cationic exchange capacity: </b>  <xsl:value-of select="witsml:cec"/></font></td>
					<td colspan="1"><font size="-1"><b>Min Size: </b>  <xsl:apply-templates select="witsml:sizeMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max Size: </b>  <xsl:apply-templates select="witsml:sizeMx" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Plug Length: </b>  <xsl:apply-templates select="witsml:lenPlug" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Formation: </b>  <xsl:value-of select="witsml:nameFormation"/></font></td>
					<td colspan="5"><font size="-1"><b>Lithostratigraphic: </b>  <xsl:value-of select="witsml:lithostratigraphic"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Chronostratigraphic: </b>  <xsl:value-of select="witsml:chronostratigraphic"/></font></td>
					<td colspan="5"><font size="-1"><b>Description: </b>  <xsl:value-of select="witsml:description"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Cutting Fluid: </b>  <xsl:value-of select="witsml:cuttingFluid"/></font></td>
					<td colspan="5"><font size="-1"><b>Cleaning Method: </b>  <xsl:value-of select="witsml:cleaningMethod"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Drying Method: </b>  <xsl:value-of select="witsml:dryingMethod"/></font></td></tr>
				<tr><td colspan="8"><font size="-1"><b>Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>


				<!--		Check for Lithology data							-->	
				<xsl:for-each select="witsml:lithology">
					<xsl:apply-templates select="."/>
				</xsl:for-each>
				
				<!--		Check for Show data							-->	
				<xsl:for-each select="witsml:show">
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for Chromatograph data							-->	
				<xsl:for-each select="witsml:chromatograph">
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for Mud Gas data							-->	
				<xsl:for-each select="witsml:mudGas">
					<xsl:apply-templates select="."/>
				</xsl:for-each>

	</xsl:template>	
	
	<!--									Lithology Template							-->
	<xsl:template match="witsml:lithology">				
				<tr><td colspan="2"><font size="+1" color="blue">Lithology</font>  <font size="-1">(uid: <xsl:value-of select="./@uid"/>)</font></td>
					<td colspan="2"><font size="-1"><b>Type: </b>  <xsl:apply-templates select="witsml:type" mode="LithologyType"/></font></td>
					<td colspan="2"><font size="-1"><b>Code: </b>  <xsl:value-of select="witsml:codeLith"/></font></td>
					<td colspan="2"><font size="-1"><b>Pct: </b>  <xsl:apply-templates select="witsml:lithPc" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="4"><font size="-1"><b>Desc: </b>  <xsl:value-of select="witsml:description"/></font></td>
					<td colspan="2"><font size="-1"><b>Class: </b>  <xsl:value-of select="witsml:lithClass"/></font></td>
					<td colspan="2"><font size="-1"><b>Grain Type: </b>  <xsl:value-of select="witsml:grainType"/></font></td></tr>
				<tr><td colspan="4"><font size="-1"><b>Dunham Class: </b>  <xsl:value-of select="witsml:dunhamClass"/></font></td>
					<td colspan="2"><font size="-1"><b>Color: </b>  <xsl:value-of select="witsml:color"/></font></td>
					<td colspan="2"><font size="-1"><b>Texture: </b>  <xsl:value-of select="witsml:texture"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Hardness: </b>  <xsl:value-of select="witsml:hardness"/></font></td>
					<td colspan="1"><font size="-1"><b>Size Grain: </b>  <xsl:value-of select="witsml:sizeGrain"/></font></td>
					<td colspan="1"><font size="-1"><b>Roundness: </b>  <xsl:value-of select="witsml:roundness"/></font></td>
					<td colspan="2"><font size="-1"><b>Sorting: </b>  <xsl:value-of select="witsml:sorting"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Matrix Cement: </b>  <xsl:value-of select="witsml:matrixCement"/></font></td>
					<td colspan="1"><font size="-1"><b>Visible Porosity : </b>  <xsl:value-of select="witsml:porosityVisible"/></font></td>
					<td colspan="5"><font size="-1"><b>Permeability: </b>  <xsl:value-of select="witsml:permeability"/></font></td></tr>

				<tr>	<td colspan="2"><font size="-1"><b>Shale Density: </b>  <xsl:apply-templates select="witsml:densShale" mode="valueWithUomRef"/></font></td></tr>

				<!--	Check for Qualifier data	-->	
				<xsl:for-each select="witsml:qualifier">
					<xsl:apply-templates select="."/>
				</xsl:for-each>
	</xsl:template>	
	
	<!--									Show Template								-->
	<xsl:template match="witsml:show">				
				<tr><td colspan="2"><font size="+1" color="blue">Show</font></td>
					<td colspan="1"><font size="-1"><b>Rating: </b>  <xsl:value-of select="witsml:showRat"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Stain: </b></font></td>
					<td colspan="2"><font size="-1"><b>Color: </b>  <xsl:value-of select="witsml:stainColor"/></font></td>
					<td colspan="4"><font size="-1"><b>Distribution: </b>  <xsl:value-of select="witsml:stainDistr"/></font></td>
					<td colspan="1"><font size="-1"><b>Pct: </b>  <xsl:apply-templates select="witsml:stainPc" mode="valueWithUomRef"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Natural Fluorescence: </b></font></td>
					<td colspan="2"><font size="-1"><b>Color: </b>  <xsl:value-of select="witsml:natFlorColor"/></font></td>
					<td colspan="2"><font size="-1"><b>Desc: </b>  <xsl:value-of select="witsml:natFlorDesc"/></font></td>
					<td colspan="2"><font size="-1"><b>Level: </b>  <xsl:value-of select="witsml:natFlorLevel"/></font></td>
					<td colspan="1"><font size="-1"><b>Pct: </b>  <xsl:apply-templates select="witsml:natFlorPc" mode="valueWithUomRef"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Cut: </b></font></td>
					<td colspan="1"><font size="-1"><b>Color: </b>  <xsl:value-of select="witsml:cutColor"/></font></td>
					<td colspan="1"><font size="-1"><b>Speed: </b>  <xsl:value-of select="witsml:cutSpeed"/></font></td>
					<td colspan="1"><font size="-1"><b>Strength: </b>  <xsl:value-of select="witsml:cutStrength"/></font></td>
					<td colspan="1"><font size="-1"><b>Form: </b>  <xsl:value-of select="witsml:cutForm"/></font></td>
					<td colspan="2"><font size="-1"><b>Level: </b>  <xsl:value-of select="witsml:cutLevel"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Cut Fluorescence: </b></font></td>
					<td colspan="1"><font size="-1"><b>Color: </b>  <xsl:value-of select="witsml:cutFlorColor"/></font></td>
					<td colspan="1"><font size="-1"><b>Speed: </b>  <xsl:value-of select="witsml:cutFlorSpeed"/></font></td>
					<td colspan="1"><font size="-1"><b>Strength: </b>  <xsl:value-of select="witsml:cutFlorStrength"/></font></td>
					<td colspan="1"><font size="-1"><b>Form: </b>  <xsl:value-of select="witsml:cutFlorForm"/></font></td>
					<td colspan="2"><font size="-1"><b>Level: </b>  <xsl:value-of select="witsml:cutFlorLevel"/></font></td></tr>
				<tr>	<td align="right"><font size="-1"><b>Residue Color: </b></font></td><td><font size="-1">  <xsl:value-of select="witsml:residueColor"/></font></td>
					<td colspan="3"><font size="-1"><b>Impregnated Litho: </b>  <xsl:value-of select="witsml:impregnatedLitho"/></font></td>
					<td colspan="3"><font size="-1"><b>Odor: </b>  <xsl:value-of select="witsml:odor"/></font></td></tr>
				<tr>	<td align="right"><font size="-1"><b>Desc: </b></font></td><td colspan="7"><font size="-1"><xsl:value-of select="witsml:showDesc"/></font></td></tr>
	</xsl:template>	

	<!--									Chromatograph Template								-->
	<xsl:template match="witsml:chromatograph">				
				<tr><td colspan="2"><font size="+1" color="blue">Chromatograph</font></td>
					<td colspan="3"><font size="-1"><b>Sample Date: </b>  <xsl:value-of select="witsml:dTim"/></font></td></tr>
				<tr><td></td>
					<td colspan="1"><font size="-1"><b>MD Top: </b>  <xsl:apply-templates select="witsml:mdTop" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD Bot: </b>  <xsl:apply-templates select="witsml:mdBottom" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Mud Den. In: </b>  <xsl:apply-templates select="witsml:wtMudIn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Mud Den. Out: </b>  <xsl:apply-templates select="witsml:wtMudOut" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td colspan="2"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:chromType"/></font></td>
					<td colspan="1"><font size="-1"><b>Cycle: </b>  <xsl:apply-templates select="witsml:eTimChromCycle" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Integrator Rpt Time: </b>  <xsl:value-of select="witsml:chromIntRpt"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>Methane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:methAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:methMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:methMx" mode="valueWithUomRef"/></font></td></tr>
					<tr><td></td>
					<td align="right"><font size="-1"><b>Ethane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:ethAv" mode="valueWithUomRef"/>: </font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:ethMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:ethMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>Propane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:propAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:propMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:propMxv" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>iso-Butane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:ibutAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:ibutMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:ibutMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>nor-Butane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:nbutAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:nbutMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:nbutMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>iso-Pentane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:ipentAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:ipentMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:ipentMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>nor-Pentane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:npentAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:npentMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:npentMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>neo-Pentane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:epentAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:epentMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:epentMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>iso-Hexane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:ihexAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:ihexMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:ihexMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>nor-Hexane: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:nhexAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:nhexAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:nhexMx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>Carbon Dioxide: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:co2Av" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:co2Mn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:co2Mx" mode="valueWithUomRef"/></font></td></tr>
				<tr><td></td>
					<td align="right"><font size="-1"><b>Hydrogen Sulfide: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:h2sAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Min: </b>  <xsl:apply-templates select="witsml:h2sMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:h2sMx" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Acetylene: </b>  <xsl:apply-templates select="witsml:acetylene" mode="valueWithUomRef"/></font></td></tr>
	</xsl:template>	
	
	<!--									Mud Gas Template								-->
	<xsl:template match="witsml:mudGas">				
				<tr><td colspan="2"><font size="+1" color="blue">Mud Gas</font></td>
					<td colspan="2"><font size="-1"><b>Background: </b>  <xsl:apply-templates select="witsml:gasBackgnd" mode="valueWithUomRef"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Gas: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:gasAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Peak: </b>  <xsl:apply-templates select="witsml:gasPeak" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Peak Type: </b>  <xsl:value-of select="witsml:gasPeakType"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Gas Connection: </b></font></td>
					<td colspan="1"><font size="-1"><b>Avg: </b>  <xsl:apply-templates select="witsml:gasConAv" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max: </b>  <xsl:apply-templates select="witsml:gasConMx" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Trip Gas Last Reading: </b>  <xsl:apply-templates select="witsml:gasTrip" mode="valueWithUomRef"/></font></td></tr>

	</xsl:template>	
	
	<!--									Qualifier Template							-->
	<xsl:template match="witsml:qualifier">					
				<tr><td colspan="1" align="center"><font size="+1" color="blue">Qualifier</font></td>
					<td colspan="2"><font size="-1"><b>Type: </b>  <xsl:apply-templates select="witsml:type" mode="QualifierType"/></font></td>
					<td colspan="1"><font size="-1"><b>MD Top: </b>  <xsl:apply-templates select="witsml:mdTop" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>MD Bottom: </b> <xsl:apply-templates select="witsml:mdBottom" mode="valueWithUomRef"/></font></td>
				</tr>
				<tr><td colspan="1"><font size="-1"><b>Abundance: </b> <xsl:apply-templates select="witsml:abundance" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Abundance Code: </b>  <xsl:value-of select="witsml:abundanceCode"/></font></td>
				</tr>
				<tr><td colspan="8"><font size="-1"><b>Description: </b>  <xsl:value-of select="witsml:description"/></font></td>
				</tr>
	</xsl:template>	



<!--       				Element linked to the LithologyType in enum file.  		-->
	<xsl:template match="*" mode="LithologyType">
		<a href="../ancillary/enumValues.xml#LithologyType::{.}">
			<xsl:value-of select="."/>
		</a>
	</xsl:template>	

<!--       				Element linked to the QualifierType in enum file.  		-->
	<xsl:template match="*" mode="QualifierType">
		<a href="../ancillary/enumValues.xml#QualifierType::{.}">
			<xsl:value-of select="."/>
		</a>
	</xsl:template>	
	
</xsl:stylesheet>
