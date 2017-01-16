##  What is this repository for? 
  The devkit is a C# development environment.

##   How do I get set up?   
###   Summary of set up  
Download the code from BitBucket.  It is suggested that the destination directory be C:\Projects.  The App.Config configuration file defines a Key named "ROOT_FOLDER" which has the value "C:\Projects".  Change this value if you prefer a different folder, but it is highly-recommended not to alter the other file linkages. 

 in projects folder we will have:   
 doc: document contains the all supported energistics xsd for user's convenience.   
 source: contains project:   
    *  Devkit:  this is old Devkit, we are using DevkitTest to perform test using the supplied sample XML.   
    *  DevKitGenerator: this is project that generator all devkit java classes.    
    *  DekitTest: this is testing project that using the example xml from demoXML folder.   
    *  DemoXML: this is folder that contains all sample xml which supports DevkitTest.   
    *  EnergisticsAPIService: this is webservice api project.   

##   Configuration.    
*  app.config has contains all supported project's mapping.  
* if you only need to generator certain ml, for example only WITSML1.4.1.1  
* you need to change key "Sets" to be <add key="SETS" value= WITSML141"/>.  
* you need to have WITSML1.4.1.1 configuration, you might or might not remove rest configure.    

##    Dependencies

  Download the HDF5library, make sure the C:\Program Files\HDF Group\HDF5\1.8.9\bin (the HDF installation path,   might be different in your install machine) and must be present in a directory that is part of your PATH environment variable.