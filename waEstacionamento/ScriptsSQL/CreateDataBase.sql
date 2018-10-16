use master
go

IF Exists (select name from sys.databases  WHERE name = 'dbEstacionamento')
	DROP DATABASE dbEstacionamento
GO

CREATE DATABASE dbEstacionamento
GO

use dbEstacionamento
Go

CREATE TABLE Estacionamento
(
    id int identity(1,1),
	dataEntrada datetime,
    dataSaida datetime,
    descricao varchar(200),
    nomeCliente varchar(100),
    telefone varchar(10),
    valor decimal(10,2),
	CONSTRAINT PK_Estacionameto PRIMARY KEY (id)
)
Go

CREATE TABLE Carro
(
    id int identity(1,1),
	anoFabricacao int,
    anoModelo int,
    cor varchar(50),
    marca varchar(60),
    modelo varchar(60),
	CONSTRAINT PK_Carro PRIMARY KEY (id)
)
GO

select * from carro