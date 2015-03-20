The schemas within this folder represent profiled (subsetted) versions of the normative schemas that can be found at:
	http://schemas.opengis.net/gml/3.2.1/
	http://schemas.opengis.net/iso/19139/20070417/
	http://schemas.opengis.net/xlink/

The purpose of profiling is to eliminate items which are not needed within the context of RESQML but in some cases optional information has been made mandatory.
The use of profiled schemas is recommended when generating proxy code using toolsets such as .NET.
Any XML which conforms to the profiled schemas will also conform to the normative schemas (but not necessarily the reverse).
For situations where use of a normative schema is desired then replace the contents of the relevant folder with the normative copy in the same relative folder structure.
