
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/14/2015 19:52:40
-- Generated from EDMX file: C:\Users\Anders\Documents\OOP2-ME\WindowsFormsApplication1\ClassLibrary1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AutoLot];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ContractLeasing_CustomerBusiness]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractLeasings] DROP CONSTRAINT [FK_ContractLeasing_CustomerBusiness];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractLeasing_VehicleTruck]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractLeasings] DROP CONSTRAINT [FK_ContractLeasing_VehicleTruck];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractSale_CustomerPrivate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractSales] DROP CONSTRAINT [FK_ContractSale_CustomerPrivate];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractSale_VehicleCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractSales] DROP CONSTRAINT [FK_ContractSale_VehicleCar];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ContractLeasings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractLeasings];
GO
IF OBJECT_ID(N'[dbo].[ContractSales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractSales];
GO
IF OBJECT_ID(N'[dbo].[CustomerBusinesses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerBusinesses];
GO
IF OBJECT_ID(N'[dbo].[CustomerPrivates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerPrivates];
GO
IF OBJECT_ID(N'[dbo].[VehicleCars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehicleCars];
GO
IF OBJECT_ID(N'[dbo].[VehicleTrucks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehicleTrucks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ContractLeasings'
CREATE TABLE [dbo].[ContractLeasings] (
    [LeasingID] int IDENTITY(1,1) NOT NULL,
    [MonthlyPrice] decimal(18,0)  NOT NULL,
    [SENumber] int  NOT NULL,
    [VehicleTruckID] int  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'ContractSales'
CREATE TABLE [dbo].[ContractSales] (
    [SalesID] int IDENTITY(1,1) NOT NULL,
    [CustomerPrivateID] int  NOT NULL,
    [VehicleCarID] int  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'CustomerBusinesses'
CREATE TABLE [dbo].[CustomerBusinesses] (
    [SENumber] int  NOT NULL,
    [CompanyName] varchar(50)  NOT NULL,
    [Address] varchar(50)  NOT NULL,
    [Phone] int  NOT NULL,
    [Email] varchar(50)  NOT NULL,
    [ContactPerson] varchar(50)  NOT NULL,
    [Fax] int  NULL,
    [NewsReciever] bit  NOT NULL
);
GO

-- Creating table 'CustomerPrivates'
CREATE TABLE [dbo].[CustomerPrivates] (
    [CustomerPrivateID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(20)  NOT NULL,
    [Address] varchar(50)  NOT NULL,
    [Phone] int  NOT NULL,
    [Email] varchar(50)  NOT NULL,
    [NewsReciever] bit  NOT NULL,
    [Age] datetime  NOT NULL,
    [Sex] varchar(50)  NOT NULL
);
GO

-- Creating table 'VehicleCars'
CREATE TABLE [dbo].[VehicleCars] (
    [VehicleCarID] int IDENTITY(1,1) NOT NULL,
    [Type] varchar(50)  NOT NULL,
    [Model] varchar(50)  NOT NULL,
    [Color] varchar(50)  NOT NULL,
    [Price] int  NOT NULL
);
GO

-- Creating table 'VehicleTrucks'
CREATE TABLE [dbo].[VehicleTrucks] (
    [VehicleTruckID] int IDENTITY(1,1) NOT NULL,
    [Type] varchar(50)  NOT NULL,
    [Model] varchar(50)  NOT NULL,
    [Color] varchar(50)  NOT NULL,
    [Price] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [LeasingID] in table 'ContractLeasings'
ALTER TABLE [dbo].[ContractLeasings]
ADD CONSTRAINT [PK_ContractLeasings]
    PRIMARY KEY CLUSTERED ([LeasingID] ASC);
GO

-- Creating primary key on [SalesID] in table 'ContractSales'
ALTER TABLE [dbo].[ContractSales]
ADD CONSTRAINT [PK_ContractSales]
    PRIMARY KEY CLUSTERED ([SalesID] ASC);
GO

-- Creating primary key on [SENumber] in table 'CustomerBusinesses'
ALTER TABLE [dbo].[CustomerBusinesses]
ADD CONSTRAINT [PK_CustomerBusinesses]
    PRIMARY KEY CLUSTERED ([SENumber] ASC);
GO

-- Creating primary key on [CustomerPrivateID] in table 'CustomerPrivates'
ALTER TABLE [dbo].[CustomerPrivates]
ADD CONSTRAINT [PK_CustomerPrivates]
    PRIMARY KEY CLUSTERED ([CustomerPrivateID] ASC);
GO

-- Creating primary key on [VehicleCarID] in table 'VehicleCars'
ALTER TABLE [dbo].[VehicleCars]
ADD CONSTRAINT [PK_VehicleCars]
    PRIMARY KEY CLUSTERED ([VehicleCarID] ASC);
GO

-- Creating primary key on [VehicleTruckID] in table 'VehicleTrucks'
ALTER TABLE [dbo].[VehicleTrucks]
ADD CONSTRAINT [PK_VehicleTrucks]
    PRIMARY KEY CLUSTERED ([VehicleTruckID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SENumber] in table 'ContractLeasings'
ALTER TABLE [dbo].[ContractLeasings]
ADD CONSTRAINT [FK_ContractLeasing_CustomerBusiness]
    FOREIGN KEY ([SENumber])
    REFERENCES [dbo].[CustomerBusinesses]
        ([SENumber])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractLeasing_CustomerBusiness'
CREATE INDEX [IX_FK_ContractLeasing_CustomerBusiness]
ON [dbo].[ContractLeasings]
    ([SENumber]);
GO

-- Creating foreign key on [VehicleTruckID] in table 'ContractLeasings'
ALTER TABLE [dbo].[ContractLeasings]
ADD CONSTRAINT [FK_ContractLeasing_VehicleTruck]
    FOREIGN KEY ([VehicleTruckID])
    REFERENCES [dbo].[VehicleTrucks]
        ([VehicleTruckID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractLeasing_VehicleTruck'
CREATE INDEX [IX_FK_ContractLeasing_VehicleTruck]
ON [dbo].[ContractLeasings]
    ([VehicleTruckID]);
GO

-- Creating foreign key on [CustomerPrivateID] in table 'ContractSales'
ALTER TABLE [dbo].[ContractSales]
ADD CONSTRAINT [FK_ContractSale_CustomerPrivate]
    FOREIGN KEY ([CustomerPrivateID])
    REFERENCES [dbo].[CustomerPrivates]
        ([CustomerPrivateID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractSale_CustomerPrivate'
CREATE INDEX [IX_FK_ContractSale_CustomerPrivate]
ON [dbo].[ContractSales]
    ([CustomerPrivateID]);
GO

-- Creating foreign key on [VehicleCarID] in table 'ContractSales'
ALTER TABLE [dbo].[ContractSales]
ADD CONSTRAINT [FK_ContractSale_VehicleCar]
    FOREIGN KEY ([VehicleCarID])
    REFERENCES [dbo].[VehicleCars]
        ([VehicleCarID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractSale_VehicleCar'
CREATE INDEX [IX_FK_ContractSale_VehicleCar]
ON [dbo].[ContractSales]
    ([VehicleCarID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------