<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:witsml="http://www.witsml.org/schemas/131" 
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    <xsl:template match="/">
        <html>
            <head />
            <body>
                <span style="font-size:larger; font-weight:bold; ">DTS Measurement</span>
                <p>Context information</p>
                    <xsl:for-each select="witsml:WITSMLComposite/witsml:wellSet/witsml:well">
                        <xsl:apply-templates select="."/>
                    </xsl:for-each>
                <p>Measurement infomation</p>
                    <xsl:for-each select="witsml:WITSMLComposite/witsml:wellSet/witsml:well/witsml:wellboreSet/witsml:wellbore/witsml:dtsMeasurementSet/witsml:dtsMeasurement">
                        <xsl:apply-templates select="."/>
                    </xsl:for-each>
                <p>DTS Data (as a well log)</p>
                    <xsl:for-each select="witsml:WITSMLComposite/witsml:wellSet/witsml:well/witsml:wellboreSet/witsml:wellbore/witsml:wellLogSet/witsml:wellLog">
                        <xsl:apply-templates select="."/>
                    </xsl:for-each>
            </body>
        </html>
    </xsl:template>

    <xsl:template match="witsml:well">
        <table border="1" width="100%">
            <tbody>
                <tr>
                    <td>Well</td>
                    <td>&#160;</td>
                    <td>&#160;</td>
                </tr>
                <tr>
                    <td>&#160;</td>
                    <td>uid</td>
                    <td>
                        <xsl:value-of select="@uid" />
                    </td>
                </tr>
                <tr>
                    <td>&#160;</td>
                    <td>name</td>
                    <td>
                        <xsl:value-of select="witsml:name"/>
                    </td>
                </tr>
                <xsl:for-each select="./witsml:wellboreSet/witsml:wellbore">
                    <xsl:apply-templates select="."/>
                </xsl:for-each>
            </tbody>
        </table>
    </xsl:template>

    <xsl:template match="witsml:wellbore">
            <tr>
                <td>Wellbore</td>
                <td>contained in well</td>
                <td><xsl:value-of select="../../witsml:name"/></td>
            </tr>
            <tr>
                <td>&#160;</td>
                <td>uid</td>
                <td>
                    <xsl:value-of select="@uid" />
                </td>
            </tr>
            <tr>
                <td>&#160;</td>
                <td>name</td>
                <td>
                    <xsl:value-of select="witsml:name"/>
                </td>
            </tr>
            <xsl:apply-templates select="./witsml:dtsInstalledSystemSet/witsml:dtsInstalledSystem"/>
    </xsl:template>

    <xsl:template match="witsml:dtsInstalledSystem">
            <tr>
                <td>DTS Installation</td>
                <td>installed in wellbore</td>
                <td><xsl:value-of select="../../witsml:name"/></td>
            </tr>
            <tr>
                <td>&#160; </td>
                <td>uid</td>
                <td>
                    <xsl:value-of select="@uid"/>
                </td>
            </tr>
            <tr>
                <td>&#160;</td>
                <td>name</td>
                <td>
                    <xsl:value-of select="witsml:name"/>
                </td>
            </tr>
    </xsl:template>

    <xsl:template match="witsml:dtsMeasurement">
                <br /><b>DTS Measurement Set</b>
                <table border="1" width="100%">
                    <tbody>
                        <tr>
                            <td>uid</td>
                            <td colspan="2">
                                <xsl:value-of select="@uid" />
                            </td>
                        </tr>
                        <tr>
                            <td>name</td>
                            <td colspan="2">
                                <xsl:value-of select="witsml:name"/>
                            </td>
                        </tr>
                        <tr>
                            <td>installed system used</td>
                            <td>&#160;</td>
                            <td><xsl:value-of select="witsml:installedSystemUsed"/>&#160;</td>
                        </tr>
        <xsl:if test="witsml:installedSystemUsed/@uidRef">
                        <tr>
                            <td>&#160;</td>
                            <td>reference uid</td>
                            <td>
                                <xsl:value-of select="witsml:installedSystemUsed/@uidRef"/>
                            </td>
                        </tr>
        </xsl:if>
                        <tr>
                            <td>data in well log</td>
                            <td>&#160;</td>
                            <td><xsl:value-of select="witsml:dataInWellLog"/>&#160;</td>
                        </tr>
        <xsl:if test="witsml:dataInWellLog/@uidRef">
                        <tr>
                            <td>&#160;</td>
                            <td>reference uid</td>
                            <td>
                                <xsl:value-of select="witsml:dataInWellLog/@uidRef"/>
                            </td>
                        </tr>
        </xsl:if>
                        <tr>
                            <td>fiber end connected</td>
                            <td colspan="2">
                                <xsl:value-of select="witsml:fiberEndConncected"/>&#160;
                            </td>
                        </tr>
                      <tr>
                            <td>fiber zero point</td>
                            <td colspan="2">
                                <xsl:value-of select="witsml:fiberZeroPoint"/>&#160;
                            </td>
                        </tr>
                    </tbody>
                </table>
    </xsl:template>

    <xsl:template match="witsml:wellLog">
                <br /><b>DTS Data</b>

                <table border="1" border-collapse="separate" frame="box" rules="all" table-layout="fixed" width="100%">
                    <tbody>
                        <tr>
                            <td>well log uid</td>
                            <td>
                                <xsl:value-of select="@uid" />
                            </td>
                        </tr>
                        <tr>
                            <td>well log name</td>
                            <td>
                                <xsl:value-of select="witsml:name"/>
                            </td>
                        </tr>
                        <xsl:call-template name="logHeader"/>
                        <xsl:apply-templates select="witsml:logData"/>
                    </tbody>
               </table>
    </xsl:template>

    <xsl:template name="logHeader">
                        <tr>
                            <td>objectGrowing</td>
                            <td>
                                <xsl:choose>
                                    <xsl:when test="witsml:objectGrowing">
                                        <xsl:value-of select="witsml:objectGrowing"/>
                                    </xsl:when>
                                    <xsl:otherwise>
                                        False
                                    </xsl:otherwise>
                                </xsl:choose>
                             </td>
                        </tr>
                        <tr>
                             <td>serviceCompany</td>
                             <td><xsl:value-of select="witsml:serviceCompany"/>
                             </td>
                        </tr>
                        <tr>
                             <td>runNumber</td>
                             <td><xsl:value-of select="witsml:runNumber"/></td>
                        </tr>
                        <tr>
                             <td>creationDate</td>
                             <td><xsl:value-of select="witsml:creationDate"/></td>
                        </tr>
                        <tr>
                             <td>description</td>
                             <td><xsl:value-of select="witsml:description"/></td>
                        </tr>
                        <tr>
                             <td>indexType</td>
                             <td><xsl:value-of select="witsml:indexType"/></td>
                        </tr>
                        <tr>
                             <td>minIndex</td>
                             <td><xsl:value-of select="witsml:minIndex"/></td>
                        </tr>
                        <tr>
                             <td>maxIndex</td>
                             <td><xsl:value-of select="witsml:maxIndex"/></td>
                        </tr>
                        <tr>
                             <td>indexUnits</td>
                             <td><xsl:value-of select="witsml:indexUnits"/></td>
                        </tr>
                        <tr>
                             <td>minDateTimeIndex</td>
                             <td><xsl:value-of select="witsml:minDateTimeIndex"/></td>
                        </tr>
                        <tr>
                             <td>maxDateTimeIndex</td>
                             <td><xsl:value-of select="witsml:maxDateTimeIndex"/></td>
                        </tr>
                        <tr>
                             <td>nullValue</td>
                             <td><xsl:value-of select="witsml:nullValue"/></td>
                        </tr>
                        <tr>
                            <td colspan="2"><b>Log Parameters:</b></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <table border="1" width="90%" align="right">
                                     <thead>
                                          <tr>
                                               <td>name</td>
                                               <td>index</td>
                                               <td>value</td>
                                               <td>uom</td>
                                               <td>description</td>
                                           </tr>
                                     </thead>
                                     <tbody>
                                     <xsl:for-each select="witsml:logParam">
                                           <tr>
                                               <td>&#160;<xsl:value-of select="@name"/></td>
                                               <td>&#160;<xsl:value-of select="@index"/></td>
                                               <td>&#160;<xsl:value-of select="."/></td>
                                               <td>&#160;<xsl:value-of select="@uom"/></td>
                                               <td>&#160;<xsl:value-of select="@description"/></td>
                                           </tr>
                                     </xsl:for-each>
                                     </tbody>
                                </table>
                             </td>
                        </tr>

                        <tr>
                            <td colspan="2"><b>Log Curve Information:</b></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <table border="1" width="90%" align="right">
                                     <thead>
                                          <tr>
                                               <td>curve uid</td>
                                               <td>mnemonic</td>
                                               <td>classWitsml</td>
                                               <td>unit</td>
                                               <td>nullValue</td>
                                               <td>curveDescription</td>
                                           </tr>
                                     </thead>
                                     <tbody>
                                     <xsl:for-each select="witsml:logCurveInfo">
                                           <tr>
                                               <td>&#160;<xsl:value-of select="@uid"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:mnemonic"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:classWitsml"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:unit"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:nullValue"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:curveDescription"/></td>
                                           </tr>
                                     </xsl:for-each>
                                     </tbody>
                                </table>
                             </td>
                        </tr>
                        <tr>
                            <td colspan="2"><b>Block Information:</b></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <table border="1" width="90%" align="right">
                                     <thead>
                                          <tr>
                                               <td>block uid</td>
                                               <td>indexType</td>
                                               <td>startIndex</td>
                                               <td>endIndex</td>
                                               <td>stepIncrement</td>
                                               <td>indexUnits</td>
                                               <td>indexCurve</td>
                                               <td>nullValue</td>
                                               <td>columnIndex</td>
                                           </tr>
                                     </thead>
                                     <tbody>
                                     <xsl:for-each select="witsml:blockInfo">
                                           <tr>
                                               <td>&#160;<xsl:value-of select="@uid"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:indexType"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:startIndex"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:endIndex"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:stepIncrement"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:indexUnits"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:indexCurve"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:nullValue"/></td>
                                               <td>&#160;<xsl:value-of select="./witsml:columnIndex"/></td>
                                           </tr>
                                           <tr>
                                             <td colspan="9"><b>Block curves information.</b></td>
                                           </tr>
                                           <xsl:for-each select="./witsml:blockCurveInfo">
                                                 <tr>
                                                   <td colspan="1">...</td>
                                                   <td colspan="2">&#160;columnIndex</td>
								   <td colspan="1"><xsl:value-of select="witsml:columnIndex"/></td>
                                                   <td colspan="3">&#160;curveId</td>
                                                   <td colspan="2">&#160;<xsl:value-of select="witsml:curveId"/></td>
                                                 </tr>
                                           </xsl:for-each>
                                     </xsl:for-each>
                                    </tbody>
                                </table>
                             </td>
                        </tr>
     </xsl:template>

     <xsl:template match="witsml:logData">

                        <tr>
                            <td colspan="2"><b>Log Data:</b></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <table border="1" width="90%" align="right">
                                     <thead>
                                          <tr>
                                               <td>List of Values</td>
                                           </tr>
                                     </thead>
                                     <tbody>
                                     <xsl:for-each select="witsml:data">
                                           <tr>
                                               <td>&#160;<xsl:value-of select="."/></td>
                                           </tr>
                                     </xsl:for-each>
                                     </tbody>
                                </table>
                             </td>
                        </tr>
    </xsl:template>

</xsl:stylesheet>
