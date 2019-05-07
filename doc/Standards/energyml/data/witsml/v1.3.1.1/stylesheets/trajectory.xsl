<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
		xmlns:witsml="http://www.witsml.org/schemas/131">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Trajectory Data Object
		</title>
	</head>
	<body>
	<table  border="2" align="center">
		<tr><th colspan="9" ><font size="+2" color="blue">WITSML</font></th></tr>
		<tr><th colspan="9"><font size="+2" color="blue">Trajectory Information</font></th></tr>
		<xsl:for-each select="witsml:trajectorys">
			<xsl:for-each select="witsml:trajectory">
				<tr>	<td colspan="3"><font size="+1" color="blue">Well uid: </font>  <xsl:value-of select="@uidWell"/></td>
					<td colspan="6"><font size="+1" color="blue">Well Name: </font>  <xsl:value-of select="witsml:nameWell"/></td></tr>
				<tr>	<td colspan="3"><font size="-1" color="blue"><b>Wellbore uid: </b></font>  <font size="-1"><xsl:value-of select="@uidWellbore"/></font></td>
					<td colspan="6"><font size="-1" color="blue"><b>Trajectory uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1"><b>Wellbore Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameWellbore"/></font></td>
					<td colspan="6"><font size="-1"><b>Traj. Name: </b></font>  <font size="-1"><xsl:value-of select="witsml:name"/></font></td></tr>

				<tr>	<td colspan="3"><font size="-1"><b>Parent Trajectory </b></font></td>
					<td colspan="3"><font size="-1"><b>Trajectory name: </b></font>  <font size="-1"><xsl:value-of select="witsml:parentTrajectory/witsml:trajectoryReference"/></font></td>
					<td colspan="6"><font size="-1"><b>Trajectory uidRef: </b></font>  <font size="-1"><xsl:value-of select="witsml:parentTrajectory/witsml:trajectoryReference/@uidRef"/></font></td></tr>
				<tr>	<td colspan="3"><font size="-1"><b> </b></font></td>
					<td colspan="3"><font size="-1"><b>Wellbore name: </b></font>  <font size="-1"><xsl:value-of select="witsml:parentTrajectory/witsml:wellboreParent"/></font></td>
					<td colspan="6"><font size="-1"><b>Wellbore uidRef: </b></font>  <font size="-1"><xsl:value-of select="witsml:parentTrajectory/witsml:wellboreParent/@uidRef"/></font></td></tr>



				<tr>	<td colspan="3"><font size="-1"><b>Traj. parent uid: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameTrajectory/@uidRef"/></font></td>
					<td colspan="6"><font size="-1"><b>Traj. parent name: </b></font>  <font size="-1"><xsl:value-of select="witsml:nameTrajectory"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Trajectory station dates: </b></font></td>
					<td colspan="2"><font size="-1"><b>Start: </b> <xsl:value-of select="witsml:dTimTrajStart"/></font></td>
					<td colspan="2"><font size="-1"><b>End: </b> <xsl:value-of select="witsml:dTimTrajEnd"/></font></td></tr>
				<tr>	<td colspan="1"><font size="-1"><b>Min MD: </b>  <xsl:apply-templates select="witsml:mdMn" mode="valueWithUomRef"/></font></td>
					<td colspan="1"><font size="-1"><b>Max MD: </b>  <xsl:apply-templates select="witsml:mdMx" mode="valueWithUomRef"/></font></td>
					<td colspan="4"><font size="-1"><b>Service Company: </b>  <xsl:value-of select="witsml:serviceCompany"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Mag. declination used: </b>  <xsl:apply-templates select="witsml:magDeclUsed" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Grid correction used: </b>  <xsl:apply-templates select="witsml:gridCorUsed" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Azimuth used: </b>  <xsl:apply-templates select="witsml:aziVertSect" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Azimuth ref.: </b>  <xsl:value-of select="witsml:aziRef"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Origin NS used: </b>  <xsl:apply-templates select="witsml:dispNsVertSectOrig" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Origin EW used: </b>  <xsl:apply-templates select="witsml:dispEwVertSectOrig" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="3"><font size="-1"><b>Definitive Trajectory?: </b>  <xsl:value-of select="witsml:definitive"/></font></td>
					<td colspan="3"><font size="-1"><b>Traj. result from tool memory dump?: </b>  <xsl:value-of select="witsml:memory"/></font></td>
					<td colspan="3"><font size="-1"><b>Final Trajectory?</b>  <xsl:value-of select="witsml:finalTraj"/></font></td></tr>

				<!--		Check for trajectoryStation Data			-->	
				<xsl:if test="trajectoryStation"><tr><td colspan="9" align="center"><font size="+1" color="blue">Trajectory Stations</font></td></tr></xsl:if>
				<xsl:for-each select="witsml:trajectoryStation">
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

	
	<!--									trajectoryStation Template							-->
	<xsl:template match="witsml:trajectoryStation">	
				<tr>	<td colspan="3"><font size="+1" color="blue"><b>Traj. Station uid: </b></font>  <font size="-1"><xsl:value-of select="@uid"/></font></td></tr>
				<tr><td colspan="2"><font size="-1"><b>Measurements made at: </b></font></td>
					<td colspan="2"><font size="-1"><b>MD: </b>  <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>TVD: </b>  <xsl:apply-templates select="witsml:tvd" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Type: </b>  <xsl:value-of select="witsml:typeTrajStation"/></font></td></tr>
				<tr>	<td colspan="2"><font size="-1"><b>Hole inclination: </b>  <xsl:apply-templates select="witsml:incl" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Hole Azimuth: </b>  <xsl:apply-templates select="witsml:azi" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Mag. toolface angle: </b>  <xsl:apply-templates select="witsml:mtf" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Gravity toolface angle: </b>  <xsl:apply-templates select="witsml:gtf" mode="valueWithUomRef"/></font></td></tr>

				<tr>	<td colspan="2"><font size="-1"><b>NS offset: </b>  <xsl:apply-templates select="witsml:dispNs" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>EW offset: </b>  <xsl:apply-templates select="witsml:dispEw" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vert distance on azi plane: </b>  <xsl:apply-templates select="witsml:vertSect" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Dogleg Severity: </b>  <xsl:apply-templates select="witsml:dls" mode="valueWithUomRef"/></font></td></tr>
				
				<tr><td colspan="2"><font size="-1"><b>Turn rate: </b>  <xsl:apply-templates select="witsml:rateTurn" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Build rate: </b>  <xsl:apply-templates select="witsml:rateBuild" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Delta MD from prev stn: </b>  <xsl:apply-templates select="witsml:mdDelta" mode="valueWithUomRef"/></font></td>
					<td colspan="3"><font size="-1"><b>Delta TVD from prev stn: </b>  <xsl:apply-templates select="witsml:tvdDelta" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Survey tool: </b></font></td>
					<td colspan="2"><font size="-1"><b>Gavity uncert.: </b>  <xsl:apply-templates select="witsml:gravTotalUncert" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Dip uncert.: </b>  <xsl:apply-templates select="witsml:dipAngleUncert" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Magnetic uncert.: </b>  <xsl:apply-templates select="witsml:magTotalUncert" mode="valueWithUomRef"/></font></td></tr>
				<tr><td colspan="1" align="right"><font size="-1"><b>Corr. used?: </b></font></td>
					<td colspan="2"><font size="-1"><b>Accelerometer align.?: </b>  <xsl:value-of select="witsml:gravAccelCorUsed"/></font></td>
					<td colspan="2"><font size="-1"><b>Magnetometer align.?: </b>  <xsl:value-of select="witsml:magXAxialCorUsed"/></font></td>
					<td colspan="2"><font size="-1"><b>BHA sag?: </b>  <xsl:value-of select="witsml:sagCorUsed"/></font></td>
					<td colspan="2"><font size="-1"><b>Drl str mag.?: </b>  <xsl:value-of select="witsml:magDrlstrCorUsed"/></font></td></tr>
				<tr><td colspan="9"><font size="-1"><b>Tool error model: </b>  <xsl:apply-templates select="witsml:modelToolError" mode="valueWithUomRef"/></font></td></tr>
					
				<!--		Check for a rawData	-->	
				<xsl:for-each select="witsml:rawData">
					<tr><td colspan="9" align="center"><font size="-1"><b>Raw Data</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a corUsed	-->	
				<xsl:for-each select="witsml:corUsed">
					<tr><td colspan="9" align="center"><font size="-1"><b>Corrections Used</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>

				<!--		Check for a valid (Validation data)	-->	
				<xsl:for-each select="witsml:valid">
					<tr><td colspan="9" align="center"><font size="-1"><b>Validation Data</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>
			
				<!--		Check for a matrixCov	-->	
				<xsl:for-each select="witsml:matrixCov">
					<tr><td colspan="9" align="center"><font size="-1"><b>Covariance Matrix</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>
			
				<!--		Check for a location	-->
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

				<!--		Check for Common Data			-->	
				<xsl:for-each select="witsml:commonData">
					<tr><td colspan="9" align="center"><font size="-1"><b>Common Data</b></font></td></tr>
					<xsl:apply-templates select="."/>
				</xsl:for-each>
	</xsl:template>		

	<!--									rawData Template							-->
	<xsl:template match="witsml:rawData">				
				<tr><td colspan="3" align="right"><font size="-1"><b>Uncorrected gravity field strength: </b></font></td>
					<td colspan="2"><font size="-1"><b>Axial dir.: </b>  <xsl:apply-templates select="witsml:gravAxialRaw" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 1: </b>  <xsl:apply-templates select="witsml:gravTran1Raw" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 2: </b>  <xsl:apply-templates select="witsml:gravTran2Raw" mode="valueWithUomRef"/></font></td>	</tr>
				<tr><td colspan="3" align="right"><font size="-1"><b>Uncorrected magnetic field field strength: </b></font></td>
					<td colspan="2"><font size="-1"><b>Axial dir.: </b>  <xsl:apply-templates select="witsml:magAxialRaw" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 1: </b>  <xsl:apply-templates select="witsml:magTran1Raw" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 2: </b>  <xsl:apply-templates select="witsml:magTran2Raw" mode="valueWithUomRef"/></font></td>	</tr>
	</xsl:template>	
	
	<!--									corUsed (Corrections Used) Template							-->
	<xsl:template match="witsml:corUsed">				
				<tr><td colspan="3" align="right"><font size="-1"><b>Calc. grav. field Corrections used: </b></font></td>
					<td colspan="2"><font size="-1"><b>Axial dir.: </b>  <xsl:apply-templates select="witsml:gravAxialAccelCor" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 1: </b>  <xsl:apply-templates select="witsml:gravTran1AccelCor" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 2: </b>  <xsl:apply-templates select="witsml:gravTran2AccelCor" mode="valueWithUomRef"/></font></td>	</tr>
				<tr><td colspan="3" align="right"><font size="-1"><b>Magnetic Drillstr corrections used: </b></font></td>
					<td colspan="2"><font size="-1"><b>Axial dir.: </b>  <xsl:apply-templates select="witsml:magAxialDrlstrCor" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 1: </b>  <xsl:apply-templates select="witsml:magTran1DrlstrCor" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Transverse dir. 2: </b>  <xsl:apply-templates select="witsml:magTran2DrlstrCor" mode="valueWithUomRef"/></font></td>	</tr>
				<tr><td colspan="3" align="right"><font size="-1"><b>Magnetic declin. corr used: </b>  <xsl:apply-templates select="witsml:stnMagDeclUsed" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Grid corr. used</b>  <xsl:apply-templates select="witsml:stnGridCorUsed" mode="valueWithUomRef"/></font></td>
					</tr>
	</xsl:template>	

	<!--									valid (validation data) Template							-->
	<xsl:template match="witsml:valid">				
				<tr><td colspan="3" align="right"><font size="-1"><b>Validation Data Used: </b></font></td>
					<td colspan="2"><font size="-1"><b>Calc. total mag. field: </b>  <xsl:apply-templates select="witsml:magTotalFieldCalc" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Calc. mag. dip: </b>  <xsl:apply-templates select="witsml:magDipAngleCalc" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Calc. total grav. field: </b>  <xsl:apply-templates select="witsml:gravTotalFieldCalc" mode="valueWithUomRef"/></font></td>	</tr>
	</xsl:template>	

	<!--									matrixCov Template							-->
	<xsl:template match="witsml:matrixCov">				
				<tr><td colspan="3" align="right"><font size="-1"><b>Covariances/Crossvariances: </b></font></td>
					<td colspan="2"><font size="-1"><b>Cov NN: </b>  <xsl:apply-templates select="witsml:varianceNN" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Crossvar NE: </b>  <xsl:apply-templates select="witsml:varianceNE" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Crossvar NV: </b>  <xsl:apply-templates select="witsml:varianceNVert" mode="valueWithUomRef"/></font></td>	</tr>
				<tr><td colspan="3" align="right"><font size="-1"><b></b></font></td>
					<td colspan="2"><font size="-1"><b>Cov EE: </b>  <xsl:apply-templates select="witsml:varianceEE" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Crossvar EV: </b>  <xsl:apply-templates select="witsml:varianceEVert" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Cov VV: </b>  <xsl:apply-templates select="witsml:varianceVertVert" mode="valueWithUomRef"/></font></td>	</tr>
				<tr><td colspan="3" align="right"><font size="-1"><b>Bias: </b></font></td>
					<td colspan="2"><font size="-1"><b>North: </b>  <xsl:apply-templates select="witsml:biasN" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>East: </b>  <xsl:apply-templates select="witsml:biasE" mode="valueWithUomRef"/></font></td>
					<td colspan="2"><font size="-1"><b>Vertical: </b>  <xsl:apply-templates select="witsml:biasVert" mode="valueWithUomRef"/></font></td></tr>
	</xsl:template>	

<!--					Location Template		-->
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

	
	<!--				Common Data Template		-->
	<xsl:template match="witsml:commonData">					
				<tr><td colspan="3"><font size="-1"><b>User ID: </b>  <xsl:value-of select="witsml:nameSource"/></font></td>
					<td colspan="3"><font size="-1"><b>Time Stamp: </b>  <xsl:value-of select="witsml:dTimStamp"/></font></td>
					<td colspan="3"><font size="-1"><b>State: </b> <xsl:value-of select="witsml:itemState"/></font></td></tr>
				<tr><td colspan="9"><font size="-1"><b>Comments: </b>  <xsl:value-of select="witsml:comments"/></font></td></tr>
	</xsl:template>		
	

</xsl:stylesheet>
