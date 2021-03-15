﻿/*
Deployment script for MyDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "MyDatabase"
:setvar DefaultFilePrefix "MyDatabase"
:setvar DefaultDataPath "C:\Users\esra\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\esra\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Update complete.';


GO

INSERT INTO [dbo].[Cars] (CarId,BrandId,ColorId,[ ModelYear],[DailyPrice ],Description)
VALUES (1,1,3,2015,500,'Otomatik');

INSERT INTO  [dbo].[Cars] (CarId,BrandId,ColorId,[ ModelYear],[DailyPrice ],Description)
VALUES (2,1,1,2017,600,'Manuel');

INSERT INTO  [dbo].[Cars](CarId,BrandId,ColorId,[ ModelYear],[DailyPrice ],Description)
VALUES (3,2,2,2010,300,'Dizel');

INSERT INTO Cars(CarId,BrandId,ColorId,[ ModelYear],[DailyPrice ],Description)
VALUES (4,4,3,2019,200,'Benzinli');

INSERT INTO  [dbo].[Cars](CarId,BrandId,ColorId,[ ModelYear],[DailyPrice ],Description)
VALUES (5,3,5,2013,300,'Hatchback');
