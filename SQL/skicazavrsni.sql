use master;
go
drop database if exists specifikacijeNaoruzanja;
go
create database specifikacijeNaoruzanja;
go

use specifikacijeNaoruzanja

create table Proizvodaci(
sifra int not null primary key identity,
naziv varchar(100) not null,
datumosnovanja datetime not null,
);

create table Metci(
sifra int not null primary key identity,
naziv varchar(60) not null,
cijena decimal(10,2),
tezinazrna decimal(10,2),
tezinametka decimal(10,2) not null,
tip varchar(60),
proizvodac int foreign key references proizvodaci(sifra) not null
);

create table Oruzja(
sifra int not null primary key identity,
naziv varchar(60) not null,
kalibar int not null foreign key references metci(sifra),
cijena decimal(10,2),
tezina int not null,
proizvodac int foreign key references proizvodaci(sifra) not null,
duzina decimal(10,2),
duzinacijevi decimal(10,2),
brzinapaljbe int,
pocetnabrzinametka int,
kapacitetspremnika int,
datumproizvodnje datetime not null,
tippaljbe varchar(20) not null
);

create table Optike(
sifra int not null primary key identity,
naziv varchar(60) not null,
cijena decimal(10,2),
magnifikacija decimal(10,2),
tezina decimal(10,2) not null,
potrebnabaterija bit not null,
proizvodac int foreign key references proizvodaci(sifra) not null
);