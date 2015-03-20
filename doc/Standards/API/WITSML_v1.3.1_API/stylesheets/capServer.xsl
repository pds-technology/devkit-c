<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:witsml="http://www.witsml.org/api/131">
<xsl:output method="html" />
<xsl:template match="/">
	<html>
	<head>
		<title>
			WITSML Server Capabilities Object
		</title>
	</head>

	<body>
	<table  border="2" align="center">
	<xsl:for-each select="witsml:capServers/witsml:capServer">
		<tr>
			<th colspan="6" >
				<font size="+2" color="blue">
					WITSML Server Capabilities Object
				</font>
			</th>
		</tr>
		<tr>
			<td><B>Contact Name: </B></td>
			<td><xsl:value-of select="witsml:contact/witsml:name"/></td>
		</tr>
		<tr>
			<td><B>Contact Email: </B></td>
			<td><xsl:value-of select="witsml:contact/witsml:email"/></td>
		</tr>
		<tr>
			<td><B>Contact Phone: </B></td>
			<td><xsl:value-of select="witsml:contact/witsml:phone"/></td>
		</tr>
		<tr>
			<td><B>Description: </B></td>
			<td><xsl:value-of select="witsml:description"/></td>
		</tr>
		<tr>
			<td><B>Name: </B></td>
			<td><xsl:value-of select="witsml:name"/></td>
		</tr>
		<tr>
			<td><B>Vendor: </B></td>
			<td><xsl:value-of select="witsml:vendor"/></td>
		</tr>
		<tr>
			<td><B>Version: </B></td>
			<td><xsl:value-of select="witsml:version"/></td>
		</tr>
		<tr>
			<td><B>Schema Version: </B></td>
			<td><xsl:value-of select="witsml:schemaVersion"/></td>
		</tr>
		<tr>
			<td><B>API Version: </B></td>
			<td><xsl:value-of select="@apiVers"/></td>
		</tr>
		<xsl:for-each select="witsml:function">
			<tr>
				<td>
					<B>Function Name: </B>
					<xsl:value-of select="@name"/>
				</td>
			</tr>
			<xsl:for-each select="witsml:dataObject">
				<tr>
					<td></td>
					<td>
						<B>Data Object: </B>
						<xsl:value-of select="."/>
					</td>
				</tr>
			</xsl:for-each>
		</xsl:for-each>
	</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>


</xsl:stylesheet>
