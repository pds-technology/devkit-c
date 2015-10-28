##  What is this repository for? 
  devkit c provides kit to the c developer  

##   How do I get set up?   
###   Summary of set up  
 download the code for bitbucket, restore to the directory which will be used in app.config.
 in our default, we restore to c:\projects, for your convinience, please don't change the internal structure, then your only need to modify the root folder which point to c:\projects.
  <add key="ROOT_FOLDER" value="C:\Projects" />
 in projects folder we will have: 
    * doc: document contains the all supported energistics xsd for user's convenience. 
*     source: contains project: 
*     Devkit:  this is old Devkit, we are using DevkitTest to perform test using the supplied sample xml. 
*     DevKitGenerator: this is project that generator all devkit java classes.  
*     DekitTest: this is testing project that using the example xml from demoXML folder. 
*     DemoXML: this is folder that contains all sample xml which supports DevkitTest. 
*     EnergisticsAPIService: this is webservice api project. 

##   Configuration.  
*  app.config has contains all supported project's mapping.
* if you only need to generator certain ml, for example only WITSML1.4.1.1
* you need to change key "Sets" to be <add key="SETS" value= WITSML141"/>.
* you need to have WITSML1.4.1.1 configuration, you might or might not remove rest configure for other ML.  

##    Dependencies

  Download the HDF5library, make sure the C:\Program Files\HDF Group\HDF5\1.8.9\bin (the HDF installation path, might be different in your install machine) and must be present in a directory that is part of your PATH environment variable.