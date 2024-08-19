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
datumosnovanja varchar(10) not null,
);


create table Oruzja(
sifra int not null primary key identity,
naziv varchar(60) not null,
kalibar varchar(10),
cijena decimal(10,2),
tezina int,
proizvodac int foreign key references proizvodaci(sifra) not null,
kapacitetspremnika int,
godinaproizvodnje int,
);

create table Optike(
sifra int not null primary key identity,
naziv varchar(60) not null,
cijena decimal(10,2),
magnifikacija varchar(10),
tezina int,

proizvodac int foreign key references proizvodaci(sifra) not null
);


insert into Proizvodaci (naziv, datumosnovanja) values
('Kel-Tec', '1991.'),
('KRISS USA', '2002.'),
('Izhmash', '1807.'),
('Streyr Arms', '1864.'),
('Heckler & Koch', '1949.'),
('FN Herstal', '1889.'),
('Colt Manufacturing Company', '1855.'),
('KBP Instrument Design Bureau', '1927.'),
('SIG Sauer', '1976.'),
('Teledyne FLIR', '1978.');

insert into Oruzja (naziv, kalibar, tezina, proizvodac, godinaproizvodnje) values
('Kel-Tech RFB', 1, 3700, 1, '2003.', 'Semi-Automatic'),
('KRISS Vector .45 ACP', 2, 2700, 2, '2009', 'Automatic'),
('ShAK-12', 3, 6000, 3, '2010', 'Automatic'),
('Streyr AUG 5.56x45', 4, 3600, 4, '1977', 'Automatic'),
('H&K HK416', 4, 3120, 5, '2004', 'Automatic');

insert into Optike (naziv, magnifikacija, proizvodac) values
('Romeo4T', '1x', 9),
('Tango6', '5-30x', 9),
('ThermoSight RS64', '2-16x', 10);


select o.naziv as Optika, o.magnifikacija as Magnifikacija, p.naziv as Proizvodac
from Optike o
inner join Proizvodaci p on o.proizvodac = p.sifra;


select w.naziv as Oruzje, w.tezina as Tezina, w.tippaljbe as TipPaljbe, p.naziv as Proizvodac
from Oruzja w
inner join Proizvodaci p on w.proizvodac = p.sifra;