# _United States National, State, and City Parks_

#### By _**Peter Vang**_

## Technologies Used
* Git
* C#
* .NET 6.0
* ASP.NET
* RESTful Routing
* Entity Framework Core
* MVC
* BootStrap
* MySQL Workbench
* Razor view Engine  
* Swagger
* Postman

## Description

_This is a C# API Framework application build to allow users to make API calls to find National, State, and City Parks in the United State. You can also query this API by location (e.g. "California") or type (e.g. "State")._

## Setup/Installation Requirements

* _Open your terminal_
* _Clone this project with the following commands $ git clone https://github.com/vangpeter06/Parks.Solution_
* _Navigate to the directory in terminal $ cd Parks.Solution_
* _Open project in the command $ code ._
* _Navigate to the sub-directory of the project $ cd Parks_
* _Add appsettings.json file to the Parks directory in terminal $ touch appsettings.json_
* _Insert the following codes 
  {
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  }
  
   "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks;uid=[YOUR-USERID-HERE];pwd=[YOUR-PASSWORD-HERE]
      }
    }_
* _Navigate to Parks directory_
* _Restore and install packages listed in the csproj in the command $ dotnet restore_
* _Build your dependencies in your command $ dotnet build_
* _If you do not have MySQL workbench do so at https://dev.mysql.com/downloads/file/?id=484391_
* _Create Initial SQL migration with the following command $ dotnet ef migration initial_
* _Update database in MySQL Workbench command $ dotnet ef database update_
* _Next we will execute this compiled code in command $ dotnet run_

### CRUD STRUCTURE
 _GET /api/Parks_
 _POST /api/Parks_
 _GET /api/Parks/{id}_
 _PUT /api/Parks/{id}_
 _DELETE /api/Parks{id}_

### EXAMPLE QUERY
 _GET /api/Parks/?location=oregon_

### SWAGGER
 _This project utilizes swagger documentation that can be found https://localhost:5001/swagger/index.html (when program is running)_

![Image of Swagger](./Parks/wwwroot/img/Screen%20Shot%202022-08-19%20at%203.19.43%20PM.png)

## Known Bugs
no know bug

## License
_If you run into any issues or have questions, ideas or concerns please contact the authors or make a contribution to the code._
This software is licensed under the MIT license
Copyright (c) _8/19/2022_ _Peter Vang_    