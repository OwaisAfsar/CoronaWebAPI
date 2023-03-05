# CoronaWebAPI

The WEB API is providing data about the Covid patient. The CRUD operation is applied on this API. 

Following are the variables:
* Patient ID
* First Name
* Last Name
* State
* Time Stamp

The data is hard coded but the CRUD operations are performing Add, Update, Delete, Search via State and Time Stamp.

Following are the URLs:
* For retrieving all the patients: "/api/patients"
* For retrieving the patients via State: "/api/patients/state/{state}"
* For retrieving the patients via Time Stamp: "/api/patients/date/{date}"
