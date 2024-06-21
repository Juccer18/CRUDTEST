*Config*

En el archivo appsettings.json se configura nuestra conexion con la BD

Db MySql

CREATE DATABASE CRUDMVC;

USE CRUDMVC;

CREATE TABLE Clients (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(35),
    Register date
);


// Dependencies
NuGet
Microsoft.EntityFrameworkCore.Tools
Pomelo.EntityFrameworkCore.MySql



