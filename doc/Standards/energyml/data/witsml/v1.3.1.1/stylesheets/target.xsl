<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
		xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Target Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="9" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="9"><font size="+2" color="blue">Target Information</font></th></tr>
		<xsl:for-each select="witsml:targets">
			<xsl:for-each select="witsml:target">
				<tr>	<td colspan="3"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Target uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="5"><font size="-1" color="blue"><b>Target Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>
				<tr>	<td colspan="4"><font size="-1"><b>Target parent uid: </b> <xsl:value-of select="witsml:uidTargetParent"/></font></td>
					<td colspan="4"><font size="-1"><b>Target parent name: </b> <xsl:value-of select="witsml:nameTargetParent"/></font></td></tr>
				<tr>	<td colspan="2" align="right"><font size="-1"><b>Target center points: </b></font></td>
					<td colspan="2"><font size="-1"><b>Northing: </b>  <xsl:apply-templates select="witsml:dispNsCenter" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Easting: </b>  <xsl:apply-templates select="witsml:dispEwCenter" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Depth: </b>  <xsl:apply-templates select="witsml:dispEwCenter" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b></b></font></td>
					<td colspan="2"><font size="-1"><b>Height above: </b>  <xsl:apply-templates select="witsml:thickAbove" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Depth below: </b>  <xsl:apply-templates select="witsml:thickBelow" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2" align="right"><font size="-1"><b>Offset of target intercept: </b></font></td>
					<td colspan="2"><font size="-1"><b>Northing: </b>  <xsl:apply-templates select="witsml:dispNsCenter" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Easting: </b>  <xsl:apply-templates select="witsml:dispEwCenter" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2" align="right"><font size="-1"><b>Disp. sect. orig.: </b></font></td><td><font size="-1">NS:  <xsl:apply-templates select="witsml:dispNsSectOrig" mode="valueWithUomRef"/></font></td>
					<td><font size="-1">EW:  <xsl:apply-templates select="witsml:dispEwSectOrig" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Angle of dip: </b>  <xsl:apply-templates select="witsml:dip" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Direction of dip: </b>  <xsl:apply-templates select="witsml:strike" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Direction of target geometry: </b>  <xsl:apply-templates select="witsml:rotation" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Major axis length: </b>  <xsl:apply-templates select="witsml:lenMajorAxis" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Minor Axis width: </b>  <xsl:apply-templates select="witsml:widMinorAxis" mode="valueWithUomRef"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeTargetScope"/></font></td>
					<td colspan="3"><font size="-1"><b>Azimuth ref: </b>  <xsl:value-of select="witsml:aziRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Target category: </b>  <xsl:value-of select="witsml:catTarg"/></font></td></tr>
			
				<!--		Check for a location	-->	
				<xsl:if test="witsml:location">
					<tr><td colspan="9" align="center"><font size="+1" color="blue">Target Location</font></td></tr>
					<xsl:for-each select="witsml:location">
						<xsl:apply-templates select="."/>
					</xsl:for-each>
				</xsl:if>

				<tr><td colspan="9" align="center"><font size="+1" color="blue">Target Sections</font></td></tr>
				<!--		Check for a target section	-->	
				<xsl:for-each select="witsml:targetSection">
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--      Common Data   -->
				<tr><td colspan="9" align="center"><font size="+1" color="blue">Common Data</font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Creation Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></font></td>
					<td colspan="3"><font size="-1"><b>Last Chg Time Stamp: </b><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></font></td>
					<td colspan="3"><font size="-1"><b>State: </b><xsl:value-of select="witsml:commonData/witsml:itemState"/></font></td></tr>
				<tr><td colspan="9"><font size="-1"><b>Comments: </b><xsl:value-of select="witsml:commonData/witsml:comments"/></font></td></tr>


			</xsl:for-each>	
		</xsl:for-each>	
	</table>
	</body>
	</html>
	</xsl:template>

	
	<!--									section Template							-->
	<xsl:template match="witsml:targetSection">				
				<tr><td colspan="1"><font size="-1"><b>Section seq.: </b>  <xsl:value-of select="witsml:sectNumber"/></font></td>
					<td colspan="8"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeTargetSectionScope"/></font></td></tr>
				<tr><td colspan="1"><font size="-1"><b></b></font></td>
					<td colspan="2"><font size="-1"><b>Radius length: </b>  <xsl:apply-templates select="witsml:lenRadius" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Arc angle: </b>  <xsl:apply-templates select="witsml:angleArc" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Height above: </b>  <xsl:apply-templates select="witsml:thickAbove" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Depth below: </b>  <xsl:apply-templates select="witsml:thickBelow" mode="valueWithUomRef"/></font></td></tr>
				<!--	Check for a location	-->
				<tr><td colspan="1" align="left"><font size="-1"></font></td>
				    <td colspan="8" align="center"><font size="-1"><b>Section Location</b></font></td></tr>	
				<xsl:for-each select="witsml:location">
					<xsl:apply-templates select="."/>
				</xsl:for-each>
	</xsl:template>	
	
<!--					Location Template		-->
<xsl:template match="witsml:location">
  <tr>
  <td colspan="1"/>
  <td colspan="1">
    <font size="-1">
      <b>uid: </b> 
      <xsl:value-of select="@uid" /> 
    </font>
  </td>
  <td colspan="2">
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

	<!--					Common Data Template		-->
	<xsl:template match="witsml:commonData">					
				<tr><td colspan="3"><font size="-1"><b>User ID: </b>  <xsl:value-of select="witsml:nameSource"/></font></td>
					<td colspan="3"><font size="-1"><b>Time Stamp: </b>  <xsl:value-of select="witsml:dTimStamp"/></font></td>
					<td colspan="3"><font size="-1"><b>State: </b> <xsl:value-of select="witsml:itemState"/></font></td></tr>
				<tr><td colspan="9"><font size="-1"><b>Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>
	</xsl:template>		
	

</xsl:stylesheet>
