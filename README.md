![](http://rocketelevator.ca/assets/R2-3c6296bf2343b849b947f8ccfce0de61dd34ba7f9e2a23a53d0a743bc4604e3c.png)


| Users  | Emails  | Passwords |
| :------------ |:---------------:| -----:|
| Philippe Bouillon | philippe.bouillon@codeboxx.biz | 123456 |
| Mathieu LeFrançois | mathieu.lefrançois@codeboxx.biz | 123456 |
| Mathieu Houd | mathieu.houde@codeboxx.biz | 123456 |
| Remi Gagnon | remi.gagnon@codeboxx.biz | 123456 |
| Serge Savoie | serge.savoie@codeboxx.biz | 123456 |
| Felix-Antoine | felix-antoine.paradis@codeboxx.biz | 123456 |
| Nadya Fortier | nadya.fortier@codeboxx.biz | 123456 |



###  # Rocket_Elevators_REST_API :
<h4> URL links is http://rocket-elevator-api.azurewebsites.net 
  
- to test the api on a interface : marcantoinetanguay.com : select INFOS in navbar (PUT method NOT working, GET method work and GET method by ID (when clicking on a row) work but we have to reload the page, make a search in the table from the search bar or make queries for tables to be interactives. Its like we need to make action for the tables to reload to be able to get the pages to be dynamic (strange behavior sorry did finished on time) 

  API CALL LIST
  
- To Retrieving an Battery for a Specified Battery use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/battery/{id}

- To Retrieving the Current Status and Id only of all Battery use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/battery/status

- To Retrieving the infos of all batteries use
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/battery


- To Retrieving the Current Status and Id only of all Column use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/column/status

- To Retrieving the infos of all Column use
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/column

- To Retrieving all infos for a Specified Column use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/column/{id}

- To Changing the Status of a Specified Elevator use:
PUT METHOD -- http://rocket-elevator-api.azurewebsites.net/api/elevator/{id}

- To Changing the Status of a Specified Battery use:
PUT METHOD -- http://rocket-elevator-api.azurewebsites.net/api/battery/{id}

- To Changing the Status of a Specified column use:
PUT METHOD -- http://rocket-elevator-api.azurewebsites.net/api/column/{id}

- To Retrieving the Current Status and Id only for all elevators :
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/elevator/status

- To Retrieving the infos for specific Elevator Cage use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/elevator/{id}

- To Retrieving the infos of all Elevator Cages:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/elevator

- To Retrieving a list of elevator that are not in operation at the time of the request use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/elevator/offline

- To Retrieve a list of buildings that contain at least one battery, column, or elevator requiring intervention use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/building

- To Retrieving a list of leads created in the last 30 days that have not yet become customers use:
GET METHOD -- http://rocket-elevator-api.azurewebsites.net/api/lead




