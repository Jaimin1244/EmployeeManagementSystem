-- Creating the database
CREATE DATABASE EmployeeDB;
GO

-- Using the database
USE EmployeeDB;
GO

-- Creating Employee table
CREATE TABLE Employees (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Position NVARCHAR(100) NOT NULL,
    Office NVARCHAR(100) NOT NULL,
    Salary DECIMAL(10,2) NOT NULL
);
GO
