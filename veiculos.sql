create database carbooking

use carbooking

create table veiculos 
(
	id_veiculo  INTEGER	IDENTITY	(1,1)   not null    PRIMARY KEY,    
	modelo		VARCHAR				(100)	not null,
	placa		VARCHAR				(8)		not null,
	ano			VARCHAR				(4)		not null,
	estado		VARCHAR				(30)	not null
);
go

select * from veiculos

drop table veiculos

create table reservas
(
	id_reserva  INTEGER	IDENTITY	(1,1)   not null    PRIMARY KEY,    
	dtinicio    datetime					not null,
	dtfinal		datetime					not null,
	estado		varchar				(50)	not null,
	id_veiculo 	INTEGER						,
	FOREIGN KEY(id_veiculo) REFERENCES veiculos (id_veiculo )
);

drop table reservas

select * from reservas