##  What is this repository for? 
  The devkit is a C# development environment.

##   How do I get set up?   
###   Summary of set up  
Download the code from BitBucket.  It is suggested that the destination directory be C:\Projects.  The App.Config configuration file defines a Key named "ROOT_FOLDER" which has the value "C:\Projects".  Change this value if you prefer a different folder, but it is highly-recommended not to alter the other file linkages. 

###The created source_master folder contains the following sub-folders:
* Doc - Contains the Energistics schemas 
* Source: Contains the following folders:

*  Devkit:  The original Devkit. 
*  DevKitGenerator: This is where the Devkit java classes can be found.    
*  DevkitTest: This is the folder containing the unit tests. 
*  DemoXML: This is folder that contains the generated sample xml files which support DevkitTest.   
*  EnergisticsAPIService: This is webservice API project.   

##   Configuration.    
* App.Config: Contains the project's configuration mappings.  

##    Dependencies

* Download the HDF5 Library. Check that the folder where the DLL resides, C:\Program Files\HDF Group\HDF5\1.8.9\bin, by default, is specified in the PATH environment variable.