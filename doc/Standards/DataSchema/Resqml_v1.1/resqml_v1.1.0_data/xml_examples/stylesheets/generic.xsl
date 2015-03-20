<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
		xmlns:witsml="http://www.resqml.org/schemas/1series">

	<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:template match="/*">
  <html>
    <head>
      <style type='text/css'>
          body, th,td, p, blockquote, 
          ol,ul,li,dl,dt,dd, h1,h2,h3,h4,h5,h6 { 
            font-family: Verdana, Arial, Helvetica, sans-serif; }
          body { margin: 2em 1em 2em 1em; 
                 color: #000085; background: white; }
      </style>
    <title><xsl:value-of select="name()"/></title></head>
    <body>
      <h1><xsl:value-of select="name()"/></h1>
      <table border="0">
        <xsl:apply-templates select="*"/>
      </table>
    </body>
  </html>
</xsl:template>

<xsl:template match="*">
  <xsl:variable name="parentCount">
    <xsl:value-of select="count(ancestor::*)"/>
  </xsl:variable>
  <xsl:variable name="colorValue">
    <xsl:choose>
    <xsl:when test="$parentCount=1">black</xsl:when>
    <xsl:when test="$parentCount=2">blue</xsl:when>
    <xsl:when test="$parentCount=3">red</xsl:when>
    <xsl:when test="$parentCount=4">green</xsl:when>
    <xsl:when test="$parentCount=5">black</xsl:when>
    <xsl:when test="$parentCount=6">blue</xsl:when>
    <xsl:when test="$parentCount=7">red</xsl:when>
    <xsl:when test="$parentCount=8">green</xsl:when>
    <xsl:when test="$parentCount=9">black</xsl:when>
    <xsl:when test="$parentCount=10">blue</xsl:when>
    <xsl:when test="$parentCount=11">red</xsl:when>
    <xsl:otherwise>green</xsl:otherwise>
  </xsl:choose>
  </xsl:variable>
  <xsl:choose>
    <xsl:when test="count(child::*)>0">
      <!-- For elements with element content. -->
      <xsl:element name="font">
        <xsl:attribute name="color">
          <xsl:value-of select='$colorValue'/>
        </xsl:attribute>
        <xsl:element name="table">
          <xsl:attribute name="border">
            <xsl:value-of select='$parentCount'/>
          </xsl:attribute>
          <tr>
            <th>
              <xsl:value-of select='name()'/>
              <xsl:apply-templates select="@*"/>
            </th>
          </tr>
          <tr>
            <td>
              <ul>
                <xsl:apply-templates select="*"/>
              </ul>
            </td>
          </tr>
        </xsl:element>
      </xsl:element>
    </xsl:when>
    <xsl:otherwise>
      <!-- For elements with data content. -->
      <li>
        <em>
          <xsl:value-of select='name()'/>
        </em>: 
        <xsl:value-of select='.'/>
        <xsl:apply-templates select="@*"/>
      </li>
    </xsl:otherwise>
  </xsl:choose>
</xsl:template>

<xsl:template match="@*">
  <font size='-1'>
    <xsl:text>(</xsl:text>
    <xsl:value-of select='name()'/>
    <xsl:text>=</xsl:text>
    <xsl:choose>
      <xsl:when test="name()='uom'">
          <xsl:call-template name="uomRefString">
            <xsl:with-param name="string" select="."/>
            <xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select='.'/>
      </xsl:otherwise>
    </xsl:choose>
    <xsl:text>)</xsl:text>
  </font>
</xsl:template>

</xsl:stylesheet>
