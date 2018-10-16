use master
go

IF Exists (select name from sys.databases  WHERE name = 'dbProva')
	DROP DATABASE dbProva
GO

CREATE DATABASE dbProva
GO

use dbProva
Go

CREATE TABLE Prova
(
    id int identity(1,1),
	descricao varchar(200),
	data datetime,
    nota1 decimal(4,2),
    nota2 decimal(4,2),
    media decimal(4,2),
	CONSTRAINT PK_Prova PRIMARY KEY (id)
)
Go
