<xsl:transform
	xmlns:w120='http://www.witsml.org/schemas/120'
	xmlns:w131='http://www.witsml.org/schemas/131'
	xmlns:xsl='http://www.w3.org/1999/XSL/Transform'
	xmlns:pr="http://www.posc.org/apps" 
	xmlns:ua="http://www.posc.org/schemas/unitAlias" 
	xmlns:posc="http://www.posc.org/schemas" 
	xmlns:diff="http://www.posc.org/schemas/schemaDiff" 
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
	version='1.1'>

  <xsl:output 
	method     = "xml" 
	media-type = "text/xml"
	encoding   = "utf-8" />

<!-- ==================================================================== -->
<!--   Transform between different versions of WITSML XML files.          -->
<!--   The currently supported versions are (automatically determined):   -->
<!--   		v1.2                                                      -->
<!--   		v1.3.1.1                                                  -->
<!--   The currently supported objects are (automatically determined):    -->
<!--   		well                                                      -->
<!--   		wellbore                                                  -->
<!--   		trajectory                                                -->
<!--   		trajectoryStation                                         -->
<!--   		log                                                       -->
<!--   		wellLog                                                   -->
<!--   		realtime                                                  -->
<!--   		mudLog                                                    -->
<!--   Units of measure are converted to the target version.              -->
<!-- ==================================================================== -->


<!-- ==================================================================== -->
<!-- History
	Initial release with v1.3.1
	v02  17 April 2006 - GM
		1) Reverse the choice when converting lithology/actual to v131.
		2) Do not create lithology/qualifier unless accessories or fossil were given in v120.
		3) Generate an "interpreted" geologyInterval if no lithology is specified.
	v03  18 April 2006 - GM
		1) Add an optional external uom alias file.
		2) Do not create FileCreationInformation unless commonData/dTimStamp is given.
	v04  25 April 2006 - GM
		Allow for templates by retaining empty elements for v1.2 to v1.3.1 conversions.\
	v05  27 April 2006 - GM
		1) Fix a type in template "typeLithology-Forward". Replace "$value" with $actual"
		when trying to issue the error.
		2) When v12Template=YES and it is a forward conversion, Do not create:
		  a) documentInfo or dataRowCount
		  b) an @uid value when they the uids are artificially generated.
		3) Do not output a v131 log/description unless either description or otherData was given.
	v06  8 Sept 2006 - GM
		If w131:lithPC is not specified and w131:typeLithology="interpreted" 
		then set w120:lithPC=100%.
	v07  3 Oct 2006 - GM
		Convert w131:densShale even if w131:qualifier is not specified. 
	v08  10 Nov 2006 - GM
		Version 131 bug-fix (v1.3.1.1).
			For a forward conversion of realtime, map the first interval to the channel definition(s)
			instead of to the realtime header.
			Change version attribute from "1.3.1.0" to "1.3.1.1".
			For (wellLog,log,realtime) interval delete @uid.
		Fix bug, in mudlog "actual-Backward" template, 
			change "../../w131:typeLithology" to "../w131:typeLithology"
		Fix bug, in template with mode="unitless-Backward", properly pass "Euc" unit.
		Fix bug, in forward template for (log) indexCurve, create "columnIndex" attribute instead of "uid".
		Fix bug, in forward template for (realtime) densData, use "." instead of "w120:densdata".
		Fix bug, in template "location-Forward", do not test for "." when generating uid for latitude.
		Fix bug, do not create uidParentWellbore unless parentWellbore is given.
		Fix bug, in backward template do not create subactivity when none specified.
		Fix bug, in backward template for well/groundElevation do not create @datum.
		Fix bug, for backward conversion to uidLog only leave blank if uid not given.
		Fix bug, for backward conversion of realtime record, if a md is not in realtime create one from record (need the uom).
		Fix bug, for forward conversion, do not create a unit for channelDefinition because multiplexed is always false.
		Fix bug, for backward conversion of realtime, always create a channel if a record is specified (for template).
			For md, classWitsml, dTim and type, test for given element versus given value.
		Fix bug, for backward conversion, do not create uidSource unless nameSource is given.
		Fix bug, for wellLog backward to log, create logCurveInfo when uid is null.
	v09  29 Nov 2006 - GM
		Fix bug, for backward conversion of lithPC, test for given versus non-null value.
		Fix bug, for forward conversion of log to wellLog, do not create curveId values for a template.
		Fix bug, be more precise as to whether something was actually specified. This prevents, for example,
		a channel md or fet from being created when it was not specified in a template.
		Fix bug, for a backward conversion of mudLog, properly create uidSource.
		Fix bug, for a backward conversion, create an indexed object when given even if it has no content.
		
-->
<!-- ==================================================================== -->

<!-- Input parameters. -->
	<!-- Path to the unit of measure dictionary for the v120 schema. Required for unit conversion and mapping. -->
	<!-- For performance reasons, it is recommended that a local file be used. -->
	<xsl:param name="unitDictionary120">http://www.witsml.org/schemas/120/witsmlDict.xml</xsl:param>

	<!-- Path to the unit of measure dictionary for the v131 schema. Required for unit conversion and mapping.-->
	<!-- For performance reasons, it is recommended that a local file be used. -->
	<xsl:param name="unitDictionary131">http://www.witsml.org/schemas/131/ancillary/witsmlUnitDict.xml</xsl:param>

	<!-- Path to the schema difference file. Required for converting enumerations. -->
	<!-- For performance reasons, it is recommended that a local file be used. -->
	<xsl:param name="schemaDiff120-131">http://www.witsml.org/schemas/131/ancillary/schemaDiff_witsml_v120-v131.xml</xsl:param>

	<!-- Path (without the trailing slash) to the folder containing the schema xsd files for the 'to' namespace. 
		This will be added to the schemaLocation in output XML file. 
		The default is the 'to' namespace. -->
	<xsl:param name="schemaLocationPath"></xsl:param>

	<!-- Switch to specify specify whether v1.2 log object should be converted to log or wellLog. 
		This is only used for forward conversions of a LOG. -->
	<!-- The content should be the singluar name. -->
	<xsl:param name="logConvertTo">log</xsl:param>

	<!-- Path to the external enumeration XML file of the 'to' version. 
		This only used for forward conversion of activityCode in REALTIME object.-->
	<!-- For performance reasons, it is recommended that a local file be used. -->
	<xsl:param name="enumFile">http://www.witsml.org/schemas/131/ancillary/enumValues.xml</xsl:param>

	<!-- Sequence number for a REALTIME. This is only used for forward conversions. -->
	<!-- For multiple realtimes in one file, the value is incremented by one after the first realtime in each file. -->
	<xsl:param name="sequenceNumber">1</xsl:param>

	<!-- Do we want to create a REALTIME header. Values of YES or NO. 
		This is only used for forward realtime conversions. -->
	<xsl:param name="realtimeHeader">NO</xsl:param>

	<!-- Path to the REALTIME XML file that contains the realtimeHeader. 
		This is only used for backward realtime conversions and it may be the same as the current input file. -->
	<xsl:param name="realtimeFile"></xsl:param>

	<!-- Path to the a Unit Alias XML file. 
		This defines a mapping between non-standard v1.2 unit of measure acronyms and a standard v1.3.1 uom acronym. -->
	<xsl:param name="unitAliasFile"></xsl:param>

	<!-- Is this a v1.2 template file? A value of YES will retain empty elements or attributes. 
	     Otherwise, they will be eliminated. All empty elements or attributes will be retained when converting back to v1.2. -->
	<xsl:param name="v12Template">NO</xsl:param>



<!-- ============================================================== -->
<!-- This script assumes:
	1) The input file represents an XML file in the 'from' schema (based on its namespace).
	2) The root element is the plural object (i.e., with appended 's').
	3) All uom attributes are populated (except for the v1.2 unitless type 
	   and chromatograph concentrations).
	4) A program such as HTML Tidy will be run to indent the output (if desired).
	   A line break is generated after each element and at the beginning of each element container.
	5) All comments are at the beginning of an element container.
	6) Custom data can be copied in its same namespace.
-->

<!-- ============================================================== -->
<!-- Assumptions specific a FORWARD transform from v1.2 to v1.3.1

     Assumptions relevant to all objects:
	1) Values with a v1.2 unitless type have no uom or a uom with a base of Euc. 
	   The values will be converted to Euc.
	2) The commonData values of nameSource and dTimStamp values are the same for all objects.
	3) For uid and name foreign key pairs, if one value is missing, the string UNKNOWN-VALUE will be assumed.
	   This applies to nameTarget,uidTarget and nameParentWellbore,uidParentWellbore.

     Assumptions specific to the log object:
	1) stepIncrement will not be specified with a dateTime index.
	2) The contents of classPOSC conform to the RealtimeData enumerations.
	3) If startIndex is given then endIndex is also given (log-to-wellLog mode).
	4) The combination of description and otherData is less than 3996 characters.
	   That is, they are combined into element description with a four character delimeter.
	5) indexCurve is always specified.

     Assumptions specific to the well object:
	1) If dtmPermanent is given then it only applies to dtmPermToWellhead.
	2) Positive geodetic zone values indicate North.
	3) A very limited set of string values for timeZone (i.e., EST, CST, MST, PST).
	4) The name of the geographic CRS is the name of the datum.

     Assumptions specific to the mudLog object:
	1) The unit of measure of 'cec' and 'shaleFactor' is "meq/g".

     Assumptions specific to the realtime object:
	1) The unit of measure of 'fet' is 's'.
	2) The unit of measure of 'densData' is '1/ft'
	3) If 'md' is specified in channel, it is also specified in realtime (for uom).
	4) Merging of realtimeHeader is not required. 
	   That is, all channel mnemonics exist somewhere in the file when parameter realtimeHeader=YES.
	5) Only one wellbore is represented in the realtime. That is, wellName and wellboreName is the same for all realtimes
	6) The 'interval' specified in the first realtime (as opposed to channel) is the same as for subsequent realtimes. 
	7) The definition information in each channel with the same mnemonic is consistent (only the first is used).
	   That is, mnemonic has a unique definition for each realtime stream. The group id will be the mnemonic value.

     The following data will be lost.
	1) Knowledge of the 'original' coordinate if the corresponding coordinate pair is not defined.
	2) uomNamingSystem in log
-->

<!-- ==================================================================== -->
<!-- Assumptions specific to a BACKWARD transform from v1.3.1 to v1.2.

     Assumptions relevant to all objects:
	1) For locations, if no coordinate is defined as the original, 'Local' will be assumed for inputType.
	2) There is only one geographic CRS and only one projected CRS.
	   Correspondingly, for each recurring location set, there is only one coordinate pair for each system.
	   If this condition is not met in the v1.3.1 XML, the transform will produce invalid results.
	3) The unit of measure of v1.2 unitless types is 'Euc'.

     Assumptions specific to the well object:
	1) Permanent datum is defined by (in priority order):
	   a) The 'datum' attribute on wellheadElevation.
	   b) The default wellDatum for elevations.
	2) The name of the geographic CRS is the name of the datum.

     Assumptions specific to the wellLog object:
	1) There are no arrays (axisDefinition) or encoded values (encodingDef). The whole transform will fail.
	2) Each block can be converted to a separate log.

     Assumptions specific to the mudLog object:
	1) The cromatagraph gas concentration uom is the same for all values.
	2) The mudGas uom is the same for all values.

     Assumptions specific to the realtime object:
	1) There are no arrays (axisDefinition). The whole transform will fail.
	2) A particular mnemonic only exists in one group.

     The following data will be lost when converting from v1.3.1 to v1.2.
	 1) Optional elements whose enumeration value is 'unknown' or any other value added to v1.3.1.
	 2) In locations, knowledge of uid, wellCRS, description and axis orientation (e.g., easting or northing versus projectedX).
	 3) For all growing objects: objectGrowing.
	 4) For all vertical coordinates, knowledge of the vertical datum.
	 5) The original units of measure for any element that maps to the v1.2 type 'percent'.
	    The values will be converted to '%'.
	 6) For well:
		fluidWell.
		Any reference point, local coordinate or local CRS.
		Vertical datums (wellDatum) except for name of the 'permanent' datum. 
		groundElevation if it is NOT relative to mean sea level.
		projectedFrom in mapProjection.
		Knowledge of well known names (nameCRS) of coordinate systems.
	 7) For wellLog and log: objectGrowing, bhaRunNumber, pass, alternateIndex, wellDatum, dataSource, densData, logCurveInfo/@uid,
	    traceOrigin and start/end/min/max DateTimeIndex (if start/end/min/max Index are also given).
	 8) For wellLog (in addition to the above): blockCurveInfo/@uid.
	 9) For trajectoryStation: objectGrowing, typeSurveyTool, sourceStation and 
	    parentTrajectory (if it does not point to a trajectory in the current wellbore).
	10) For mudlog: relatedLog, parameter, geologyInterval/@uid, geologyInterval/qft, lithology/type,
	    lithology/qualifier, qft,  geologyInterval/currentAv.
	11) For realtime: @idSub, detailActivity, sequence, dataGroup, serviceCompany, runNumber, bhaRunNumber, pass, creationDate, 
	    realtimeHeader/description, mneAlias, sensorOffset, all knowledge of group 
	    (i.e., id, persistedAsLog, persistedAsWellLog, interval, comment).
-->


<!-- Global variables. -->

	<!-- relative versions. -->
	<xsl:variable name="oldVersion">http://www.witsml.org/schemas/120</xsl:variable>
	<xsl:variable name="newVersion">http://www.witsml.org/schemas/131</xsl:variable>

	<!-- Namespace for the new schema. -->
	<xsl:variable name="direction">
		<xsl:for-each select="/child::*">
			<xsl:choose>
				<xsl:when test="namespace-uri() = $oldVersion">forward</xsl:when>
				<xsl:when test="namespace-uri() = $newVersion">backward</xsl:when>
				<xsl:otherwise>UNKNOWN</xsl:otherwise>
			</xsl:choose>
		</xsl:for-each>
	</xsl:variable>

	<!-- A value of YES indicates that empty values should be retained. -->
	<xsl:variable name="retainEmpty">
		<xsl:choose>
			<xsl:when test="$direction='forward' and $v12Template='YES'">YES</xsl:when>
			<xsl:when test="$direction='backward'">YES</xsl:when>
			<xsl:otherwise>NO</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>

	<!-- Namespace for the new schema. -->
	<xsl:variable name="newNameSpace">
		<xsl:choose>
			<xsl:when test="$direction='forward'" ><xsl:value-of select="$newVersion"/></xsl:when>
			<xsl:when test="$direction='backward'"><xsl:value-of select="$oldVersion"/></xsl:when>
			<xsl:otherwise>UNKNOWN</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>

	<!-- The name of the singular output object. -->
	<xsl:variable name="object">
		<xsl:choose>
			<xsl:when test="name(.//child::*) = 'wellLogs'">
				<!-- This must be a backward conversion. -->
				<xsl:text>log</xsl:text>
			</xsl:when>
			<xsl:when test="name(.//child::*) != 'logs'">
				<!-- Strip off the terminating 's' to get the singular name. -->
				<xsl:value-of  select="substring(name(.//child::*),1,string-length(name(.//child::*))-1)"/>
			</xsl:when>
			<xsl:when test="$direction = 'backward'">
				<!-- This must be a log to log conversion. -->
				<xsl:text>log</xsl:text>
			</xsl:when>
			<xsl:otherwise>
				<!-- This must be a forward conversion of a log. -->
				<xsl:value-of  select="$logConvertTo"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>

	<!-- version of the new schema. -->
	<xsl:variable name="version">
		<xsl:choose>
			<xsl:when test="$direction='forward'" >1.3.1.1</xsl:when>
			<xsl:when test="$direction='backward'">1.2.0</xsl:when>
			<xsl:otherwise>UNKNOWN</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>

	<!-- schemaLocation of the new schema. -->
	<xsl:variable name="schemaLocation">
		<xsl:value-of select="$newNameSpace"/>
		<xsl:text> </xsl:text>
		<xsl:choose>
			<xsl:when test="$schemaLocationPath!=''">
				<xsl:value-of select="translate($schemaLocationPath,'\','/')"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$newNameSpace"/>
			</xsl:otherwise>
		</xsl:choose>
		<xsl:text>/obj_</xsl:text>
		<xsl:value-of select="$object"/>
		<xsl:text>.xsd</xsl:text>
	</xsl:variable>

	<!-- Node set for the v120 uom dictionary. -->
	<xsl:variable name="uomNodeSet120" select="document(translate($unitDictionary120,'\','/'))/pr:UnitOfMeasureDictionary"/>

	<!-- Node set for the v131 uom dictionary. -->
	<xsl:variable name="uomNodeSet131" select="document(translate($unitDictionary131,'\','/'))/posc:UnitOfMeasureDictionary"/>

	<!-- Node set for the schema difference file. -->
	<xsl:variable name="schemaDiffNodeSet" select="document(translate($schemaDiff120-131,'\','/'))//diff:enumSet"/>

	<!-- Node set for the external enum file. -->
	<xsl:variable name="activityCodeEnumSet" select="document(translate($enumFile,'\','/'))//w131:enumList[w131:name='ActivityCode']"/>

	<!-- Node set for the realtimeHeader. -->
	<xsl:variable name="realtimeHeaderSet" select="document(translate($realtimeFile,'\','/'))//w131:realtimeHeader"/>

	<!-- Node set for the unit alias file. -->
	<xsl:variable name="unitAliasSet" select="document(translate($unitAliasFile,'\','/'))//ua:unitAlias"/>


<!-- Output one plural container per input plural container -->
<xsl:template match="/child::*" >
	<xsl:call-template name="linebreak"/>
	<xsl:for-each select="parent::*">
		<xsl:call-template name="copy-comment"/>
	</xsl:for-each>
	<!-- The direction of conversion. -->
	<xsl:element name="{$object}s" namespace="{$newNameSpace}">
		<xsl:attribute name="xsi:schemaLocation"><xsl:value-of select="$schemaLocation"/></xsl:attribute>
		<xsl:attribute name="version"><xsl:value-of select="$version"/></xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:choose>
			<xsl:when test="$direction = 'forward'">
				<xsl:choose>
					<xsl:when test="$object = 'well'">
						<xsl:for-each select="w120:well">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="well-Forward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'wellbore'">
						<xsl:for-each select="w120:wellbore">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="wellbore-Forward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'trajectory'">
						<xsl:for-each select="w120:trajectory">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="trajectory-Forward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'trajectoryStation'">
						<xsl:for-each select="w120:trajectoryStation">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="trajectoryStation-Object-Forward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'log'">
						<xsl:for-each select="w120:log">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="log-Forward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'wellLog'">
						<xsl:for-each select="w120:log">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="log-Forward-To-WellLog"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'mudLog'">
						<xsl:for-each select="w120:mudLog">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="mudLog-Forward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'realtime'">
						<xsl:for-each select="w120:realtime">
							<xsl:if test="position()=1">
								<xsl:call-template name="documentInfo-Forward"/>
							</xsl:if>
							<xsl:call-template name="realtime-Forward"/>
						</xsl:for-each>
					</xsl:when>
				</xsl:choose>
			</xsl:when>
			<xsl:when test="$direction = 'backward'">
				<xsl:choose>
					<xsl:when test="$object = 'well'">
						<xsl:for-each select="w131:well">
							<xsl:call-template name="well-Backward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'wellbore'">
						<xsl:for-each select="w131:wellbore">
							<xsl:call-template name="wellbore-Backward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'trajectory'">
						<xsl:for-each select="w131:trajectory">
							<xsl:call-template name="trajectory-Backward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'trajectoryStation'">
						<xsl:for-each select="w131:trajectoryStation">
							<xsl:call-template name="trajectoryStation-Object-Backward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'log'">
						<xsl:choose>
							<xsl:when test="name(.) = 'logs'">
								<xsl:for-each select="w131:log">
									<xsl:call-template name="log-Backward"/>
								</xsl:for-each>
							</xsl:when>
							<xsl:when test="name(.) = 'wellLogs'">
								<xsl:choose>
									<xsl:when test="not(.//w131:axisDefinition or .//w131:encodingDef)">
										<xsl:for-each select="w131:wellLog">
											<xsl:call-template name="wellLog-Backward-To-Log"/>
										</xsl:for-each>
									</xsl:when>
									<xsl:otherwise>ERROR-WELLLOG-CONTAINS-ARRAY-DATA-OR-ENCODED-VALUES</xsl:otherwise>
								</xsl:choose>
							</xsl:when>
						</xsl:choose>
					</xsl:when>
					<xsl:when test="$object = 'mudLog'">
						<xsl:for-each select="w131:mudLog">
							<xsl:call-template name="mudLog-Backward"/>
						</xsl:for-each>
					</xsl:when>
					<xsl:when test="$object = 'realtime'">
						<xsl:for-each select="w131:realtime">
							<xsl:choose>
								<xsl:when test="not(.//w131:axisDefinition)">
									<xsl:call-template name="realtime-Backward"/>
								</xsl:when>
								<xsl:otherwise>ERROR-REALTIME-CONTAINS-ARRAY-DATA</xsl:otherwise>
							</xsl:choose>
						</xsl:for-each>
					</xsl:when>
				</xsl:choose>
			</xsl:when>
			<xsl:otherwise>ERROR-UNKNOWN-NAMESPACE</xsl:otherwise>
		</xsl:choose>
	</xsl:element>
</xsl:template>



<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!--                           Templates for FORWARD conversion.                             -->
<!--                       These templates are direction specific.                            -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->


<!-- ======================================================================================== -->
<!-- ==================== Templates specific to the REALTIME object. ======================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="realtime-Forward">
	<xsl:element name="realtime" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<!-- @uidSource moved to commonData/sourceName. -->
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<!-- nameWell moved to realtimeHeader. -->
		<!-- nameWellbore moved to realtimeHeader. -->
		<xsl:apply-templates select="w120:dTim"               mode="copy-element"/>
		<xsl:apply-templates select="w120:md"                 mode="copy-measure"/>
		<!-- interval moved to channelDefinition. -->
		<xsl:call-template                                    name="create-element">
			<xsl:with-param name="name">sequence</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$sequenceNumber+position()-1"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                    name="activityCode-realtime-Forward"/>
		<!-- activitySubcode is merged into activityCode. -->
		<xsl:call-template                                    name="realtimeHeader-Forward"/>
		<xsl:apply-templates select="w120:channel"            mode="channel-Forward"/>
		<xsl:apply-templates select="w120:commonData"         mode="Forward"/>
		<xsl:apply-templates select="w120:customData"         mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="realtimeHeader-Forward">
	<!-- We are still within the context of realtime. -->
	<xsl:if test="$realtimeHeader='YES'">
		<!-- Only create a header for the first realtime but use information from all realtimes. -->
		<xsl:if test="position()=1">
			<xsl:element name="realtimeHeader" namespace="{$newNameSpace}">
				<xsl:call-template name="linebreak"/>
				<xsl:call-template name="copy-comment"/>
				<xsl:apply-templates select="w120:nameWell"                  mode="copy-element"/>
				<xsl:apply-templates select="w120:nameWellbore"              mode="copy-element"/>
				<!-- Collect definitions from all channels in this file. -->
				<xsl:call-template                                           name="create-channelDefinition-Forward"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:channel" mode="channel-Forward">
	<xsl:element name="channel" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="@mnemonic"                           mode="create-element">
			<xsl:with-param name="name">id</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="@mnemonic"                           mode="create-element">
			<xsl:with-param name="name">mnemonic</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="@dTim"                               mode="create-element">
			<xsl:with-param name="name">dTim</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                                name="create-measure">
			<xsl:with-param name="name">md</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="../w120:md/@uom"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="@md"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="@md">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                                name="create-measure">
			<xsl:with-param name="name">value</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="@uom"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="@value"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="@value">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template name="linebreak"/>
		<xsl:apply-templates select="w120:densData"                       mode="Forward"/>
		<xsl:apply-templates select="w120:qualData"                       mode="copy-element"/>
		<xsl:call-template                                                name="create-measure">
			<xsl:with-param name="name">fet</xsl:with-param>
			<xsl:with-param name="unit"><xsl:if test="w120:fet!=''">s</xsl:if></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:fet"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:fet">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="create-channelDefinition-Forward">
	<!-- Scan all channels and create a definition based on the first one for each mnemonic. -->
	<!-- We are still within the context of realtime. -->
	<xsl:variable name="channelSet" select="//w120:channel"/>
	<xsl:for-each select="$channelSet">
		<xsl:variable name="mne"><xsl:value-of select="@mnemonic"/></xsl:variable>
		<xsl:variable name="pos"><xsl:value-of select="position()"/></xsl:variable>
		<xsl:variable name="doIt">
			<!-- Have we already done this mnemonic. doIt=NO indicates that we have. -->
			<xsl:for-each select="$channelSet">
				<xsl:if test="$pos>position() and @mnemonic=$mne">NO</xsl:if>
			</xsl:for-each>
		</xsl:variable>
		<xsl:if test="not(contains($doIt,'NO'))">
			<xsl:apply-templates select="."                   mode="channelDefinition-Forward"/>
		</xsl:if>
	</xsl:for-each>
</xsl:template>

<xsl:template match="w120:channel" mode="channelDefinition-Forward">
	<!-- Each channel definition will be within a separate group definition. -->
	<xsl:element name="groupDefinition" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:apply-templates select="@mnemonic"                                   mode="create-element">
			<xsl:with-param name="name">id</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                                        name="create-element">
			<xsl:with-param name="name">multiplexed</xsl:with-param>
			<xsl:with-param name="value">false</xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:element name="channelDefinition" namespace="{$newNameSpace}">
			<xsl:call-template name="linebreak"/>
			<xsl:apply-templates select="@mnemonic"                           mode="create-element">
				<xsl:with-param name="name">mnemonic</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="@type"                               mode="create-enumeration-element">
				<xsl:with-param name="typeName">DataType</xsl:with-param>
				<xsl:with-param name="name">dataType</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="@classWitsml"                        mode="create-enumeration-element">
				<xsl:with-param name="typeName">RealtimeData</xsl:with-param>
				<xsl:with-param name="name">classWitsml</xsl:with-param>
			</xsl:apply-templates>
			<!-- Do not create unit element because multiplexed is always false. -->
			<xsl:apply-templates select="w120:description"                    mode="copy-element"/>
			<xsl:apply-templates select="w120:source"                         mode="rename-element">
				<xsl:with-param name="newName">dataSource</xsl:with-param>
			</xsl:apply-templates>
			<xsl:choose>
				<!-- Either use the interval in this channel or use the one in the parent realtime. -->
				<xsl:when test="w120:interval">
					<xsl:apply-templates select="w120:interval"       mode="interval-Forward"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:apply-templates select="../w120:interval"    mode="interval-Forward"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:element>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:densData" mode="Forward">
	<xsl:call-template                                                               name="create-measure">
		<xsl:with-param name="name">densData</xsl:with-param>
		<xsl:with-param name="unit"><xsl:if test=".!=''">1/ft</xsl:if></xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="w120:interval" mode="interval-Forward">
	<xsl:element name="interval" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:apply-templates select="@type"                               mode="create-enumeration-element">
			<xsl:with-param name="typeName">IntervalType</xsl:with-param>
			<xsl:with-param name="name">type</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="@method"                             mode="create-enumeration-element">
			<xsl:with-param name="typeName">IntervalMethod</xsl:with-param>
			<xsl:with-param name="name">method</xsl:with-param>
		</xsl:apply-templates>
		<xsl:if test="normalize-space(@value)!='' or (@value and $retainEmpty='YES')">
			<xsl:if test="@type='Time' or (normalize-space(@type)='' and $retainEmpty='YES')">
				<xsl:call-template                                name="create-measure">
					<xsl:with-param name="name">timeInterval</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="@uom"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="@value"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:if>
			<xsl:if test="@type='Depth' or (normalize-space(@type)='' and $retainEmpty='YES')">
				<xsl:call-template                                name="create-measure">
					<xsl:with-param name="name">distanceInterval</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="@uom"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="@value"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:if>
		</xsl:if>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="activityCode-realtime-Forward">
	<!-- Activity code and subcodes were concatenated. -->
	<xsl:variable name="code">
		<xsl:call-template                                                name="convert-enum-value">
			<xsl:with-param name="typeName">ActivityCode</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:activityCode"/></xsl:with-param>
		</xsl:call-template>
	</xsl:variable>
	<xsl:variable name="sub">
		<xsl:call-template                                                name="convert-enum-value">
			<xsl:with-param name="typeName">ActivitySubcode</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:activitySubcode"/></xsl:with-param>
		</xsl:call-template>
	</xsl:variable>
	<xsl:variable name="combined">
		<xsl:choose>
			<xsl:when test="$code='miscellaneous' and w120:activitySubcode='MISCELLANEOUS'">miscellaneous</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$code"/>
				<xsl:if test="$code!=''">
					<xsl:if test="$sub!=''"> -- </xsl:if>
				</xsl:if>
				<xsl:value-of select="$sub"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:if test="normalize-space($combined)!='' or $retainEmpty='YES'">
		<xsl:variable name="value">
			<!-- Now that we have combined the values, is this a valid combination? -->
			<xsl:if test="$activityCodeEnumSet/w131:value[w131:name=$combined]">
				<xsl:value-of select="$combined"/>
			</xsl:if>
		</xsl:variable>
		<xsl:call-template                                            name="create-element">
			<xsl:with-param name="name">activityCode</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$value"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:activityCode">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
	</xsl:if>
</xsl:template>



<!-- ======================================================================================== -->
<!-- ==================== Templates specific to the MUDLOG object. ========================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="mudLog-Forward">
	<xsl:element name="mudLog" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidMudLog)"/></xsl:attribute>
		<!-- @uidSource moved to commonData/sourceName. -->
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:nameWell"           mode="copy-element"/>
		<xsl:apply-templates select="w120:nameWellbore"       mode="copy-element"/>
		<xsl:apply-templates select="w120:nameMudLog"         mode="rename-element">
			<xsl:with-param name="newName">name</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:dTim"               mode="copy-element"/>
		<xsl:apply-templates select="w120:mudLogCompany"      mode="copy-element"/>
		<xsl:apply-templates select="w120:mudLogEngineers"    mode="copy-element"/>
		<xsl:apply-templates select="w120:startMd"            mode="copy-measure"/>
		<xsl:apply-templates select="w120:endMd"              mode="copy-measure"/>
		<xsl:apply-templates select="w120:geologyInterval"    mode="Forward"/>
		<xsl:apply-templates select="w120:commonData"         mode="Forward"/>
		<xsl:apply-templates select="w120:customData"         mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:geologyInterval" mode="Forward">
	<!-- If an interval contains both actual and interpreted lithologies then create two intervals. -->
	<xsl:variable name="cuttings">
		<xsl:for-each select="w120:lithology">
			<xsl:if test="w120:actual = 'true'">YES</xsl:if>
			<xsl:if test="w120:actual = '1'">YES</xsl:if>
		</xsl:for-each>
	</xsl:variable>
	<xsl:if test="contains($cuttings,'YES')">
		<xsl:call-template name="geologyInterval-Forward-Split">
			<xsl:with-param name="actual">true</xsl:with-param>
		</xsl:call-template>
	</xsl:if>
	<xsl:variable name="interp">
		<xsl:for-each select="w120:lithology">
			<xsl:if test="w120:actual = 'false'">YES</xsl:if>
			<xsl:if test="w120:actual = '0'">YES</xsl:if>
			<xsl:if test="w120:actual = '' and $retainEmpty='NO'">YES</xsl:if>
			<xsl:if test="not(w120:actual)">YES</xsl:if>
		</xsl:for-each>
		<xsl:if test="not(w120:lithology)">YES</xsl:if> <!-- GM - 17apr2006 - Generate an "interpreted" geologyInterval if no lithology is specified. -->
	</xsl:variable>
	<xsl:if test="contains($interp,'YES')">
		<xsl:call-template name="geologyInterval-Forward-Split">
			<xsl:with-param name="actual">false</xsl:with-param>
		</xsl:call-template>
	</xsl:if>
	<xsl:variable name="empty">
		<xsl:for-each select="w120:lithology">
			<xsl:if test="w120:actual = '' and $retainEmpty='YES'">YES</xsl:if>
		</xsl:for-each>
	</xsl:variable>
	<xsl:if test="contains($empty,'YES')">
		<xsl:call-template                                                   name="geologyInterval-Forward-Split">
			<xsl:with-param name="actual">empty</xsl:with-param>
		</xsl:call-template>
	</xsl:if>
</xsl:template>

<xsl:template name="geologyInterval-Forward-Split">
	<!-- We are still within the context of geologyInterval. -->
	<xsl:param name="actual"/>
	<xsl:element name="geologyInterval" namespace="{$newNameSpace}">
		<xsl:attribute name="uid">
			<xsl:if test="$retainEmpty='NO'">GI-<xsl:value-of select="position()"/></xsl:if>
		</xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:call-template                                       name="typeLithology-Forward">
			<xsl:with-param name="actual"><xsl:value-of select="$actual"/></xsl:with-param>
		</xsl:call-template>
		<!-- mdTop is handled with lenInterval. -->
		<!-- mdBottom is handled with lenInterval. -->
		<!-- lenInterval was deleted. -->
		<xsl:call-template                                       name="lenInterval-Forward"/>
		<xsl:apply-templates select="w120:dTim"                  mode="copy-element"/>
		<xsl:apply-templates select="w120:tvdTop"                mode="copy-measure"/>
		<xsl:apply-templates select="w120:tvdBase"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:ropAv"                 mode="copy-measure"/>
		<xsl:apply-templates select="w120:ropMn"                 mode="copy-measure"/>
		<xsl:apply-templates select="w120:ropMx"                 mode="copy-measure"/>
		<xsl:apply-templates select="w120:wobAv"                 mode="copy-measure"/>
		<xsl:apply-templates select="w120:tqAv"                  mode="copy-measure"/>
		<xsl:apply-templates select="w120:rpmAv"                 mode="copy-measure"/>
		<xsl:apply-templates select="w120:wtMudAv"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:ecdTdAv"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:dxcAv"                 mode="unitless-Forward"/>
		<xsl:apply-templates select="w120:lithology"             mode="Forward">
			<xsl:with-param name="actual"><xsl:value-of select="$actual"/></xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:show"                  mode="Forward"/>
		<xsl:apply-templates select="w120:chromatograph"         mode="Forward"/>
		<xsl:apply-templates select="w120:mudGas"                mode="Forward"/>
		<xsl:apply-templates select="w120:densBulk"              mode="copy-measure"/>
		<xsl:apply-templates select="w120:densShale"             mode="copy-measure"/>
		<!-- shaleFactor was deleted - semantically the same as element cec. -->
		<xsl:apply-templates select="w120:calcite"               mode="percent-Forward"/>
		<xsl:apply-templates select="w120:dolomite"              mode="percent-Forward"/>
		<xsl:call-template                                       name="cec-Forward"/>
		<xsl:apply-templates select="w120:calcStab"              mode="percent-Forward"/>
		<xsl:apply-templates select="w120:nameFormation"         mode="copy-element"/>
		<xsl:apply-templates select="w120:lithostratigraphic"    mode="copy-element"/>
		<xsl:apply-templates select="w120:chronostratigraphic"   mode="copy-element"/>
		<xsl:apply-templates select="w120:sizeMn"                mode="copy-measure"/>
		<xsl:apply-templates select="w120:sizeMx"                mode="copy-measure"/>
		<xsl:apply-templates select="w120:lenPlug"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:description"           mode="copy-element"/>
		<xsl:apply-templates select="w120:cuttingFluid"          mode="copy-element"/>
		<xsl:apply-templates select="w120:cleaningMethod"        mode="copy-element"/>
		<xsl:apply-templates select="w120:dryingMethod"          mode="copy-element"/>
		<xsl:apply-templates select="w120:comments"              mode="copy-element"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="lenInterval-Forward">
	<!-- We are still within the context of geologyInterval. -->
	<!-- Any 2 of top, bottom and interval defines the other. -->
	<xsl:apply-templates select="w120:mdTop"                       mode="copy-measure"/>
	<xsl:apply-templates select="w120:mdBottom"                    mode="copy-measure"/>
	<xsl:if test="w120:lenInterval">
		<xsl:if test="not(w120:mdTop)">
			<xsl:if test="w120:mdBottom">
				<xsl:call-template                     name="create-measure">
					<xsl:with-param name="name">mdTop</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:mdBottom/@uom"/></xsl:with-param>
					<xsl:with-param name="value">
						<xsl:if test="w120:mdBottom!='' and w120:lenInterval!=''">
							<xsl:value-of select="number(w120:mdBottom) - number(w120:lenInterval)"/>
						</xsl:if>
					</xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:if>
		</xsl:if>
		<xsl:if test="not(w120:mdBottom)">
			<xsl:if test="w120:mdTop">
				<xsl:call-template                     name="create-measure">
					<xsl:with-param name="name">mdBottom</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:mdTop/@uom"/></xsl:with-param>
					<xsl:with-param name="value">
						<xsl:if test="w120:mdTop!='' and w120:lenInterval!=''">
							<xsl:value-of select="number(w120:mdTop) + number(w120:lenInterval)"/>
						</xsl:if>
					</xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:if>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template name="cec-Forward">
	<!-- We are still within the context of geologyInterval. -->
	<!-- cec and shaleFactor are semantically equivalent. -->
	<xsl:choose>
		<xsl:when test="w120:cec">
			<xsl:call-template                             name="create-measure">
				<xsl:with-param name="name">cec</xsl:with-param>
				<xsl:with-param name="unit">meq/g</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="w120:cec"/></xsl:with-param>
				<xsl:with-param name="given"><xsl:if test="w120:cec">YES</xsl:if></xsl:with-param>
			</xsl:call-template>
		</xsl:when>
		<xsl:when test="w120:shaleFactor">
			<xsl:call-template                             name="create-measure">
				<xsl:with-param name="name">cec</xsl:with-param>
				<xsl:with-param name="unit">meq/g</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="w120:shaleFactor"/></xsl:with-param>
				<xsl:with-param name="given"><xsl:if test="w120:shaleFactor">YES</xsl:if></xsl:with-param>
			</xsl:call-template>
		</xsl:when>
	</xsl:choose>
</xsl:template>

<xsl:template name="typeLithology-Forward">
	<xsl:param name="actual"/>
	<!-- We are still within the context of geologyInterval. -->
	<xsl:variable name="value">
		<xsl:choose>    <!-- GM - 17apr2006 - reverse the choice -->
			<xsl:when test="$actual='empty'"></xsl:when>
			<xsl:when test="$actual='true'">cuttings</xsl:when>
			<xsl:when test="$actual='false'">interpreted</xsl:when>
			<xsl:otherwise>ERROR-ACTUAL-PARAMETER=<xsl:value-of select="$actual"/></xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:call-template                                                name="create-element">
		<xsl:with-param name="name">typeLithology</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="$value"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="w120:lithology" mode="Forward">
	<xsl:param name="actual"/> <!-- Must match the value of actual. -->
	<xsl:variable name="doit">
		<xsl:choose>
			<xsl:when test="$actual='true'">
				<xsl:if test="w120:actual='true'">YES</xsl:if>
				<xsl:if test="w120:actual='1'">YES</xsl:if>
			</xsl:when>
			<xsl:when test="$actual='false'">
				<xsl:if test="w120:actual = 'false'">YES</xsl:if>
				<xsl:if test="w120:actual = '0'">YES</xsl:if>
				<xsl:if test="w120:actual = ''">YES</xsl:if>
				<xsl:if test="not(w120:actual)">YES</xsl:if>
			</xsl:when>
			<xsl:when test="$actual='empty'">
				<xsl:if test="w120:actual = ''">YES</xsl:if>
			</xsl:when>
		</xsl:choose>
	</xsl:variable>
	<xsl:if test="contains($doit,'YES')">
		<xsl:element name="lithology" namespace="{$newNameSpace}">
			<xsl:attribute name="uid"><xsl:value-of select="@uidLithName"/></xsl:attribute>
			<xsl:call-template name="linebreak"/>
			<xsl:call-template name="copy-comment"/>
			<xsl:apply-templates select="w120:codeLith"       mode="copy-element"/>
			<xsl:apply-templates select="w120:lithPc"         mode="percent-Forward"/>
			<xsl:apply-templates select="w120:description"    mode="copy-element"/>
			<xsl:apply-templates select="w120:lithClass"      mode="copy-element"/>
			<xsl:apply-templates select="w120:grainType"      mode="copy-element"/>
			<xsl:apply-templates select="w120:dunhamClass"    mode="copy-element"/>
			<xsl:apply-templates select="w120:color"          mode="copy-element"/>
			<xsl:apply-templates select="w120:texture"        mode="copy-element"/>
			<xsl:apply-templates select="w120:hardness"       mode="copy-element"/>
			<xsl:apply-templates select="w120:sizeGrain"      mode="copy-element"/>
			<xsl:apply-templates select="w120:roundness"      mode="copy-element"/>
			<xsl:apply-templates select="w120:sorting"        mode="copy-element"/>
			<xsl:apply-templates select="w120:matrixCement"   mode="copy-element"/>
			<xsl:apply-templates select="w120:porosityVis"    mode="rename-element">
				<xsl:with-param name="newName">porosityVisible</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="w120:permeability"   mode="copy-element"/>
			<!-- accessories moved to qualifier. -->
			<!-- fossil moved to qualifier. -->
			<xsl:apply-templates select="w120:densShale"      mode="copy-measure"/>
			<xsl:call-template                                name="qualifier-Forward"/>
			<!-- actual moved to up to typeLithology. -->
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template name="qualifier-Forward">
	<!-- We are still within the context of lithology. -->
	<xsl:variable name="desc">
		<!-- Concatenate accessories and fossil. -->
		<xsl:if test="w120:accessories!=''">
			<xsl:text>accessories: </xsl:text>
			<xsl:value-of select="w120:accessories"/>
			<xsl:if test="w120:fossil!=''"> -- </xsl:if>
		</xsl:if>
		<xsl:if test="w120:fossil!=''">
			<xsl:text>fossil: </xsl:text>
			<xsl:value-of select="w120:fossil"/>
		</xsl:if>
	</xsl:variable>
	<xsl:if test="w120:accessories | w120:fossil"> <!-- GM - 17apr2006 - do not create lithology/qualifier unless accessories or fossil were given in v120. -->
		<xsl:element name="qualifier" namespace="{$newNameSpace}">
			<xsl:attribute name="uid">
				<xsl:if test="$retainEmpty='NO'">Q-<xsl:value-of select="position()"/></xsl:if>
			</xsl:attribute>
			<xsl:call-template name="linebreak"/>
			<xsl:call-template                                           name="create-element">
				<xsl:with-param name="name">type</xsl:with-param>
				<xsl:with-param name="value"><xsl:if test="w120:accessories!='' or w120:fossil!=''">unknown</xsl:if></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
			<xsl:call-template                                           name="create-element">
				<xsl:with-param name="name">description</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="$desc"/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:show" mode="Forward">
	<xsl:element name="show" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:showRat"             mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowRating</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:stainColor"          mode="copy-element"/>
		<xsl:apply-templates select="w120:stainDistr"          mode="copy-element"/>
		<xsl:apply-templates select="w120:stainPc"             mode="percent-Forward"/>
		<xsl:apply-templates select="w120:natFlorColor"        mode="copy-element"/>
		<xsl:apply-templates select="w120:natFlorPc"           mode="percent-Forward"/>
		<xsl:apply-templates select="w120:natFlorLevel"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowFluorescence</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:natFlorDesc"         mode="copy-element"/>
		<xsl:apply-templates select="w120:cutColor"            mode="copy-element"/>
		<xsl:apply-templates select="w120:cutSpeed"            mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowSpeed</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:cutStrength"         mode="copy-element"/>
		<xsl:apply-templates select="w120:cutForm"             mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowLevel</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:cutLevel"            mode="copy-element"/>
		<xsl:apply-templates select="w120:cutFlorColor"        mode="copy-element"/>
		<xsl:apply-templates select="w120:cutFlorSpeed"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowSpeed</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:cutFlorStrength"     mode="copy-element"/>
		<xsl:apply-templates select="w120:cutFlorForm"         mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowLevel</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:cutFlorLevel"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowFluorescence</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:residueColor"        mode="copy-element"/>
		<xsl:apply-templates select="w120:showDesc"            mode="copy-element"/>
		<xsl:apply-templates select="w120:impregnatedLitho"    mode="copy-element"/>
		<xsl:apply-templates select="w120:odor"                mode="copy-element"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:chromatograph" mode="Forward">
	<xsl:element name="chromatograph" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:dTim"                mode="copy-element"/>
		<xsl:apply-templates select="w120:mdTop"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:mdBottom"            mode="copy-measure"/>
		<xsl:apply-templates select="w120:wtMudIn"             mode="copy-measure"/>
		<xsl:apply-templates select="w120:wtMudOut"            mode="copy-measure"/>
		<xsl:apply-templates select="w120:chromType"           mode="copy-element"/>
		<!-- chromGasUnit was deleted - redundant to uom attributes. -->
		<xsl:apply-templates select="w120:eTimChromCycle"      mode="copy-measure"/>
		<xsl:apply-templates select="w120:chromIntRpt"         mode="copy-element"/>
		<xsl:apply-templates select="w120:methAv"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:methMn"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:methMx"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ethAv"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ethMn"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ethMx"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:propAv"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:propMn"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:propMx"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ibutAv"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ibutMn"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ibutMx"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:nbutAv"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:nbutMn"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:nbutMx"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ipentAv"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ipentMn"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ipentMx"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:npentAv"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:npentMn"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:npentMx"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:epentAv"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:epentMn"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:epentMx"             mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ihexAv"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ihexMn"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:ihexMx"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:nhexAv"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:nhexMn"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:nhexMx"              mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:co2Av"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:co2Mn"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:co2Mx"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:h2sAv"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:h2sMn"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:h2sMx"               mode="copy-chromatograph-measure-Forward"/>
		<xsl:apply-templates select="w120:acetylene"           mode="percent-Forward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="*" mode="copy-chromatograph-measure-Forward">
	<!-- chromatograph uom values may be defined by chromGasUnit. -->
	<xsl:variable name="unit">
		<xsl:choose>
			<xsl:when test="../w120:chromGasUnit!=''">
				<xsl:value-of select="../w120:chromGasUnit"/>
			</xsl:when>
			<xsl:when test="../w120:chromGasUnit"></xsl:when>
			<xsl:otherwise>ppm</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:call-template                                             name="create-measure">
		<xsl:with-param name="name"><xsl:value-of select="name()"/></xsl:with-param>
		<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="w120:mudGas" mode="Forward">
	<xsl:element name="mudGas" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<!-- gasUnit was deleted - redundant to uom attributes. -->
		<xsl:call-template                                      name="create-measure">
			<xsl:with-param name="name">gasAv</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:gasUnit"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:gasAv"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:gasAv">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                      name="create-measure">
			<xsl:with-param name="name">gasPeak</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:gasUnit"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:gasPeak"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:gasPeak">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:apply-templates select="w120:gasPeakType"          mode="convert-enumeration-element">
			<xsl:with-param name="typeName">GasPeakType</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                      name="create-measure">
			<xsl:with-param name="name">gasBackgnd</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:gasUnit"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:gasBackgnd"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:gasBackgnd">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                      name="create-measure">
			<xsl:with-param name="name">gasConAv</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:gasUnit"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:gasConAv"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:gasConAv">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                      name="create-measure">
			<xsl:with-param name="name">gasConMx</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:gasUnit"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:gasConMx"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:gasConMx">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                      name="create-measure">
			<xsl:with-param name="name">gasTrip</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:gasUnit"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:gasTrip"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w120:gasTrip">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<!-- ======================================================================================== -->
<!-- ============= Templates specific to the LOG object FORWARD-TO-WELLLOG. ================= -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="log-Forward-To-WellLog">
	<xsl:element name="wellLog" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidLog)"/></xsl:attribute>
		<!-- @uidSource moved to commonData/sourceName. -->
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:nameWell"                     mode="copy-element"/>
		<xsl:apply-templates select="w120:nameWellbore"                 mode="copy-element"/>
		<xsl:apply-templates select="w120:nameLog"                      mode="rename-element">
			<xsl:with-param name="newName">name</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:logHeader"                    mode="Forward-To-WellLog"/>
		<xsl:apply-templates select="w120:logData"                      mode="Forward"/>
		<xsl:apply-templates select="w120:commonData"                   mode="Forward"/>
		<xsl:apply-templates select="w120:customData"                   mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:logHeader" mode="Forward-To-WellLog">
	<!-- logHeader was collapsed to log in v1.3.1. -->
	<xsl:call-template name="copy-comment"/>
	<xsl:apply-templates select="w120:serviceCompany"       mode="copy-element"/>
	<xsl:apply-templates select="w120:runNumber"            mode="copy-element"/>
	<xsl:apply-templates select="w120:creationDate"         mode="copy-element"/>
	<xsl:call-template                                      name="logHeader-description-Forward"/>
	<xsl:apply-templates select="w120:indexType"            mode="convert-enumeration-element">
		<xsl:with-param name="typeName">LogIndexType</xsl:with-param>
	</xsl:apply-templates>
	<xsl:call-template                                      name="startIndex-Header-Forward-To-WellLog"/>
	<!-- endIndex was handled with startIndex. -->
	<!-- direction is not used here. -->
	<!-- indexCurve is not used here. -->
	<!-- stepIncrement is not used here. -->
	<!-- indexUnits moved to become a uom attribute. -->
	<xsl:apply-templates select="w120:nullValue"            mode="copy-element"/>
	<!-- uomNamingSystem was deleted. -->
	<xsl:apply-templates select="w120:logHeaderParam"       mode="rename-indexedObject">
		<xsl:with-param name="newName">logParam</xsl:with-param>
	</xsl:apply-templates>
	<!-- otherData was moved to description. -->
	<xsl:apply-templates select="w120:logCurveInfo"         mode="Forward-To-WellLog"/>
	<xsl:call-template                                      name="blockInfo-Forward-To-WellLog"/>
</xsl:template>

<xsl:template name="blockInfo-Forward-To-WellLog">
	<!-- For wellLog, blockInfo is a variation of logHeader. -->
	<!-- Note that we are still in the context of logHeader. -->
	<xsl:element name="blockInfo" namespace="{$newNameSpace}">
		<xsl:attribute name="uid">
			<xsl:if test="$retainEmpty='NO'">1</xsl:if>
		</xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<!-- serviceCompany is not used here. -->
		<!-- runNumber is not used here. -->
		<!-- creationDate is not used here. -->
		<xsl:call-template                                              name="logHeader-description-Forward"/>
		<xsl:apply-templates select="w120:indexType"                    mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogIndexType</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                              name="startIndex-Header-Forward"/>
		<!-- endIndex was handled with startIndex. -->
		<xsl:apply-templates select="w120:direction"                    mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogIndexDirection</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:indexCurve"                   mode="Forward"/>
		<!-- stepIncrement was handled with startIndex. -->
		<!-- indexUnits was moved to a uom attribute. -->
		<xsl:apply-templates select="w120:nullValue"                    mode="copy-element"/>
		<!-- uomNamingSystem was deleted. -->
		<xsl:apply-templates select="w120:logHeaderParam"               mode="rename-indexedObject">
			<xsl:with-param name="newName">logParam</xsl:with-param>
		</xsl:apply-templates>
		<!-- otherData was moved to description. -->
		<xsl:apply-templates select="w120:logCurveInfo"                 mode="blockCurveInfo-Forward-To-WellLog"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:logCurveInfo" mode="Forward-To-WellLog">
	<!-- For wellLog, logCurveInfo contains the semantic content part of log/logCurveInfo. -->
	<xsl:element name="logCurveInfo" namespace="{$newNameSpace}">
		<xsl:attribute name="uid">
			<xsl:if test="$retainEmpty='NO'"><xsl:value-of select="position()"/></xsl:if>
		</xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:mnemonic"           mode="copy-element"/>
		<xsl:apply-templates select="w120:classPOSC"          mode="rename-classWitsml">
			<xsl:with-param name="newName">classWitsml</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:unit"               mode="copy-element"/>
		<xsl:apply-templates select="w120:mnemAlias"          mode="copy-element"/>
		<xsl:apply-templates select="w120:nullValue"          mode="copy-element"/>
		<!-- startIndex is not used here. -->
		<!-- endIndex is not used here. -->
		<!-- columnIndex is not used here. -->
		<xsl:apply-templates select="w120:curveDescription"   mode="copy-element"/>
		<xsl:apply-templates select="w120:sensorOffset"       mode="copy-measure"/>
		<xsl:apply-templates select="w120:traceState"         mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogTraceState</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:typeLogData"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogDataType</xsl:with-param>
		</xsl:apply-templates>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:logCurveInfo" mode="blockCurveInfo-Forward-To-WellLog">
	<!-- For wellLog, blockCurveInfo contains the structural representation part of log/logCurveInfo. -->
	<!-- Since there is only one block, there is a one-to-one correspondence between logCurveInfo and blockCurveInfo. -->
	<xsl:element name="blockCurveInfo" namespace="{$newNameSpace}">
		<xsl:attribute name="uid">
			<xsl:if test="$retainEmpty='NO'"><xsl:value-of select="position()"/></xsl:if>
		</xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:call-template                                      name="create-element">
			<xsl:with-param name="name">curveId</xsl:with-param>
			<xsl:with-param name="value">
				<xsl:if test="$retainEmpty='NO'"><xsl:value-of select="position()"/></xsl:if>
			</xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:apply-templates select="w120:columnIndex"          mode="copy-element"/>
		<!-- mnemonic is not used here. -->
		<!-- classPOSC is not used here. -->
		<!-- unit is not used here. -->
		<!-- mnemAlias is not used here. -->
		<!-- nullValue is not used here. -->
		<xsl:call-template                                      name="startIndex-Curve-Forward"/>
		<!-- curveDescription is not used here. -->
		<!-- sensorOffset is not used here. -->
		<!-- traceState is not used here. -->
		<!-- typeLogData is not used here. -->
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="startIndex-Header-Forward-To-WellLog">
	<!-- Converts start/end index to min/max index. -->
	<xsl:if test="w120:startIndex">
		<xsl:variable name="min">
			<xsl:choose>
				<xsl:when test="w120:startIndex > w120:endIndex">
					<xsl:value-of select="normalize-space(w120:endIndex)"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="normalize-space(w120:startIndex)"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<xsl:variable name="max">
			<xsl:choose>
				<xsl:when test="w120:startIndex > w120:endIndex">
					<xsl:value-of select="normalize-space(w120:startIndex)"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="normalize-space(w120:endIndex)"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="w120:indexType='DateTime'">
				<xsl:call-template                                      name="create-element">
					<xsl:with-param name="name">minDateTimeIndex</xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="$min"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template                                      name="create-element">
					<xsl:with-param name="name">maxDateTimeIndex</xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="$max"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template                                      name="create-measure">
					<xsl:with-param name="name">minIndex</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:indexUnits"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="$min"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template                                      name="create-measure">
					<xsl:with-param name="name">maxIndex</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:indexUnits"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="$max"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</xsl:template>



<!-- ======================================================================================== -->
<!-- ================ Templates specific to the LOG object (LOG-TO-LOG). ==================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="log-Forward">
	<xsl:element name="log" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidLog)"/></xsl:attribute>
		<!-- @uidSource moved to commonData/sourceName. -->
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:nameWell"           mode="copy-element"/>
		<xsl:apply-templates select="w120:nameWellbore"       mode="copy-element"/>
		<xsl:apply-templates select="w120:nameLog"            mode="rename-element">
			<xsl:with-param name="newName">name</xsl:with-param>
		</xsl:apply-templates>
		<xsl:if test="$retainEmpty='NO'">
			<xsl:call-template                                    name="create-element">
				<xsl:with-param name="name">dataRowCount</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="count(w120:logData/w120:data)"/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
		</xsl:if>
		<xsl:apply-templates select="w120:logHeader"          mode="Forward"/>
		<xsl:apply-templates select="w120:logData"            mode="Forward"/>
		<xsl:apply-templates select="w120:commonData"         mode="Forward"/>
		<xsl:apply-templates select="w120:customData"         mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:logHeader" mode="Forward">
	<!-- logHeader was collapsed to log in v1.3.1. -->
	<xsl:call-template name="copy-comment"/>
	<xsl:apply-templates select="w120:serviceCompany"       mode="copy-element"/>
	<xsl:apply-templates select="w120:runNumber"            mode="copy-element"/>
	<xsl:apply-templates select="w120:creationDate"         mode="copy-element"/>
	<xsl:call-template                                      name="logHeader-description-Forward"/>
	<xsl:apply-templates select="w120:indexType"            mode="convert-enumeration-element">
		<xsl:with-param name="typeName">LogIndexType</xsl:with-param>
	</xsl:apply-templates>
	<xsl:call-template                                      name="startIndex-Header-Forward"/>
	<!-- endIndex was handled with startIndex. -->
	<xsl:apply-templates select="w120:direction"            mode="convert-enumeration-element">
		<xsl:with-param name="typeName">LogIndexDirection</xsl:with-param>
	</xsl:apply-templates>
	<xsl:apply-templates select="w120:indexCurve"           mode="Forward"/>
	<!-- stepIncrement was handled with startIndex. -->
	<!-- indexUnits moved to become a uom attribute. -->
	<xsl:apply-templates select="w120:nullValue"            mode="copy-element"/>
	<!-- uomNamingSystem was deleted. -->
	<xsl:apply-templates select="w120:logHeaderParam"       mode="rename-indexedObject">
		<xsl:with-param name="newName">logParam</xsl:with-param>
	</xsl:apply-templates>
	<!-- otherData was moved to description. -->
	<xsl:apply-templates select="w120:logCurveInfo"         mode="Forward"/>
</xsl:template>

<xsl:template match="w120:logData" mode="Forward">
	<xsl:element name="logData" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:data"               mode="copy-element"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:logCurveInfo" mode="Forward">
	<xsl:element name="logCurveInfo" namespace="{$newNameSpace}">
		<xsl:attribute name="uid">
			<xsl:if test="$retainEmpty='NO'"><xsl:value-of select="position()"/></xsl:if>
		</xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:mnemonic"           mode="copy-element"/>
		<xsl:apply-templates select="w120:classPOSC"          mode="rename-classWitsml">
			<xsl:with-param name="newName">classWitsml</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:unit"               mode="copy-element"/>
		<xsl:apply-templates select="w120:mnemAlias"          mode="copy-element"/>
		<xsl:apply-templates select="w120:nullValue"          mode="copy-element"/>
		<xsl:call-template                                    name="startIndex-Curve-Forward"/>
		<xsl:apply-templates select="w120:columnIndex"        mode="copy-element"/>
		<xsl:apply-templates select="w120:curveDescription"   mode="copy-element"/>
		<xsl:apply-templates select="w120:sensorOffset"       mode="copy-measure"/>
		<xsl:apply-templates select="w120:traceState"         mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogTraceState</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:typeLogData"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogDataType</xsl:with-param>
		</xsl:apply-templates>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="logHeader-description-Forward">
	<!-- otherData was combined into description. -->
	<xsl:variable name="desc">
		<xsl:value-of select="normalize-space(w120:description)"/>
	</xsl:variable>
	<xsl:variable name="other">
		<xsl:if test="normalize-space(w120:otherData)!=''">
			<xsl:if test="normalize-space(w120:description)!=''"><xsl:text> </xsl:text></xsl:if>
			<xsl:value-of select="normalize-space(w120:otherData)"/>
		</xsl:if>
	</xsl:variable>
	<xsl:variable name="spacer">
		<xsl:if test="normalize-space(w120:otherData)!=''">
			<xsl:if test="normalize-space(w120:description)!=''"><xsl:text> -- </xsl:text></xsl:if>
		</xsl:if>
	</xsl:variable>
	<xsl:variable name="combo"><xsl:value-of select="normalize-space($desc)"/><xsl:value-of select="$spacer"/><xsl:value-of select="normalize-space($other)"/></xsl:variable>
	<xsl:if test="w120:description or w120:otherData">
		<xsl:call-template                                         name="create-element">
			<xsl:with-param name="name">description</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$combo"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:indexCurve" mode="Forward">
	<!-- This assumes that indexCurve is always specified. --> 
	<xsl:variable name="mne"><xsl:value-of select="normalize-space(.)"/></xsl:variable>
	<xsl:variable name="count">
		<xsl:for-each select="../w120:logCurveInfo">
			<xsl:if test="w120:mnemonic = $mne"><xsl:value-of select="position()"/></xsl:if>
		</xsl:for-each>
	</xsl:variable>
	<xsl:element name="indexCurve" namespace="{$newNameSpace}">
		<xsl:attribute name="columnIndex">
			<xsl:if test="$retainEmpty='NO'"><xsl:value-of select="$count"/></xsl:if>
		</xsl:attribute>
		<xsl:value-of select="normalize-space(.)"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="startIndex-Header-Forward">
	<xsl:if test="w120:startIndex">
		<xsl:choose>
			<xsl:when test="w120:indexType='DateTime'">
				<xsl:apply-templates select="w120:startIndex"     mode="rename-element">
					<xsl:with-param name="newName">startDateTimeIndex</xsl:with-param>
				</xsl:apply-templates>
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template                                name="create-measure">
					<xsl:with-param name="name">startIndex</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:indexUnits"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="w120:startIndex"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
	<xsl:if test="w120:endIndex">
		<xsl:choose>
			<xsl:when test="w120:indexType='DateTime'">
				<xsl:apply-templates select="w120:endIndex"       mode="rename-element">
					<xsl:with-param name="newName">endDateTimeIndex</xsl:with-param>
				</xsl:apply-templates>
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template                                name="create-measure">
					<xsl:with-param name="name">endIndex</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:indexUnits"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="w120:endIndex"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
	<xsl:if test="w120:stepIncrement">
		<xsl:call-template                                                name="create-measure">
			<xsl:with-param name="name">stepIncrement</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:indexUnits"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:stepIncrement"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
	</xsl:if>
</xsl:template>

<xsl:template name="startIndex-Curve-Forward">
	<!-- We are still in the context of logCurveInfo. -->
	<!-- This is used for both log and wellLog as a target. --> 
	<xsl:if test="w120:startIndex">
		<xsl:choose>
			<xsl:when test="w120:indexType='DateTime'">
				<xsl:apply-templates select="w120:startIndex"        mode="rename-element">
					<xsl:with-param name="newName">minDateTimeIndex</xsl:with-param>
				</xsl:apply-templates>
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template                                   name="create-measure">
					<xsl:with-param name="name">minIndex</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:unit"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="w120:startIndex"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
	<xsl:if test="w120:endIndex">
		<xsl:choose>
			<xsl:when test="w120:indexType='DateTime'">
				<xsl:apply-templates select="w120:endIndex"          mode="rename-element">
					<xsl:with-param name="newName">maxDateTimeIndex</xsl:with-param>
				</xsl:apply-templates>
			</xsl:when>
			<xsl:otherwise>
				<xsl:call-template                                   name="create-measure">
					<xsl:with-param name="name">maxIndex</xsl:with-param>
					<xsl:with-param name="unit"><xsl:value-of select="w120:unit"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="w120:endIndex"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</xsl:template>



<!-- ======================================================================================== -->
<!-- ======= Templates specific to the TRAJECTORY and TRAJECTORYSTATION objects. ============ -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->


<xsl:template name="trajectory-Forward">
	<xsl:element name="trajectory" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidTraj)"/></xsl:attribute>
		<!-- uidSource moved to commonData/sourceName. -->
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:nameWell"           mode="copy-element"/>
		<xsl:apply-templates select="w120:nameWellbore"       mode="copy-element"/>
		<xsl:apply-templates select="w120:nameTraj"           mode="rename-element">
			<xsl:with-param name="newName">name</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                    name="parentTrajectory-Forward"/>
		<xsl:apply-templates select="w120:dTimTrajStart"      mode="copy-element"/>
		<xsl:apply-templates select="w120:dTimTrajEnd"        mode="copy-element"/>
		<xsl:apply-templates select="w120:mdMn"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:mdMx"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:serviceCompany"     mode="copy-element"/>
		<xsl:apply-templates select="w120:magDeclUsed"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:gridCorUsed"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:aziVertSect"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:dispNsVertSectOrig" mode="copy-measure"/>
		<xsl:apply-templates select="w120:dispEwVertSectOrig" mode="copy-measure"/>
		<xsl:apply-templates select="w120:definitive"         mode="copy-element"/>
		<xsl:apply-templates select="w120:memory"             mode="copy-element"/>
		<xsl:apply-templates select="w120:finalTraj"          mode="copy-element"/>
		<xsl:apply-templates select="w120:aziRef"             mode="convert-enumeration-element">
			<xsl:with-param name="typeName">AziRef</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:trajectoryStation"  mode="Forward"/>
		<xsl:apply-templates select="w120:commonData"         mode="Forward"/>
		<xsl:apply-templates select="w120:customData"         mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="trajectoryStation-Object-Forward">
	<xsl:element name="trajectoryStation" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<xsl:attribute name="uidTrajectory"><xsl:value-of select="normalize-space(@uidTraj)"/></xsl:attribute>
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidTrajStn)"/></xsl:attribute>
		<!-- uidSource moved to commonData/sourceName. -->
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:nameWell"           mode="copy-element"/>
		<xsl:apply-templates select="w120:nameWellbore"       mode="copy-element"/>
		<xsl:apply-templates select="w120:nameTraj"           mode="rename-element">
			<xsl:with-param name="newName">nameTrajectory</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                    name="groupTrajectoryStation-Forward"/>
		<xsl:apply-templates select="w120:commonData"         mode="Forward"/>
		<xsl:apply-templates select="w120:customData"         mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="parentTrajectory-Forward">
	<!-- We must combine separate name and uid elements into one element inside a container. -->
	<!-- We are still within the context of trajectory. -->
	<xsl:if test="w120:uidTrajParent and w120:nameTrajParent">
		<xsl:element name="parentTrajectory" namespace="{$newNameSpace}">
			<xsl:call-template name="linebreak"/>
			<xsl:element name="trajectoryReference" namespace="{$newNameSpace}">
				<xsl:attribute name="uidRef"><xsl:value-of select="normalize-space(w120:uidTrajParent)"/></xsl:attribute>
				<xsl:value-of select="normalize-space(w120:nameTrajParent)"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:trajectoryStation" mode="Forward">
	<xsl:element name="trajectoryStation" namespace="{$newNameSpace}">
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidTrajStn)"/></xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:call-template                                 name="groupTrajectoryStation-Forward"/>
		<xsl:apply-templates select="w120:commonData"      mode="Forward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<xsl:template name="groupTrajectoryStation-Forward">
	<!-- uidTarget is handled in nameTarget. -->
	<xsl:call-template                                         name="nameTarget-Forward"/>
	<xsl:apply-templates select="w120:dTimStn"                 mode="copy-element"/>
	<xsl:apply-templates select="w120:typeTrajStation"         mode="convert-enumeration-element">
		<xsl:with-param name="typeName">TrajStationType</xsl:with-param>
	</xsl:apply-templates>
	<xsl:apply-templates select="w120:md"                      mode="copy-measure"/>
	<xsl:apply-templates select="w120:tvd"                     mode="copy-measure"/>
	<xsl:apply-templates select="w120:incl"                    mode="copy-measure"/>
	<xsl:apply-templates select="w120:azi"                     mode="copy-measure"/>
	<xsl:apply-templates select="w120:mtf"                     mode="copy-measure"/>
	<xsl:apply-templates select="w120:gtf"                     mode="copy-measure"/>
	<xsl:apply-templates select="w120:dispNs"                  mode="copy-measure"/>
	<xsl:apply-templates select="w120:dispEw"                  mode="copy-measure"/>
	<xsl:apply-templates select="w120:vertSect"                mode="copy-measure"/>
	<xsl:apply-templates select="w120:dls"                     mode="copy-measure"/>
	<xsl:apply-templates select="w120:rateTurn"                mode="copy-measure"/>
	<xsl:apply-templates select="w120:rateBuild"               mode="copy-measure"/>
	<xsl:apply-templates select="w120:mdDelta"                 mode="copy-measure"/>
	<xsl:apply-templates select="w120:tvdDelta"                mode="copy-measure"/>
	<xsl:apply-templates select="w120:modelToolError"          mode="copy-element"/>
	<xsl:apply-templates select="w120:gravTotalUncert"         mode="copy-measure"/>
	<xsl:apply-templates select="w120:dipAngleUncert"          mode="copy-measure"/>
	<xsl:apply-templates select="w120:magTotalUncert"          mode="copy-measure"/>
	<xsl:apply-templates select="w120:gravAccelCorUsed"        mode="copy-element"/>
	<xsl:apply-templates select="w120:magXAxialCorUsed"        mode="copy-element"/>
	<xsl:apply-templates select="w120:sagCorUsed"              mode="copy-element"/>
	<xsl:apply-templates select="w120:magDrlstrCorUsed"        mode="copy-element"/>
	<xsl:apply-templates select="w120:gravTotalFieldReference" mode="copy-measure"/>
	<xsl:apply-templates select="w120:magTotalFieldReference"  mode="copy-measure"/>
	<xsl:apply-templates select="w120:magDipAngleReference"    mode="copy-measure"/>
	<xsl:apply-templates select="w120:magModelUsed"            mode="copy-element"/>
	<xsl:apply-templates select="w120:magModelValid"           mode="copy-element"/>
	<xsl:apply-templates select="w120:geoModelUsed"            mode="copy-element"/>
	<xsl:apply-templates select="w120:statusTrajStation"       mode="convert-enumeration-element">
		<xsl:with-param name="typeName">TrajStationStatus</xsl:with-param>
	</xsl:apply-templates>
	<xsl:apply-templates select="w120:rawData"                 mode="copy-all"/>
	<xsl:apply-templates select="w120:corUsed"                 mode="copy-all"/>
	<xsl:apply-templates select="w120:valid"                   mode="copy-all"/>
	<xsl:apply-templates select="w120:matrixCov"               mode="Forward"/>
	<xsl:apply-templates select="w120:location"                mode="location-Forward">
		<xsl:with-param name="newName">location</xsl:with-param>
	</xsl:apply-templates>
</xsl:template>

<xsl:template name="nameTarget-Forward">
	<!-- Combine two elements into one element with one attribute. -->
	<xsl:variable name="uidVal">
		<xsl:choose>
			<xsl:when test="w120:uidTarget!=''">
				<xsl:value-of select="normalize-space(w120:uidTarget)"/>
			</xsl:when>
			<xsl:when test="w120:uidTarget='' and $retainEmpty='YES'"></xsl:when>
			<xsl:otherwise>UNKNOWN-VALUE</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="nameVal">
		<xsl:choose>
			<xsl:when test="w120:nameTarget!=''">
				<xsl:value-of select="normalize-space(w120:nameTarget)"/>
			</xsl:when>
			<xsl:when test="w120:nameTarget='' and $retainEmpty='YES'"></xsl:when>
			<xsl:otherwise>UNKNOWN-VALUE</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:choose>
		<!-- At least one value must be known. -->
		<xsl:when test="$nameVal!='UNKNOWN-VALUE'">
			<xsl:element name="target" namespace="{$newNameSpace}">
				<xsl:attribute name="uidRef"><xsl:value-of select="$uidVal"/></xsl:attribute>
				<xsl:value-of select="$nameVal"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:when>
		<xsl:when test="$uidVal!='UNKNOWN-VALUE'">
			<xsl:element name="target" namespace="{$newNameSpace}">
				<xsl:attribute name="uidRef"><xsl:value-of select="$uidVal"/></xsl:attribute>
				<xsl:value-of select="$nameVal"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:when>
	</xsl:choose>
</xsl:template>

<xsl:template match="w120:matrixCov" mode="Forward">
	<xsl:element name="matrixCov" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:varNN"    mode="rename-measure">
			<xsl:with-param name="newName">varianceNN</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:varNE"    mode="rename-measure">
			<xsl:with-param name="newName">varianceNE</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:varNV"    mode="rename-measure">
			<xsl:with-param name="newName">varianceNVert</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:varEE"    mode="rename-measure">
			<xsl:with-param name="newName">varianceEE</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:varEV"    mode="rename-measure">
			<xsl:with-param name="newName">varianceEVert</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:varVV"    mode="rename-measure">
			<xsl:with-param name="newName">varianceVertVert</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:biasN"    mode="copy-measure"/>
		<xsl:apply-templates select="w120:biasE"    mode="copy-measure"/>
		<xsl:apply-templates select="w120:biasV"    mode="rename-measure">
			<xsl:with-param name="newName">biasVert</xsl:with-param>
		</xsl:apply-templates>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>




<!-- ======================================================================================== -->
<!-- ==================== Templates specific to the WELLBORE object. ======================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="wellbore-Forward">
	<xsl:element name="wellbore" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<!-- uidSource moved to commonData/sourceName. -->
			<xsl:call-template name="linebreak"/>
			<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:nameWell"          mode="copy-element"/>
		<xsl:apply-templates select="w120:nameWellbore"      mode="rename-element">
			<xsl:with-param name="newName">name</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                   name="parentWellbore-Forward"/>
		<xsl:apply-templates select="w120:number"            mode="copy-element"/>
		<xsl:apply-templates select="w120:suffixAPI"         mode="copy-element"/>
		<xsl:apply-templates select="w120:numGovt"           mode="copy-element"/>
		<xsl:apply-templates select="w120:statusWellbore"    mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellStatus</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:purposeWellbore"   mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellPurpose</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:typeWellbore"      mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellboreType</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:shape"             mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellboreShape</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:dTimKickoff"       mode="copy-element"/>
		<xsl:apply-templates select="w120:mdCurrent"         mode="copy-measure"/>
		<xsl:apply-templates select="w120:tvdCurrent"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:mdKickoff"         mode="copy-measure"/>
		<xsl:apply-templates select="w120:tvdKickoff"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:mdPlanned"         mode="copy-measure"/>
		<xsl:apply-templates select="w120:tvdPlanned"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:mdSubSeaPlanned"   mode="copy-measure"/>
		<xsl:apply-templates select="w120:tvdSubSeaPlanned"  mode="copy-measure"/>
		<xsl:apply-templates select="w120:dayTarget"         mode="copy-measure"/>
		<xsl:apply-templates select="w120:commonData"        mode="Forward"/>
		<xsl:apply-templates select="w120:customData"        mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="parentWellbore-Forward">
	<!-- We must combine separate name and uid elements into one elelent. -->
	<xsl:variable name="uidVal">
		<xsl:choose>
			<xsl:when test="w120:uidParentWellbore!=''">
				<xsl:value-of select="normalize-space(w120:uidParentWellbore)"/>
			</xsl:when>
			<xsl:when test="w120:uidParentWellbore='' and $retainEmpty='YES'"></xsl:when>
			<xsl:otherwise>UNKNOWN-VALUE</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="nameVal">
		<xsl:choose>
			<xsl:when test="w120:nameParentWellbore!=''">
				<xsl:value-of select="normalize-space(w120:nameParentWellbore)"/>
			</xsl:when>
			<xsl:when test="w120:nameParentWellbore='' and $retainEmpty='YES'"></xsl:when>
			<xsl:otherwise>UNKNOWN-VALUE</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:choose>
		<!-- At least one value must be known. -->
		<xsl:when test="$nameVal!='UNKNOWN-VALUE'">
			<xsl:element name="parentWellbore" namespace="{$newNameSpace}">
				<xsl:attribute name="uidRef"><xsl:value-of select="$uidVal"/></xsl:attribute>
				<xsl:value-of select="$nameVal"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:when>
		<xsl:when test="$uidVal!='UNKNOWN-VALUE'">
			<xsl:element name="parentWellbore" namespace="{$newNameSpace}">
				<xsl:attribute name="uidRef"><xsl:value-of select="$uidVal"/></xsl:attribute>
				<xsl:value-of select="$nameVal"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:when>
	</xsl:choose>
</xsl:template>



<!-- ======================================================================================== -->
<!-- ====================== Templates specific to the WELL object. ========================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="well-Forward">
	<xsl:element name="well" namespace="{$newNameSpace}">
		<xsl:attribute name="uid"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<!-- uidSource moved to commonData/sourceName. -->
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:nameWell"          mode="rename-element">
			<xsl:with-param name="newName">name</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:nameLegal"         mode="copy-element"/>
		<xsl:apply-templates select="w120:numLicense"        mode="copy-element"/>
		<xsl:apply-templates select="w120:numGovt"           mode="copy-element"/>
		<xsl:apply-templates select="w120:dTimLicense"       mode="copy-element"/>
		<xsl:apply-templates select="w120:field"             mode="copy-element"/>
		<xsl:apply-templates select="w120:country"           mode="copy-element"/>
		<xsl:apply-templates select="w120:state"             mode="copy-element"/>
		<xsl:apply-templates select="w120:county"            mode="copy-element"/>
		<xsl:apply-templates select="w120:region"            mode="copy-element"/>
		<xsl:apply-templates select="w120:district"          mode="copy-element"/>
		<xsl:apply-templates select="w120:block"             mode="copy-element"/>
		<xsl:apply-templates select="w120:timeZone"          mode="Forward"/>
		<xsl:apply-templates select="w120:operator"          mode="copy-element"/>
		<xsl:apply-templates select="w120:operatorDiv"       mode="copy-element"/>
		<xsl:apply-templates select="w120:pcInterest"        mode="percent-Forward"/>
		<xsl:apply-templates select="w120:numAPI"            mode="copy-element"/>
		<xsl:apply-templates select="w120:statusWell"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellStatus</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:purposeWell"       mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellPurpose</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:dTimSpud"          mode="copy-element"/>
		<xsl:apply-templates select="w120:dTimPa"            mode="copy-element"/>
		<!-- dtmPermToWellhead is defined by the wellDatum template.-->
		<!-- dtmPermanent moved to wellDatum/code-->
		<xsl:call-template                                   name="wellDatum-Forward" />
		<xsl:apply-templates select="w120:groundElevation"   mode="Forward"/>
		<xsl:apply-templates select="w120:waterDepth"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:location"          mode="location-Forward">
			<xsl:with-param name="newName">wellLocation</xsl:with-param>
		</xsl:apply-templates>
		 <!-- cartographicProjection moved to wellCRS-->
		<xsl:call-template                                   name="wellCRS-Forward" />
		<xsl:apply-templates select="w120:commonData"        mode="Forward"/>
		<xsl:apply-templates select="w120:customData"        mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="wellCRS-Forward">
	<xsl:if test="w120:cartographicProjection">
		<xsl:if test=".//w120:mapProjection">
			<xsl:element name="wellCRS" namespace="{$newNameSpace}">
				<!-- The name and uid must match those used in location. --> 
				<xsl:attribute name="uid">
					<xsl:if test="$retainEmpty='NO'">projected</xsl:if>
				</xsl:attribute>
				<xsl:call-template name="linebreak"/>
				<xsl:apply-templates select="w120:cartographicProjection/child::comment()" mode="copy-all"/>
				<xsl:element name="name" namespace="{$newNameSpace}">
					<xsl:choose>
						<xsl:when test=".//w120:mapProjection/w120:nameProj='' and $retainEmpty='YES'"/>
						<xsl:when test=".//w120:mapProjection/w120:nameProj">
							<xsl:value-of select="normalize-space(.//w120:mapProjection/w120:nameProj)"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:value-of select="normalize-space(.//w120:mapProjection/w120:projectionCode)"/>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:element>
				<xsl:call-template name="linebreak"/>
				<xsl:apply-templates select=".//w120:mapProjection" mode="Forward"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:if>
		<xsl:if test=".//w120:geodeticModel">
			<xsl:element name="wellCRS" namespace="{$newNameSpace}">
				<!-- The name and uid must match those used in location. -->  
				<xsl:attribute name="uid">
					<xsl:if test="$retainEmpty='NO'">geographic</xsl:if>
				</xsl:attribute>
				<xsl:call-template name="linebreak"/>
				<xsl:apply-templates select="w120:cartographicProjection/child::comment()" mode="copy-all"/>
				<xsl:element name="name" namespace="{$newNameSpace}">
					<xsl:choose>
						<xsl:when test=".//w120:geodeticModel/w120:geodeticDatumName='' and $retainEmpty='YES'"/>
						<xsl:when test=".//w120:geodeticModel/w120:geodeticDatumName">
							<xsl:value-of select="normalize-space(.//w120:geodeticModel/w120:geodeticDatumName)"/>
						</xsl:when>
						<xsl:otherwise>
							<xsl:call-template name="convert-enum-value">
								<xsl:with-param name="typeName">GeodeticDatum</xsl:with-param>
								<xsl:with-param name="value"><xsl:value-of select=".//w120:geodeticModel/w120:geodeticDatumCode"/></xsl:with-param>
							</xsl:call-template>
						</xsl:otherwise>
					</xsl:choose>
				</xsl:element>
				<xsl:call-template name="linebreak"/>
				<xsl:apply-templates select=".//w120:geodeticModel" mode="Forward"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:mapProjection" mode="Forward">
	<xsl:element name="mapProjection" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:projectionCode"    mode="convert-enumeration-element">
			<xsl:with-param name="typeName">Projection</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:stdParallel1"      mode="copy-measure"/>
		<xsl:apply-templates select="w120:stdParallel2"      mode="copy-measure"/>
		<xsl:apply-templates select="w120:centralMeridian"   mode="copy-measure"/>
		<xsl:apply-templates select="w120:originLatitude"    mode="copy-measure"/>
		<xsl:apply-templates select="w120:originLongitude"   mode="copy-measure"/>
		<xsl:apply-templates select="w120:latitude1"         mode="copy-measure"/>
		<xsl:apply-templates select="w120:longitude1"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:latitude2"         mode="copy-measure"/>
		<xsl:apply-templates select="w120:longitude2"        mode="copy-measure"/>
		<xsl:apply-templates select="w120:latitudeForScale"  mode="copy-measure"/>
		<xsl:apply-templates select="w120:longitudeForScale" mode="copy-measure"/>
		<xsl:apply-templates select="w120:trueScaleLatitude" mode="copy-measure"/>
		<xsl:apply-templates select="w120:spheroidRadius"    mode="copy-measure"/>
		<xsl:apply-templates select="w120:scaleFactor"       mode="unitless-Forward"/>
		<xsl:apply-templates select="w120:methodVariant"     mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ProjectionVariantsObliqueMercator</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:perspectiveHeight" mode="copy-measure"/>
		<xsl:apply-templates select="w120:zone"              mode="Forward"/>
		<xsl:apply-templates select="w120:NADType"           mode="convert-enumeration-element">
			<xsl:with-param name="typeName">NADTypes</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:falseEasting"      mode="copy-measure"/>
		<xsl:apply-templates select="w120:falseNorthing"     mode="copy-measure"/>
		<xsl:apply-templates select="w120:bearing"           mode="copy-measure"/>
		<xsl:apply-templates select="w120:hemisphere"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">Hemispheres</xsl:with-param>
		</xsl:apply-templates>
		<!-- nameProj moved to wellCRS/name. --> 
		<xsl:apply-templates select="w120:description"       mode="copy-element"/>
		<xsl:apply-templates select="w120:parameter"         mode="copy-indexedObject"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:geodeticModel" mode="Forward">
	<xsl:element name="geographic" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w120:geodeticDatumCode"          mode="convert-enumeration-element">
			<xsl:with-param name="typeName">GeodeticDatum</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:xTranslation"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:yTranslation"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:zTranslation"               mode="copy-measure"/>
		<xsl:apply-templates select="w120:xRotation"                  mode="copy-measure"/>
		<xsl:apply-templates select="w120:yRotation"                  mode="copy-measure"/>
		<xsl:apply-templates select="w120:zRotation"                  mode="copy-measure"/>
		<xsl:apply-templates select="w120:scaleFactor"                mode="unitless-Forward"/>
		<xsl:apply-templates select="w120:ellipsoidCode"              mode="convert-enumeration-element">
			<xsl:with-param name="typeName">Ellipsoid</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:ellipsoidSemiMajorAxis"     mode="copy-measure"/>
		<xsl:apply-templates select="w120:ellipsoidInverseFlattening" mode="unitless-Forward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w120:zone" mode="Forward">
	<!-- The geodetic zone values now have a letter to indicate the direction instead of a sign. --> 
	<xsl:if test="normalize-space(.)!='' or $retainEmpty='YES'">
		<xsl:element name="{name(.)}" namespace="{$newNameSpace}">
			<xsl:choose>
				<xsl:when test="normalize-space(.)='' and $retainEmpty='YES'"/>
				<xsl:when test=". > 0"><xsl:value-of select="normalize-space(.)"/>N</xsl:when>
				<xsl:otherwise><xsl:value-of select="number(.) * -1"/>S</xsl:otherwise>
			</xsl:choose>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:groundElevation" mode="Forward">
	<!-- The v120 ground elevation is specifically with respect to mean sea level. --> 
	<!-- The wellDatum template will create a sea level datum. --> 
	<xsl:call-template                                              name="create-coordinate">
		<xsl:with-param name="name"><xsl:value-of select="name(.)"/></xsl:with-param>
		<xsl:with-param name="unit"><xsl:value-of select="@uom"/></xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="datum"><xsl:if test=".='' and $retainEmpty='NO'">SL</xsl:if></xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template name="wellDatum-Forward">
	<!-- If dtmPermanent was given then we know the datum for dtmPermToWellhead 
		but we really do not know the other datums except for groundElevation (SL). -->
	<xsl:variable name="dtmPermanent">
		<xsl:call-template                                      name="convert-enum-value">
			<xsl:with-param name="typeName">PermanentDatum</xsl:with-param>
			<xsl:with-param name="value">
				<xsl:value-of select="w120:dtmPermanent"/>
			</xsl:with-param>
		</xsl:call-template>
	</xsl:variable>
	<xsl:variable name="code">
		<xsl:choose>
			<xsl:when test="$dtmPermanent!='' or $retainEmpty='YES'"><xsl:value-of select="$dtmPermanent"/></xsl:when>
			<xsl:otherwise>permanent-datum</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:if test="w120:dtmPermToWellhead">
		<!-- The datum is defined by dtmPermanent. -->
		<xsl:call-template                                      name="create-coordinate">
			<xsl:with-param name="name">wellheadElevation</xsl:with-param>
			<xsl:with-param name="unit"><xsl:value-of select="w120:dtmPermToWellhead/@uom"/></xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="w120:dtmPermToWellhead"/></xsl:with-param>
			<xsl:with-param name="datum"><xsl:value-of select="$code"/></xsl:with-param>
		</xsl:call-template>
	</xsl:if>
	<xsl:if test="$dtmPermanent!=''">
		<xsl:element name="wellDatum" namespace="{$newNameSpace}">
			<xsl:attribute name="uid">
				<xsl:if test="$retainEmpty='NO'"><xsl:value-of select="$code"/></xsl:if>
			</xsl:attribute>
			<xsl:call-template name="linebreak"/>
			<xsl:call-template                                          name="create-element">
				<xsl:with-param name="name">name</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="$dtmPermanent"/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
			<xsl:call-template                                          name="create-element">
				<xsl:with-param name="name">code</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="$code"/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
	<xsl:if test="w120:groundElevation">
		<!-- Ground elevation requires a datum of mean sea level. -->
		<xsl:if test="$code!='SL'">
			<xsl:element name="wellDatum" namespace="{$newNameSpace}">
				<xsl:attribute name="uid"><xsl:if test="w120:groundElevation='' and $retainEmpty='NO'">SL</xsl:if></xsl:attribute>
				<xsl:call-template name="linebreak"/>
				<xsl:call-template                                        name="create-element">
					<xsl:with-param name="name">name</xsl:with-param>
					<xsl:with-param name="value"><xsl:if test="w120:groundElevation='' and $retainEmpty='NO'">Mean Sea Level</xsl:if></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template                                        name="create-element">
					<xsl:with-param name="name">code</xsl:with-param>
					<xsl:with-param name="value"><xsl:if test="w120:groundElevation='' and $retainEmpty='NO'">SL</xsl:if></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:timeZone" mode="Forward">
	<!-- The timezone has been constrained to an offset from GMT. --> 
	<xsl:if test="normalize-space(.)!='' or $retainEmpty='YES'">
		<xsl:element name="{name(.)}" namespace="{$newNameSpace}">
			<xsl:choose>
				<xsl:when test=". = 'EST'">-05:00</xsl:when>
				<xsl:when test=". = 'CST'">-06:00</xsl:when>
				<xsl:when test=". = 'MST'">-07:00</xsl:when>
				<xsl:when test=". = 'PST'">-08:00</xsl:when>
				<xsl:otherwise><xsl:value-of select="normalize-space(.)"/></xsl:otherwise>
			</xsl:choose>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>


<!-- ======================================================================================== -->
<!-- ========================= Non-Object specific templates ================================ -->
<!-- =================== These templates are direction specific. ============================ -->
<!-- ======================================================================================== -->

<xsl:template name="documentInfo-Forward">
	<xsl:element name="documentInfo" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="create-element">
			<xsl:with-param name="name">DocumentName</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$object"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:if test=".//w120:commonData/w120:dTimStamp or .//w120:commonData/w120:nameSource">
			<xsl:variable name="dTimStampNodeSet"  select=".//w120:commonData/w120:dTimStamp"/>
			<xsl:variable name="nameSourceNodeSet" select=".//w120:commonData/w120:nameSource"/>
			<xsl:variable name="time">
				<xsl:choose>
					<xsl:when test="$dTimStampNodeSet[position()=1]">
						<xsl:value-of select="$dTimStampNodeSet[position()=1]"/>
					</xsl:when>
					<xsl:when test="$retainEmpty='YES'"/>
					<xsl:otherwise>
						<xsl:text>1900-01-01T00:00:00.000Z</xsl:text>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:variable>
			<xsl:element name="FileCreationInformation" namespace="{$newNameSpace}">
				<xsl:call-template name="linebreak"/>
				<xsl:call-template name="create-element">
					<xsl:with-param name="name">FileCreationDate</xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="$time"/></xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
				<xsl:if test=".//w120:commonData/w120:nameSource">
					<xsl:apply-templates select="$nameSourceNodeSet[position()=1]"      mode="rename-element">
						<xsl:with-param name="newName">FileCreator</xsl:with-param>
					</xsl:apply-templates>
				</xsl:if>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:if>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="*" mode="percent-Forward">
	<!-- Convert from a value with an implied unit of measure of % to a value with an explicit uom. --> 
	<xsl:call-template                                              name="create-measure">
		<xsl:with-param name="name"><xsl:value-of select="name(.)"/></xsl:with-param>
		<xsl:with-param name="unit">%</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="*" mode="unitless-Forward">
	<!-- Convert from a value that may have a unit of measure to a value without a unit. -->
	<!-- If a uom exists, convert the value to a uom of Euc. --> 
	<xsl:call-template                                              name="create-measure-without-uom">
		<xsl:with-param name="name"><xsl:value-of select="name(.)"/></xsl:with-param>
		<xsl:with-param name="oldunit"><xsl:value-of select="@uom"/></xsl:with-param>
		<xsl:with-param name="oldvalue"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="newunit">Euc</xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="*" mode="location-Forward">
	<!-- Each location pair must now be in a separate location instance. --> 
	<xsl:param name="newName"/>       <!-- The new element name. -->
	<xsl:if test="w120:latitude">
		<xsl:element name="{$newName}" namespace="{$newNameSpace}">
			<xsl:attribute name="uid">
				<xsl:if test="$retainEmpty='NO'">loc-lat</xsl:if>
			</xsl:attribute>
			<xsl:call-template name="linebreak"/>
			<xsl:call-template name="copy-comment"/>
			<xsl:apply-templates select="w120:latitude"            mode="copy-measure"/>
			<xsl:apply-templates select="w120:longitude"           mode="copy-measure"/>
			<xsl:choose>
				<xsl:when test="not(w120:inputType)"/>
				<xsl:when test="w120:inputType = 'Geographic'">
					<xsl:call-template                     name="create-element">
						<xsl:with-param name="name">original</xsl:with-param>
						<xsl:with-param name="value">true</xsl:with-param>
						<xsl:with-param name="given">YES</xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:when test="w120:inputType='' and $retainEmpty='YES'">
					<xsl:call-template                     name="create-element">
						<xsl:with-param name="name">original</xsl:with-param>
						<xsl:with-param name="value"></xsl:with-param>
						<xsl:with-param name="given">YES</xsl:with-param>
					</xsl:call-template>
				</xsl:when>
			</xsl:choose>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
	<xsl:if test="w120:xCoord">
		<xsl:element name="{$newName}" namespace="{$newNameSpace}">
			<xsl:attribute name="uid">
				<xsl:if test="$retainEmpty='NO'">loc-x</xsl:if>
			</xsl:attribute>
			<xsl:call-template name="linebreak"/>
			<xsl:call-template name="copy-comment"/>
			<xsl:apply-templates select="w120:xCoord"      mode="rename-measure">
				<xsl:with-param name="newName">projectedX</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="w120:yCoord"      mode="rename-measure">
				<xsl:with-param name="newName">projectedY</xsl:with-param>
			</xsl:apply-templates>
			<xsl:choose>
				<xsl:when test="not(w120:inputType)"/>
				<xsl:when test="w120:inputType = 'Projection'">
					<xsl:call-template                     name="create-element">
						<xsl:with-param name="name">original</xsl:with-param>
						<xsl:with-param name="value">true</xsl:with-param>
						<xsl:with-param name="given">YES</xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:when test="w120:inputType='' and $retainEmpty='YES'">
					<xsl:call-template                     name="create-element">
						<xsl:with-param name="name">original</xsl:with-param>
						<xsl:with-param name="value"></xsl:with-param>
						<xsl:with-param name="given">YES</xsl:with-param>
					</xsl:call-template>
				</xsl:when>
			</xsl:choose>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="w120:commonData" mode="Forward">
	<xsl:element name="commonData" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="../@uidSource"         mode="create-element">
			<xsl:with-param name="name">sourceName</xsl:with-param>
		</xsl:apply-templates>
		<!-- dTimStamp and nameSource moved to DocumentInfo. -->
		<xsl:apply-templates select="w120:dTimCreation"     mode="copy-element"/>
		<xsl:apply-templates select="w120:dTimLastChange"   mode="copy-element"/>
		<xsl:apply-templates select="w120:itemState"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ItemState</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w120:comments"         mode="copy-element"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!--                           Templates for BACKWARD conversion.                             -->
<!--                       These templates are direction specific.                            -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->


<!-- ======================================================================================== -->
<!-- ==================== Templates specific to the REALTIME object. ======================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="realtime-Backward">
	<xsl:element name="realtime" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"                              mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="$realtimeHeaderSet/w131:nameWell"             mode="copy-element"/>
		<xsl:apply-templates select="$realtimeHeaderSet/w131:nameWellbore"         mode="copy-element"/>
		<xsl:apply-templates select="w131:dTim"                                    mode="copy-element"/>
		<xsl:call-template                                                         name="realtime-md-Backward"/>
		<xsl:call-template                                                         name="activityCode-realtime-Backward"/>
		<!-- activitySubcode is handled with activityCode. -->
		<xsl:apply-templates select="w131:channel"                                 mode="channel-Backward"/>
		<xsl:apply-templates select="w131:record"                                  mode="record-Backward"/>
		<xsl:apply-templates select="w131:commonData"                              mode="Backward"/>
		<xsl:apply-templates select="w131:customData"                              mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="realtime-md-Backward">
	<!-- We are still within the context of realtime. -->
	<xsl:choose>
		<xsl:when test="w131:md">
			<xsl:apply-templates select="w131:md"                               mode="copy-measure"/>
		</xsl:when>
		<xsl:when test="w131:record/w131:md">
			<!-- Copy the md from a record. We need the uom in realtime. -->
			<xsl:apply-templates select="w131:record/w131:md"                   mode="copy-measure"/>
		</xsl:when>
	</xsl:choose>
</xsl:template>

<xsl:template match="w131:record" mode="record-Backward">
	<xsl:call-template                                                         name="record-Backward-next-channel">
		<xsl:with-param name="firstCall">true</xsl:with-param>
		<xsl:with-param name="string"><xsl:value-of select="normalize-space(w131:value)"/></xsl:with-param>
		<xsl:with-param name="index">1</xsl:with-param>
	</xsl:call-template>
</xsl:template>


<xsl:template name="record-Backward-next-channel">
	<!-- Recursive template to find the next value in a comma delimited record value
	     and create the corresponding channel element. -->
	<!-- We are still within the context of record. -->
	<xsl:param name="firstCall"></xsl:param> <!-- true indicates the first call. -->
	<xsl:param name="string"></xsl:param>    <!-- The remaining comma delimited string. -->
	<xsl:param name="index">1</xsl:param>    <!-- The column index of the next column. -->
	<xsl:choose>
		<xsl:when test="$string='' and $firstCall!='true'">
			<!-- We are finished. -->
		</xsl:when>
		<xsl:otherwise>
			<!-- Do next column. -->
			<xsl:variable name="groupId">
				<xsl:value-of select="w131:id"/>
			</xsl:variable>
			<xsl:variable name="mnemonic">
				<xsl:value-of select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:columnIndex=$index]/w131:mnemonic"/>
			</xsl:variable>
			<xsl:variable name="oldunit">
				<xsl:value-of select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:columnIndex=$index]/w131:unit"/>
			</xsl:variable>
			<xsl:variable name="oldvalue">
				<xsl:choose>
					<xsl:when test="contains($string,',')">
						<xsl:value-of select="normalize-space(substring-before($string,','))"/>
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select="$string"/>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:variable>
			<xsl:variable name="newunit">
				<xsl:variable name="substitute-Unit">
					<xsl:call-template name="unit-substitute">
						<xsl:with-param name="unit">
							<xsl:value-of select="$oldunit"/>
						</xsl:with-param>
					</xsl:call-template>
				</xsl:variable>
				<xsl:choose>
					<xsl:when test="substitute-Unit!=''">
						<!-- The old unit is not valid in the target schema. -->
						<xsl:value-of select="$substitute-Unit"/>
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select="$oldunit"/>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:variable>
			<xsl:variable name="value">
				<xsl:choose>
					<xsl:when test="$newunit!=$oldunit">
						<!-- The old unit is not valid in the target schema. Convert the record value to the new uom.-->
						<xsl:call-template                               name="unit-convert">
							<xsl:with-param name="val"><xsl:value-of select="$oldvalue"/></xsl:with-param>
							<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
							<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
						</xsl:call-template>
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select="$oldvalue"/>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:variable>
			<xsl:variable name="classWitsmlGiven">
				<xsl:if test="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:classWitsml">
					<xsl:text>YES</xsl:text>
				</xsl:if>
			</xsl:variable>
			<xsl:variable name="classWitsml">
				<xsl:call-template                                     name="convert-enum-value">
					<xsl:with-param name="typeName">RealtimeData</xsl:with-param>
					<xsl:with-param name="value">
						<xsl:value-of select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:classWitsml"/>
					</xsl:with-param>
				</xsl:call-template>
			</xsl:variable>
			<xsl:variable name="typeGiven">
				<xsl:if test="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:dataType">
					<xsl:text>YES</xsl:text>
				</xsl:if>
			</xsl:variable>
			<xsl:variable name="type">
				<xsl:call-template                                      name="convert-enum-value">
					<xsl:with-param name="typeName">DataType</xsl:with-param>
					<xsl:with-param name="value">
						<xsl:value-of select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:dataType"/>
					</xsl:with-param>
				</xsl:call-template>
			</xsl:variable>
			<xsl:element name="channel" namespace="{$newNameSpace}">
				<xsl:attribute name="mnemonic"><xsl:value-of select="$mnemonic"/></xsl:attribute>
				<xsl:if test="$classWitsmlGiven='YES'">
					<xsl:attribute name="classWitsml"><xsl:value-of select="$classWitsml"/></xsl:attribute>
				</xsl:if>
				<xsl:if test="w131:dTim">
					<xsl:attribute name="dTim"><xsl:value-of select="w131:dTim"/></xsl:attribute>
				</xsl:if>
				<xsl:attribute name="uom"><xsl:value-of select="$newunit"/></xsl:attribute>
				<xsl:if test="w131:md">
					<xsl:attribute name="md"><xsl:value-of select="w131:md"/></xsl:attribute>
				</xsl:if>
				<xsl:if test="$typeGiven='YES'">
					<xsl:attribute name="type"><xsl:value-of select="$type"/></xsl:attribute>
				</xsl:if>
				<xsl:attribute name="value"><xsl:value-of select="$value"/></xsl:attribute>
				<xsl:call-template name="linebreak"/>
				<xsl:call-template name="copy-comment"/>
				<xsl:apply-templates select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:dataSource"   mode="rename-element">
					<xsl:with-param name="newName">source</xsl:with-param>
				</xsl:apply-templates>
				<xsl:apply-templates select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:description"  mode="copy-element"/>
				<xsl:apply-templates select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:interval"     mode="interval-Backward"/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
			<xsl:call-template                                             name="record-Backward-next-channel">
				<xsl:with-param name="firstCall">false</xsl:with-param>
				<xsl:with-param name="string"><xsl:value-of select="normalize-space(substring-after($string,','))"/></xsl:with-param>
				<xsl:with-param name="index"><xsl:value-of select="$index +1"/></xsl:with-param>
			</xsl:call-template>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>

<xsl:template match="w131:channel" mode="channel-Backward">
	<xsl:variable name="groupId">
		<xsl:value-of select="w131:id"/>
	</xsl:variable>
	<xsl:variable name="mnemonic">
		<xsl:value-of select="w131:mnemonic"/>
	</xsl:variable>
	<xsl:variable name="classWitsmlGiven">
		<xsl:if test="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:classWitsml">
			<xsl:text>true</xsl:text>
		</xsl:if>
	</xsl:variable>
	<xsl:variable name="classWitsml">
		<xsl:call-template name="convert-enum-value">
			<xsl:with-param name="typeName">RealtimeData</xsl:with-param>
			<xsl:with-param name="value">
				<xsl:value-of select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:classWitsml"/>
			</xsl:with-param>
		</xsl:call-template>
	</xsl:variable>
	<xsl:variable name="typeGiven">
		<xsl:if test="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:dataType">
			<xsl:text>true</xsl:text>
		</xsl:if>
	</xsl:variable>
	<xsl:variable name="type">
		<xsl:call-template name="convert-enum-value">
			<xsl:with-param name="typeName">DataType</xsl:with-param>
			<xsl:with-param name="value">
				<xsl:value-of select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:dataType"/>
			</xsl:with-param>
		</xsl:call-template>
	</xsl:variable>
	<xsl:variable name="oldvalue">
		<xsl:value-of select="w131:value"/>
	</xsl:variable>
	<xsl:variable name="oldunit">
		<xsl:value-of select="w131:value/@uom"/>
	</xsl:variable>
	<xsl:variable name="newunit">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$oldunit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="substitute-Unit!=''">
				<!-- The old unit is not valid in the target schema. -->
				<xsl:value-of select="$substitute-Unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldunit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="value">
		<xsl:choose>
			<xsl:when test="$newunit!=$oldunit">
				<!-- The old unit is not valid in the target schema. Convert the record value to the new uom.-->
				<xsl:call-template name="unit-convert">
					<xsl:with-param name="val"><xsl:value-of select="$oldvalue"/></xsl:with-param>
					<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
					<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
				</xsl:call-template>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldvalue"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:element name="channel" namespace="{$newNameSpace}">
		<xsl:attribute name="mnemonic"><xsl:value-of select="$mnemonic"/></xsl:attribute>
		<xsl:if test="$classWitsmlGiven='true'">
			<xsl:attribute name="classWitsml"><xsl:value-of select="$classWitsml"/></xsl:attribute>
		</xsl:if>
		<xsl:if test="w131:dTim">
			<xsl:attribute name="dTim"><xsl:value-of select="w131:dTim"/></xsl:attribute>
		</xsl:if>
		<xsl:attribute name="uom"><xsl:value-of select="$newunit"/></xsl:attribute>
		<xsl:if test="w131:md!=''">
			<xsl:attribute name="md"><xsl:value-of select="w131:md"/></xsl:attribute>
		</xsl:if>
		<xsl:if test="$typeGiven='true'">
			<xsl:attribute name="type"><xsl:value-of select="$type"/></xsl:attribute>
		</xsl:if>
		<xsl:attribute name="value"><xsl:value-of select="$value"/></xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:dataSource"   mode="rename-element">
			<xsl:with-param name="newName">source</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:densData"                                                                        mode="copy-element"/> <!-- Ignores uom. -->
		<xsl:apply-templates select="w131:qualData"                                                                        mode="copy-element"/>
		<xsl:apply-templates select="w131:fet"                                                                             mode="copy-element"/> <!-- Ignores uom. -->
		<xsl:apply-templates select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:description"  mode="copy-element"/>
		<xsl:apply-templates select="$realtimeHeaderSet/w131:groupDefinition[w131:id=$groupId]/w131:channelDefinition[w131:mnemonic=$mnemonic]/w131:interval"     mode="interval-Backward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="activityCode-realtime-Backward">
	<!-- Activity code must be split into a code and a subcode. -->
	<!-- We are still within the context of realtime. -->
	<xsl:if test="w131:activityCode">
		<xsl:variable name="code">
			<xsl:choose>
				<xsl:when test="contains(w131:activityCode,' -- ')">
					<xsl:call-template name="convert-enum-value">
						<xsl:with-param name="typeName">ActivityCode</xsl:with-param>
						<xsl:with-param name="value"><xsl:value-of select="substring-before(w131:activityCode,' -- ')"/></xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:otherwise>
					<xsl:call-template name="convert-enum-value">
						<xsl:with-param name="typeName">ActivityCode</xsl:with-param>
						<xsl:with-param name="value"><xsl:value-of select="w131:activityCode"/></xsl:with-param>
					</xsl:call-template>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<xsl:variable name="sub">
			<xsl:call-template name="convert-enum-value">
				<xsl:with-param name="typeName">ActivitySubcode</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="substring-after(w131:activityCode,' -- ')"/></xsl:with-param>
			</xsl:call-template>			
		</xsl:variable>
		<xsl:call-template                                 name="create-element">
			<xsl:with-param name="name">activityCode</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$code"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:if test="$sub!=''">
			<xsl:call-template                                 name="create-element">
				<xsl:with-param name="name">activitySubcode</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="$sub"/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template match="w131:interval" mode="interval-Backward">
	<!-- Only one is allowed in the old schema. -->
	<xsl:if test="position()=1">	
		<xsl:variable name="type">
			<xsl:call-template name="convert-enum-value">
				<xsl:with-param name="typeName">IntervalType</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="normalize-space(w131:type)"/></xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:variable name="method">
			<xsl:call-template name="convert-enum-value">
				<xsl:with-param name="typeName">IntervalMethod</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="normalize-space(w131:method)"/></xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:variable name="oldvalue">
			<xsl:choose>
				<xsl:when test="w131:distanceInterval">
					<xsl:value-of select="w131:distanceInterval"/>
				</xsl:when>
				<xsl:when test="w131:timeInterval">
					<xsl:value-of select="w131:timeInterval"/>
				</xsl:when>
			</xsl:choose>
		</xsl:variable>
		<xsl:variable name="oldunit">
			<xsl:choose>
				<xsl:when test="w131:distanceInterval">
					<xsl:value-of select="w131:distanceInterval/@uom"/>
				</xsl:when>
				<xsl:when test="w131:timeInterval">
					<xsl:value-of select="w131:timeInterval/@uom"/>
				</xsl:when>
			</xsl:choose>
		</xsl:variable>
		<xsl:variable name="newunit">
			<xsl:variable name="substitute-Unit">
				<xsl:call-template name="unit-substitute">
					<xsl:with-param name="unit">
						<xsl:value-of select="$oldunit"/>
					</xsl:with-param>
				</xsl:call-template>
			</xsl:variable>
			<xsl:choose>
				<xsl:when test="substitute-Unit!=''">
					<!-- The old unit is not valid in the target schema. -->
					<xsl:value-of select="$substitute-Unit"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="$oldunit"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<xsl:variable name="value">
			<xsl:choose>
				<xsl:when test="$newunit!=$oldunit">
					<!-- The old unit is not valid in the target schema. Convert the record value to the new uom.-->
					<xsl:call-template name="unit-convert">
						<xsl:with-param name="val"><xsl:value-of select="$oldvalue"/></xsl:with-param>
						<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="$oldvalue"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<!-- If a value is not defined, then create a null attribute name. This is a trick to prevent the attribute from being created. -->
		<xsl:element name="interval" namespace="{$newNameSpace}">
			<xsl:attribute name="type"><xsl:value-of select="$type"/></xsl:attribute>
			<xsl:if test="w131:method">
				<xsl:attribute name="method"><xsl:value-of select="$method"/></xsl:attribute>
			</xsl:if>
			<xsl:if test="w131:distanceInterval or w131:timeInterval">
				<xsl:attribute name="uom"><xsl:value-of select="$newunit"/></xsl:attribute>
				<xsl:attribute name="value"><xsl:value-of select="$value"/></xsl:attribute>
			</xsl:if>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>



<!-- ======================================================================================== -->
<!-- ==================== Templates specific to the MUDLOG object. ========================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="mudLog-Backward">
	<xsl:element name="mudLog" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(@uidWell)"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(@uidWellbore)"/></xsl:attribute>
		<xsl:attribute name="uidMudLog"><xsl:value-of select="normalize-space(@uid)"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"      mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:nameWell"           mode="copy-element"/>
		<xsl:apply-templates select="w131:nameWellbore"       mode="copy-element"/>
		<xsl:apply-templates select="w131:name"               mode="rename-element">
			<xsl:with-param name="newName">nameMudLog</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:dTim"               mode="copy-element"/>
		<xsl:apply-templates select="w131:mudLogCompany"      mode="copy-element"/>
		<xsl:apply-templates select="w131:mudLogEngineers"    mode="copy-element"/>
		<xsl:apply-templates select="w131:startMd"            mode="copy-measure"/>
		<xsl:apply-templates select="w131:endMd"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:geologyInterval"    mode="Backward"/>
		<xsl:apply-templates select="w131:commonData"         mode="Backward"/>
		<xsl:apply-templates select="w131:customData"         mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w131:geologyInterval" mode="Backward">
	<xsl:element name="geologyInterval" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<!-- mdTop is handled with lenInterval. -->
		<!-- mdBottom is handled with lenInterval. -->
		<xsl:call-template                                       name="lenInterval-Backward"/>
		<xsl:apply-templates select="w131:dTim"                  mode="copy-element"/>
		<xsl:apply-templates select="w131:tvdTop"                mode="copy-measure"/>
		<xsl:apply-templates select="w131:tvdBase"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:ropAv"                 mode="copy-measure"/>
		<xsl:apply-templates select="w131:ropMn"                 mode="copy-measure"/>
		<xsl:apply-templates select="w131:ropMx"                 mode="copy-measure"/>
		<xsl:apply-templates select="w131:wobAv"                 mode="copy-measure"/>
		<xsl:apply-templates select="w131:tqAv"                  mode="copy-measure"/>
		<xsl:apply-templates select="w131:rpmAv"                 mode="copy-measure"/>
		<xsl:apply-templates select="w131:wtMudAv"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:ecdTdAv"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:dxcAv"                 mode="unitless-Backward"/>
		<xsl:apply-templates select="w131:lithology"             mode="Backward"/>
		<xsl:apply-templates select="w131:show"                  mode="Backward"/>
		<xsl:apply-templates select="w131:chromatograph"         mode="Backward"/>
		<xsl:apply-templates select="w131:mudGas"                mode="Backward"/>
		<xsl:apply-templates select="w131:densBulk"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:densShale"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:cec"                   mode="rename-element"> <!-- uom ignored. -->
			<xsl:with-param name="newName">shaleFactor</xsl:with-param>
		</xsl:apply-templates> <!-- cec and shaleFactor are equivalent. -->
		<xsl:apply-templates select="w131:calcite"               mode="percent-Backward"/>
		<xsl:apply-templates select="w131:dolomite"              mode="percent-Backward"/>
		<xsl:apply-templates select="w131:cec"                   mode="copy-element"/> <!-- uom ignored. -->
		<xsl:apply-templates select="w131:calcStab"              mode="percent-Backward"/>
		<xsl:apply-templates select="w131:nameFormation"         mode="copy-element"/>
		<xsl:apply-templates select="w131:lithostratigraphic"    mode="copy-element"/>
		<xsl:apply-templates select="w131:chronostratigraphic"   mode="copy-element"/>
		<xsl:apply-templates select="w131:sizeMn"                mode="copy-measure"/>
		<xsl:apply-templates select="w131:sizeMx"                mode="copy-measure"/>
		<xsl:apply-templates select="w131:lenPlug"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:description"           mode="copy-element"/>
		<xsl:apply-templates select="w131:cuttingFluid"          mode="copy-element"/>
		<xsl:apply-templates select="w131:cleaningMethod"        mode="copy-element"/>
		<xsl:apply-templates select="w131:dryingMethod"          mode="copy-element"/>
		<xsl:apply-templates select="w131:comments"              mode="copy-element"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="lenInterval-Backward">
	<!-- We are still within the context of geologyInterval. -->
	<!-- Any 2 of top, bottom and interval defines the other. -->
	<xsl:apply-templates select="w131:mdTop"                       mode="copy-measure"/>
	<xsl:apply-templates select="w131:mdBottom"                    mode="copy-measure"/>
	<xsl:if test="w131:mdTop">
		<xsl:if test="w131:mdBottom">
			<xsl:call-template                             name="create-measure">
				<xsl:with-param name="name">lenInterval</xsl:with-param>
				<xsl:with-param name="unit"><xsl:value-of select="w131:mdBottom/@uom"/></xsl:with-param>
					<xsl:with-param name="value">
						<xsl:if test="w131:mdBottom!='' and w131:mdTop!=''">
							<xsl:value-of select="number(w131:mdBottom) - number(w131:mdTop)"/>
						</xsl:if>
					</xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template match="w131:lithology" mode="Backward">
	<xsl:element name="lithology" namespace="{$newNameSpace}">
		<xsl:attribute name="uidLithName"><xsl:value-of select="@uid"/></xsl:attribute>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:codeLith"         mode="copy-element"/>
		<xsl:call-template                                  name="lithPc-Backward"/>
		<xsl:apply-templates select="w131:description"      mode="copy-element"/>
		<xsl:apply-templates select="w131:lithClass"        mode="copy-element"/>
		<xsl:apply-templates select="w131:grainType"        mode="copy-element"/>
		<xsl:apply-templates select="w131:dunhamClass"      mode="copy-element"/>
		<xsl:apply-templates select="w131:color"            mode="copy-element"/>
		<xsl:apply-templates select="w131:texture"          mode="copy-element"/>
		<xsl:apply-templates select="w131:hardness"         mode="copy-element"/>
		<xsl:apply-templates select="w131:sizeGrain"        mode="copy-element"/>
		<xsl:apply-templates select="w131:roundness"        mode="copy-element"/>
		<xsl:apply-templates select="w131:sorting"          mode="copy-element"/>
		<xsl:apply-templates select="w131:matrixCement"     mode="copy-element"/>
		<xsl:apply-templates select="w131:porosityVisible"  mode="rename-element">
			<xsl:with-param name="newName">porosityVis</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:permeability"     mode="copy-element"/>
		<xsl:apply-templates select="w131:qualifier"        mode="Backward"/>
		<!-- accessories is handled in qualifier. -->
		<!-- fossil      is handled in qualifier. -->
		<xsl:apply-templates select="w131:densShale"        mode="copy-measure"/>
		<xsl:call-template                                  name="actual-Backward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="lithPc-Backward">
	<!-- We are still within the context of w131:lithology. -->
	<xsl:choose>
		<xsl:when test="w131:lithPc">
			<xsl:apply-templates select="w131:lithPc"   mode="percent-Backward"/>
		</xsl:when>
		<xsl:otherwise>
			<xsl:if test="../w131:typeLithology='interpreted'">
				<xsl:call-template                  name="create-element">
					<xsl:with-param name="name">lithPc</xsl:with-param>
					<xsl:with-param name="value">100</xsl:with-param>
					<xsl:with-param name="given">YES</xsl:with-param>
				</xsl:call-template>
			</xsl:if>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>

<xsl:template match="w131:qualifier" mode="Backward">
	<xsl:call-template                                            name="create-element">
		<xsl:with-param name="name">accessories</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="substring(w131:description,1,32)"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
	<xsl:call-template                                            name="create-element">
		<xsl:with-param name="name">fossil</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="substring(w131:description,1,32)"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template name="actual-Backward">
	<!-- We are still within the context of w131:lithology. -->
	<xsl:variable name="actual">
		<xsl:choose>
			<xsl:when test="../w131:typeLithology=''"></xsl:when>
			<xsl:when test="../w131:typeLithology='cuttings'">true</xsl:when>
			<xsl:when test="../w131:typeLithology='interpreted'">false</xsl:when>
			<xsl:otherwise>ERROR-TYPELITHOLOGY=<xsl:value-of select="../w131:typeLithology"/></xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:call-template                                            name="create-element">
		<xsl:with-param name="name">actual</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="$actual"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="w131:show" mode="Backward">
	<xsl:element name="show" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:showRat"             mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowRating</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:stainColor"          mode="copy-element"/>
		<xsl:apply-templates select="w131:stainDistr"          mode="copy-element"/>
		<xsl:apply-templates select="w131:stainPc"             mode="percent-Backward"/>
		<xsl:apply-templates select="w131:natFlorColor"        mode="copy-element"/>
		<xsl:apply-templates select="w131:natFlorPc"           mode="percent-Backward"/>
		<xsl:apply-templates select="w131:natFlorLevel"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowFluorescence</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:natFlorDesc"         mode="copy-element"/>
		<xsl:apply-templates select="w131:cutColor"            mode="copy-element"/>
		<xsl:apply-templates select="w131:cutSpeed"            mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowSpeed</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:cutStrength"         mode="copy-element"/>
		<xsl:apply-templates select="w131:cutForm"             mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowLevel</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:cutLevel"            mode="copy-element"/>
		<xsl:apply-templates select="w131:cutFlorColor"        mode="copy-element"/>
		<xsl:apply-templates select="w131:cutFlorSpeed"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowSpeed</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:cutFlorStrength"     mode="copy-element"/>
		<xsl:apply-templates select="w131:cutFlorForm"         mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowLevel</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:cutFlorLevel"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ShowFluorescence</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:residueColor"        mode="copy-element"/>
		<xsl:apply-templates select="w131:showDesc"            mode="copy-element"/>
		<xsl:apply-templates select="w131:impregnatedLitho"    mode="copy-element"/>
		<xsl:apply-templates select="w131:odor"                mode="copy-element"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w131:chromatograph" mode="Backward">
	<xsl:element name="chromatograph" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:dTim"                mode="copy-element"/>
		<xsl:apply-templates select="w131:mdTop"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:mdBottom"            mode="copy-measure"/>
		<xsl:apply-templates select="w131:wtMudIn"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:wtMudOut"            mode="copy-measure"/>
		<xsl:apply-templates select="w131:chromType"           mode="copy-element"/>
		<xsl:call-template                                     name="chromGasUnit-Backward"/>
		<xsl:apply-templates select="w131:eTimChromCycle"      mode="copy-measure"/>
		<xsl:apply-templates select="w131:chromIntRpt"         mode="copy-element"/>
		<xsl:apply-templates select="w131:methAv"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:methMn"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:methMx"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:ethAv"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:ethMn"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:ethMx"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:propAv"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:propMn"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:propMx"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:ibutAv"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:ibutMn"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:ibutMx"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:nbutAv"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:nbutMn"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:nbutMx"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:ipentAv"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:ipentMn"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:ipentMx"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:npentAv"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:npentMn"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:npentMx"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:epentAv"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:epentMn"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:epentMx"             mode="copy-measure"/>
		<xsl:apply-templates select="w131:ihexAv"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:ihexMn"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:ihexMx"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:nhexAv"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:nhexMn"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:nhexMx"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:co2Av"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:co2Mn"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:co2Mx"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:h2sAv"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:h2sMn"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:h2sMx"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:acetylene"           mode="percent-Backward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="chromGasUnit-Backward">
	<!-- We are still within the context of chromatograph. -->
	<xsl:variable name="oldunit">
		<xsl:choose>
			<xsl:when test="w131:methAv">
				<xsl:value-of select="w131:methAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:methMn">
				<xsl:value-of select="w131:methMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:methMx">
				<xsl:value-of select="w131:methMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ethAv">
				<xsl:value-of select="w131:ethAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ethMn">
				<xsl:value-of select="w131:ethMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ethMx">
				<xsl:value-of select="w131:ethMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:propAv">
				<xsl:value-of select="w131:propAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:propMn">
				<xsl:value-of select="w131:propMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:propMx">
				<xsl:value-of select="w131:propMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ibutAv">
				<xsl:value-of select="w131:ibutAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ibutMn">
				<xsl:value-of select="w131:ibutMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ibutMx">
				<xsl:value-of select="w131:ibutMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:nbutAv">
				<xsl:value-of select="w131:nbutAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:nbutMn">
				<xsl:value-of select="w131:nbutMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:nbutMx">
				<xsl:value-of select="w131:nbutMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ipentAv">
				<xsl:value-of select="w131:ipentAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ipentMn">
				<xsl:value-of select="w131:ipentMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ipentMx">
				<xsl:value-of select="w131:ipentMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:npentAv">
				<xsl:value-of select="w131:npentAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:npentMn">
				<xsl:value-of select="w131:npentMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:npentMx">
				<xsl:value-of select="w131:npentMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:epentAv">
				<xsl:value-of select="w131:epentAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:epentMn">
				<xsl:value-of select="w131:epentMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:epentMx">
				<xsl:value-of select="w131:epentMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ihexAv">
				<xsl:value-of select="w131:ihexAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ihexMn">
				<xsl:value-of select="w131:ihexMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:ihexMx">
				<xsl:value-of select="w131:ihexMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:nhexAv">
				<xsl:value-of select="w131:nhexAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:nhexMn">
				<xsl:value-of select="w131:nhexMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:nhexMx">
				<xsl:value-of select="w131:nhexMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:co2Av">
				<xsl:value-of select="w131:co2Av/@uom"/>
			</xsl:when>
			<xsl:when test="w131:co2Mn">
				<xsl:value-of select="w131:co2Mn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:co2Mx">
				<xsl:value-of select="w131:co2Mx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:h2sAv">
				<xsl:value-of select="w131:h2sAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:h2sMn">
				<xsl:value-of select="w131:h2sMn/@uom"/>
			</xsl:when>
			<xsl:when test="w131:h2sMx">
				<xsl:value-of select="w131:h2sMx/@uom"/>
			</xsl:when>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="newunit">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$oldunit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="substitute-Unit!=''">
				<!-- The old unit is not valid in the target schema. -->
				<xsl:value-of select="$substitute-Unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldunit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<!-- Any required value conversion will occur in template copy-measure for each element. -->
	<xsl:call-template name="create-element">
		<xsl:with-param name="name">chromGasUnit</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="$newunit"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="w131:mudGas" mode="Backward">
	<xsl:variable name="oldunit">
		<xsl:choose>
			<xsl:when test="w131:gasAv/@uom!=''">
				<xsl:value-of select="w131:gasAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:gasPeak/@uom!=''">
				<xsl:value-of select="w131:gasPeak/@uom"/>
			</xsl:when>
			<xsl:when test="w131:gasBackgnd/@uom!=''">
				<xsl:value-of select="w131:gasBackgnd/@uom"/>
			</xsl:when>
			<xsl:when test="w131:gasConAv/@uom!=''">
				<xsl:value-of select="w131:gasConAv/@uom"/>
			</xsl:when>
			<xsl:when test="w131:gasConMx/@uom!=''">
				<xsl:value-of select="w131:gasConMx/@uom"/>
			</xsl:when>
			<xsl:when test="w131:gasTrip/@uom!=''">
				<xsl:value-of select="w131:gasTrip/@uom"/>
			</xsl:when>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="newunit">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$oldunit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="substitute-Unit!=''">
				<!-- The old unit is not valid in the target schema. -->
				<xsl:value-of select="$substitute-Unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldunit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:element name="mudGas" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:call-template                                              name="create-element">
			<xsl:with-param name="name">gasUnit</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:call-template 					        name="create-measure-without-uom">
			<xsl:with-param name="name">gasAv</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:gasAv"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:gasAv">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                              name="create-measure-without-uom">
			<xsl:with-param name="name">gasPeak</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:gasPeak"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:gasPeak">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:apply-templates select="w131:gasPeakType"                  mode="convert-enumeration-element">
			<xsl:with-param name="typeName">GasPeakType</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template 					        name="create-measure-without-uom">
			<xsl:with-param name="name">gasBackgnd</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:gasBackgnd"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:gasBackgnd">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template 					        name="create-measure-without-uom">
			<xsl:with-param name="name">gasConAv</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:gasConAv"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:gasConAv">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template 					        name="create-measure-without-uom">
			<xsl:with-param name="name">gasConMx</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:gasConMx"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:gasConMx">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template 					        name="create-measure-without-uom">
			<xsl:with-param name="name">gasTrip</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="$oldunit"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:gasTrip"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:gasTrip">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<!-- ======================================================================================== -->
<!-- ============= Templates specific to the WELLLOG object BACKWARD-TO-LOG. ================ -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="wellLog-Backward-To-Log">
	<!-- Output one log for each blockInfo. -->
	<xsl:variable name="split">
		<!-- Are we going to split this into multiple logs? -->
		<xsl:choose>
			<xsl:when test="count(w131:blockInfo) > 1">YES</xsl:when>
			<xsl:otherwise>NO</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:for-each select="w131:blockInfo">
		<xsl:element name="log" namespace="{$newNameSpace}">
			<xsl:attribute name="uidWell"><xsl:value-of select="normalize-space(../@uidWell)"/></xsl:attribute>
			<xsl:attribute name="uidWellbore"><xsl:value-of select="normalize-space(../@uidWellbore)"/></xsl:attribute>
			<xsl:attribute name="uidLog">
				<xsl:choose>
					<xsl:when test="$split='YES' and $retainEmpty='NO'">
						<xsl:value-of select="concat(normalize-space(../@uid),'--',position())"/>
					</xsl:when>
					<xsl:when test="$split='YES' and $retainEmpty='YES' and ../@uid=''"></xsl:when>
					<xsl:otherwise>
						<xsl:value-of select="normalize-space(../@uid)"/>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:attribute>
			<xsl:apply-templates select="../w131:commonData"                mode="uidSource-Backward"/>
			<xsl:call-template name="linebreak"/>
			<xsl:for-each select="parent::w131:wellLog">
				<xsl:call-template name="copy-comment"/>
			</xsl:for-each>
			<xsl:call-template name="copy-comment"/>
			<xsl:apply-templates select="../w131:nameWell"                  mode="copy-element"/>
			<xsl:apply-templates select="../w131:nameWellbore"              mode="copy-element"/>
			<xsl:call-template                                              name="name-Backward-To-Log">
				<xsl:with-param name="split"><xsl:value-of select="$split"/></xsl:with-param>
			</xsl:call-template>
			<xsl:call-template                                              name="logHeader-Backward-To-Log"/>
			<xsl:apply-templates select="../w131:logData"                   mode="Backward-To-Log">
				<xsl:with-param name="blockUid"><xsl:value-of select="normalize-space(@uid)"/></xsl:with-param>
				<xsl:with-param name="split"><xsl:value-of select="$split"/></xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="../w131:commonData"                mode="Backward"/>
			<xsl:apply-templates select="../w131:customData"                mode="copy-of-customData"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:for-each>
</xsl:template>

<xsl:template name="logHeader-Backward-To-Log">
	<!-- The v1.2 logHeader was collapsed to log in v1.3.1. -->
	<!-- We are still within the context of blockInfo. -->
	<xsl:variable name="oldunit">
		<xsl:value-of select="w131:startIndex/@uom"/>
	</xsl:variable>
	<xsl:variable name="newunit">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$oldunit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="substitute-Unit!=''">
				<!-- The old unit is not valid in the target schema. -->
				<xsl:value-of select="$substitute-Unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldunit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:element name="logHeader" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:for-each select="parent::w131:wellLog">
			<xsl:call-template name="copy-comment"/>
		</xsl:for-each>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="../w131:serviceCompany"                mode="copy-element"/>
		<xsl:call-template                                                  name="runNumber-Backward-To-Log"/>
		<xsl:apply-templates select="../w131:creationDate"                  mode="copy-element"/>
		<xsl:call-template                                                  name="description-Backward-To-Log"/>
		<xsl:apply-templates select="w131:indexType"                        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogIndexType</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                                  name="create-measure-without-uom">
			<xsl:with-param name="name">startIndex</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:startIndex/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:startIndex"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:startIndex">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                                  name="create-measure-without-uom">
			<xsl:with-param name="name">endIndex</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:endIndex/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:endIndex"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:endIndex">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:if test="w131:startDateTimeIndex and not(w131:startIndex)">
			<xsl:apply-templates select="w131:startDateTimeIndex"       mode="rename-element">
				<xsl:with-param name="newName">startIndex</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="w131:endDateTimeIndex"         mode="rename-element">
				<xsl:with-param name="newName">endIndex</xsl:with-param>
			</xsl:apply-templates>
		</xsl:if>
		<xsl:apply-templates select="w131:direction"                        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogIndexDirection</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:indexCurve"                       mode="copy-element"/>
		<xsl:call-template                                                  name="create-measure-without-uom">
			<xsl:with-param name="name">stepIncrement</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:stepIncrement/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:stepIncrement"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:stepIncrement">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                                  name="create-element">
			<xsl:with-param name="name">indexUnits</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:apply-templates select="w131:nullValue"                        mode="copy-element"/>
		<!-- uomNamingSystem was deleted. -->
		<xsl:apply-templates select="w131:logParam"                         mode="rename-indexedObject">
			<xsl:with-param name="newName">logHeaderParam</xsl:with-param>
		</xsl:apply-templates>
		<!-- otherData was moved to description. -->
		<xsl:apply-templates select="../w131:logCurveInfo"                  mode="Backward-To-Log">
			<xsl:with-param name="blockUid"><xsl:value-of select="normalize-space(@uid)"/></xsl:with-param>
		</xsl:apply-templates>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="name-Backward-To-Log">
	<!-- Need to make the name unique if we are splitting the wellLog into multiple logs. -->
	<!-- We are still within the context of blockInfo. -->
	<xsl:param name="split"/>
	<xsl:variable name="val">
		<xsl:choose>
			<xsl:when test="$split='NO'">
				<xsl:value-of select="../w131:name"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="concat(../w131:name,'--',position())"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:call-template                                              name="create-element">
		<xsl:with-param name="name">nameLog</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="$val"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template name="runNumber-Backward-To-Log">
	<!-- runNumber is mandatory in v1.2. -->
	<xsl:variable name="val">
		<xsl:choose>
			<xsl:when test="../w131:runNumber!='' ">
				<xsl:value-of select="../w131:runNumber"/>
			</xsl:when>
			<xsl:when test="../w131:runNumber='' and $retainEmpty='YES'"></xsl:when>
			<xsl:otherwise>UNKNOWN-VALUE</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:call-template                                               name="create-element">
		<xsl:with-param name="name">runNumber</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="$val"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template name="description-Backward-To-Log">
	<!-- The description from both the log and the block must be combined. -->
	<!-- We are still within the context of blockInfo. -->
	<xsl:variable name="descLog">
		<xsl:choose>
			<xsl:when test="normalize-space(../w131:description)!=''">
				<xsl:value-of select="normalize-space(../w131:description)"/>
			</xsl:when>
			<xsl:otherwise></xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="descBlock">
		<xsl:choose>
			<xsl:when test="normalize-space(w131:description)!=''">
				<xsl:value-of select="normalize-space(w131:description)"/>
			</xsl:when>
			<xsl:otherwise></xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="spacer">
		<xsl:choose>
			<xsl:when test="$descLog!=''">
				<xsl:if test="$descBlock!=''"><xsl:text> -- </xsl:text></xsl:if>
			</xsl:when>
			<xsl:otherwise></xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="combo"><xsl:value-of select="normalize-space($descLog)"/><xsl:value-of select="$spacer"/><xsl:value-of select="normalize-space($descBlock)"/></xsl:variable>
	<xsl:call-template                                                      name="create-element">
		<xsl:with-param name="name">description</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="$combo"/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="w131:logCurveInfo" mode="Backward-To-Log">
	<xsl:param name="blockUid"/>   <!-- Identifies the block for which we are creating a log. -->
	<xsl:variable name="oldunit">
		<xsl:value-of select="w131:unit"/>
	</xsl:variable>
	<xsl:variable name="newunit">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$oldunit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="substitute-Unit!=''">
				<!-- The old unit is not valid in the target schema. -->
				<xsl:value-of select="$substitute-Unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldunit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:if test="@uid='' or ../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo/w131:curveId = @uid">
		<!-- This curve is being used in the block. -->
		<xsl:element name="logCurveInfo" namespace="{$newNameSpace}">
			<xsl:call-template name="linebreak"/>
			<xsl:call-template name="copy-comment"/>
			<xsl:apply-templates select="w131:mnemonic"           mode="copy-element"/>
			<xsl:apply-templates select="w131:classWitsml"        mode="rename-classWitsml">
				<xsl:with-param name="newName">classPOSC</xsl:with-param>
			</xsl:apply-templates>
			<xsl:call-template                                    name="create-element">
				<xsl:with-param name="name">unit</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="$newunit"/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
			<xsl:apply-templates select="w131:mnemAlias"          mode="copy-element"/>
			<xsl:apply-templates select="w131:nullValue"          mode="copy-element"/>
			<xsl:call-template                                    name="startIndex-Curve-Backward-To-Log">
				<xsl:with-param name="blockUid"><xsl:value-of select="$blockUid"/></xsl:with-param>
				<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			</xsl:call-template>
			<!-- endIndex is handled by startIndex. -->
			<!-- columnIndex is handled by startIndex. -->
			<xsl:apply-templates select="w131:curveDescription"   mode="copy-element"/>
			<xsl:apply-templates select="w131:sensorOffset"       mode="copy-measure"/>
			<xsl:apply-templates select="w131:traceState"         mode="convert-enumeration-element">
				<xsl:with-param name="typeName">LogTraceState</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="w131:typeLogData"        mode="convert-enumeration-element">
				<xsl:with-param name="typeName">LogDataType</xsl:with-param>
			</xsl:apply-templates>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template name="startIndex-Curve-Backward-To-Log">
	<xsl:param name="blockUid"/>
	<xsl:param name="newunit"/>
	<!-- The log curve start,end values are really min,max values -->
	<!-- We are still within the context of logCurveInfo. -->
	<xsl:variable name="id" select="@uid"/>
	<xsl:variable name="minIdx" select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:minIndex"/>
	<xsl:variable name="maxIdx" select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:maxIndex"/>
	<xsl:variable name="minDte" select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:minDateTimeIndex"/>
	<xsl:variable name="minIdxUnit" select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:minIndex/@uom"/>
	<xsl:variable name="maxIdxUnit" select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:maxIndex/@uom"/>
	<xsl:call-template                                                            name="create-measure-without-uom">
		<xsl:with-param name="name">startIndex</xsl:with-param>
		<xsl:with-param name="oldunit"><xsl:value-of select="$minIdxUnit"/></xsl:with-param>
		<xsl:with-param name="oldvalue"><xsl:value-of select="$minIdx"/></xsl:with-param>
		<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
		<xsl:with-param name="given"><xsl:if test="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:minIndex">YES</xsl:if></xsl:with-param>
	</xsl:call-template>
	<xsl:call-template                                                            name="create-measure-without-uom">
		<xsl:with-param name="name">endIndex</xsl:with-param>
		<xsl:with-param name="oldunit"><xsl:value-of select="$maxIdxUnit"/></xsl:with-param>
		<xsl:with-param name="oldvalue"><xsl:value-of select="$maxIdx"/></xsl:with-param>
		<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
		<xsl:with-param name="given"><xsl:if test="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:maxIndex">YES</xsl:if></xsl:with-param>
	</xsl:call-template>
	<xsl:if test="$minDte and not($minIdx)">
		<xsl:apply-templates select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:minDateTimeIndex"  mode="rename-element"> <!-- Ignores uom attribute. -->
			<xsl:with-param name="newName">startIndex</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:maxDateTimeIndex"  mode="rename-element">  <!-- Ignores uom attribute. -->
			<xsl:with-param name="newName">endIndex</xsl:with-param>
		</xsl:apply-templates>
	</xsl:if>
	<xsl:apply-templates select="../w131:blockInfo[@uid=$blockUid]/w131:blockCurveInfo[w131:curveId=$id]/w131:columnIndex"  mode="copy-element"/> <!-- Ignores columnIndex attribute. -->
</xsl:template>

<xsl:template match="w131:logData" mode="Backward-To-Log">
	<xsl:param name="blockUid"/>
	<xsl:param name="split"/>
	<!-- Add an index attribute to data. --> 
	<xsl:element name="logData" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:choose>
			<xsl:when test="$split='YES'">
				<xsl:for-each select="w131:data[@id=$blockUid]">
					<xsl:element name="data" namespace="{$newNameSpace}">
						<xsl:attribute name="index"><xsl:if test=".!=''"><xsl:value-of select="position()"/></xsl:if></xsl:attribute>
						<xsl:value-of select="."/>
					</xsl:element>
					<xsl:call-template name="linebreak"/>
				</xsl:for-each>
			</xsl:when>
			<xsl:otherwise>
				<xsl:for-each select="w131:data">
					<xsl:element name="data" namespace="{$newNameSpace}">
						<xsl:attribute name="index"><xsl:if test=".!=''"><xsl:value-of select="position()"/></xsl:if></xsl:attribute>
						<xsl:value-of select="."/>
					</xsl:element>
					<xsl:call-template name="linebreak"/>
				</xsl:for-each>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<!-- ======================================================================================== -->
<!-- ===================== Templates specific to the LOG objects. =========================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="log-Backward">
	<xsl:element name="log" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="@uidWell"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="@uidWellbore"/></xsl:attribute>
		<xsl:attribute name="uidLog"><xsl:value-of select="@uid"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"         mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:nameWell"           mode="copy-element"/>
		<xsl:apply-templates select="w131:nameWellbore"       mode="copy-element"/>
		<xsl:apply-templates select="w131:name"               mode="rename-element">
			<xsl:with-param name="newName">nameLog</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                    name="logHeader-Backward"/>
		<xsl:apply-templates select="w131:logData"            mode="Backward"/>
		<xsl:apply-templates select="w131:commonData"         mode="Backward"/>
		<xsl:apply-templates select="w131:customData"         mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w131:logData" mode="Backward">
	<!-- Add an index attribute to data. --> 
	<xsl:element name="logData" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:for-each select="w131:data">
			<xsl:element name="data" namespace="{$newNameSpace}">
				<xsl:attribute name="index"><xsl:if test=".!=''"><xsl:value-of select="position()"/></xsl:if></xsl:attribute>
				<xsl:value-of select="."/>
			</xsl:element>
			<xsl:call-template name="linebreak"/>
		</xsl:for-each>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="logHeader-Backward">
	<!-- The v1.2 logHeader was collapsed to log in v1.3.1. -->
	<xsl:variable name="oldunit">
		<xsl:value-of select="w131:startIndex/@uom"/>
	</xsl:variable>
	<xsl:variable name="newunit">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$oldunit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="substitute-Unit!=''">
				<!-- The old unit is not valid in the target schema. -->
				<xsl:value-of select="$substitute-Unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldunit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:element name="logHeader" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:serviceCompany"                mode="copy-element"/>
		<xsl:apply-templates select="w131:runNumber"                     mode="copy-element"/>
		<xsl:apply-templates select="w131:creationDate"                  mode="copy-element"/>
		<xsl:apply-templates select="w131:description"                   mode="copy-element"/>
		<xsl:apply-templates select="w131:indexType"                     mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogIndexType</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                               name="create-measure-without-uom">
			<xsl:with-param name="name">startIndex</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:startIndex/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:startIndex"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:startIndex">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                               name="create-measure-without-uom">
			<xsl:with-param name="name">endIndex</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:endIndex/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:endIndex"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:endIndex">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:if test="w131:startDateTimeIndex and not(w131:startIndex)">
			<xsl:apply-templates select="w131:startDateTimeIndex"    mode="rename-element">
				<xsl:with-param name="newName">startIndex</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="w131:endDateTimeIndex"      mode="rename-element">
				<xsl:with-param name="newName">endIndex</xsl:with-param>
			</xsl:apply-templates>
		</xsl:if>
		<xsl:apply-templates select="w131:direction"                     mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogIndexDirection</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:indexCurve"                    mode="copy-element"/> <!-- Ignores columnIndex. -->
		<xsl:call-template                                               name="create-measure-without-uom">
			<xsl:with-param name="name">stepIncrement</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:stepIncrement/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:stepIncrement"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:stepIncrement">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                               name="create-element">
			<xsl:with-param name="name">indexUnits</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
		<xsl:apply-templates select="w131:nullValue"                     mode="copy-element"/>
		<!-- uomNamingSystem was deleted. -->
		<xsl:apply-templates select="w131:logParam"                      mode="rename-indexedObject">
			<xsl:with-param name="newName">logHeaderParam</xsl:with-param>
		</xsl:apply-templates>
		<!-- otherData was moved to description. -->
		<xsl:apply-templates select="w131:logCurveInfo"                  mode="logCurveInfo-Backward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w131:logCurveInfo" mode="logCurveInfo-Backward">
	<xsl:variable name="oldunit">
		<xsl:value-of select="w131:unit"/>
	</xsl:variable>
	<xsl:variable name="newunit">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$oldunit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="substitute-Unit!=''">
				<!-- The old unit is not valid in the target schema. -->
				<xsl:value-of select="$substitute-Unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$oldunit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:element name="logCurveInfo" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:mnemonic"                       mode="copy-element"/>
		<xsl:apply-templates select="w131:classWitsml"                    mode="rename-classWitsml">
			<xsl:with-param name="newName">classPOSC</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:unit"                           mode="copy-element"/>
		<xsl:apply-templates select="w131:mnemAlias"                      mode="copy-element"/>
		<xsl:apply-templates select="w131:nullValue"                      mode="copy-element"/>
		<xsl:call-template                                                name="create-measure-without-uom">
			<xsl:with-param name="name">startIndex</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:minIndex/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:minIndex"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:minIndex">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:call-template                                                name="create-measure-without-uom">
			<xsl:with-param name="name">endIndex</xsl:with-param>
			<xsl:with-param name="oldunit"><xsl:value-of select="w131:maxIndex/@uom"/></xsl:with-param>
			<xsl:with-param name="oldvalue"><xsl:value-of select="w131:maxIndex"/></xsl:with-param>
			<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
			<xsl:with-param name="given"><xsl:if test="w131:maxIndex">YES</xsl:if></xsl:with-param>
		</xsl:call-template>
		<xsl:if test="w131:minDateTimeIndex and not(w131:minIndex)">
			<xsl:apply-templates select="w131:minDateTimeIndex"       mode="rename-element">
				<xsl:with-param name="newName">startIndex</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="w131:maxDateTimeIndex"       mode="rename-element">
				<xsl:with-param name="newName">endIndex</xsl:with-param>
			</xsl:apply-templates>
		</xsl:if>
		<xsl:apply-templates select="w131:columnIndex"                    mode="copy-element"/>
		<xsl:apply-templates select="w131:curveDescription"               mode="copy-element"/>
		<xsl:apply-templates select="w131:sensorOffset"                   mode="copy-measure"/>
		<xsl:apply-templates select="w131:traceState"                     mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogTraceState</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:typeLogData"                    mode="convert-enumeration-element">
			<xsl:with-param name="typeName">LogDataType</xsl:with-param>
		</xsl:apply-templates>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<!-- ======================================================================================== -->
<!-- ======= Templates specific to the TRAJECTORY and TRAJECTORYSTATION objects. ============ -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="trajectory-Backward">
	<xsl:element name="trajectory" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="@uidWell"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="@uidWellbore"/></xsl:attribute>
		<xsl:attribute name="uidTraj"><xsl:value-of select="@uid"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"                   mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:nameWell"                     mode="copy-element"/>
		<xsl:apply-templates select="w131:nameWellbore"                 mode="copy-element"/>
		<xsl:apply-templates select="w131:name"                         mode="rename-element">
			<xsl:with-param name="newName">nameTraj</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                              name="parentTrajectory-Backward"/>
		<xsl:apply-templates select="w131:dTimTrajStart"                mode="copy-element"/>
		<xsl:apply-templates select="w131:dTimTrajEnd"                  mode="copy-element"/>
		<xsl:apply-templates select="w131:mdMn"                         mode="copy-measure"/>
		<xsl:apply-templates select="w131:mdMx"                         mode="copy-measure"/>
		<xsl:apply-templates select="w131:serviceCompany"               mode="copy-element"/>
		<xsl:apply-templates select="w131:magDeclUsed"                  mode="copy-measure"/>
		<xsl:apply-templates select="w131:gridCorUsed"                  mode="copy-measure"/>
		<xsl:apply-templates select="w131:aziVertSect"                  mode="copy-measure"/>
		<xsl:apply-templates select="w131:dispNsVertSectOrig"           mode="copy-measure"/>
		<xsl:apply-templates select="w131:dispEwVertSectOrig"           mode="copy-measure"/>
		<xsl:apply-templates select="w131:definitive"                   mode="copy-element"/>
		<xsl:apply-templates select="w131:memory"                       mode="copy-element"/>
		<xsl:apply-templates select="w131:finalTraj"                    mode="copy-element"/>
		<xsl:apply-templates select="w131:aziRef"                       mode="convert-enumeration-element">
			<xsl:with-param name="typeName">AziRef</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:trajectoryStation"            mode="Backward"/>
		<xsl:apply-templates select="w131:commonData"                   mode="Backward"/>
		<xsl:apply-templates select="w131:customData"                   mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="trajectoryStation-Object-Backward">
	<xsl:element name="trajectoryStation" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="@uidWell"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="@uidWellbore"/></xsl:attribute>
		<xsl:attribute name="uidTraj"><xsl:value-of select="@uidTrajectory"/></xsl:attribute>
		<xsl:attribute name="uidTrajStn"><xsl:value-of select="@uid"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"                mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:nameWell"                  mode="copy-element"/>
		<xsl:apply-templates select="w131:nameWellbore"              mode="copy-element"/>
		<xsl:apply-templates select="w131:nameTrajectory"            mode="rename-element">
			<xsl:with-param name="newName">nameTraj</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                           name="groupTrajectoryStation-Backward"/>
		<xsl:apply-templates select="w131:commonData"                mode="Backward"/>
		<xsl:apply-templates select="w131:customData"                mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="parentTrajectory-Backward">
	<!-- We must split an element into separate name and uid elements. -->
	<xsl:if test="w131:parentTrajectory">
		<xsl:variable name="doIt">
			<xsl:choose>
				<xsl:when test="not(w131:parentTrajectory/w131:wellboreParent)">YES</xsl:when>
				<xsl:when test="w131:parentTrajectory/w131:wellboreParent/@uidRef = ../@uidWellbore">YES</xsl:when>
			</xsl:choose>
		</xsl:variable>
		<xsl:if test="$doIt='YES'">
			<xsl:apply-templates select="w131:parentTrajectory/w131:trajectoryReference/@uidRef"  mode="create-element">
				<xsl:with-param name="name">uidTrajParent</xsl:with-param>
			</xsl:apply-templates>
			<xsl:apply-templates select="w131:parentTrajectory/w131:trajectoryReference"          mode="create-element">
				<xsl:with-param name="name">nameTrajParent</xsl:with-param>
			</xsl:apply-templates>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template match="w131:trajectoryStation" mode="Backward">
	<xsl:element name="trajectoryStation" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="../@uidWell"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="../@uidWellbore"/></xsl:attribute>
		<xsl:attribute name="uidTraj"><xsl:value-of select="../@uid"/></xsl:attribute>
		<xsl:attribute name="uidTrajStn"><xsl:value-of select="@uid"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"                      mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="../w131:nameWell"                     mode="copy-element"/>
		<xsl:apply-templates select="../w131:nameWellbore"                 mode="copy-element"/>
		<xsl:apply-templates select="../w131:name"                         mode="rename-element">
			<xsl:with-param name="newName">nameTraj</xsl:with-param>
		</xsl:apply-templates>
		<xsl:call-template                                                 name="groupTrajectoryStation-Backward"/>
		<xsl:apply-templates select="w131:commonData"                      mode="Backward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<xsl:template name="groupTrajectoryStation-Backward">
	<!-- Split an element with an attribute into two elements. -->
	<xsl:apply-templates select="w131:target/@uidRef"          mode="create-element">
		<xsl:with-param name="name">uidTarget</xsl:with-param>
	</xsl:apply-templates>
	<xsl:apply-templates select="w131:target"                  mode="rename-element"> <!-- Ignores attribute.-->
		<xsl:with-param name="newName">nameTarget</xsl:with-param>
	</xsl:apply-templates>
	<xsl:apply-templates select="w131:dTimStn"                 mode="copy-element"/>
	<xsl:apply-templates select="w131:typeTrajStation"         mode="convert-enumeration-element">
		<xsl:with-param name="typeName">TrajStationType</xsl:with-param>
	</xsl:apply-templates>
	<xsl:apply-templates select="w131:md"                      mode="copy-measure"/>
	<xsl:apply-templates select="w131:tvd"                     mode="copy-measure"/>
	<xsl:apply-templates select="w131:incl"                    mode="copy-measure"/>
	<xsl:apply-templates select="w131:azi"                     mode="copy-measure"/>
	<xsl:apply-templates select="w131:mtf"                     mode="copy-measure"/>
	<xsl:apply-templates select="w131:gtf"                     mode="copy-measure"/>
	<xsl:apply-templates select="w131:dispNs"                  mode="copy-measure"/>
	<xsl:apply-templates select="w131:dispEw"                  mode="copy-measure"/>
	<xsl:apply-templates select="w131:vertSect"                mode="copy-measure"/>
	<xsl:apply-templates select="w131:dls"                     mode="copy-measure"/>
	<xsl:apply-templates select="w131:rateTurn"                mode="copy-measure"/>
	<xsl:apply-templates select="w131:rateBuild"               mode="copy-measure"/>
	<xsl:apply-templates select="w131:mdDelta"                 mode="copy-measure"/>
	<xsl:apply-templates select="w131:tvdDelta"                mode="copy-measure"/>
	<xsl:apply-templates select="w131:modelToolError"          mode="copy-element"/>
	<xsl:apply-templates select="w131:gravTotalUncert"         mode="copy-measure"/>
	<xsl:apply-templates select="w131:dipAngleUncert"          mode="copy-measure"/>
	<xsl:apply-templates select="w131:magTotalUncert"          mode="copy-measure"/>
	<xsl:apply-templates select="w131:gravAccelCorUsed"        mode="copy-element"/>
	<xsl:apply-templates select="w131:magXAxialCorUsed"        mode="copy-element"/>
	<xsl:apply-templates select="w131:sagCorUsed"              mode="copy-element"/>
	<xsl:apply-templates select="w131:magDrlstrCorUsed"        mode="copy-element"/>
	<xsl:apply-templates select="w131:gravTotalFieldReference" mode="copy-measure"/>
	<xsl:apply-templates select="w131:magTotalFieldReference"  mode="copy-measure"/>
	<xsl:apply-templates select="w131:magDipAngleReference"    mode="copy-measure"/>
	<xsl:apply-templates select="w131:magModelUsed"            mode="copy-element"/>
	<xsl:apply-templates select="w131:magModelValid"           mode="copy-element"/>
	<xsl:apply-templates select="w131:geoModelUsed"            mode="copy-element"/>
	<xsl:apply-templates select="w131:statusTrajStation"       mode="convert-enumeration-element">
		<xsl:with-param name="typeName">TrajStationStatus</xsl:with-param>
	</xsl:apply-templates>
	<xsl:apply-templates select="w131:rawData"                 mode="copy-all"/>
	<xsl:apply-templates select="w131:corUsed"                 mode="copy-all"/>
	<xsl:apply-templates select="w131:valid"                   mode="copy-all"/>
	<xsl:apply-templates select="w131:matrixCov"               mode="Backward"/>
	<xsl:call-template                                         name="location-Backward">
		<xsl:with-param name="newName">location</xsl:with-param>
		<xsl:with-param name="nodeSet" select="w131:location"/>
	</xsl:call-template>
	<!-- Element sourceStation has no mapping back to w120. -->
</xsl:template>

<xsl:template match="w131:matrixCov" mode="Backward">
	<xsl:element name="matrixCov" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:varianceNN"         mode="rename-measure">
			<xsl:with-param name="newName">varNN</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:varianceNE"         mode="rename-measure">
			<xsl:with-param name="newName">varNE</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:varianceNVert"      mode="rename-measure">
			<xsl:with-param name="newName">varNV</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:varianceEE"         mode="rename-measure">
			<xsl:with-param name="newName">varEE</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:varianceEVert"      mode="rename-measure">
			<xsl:with-param name="newName">varEV</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:varianceVertVert"   mode="rename-measure">
			<xsl:with-param name="newName">varVV</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:biasN"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:biasE"              mode="copy-measure"/>
		<xsl:apply-templates select="w131:biasVert"           mode="rename-measure">
			<xsl:with-param name="newName">biasV</xsl:with-param>
		</xsl:apply-templates>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>



<!-- ======================================================================================== -->
<!-- ==================== Templates specific to the WELLBORE object. ======================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="wellbore-Backward">
	<xsl:element name="wellbore" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="@uidWell"/></xsl:attribute>
		<xsl:attribute name="uidWellbore"><xsl:value-of select="@uid"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"        mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:nameWell"          mode="copy-element"/>
		<xsl:apply-templates select="w131:name"              mode="rename-element">
			<xsl:with-param name="newName">nameWellbore</xsl:with-param>
		</xsl:apply-templates>
		<!-- We must split one element into separate name and uid elements. -->
		<xsl:if test="w131:parentWellbore">
			<xsl:apply-templates select="w131:parentWellbore/@uidRef"   mode="create-element">
				<xsl:with-param name="name">uidParentWellbore</xsl:with-param>
			</xsl:apply-templates>
		</xsl:if>
		<xsl:apply-templates select="w131:parentWellbore"    mode="rename-element">  <!-- Ignores attribute. -->
			<xsl:with-param name="newName">nameParentWellbore</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:number"            mode="copy-element"/>
		<xsl:apply-templates select="w131:suffixAPI"         mode="copy-element"/>
		<xsl:apply-templates select="w131:numGovt"           mode="copy-element"/>
		<xsl:apply-templates select="w131:statusWellbore"    mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellStatus</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:purposeWellbore"   mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellPurpose</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:typeWellbore"      mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellboreType</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:shape"             mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellboreShape</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:dTimKickoff"       mode="copy-element"/>
		<xsl:apply-templates select="w131:mdCurrent"         mode="copy-measure"/>
		<xsl:apply-templates select="w131:tvdCurrent"        mode="copy-measure"/>
		<xsl:apply-templates select="w131:mdKickoff"         mode="copy-measure"/>
		<xsl:apply-templates select="w131:tvdKickoff"        mode="copy-measure"/>
		<xsl:apply-templates select="w131:mdPlanned"         mode="copy-measure"/>
		<xsl:apply-templates select="w131:tvdPlanned"        mode="copy-measure"/>
		<xsl:apply-templates select="w131:mdSubSeaPlanned"   mode="copy-measure"/>
		<xsl:apply-templates select="w131:tvdSubSeaPlanned"  mode="copy-measure"/>
		<xsl:apply-templates select="w131:dayTarget"         mode="copy-measure"/>
		<xsl:apply-templates select="w131:commonData"        mode="Backward"/>
		<xsl:apply-templates select="w131:customData"        mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>


<!-- ======================================================================================== -->
<!-- ====================== Templates specific to the well object. ========================== -->
<!-- ===================== These templates are direction specific. ========================== -->
<!-- ======================================================================================== -->

<xsl:template name="well-Backward">
	<xsl:element name="well" namespace="{$newNameSpace}">
		<xsl:attribute name="uidWell"><xsl:value-of select="@uid"/></xsl:attribute>
		<xsl:apply-templates select="w131:commonData"      mode="uidSource-Backward"/>
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:name"            mode="rename-element">
			<xsl:with-param name="newName">nameWell</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:nameLegal"       mode="copy-element"/>
		<xsl:apply-templates select="w131:numLicense"      mode="copy-element"/>
		<xsl:apply-templates select="w131:numGovt"         mode="copy-element"/>
		<xsl:apply-templates select="w131:dTimLicense"     mode="copy-element"/>
		<xsl:apply-templates select="w131:field"           mode="copy-element"/>
		<xsl:apply-templates select="w131:country"         mode="copy-element"/>
		<xsl:apply-templates select="w131:state"           mode="copy-element"/>
		<xsl:apply-templates select="w131:county"          mode="copy-element"/>
		<xsl:apply-templates select="w131:region"          mode="copy-element"/>
		<xsl:apply-templates select="w131:district"        mode="copy-element"/>
		<xsl:apply-templates select="w131:block"           mode="copy-element"/>
		<xsl:apply-templates select="w131:timeZone"        mode="copy-element"/>
		<xsl:apply-templates select="w131:operator"        mode="copy-element"/>
		<xsl:apply-templates select="w131:operatorDiv"     mode="copy-element"/>
		<xsl:apply-templates select="w131:pcInterest"      mode="percent-Backward"/>
		<xsl:apply-templates select="w131:numAPI"          mode="copy-element"/>
		<xsl:apply-templates select="w131:statusWell"      mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellStatus</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:purposeWell"     mode="convert-enumeration-element">
			<xsl:with-param name="typeName">WellPurpose</xsl:with-param>
		</xsl:apply-templates>
		<!-- Element fluidWell has no mapping back to w120. -->
		<xsl:apply-templates select="w131:dTimSpud"        mode="copy-element"/>
		<xsl:apply-templates select="w131:dTimPa"          mode="copy-element"/>
		<!-- dtmPermToWellhead handled by wellDatum-->
		<!-- dtmPermanent handled by wellDatum-->
		<xsl:call-template                                 name="wellDatum-Backward"/>
		<xsl:apply-templates select="w131:groundElevation" mode="Backward"/>
		<xsl:apply-templates select="w131:waterDepth"      mode="copy-measure"/>
		<xsl:call-template                                 name="location-Backward">
			<xsl:with-param name="newName">location</xsl:with-param>
			<xsl:with-param name="nodeSet" select="w131:wellLocation"/>
		</xsl:call-template>
		<xsl:call-template                                 name="wellCRS-Backward"/>
		<xsl:apply-templates select="w131:commonData"      mode="Backward"/>
		<xsl:apply-templates select="w131:customData"      mode="copy-of-customData"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="wellCRS-Backward">
	<!-- Information from many wellCRS must be part of the same cartographicProjection container.-->
	<xsl:if test="w131:wellCRS//w131:mapProjection | w131:wellCRS//w131:geographic">
		<xsl:element name="cartographicProjection" namespace="{$newNameSpace}">
			<xsl:call-template name="linebreak"/>
			<xsl:apply-templates select="w131:wellCRS/child::comment()" mode="copy-all"/>
			<xsl:apply-templates select=".//w131:mapProjection"         mode="Backward"/>
			<xsl:apply-templates select=".//w131:geographic"            mode="Backward"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="w131:mapProjection" mode="Backward">
	<xsl:element name="mapProjection" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:projectionCode"    mode="convert-enumeration-element">
			<xsl:with-param name="typeName">Projection</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:stdParallel1"      mode="copy-measure"/>
		<xsl:apply-templates select="w131:stdParallel2"      mode="copy-measure"/>
		<xsl:apply-templates select="w131:centralMeridian"   mode="copy-measure"/>
		<xsl:apply-templates select="w131:originLatitude"    mode="copy-measure"/>
		<xsl:apply-templates select="w131:originLongitude"   mode="copy-measure"/>
		<xsl:apply-templates select="w131:latitude1"         mode="copy-measure"/>
		<xsl:apply-templates select="w131:longitude1"        mode="copy-measure"/>
		<xsl:apply-templates select="w131:latitude2"         mode="copy-measure"/>
		<xsl:apply-templates select="w131:longitude2"        mode="copy-measure"/>
		<xsl:apply-templates select="w131:latitudeForScale"  mode="copy-measure"/>
		<xsl:apply-templates select="w131:longitudeForScale" mode="copy-measure"/>
		<xsl:apply-templates select="w131:trueScaleLatitude" mode="copy-measure"/>
		<xsl:apply-templates select="w131:spheroidRadius"    mode="copy-measure"/>
		<xsl:apply-templates select="w131:scaleFactor"       mode="unitless-Backward"/>
		<xsl:apply-templates select="w131:methodVariant"     mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ProjectionVariantsObliqueMercator</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:perspectiveHeight" mode="copy-measure"/>
		<xsl:apply-templates select="w131:zone"              mode="Backward"/>
		<xsl:apply-templates select="w131:NADType"           mode="convert-enumeration-element">
			<xsl:with-param name="typeName">NADTypes</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:falseEasting"      mode="copy-measure"/>
		<xsl:apply-templates select="w131:falseNorthing"     mode="copy-measure"/>
		<xsl:apply-templates select="w131:bearing"           mode="copy-measure"/>
		<xsl:apply-templates select="w131:hemisphere"        mode="convert-enumeration-element">
			<xsl:with-param name="typeName">Hemispheres</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="../w131:name"           mode="rename-element">
			<xsl:with-param name="newName">nameProj</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:description"       mode="copy-element"/>
		<xsl:apply-templates select="w131:parameter"         mode="copy-indexedObject"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w131:geographic" mode="Backward">
	<xsl:element name="geodeticModel" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="w131:geodeticDatumCode"          mode="copy-element"/>
		<xsl:apply-templates select="../w131:name"                    mode="rename-element">
			<xsl:with-param name="newName">geodeticDatumName</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:xTranslation"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:yTranslation"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:zTranslation"               mode="copy-measure"/>
		<xsl:apply-templates select="w131:xRotation"                  mode="copy-measure"/>
		<xsl:apply-templates select="w131:yRotation"                  mode="copy-measure"/>
		<xsl:apply-templates select="w131:zRotation"                  mode="copy-measure"/>
		<xsl:apply-templates select="w131:scaleFactor"                mode="unitless-Backward"/>
		<xsl:apply-templates select="w131:ellipsoidCode"              mode="convert-enumeration-element">
			<xsl:with-param name="typeName">Ellipsoid</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:ellipsoidSemiMajorAxis"     mode="copy-measure"/>
		<xsl:apply-templates select="w131:ellipsoidInverseFlattening" mode="unitless-Backward"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="w131:groundElevation" mode="Backward">
	<!-- The v120 ground elevation is specifically with respect to mean sea level. --> 
	<xsl:if test=".!=''">
		<xsl:variable name="code">
			<xsl:choose>
				<xsl:when test="@datum">
					<!-- A specific datum was given for the elevation. -->
					<xsl:variable name="datum" select="@datum"/>
					<xsl:value-of select="../w131:wellDatum[@uid=$datum]/w131:code"/>
				</xsl:when>
				<xsl:when test="../w131:wellDatum[@defaultElevation]/w131:name">
					<!-- Use the default elevation datum. -->
					<xsl:value-of select="../w131:wellDatum[@defaultElevation]/w131:code"/>
				</xsl:when>
			</xsl:choose>
		</xsl:variable>
		<xsl:if test="$code='SL'">
			<xsl:call-template                             name="create-measure">
				<xsl:with-param name="name">groundElevation</xsl:with-param>
				<xsl:with-param name="unit"><xsl:value-of select="@uom"/></xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
		</xsl:if>
	</xsl:if>
</xsl:template>

<xsl:template name="wellDatum-Backward">
	<!-- If wellheadElevation was given then its datum will be the permanent datum. -->
	<xsl:if test="w131:wellheadElevation">
		<xsl:apply-templates select="w131:wellheadElevation"                          mode="rename-measure">
			<xsl:with-param name="newName">dtmPermToWellhead</xsl:with-param>
		</xsl:apply-templates> 
		<xsl:variable name="code">
			<xsl:choose>
				<xsl:when test="w131:wellheadElevation/@datum">
					<!-- A specific datum was given for the elevation. -->
					<xsl:variable name="datum" select="w131:wellheadElevation/@datum"/>
					<xsl:call-template name="convert-enum-value">
						<xsl:with-param name="typeName">PermanentDatum</xsl:with-param>
						<xsl:with-param name="value">
							<xsl:value-of select="w131:wellDatum[@uid=$datum]/w131:code"/>
						</xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:when test="w131:wellDatum[@defaultElevation]/w131:name">
					<!-- Use the default elevation datum. -->
					<xsl:call-template name="convert-enum-value">
						<xsl:with-param name="typeName">PermanentDatum</xsl:with-param>
						<xsl:with-param name="value">
							<xsl:value-of select="w131:wellDatum[@defaultElevation]/w131:code"/>
						</xsl:with-param>
					</xsl:call-template>
				</xsl:when>
			</xsl:choose>
		</xsl:variable>
		<xsl:call-template                                                       name="create-element">
			<xsl:with-param name="name">dtmPermanent</xsl:with-param>
			<xsl:with-param name="value"><xsl:value-of select="$code"/></xsl:with-param>
			<xsl:with-param name="given">YES</xsl:with-param>
		</xsl:call-template>
	</xsl:if>
</xsl:template>

<xsl:template match="w131:zone" mode="Backward">
	<!-- Convert a letter indicating the direction to a value sign. --> 
	<xsl:element name="{name(.)}" namespace="{$newNameSpace}">
		<xsl:choose>
			<xsl:when test=".='' and $retainEmpty='YES'"></xsl:when>
			<xsl:when test="contains(.,'N')"><xsl:value-of select="substring-before(normalize-space(.),'N')"/></xsl:when>
			<xsl:when test="contains(.,'S')"><xsl:value-of select="number(substring-before(normalize-space(.),'S')) * -1"/></xsl:when>
			<xsl:otherwise>ERROR-ZONE-WITHOUT-N-OR-S</xsl:otherwise>
		</xsl:choose>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<!-- ======================================================================================== -->
<!-- ========================= Non-Object specific templates ================================ -->
<!-- =================== These templates are direction specific. ============================ -->
<!-- ======================================================================================== -->

<xsl:template match="w131:commonData" mode="uidSource-Backward">
	<!-- sourceName moves to @uidSource. --> 
	<xsl:if test="w131:sourceName">
		<xsl:attribute name="uidSource">
			<xsl:value-of select="normalize-space(w131:sourceName)"/>
		</xsl:attribute>
	</xsl:if>
</xsl:template>

<xsl:template match="w131:commonData" mode="Backward">
	<xsl:element name="commonData" namespace="{$newNameSpace}">
		<xsl:call-template name="linebreak"/>
		<xsl:call-template name="copy-comment"/>
		<xsl:apply-templates select="//w131:documentInfo//w131:FileCreator"       mode="rename-element">
			<xsl:with-param name="newName">nameSource</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="//w131:documentInfo//w131:FileCreationDate"  mode="rename-element">
			<xsl:with-param name="newName">dTimStamp</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:dTimCreation"                           mode="copy-element"/>
		<xsl:apply-templates select="w131:dTimLastChange"                         mode="copy-element"/>
		<xsl:apply-templates select="w131:itemState"                              mode="convert-enumeration-element">
			<xsl:with-param name="typeName">ItemState</xsl:with-param>
		</xsl:apply-templates>
		<xsl:apply-templates select="w131:comments"                               mode="copy-element"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="*" mode="percent-Backward">
	<!-- Convert a value with explicit uom to a value with an implied unit of measure of %. --> 
	<xsl:call-template name="create-measure-without-uom">
		<xsl:with-param name="name"><xsl:value-of select="name(.)"/></xsl:with-param>
		<xsl:with-param name="oldunit"><xsl:value-of select="@uom"/></xsl:with-param>
		<xsl:with-param name="oldvalue"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="newunit">%</xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="*" mode="unitless-Backward">
	<!-- Create artificial unit of Euc. -->
	<xsl:call-template                             name="create-measure">
		<xsl:with-param name="name"><xsl:value-of select="name(.)"/></xsl:with-param>
		<xsl:with-param name="unit">Euc</xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>


<xsl:template name="location-Backward">
	<!-- Each location pair must be combined into one location instance. -->
	<xsl:param name="newName"/>       <!-- The new element name. -->
	<xsl:param name="nodeSet"/>       <!-- A node set containing only the appropriate locations. -->
	<xsl:if test="$nodeSet//w131:latitude or $nodeSet//w131:easting or $nodeSet//w131:westing or $nodeSet//w131:projectedX">
		<xsl:element name="{$newName}" namespace="{$newNameSpace}">
			<xsl:call-template name="linebreak"/>
			<xsl:apply-templates select="$nodeSet/descendant::comment()"   mode="copy-all"/>
			<xsl:if test="$nodeSet//w131:latitude">
				<xsl:apply-templates select="$nodeSet//w131:latitude"  mode="copy-measure"/>
				<xsl:apply-templates select="$nodeSet//w131:longitude" mode="copy-measure"/>
			</xsl:if>
			<xsl:if test="$nodeSet//w131:easting">
				<xsl:apply-templates select="$nodeSet//w131:easting"   mode="rename-measure">
					<xsl:with-param name="newName">xCoord</xsl:with-param>
				</xsl:apply-templates>
				<xsl:apply-templates select="$nodeSet//w131:northing"  mode="rename-measure">
					<xsl:with-param name="newName">yCoord</xsl:with-param>
				</xsl:apply-templates>
			</xsl:if>
			<xsl:if test="$nodeSet//w131:westing">
				<xsl:apply-templates select="$nodeSet//w131:westing"   mode="rename-measure">
					<xsl:with-param name="newName">xCoord</xsl:with-param>
				</xsl:apply-templates>
				<xsl:apply-templates select="$nodeSet//w131:southing"  mode="rename-measure">
					<xsl:with-param name="newName">yCoord</xsl:with-param>
				</xsl:apply-templates>
			</xsl:if>
			<xsl:if test="$nodeSet//w131:projectedX">
				<xsl:apply-templates select="$nodeSet//w131:projectedX" mode="rename-measure">
					<xsl:with-param name="newName">xCoord</xsl:with-param>
				</xsl:apply-templates>
				<xsl:apply-templates select="$nodeSet//w131:projectedY" mode="rename-measure">
					<xsl:with-param name="newName">yCoord</xsl:with-param>
				</xsl:apply-templates>
			</xsl:if>
			<xsl:variable name="inputType">
				<xsl:variable name="temp">
					<xsl:for-each select="$nodeSet//w131:original">
						<xsl:if test=". = 'true'">
							<xsl:choose>
								<xsl:when test="$nodeSet//w131:latitude!=''">Geographic</xsl:when>
								<xsl:when test="$nodeSet//w131:easting!='' or $nodeSet//w131:westing!='' or $nodeSet//w131:projectedX!=''">Projection</xsl:when>
								<xsl:when test="$nodeSet//w131:localX!=''">Local</xsl:when>
							</xsl:choose>
						</xsl:if>
					</xsl:for-each>
				</xsl:variable>
				<xsl:choose>
					<xsl:when test="$temp != ''"><xsl:value-of select="$temp"/></xsl:when>
					<!-- Use empty value if original was specified but we did not find a candidate. -->
					<xsl:when test="$nodeSet//w131:original"></xsl:when>
					<!-- Use Local as the default under the assumption that knowledge of Local
					     was lost because there were no local coordinates to retain the information. -->
					<xsl:otherwise>Local</xsl:otherwise>
				</xsl:choose>
			</xsl:variable>
			<xsl:call-template                                                 name="create-element">
				<xsl:with-param name="name">inputType</xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="$inputType"/></xsl:with-param>
				<xsl:with-param name="given">YES</xsl:with-param>
			</xsl:call-template>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template name="enum-value-Forward">
	<!-- Convert an old enumeration value to a new enumeration value. -->
	<!-- If there is not conversion, a null value will be returned. -->
	<xsl:param name="typeName"/>      <!-- The name of the element type. -->
	<xsl:param name="value"/>         <!-- The value to be converted. -->
	<xsl:variable name="valueIn" select="normalize-space($value)"/>
	<xsl:if test="$valueIn!=''">
		<xsl:variable name="typeStatus"><xsl:value-of select="$schemaDiffNodeSet//diff:oldEnumType[diff:name=$typeName]/diff:status"/></xsl:variable>
		<xsl:variable name="status"    ><xsl:value-of select="$schemaDiffNodeSet//diff:oldEnumType[diff:name=$typeName]//diff:oldValue[diff:name=$valueIn]/diff:status"/></xsl:variable>
		<xsl:variable name="newValue"  ><xsl:value-of select="$schemaDiffNodeSet//diff:oldEnumType[diff:name=$typeName]//diff:oldValue[diff:name=$valueIn]/diff:newValue"/></xsl:variable>
		<xsl:choose>
			<xsl:when test="$typeStatus='ADD'"><xsl:text>ERROR-ENUM-VALUE-FORWARD-ADD-TYPE=</xsl:text><xsl:value-of select="$typeName"/></xsl:when>
			<xsl:when test="$typeStatus='DELETE'"><xsl:text>ERROR-ENUM-VALUE-FORWARD-DELETE-TYPE=</xsl:text><xsl:value-of select="$typeName"/></xsl:when>
			<xsl:when test="$status=''">
				<xsl:value-of select="$valueIn"/>
			</xsl:when>
			<xsl:when test="$status='DUPLICATE'">
				<xsl:value-of select="$newValue"/>
			</xsl:when>
			<xsl:when test="$status='RENAME'">
				<xsl:value-of select="$newValue"/>
			</xsl:when>
			<xsl:when test="$status='DELETE'"></xsl:when>
			<xsl:when test="$status='SPLIT'">
				<xsl:choose>
					<xsl:when test="$typeName='LogIndexType'">
						<xsl:choose>
							<xsl:when test="$valueIn='Depth'">
								<xsl:text>measured depth</xsl:text>
							</xsl:when>
							<xsl:otherwise>
								<xsl:text>ENUM-SPLIT-LogIndexType-</xsl:text><xsl:value-of select="$valueIn"/>
							</xsl:otherwise>
						</xsl:choose>
					</xsl:when>
					<xsl:otherwise>
						<xsl:text>ENUM-SPLIT-TYPE=</xsl:text><xsl:value-of select="$typeName"/><xsl:text>-VALUE=</xsl:text><xsl:value-of select="$valueIn"/>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:when>
			<xsl:otherwise>
				<xsl:text>ERROR-ENUM-VALUE-FORWARD-STATUS=</xsl:text><xsl:value-of select="$status"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</xsl:template>

<xsl:template name="enum-value-Backward">
	<!-- Convert a new enumeration value to an old enumeration value. -->
	<!-- If there is not conversion, a null value will be returned. -->
	<xsl:param name="typeName"/>      <!-- The name of the element type. -->
	<xsl:param name="value"/>         <!-- The value to be converted. -->
	<xsl:variable name="valueIn" select="normalize-space($value)"/>
	<xsl:if test="$valueIn!=''">
		<xsl:variable name="typeStatus"><xsl:value-of select="$schemaDiffNodeSet//diff:oldEnumType[diff:name=$typeName]/diff:status"/></xsl:variable>
		<xsl:variable name="status"    ><xsl:value-of select="$schemaDiffNodeSet//diff:oldEnumType[diff:name=$typeName]//diff:oldValue[diff:newValue=$valueIn]/diff:status"/></xsl:variable>
		<xsl:variable name="oldValue"  ><xsl:value-of select="$schemaDiffNodeSet//diff:oldEnumType[diff:name=$typeName]//diff:oldValue[diff:newValue=$valueIn]/diff:name"/></xsl:variable>
		<xsl:choose>
			<xsl:when test="$typeStatus='ADD'"><xsl:value-of select="$typeName"/></xsl:when>
			<xsl:when test="$typeStatus='DELETE'"><xsl:text>ERROR-ENUM-VALUE-BACKWARD-DELETE-TYPE=</xsl:text><xsl:value-of select="$typeName"/></xsl:when>
			<xsl:when test="$status=''">
				<xsl:value-of select="$valueIn"/>
			</xsl:when>
			<xsl:when test="$status='DUPLICATE'">
				<xsl:value-of select="$oldValue"/>
			</xsl:when>
			<xsl:when test="$status='RENAME'">
				<xsl:value-of select="$oldValue"/>
			</xsl:when>
			<xsl:when test="$status='ADD'"></xsl:when>
			<xsl:when test="$status='SPLIT'">
				<xsl:choose>
					<xsl:when test="$typeName='LogIndexType'">
						<xsl:value-of select="$oldValue"/>
					</xsl:when>
					<xsl:otherwise>
						<xsl:text>ENUM-SPLIT-TYPE=</xsl:text><xsl:value-of select="$typeName"/><xsl:text>-VALUE=</xsl:text><xsl:value-of select="$valueIn"/>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:when>
			<xsl:otherwise>
				<xsl:text>ERROR-ENUM-VALUE-BACKWARD-STATUS=</xsl:text><xsl:value-of select="$status"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</xsl:template>



<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!--               These templates are NOT specific to any one object.                        -->
<!--                  These templates are independent of direction.                           -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->



<xsl:template match="*" mode="copy-all">
	<!-- Copies the text and attribute content of an element and all sub-elements into a new namespace. --> 
	<!-- This copies the whole hierarchy into a new namespace. --> 
	<xsl:if test=".!='' or $retainEmpty='YES'">
		<xsl:element name="{name(.)}" namespace="{$newNameSpace}">
			<xsl:for-each select="./@*">
				<xsl:attribute name="{name(.)}"><xsl:value-of select="normalize-space(.)"/></xsl:attribute>
			</xsl:for-each>
			<xsl:if test="./child::*">
				<xsl:call-template name="linebreak"/>
			</xsl:if>
			<xsl:apply-templates mode="copy-all"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="text()" mode="copy-all">
	<!-- Copies the text content of an element. --> 
	<xsl:value-of select="normalize-space(.)"/>
</xsl:template>

<xsl:template match="comment()" mode="copy-all">
	<!-- Copies the comment content. --> 
	<xsl:comment><xsl:value-of select="."/></xsl:comment>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template name="copy-comment">
	<!-- Copies the child comments of the current node. --> 
	<xsl:apply-templates select="./child::comment()" mode="copy-all"/>
</xsl:template>

<xsl:template name="linebreak">
	<!-- Inserts a line break. -->
	<xsl:text>
</xsl:text>
</xsl:template>

<xsl:template match="*" mode="copy-of-customData">
	<!-- Copy the contents of the custom data container in its existing namespace. --> 
	<xsl:if test=".!='' or $retainEmpty='YES'">
		<xsl:element name="customData" namespace="{$newNameSpace}">
			<xsl:call-template name="linebreak"/>
			<xsl:call-template name="copy-comment"/>
			<xsl:copy-of  select="./*"/>
			<xsl:call-template name="linebreak"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="*" mode="copy-element">
	<!-- Create an element with the same name and text content but with a new namespace. --> 
	<!-- Any attributes will be ignored (i.e., not copied). --> 
	<!-- This should NOT be called for container elements. --> 
	<xsl:if test=".!='' or $retainEmpty='YES'">
		<xsl:element name="{name(.)}" namespace="{$newNameSpace}">
			<xsl:value-of select="normalize-space(.)"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="*" mode="rename-element">
	<!-- Create an element with the same text content but with a different name and namespace. -->
	<!-- Any attributes will be ignored (i.e., not copied). --> 
	<!-- This should NOT be called for container elements. --> 
	<xsl:param name="newName"/>
	<xsl:if test=".!='' or $retainEmpty='YES'">
		<xsl:element name="{$newName}" namespace="{$newNameSpace}">
			<xsl:value-of select="normalize-space(.)"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="*" mode="rename-classWitsml">
	<xsl:param name="newName"/>
	<xsl:variable name="classWitsml">
		<xsl:call-template name="convert-enum-value">
			<xsl:with-param name="typeName">RealtimeData</xsl:with-param>
			<xsl:with-param name="value">
				<xsl:value-of select="."/>
			</xsl:with-param>
		</xsl:call-template>
	</xsl:variable>
	<xsl:if test="$classWitsml!='' or $retainEmpty='YES'">
		<xsl:element name="{$newName}" namespace="{$newNameSpace}">
			<xsl:value-of select="$classWitsml"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template name="convert-enum-value">
	<!-- Convert an enumeration value. -->
	<!-- The conversion handles both foward and backward. -->
	<!-- If there is no conversion, the same value will be returned. -->
	<xsl:param name="typeName"/>   <!-- The name of the element type. -->
	<xsl:param name="value"/>      <!-- The value to be converted. -->
	<xsl:if test="normalize-space($value)!=''">
		<xsl:choose>
			<xsl:when test="$direction='forward'">
				<xsl:call-template name="enum-value-Forward">
					<xsl:with-param name="typeName"><xsl:value-of select="$typeName"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="$value"/></xsl:with-param>
				</xsl:call-template>
			</xsl:when>
			<xsl:when test="$direction='backward'">
				<xsl:call-template name="enum-value-Backward">
					<xsl:with-param name="typeName"><xsl:value-of select="$typeName"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="$value"/></xsl:with-param>
				</xsl:call-template>
			</xsl:when>
			<xsl:otherwise>ERROR-UNRECOGNIZED-DIRECTION</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</xsl:template>



<xsl:template match="*" mode="rename-enumeration-element">
	<!-- Rename an element with a converted enumeration value. -->
	<!-- The conversion handles both foward and backward. -->
	<xsl:param name="typeName"/>      <!-- The name of the element type. -->
	<xsl:param name="newName"/>       <!-- The new name of the element. -->
	<xsl:if test="normalize-space(.)!='' or $retainEmpty='YES'">
		<xsl:variable name="value">
			<xsl:call-template name="convert-enum-value">
				<xsl:with-param name="typeName"><xsl:value-of select="$typeName"/></xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:element name="{$newName}" namespace="{$newNameSpace}">
			<xsl:value-of select="$value"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="* | @*" mode="create-enumeration-element">
	<!-- Create an element with a converted enumeration value. -->
	<!-- The conversion handles both foward and backward. -->
	<xsl:param name="typeName"/>      <!-- The name of the enumeration type. -->
	<xsl:param name="name"/>          <!-- The name of the element. -->
	<xsl:if test="normalize-space(.)!='' or $retainEmpty='YES'">
		<xsl:variable name="newvalue">
			<xsl:if test=". != ''">
				<xsl:call-template name="convert-enum-value">
					<xsl:with-param name="typeName"><xsl:value-of select="$typeName"/></xsl:with-param>
					<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
				</xsl:call-template>
			</xsl:if>
		</xsl:variable>
		<xsl:element name="{$name}" namespace="{$newNameSpace}">
			<xsl:value-of select="$newvalue"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="*" mode="convert-enumeration-element">
	<!-- Create an element with a converted enumeration value. -->
	<!-- The same element name is assumed. -->
	<!-- The conversion handles both foward and backward. -->
	<xsl:param name="typeName"/>      <!-- The name of the element type. -->
	<xsl:if test="normalize-space(.)!='' or $retainEmpty='YES'">
		<xsl:variable name="value">
			<xsl:call-template name="convert-enum-value">
				<xsl:with-param name="typeName"><xsl:value-of select="$typeName"/></xsl:with-param>
				<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:element name="{name(.)}" namespace="{$newNameSpace}">
			<xsl:value-of select="$value"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="* | @*" mode="create-element">
	<!-- Create an element with the specified name and content. --> 
	<xsl:param name="name"/>
	<xsl:call-template                                           name="create-element">
		<xsl:with-param name="name"><xsl:value-of select="$name"/></xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template name="create-element">
	<!-- Create an element with the specified name and content. --> 
	<xsl:param name="name"/>
	<xsl:param name="value"/>
	<xsl:param name="given"/> <!-- YES if the element/attribute was actually specified. -->
	<xsl:if test="$given='YES' and ($value!='' or $retainEmpty='YES')">
		<xsl:element name="{$name}" namespace="{$newNameSpace}">
			<xsl:value-of select="normalize-space($value)"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template name="create-measure-without-uom">
	<!-- Create an element with the specified name and content. --> 
	<!-- This will create an element WITHOUT a uom attribute. --> 
	<!-- The value may be converted if the oldunit is not valid in the target version. --> 
	<!-- This is primarily intended for BACKWARD conversion to measures with an implied uom. --> 
	<xsl:param name="name"/>     <!-- The name of the element. -->
	<xsl:param name="oldunit"/>  <!-- The unit of measure. If null, no conversion will occur. -->
	<xsl:param name="oldvalue"/> <!-- The numeric value. -->
	<xsl:param name="newunit"/>  <!-- The unit of measure. This should only be specified if it is a valid uom in the target system. -->
	<xsl:param name="given"/>    <!-- YES if the element was specified. -->
	<xsl:if test="normalize-space($oldvalue)!='' or (normalize-space($oldvalue)='' and $retainEmpty='YES' and $given='YES')">
		<xsl:variable name="substitute-Unit">
			<xsl:choose>
				<xsl:when test="$oldunit=''"></xsl:when>
				<xsl:when test="$newunit=''">
					<xsl:call-template name="unit-substitute">
						<xsl:with-param name="unit">
							<xsl:value-of select="$oldunit"/>
						</xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="normalize-space($newunit)"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="$substitute-Unit=''">
				<!-- The uom is valid in the target schema. -->
				<xsl:element name="{$name}" namespace="{$newNameSpace}">
					<xsl:value-of select="normalize-space($oldvalue)"/>
				</xsl:element>
				<xsl:call-template name="linebreak"/>
			</xsl:when>
			<xsl:otherwise>
				<!-- The oldunit is NOT valid in the target schema. -->
				<!-- Convert the value to a new uom. -->
				<xsl:variable name="new-val">
					<xsl:call-template name="unit-convert">
						<xsl:with-param name="val"><xsl:value-of select="$oldvalue"/></xsl:with-param>
						<xsl:with-param name="oldunit"><xsl:value-of select="normalize-space($oldunit)"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$substitute-Unit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:variable>
				<xsl:element name="{$name}" namespace="{$newNameSpace}">
					<xsl:value-of select="$new-val"/>
				</xsl:element>
				<xsl:call-template name="linebreak"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</xsl:template>

<xsl:template name="create-measure">
	<!-- Create a measure element with the specified name and content. --> 
	<!-- This will create a measure element with a uom attribute. --> 
	<!-- The uom and value may be converted if the uom is not valid in the target version. --> 
	<xsl:param name="name"/>  <!-- The name of the element. -->
	<xsl:param name="unit"/>  <!-- The unit of measure. If not specified, a uom will not be created. -->
	<xsl:param name="value"/> <!-- The numeric value. -->
	<xsl:param name="given"/> <!-- YES if the element was specified. -->
	<xsl:if test="normalize-space($value)!='' or (normalize-space($value)='' and $retainEmpty='YES' and $given='YES')">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit">
					<xsl:value-of select="$unit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:choose>
			<xsl:when test="$substitute-Unit=''">
				<!-- The uom is valid in the target schema. -->
				<xsl:element name="{$name}" namespace="{$newNameSpace}">
					<xsl:if test="normalize-space($unit)!='' or $retainEmpty='YES'">
						<xsl:attribute name="uom"><xsl:value-of select="normalize-space($unit)"/></xsl:attribute>
					</xsl:if>
					<xsl:value-of select="normalize-space($value)"/>
				</xsl:element>
				<xsl:call-template name="linebreak"/>
			</xsl:when>
			<xsl:otherwise>
				<!-- The uom is NOT valid in the target schema. -->
				<!-- Convert the value to a new uom. -->
				<xsl:variable name="new-val">
					<xsl:call-template name="unit-convert">
						<xsl:with-param name="val"><xsl:value-of select="$value"/></xsl:with-param>
						<xsl:with-param name="oldunit"><xsl:value-of select="normalize-space($unit)"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$substitute-Unit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:variable>
				<xsl:element name="{$name}" namespace="{$newNameSpace}">
					<xsl:if test="$substitute-Unit!='' or $retainEmpty='YES'">
						<xsl:attribute name="uom"><xsl:value-of select="$substitute-Unit"/></xsl:attribute>
					</xsl:if>
					<xsl:value-of select="$new-val"/>
				</xsl:element>
				<xsl:call-template name="linebreak"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:if>
</xsl:template>

<xsl:template name="create-coordinate">
	<!-- Create a coordinate measure element with the specified name and content. --> 
	<!-- This will create a measure element with uom and datum attributes. --> 
	<!-- The uom and value may be converted if the uom is not valid in the target version. --> 
	<xsl:param name="name"/>  <!-- The name of the element. -->
	<xsl:param name="unit"/>  <!-- The unit of measure. -->
	<xsl:param name="value"/> <!-- The numeric value. -->
	<xsl:param name="datum"/> <!-- The datum value. -->
	<xsl:if test="normalize-space($value)!='' or $retainEmpty='YES'">
		<xsl:variable name="substitute-Unit">
			<xsl:call-template name="unit-substitute">
				<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
			</xsl:call-template>
		</xsl:variable>
		<xsl:variable name="newunit">
			<xsl:choose>
				<xsl:when test="$substitute-Unit=''">
					<!-- The uom is valid in the target schema. -->
					<xsl:value-of select="normalize-space($unit)"/>
				</xsl:when>
				<xsl:otherwise>
					<!-- The uom is NOT valid in the target schema. -->
					<xsl:value-of select="$substitute-Unit"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<xsl:variable name="newvalue">
			<xsl:choose>
				<xsl:when test="$substitute-Unit=''">
					<!-- The uom is valid in the target schema. -->
					<xsl:value-of select="normalize-space($value)"/>
				</xsl:when>
				<xsl:otherwise>
					<!-- The uom is NOT valid in the target schema. -->
					<!-- Convert the value to a new uom. -->
					<xsl:call-template name="unit-convert">
						<xsl:with-param name="val"><xsl:value-of select="$value"/></xsl:with-param>
						<xsl:with-param name="oldunit"><xsl:value-of select="normalize-space($unit)"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$substitute-Unit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<xsl:element name="{$name}" namespace="{$newNameSpace}">
			<xsl:attribute name="uom"><xsl:value-of select="normalize-space($newunit)"/></xsl:attribute>
			<xsl:if test="normalize-space($datum)!='' or $retainEmpty='YES'">
				<xsl:attribute name="datum"><xsl:value-of select="normalize-space($datum)"/></xsl:attribute>
			</xsl:if>
			<xsl:value-of select="normalize-space($newvalue)"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>

<xsl:template match="*" mode="copy-measure">
	<!-- Create an element with the same name and content but with a new namespace. --> 
	<!-- This should ONLY be called for measure elements with a uom attribute. --> 
	<!-- Any attribute other than uom will be ignored (i.e., datum). --> 
	<!-- The uom and value may be converted if the uom is not valid in the target version. -->
	<xsl:call-template name="create-measure">
		<xsl:with-param name="name"><xsl:value-of select="name(.)"/></xsl:with-param>
		<xsl:with-param name="unit"><xsl:value-of select="@uom"/></xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="*" mode="rename-measure">
	<!-- Create an element with the same content but with a different name and namespace. --> 
	<!-- This should ONLY be called for measure elements with a uom attribute. --> 
	<!-- Any attribute other than uom will be ignored (i.e., datum). --> 
	<xsl:param name="newName"/>
	<!-- The uom and value may be converted if the uom is not valid in the target version. --> 
	<xsl:call-template name="create-measure">
		<xsl:with-param name="name"><xsl:value-of select="$newName"/></xsl:with-param>
		<xsl:with-param name="unit"><xsl:value-of select="@uom"/></xsl:with-param>
		<xsl:with-param name="value"><xsl:value-of select="."/></xsl:with-param>
		<xsl:with-param name="given">YES</xsl:with-param>
	</xsl:call-template>
</xsl:template>

<xsl:template match="*" mode="copy-indexedObject">
	<!-- Create an element with the same name and content but with a new namespace. -->
	<!-- This should ONLY be called elements with a type of indexedObject. -->
	<xsl:element name="{name(.)}" namespace="{$newNameSpace}">
		<xsl:attribute name="index"><xsl:value-of select="normalize-space(@index)"/></xsl:attribute>
		<xsl:attribute name="name"><xsl:value-of select="normalize-space(@name)"/></xsl:attribute>
		<xsl:attribute name="uom"><xsl:value-of select="normalize-space(@uom)"/></xsl:attribute>
		<xsl:attribute name="description"><xsl:value-of select="normalize-space(@description)"/></xsl:attribute>
		<xsl:value-of select="normalize-space(.)"/>
	</xsl:element>
	<xsl:call-template name="linebreak"/>
</xsl:template>

<xsl:template match="*" mode="rename-indexedObject">
	<!-- Create an element with the same content but with a different name and namespace. -->
	<!-- This should ONLY be called elements with a type of indexedObject. --> 
	<xsl:param name="newName"/>
	<xsl:if test="normalize-space(.)!='' or $retainEmpty='YES'">
		<xsl:element name="{$newName}" namespace="{$newNameSpace}">
			<xsl:attribute name="index"><xsl:value-of select="normalize-space(@index)"/></xsl:attribute>
			<xsl:attribute name="name"><xsl:value-of select="normalize-space(@name)"/></xsl:attribute>
			<xsl:attribute name="uom"><xsl:value-of select="normalize-space(@uom)"/></xsl:attribute>
			<xsl:attribute name="description"><xsl:value-of select="normalize-space(@description)"/></xsl:attribute>
			<xsl:value-of select="normalize-space(.)"/>
		</xsl:element>
		<xsl:call-template name="linebreak"/>
	</xsl:if>
</xsl:template>


<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!--                           Unit of measure conversion.                                    -->
<!--               These templates are NOT specific to any one object.                        -->
<!--                  These templates are independent of direction.                           -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->
<!-- //////////////////////////////////////////////////////////////////////////////////////// -->


<xsl:template name="unit-substitute">
	<!-- For given 'from' uom, defines an equivalent 'to' uom. Null if there is no substitute. -->
	<xsl:param name="unit"/> 
	<xsl:choose>
		<xsl:when test="$direction='forward'">
			<xsl:call-template name="unit-substitute-Forward">
				<xsl:with-param name="unit">
					<xsl:value-of select="$unit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:when>
		<xsl:when test="$direction='backward'">
			<xsl:call-template name="unit-substitute-Backward">
				<xsl:with-param name="unit">
					<xsl:value-of select="$unit"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:when>
	</xsl:choose>
</xsl:template>


<xsl:template name="unit-substitute-Forward">
	<!-- For a v1.2 uom, defines an equivalent uom in v1.3.x. Null if there is no substitute. -->
	<xsl:param name="unit"/> 
	<xsl:choose>
		<xsl:when test="$unit=''"></xsl:when>
		<xsl:when test="$unit='(L/min)/bar'">L/bar.min</xsl:when>
		<xsl:when test="$unit='(m3/h)/kPa'">m3/kPa.h</xsl:when>
		<xsl:when test="$unit='1/N'">1/lbf</xsl:when>
		<xsl:when test="$unit='1000/s'">kEuc/s</xsl:when>
		<xsl:when test="$unit='1E-4cm2/s'">mm2/s</xsl:when>
		<xsl:when test="$unit='1N'">1/N</xsl:when>
		<xsl:when test="$unit='atm/hm'">atm/100m</xsl:when>
		<xsl:when test="$unit='bbl/(d.ft)'">bbl/d.ft</xsl:when>
		<xsl:when test="$unit='bbl/(d.kPa)'">bbl/kPa.d</xsl:when>
		<xsl:when test="$unit='bbl/(d.psi)'">bbl/psi.d</xsl:when>
		<xsl:when test="$unit='bbl/d.psi'">bbl/psi.d</xsl:when>
		<xsl:when test="$unit='bbl/hbbl'">bbl/100bbl</xsl:when>
		<xsl:when test="$unit='bbl/Mft3'">bbl/M(ft3)</xsl:when>
		<xsl:when test="$unit='Btu(million)/hr'">MBtu/hr</xsl:when>
		<xsl:when test="$unit='cu ft'">ft3</xsl:when>
		<xsl:when test="$unit='cu in'">in3</xsl:when>
		<xsl:when test="$unit='cu yd'">yd3</xsl:when>
		<xsl:when test="$unit='cubem'">mi3</xsl:when>
		<xsl:when test="$unit='curie'">Ci</xsl:when>
		<xsl:when test="$unit='dega/ft(100)'">dega/100ft</xsl:when>
		<xsl:when test="$unit='dega/m(30)'">dega/30ft</xsl:when>
		<xsl:when test="$unit='degF/ft(100)'">degF/100ft</xsl:when>
		<xsl:when test="$unit='dkN'">kN</xsl:when>
		<xsl:when test="$unit='dm3/km(100)'">dm3/100km</xsl:when>
		<xsl:when test="$unit='dms'">cs</xsl:when>
		<xsl:when test="$unit='fl ozUK'">flozUK</xsl:when>
		<xsl:when test="$unit='fl ozUS'">flozUS</xsl:when>
		<xsl:when test="$unit='fraction'">Euc</xsl:when>
		<xsl:when test="$unit='ft/10'">ft</xsl:when>
		<xsl:when test="$unit='ft3(std,60F)'">scf(60F)</xsl:when>
		<xsl:when test="$unit='ft3/sack'">ft3/sack94</xsl:when>
		<xsl:when test="$unit='gal/dbbl'">galUS/10bbl</xsl:when>
		<xsl:when test="$unit='gal/kgal'">galUS/kgalUS or galUS/kgalUS</xsl:when>
		<xsl:when test="$unit='gal/sack'">galUS/sack94</xsl:when>
		<xsl:when test="$unit='galUS/dbbl'">galUS/10bbl</xsl:when>
		<xsl:when test="$unit='grad'">gr</xsl:when>
		<xsl:when test="$unit='grain/ft3(100)'">grain/100ft3</xsl:when>
		<xsl:when test="$unit='gravity'">gn</xsl:when>
		<xsl:when test="$unit='in/1000'">mil</xsl:when>
		<xsl:when test="$unit='kft3'">1000ft3</xsl:when>
		<xsl:when test="$unit='kft3/(d.ft)'">1000ft3/d.ft</xsl:when>
		<xsl:when test="$unit='kft3/(d.psi)'">1000ft3/psi.d</xsl:when>
		<xsl:when test="$unit='kft3/bbl'">1000ft3/bbl</xsl:when>
		<xsl:when test="$unit='kft3/d'">1000ft3/d</xsl:when>
		<xsl:when test="$unit='kft3/d'">1000ft3/d</xsl:when>
		<xsl:when test="$unit='kkg/m3'">Mg/m3</xsl:when>
		<xsl:when test="$unit='kkgf'">Mgf</xsl:when>
		<xsl:when test="$unit='km3/(d.m)'">1000m3/d.m</xsl:when>
		<xsl:when test="$unit='km3/(h.m)'">1000m3/h.m</xsl:when>
		<xsl:when test="$unit='km3/d'">1000m3/d</xsl:when>
		<xsl:when test="$unit='km3/d'">1000m3/d</xsl:when>
		<xsl:when test="$unit='km3/h'">1000m3/h</xsl:when>
		<xsl:when test="$unit='km3/h'">1000m3/h</xsl:when>
		<xsl:when test="$unit='km4/d'">1000m4/d</xsl:when>
		<xsl:when test="$unit='kPa/hm'">kPa/100m</xsl:when>
		<xsl:when test="$unit='kPa/hm'">kPa/100m</xsl:when>
		<xsl:when test="$unit='L/dbbl'">L/10bbl</xsl:when>
		<xsl:when test="$unit='L/hkg'">L/100kg</xsl:when>
		<xsl:when test="$unit='L/km(100)'">L/100km</xsl:when>
		<xsl:when test="$unit='lbf/ft2(100)'">lbf/100ft2</xsl:when>
		<xsl:when test="$unit='lbf/hft'">lbf/100ft</xsl:when>
		<xsl:when test="$unit='lbm(million)/yr'">Mlbm/yr</xsl:when>
		<xsl:when test="$unit='lbm/ft.h'">lbm/h.ft</xsl:when>
		<xsl:when test="$unit='lbm/ft.s'">lbm/s.ft</xsl:when>
		<xsl:when test="$unit='lbm/galUK(1000)'">lbm/1000galUK</xsl:when>
		<xsl:when test="$unit='lbm/galUS(1000)'">lbm/1000galUS</xsl:when>
		<xsl:when test="$unit='lbm/hft2'">lbm/100ft2</xsl:when>
		<xsl:when test="$unit='m3(std,0C)'">scm(0C)</xsl:when>
		<xsl:when test="$unit='m3(std,15C)'">scm(15C)</xsl:when>
		<xsl:when test="$unit='m3/(d.bar)'">m3/bar.h</xsl:when>
		<xsl:when test="$unit='m3/(d.kPa)'">m3/kPa.d</xsl:when>
		<xsl:when test="$unit='m3/(d.m)'">m3/d.m</xsl:when>
		<xsl:when test="$unit='m3/(d.psi)'">m3/psi.d</xsl:when>
		<xsl:when test="$unit='m3/(h.bar)'">m3/bar.h</xsl:when>
		<xsl:when test="$unit='m3/(h.m)'">m3/h.m</xsl:when>
		<xsl:when test="$unit='m3/(min.bar)'">m3/bar.min</xsl:when>
		<xsl:when test="$unit='m3/(s.ft)'">m3/s.ft</xsl:when>
		<xsl:when test="$unit='m3/d.kPa'">m3/kPa.d</xsl:when>
		<xsl:when test="$unit='m3/s/Pa'">m3/Pa.s</xsl:when>
		<xsl:when test="$unit='mcurie'">mCi</xsl:when>
		<xsl:when test="$unit='meq/hg'">meq/100g</xsl:when>
		<xsl:when test="$unit='Mft3'">M(ft3)</xsl:when>
		<xsl:when test="$unit='Mft3/(acre.ft)'">M(ft3)/acre.ft</xsl:when>
		<xsl:when test="$unit='Mft3/d'">M(ft3)/d</xsl:when>
		<xsl:when test="$unit='Mft3/d'">M(ft3)/d</xsl:when>
		<xsl:when test="$unit='mi'">mi3</xsl:when>
		<xsl:when test="$unit='Mm3'">M(m3)</xsl:when>
		<xsl:when test="$unit='Mm3/d'">M(m3)/d</xsl:when>
		<xsl:when test="$unit='Mm3/d'">M(m3)/d</xsl:when>
		<xsl:when test="$unit='MMcf'">M(m3)</xsl:when>
		<xsl:when test="$unit='MPa2'">kPa2</xsl:when>
		<xsl:when test="$unit='Mpsi2'">kpsi2</xsl:when>
		<xsl:when test="$unit='Msm3'">MMscm(15C)</xsl:when>
		<xsl:when test="$unit='MY'">Ma</xsl:when>
		<xsl:when test="$unit='ncurie'">nCi</xsl:when>
		<xsl:when test="$unit='pcurie'">pCi</xsl:when>
		<xsl:when test="$unit='ppdk'">pp10k</xsl:when>
		<xsl:when test="$unit='psf'">lbf/ft2</xsl:when>
		<xsl:when test="$unit='psi/ft(100)'">psi/100ft</xsl:when>
		<xsl:when test="$unit='psi/ft(1000)'">psi/kft</xsl:when>
		<xsl:when test="$unit='psi/ft(1000)'">psi/kft</xsl:when>
		<xsl:when test="$unit='psi2.d/cp.ft3'">psi2.d/cP.ft3</xsl:when>
		<xsl:when test="$unit='psi2.d2/cp.ft6'">psi2.d2/cP.ft6</xsl:when>
		<xsl:when test="$unit='ptUS/dbbl'">ptUS/10bbl</xsl:when>
		<xsl:when test="$unit='pu'">%</xsl:when>
		<xsl:when test="$unit='rev/min'">rpm</xsl:when>
		<xsl:when test="$unit='s/10'">s</xsl:when>
		<xsl:when test="$unit='s/60'">s</xsl:when>
		<xsl:when test="$unit='s/qt'">s/qtUS</xsl:when>
		<xsl:when test="$unit='section'">miUS2</xsl:when>
		<xsl:when test="$unit='sg'">Euc</xsl:when>
		<xsl:when test="$unit='sievert'">Sv</xsl:when>
		<xsl:when test="$unit='sigma'">cu</xsl:when>
		<xsl:when test="$unit='sq ft'">ft2</xsl:when>
		<xsl:when test="$unit='sq in'">in2</xsl:when>
		<xsl:when test="$unit='sq mi'">m2</xsl:when>
		<xsl:when test="$unit='sq yd'">yd2</xsl:when>
		<xsl:when test="$unit='ton.mi'">tonfUS.mi</xsl:when>
		<xsl:when test="$unit='tonne.km'">kN.m</xsl:when>
		<xsl:when test="$unit='ucurie'">uCi</xsl:when>
		<xsl:when test="$unit='unitless'">Euc</xsl:when>
		<xsl:when test="$unit='volpercent'">%</xsl:when>
		<xsl:when test="$unit='volppm'">ppm</xsl:when>
		<xsl:when test="$unit='wtpercent'">%</xsl:when>
		<xsl:when test="$unit='wtppm'">ppm</xsl:when>
		<xsl:when test="$unit='yr(100k)'">100ka</xsl:when>
		<xsl:otherwise>
			<xsl:if test="$unitAliasSet//ua:unit[ua:alias=$unit]/ua:name != ''">
				<xsl:value-of select="$unitAliasSet//ua:unit[ua:alias=$unit]/ua:name"/>
			</xsl:if>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>

<xsl:template name="unit-substitute-Backward">
	<!-- For a v1.3.x uom, defines an equivalent uom in v1.2. Null if there is no substitute. -->
	<xsl:param name="unit"/> 
	<xsl:choose>
		<xsl:when test="$unit=''"></xsl:when>
		<!-- A new base unit. No substitution. -->
		<xsl:when test="$unit='gu'">ERROR-NO-EQUIVALENT-UNIT</xsl:when>
		<xsl:when test="$unit='J/K'">ERROR-NO-EQUIVALENT-UNIT</xsl:when>
		<xsl:when test="$unit='K/W'">ERROR-NO-EQUIVALENT-UNIT</xsl:when>
		<xsl:when test="$unit='m3/Pa/s'">ERROR-NO-EQUIVALENT-UNIT</xsl:when>
		<xsl:when test="$unit='Sv/s'">ERROR-NO-EQUIVALENT-UNIT</xsl:when>
		<xsl:when test="$unit='W/K'">ERROR-NO-EQUIVALENT-UNIT</xsl:when>
		<!-- Substitute the base unit. -->
		<xsl:when test="$unit='10Mg/m3'">kg/m3</xsl:when>
		<xsl:when test="$unit='bbl/k(ft3)'">Euc</xsl:when>
		<xsl:when test="$unit='d/k(ft3)'">s/m3</xsl:when>
		<xsl:when test="$unit='daN.m'">J</xsl:when>
		<xsl:when test="$unit='dega/30m'">rad/m</xsl:when>
		<xsl:when test="$unit='galUK/kgalUK'">Euc</xsl:when>
		<xsl:when test="$unit='galUS/kgalUS'">Euc</xsl:when>
		<xsl:when test="$unit='m3/bar.d'">m3/Pa.s</xsl:when>
		<xsl:when test="$unit='mgn'">m/s2</xsl:when>
		<xsl:when test="$unit='mrem'">Sv</xsl:when>
		<xsl:when test="$unit='mrem/h'">Sv/s</xsl:when>
		<xsl:when test="$unit='mSv/h'">Sv/s</xsl:when>
		<xsl:when test="$unit='rem'">Sv</xsl:when>
		<xsl:when test="$unit='rem/h'">Sv/s</xsl:when>
		<xsl:when test="$unit='s/qtUK'">s/m3</xsl:when>
		<xsl:when test="$unit='Sv/h'">Sv/s</xsl:when>
		<!-- Substitute an alias unit. -->
		<xsl:when test="$unit='1000ft3'">kft3</xsl:when>
		<xsl:when test="$unit='1000ft3/bbl'">kft3/bbl</xsl:when>
		<xsl:when test="$unit='1000ft3/d'">kft3/d</xsl:when>
		<xsl:when test="$unit='1000ft3/d.ft'">kft3/(d.ft)</xsl:when>
		<xsl:when test="$unit='1000ft3/psi.d'">kft3/(d.psi)</xsl:when>
		<xsl:when test="$unit='1000m3/d'">km3/d</xsl:when>
		<xsl:when test="$unit='1000m3/d.m'">km3/(d.m)</xsl:when>
		<xsl:when test="$unit='1000m3/h'">km3/h</xsl:when>
		<xsl:when test="$unit='1000m3/h.m'">km3/(h.m)</xsl:when>
		<xsl:when test="$unit='1000m4/d'">km4/d</xsl:when>
		<xsl:when test="$unit='100ka'">yr(100k)</xsl:when>
		<xsl:when test="$unit='bbl/100bbl'">bbl/hbbl</xsl:when>
		<xsl:when test="$unit='bbl/kPa.d'">bbl/(d.kPa)</xsl:when>
		<xsl:when test="$unit='bbl/M(ft3)'">bbl/Mft3</xsl:when>
		<xsl:when test="$unit='bbl/psi.d'">bbl/(d.psi)</xsl:when>
		<xsl:when test="$unit='Ci'">curie</xsl:when>
		<xsl:when test="$unit='cs'">dms</xsl:when>
		<xsl:when test="$unit='dega/100ft'">dega/ft(100)</xsl:when>
		<xsl:when test="$unit='degF/100ft'">degF/ft(100)</xsl:when>
		<xsl:when test="$unit='dm3/100km'">dm3/km(100)</xsl:when>
		<xsl:when test="$unit='flozUK'">fl ozUK</xsl:when>
		<xsl:when test="$unit='flozUS'">fl ozUS</xsl:when>
		<xsl:when test="$unit='ft3/sack94'">ft3/sack</xsl:when>
		<xsl:when test="$unit='galUS/10bbl'">gal/dbbl</xsl:when>
		<xsl:when test="$unit='galUS/sack94'">gal/sack</xsl:when>
		<xsl:when test="$unit='gn'">gravity</xsl:when>
		<xsl:when test="$unit='grain/100ft3'">grain/ft3(100)</xsl:when>
		<xsl:when test="$unit='kEuc/s'">1000/s</xsl:when>
		<xsl:when test="$unit='kPa/100m'">kPa/hm</xsl:when>
		<xsl:when test="$unit='kpsi2'">Mpsi2</xsl:when>
		<xsl:when test="$unit='L/100kg'">L/hkg</xsl:when>
		<xsl:when test="$unit='L/100km'">L/km(100)</xsl:when>
		<xsl:when test="$unit='L/10bbl'">L/dbbl</xsl:when>
		<xsl:when test="$unit='L/bar.min'">(L/min)/bar</xsl:when>
		<xsl:when test="$unit='lbf/100ft'">lbf/hft</xsl:when>
		<xsl:when test="$unit='lbf/100ft2'">lbf/ft2(100)</xsl:when>
		<xsl:when test="$unit='lbm/1000galUK'">lbm/galUK(1000)</xsl:when>
		<xsl:when test="$unit='lbm/1000galUS'">lbm/galUS(1000)</xsl:when>
		<xsl:when test="$unit='lbm/100ft2'">lbm/hft2</xsl:when>
		<xsl:when test="$unit='M(ft3)'">Mft3</xsl:when>
		<xsl:when test="$unit='M(ft3)/acre.ft'">Mft3/(acre.ft)</xsl:when>
		<xsl:when test="$unit='M(ft3)/d'">Mft3/d</xsl:when>
		<xsl:when test="$unit='M(m3)'">Mm3</xsl:when>
		<xsl:when test="$unit='M(m3)/d'">Mm3/d</xsl:when>
		<xsl:when test="$unit='m3/bar.h'">m3/(d.bar)</xsl:when>
		<xsl:when test="$unit='m3/bar.min'">m3/(min.bar)</xsl:when>
		<xsl:when test="$unit='m3/d.m'">m3/(d.m)</xsl:when>
		<xsl:when test="$unit='m3/h.m'">m3/(h.m)</xsl:when>
		<xsl:when test="$unit='m3/kPa.d'">m3/(d.kPa)</xsl:when>
		<xsl:when test="$unit='m3/kPa.h'">(m3/h)/kPa</xsl:when>
		<xsl:when test="$unit='m3/psi.d'">m3/(d.psi)</xsl:when>
		<xsl:when test="$unit='m3/s.ft'">m3/(s.ft)</xsl:when>
		<xsl:when test="$unit='MBtu/hr'">Btu(million)/hr</xsl:when>
		<xsl:when test="$unit='mCi'">mcurie</xsl:when>
		<xsl:when test="$unit='meq/100g'">meq/hg</xsl:when>
		<xsl:when test="$unit='Mg/m3'">kkg/m3</xsl:when>
		<xsl:when test="$unit='Mgf'">kkgf</xsl:when>
		<xsl:when test="$unit='Mlbm/yr'">lbm(million)/yr</xsl:when>
		<xsl:when test="$unit='MMscm(15C)'">Msm3</xsl:when>
		<xsl:when test="$unit='nCi'">ncurie</xsl:when>
		<xsl:when test="$unit='pCi'">pcurie</xsl:when>
		<xsl:when test="$unit='psi/100ft'">psi/ft(100)</xsl:when>
		<xsl:when test="$unit='psi/kft'">psi/ft(1000)</xsl:when>
		<xsl:when test="$unit='psi2.d/cP.ft3'">psi2.d/cp.ft3</xsl:when>
		<xsl:when test="$unit='psi2.d2/cP.ft6'">psi2.d2/cp.ft6</xsl:when>
		<xsl:when test="$unit='ptUS/10bbl'">ptUS/dbbl</xsl:when>
		<xsl:when test="$unit='s/qtUS'">s/qt</xsl:when>
		<xsl:when test="$unit='uCi'">ucurie</xsl:when>
		<xsl:when test="$unit='yd3'">cu yd</xsl:when>
		<xsl:otherwise></xsl:otherwise>
	</xsl:choose>
</xsl:template>

<xsl:template name="unit-convert">
	<!-- Convert a value from one unit to another. -->
	<xsl:param name="val"/>     <!-- The old value. -->
	<xsl:param name="oldunit"/>    <!-- The old unit. -->
	<xsl:param name="newunit"/> <!-- Convert to this target unit. -->
	<xsl:choose>
		<xsl:when test="$direction='forward'">
			<xsl:variable name="unit">
				<xsl:choose>
					<xsl:when test="$unitAliasSet//ua:unit[ua:alias=$oldunit]/ua:name != ''">
						<xsl:value-of select="$unitAliasSet//ua:unit[ua:alias=$oldunit]/ua:name"/>
					</xsl:when>
					<xsl:otherwise>
						<xsl:value-of select="$oldunit"/>
					</xsl:otherwise>
				</xsl:choose>
			</xsl:variable>
			<xsl:variable name="substitute-Unit">
				<xsl:call-template name="unit-substitute-Forward">
					<xsl:with-param name="unit">
						<xsl:value-of select="$unit"/>
					</xsl:with-param>
				</xsl:call-template>
			</xsl:variable>
			<xsl:variable name="substitute-NewUnit">
				<xsl:call-template name="unit-substitute-Forward">
					<xsl:with-param name="unit">
						<xsl:value-of select="$newunit"/>
					</xsl:with-param>
				</xsl:call-template>
			</xsl:variable>
			<xsl:choose>
				<xsl:when test="$substitute-Unit='' and $substitute-NewUnit=''">
					<!-- Both units are valid in both versions. -->
					<!-- The newer version has more accurate conversion factors. -->
					<xsl:call-template name="unit-convert-131">
						<xsl:with-param name="val"><xsl:value-of select="$val"/></xsl:with-param>
						<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:when test="contains($substitute-Unit,'ERROR-')">
					<!-- Something is wrong.  -->
					<xsl:value-of select="$substitute-Unit"/>
				</xsl:when>
				<xsl:when test="contains($substitute-NewUnit,'ERROR-')">
					<!-- Something is wrong.  -->
					<xsl:value-of select="$substitute-NewUnit"/>
				</xsl:when>
				<xsl:otherwise>
					<!-- Convert to the base unit in the source version and then 
					     convert to the unit in the target version. -->
					<xsl:variable name="unit-base">
						<!-- The base unit for 'unit'. -->
						<xsl:call-template name="base-unit-120">
							<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
						</xsl:call-template>
					</xsl:variable>
					<xsl:variable name="to-unit">
						<!-- The target unit. -->
						<xsl:choose>
							<xsl:when test="$substitute-NewUnit!=''">
								<!-- The new unit is NOT valid in the target schema. -->
								<xsl:value-of select="$substitute-NewUnit"/>
							</xsl:when>
							<xsl:when test="$newunit=$substitute-Unit">
								<!-- The substitution has already been performed. -->
								<xsl:value-of select="$newunit"/>
							</xsl:when>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="val-base">
						<!-- The value in units of 'unit-base'. -->
						<xsl:call-template name="unit-convert-120">
							<xsl:with-param name="val"><xsl:value-of select="$val"/></xsl:with-param>
							<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
							<xsl:with-param name="newunit"><xsl:value-of select="$unit-base"/></xsl:with-param>
						</xsl:call-template>
					</xsl:variable>
					<xsl:call-template name="unit-convert-131">
						<xsl:with-param name="val"><xsl:value-of select="$val-base"/></xsl:with-param>
						<xsl:with-param name="unit"><xsl:value-of select="$unit-base"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$to-unit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:when>
		<xsl:when test="$direction='backward'">
			<xsl:variable name="unit">
				<xsl:value-of select="$oldunit"/>
			</xsl:variable>
			<xsl:variable name="substitute-Unit">
				<xsl:call-template name="unit-substitute-Backward">
					<xsl:with-param name="unit">
						<xsl:value-of select="$unit"/>
					</xsl:with-param>
				</xsl:call-template>
			</xsl:variable>
			<xsl:variable name="substitute-NewUnit">
				<xsl:call-template name="unit-substitute-Backward">
					<xsl:with-param name="unit">
						<xsl:value-of select="$newunit"/>
					</xsl:with-param>
				</xsl:call-template>
			</xsl:variable>
			<xsl:choose>
				<xsl:when test="$substitute-Unit='' and $substitute-NewUnit=''">
					<!-- Both units are valid in both versions. -->
					<!-- The newer version has more accurate conversion factors. -->
					<xsl:call-template name="unit-convert-131">
						<xsl:with-param name="val"><xsl:value-of select="$val"/></xsl:with-param>
						<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$newunit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:when>
				<xsl:when test="contains($substitute-Unit,'ERROR-')">
					<!-- Something is wrong.  -->
					<xsl:value-of select="$substitute-Unit"/>
				</xsl:when>
				<xsl:when test="contains($substitute-NewUnit,'ERROR-')">
					<!-- Something is wrong.  -->
					<xsl:value-of select="$substitute-NewUnit"/>
				</xsl:when>
				<xsl:otherwise>
					<!-- Convert to the base unit in the source version and then 
					     convert to the final unit in the target version. -->
					<xsl:variable name="unit-base">
						<!-- The base unit for 'unit'. -->
						<xsl:call-template name="base-unit-131">
							<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
						</xsl:call-template>
					</xsl:variable>
					<xsl:variable name="to-unit">
						<!-- The target unit. -->
						<xsl:choose>
							<xsl:when test="$substitute-NewUnit!=''">
								<!-- The new unit is NOT valid in the target schema. -->
								<xsl:value-of select="$substitute-NewUnit"/>
							</xsl:when>
							<xsl:when test="$newunit=$substitute-Unit">
								<!-- The substitution has already been performed. -->
								<xsl:value-of select="$newunit"/>
							</xsl:when>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="val-base">
						<!-- The value in units of 'unit-base'. -->
						<xsl:call-template name="unit-convert-131">
							<xsl:with-param name="val"><xsl:value-of select="$val"/></xsl:with-param>
							<xsl:with-param name="unit"><xsl:value-of select="$unit"/></xsl:with-param>
							<xsl:with-param name="newunit"><xsl:value-of select="$unit-base"/></xsl:with-param>
						</xsl:call-template>
					</xsl:variable>
					<xsl:call-template name="unit-convert-120">
						<xsl:with-param name="val"><xsl:value-of select="$val-base"/></xsl:with-param>
						<xsl:with-param name="unit"><xsl:value-of select="$unit-base"/></xsl:with-param>
						<xsl:with-param name="newunit"><xsl:value-of select="$to-unit"/></xsl:with-param>
					</xsl:call-template>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:when>
	</xsl:choose>
</xsl:template>

<xsl:template name="base-unit-120">
	<!-- Determine the base unit for a v1.2 uom. -->
	<xsl:param name="unit"/>
	<xsl:choose>
		<xsl:when test="contains($unit,'ERROR-')">
			<!-- Something is wrong.  -->
			<xsl:value-of select="$unit"/>
		</xsl:when>
		<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:BaseUnit">
			<!-- The unit is already a base unit.  -->
			<xsl:value-of select="$unit"/>
		</xsl:when>
		<xsl:otherwise>
			<!-- Note that the baseUnit string is an internal reference containing a #. -->
			<xsl:value-of select="substring-after($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//@baseUnit,'#')"/>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>

<xsl:template name="base-unit-131">
	<!-- Determine the base unit for a v1.3.1 uom. -->
	<!-- The only real difference in the schemas of the two versions is the namespace. -->
	<xsl:param name="unit"/>
	<xsl:choose>
		<xsl:when test="contains($unit,'ERROR-')">
			<!-- Something is wrong.  -->
			<xsl:value-of select="$unit"/>
		</xsl:when>
		<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:BaseUnit">
			<!-- The unit is already a base unit.  -->
			<xsl:value-of select="$unit"/>
		</xsl:when>
		<xsl:otherwise>
			<xsl:value-of select="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]/posc:ConversionToBaseUnit/@baseUnit"/>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>

<xsl:template name="unit-convert-120">
	<!-- Convert a value from one v120 unit to another. -->
	<xsl:param name="val"/>     <!-- The old value. -->
	<xsl:param name="unit"/>    <!-- The old unit. -->
	<xsl:param name="newunit"/> <!-- Convert to this unit. -->
	<xsl:variable name="oldBase">
		<xsl:choose>
			<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:BaseUnit">
				<!-- The unit is the base unit.  -->
				<xsl:value-of select="$unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:ConversionToBaseUnit/@baseUnit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="newBase">
		<xsl:choose>
			<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:BaseUnit">
				<!-- The unit is the base unit.  -->
				<xsl:value-of select="$newunit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:ConversionToBaseUnit/@baseUnit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="valBase">
		<!-- Convert to the base unit. -->
		<xsl:choose>
			<xsl:when test="$newunit = $unit">
				<!-- The units are the same. Do nothing. -->
			</xsl:when>
			<xsl:when test="contains($newunit,'ERROR-')">
				<!-- Something is wrong. -->
				<xsl:value-of select="$newunit"/>
			</xsl:when>
			<xsl:when test="contains($unit,'ERROR-')">
				<!-- Something is wrong. -->
				<xsl:value-of select="$unit"/>
			</xsl:when>
			<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:Factor">
				<xsl:value-of select="
					number($val) 
					*
					number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:Factor)
				"/>
			</xsl:when>
			<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:Fraction">
				<xsl:value-of select="
					number($val) 
					*
					number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:Numerator)
					div
					number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:Denominator)
				"/>
			</xsl:when>
			<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:Formula">
				<xsl:variable name="A">
					<xsl:choose>
						<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:A">
							<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:A)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:variable name="B">
					<xsl:choose>
						<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:B">
							<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:B)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:variable name="C">
					<xsl:choose>
						<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:C">
							<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:C)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:variable name="D">
					<xsl:choose>
						<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:D">
							<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:D)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:value-of select="($A + ($B * number($val))) div ($C + ($D * number($val)))"/>
			</xsl:when>
			<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//posc:BaseUnit">
				<!-- The unit is already a base unit.  -->
				<xsl:value-of select="number($val)"/>
			</xsl:when>
			<xsl:otherwise>ERROR-IN-UOM-CONVERSION</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:choose>
		<xsl:when test="$oldBase != $newBase">
			<!-- The base units are different. -->
			<xsl:text>ERROR-THE-BASE-UNITS-OF-</xsl:text>
			<xsl:value-of select="$unit"/>
			<xsl:text>-AND-</xsl:text>
			<xsl:value-of select="$newunit"/>
			<xsl:text>-ARE-DIFFERENT</xsl:text>
		</xsl:when>
		<xsl:when test="$newunit = $unit">
			<!-- The units are the same. No conversion is necessary. -->
			<xsl:value-of select="$val"/>
		</xsl:when>
		<xsl:when test="$newunit = substring-after($uomNodeSet120//pr:UnitOfMeasure[@annotation=$unit]//@baseUnit,'#')">
			<!-- The base unit is the new unit. Note that the base unit string is an internal reference containing a #. -->
			<xsl:value-of select="$valBase"/>
		</xsl:when>
		<xsl:otherwise>
			<!-- Convert from base unit to the new unit.  -->
			<!-- Note that the conversion formulas are reversed in this direction. -->
			<xsl:choose>
				<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:Factor">
					<xsl:value-of select="
						number($valBase) 
						div
						number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:Factor)
					"/>
				</xsl:when>
				<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:Fraction">
					<xsl:value-of select="
						number($valBase) 
						*
						number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:Denominator)
						div
						number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:Numerator)
					"/>
				</xsl:when>
				<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:Formula">
					<xsl:variable name="A">
						<xsl:choose>
							<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:A">
								<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:A)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="B">
						<xsl:choose>
							<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:B">
								<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:B)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="C">
						<xsl:choose>
							<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:C">
								<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:C)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="D">
						<xsl:choose>
							<xsl:when test="$uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:D">
								<xsl:value-of select="number($uomNodeSet120//pr:UnitOfMeasure[@annotation=$newunit]//posc:D)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:value-of select="($A + ($B * number($valBase))) div ($C + ($D * number($valBase)))"/>
				</xsl:when>
				<xsl:otherwise>ERROR-IN-UOM-CONVERSION</xsl:otherwise>
			</xsl:choose>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>

<xsl:template name="unit-convert-131">
	<!-- Convert a value from one v131 unit to another. -->
	<xsl:param name="val"/>     <!-- The old value. -->
	<xsl:param name="unit"/>    <!-- The old unit. -->
	<xsl:param name="newunit"/> <!-- Convert to this unit. -->
	<xsl:variable name="oldBase">
		<xsl:choose>
			<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:BaseUnit">
				<!-- The unit is the base unit.  -->
				<xsl:value-of select="$unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:ConversionToBaseUnit/@baseUnit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="newBase">
		<xsl:choose>
			<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:BaseUnit">
				<!-- The unit is the base unit.  -->
				<xsl:value-of select="$unit"/>
			</xsl:when>
			<xsl:otherwise>
				<xsl:value-of select="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:ConversionToBaseUnit/@baseUnit"/>
			</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:variable name="valBase">
		<!-- Convert to the base unit. -->
		<xsl:choose>
			<xsl:when test="contains($newunit,'ERROR-')">
				<!-- Something is wrong. -->
				<xsl:value-of select="$newunit"/>
			</xsl:when>
			<xsl:when test="contains($unit,'ERROR-')">
				<!-- Something is wrong. -->
				<xsl:value-of select="$unit"/>
			</xsl:when>
			<xsl:when test="$newunit = $unit">
				<!-- The units are the same. Do nothing. -->
			</xsl:when>
			<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:Factor">
				<xsl:value-of select="
					number($val) 
					*
					number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:Factor)
				"/>
			</xsl:when>
			<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:Fraction">
				<xsl:value-of select="
					number($val) 
					*
					number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:Numerator)
					div
					number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:Denominator)
				"/>
			</xsl:when>
			<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:Formula">
				<xsl:variable name="A">
					<xsl:choose>
						<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:A">
							<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:A)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:variable name="B">
					<xsl:choose>
						<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:B">
							<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:B)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:variable name="C">
					<xsl:choose>
						<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:C">
							<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:C)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:variable name="D">
					<xsl:choose>
						<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:D">
							<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:D)"/>
						</xsl:when>
						<xsl:otherwise>number(1)</xsl:otherwise>
					</xsl:choose>
				</xsl:variable>
				<xsl:value-of select="($A + ($B * number($val))) div ($C + ($D * number($val)))"/>
			</xsl:when>
			<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//posc:BaseUnit">
				<!-- The unit is already a base unit.  -->
				<xsl:value-of select="number($val)"/>
			</xsl:when>
			<xsl:otherwise>ERROR-IN-UOM-CONVERSION</xsl:otherwise>
		</xsl:choose>
	</xsl:variable>
	<xsl:choose>
		<xsl:when test="$oldBase != $newBase">
			<!-- The base units are different. -->
			<xsl:text>ERROR-THE-BASE-UNITS-OF-</xsl:text>
			<xsl:value-of select="$unit"/>
			<xsl:text>-AND-</xsl:text>
			<xsl:value-of select="$newunit"/>
			<xsl:text>-ARE-DIFFERENT</xsl:text>
		</xsl:when>
		<xsl:when test="$newunit = $unit">
			<!-- The units are the same. No conversion is necessary. -->
			<xsl:value-of select="$val"/>
		</xsl:when>
		<xsl:when test="$newunit = $uomNodeSet131//posc:UnitOfMeasure[@annotation=$unit]//@baseUnit">
			<!-- The base unit is the new unit. -->
			<xsl:value-of select="$valBase"/>
		</xsl:when>
		<xsl:otherwise>
			<!-- Convert from base unit to the new unit.  -->
			<!-- Note that the conversion formulas are reversed in this direction. -->
			<xsl:choose>
				<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:Factor">
					<xsl:value-of select="
						number($valBase) 
						div
						number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:Factor)
					"/>
				</xsl:when>
				<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:Fraction">
					<xsl:value-of select="
						number($valBase) 
						*
						number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:Denominator)
						div
						number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:Numerator)
					"/>
				</xsl:when>
				<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:Formula">
					<xsl:variable name="A">
						<xsl:choose>
							<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:A">
								<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:A)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="B">
						<xsl:choose>
							<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:B">
								<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:B)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="C">
						<xsl:choose>
							<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:C">
								<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:C)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:variable name="D">
						<xsl:choose>
							<xsl:when test="$uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:D">
								<xsl:value-of select="number($uomNodeSet131//posc:UnitOfMeasure[@annotation=$newunit]//posc:D)"/>
							</xsl:when>
							<xsl:otherwise>number(1)</xsl:otherwise>
						</xsl:choose>
					</xsl:variable>
					<xsl:value-of select="($A + ($B * number($valBase))) div ($C + ($D * number($valBase)))"/>
				</xsl:when>
				<xsl:otherwise>ERROR-IN-UOM-CONVERSION</xsl:otherwise>
			</xsl:choose>
		</xsl:otherwise>
	</xsl:choose>
</xsl:template>

</xsl:transform>
