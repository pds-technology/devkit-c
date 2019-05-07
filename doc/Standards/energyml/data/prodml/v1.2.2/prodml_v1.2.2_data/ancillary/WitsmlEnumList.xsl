<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:prodml="http://www.prodml.org/schemas/1series">


<xsl:template match="/">

  <html>
    <head>
      <title>WITSML Dynamic Enumeration List for version <xsl:value-of select="/prodml:enumListSet/@version"/>
      </title>
    </head>

    <body bgcolor="#DDE8FF">
      <H1>WITSML Dynamic Enumeration List</H1>
      <H2>Version <xsl:value-of select="/prodml:enumListSet/@version"/></H2>

      <xsl:apply-templates select="/prodml:enumListSet" mode="outline"/>

      <xsl:for-each select="/prodml:enumListSet/prodml:enumList">
        <xsl:apply-templates select="."/>
      </xsl:for-each>

    </body>
  </html>
</xsl:template>


<xsl:template match="/prodml:enumListSet" mode="outline">
  <HR/>
  <H2>Table of Contents</H2>
    <xsl:for-each select="/prodml:enumListSet/prodml:enumList">
        <H3><a href="#{prodml:name}"><xsl:value-of select="prodml:name"/></a></H3>
    </xsl:for-each>

</xsl:template>

<xsl:template match="/prodml:enumListSet/prodml:enumList">
  <HR/>
  <H2><a name="{prodml:name}"><xsl:value-of select="prodml:name"/></a></H2>
  <P> 
    <xsl:if test="prodml:namingSystem">
      From Naming System 
        <B><xsl:value-of select="prodml:namingSystem"/></B>.
    </xsl:if>
    <xsl:if test="prodml:description"> 
      <BR/><xsl:value-of select="prodml:description"/>
    </xsl:if>
  </P>
 
  <TABLE border="1" cellpadding="2" cellspacing="0">
    <TR>
      <TH>Name</TH>
      <TH>Description</TH>
      <TH>Status</TH>
    </TR>
    <xsl:for-each select="prodml:value">
      <xsl:apply-templates select="."/>
    </xsl:for-each>
  </TABLE>
  <P><SMALL>Value List Copyright POSC 2005. All rights reserved.</SMALL></P>

</xsl:template>

<xsl:template match="prodml:value">
  <TR>
    <TD><a name="{../prodml:name}::{prodml:name}"><xsl:value-of select="prodml:name"/></a></TD>
    <TD>
      <xsl:choose>
        <xsl:when test="prodml:description!=''">
          <xsl:value-of select="prodml:description"/>
        </xsl:when>
        <xsl:otherwise><BR/></xsl:otherwise>
      </xsl:choose>
    </TD>
    <TD>
      <xsl:choose>
        <xsl:when test="prodml:deprecated">deprecated</xsl:when>
        <xsl:otherwise>current</xsl:otherwise>
      </xsl:choose>
    </TD>
  </TR>
</xsl:template>

</xsl:stylesheet>
