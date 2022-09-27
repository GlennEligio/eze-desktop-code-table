# EZE Code List app

Application to display all the codes in the database which is populated by the GSM in main application

## Setup

**Adding necessary tables in database**

1. Execute the DDL scripts inside the DDL scripts folder to create Message and Professor table
2. From here, you can either (re)create the ADO.NET Models to reflect to your desired database, or repoint the existing connection strings of ADO.NET Model located in App.config to the correct database

**Creating New ADO.NET Models**

1. Delete the connection strings generated by the database-first approach of the Entity Framework in the EZECodesList/App.config
2. Delete the ADO.NETModels in the EZECodesList, then recreated them again in the Visual Studio by creating new ADO.NET Model

**Repoint the ADO.NET Models connection string**

1. Edit the connection strings in App.config to point it to the correct MSSQL database