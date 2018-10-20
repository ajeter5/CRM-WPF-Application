# CRM-WPF-Application

This is a Windows Presentation Foundation (WPF) Customer Relationship Management (CRM) Application.

The application loads data into an instance of SQL Server. The application is configured to connect to the users local SQL Server instance (Server = localhost).

Each time the application is launched the application creates a new database (CRMDatabase) if one does not exist and creates three tables. 
If a database named CRMDatabase the database will be dropped and recreated.

There are three classes, Customer, Prospect, and Person that are currently not used. Customer and Prospect inherit from Person.

Developed by Austin Jeter
ajeter10@gmail.com
