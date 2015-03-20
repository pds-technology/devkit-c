<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet 
	version="2.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns="http://www.w3.org/1999/xhtml">

<xsl:include href="all_object_utility_templates.xsl"/>

<xsl:output  doctype-public="-//W3C//DTD HTML 4.01//EN"/>

<!-- 
  This script is designed to be used for the display of WITSML-style data-object XML-examples.
  For each element with simple content, the contents of the element 
    are listed after a colon (:) on the same line as the element name.
    The elements are bulleted a spart of an unordered list.
  For each element with complex content (contains other elements), it puts the contents within a table. 
    The result is nested tables to the depth of nesting within the XML file. 
    Each nesting level uses a different color but only four colors are used and then the sequence is repeated.
    For each table, the border width is defined by the depth of nesting.
    The tables are not bulleted.
    Each table can be expanded or collapsed by the viewer.
  Attributes are listed in parenthesis on the same line as the containing element.
    An attribute with the name of "uom" is presumed to represent a foreign key to file 
    "../ancillary/witsmlUnitDict.html" and a link is generated accordingly.

  Revision History
    Nov 2011 - Added expand/collapse logic for the contents of each table.
               Reveal the version attribute.
-->


<xsl:param name="namespace">http://www.w3.org/1999/xhtml</xsl:param>

<xsl:template match="/*">
  <html>
    <head>
      <style type="text/css">
          body, th,td, p, blockquote, 
          ol,ul,li,dl,dt,dd, h1,h2,h3,h4,h5,h6 { 
            font-family: Verdana, Arial, Helvetica, sans-serif; }
          body { margin: 2em 1em 2em 1em; 
                 color: #000085; background: white; }
      </style>
    <title><xsl:value-of select="name()"/></title></head>

	<!-- The /script> terminating tag MUST be used or MSIE will not work. -->
	<!-- The src path assumes that the script is being invoked in the parent folder. -->
    <script language="JavaScript" src="./stylesheets/expand-colllapse_java-script.js">
    </script>

    <body>
      <h1>
        <xsl:value-of select="name()"/>
        <xsl:apply-templates select="@version"/>
      </h1>
      <!-- Button for collapsing the content of ALL tables. -->
      <xsl:element name="input" namespace="{$namespace}">
        <xsl:attribute name="type">button</xsl:attribute>
        <xsl:attribute name="value">Collapse All</xsl:attribute>
        <xsl:attribute name="align">left</xsl:attribute>
        <xsl:attribute name="onclick">CollapseAll()</xsl:attribute>
        <xsl:attribute name="id">CollapseAll</xsl:attribute>
      </xsl:element>
      <!-- Button for expanding the content of ALL tables. -->
      <xsl:element name="input" namespace="{$namespace}">
        <xsl:attribute name="type">button</xsl:attribute>
        <xsl:attribute name="value">Expand All</xsl:attribute>
        <xsl:attribute name="align">left</xsl:attribute>
        <xsl:attribute name="onclick">ExpandAll()</xsl:attribute>
        <xsl:attribute name="id">ExpandAll</xsl:attribute>
      </xsl:element>
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
      <xsl:when test="$parentCount=12">green</xsl:when>
      <xsl:otherwise>black</xsl:otherwise>
    </xsl:choose>
  </xsl:variable>
  <xsl:choose>
    <xsl:when test="count(child::*)>0">
      <!-- ================================== -->
      <!-- For elements with element content. -->
      <xsl:variable name="tableID">
        <xsl:value-of select="count(ancestor::*)*100000 +count(preceding::*)"/>
      </xsl:variable>
      <xsl:element name="font" namespace="{$namespace}">
        <xsl:attribute name="color">
          <xsl:value-of select="$colorValue"/>
        </xsl:attribute>

        <xsl:element name="table" namespace="{$namespace}">
          <xsl:attribute name="border">
            <xsl:value-of select="$parentCount"/>
          </xsl:attribute>
          <tr>
            <th style="width:1%;" > <!-- MSIE 8 does not work well with @width=1. -->
      	      <!-- Button for expanding or collapsing the content of the table. -->
              <xsl:element name="input" namespace="{$namespace}">
                <xsl:attribute name="type">button</xsl:attribute>
                <xsl:attribute name="value">+</xsl:attribute>
                <xsl:attribute name="align">left</xsl:attribute>
                <xsl:attribute name="onclick">
                  <xsl:text>ExpandCollapse('</xsl:text>
                  <xsl:value-of select="$tableID"/>
                  <xsl:text>')</xsl:text>
                </xsl:attribute>
                <xsl:attribute name="id">
                  <xsl:text>btn-</xsl:text>
                  <xsl:value-of select="$tableID"/>
                </xsl:attribute>
              </xsl:element>
            </th>
            <th>
      	      <!-- The name of the element along with its attribute content. -->
                <xsl:value-of select="name()"/>
                <xsl:apply-templates select="@*"/>
            </th>
          </tr>
          <tr>
            <td colspan="2">
              <xsl:element name="table" namespace="{$namespace}">
                <xsl:attribute name="border">0</xsl:attribute>
                <xsl:attribute name="id">
                  <xsl:text>tbl-</xsl:text>
                  <xsl:value-of select="$tableID"/>
                </xsl:attribute>
               <tr>
                  <td>
                    <ul>
                      <xsl:apply-templates select="*"/>
                    </ul>
                  </td>
                </tr>
              </xsl:element>
            </td>
          </tr>
        </xsl:element>
      </xsl:element>
    </xsl:when>
    <xsl:otherwise>
      <!-- ================================== -->
      <!-- For elements with data content.    -->
      <li>
        <em>
          <xsl:value-of select="name()"/>
        </em>:
        <xsl:value-of select="."/> 
        <xsl:apply-templates select="@*"/>
      </li>
    </xsl:otherwise>
  </xsl:choose>
</xsl:template>

<xsl:template match="@*">
  <font size="-1">
    <xsl:text> (</xsl:text>
    <xsl:value-of select="name()"/>
    <xsl:text>=</xsl:text>
    <xsl:choose>
      <xsl:when test="name()='uom'">
          <xsl:call-template name="uomRefString">
            <xsl:with-param name="string" select="."/>
            <xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="."/>
      </xsl:otherwise>
    </xsl:choose>
    <xsl:text>)</xsl:text>
  </font>
</xsl:template>

</xsl:stylesheet>
