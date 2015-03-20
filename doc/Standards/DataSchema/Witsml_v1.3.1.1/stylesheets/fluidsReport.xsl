<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"  
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Fluids Report Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="8" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="8"><font size="+2" color="blue">Fluids Report</font></th></tr>
		<xsl:for-each select="witsml:fluidsReports">
			<xsl:for-each select="witsml:fluidsReport">
				<tr>	<td colspan="3"><font size="+1" color="blue">uidWell: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>uidWellbore: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Report Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1"><b>Time Stamp</b>  <xsl:value-of select="witsml:dTim"/></font></td>
					<td colspan="1"><font size="-1"><b>Rpt no.: </b> <xsl:value-of select="witsml:numReport"/></font></td>
					<td colspan="2"><font size="-1"><b>MD: </b>  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>TVD: </b>  <xsl:apply-templates select="witsml:tvd" mode="valueWithUomRef"/></font></td>						</tr>

				<!--		Check for Fluid data	-->	
				<xsl:for-each select="witsml:fluid">
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


	<!--									fluid Template							-->
	<xsl:template match="witsml:fluid">				
				<tr><td colspan="8" align="center"><font size="+1" color="blue">Fluid Properties</font><font size="-1"> (uid: <xsl:value-of select="@uid"/>)</font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Company: </b>  <xsl:value-of select="witsml:company"/></font></td>
					<td colspan="3"><font size="-1"><b>Engineer: </b>  <xsl:value-of select="witsml:engineer"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:type"/></font></td>
					<td colspan="3"><font size="-1"><b>Sample location: </b>  <xsl:value-of select="witsml:locationSample"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Density: </b>  <xsl:apply-templates select="witsml:density" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Funnel Viscosity: </b>  <xsl:apply-templates select="witsml:visFunnel" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Funnel Viscosity Temp: </b>  <xsl:apply-templates select="witsml:tempVis" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Plastic Viscosity: </b>  <xsl:apply-templates select="witsml:pv" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Yield Point: </b>  <xsl:apply-templates select="witsml:yp" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>10 sec. gels: </b>  <xsl:apply-templates select="witsml:gel10Sec" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>10 min. gels: </b>  <xsl:apply-templates select="witsml:gel10Min" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>30 min. gels: </b>  <xsl:apply-templates select="witsml:gel30Min" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Filter cake thickness: </b>  <xsl:apply-templates select="witsml:filterCakeLtlp" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>API water loss: </b>  <xsl:apply-templates select="witsml:filtrateLtlp" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>HTHP: </b></font></td>
					<td colspan="1"><font size="-1"><b>Temp.: </b>  <xsl:apply-templates select="witsml:tempHthp" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Pressure: </b>  <xsl:apply-templates select="witsml:presHthp" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Filtrate: </b>  <xsl:apply-templates select="witsml:filtrateHthp" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Filter cake thickness: </b>  <xsl:apply-templates select="witsml:filterCakeHthp" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Percent: </b></font></td>
					<td colspan="1"><font size="-1"><b>Solids from retort: </b>  <xsl:apply-templates select="witsml:solidsPc" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Water: </b>  <xsl:apply-templates select="witsml:waterPc" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Oil: </b>  <xsl:apply-templates select="witsml:oilPc" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Sand: </b>  <xsl:apply-templates select="witsml:sandPc" mode="valueWithUomRef"/>: </font></td>
					<td colspan="1"><font size="-1"><b>Low grav solids: </b>  <xsl:apply-templates select="witsml:solidsLowGravPc" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b></b></font></td>
					<td colspan="1"><font size="-1"><b>Solids (calc.): </b>  <xsl:apply-templates select="witsml:solidsCalcPc" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Barite: </b>  <xsl:apply-templates select="witsml:baritePc" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Brine: </b>  <xsl:apply-templates select="witsml:brinePc" mode="valueWithUomRef"/>: </font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b>Loss Circ Matl: </b>  <xsl:apply-templates select="witsml:lcm" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>CEC of Mud Sample meas. by MBT: </b>  <xsl:apply-templates select="witsml:mbt" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Mud pH: </b>  <xsl:value-of select="witsml:ph"/></font></td>
					<td colspan="2"><font size="-1"><b>Mud pH meas. temp: </b>  <xsl:apply-templates select="witsml:tempPh" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2" align="right"><font size="-1"><b>Phenolpthalein alkalinity: </b></font></td>
					<td colspan="2"><font size="-1"><b>of whole mud: </b>  <xsl:apply-templates select="witsml:pm" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>of mud filtrate: </b>  <xsl:apply-templates select="witsml:pmFiltrate" mode="valueWithUomRef"/></font></td></tr>
					<tr><td colspan="2"><font size="-1"><b>Methyl orange alkalinity of filtrate: </b>  <xsl:apply-templates select="witsml:mf" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Mud alkalinity P1: </b>  <xsl:apply-templates select="witsml:alkalinityP1" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Mud alkalinity P2: </b>  <xsl:apply-templates select="witsml:alkalinityP2" mode="valueWithUomRef"/></font></td></tr>
					<tr><td colspan="1" align="right"><font size="-1"><b>Content: </b></font></td>
						<td colspan="1"><font size="-1"><b>Chloride: </b>  <xsl:apply-templates select="witsml:chloride" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Calcium: </b>  <xsl:apply-templates select="witsml:calcium" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Magnesium: </b>  <xsl:apply-templates select="witsml:magnesium" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Potassium: </b>  <xsl:apply-templates select="witsml:potassium" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Lime: </b>  <xsl:apply-templates select="witsml:lime" mode="valueWithUomRef"/></font></td>
						<td colspan="1"><font size="-1"><b>Sulfide: </b>  <xsl:apply-templates select="witsml:sulfide" mode="valueWithUomRef"/></font></td></tr>
					<tr>	<td colspan="2"><font size="-1"><b>Emulsion stability: </b>  <xsl:apply-templates select="witsml:electStab" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Calcium chloride: </b>  <xsl:apply-templates select="witsml:calciumChloride" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Avg spec grav of solids: </b>  <xsl:apply-templates select="witsml:asg" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Solid high grav.: </b>  <xsl:apply-templates select="witsml:solidsHiGravPc" mode="valueWithUomRef"/></font></td></tr>
					<tr><td colspan="2"><font size="-1"><b>Polymer in mud: </b>  <xsl:apply-templates select="witsml:polymer" mode="valueWithUomRef"/></font></td>
						<td colspan="4"><font size="-1"><b>Type of polymers: </b>  <xsl:value-of select="witsml:polyType"/></font></td></tr>
					<tr><td colspan="2"><font size="-1"><b>Solids corr. for chloride: </b>  <xsl:apply-templates select="witsml:solCorPc" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Oil cuttings: </b>  <xsl:apply-templates select="witsml:oilCtg" mode="valueWithUomRef"/></font></td>
						<td colspan="2"><font size="-1"><b>Calcium hardness: </b>  <xsl:apply-templates select="witsml:hardnessCa" mode="valueWithUomRef"/></font></td></tr>
					<tr><td colspan="8"><font size="-1"><b>Fluid Property Comments: </b><xsl:value-of select="witsml:comments" /></font></td></tr>

				<!--		Check for Rheometer Readings	-->	
				<tr><td colspan="8" align="center"><font size="+1" color="blue">Rheometer Readings</font></td></tr>
				<xsl:for-each select="witsml:rheometer">
					<xsl:apply-templates select="."/>
				</xsl:for-each>
	</xsl:template>	
	
	<!--									rheometer Template							-->
	<xsl:template match="witsml:rheometer">				
				<tr><td colspan="1" align="right"><font size="-1"><b>Reading:</b></font><BR/><font size="-1"> (uid: <xsl:value-of select="@uid"/>)</font></td>
					<td colspan="2" align="center"><font size="-1"><b>Temperature: </b>  <xsl:apply-templates select="witsml:tempRheom" mode="valueWithUomRef"/></font></td>
					<td colspan="2" align="center"><font size="-1"><b>Pressure: </b>  <xsl:apply-templates select="witsml:presRheom" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Viscometer: </b></font></td>
					<td colspan="1"><font size="-1"><b>3 RPM: </b>  <xsl:value-of select="witsml:vis3Rpm"/></font></td>
					<td colspan="1"><font size="-1"><b>6 RPM: </b>  <xsl:value-of select="witsml:vis6Rpm"/></font></td>
					<td colspan="1"><font size="-1"><b>100 RPM: </b>  <xsl:value-of select="witsml:vis100Rpm"/></font></td>
					<td colspan="1"><font size="-1"><b>200 RPM: </b>  <xsl:value-of select="witsml:vis200Rpm"/></font></td>
					<td colspan="1"><font size="-1"><b>300 RPM: </b>  <xsl:value-of select="witsml:vis300Rpm"/></font></td>
					<td colspan="1"><font size="-1"><b>600 RPM: </b>  <xsl:value-of select="witsml:vis600Rpm"/></font></td></tr>
	</xsl:template>	

	
</xsl:stylesheet>
