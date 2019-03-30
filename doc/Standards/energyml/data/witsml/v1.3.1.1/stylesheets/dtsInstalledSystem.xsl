<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131" 
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

   <xsl:import href="dtsFiber.xsl"/>
   <xsl:import href="dtsInstrumentBox.xsl"/>

   <xsl:include href="all_object_utility_templates.xsl"/> 

    <xsl:template match="/">
        <html>
            <head>
			<title>DTS Installed System Object</title>
		</head>
            <body>
                <span style="font-size:larger; font-weight:bold; ">DTS Installed System</span>
            <xsl:apply-templates select="//witsml:documentInfo"/>
            <xsl:for-each select="//witsml:dtsInstalledSystem">
	           <xsl:apply-templates select="."/>
            </xsl:for-each>
            </body>
        </html>
    </xsl:template>

    <xsl:template match="witsml:documentInfo">
        <P><B>Document date: </B><xsl:value-of select="witsml:FileCreationInformation/witsml:FileCreationDate"/><BR/>
        <B>Created by: </B><xsl:value-of select="witsml:FileCreationInformation/witsml:FileCreator"/></P>
    </xsl:template>

    <xsl:template match="witsml:dtsInstalledSystem">
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
   <td>isPlanned</td>
   <td>
      <xsl:value-of select="witsml:isPlanned"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>fiberConfiguration</td>
   <td>
      <xsl:value-of select="witsml:fiberConfiguration"></xsl:value-of>
   </td>
</tr>

<tr>
   <td colspan="2">fiberEndPoint</td>
</tr>
<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <!--HORIZONTAL embedding area-->
         <thead>
            <!--INSERT Horizontal table header here-->
      <tr>
         <td>uid</td>   <!-- line 100  -->
         <td>name</td>
         <td>description</td>
      </tr>
         </thead>
         <tbody>
            <xsl:for-each select="witsml:fiberEndPoint">
               <!--INSERT Horizontal table row here-->
         <tr>
            <td> 
               <xsl:value-of select="@uid"></xsl:value-of>
            </td>
            <td> 
               <xsl:value-of select="witsml:name"></xsl:value-of>
            </td>
            <td> 
               <xsl:value-of select="witsml:description"></xsl:value-of>
            </td>
         </tr>
            </xsl:for-each>
         </tbody>
      </table>
   </td>
</tr>

<tr>
   <td>fiberLength</td>
   <td>
      <xsl:apply-templates select="witsml:fiberLength" mode="valueWithUomRef"/>
   </td>
</tr>

<tr>
   <td colspan="2">wellboreFiberSchematic</td>
</tr>

<tr>
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <tbody>
            <xsl:for-each select="witsml:wellboreFiberSchematic/witsml:installedPoint">
              <tr>
                <td>installedPoint</td>
              </tr>
              <tr><td>
              <table border="1" width="90%" align="right">
                 <thead>
                    <tr>
                       <td>md (<xsl:value-of select="witsml:md/@datum"/>)</td>
                       <td>lengthAlongFiber</td>
                       <td>type</td>
                    </tr>
                 </thead>
                 <tbody>
                    <tr>
                       <td>
                          <xsl:apply-templates select="witsml:md" mode="valueWithUomRef"/>
                       </td>
                       <td>
                          <xsl:apply-templates select="witsml:lengthAlongFiber" mode="valueWithUomRef"/>
                       </td>
                       <td>
                          <xsl:value-of select="witsml:type"/>
                       </td>
                    </tr>
                  </tbody>
              </table>
              </td></tr>
            </xsl:for-each>
         </tbody>
      </table>
   </td>
</tr>
<tr>
   <td>opticalBudget</td>
   <td>
      <xsl:apply-templates select="witsml:opticalBudget" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>basedOnInstalledFiber</td>
   <td><table border="1"><tbody>
      <tr>
      <td>uidRef: <xsl:value-of select="witsml:basedOnInstalledFiber/@uidRef"/></td>
      <td>name: <xsl:value-of select="witsml:basedOnInstalledFiber"/></td>
      </tr>
   </tbody></table></td>
</tr>

<tr>
   <td colspan="2"><B>Pump Activity</B></td>
</tr>
<tr>   <!--   Line 200 -->
   <td colspan="2">
      <table border="1" width="90%" align="right">
         <thead>
            <tr>
               <td><B>element</B></td>
               <td><B>Value</B></td>
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
      <xsl:value-of select="witsml:pumpActivity/witsml:name"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>installedFiber</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:installedFiber"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>pumpingDate</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:pumpingDate"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>engineerName</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:engineerName"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>serviceCompany</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:serviceCompany"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>pumpFluidType</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:pumpFluidType"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>controlLineFluid</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:controlLineFluid"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>pumpDirection</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:pumpDirection"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>fiberEndSeal</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:fiberEndSeal"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>cableMeterType</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:cableMeterType"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>cableMeterSerialNumber</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:cableMeterSerialNumber"></xsl:value-of>
   </td>
</tr>

<tr>
   <td>cableMeterCalibrationDate</td>
   <td>
      <xsl:value-of select="witsml:pumpActivity/witsml:cableMeterCalibrationDate"></xsl:value-of>
   </td>
</tr>
<tr>
   <xsl:choose>
      <xsl:when test="witsml:pumpActivity/witsml:wasDriftRunPerformed">
        <td>wasDriftRunPerformed</td>
        <td><xsl:value-of select="witsml:pumpActivity/witsml:wasDriftRunPerformed"/></td>
      </xsl:when>
      <xsl:when test="witsml:pumpActivity/witsml:OTDRPerformed">
        <td>OTDRPerformed</td>
        <td><table border="1"><tbody>
           <tr>
             <td>uidRef: <xsl:value-of select="witsml:pumpActivity/witsml:OTDRPerformed/@uidRef"/></td>
             <td>name: <xsl:value-of select="witsml:pumpActivity/witsml:OTDRPerformed"/></td>
           </tr>    <!--   Line 300 -->
        </tbody></table></td>
      </xsl:when>
      <xsl:otherwise>
         <td>wasDriftRunPerformed</td>
         <td>False</td>
      </xsl:otherwise>
   </xsl:choose>
</tr>

<tr>
   <td>excessFiberRecovered</td>
   <td>
      <xsl:apply-templates select="witsml:pumpActivity" mode="valueWithUomRef"/>
   </td>
</tr>

<tr>
   <td colspan="2">pumpLog</td>
</tr>
      <tr>
        <td colspan="2">
          <table border="1" width="90%" align="right">
             <xsl:for-each select="witsml:pumpActivity/witsml:pumpLog/witsml:tableRow">
               <tr>
                 <td>tableRow</td>
               </tr>
               <tr>
                 <td>
                   <table border="1" width="90%" align="right">
<tr>
   <td>uid</td>
   <td>
      <xsl:value-of select="@uid"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>cableSpeed</td>
   <td>
      <xsl:apply-templates select="witsml:cableSpeed" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>fiberPumpedLength</td>
   <td>
      <xsl:apply-templates select="witsml:fiberPumpedLength" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>pumpPressure</td>
   <td>
      <xsl:apply-templates select="witsml:pumpPressure" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>pumpFluid</td>
   <td>
      <xsl:value-of select="witsml:pumpFluid"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>temperatureIn</td>
   <td>
      <xsl:apply-templates select="witsml:temperatureIn" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>temperatureOut</td>
   <td>
      <xsl:apply-templates select="witsml:temperatureOut" mode="valueWithUomRef"/>
   </td>
</tr>
<tr>
   <td>remarks</td>
   <td>
      <xsl:value-of select="witsml:remarks"></xsl:value-of>
   </td>
</tr>

                   </table>
                 </td>
               </tr>
             </xsl:for-each>
          </table>
        </td>
      </tr>

  <xsl:for-each select="witsml:otdrInstallationTest">
    <tr>
      <td colspan="2">otdrInstallationTest</td>
    </tr>
    <tr>
       <td colspan="2">
         <table border="1" width="90%" align="right">
           <tbody>
<tr>
   <td>uid</td>
   <td>
      <xsl:value-of select="@uid"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>reasonForRun</td>
   <td>
      <xsl:value-of select="witsml:reasonForRun"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>dTimRun</td>
   <td>
      <xsl:value-of select="witsml:dTimRun"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>dataInWellLog</td>
   <td>
      <xsl:value-of select="witsml:dataInWellLog"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>fiberEndConncected</td>
   <td>
      <xsl:value-of select="witsml:fiberEndConncected"></xsl:value-of>
   </td>
</tr>
<tr>
   <td>comment</td>
   <td>
      <xsl:value-of select="witsml:comment"></xsl:value-of>
   </td>
</tr>

           </tbody>
         </table>
       </td>
    </tr>
  </xsl:for-each>

<tr>
   <td colspan="2"><B>Fiber</B></td>
</tr>
<tr>
   <td/>
   <td>
<xsl:apply-templates select="//witsml:fiber"/>
   </td>
</tr>
<tr>
   <td colspan="2"><B>Instrument Box</B></td>
</tr>
<tr>
   <td/>
   <td>
<xsl:apply-templates select="//witsml:instrumentBox"/>
   </td>
</tr>
		</tbody>
	</table>
  </td>
</tr>
    </tbody>
  </table>

    </xsl:template>


</xsl:stylesheet>
