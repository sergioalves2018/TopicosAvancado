use master
GO

PRINT '-- Apaga a base se já existir(Momento de criacao) -----------------------------------------'
IF Exists (select name from sys.databases  WHERE name = 'dbLabInfo')
	DROP DATABASE dbLabInfo
GO

PRINT '-- Cria a base --------------------'
CREATE DATABASE dbLabInfo
GO

PRINT '-- Aponto a base que irei usar ----'
USE dbLabInfo
GO

PRINT '-- Criacao tabela LabInfo -----------------------------------------------------------------'
CREATE TABLE LabInfo(
	id int identity(1,1) NOT NULL,
	nome varchar(200) NOT NULL,
	qtdComputadores int NULL,
	qtdAlunos int NULL,
	projetor bit,
	software1 varchar(100),
	software2 varchar(100),
	software3 varchar(100),
	sistemaOperacional varchar(100),
	CONSTRAINT PK_LabInfo_id Primary Key (id),
	CONSTRAINT UQ_Nome UNIQUE(Nome), 
) 
GO

select * from LabInfo