<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSMLSidewall Core Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="8" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="8"><font size="+2" color="blue">Sidewall Core Information</font></th></tr>
		<xsl:for-each select="witsml:sidewallCores">
			<xsl:for-each select="witsml:sidewallCore">
				<tr>	<td colspan="3"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
									<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
								<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
									<td colspan="5"><font size="-1" color="blue"><b>Core uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
								<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Core Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
				<tr><td colspan="2" align="right"><font size="-1"><b>Date/time logging suite: </b></font></td>
					<td colspan="2"><font size="-1"><b>Tool run in hole: </b></font>  <font size="-1"><xsl:value-of select="witsml:dTimToolRun"/></font></td>
					<td colspan="4"><font size="-1"><b>Tool pulled out of hole: </b></font>  <font size="-1"><xsl:value-of select="witsml:dTimToolPull"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>MD: </b></font></td>
					<td colspan="2"><font size="-1"><b>Tool Ref: </b></font>  <xsl:apply-templates select="witsml:mdToolReference" mode="valueWithUomRef"/></td>						
					<td colspan="2"><font size="-1"><b>Core depth</b></font>  <xsl:apply-templates select="witsml:mdCore" mode="valueWithUomRef"/></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Diameter: </b></font></td>
					<td colspan="2"><font size="-1"><b>Hole: </b></font>  <xsl:apply-templates select="witsml:diaHole" mode="valueWithUomRef"/></td>						
				<td colspan="2"><font size="-1"><b>Plug: </b></font>  <xsl:apply-templates select="witsml:diaPlug" mode="valueWithUomRef"/></td></tr>				
				<tr><td colspan="1" align="right"><font size="-1"><b>Number: </b></font></td>
					<td colspan="1"><font size="-1"><b>Total plugs: </b></font>  <xsl:value-of select="witsml:numPlugsShot"/></td>						
					<td colspan="1"><font size="-1"><b>Recovered plugs: </b></font>  <xsl:value-of select="witsml:numRecPlugs"/></td>
					<td colspan="1"><font size="-1"><b>Misfired plugs: </b></font>  <xsl:value-of select="witsml:numMisfiredPlugs"/></td>
					<td colspan="1"><font size="-1"><b>Empty plugs: </b></font>  <xsl:value-of select="witsml:numEmptyPlugs"/></td>
					<td colspan="1"><font size="-1"><b>Lost plugs: </b></font>  <xsl:value-of select="witsml:numLostPlugs"/></td>
					<td colspan="1"><font size="-1"><b>Paid for: </b></font>  <xsl:value-of select="witsml:numPaidPlugs"/></td></tr>				

				<tr><td colspan="3"><font size="-1"><b>Log Ref : </b></font>  <xsl:value-of select="witsml:coreReferenceLog"/></td>
					<td colspan="5"><font size="-1"><b>Tool Desc. : </b></font>  <xsl:value-of select="witsml:sidewallCoringTool"/></td></tr>				
				<tr>	<td colspan="3"><font size="-1"><b>Service Company: </b>  <xsl:value-of select="witsml:serviceCompany"/></font></td>
					<td colspan="3"><font size="-1"><b>Analysis Contractor: </b>  <xsl:value-of select="witsml:analysisContractor"/></font></td>
					<td colspan="2"><font size="-1"><b>Analysis by: </b>  <xsl:value-of select="witsml:analysisBy"/></font></td></tr>

				<!--		Check for Lithology data							-->	
				<xsl:for-each select="witsml:swcSample">
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

	<!--									Sidewall Core Sample Template							-->
	<xsl:template match="witsml:swcSample">				
				<tr><td colspan="8" align="center"><font size="+1" color="blue">SWC Sample - <xsl:value-of select="./@witsmluidSwcPlug"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>MD plug: </b>  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/></font></td>
					<td colspan="6"><font size="-1"><b>Formation: </b>  <xsl:value-of select="witsml:nameFormation"/></font></td></tr>
					
				<xsl:for-each select="witsml:commonData">
					<tr><td colspan="8"><font size="-1"><b>Sample Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>
				</xsl:for-each>
					
				<!--		Check for Lithology data							-->	
				<xsl:for-each select="witsml:lithology">
					<xsl:apply-templates select="."/>
				</xsl:for-each>
				
				<!--		Check for Show data							-->	
				<xsl:for-each select="witsml:show">
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
					<td colspan="1"><font size="-1"><b>Pct: </b>  <xsl:value-of select="witsml:stainPc"/></font></td></tr>
				<tr><td align="right"><font size="-1"><b>Natural Fluorescence: </b></font></td>
					<td colspan="2"><font size="-1"><b>Color: </b>  <xsl:value-of select="witsml:natFlorColor"/></font></td>
					<td colspan="2"><font size="-1"><b>Desc: </b>  <xsl:value-of select="witsml:natFlorDesc"/></font></td>
					<td colspan="2"><font size="-1"><b>Level: </b>  <xsl:value-of select="witsml:natFlorLevel"/></font></td>
					<td colspan="1"><font size="-1"><b>Pct: </b>  <xsl:value-of select="witsml:stainPc"/></font></td></tr>
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
	
	<!--									Lithology Template							-->
	<xsl:template match="witsml:lithology">				
				<tr><td colspan="2"><font size="+1" color="blue">Lithology</font>  <font size="-1">(uid: <xsl:value-of select="./@uid"/>)</font></td>
					<td colspan="1"><font size="-1"><b>Type: </b>  <xsl:apply-templates select="witsml:type" mode="LithologyType"/></font></td>
					<td colspan="2"><font size="-1"><b>Code: </b>  <xsl:value-of select="witsml:codeLith"/></font></td>
					<td><font size="-1"><b>Pct: </b>  <xsl:apply-templates select="witsml:lithPc" mode="valueWithUomRef"/></font></td></tr>
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
