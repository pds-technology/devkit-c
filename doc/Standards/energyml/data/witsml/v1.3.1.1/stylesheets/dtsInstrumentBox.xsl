<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131" 
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

	<xsl:include href="all_object_utility_templates.xsl"/>

    <xsl:template match="/">
        <html>
            <head>
			<title>DTS Instrument Box Object</title>
		</head>
            <body>
                <span style="font-size:larger; font-weight:bold; ">DTS Instrument Box</span>
		<xsl:apply-templates select="witsml:dtsInstrumentBox"/>
            </body>
        </html>
    </xsl:template>

<xsl:template match="witsml:dtsInstrumentBox">
        <table border="1" width="100%">
		<thead>
<tr>
	<td><B>element or attribute</B></td>
	<td><B>value</B></td>
</tr>
		</thead>
            <tbody>
<tr>
   <td>uid</td>
   <td>
      <xsl:value-of select="@uid"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>name</td>
   <td>
      <xsl:value-of select="witsml:name"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>manufacturer</td>
   <td>
      <xsl:value-of select="witsml:manufacturer"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>manufacturingDate</td>
   <td>
      <xsl:value-of select="witsml:manufacturingDate"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>type</td>
   <td>
      <xsl:value-of select="witsml:type"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>name tag</td>
   <td>
      <xsl:value-of select="witsml:nameTag/witsml:numberingScheme"></xsl:value-of>=<xsl:value-of select="witsml:nameTag/witsml:name"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>softwareVersion</td>
   <td>
      <xsl:value-of select="witsml:softwareVersion"></xsl:value-of>
   </td>
</tr>

<xsl:for-each select="witsml:factoryCalibration">
<!--EMBED vertical OR horizontal table-->
<tr>
   <td colspan="2">factoryCalibration</td>
</tr>
<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <!--VERTICAL embedding area-->
         <tbody>
            <!--INSERT vertical table here-->
<tr>
   <td>uid</td>
   <td>
      <xsl:value-of select="@uid"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>dTimCalibration</td>
   <td>
      <xsl:value-of select="witsml:dTimCalibration"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>calibratedBy</td>
   <td>
      <xsl:value-of select="witsml:calibratedBy"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>calibrationProtocol</td>
   <td>
      <xsl:value-of select="witsml:calibrationProtocol"></xsl:value-of>
   </td>
</tr>
<!--EMBED vertical OR horizontal table-->
<tr>
   <td colspan="2">parameter</td>
</tr>
<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <!--HORIZONTAL embedding area-->
         <thead>
            <!--INSERT Horizontal table header here-->
      <tr>
         <td>name</td>
         <td>description</td>
         <td>value</td>
      </tr>
         </thead>
         <tbody>
            <xsl:for-each select="witsml:parameter">
               <!--INSERT Horizontal table row here-->
         <tr>
            <td> 
               <xsl:value-of select="@name"></xsl:value-of>
            </td>
            <td> 
               <xsl:value-of select="@description"></xsl:value-of>
            </td>
            <td> 
               <xsl:apply-templates select="." mode="valueWithUomRef"/>
            </td>
         </tr>
            </xsl:for-each>
        </tbody>
      </table>
    </td>
</tr>
<!--Horizontal embedding area-->
<tr>
   <td>remarks</td>
   <td>
      <xsl:value-of select="witsml:remarks"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>offsetTemperatureCalibration</td>
   <td>
      <xsl:apply-templates select="witsml:offsetTemperatureCalibration" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>slopeCalibration</td>
   <td>
      <xsl:apply-templates select="witsml:slopeCalibration" mode="valueWithUomRef"/>
   </td>
</tr>
         </tbody>
         <!--END VERTICAL embedding area-->
      </table>
   </td>
</tr>
</xsl:for-each>
<!--Horizontal embedding area-->
<tr>
   <td>internalOvenLocationNear</td>
   <td>
      <xsl:apply-templates select="witsml:internalOvenLocationNear" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>internalOvenLocationFar</td>
   <td>
      <xsl:apply-templates select="witsml:internalOvenLocationFar" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>ovenSetPoint</td>
   <td>
      <xsl:apply-templates select="witsml:ovenSetPoint" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>testCable</td>
   <td>
      <xsl:value-of select="witsml:testCable"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>offset</td>
   <td>
      <xsl:value-of select="witsml:offset"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>differentialLossSetting</td>
   <td>
      <xsl:apply-templates select="witsml:differentialLossSetting" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td colspan="2">parameter</td>
</tr>
<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <!--HORIZONTAL embedding area-->
         <thead>
            <!--INSERT Horizontal table header here-->
      <tr>
         <td>index</td>
         <td>name</td>
         <td>description</td>
         <td>value</td>
      </tr>
         </thead>
         <tbody>
            <xsl:for-each select="witsml:parameter">
               <!--INSERT Horizontal table row here-->
         <tr>
            <td> 
               <xsl:value-of select="@index"></xsl:value-of>
            </td>
            <td> 
               <xsl:value-of select="@name"></xsl:value-of>
            </td>
            <td> 
               <xsl:value-of select="@description"></xsl:value-of>
            </td>
            <td> 
               <xsl:apply-templates select="." mode="valueWithUomRef"/>
            </td>
         </tr>
            </xsl:for-each>
        </tbody>
      </table>
    </td>
</tr>

            </tbody>
        </table>
</xsl:template>

</xsl:stylesheet>
