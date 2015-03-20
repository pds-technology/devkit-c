<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet 
	version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:output method="html" />

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Well Data Object
		</title>
	</head>

	<body>
	<table  border="2" align="center">
		<tr><th colspan="7" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="7"><font size="+2" color="blue">Well Master Information</font></th></tr>
		<xsl:for-each select="witsml:wells/witsml:well">
			<tr>	<td colspan="2"><font size="+1" color="blue">uid: </font>  <xsl:value-of select="@uid"/></td>
				<td colspan="5"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:name"/></td></tr>
			<tr>	<td><b>Operator: </b></td><td><xsl:value-of select="witsml:operator"/></td>
				<td><b>Division: </b></td><td><xsl:value-of select="witsml:operatorDiv"/></td>
				<td><b>Interest: </b></td><td><xsl:apply-templates select="witsml:pcInterest" mode="valueWithUomRef"/></td></tr>
			<tr>	<td><b>Field: </b></td><td><xsl:value-of select="witsml:field"/></td>
				<td><b>Block: </b></td><td><xsl:value-of select="witsml:block"/></td></tr>
			<tr>	<td><b>legal Name: </b></td><td><xsl:value-of select="witsml:nameLegal"/></td></tr>
			<tr>	<td><b>License Number: </b></td><td><xsl:value-of select="witsml:numLicense"/></td>
				<td><b>API Number: </b></td><td><xsl:value-of select="witsml:numAPI"/></td></tr>
			
			<tr>	<td><b>License Date: </b></td><td><xsl:value-of select="witsml:dTimLicense"/></td>
				<td><b>Govt. Number: </b></td><td><xsl:value-of select="witsml:numGovt"/></td></tr>
			
			<tr>	<td><b>Region: </b></td><td><xsl:value-of select="witsml:region"/></td>
				<td><b>District: </b></td><td><xsl:value-of select="witsml:district"/></td></tr>
			<tr>	<td><b>County: </b></td><td><xsl:value-of select="witsml:county"/></td>
				<td><b>State: </b></td><td><xsl:value-of select="witsml:state"/></td>
				<td><b>Country: </b></td><td><xsl:value-of select="witsml:country"/></td></tr>
			<tr>	<td colspan="7" align="Center"><b>-------------------------------------------------------------- Status/Purpose/Dates/Times ---------------------------------------------------------------</b></td></tr>
			<tr>	<td><b>Time Zone: </b></td><td><xsl:value-of select="witsml:timeZone"/></td></tr>
			<tr>	<td><b>Well Status: </b></td><td><xsl:value-of select="witsml:statusWell"/></td>
				<td><b>Purpose: </b></td><td><xsl:value-of select="witsml:purposeWell"/></td></tr>
			<tr>	<td><b>Date/Time Spud: </b></td><td><xsl:value-of select="witsml:dTimSpud"/></td>
				<td><b>Date/Time PA: </b></td><td><xsl:value-of select="witsml:dTimPa"/></td></tr>
			<tr>	<td colspan="7" align="Center"><b>---------------------------------------------------------------- References/Elevations ------------------------------------------------------------------</b></td>
			</tr>

			<tr>	<td><b>Wellhead Elevation: </b></td><td><xsl:apply-templates select="witsml:wellheadElevation" mode="valueWithUomRef"/></td>
				<td><b>Ground Elevation: </b></td><td><xsl:apply-templates select="witsml:groundElevation" mode="valueWithUomRef"/></td>
				<td><b>Water Depth: </b></td><td><xsl:apply-templates select="witsml:waterDepth" mode="valueWithUomRef"/></td>
			</tr>

			<tr>	<td colspan="7" align="center"><b>------------------------------------------------------------------------- Common Data ------------------------------------------------------------------------</b></td></tr>
			<tr>	<td><b>Creation Time Stamp: </b></td><td><xsl:value-of select="witsml:commonData/witsml:dTimCreation"/></td>
				<td><b>Last Chg Time Stamp: </b></td><td><xsl:value-of select="witsml:commonData/witsml:dTimLastChange"/></td>
				<td><b>Item State: </b></td><td><xsl:value-of select="witsml:commonData/witsml:itemState"/></td></tr>
			<tr>	<td><b>Comments: </b></td><td colspan="6"><xsl:value-of select="witsml:commonData/witsml:comments"/></td></tr>

			<tr>	<td colspan="7" align="Center"><b>----------------------------------------------------------------- Elevation and Depth Datums -------------------------------------------------------------------------</b></td>
			</tr>
			  <xsl:for-each select="witsml:wellDatum">
			    <xsl:apply-templates select="." /> 
			  </xsl:for-each>


			<xsl:if test="witsml:wellLocation">
			  <tr>	<td colspan="7" align="Center"><b>------------------------------------------------------------------------- Well Location ------------------------------------------------------------------------</b></td>
			  </tr>
			  <xsl:for-each select="witsml:wellLocation">
			    <xsl:call-template name="location" /> 
			  </xsl:for-each>
			</xsl:if>

			<xsl:if test="witsml:referencePoint">
			  <tr>	<td colspan="7" align="Center"><b>------------------------------------------------------------------------- Reference Points ------------------------------------------------------------------------</b></td>
			  </tr>
			  <xsl:for-each select="witsml:referencePoint">
			    <xsl:apply-templates select="." /> 
			  </xsl:for-each>
			</xsl:if>
			
			<xsl:if test="witsml:wellCRS">
			  <tr>	<td colspan="7" align="center"><b>------------------------------------------------------------ Coordinate Reference Systems --------------------------------------------------------------</b></td></tr>
			  <xsl:for-each select="witsml:wellCRS">
			    <xsl:apply-templates select="."/>
			  </xsl:for-each>
			</xsl:if>


		</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>

	
	
<!--					Well Datum Template									-->
	<xsl:template match="witsml:wellDatum">
		<TR>
			<TD colspan="2">
				<B>Name: </B>
				<xsl:value-of select="witsml:name"/>
				<xsl:text> </xsl:text>
				(uid=<xsl:value-of select="@uid"/>)
			</TD>
			<TD colspan="2">
				<B>Code: </B>
				<xsl:value-of select="witsml:code"/>
			</TD>
			<TD colspan="2">
				<B>Datum Name: </B>
				<xsl:value-of select="witsml:datumName"/>
				<xsl:if test="witsml:datumName/@namingSystem">
					(naming system="<xsl:value-of select="witsml:datumName/@namingSystem"/>")
				</xsl:if>
				<xsl:if test="witsml:datumName/@namingSystem">
					(code="<xsl:value-of select="witsml:datumName/@code"/>")
				</xsl:if>
			</TD>
		</TR>
		<TR>
			<TD colspan="2">
				
			</TD>
			<TD colspan="2">
				<B>Kind: </B>
				<xsl:value-of select="witsml:kind"/>
			</TD>
			<TD align='right'>
				<B>Default For: </B>
			</TD>
			<TD>
				<xsl:if test="@defaultMeasuredDepth">
					Measured Depths 
					<xsl:choose>
						<xsl:when test="@defaultVerticalDepth">
							<BR/>
						</xsl:when>
						<xsl:when test="@defaultElevation">
							<BR/>
						</xsl:when>
					</xsl:choose>
				</xsl:if>
				<xsl:if test="@defaultVerticalDepth">
					Vertical Depths 
					<xsl:if test="@defaultElevation">
						<BR/>
					</xsl:if>
				</xsl:if>
				<xsl:if test="@defaultElevation">
					Elevations 
				</xsl:if>
			</TD>
		</TR>
		<TR>
			<TD colspan="2">
				
			</TD>
			<TD colspan="2">
				<B>Elevation: </B>
				<xsl:apply-templates select="witsml:elevation" mode="valueWithUomRef"/>
			</TD>
			<TD colspan="2">
				<B>Measured Depth: </B>
				<xsl:apply-templates select="witsml:measuredDepth" mode="valueWithUomRef"/>
			</TD>
		</TR>
	</xsl:template>
	
<!--					Location Template				-->
  <xsl:template name="location">
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
      <xsl:value-of select="witsml:wellCRS" /> 
    </font>
  </td>
  <td colspan="1">
    <font size="-1">
      <b>CRS uid: </b> 
      <xsl:value-of select="witsml:wellCRS/@uidRef" /> 
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
  </tr>
  <tr>
  <td colspan="1" /> 
  <td colspan="5">
    <font size="-1">
      <b>Description: </b> 
      <xsl:value-of select="witsml:description" /> 
    </font>
  </td>
  </tr>
  </xsl:template>

<!--					Reference Point Template				-->
	<xsl:template match="witsml:referencePoint">
			<tr>
				<td align="right"><b>Reference Point</b></td>
				<td><b>Name: </b><xsl:value-of select="witsml:name"/></td>
				<td><b>Uid: </b><xsl:value-of select="@uid"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Type: </b></td><td><xsl:value-of select="witsml:type"/></td>
				<td><b>Elevation: </b></td><td><xsl:apply-templates select="witsml:elevation" mode="valueWithUomRef"/></td>
				<td><b>Measured Depth: </b></td><td><xsl:apply-templates select="witsml:measuredDepth" mode="valueWithUomRef"/></td>
			</tr>
			<xsl:for-each select="witsml:location">
				<xsl:call-template name="location"/>
			</xsl:for-each>
			<tr>
				<td></td>
				<td colspan="6"><b>Point Description: </b><xsl:value-of select="../witsml:description"/></td>
			</tr>

	</xsl:template>

	<xsl:template match="witsml:wellCRS">
			<xsl:apply-templates select="witsml:mapProjection |
						     witsml:geographic | 
						     witsml:localCRS"/>
	</xsl:template>

<!--				Projection Templates			-->
	<xsl:template match="witsml:mapProjection">
			<tr>
				<td align="right"><b>Projection System</b></td>
				<td><b>Name: </b><xsl:value-of select="../witsml:name"/></td>
				<td><b>Uid: </b><xsl:value-of select="../@uid"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Well Known</b></td><td><b>Name: </b><xsl:value-of select="witsml:nameCRS"/></td>
				<td><b>Code: </b><xsl:value-of select="witsml:nameCRS/@code"/></td>
				<td><b>Naming System: </b><xsl:value-of select="witsml:nameCRS/@namingSystem"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Projected From</b></td>
				<td><b>Name</b> :<xsl:value-of select="witsml:nameWellCRS"/></td>
				<td><b>Uid</b> :<xsl:value-of select="witsml:nameWellCRS/@uidRef"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Projection Code: </b></td>
				<td><xsl:value-of select="../witsml:projectionCode"/></td>
			</tr>
			<xsl:apply-templates select="witsml:stdParallel1 |
						     witsml:centralMeridian |
						     witsml:originLongitude |
						     witsml:falseEasting |
						     witsml:spheroidRadius |
						     witsml:scaleFactor |
						     witsml:trueScaleLatitude |
						     witsml:bearing |
						     witsml:latitude1 |
						     witsml:longitude1 |
						     witsml:latitude2 |
						     witsml:longitude2 |
						     witsml:methodVariant |
						     witsml:perspectiveHeight |
						     witsml:zone |
						     witsml:NADType |
						     witsml:latitudeForScale |
						     witsml:longitudeForScale |
						     witsml:hemisphere |
						     witsml:description |
						     witsml:parameter"/>
			<tr>
				<td></td>
				<td><b>Description: </b></td>
				<td colspan="6"><xsl:value-of select="../witsml:description"/></td>
			</tr>
	</xsl:template>


	<xsl:template match="witsml:stdParallel1">
			<tr>
				<td></td>
				<td><b>Std Parallel 1: </b></td><td><xsl:apply-templates select="witsml:stdParallel1" mode="valueWithUomRef"/></td>
				<td><b>Std Parallel 2: </b></td><td><xsl:apply-templates select="witsml:stdParallel2" mode="valueWithUomRef"/></td>
			</tr>
	</xsl:template>
	
	<xsl:template match="witsml:centralMeridian | witsml:originalLongitude">
			<tr>
				<td></td>
				<td><b>Central Meridian: </b></td>
				<td><xsl:apply-templates select="../witsml:centralMeridian" mode="valueWithUomRef"/></td>
				<td><b>Origin Latitude: </b></td>
				<td><xsl:apply-templates select="../witsml:originLatitude" mode="valueWithUomRef"/></td>
				<xsl:if test="originLongitude">
					<td><b>Origin Longitude: </b></td><td><xsl:apply-templates select="../witsml:originLongitude" mode="valueWithUomRef"/></td>
				</xsl:if></tr>
	</xsl:template>
	
	<xsl:template match="witsml:falseEasting">
			<tr>	<td></td><td><b>False Easting: </b></td>
				<td><xsl:apply-templates select="." mode="valueWithUomRef"/></td>
				<td><b>False Northing: </b></td>
				<td><xsl:apply-templates select="../witsml:falseNorthing" mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:spheroidRadius">
			<tr>	<td></td><td><b>Spheroid Radius: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:scaleFactor">
			<tr>	<td></td><td><b>Scale Factor: </b></td><td><xsl:value-of select="../witsml:scaleFactor"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:trueScaleLatitude">
			<tr>	<td></td><td><b>True Scale Latitude: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:bearing">
			<tr>	<td></td><td><b>Bearing: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:latitude1">
			<tr>	<td></td><td><b>Latitude 1: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:longitude1">
			<tr>	<td></td><td><b>Longitude 1: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:latitude2">
			<tr>	<td></td><td><b>Latitude 2: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:longitude2">
			<tr>	<td></td><td><b>Longitude 2: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:methodVariant">
			<tr>	<td></td><td><b>Method Variant: </b></td><td><xsl:value-of select="../witsml:methodVariant"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:perspectiveHeight">
			<tr>	<td></td><td><b>Perspective Height: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:zone">
			<tr>	<td></td><td><b>Zone: </b></td><td><xsl:value-of select="../witsml:zone"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:NADType">
			<tr>	<td></td><td><b>NAD Type: </b></td><td><xsl:value-of select="../witsml:NADType"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:latitudeForScale">
			<tr>	<td></td><td><b>Latitude For Scale: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:longitudeForScale">
			<tr>	<td></td><td><b>Longitude For Scale: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:hemisphere">
			<tr>	<td></td><td><b>Hemisphere: </b></td><td><xsl:value-of select="../witsml:hemisphere"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:nameProj">
			<tr>	<td></td><td><b>Name: </b></td><td><xsl:value-of select="../witsml:nameProj"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:description">
			<tr>	<td></td>
				<td><b>Description: </b></td>
				<td colspan="6"><xsl:value-of select="../witsml:description"/></td></tr>
	</xsl:template>
	
	<xsl:template match="witsml:parameter">
			<tr>	<td></td><td><b>Parameter: </b></td><td><xsl:apply-templates select="." mode="valueWithUomRef"/></td><td><xsl:value-of select="@index"/></td></tr>
	</xsl:template>

<!--					Geodetic Model Template				-->
	<xsl:template match="witsml:geographic">
			<tr>
				<td align="right"><b>Geographic System</b></td>
				<td><b>Name: </b><xsl:value-of select="../witsml:name"/></td>
				<td><b>Uid: </b><xsl:value-of select="../@uid"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Well Known</b></td><td><b>Name: </b><xsl:value-of select="witsml:nameCRS"/></td>
				<td><b>Code: </b><xsl:value-of select="witsml:nameCRS/@code"/></td>
				<td><b>Naming System: </b><xsl:value-of select="witsml:nameCRS/@namingSystem"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Datum Code: </b></td><td><xsl:value-of select="witsml:geodeticDatumCode"/></td></tr>
			<tr>
				<td></td>
				<td><b>xTranslation: </b></td><td><xsl:apply-templates select="witsml:xTranslation" mode="valueWithUomRef"/></td>
				<td><b>yTranslation: </b></td><td><xsl:apply-templates select="witsml:yTranslation" mode="valueWithUomRef"/></td>
				<td><b>zTranslation: </b></td><td><xsl:apply-templates select="witsml:zTranslation" mode="valueWithUomRef"/></td></tr>
			<tr>
				<td></td>
				<td><b>xRotation: </b></td><td><xsl:apply-templates select="witsml:xRotation" mode="valueWithUomRef"/></td>
				<td><b>yRotation: </b></td><td><xsl:apply-templates select="witsml:yRotation" mode="valueWithUomRef"/></td>
				<td><b>zRotation: </b></td><td><xsl:apply-templates select="witsml:zRotation" mode="valueWithUomRef"/></td></tr>
			<tr>
				<td></td>
				<td><b>scaleFactor: </b></td><td><xsl:value-of select="witsml:scaleFactor"/></td>
				<td><b>ellipsoidCode: </b></td><td><xsl:value-of select="witsml:ellipsoidCode"/></td></tr>
			<tr>
				<td></td>
				<td><b>semi Major Axis: </b></td><td><xsl:apply-templates select="witsml:ellipsoidSemiMajorAxis" mode="valueWithUomRef"/></td>
				<td><b>Inverse Flattening: </b></td><td><xsl:value-of select="witsml:ellipsoidInverseFlattening"/></td></tr>
			<tr>
				<td></td>
				<td><b>Description: </b></td>
				<td colspan="6"><xsl:value-of select="../witsml:description"/></td>
			</tr>

	</xsl:template>

<!--					Local CRS Template				-->
	<xsl:template match="witsml:localCRS">
			<tr>
				<td align="right"><b>Local System</b></td>
				<td><b>Name: </b><xsl:value-of select="../witsml:name"/></td>
				<td><b>Uid: </b><xsl:value-of select="../@uid"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Uses Well as Origin: </b></td>
				<td><xsl:value-of select="witsml:usesWellAsOrigin"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Origin Point</b></td>
				<td><b>Name: </b><xsl:value-of select="witsml:nameReferencePoint"/></td>
				<td><b>Uid: </b><xsl:value-of select="witsml:nameReferencePoint/@uidRef"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Origin Description: </b></td>
				<td><xsl:value-of select="witsml:originDescription"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>North Direction: </b></td>
				<td><xsl:value-of select="witsml:yAxisAzimuth/@northDirection"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Y-Axis Direction: </b></td>
				<td><xsl:apply-templates select="witsml:yAxisAzimuth" mode="valueWithUomRef"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>X-axis Rotated Counter Clockwise: </b></td>
				<td><xsl:value-of select="witsml:xRotationCounterClockwise"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Y-Axis Description: </b></td><td colspan="6"><xsl:value-of select="witsml:yAxisDescription"/></td>
			</tr>
			<tr>
				<td></td>
				<td><b>Description: </b></td><td colspan="6"><xsl:value-of select="../witsml:description"/></td>
			</tr>

	</xsl:template>


</xsl:stylesheet>
