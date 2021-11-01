CREATE DATABASE Hotel;

USE Hotel;

CREATE TABLE Cargos (

id int IDENTITY PRIMARY KEY,
cargo varchar(30),

);

SELECT * FROM Cargos

CREATE TABLE funcionarios (

id int IDENTITY PRIMARY KEY,
nome varchar(40),
cpf varchar(20),
endereco varchar(80),
telefone varchar(20),
cargo varchar(30),
data date,
);

SELECT * FROM funcionarios