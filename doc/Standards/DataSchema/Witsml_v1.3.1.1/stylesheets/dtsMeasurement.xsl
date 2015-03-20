<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131" 
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

	<xsl:include href="all_object_utility_templates.xsl"/> 

    <xsl:template match="/">
        <html>
            <head>
			<title>dtsMeasurement Object</title>
		</head>
            <body>
                <span style="font-size:larger; font-weight:bold; ">DTS Measurement</span>
            <xsl:apply-templates select="//witsml:documentInfo"/>
		<xsl:for-each select="//witsml:dtsMeasurement">
                <xsl:apply-templates select="."/>
            </xsl:for-each>
            </body>
        </html>
    </xsl:template>

    <xsl:template match="witsml:documentInfo">
        <P><B>Created date: </B><xsl:value-of select="witsml:FileCreationInformation/witsml:FileCreationDate"/><BR/>
        <B>Created by: </B><xsl:value-of select="witsml:FileCreationInformation/witsml:FileCreator"/></P>
    </xsl:template>

    <xsl:template match="witsml:dtsMeasurement">
        <table border="1" width="100%">

		<thead>
<tr>
	<td><B>element or attribute</B></td>
	<td><B>value</B></td>
</tr>
		</thead>

            <tbody>
<tr>
   <td>uidWell</td>
   <td>
      <xsl:value-of select="@uidWell"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>uidWellbore</td>
   <td>
      <xsl:value-of select="@uidWellbore"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>uid</td>
   <td>
      <xsl:value-of select="@uid"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>nameWell</td>
   <td>
      <xsl:value-of select="witsml:nameWell"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>nameWellbore</td>
   <td>
      <xsl:value-of select="witsml:nameWellbore"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>name</td>
   <td>
      <xsl:value-of select="witsml:name"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>runDuration</td>
   <td>
      <xsl:apply-templates select="witsml:runDuration" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>installedSystemUsed</td>
   <table border="1"><tbody>
      <tr>
      <td>uidRef: <xsl:value-of select="witsml:installedSystemUsed/@uidRef"/></td>
      <td>name: <xsl:value-of select="witsml:installedSystemUsed"/></td>
      </tr>
   </tbody></table>
</tr>
<tr>
   <td>dataInWellLog</td>
   <table border="1"><tbody>
      <tr>
      <td>uidRef: <xsl:value-of select="witsml:dataInWellLog/@uidRef"/></td>
      <td>name: <xsl:value-of select="witsml:dataInWellLog"/></td>
      </tr>
   </tbody></table>
</tr>
<tr>
   <td>fiberEndConnected</td>
   <table border="1"><tbody>
      <tr>
      <td>uidRef: <xsl:value-of select="witsml:fiberEndConnected/@uidRef"/></td>
      <td>name: <xsl:value-of select="witsml:fiberEndConnected"/></td>
      </tr>
   </tbody></table>
</tr>
<tr>
   <td colspan="2">fiberDefinedPoint</td>
</tr>
<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <!--HORIZONTAL embedding area-->
         <thead>
            <!--INSERT Horizontal table header here-->
      <tr>
         <td>uid</td>
         <td>md</td>
         <td>lengthAlongFiber</td>
         <td>type</td>
      </tr>
         </thead>
         <tbody>
            <xsl:for-each select="witsml:fiberDefinedPoint">
               <!--INSERT Horizontal table row here-->
         <tr>
            <td> 
               <xsl:value-of select="@uid"></xsl:value-of>
            </td>
            <td> 
               <xsl:value-of select="witsml:md"></xsl:value-of>
            </td>
            <td> 
               <xsl:apply-templates select="witsml:lengthAlongFiber" mode="valueWithUomRef"/>
            </td>
            <td> 
               <xsl:value-of select="witsml:type"></xsl:value-of>
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
