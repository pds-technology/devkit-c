[![Build status](https://ci.appveyor.com/api/projects/status/pbqh9kgp6bxf81bm?svg=true)](https://ci.appveyor.com/project/PDS/devkit-c)
[![Coverity Scan Build Status](https://scan.coverity.com/projects/20691/badge.svg)](https://scan.coverity.com/projects/pds-technology-devkit-c)

##  What is this repository for? 
  The devkit is a C# development environment.

##   How do I get set up?   
###   Summary of set up  
Download the code from BitBucket.  Building the DevKit relies on passing the root folder of the repository to the applications by using the --root-folder command line argument or the ROOT_FOLDER App.Config setting. 

###The repository root folder contains the following sub-folders:

doc - Contains the Energistics schemas.

source - Contains the following folders:

*  Devkit:  The original Devkit. 
*  DevKitGenerator: This is where the Devkit java classes can be found.    
*  DevkitTest: This is the folder containing the unit tests. 
*  DemoXML: This is folder that contains the generated sample xml files which support DevkitTest.   
*  EnergisticsAPIService: This is the webservice API project.   

##   Configuration.    
* App.Config: Contains the project's configuration mappings.  

##    Dependencies

* Download the HDF5 Library. Check that the folder where the DLL resides, C:\Program Files\HDF Group\HDF5\1.8.9\bin, by default, is specified in the PATH environment variable.