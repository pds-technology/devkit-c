<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"  
	xmlns:witsml="http://www.witsml.org/schemas/1series">

	<xsl:output method="html" />

	<!-- Unit of Measure Element linked to the unit file. -->
	<xsl:template match="*" mode="UnitRef">
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="string" select="."/>
			<xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
		</xsl:call-template>
	</xsl:template>		


	<!-- Uom attribute linked to the unit file. -->
	<xsl:template match="*" mode="UomRef">
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="string" select="@uom"/>
			<xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
		</xsl:call-template>
	</xsl:template>


	<!--  Measure value with a unit of measure linked to the unit file. -->
	<xsl:template match="*" mode="valueWithUomRef">
		<xsl:value-of select="."/>
		<xsl:text> </xsl:text>
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="path" select="'../ancillary/witsmlUnitDict.html'"/>
		</xsl:call-template>
		<!-- In case this is a coordinate, check for datum. -->
		<xsl:if test="@datum">
			<xsl:text> </xsl:text>
			(<xsl:value-of select="@datum"/>)
		</xsl:if>
	</xsl:template>


	<!-- Template to create a name anchor or to create an href to a uom in the WITSML unit file. -->
	<!-- Add an underscore in front of Uppercase characters in the string. -->
	<!-- Also substitute T (times) and P (per) for period (.) and slash (/). -->
	<xsl:template name="uomRefString">
		<xsl:param name="string" select="@uom"/>    <!-- The uom string. -->
		<xsl:param name="index"  select="1"/>       <!-- The start index in the string. -->
		<xsl:param name="mode"   select="'href'"/>  <!-- 'href' or 'name'. -->
		<xsl:param name="path"   select="''"/>      <!-- Path to the unit file. Only relevant to 'href'. -->
		<xsl:choose>
			<xsl:when test="not($string)">
			<!-- For whatever reason, this value does not have a uom. -->
			<!-- It may be a unitless quantity or an indexed parameter with an optional uom. -->
			</xsl:when>
			<xsl:when test="$index > string-length($string)">
				-------- This is a bad call ----------
				string='<xsl:value-of select="$string"/>'
				index='<xsl:value-of select="$index"/>'
				mode='<xsl:value-of select="$mode"/>'
				path='<xsl:value-of select="$path"/>'
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template name="_nextChar">
					<xsl:with-param name="string" select="$string"/>
					<xsl:with-param name="index" select="$index"/>
					<xsl:with-param name="mode" select="$mode"/>
					<xsl:with-param name="original" select="$string"/>
					<xsl:with-param name="path" select="$path"/>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<!--Template to examine the next character for an upper case letter. -->
	<xsl:template name="_nextChar">
		<xsl:param name="string"/>
		<xsl:param name="index"/>
		<xsl:param name="mode"/>
		<xsl:param name="original"/>
		<xsl:param name="path"/>
		<xsl:variable name="char"><xsl:value-of select="substring($string,$index,1)"/></xsl:variable>
		<xsl:variable name="len"><xsl:value-of select="string-length($string)"/></xsl:variable>
		<xsl:choose>
			<xsl:when test="not($string)"/>
			<xsl:when test="$index > $len">
				<!-- We are finished -->
				<xsl:if test="$mode = 'href'">
					<a href="{$path}#uom::{translate($string,'./','TP')}"><xsl:value-of select="$original"/></a>
				</xsl:if>
				<xsl:if test="$mode = 'name'">
					<a name="uom::{translate($string,'./','TP')}"/>
				</xsl:if>
			</xsl:when>
			<xsl:when test="contains('ABCDEFGHIJKLMNOPQRSTUVWXYZ',$char)">
				<xsl:call-template name="_insertChar">
					<xsl:with-param name="string" select="$string"/>
					<xsl:with-param name="index" select="$index"/>
					<xsl:with-param name="mode" select="$mode"/>
					<xsl:with-param name="original" select="$original"/>
					<xsl:with-param name="path" select="$path"/>
				</xsl:call-template>
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template name="_nextChar">
					<xsl:with-param name="string" select="$string"/>
					<xsl:with-param name="index" select="$index +1"/>
					<xsl:with-param name="mode" select="$mode"/>
					<xsl:with-param name="original" select="$original"/>
					<xsl:with-param name="path" select="$path"/>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:template>
	<!--Template to insert an underscore at the current index while calling _nextChar. -->
	<xsl:template name="_insertChar">
		<xsl:param name="string"/>
		<xsl:param name="index"/>
		<xsl:param name="mode"/>
		<xsl:param name="original"/>
		<xsl:param name="path"/>
		<xsl:variable name="len"><xsl:value-of select="string-length($string)"/></xsl:variable>
		<xsl:call-template name="_nextChar">
			<xsl:with-param name="string" select="concat(substring($string,1,$index - 1),'_',substring($string,$index,$len - $index +1))"/>
			<xsl:with-param name="index" select="$index +2"/>
			<xsl:with-param name="mode" select="$mode"/>
			<xsl:with-param name="original" select="$original"/>
			<xsl:with-param name="path" select="$path"/>
		</xsl:call-template>
	</xsl:template>

</xsl:stylesheet>
