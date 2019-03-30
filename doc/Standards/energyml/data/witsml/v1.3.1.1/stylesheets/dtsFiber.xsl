<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131" 
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

	<xsl:include href="all_object_utility_templates.xsl"/>  

    <xsl:template match="/">
        <html>
            <head>
                <title>DTS Fiber Object</title>
                <link rel='stylesheet' href='../stylesheets/witsml.css' type='text/css' />
	    </head>
            <body>
                <span style="font-size:larger; font-weight:bold; ">DTS Fiber</span>
		<xsl:apply-templates select="witsml:dtsFiber"/>
            </body>
        </html>
    </xsl:template>

    <xsl:template match="witsml:dtsFiber">
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
   <td>mode</td>
   <td>
      <xsl:value-of select="witsml:mode"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>type</td>
   <td>
      <xsl:value-of select="witsml:type"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>coating</td>
   <td>
      <xsl:value-of select="witsml:coating"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>jacket</td>
   <td>
      <xsl:value-of select="witsml:jacket"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>coreDiameter</td>
   <td>
      <xsl:apply-templates select="witsml:coreDiameter" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>outsideDiameter</td>
   <td>
      <xsl:apply-templates select="witsml:outsideDiameter" mode="valueWithUomRef"/>
   </td>
</tr>
<!--EMBED vertical OR horizontal table-->
<tr>
   <td colspan="2">refractiveIndex</td>
</tr>
<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <!--HORIZONTAL embedding area-->
         <thead>
      <!--BEGIN Table Header-->
      <tr>
         <td>uid</td>
         <td>value</td>
         <td>frequency</td>
         <td>wavelength</td>
      </tr>
      <!--END Table Header-->
         </thead>
         <tbody>
            <xsl:for-each select="witsml:refractiveIndex">
               <!--INSERT Horizontal table row here-->
         <tr>
            <td> 
               <xsl:value-of select="@uid"></xsl:value-of>
            </td>
            <td> 
               <xsl:value-of select="witsml:value"></xsl:value-of>
            </td>
            <td> 
               <xsl:apply-templates select="witsml:frequency" mode="valueWithUomRef"/>
            </td>
            <td> 
               <xsl:apply-templates select="witsml:wavelength" mode="valueWithUomRef"/>
            </td>
         </tr>
            </xsl:for-each>
         </tbody>
      </table>
   </td>
</tr>
<!--Horizontal embedding area-->
<!--EMBED vertical OR horizontal table-->
<tr>
   <td colspan="2">oneWayLoss</td>
</tr>
<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <!--HORIZONTAL embedding area-->
         <thead>
            <!--INSERT Horizontal table header here-->
      <tr>
         <td>uid</td>
         <td>value</td>
         <td>frequency</td>
         <td>wavelength</td>
      </tr>
         </thead>
         <tbody>
            <xsl:for-each select="witsml:oneWayLoss">
               <!--INSERT Horizontal table row here-->
         <tr>
            <td> 
               <xsl:value-of select="@uid"></xsl:value-of>
            </td>
            <td> 
               <xsl:apply-templates select="witsml:value" mode="valueWithUomRef"/>
            </td>
            <td> 
               <xsl:apply-templates select="witsml:frequency" mode="valueWithUomRef"/>
            </td>
            <td> 
               <xsl:apply-templates select="witsml:wavelength" mode="valueWithUomRef"/>
            </td>
         </tr>
            </xsl:for-each>
         </tbody>
         <!--END HORIZONTAL embedding area-->
      </table>
   </td>
</tr>
<!--Horizontal embedding area-->
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
<tr>
   <td>spoolNumberTag</td>
   <td>
      <xsl:value-of select="witsml:spoolNumberTag"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>spoolLength</td>
   <td>
      <xsl:apply-templates select="witsml:spoolLength" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>supplyDate</td>
   <td>
      <xsl:value-of select="witsml:supplyDate"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>supplier</td>
   <td>
      <xsl:value-of select="witsml:supplier"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>supplierModelNumber</td>
   <td>
      <xsl:value-of select="witsml:supplierModelNumber"></xsl:value-of>
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
         </tbody>
         <!--END VERTICAL embedding area-->
      </table>
   </td>
</tr>
</xsl:for-each>
<!--Horizontal embedding area-->
<tr>
   <td>installationHistory</td>
   <td>
      <xsl:value-of select="witsml:installationHistory"></xsl:value-of>
   </td>
</tr>
		</tbody>
	</table>
</xsl:template>

</xsl:stylesheet>
