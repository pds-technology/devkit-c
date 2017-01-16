##  What is this repository for? 
  The devkit is a C# development environment.

##   How do I get set up?   
###   Summary of set up  
Download the code from BitBucket.  It is suggested that the destination directory be C:\Projects.  The App.Config configuration file defines a Key named "ROOT_FOLDER" which has the value "C:\Projects".  Change this value if you prefer a different folder, but it is highly-recommended not to alter the other file linkages. 

The created source_master folder contains the following sub-folders:
- Doc - Contains the Energistics schemas 
- Source: Contains the following folders:

    *  Devkit:  The original Devkit. 
    *  DevKitGenerator: This is where the Devkit java classes can be found.    
    *  DevkitTest: This is the folder containing the unit tests. 
    *  DemoXML: This is folder that contains the generated sample xml files which support DevkitTest.   
    *  EnergisticsAPIService: This is webservice API project.   

##   Configuration.    
*  app.config has contains all supported project's mapping.  
* if you only need to generator certain ml, for example only WITSML1.4.1.1  
* you need to change key "Sets" to be <add key="SETS" value= WITSML141"/>.  
* you need to have WITSML1.4.1.1 configuration, you might or might not remove rest configure.    

##    Dependencies

  Download the HDF5library, make sure the C:\Program Files\HDF Group\HDF5\1.8.9\bin (the HDF installation path,   might be different in your install machine) and must be present in a directory that is part of your PATH environment variable.