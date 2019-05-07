<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform" 
	xmlns:posc="http://www.posc.org/schemas">

<!-- View of the witsmlDict.xml unit of measure file -->

<!--	Original: John Shields
	24Feb04 Gary Masters: Add anchor name for derived units.
		Add conversion formula.
	24Mar04 Gary Masters: Convert to UnitOfMeasureDictionary V2 schema.
	3Mar05  Gary Masters: Remove ID because it is an internal concept.
		Move the annotation to a row.
		Generate caseless anchors and hrefs.
	31Oct06 Gary Masters: Flag deprecated units.
 -->

<xsl:output method="html" />

<xsl:template match="/">
	<html>
		<head>
			<xsl:comment>This file was generated from the ancillary/witsmlUnitDict.xml file using</xsl:comment>
			<xsl:comment>the stylesheets/Units.xsl file.</xsl:comment>
			<title>WITSML conversions dictionary stylesheet</title>
		</head>
		<body>
		<h1>WITSML conversions dictionary (viewed via stylesheet)</h1>
		<br/>
		<h1>Base Units</h1>
		<xsl:apply-templates select="posc:UnitOfMeasureDictionary/posc:UnitsDefinition/posc:UnitOfMeasure/posc:BaseUnit">
			<xsl:sort select="../posc:Name"/>
		</xsl:apply-templates>
		
		<h1>Derived units</h1>
		<xsl:apply-templates select="posc:UnitOfMeasureDictionary/posc:UnitsDefinition/posc:UnitOfMeasure/posc:ConversionToBaseUnit">
			<xsl:sort select="../posc:Name"/>
		</xsl:apply-templates>

		</body>
	</html>

</xsl:template>


<xsl:template match="posc:BaseUnit">
	<h2><xsl:apply-templates select="../posc:CatalogSymbol" mode="baseUnitName"/>
		<xsl:value-of select="../posc:Name" />
	</h2>
	<p align="center">
		<table border="1" cellpadding="0" cellspacing="0" width="98%" >
			<tr>
				<td width="15%"><strong>Annotation</strong></td>
				<td>
					<xsl:value-of select="../@annotation" />
				</td>
			</tr>
			<tr>
				<td width="15%"><strong>Description</strong></td>
				<td>
					<xsl:choose>
						<xsl:when test="posc:Description">
							<xsl:value-of select="posc:Description"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:text> </xsl:text>	
						</xsl:otherwise>
					</xsl:choose>
				</td>
			</tr>
			<tr>
				<td><strong>Origin</strong></td>
				<td><xsl:value-of select="../posc:CatalogName"/></td>
			</tr>
		</table>
	</p>
</xsl:template>


<xsl:template match="posc:ConversionToBaseUnit">
	<h2>
		<xsl:apply-templates select="../posc:CatalogSymbol" mode="baseUnitName"/>
		<xsl:value-of select="../posc:Name"/>
		<xsl:if test="../posc:Deprecated != ''"> [DEPRECATED]</xsl:if>
	</h2>

	<p align="center">
		<table border="1" cellpadding="0" cellspacing="0" width="98%" >
			<tr>
				<td width="15%"><strong>Annotation</strong></td>
				<td>
					<xsl:value-of select="../@annotation" />
				</td>
			</tr>
			<tr>
				<td width="15%"><strong>Base unit</strong></td>
				<td>
					<xsl:apply-templates select="." mode="baseUnitRef"/>
				</td>
			</tr>
			<tr>
				<td>
					<strong>Conversion</strong>
					<xsl:if test="posc:Factor">
						(factor)
					</xsl:if>
					<xsl:if test="posc:Fraction">
						(fraction)
					</xsl:if>
					<xsl:if test="posc:Formula">
						(formula)
					</xsl:if>
				</td>
				<td>
					<xsl:if test="posc:Factor">
						<xsl:value-of select="@baseUnit"/>
						<xsl:text> </xsl:text>
						= 
						<xsl:text> </xsl:text>
						<xsl:value-of select="posc:Factor"/>
						<xsl:text> </xsl:text>
						<xsl:value-of select="../@annotation" />
					</xsl:if>
					<xsl:if test="posc:Fraction">
						<xsl:value-of select="@baseUnit"/>
						<xsl:text> </xsl:text>
						=
						<xsl:text> </xsl:text>
						(
						<xsl:text> </xsl:text>
						<xsl:value-of select="posc:Fraction/posc:Numerator"/>
						<xsl:text> </xsl:text>
						/
						<xsl:text> </xsl:text>
						<xsl:value-of select="posc:Fraction/posc:Denominator"/>
						<xsl:text> </xsl:text>
						)
						<xsl:text> </xsl:text>
						<xsl:value-of select="../@annotation" />
					</xsl:if>
					<xsl:if test="posc:Formula">
						<xsl:value-of select="@baseUnit"/>
						<xsl:text> </xsl:text>
						= 
						<xsl:text> </xsl:text>
						(
						<xsl:text> </xsl:text>
						<xsl:if test="posc:Formula/posc:A">
							<xsl:value-of select="posc:Formula/posc:A"/> 
						</xsl:if>
						<xsl:if test="posc:Formula/posc:B">
						<xsl:text> </xsl:text>
							+
						<xsl:text> </xsl:text>
							<xsl:value-of select="posc:Formula/posc:B"/>
							<xsl:text> </xsl:text>
							<xsl:value-of select="../@annotation" /> 
						</xsl:if>
						<xsl:text> </xsl:text>
						)
						<xsl:if test="posc:Formula/posc:C">
							<xsl:choose>
								<xsl:when test="posc:Formula/posc:D">
									<xsl:text> </xsl:text>
									/ 
									<xsl:text> </xsl:text>
									(
									<xsl:text> </xsl:text>
									<xsl:value-of select="posc:Formula/posc:C"/>
									<xsl:text> </xsl:text>
									+
									<xsl:text> </xsl:text>
									<xsl:value-of select="posc:Formula/posc:D"/>
									<xsl:text> </xsl:text>
									<xsl:value-of select="../@annotation" />
									)
								</xsl:when>
								<xsl:when test="posc:Formula/posc:C != 1">
									/
									<xsl:text> </xsl:text>
									<xsl:value-of select="posc:Formula/posc:C"/>
								</xsl:when>
							</xsl:choose>
						</xsl:if>
					</xsl:if>
				</td>
			</tr>
			<tr>
				<td><strong>Origin</strong></td>
				<td><xsl:value-of select="../posc:CatalogName"/></td>
			</tr>
		</table>
	</p>

</xsl:template>



	<xsl:template match="*" mode="baseUnitName">
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="string" select="."/>
			<xsl:with-param name="mode" select="'name'"/>
		</xsl:call-template>
	</xsl:template>


	<xsl:template match="*" mode="baseUnitRef">
		<xsl:call-template name="uomRefString">
			<xsl:with-param name="string" select="@baseUnit"/>
			<xsl:with-param name="mode" select="'href'"/>
		</xsl:call-template>
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
			<xsl:when test="$char='A'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='B'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='C'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='D'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='E'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='F'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='G'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='H'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='I'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='J'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='K'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='L'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='M'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='N'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='O'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='P'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='Q'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='R'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='S'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='T'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='U'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='V'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='W'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='X'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='Y'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
			<xsl:when test="$char='Z'"><xsl:call-template name="_insertChar"><xsl:with-param name="string" select="$string"/>
						   <xsl:with-param name="index" select="$index"/><xsl:with-param name="mode" select="$mode"/>
						   <xsl:with-param name="original" select="$original"/><xsl:with-param name="path" select="$path"/>
						   </xsl:call-template></xsl:when>
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
