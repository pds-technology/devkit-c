<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:witsml="http://www.witsml.org/schemas/131">


<xsl:template match="/">

  <html>
    <head>
      <title>WITSML Dynamic Enumeration List for version <xsl:value-of select="/witsml:enumListSet/@version"/>
      </title>
    </head>

    <body bgcolor="#DDE8FF">
      <H1>WITSML Dynamic Enumeration List</H1>
      <H2>Version <xsl:value-of select="/witsml:enumListSet/@version"/></H2>

      <xsl:apply-templates select="/witsml:enumListSet" mode="outline"/>

      <xsl:for-each select="/witsml:enumListSet/witsml:enumList">
        <xsl:apply-templates select="."/>
      </xsl:for-each>

    </body>
  </html>
</xsl:template>


<xsl:template match="/witsml:enumListSet" mode="outline">
  <HR/>
  <H2>Table of Contents</H2>
    <xsl:for-each select="/witsml:enumListSet/witsml:enumList">
        <H3><a href="#{witsml:name}"><xsl:value-of select="witsml:name"/></a></H3>
    </xsl:for-each>

</xsl:template>

<xsl:template match="/witsml:enumListSet/witsml:enumList">
  <HR/>
  <H2><a name="{witsml:name}"><xsl:value-of select="witsml:name"/></a></H2>
  <P> 
    <xsl:if test="witsml:namingSystem">
      From Naming System 
        <B><xsl:value-of select="witsml:namingSystem"/></B>.
    </xsl:if>
    <xsl:if test="witsml:description"> 
      <BR/><xsl:value-of select="witsml:description"/>
    </xsl:if>
  </P>
 
  <TABLE border="1" cellpadding="2" cellspacing="0">
    <TR>
      <TH>Name</TH>
      <TH>Description</TH>
      <TH>Status</TH>
    </TR>
    <xsl:for-each select="witsml:value">
      <xsl:apply-templates select="."/>
    </xsl:for-each>
  </TABLE>
  <P><SMALL>Value List Copyright POSC 2005. All rights reserved.</SMALL></P>

</xsl:template>

<xsl:template match="witsml:value">
  <TR>
    <TD><a name="{../witsml:name}::{witsml:name}"><xsl:value-of select="witsml:name"/></a></TD>
    <TD>
      <xsl:choose>
        <xsl:when test="witsml:description!=''">
          <xsl:value-of select="witsml:description"/>
        </xsl:when>
        <xsl:otherwise><BR/></xsl:otherwise>
      </xsl:choose>
    </TD>
    <TD>
      <xsl:choose>
        <xsl:when test="witsml:deprecated">deprecated</xsl:when>
        <xsl:otherwise>current</xsl:otherwise>
      </xsl:choose>
    </TD>
  </TR>
</xsl:template>

</xsl:stylesheet>
