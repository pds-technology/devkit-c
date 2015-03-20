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
			WITSML Subscription  Object
		</title>
	</head>

	<body>
	<table  border="2" align="center">
	<xsl:for-each select="witsml:subscriptions/witsml:subscription">
		<tr>
			<th colspan="6" >
				<font size="+2" color="blue">
					WITSML Subscription Object
				</font>
			</th>
		</tr>
		<tr>
			<td><B>Host: </B></td>
			<td><xsl:value-of select="@host"/></td>
		</tr>
		<tr>
			<td><B>Process: </B></td>
			<td><xsl:value-of select="@process"/></td>
		</tr>
		<tr>
			<td><B>Encrypt: </B></td>
			<td><xsl:value-of select="@encrypt"/></td>
		</tr>
		<tr>
			<td><B>Port: </B></td>
			<td><xsl:value-of select="@port"/></td>
		</tr>
		<tr>
			<td><B>Retry: </B></td>
			<td><xsl:value-of select="@retry"/></td>
		</tr>
		<tr>
			<td><B>Publisher ID: </B></td>
			<td><xsl:value-of select="@idPub"/></td>
		</tr>
		<tr>
			<td><B>Subscription ID: </B></td>
			<td><xsl:value-of select="@idSub"/></td>
		</tr>
		<tr>
			<td><B>Return Code: </B></td>
			<td><xsl:value-of select="@retCode"/></td>
		</tr>
		<tr>
			<td><B>Action: </B></td>
			<td><xsl:value-of select="@action"/></td>
		</tr>
		<tr>
			<td><B>Test?: </B></td>
			<td><xsl:value-of select="@test"/></td>
		</tr>
		<tr>
			<td><B>Update Interval: </B></td>
			<td><xsl:value-of select="@updateInterval"/></td>
		</tr>
		<tr>
			<td colspan="2">[To see the details of what is being subscribed to, 
			    see this file without a stylesheet.]</td>
			<td></td>
		</tr>
	</xsl:for-each>
	</table>
	</body>
	</html>
	</xsl:template>



</xsl:stylesheet>
