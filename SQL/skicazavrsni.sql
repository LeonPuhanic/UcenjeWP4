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

create table Metci(
sifra int not null primary key identity,
naziv varchar(60) not null,
cijena decimal(10,2),
tezinazrna decimal(10,2),
tezinametka decimal(10,2),
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
datumproizvodnje varchar(10) not null,
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

create table Korisnici(
sifra int not null primary key identity,
username varchar(20) not null,
email varchar(40) not null,
pass varchar(20) not null,
isAdmin bit not null,
favOruzje int foreign key references Oruzja(sifra),
favOptika int foreign key references Optike(sifra)
);

insert into Proizvodaci (naziv, datumosnovanja) values
('Kel-Tec', '1991.'),
('KRISS USA', '2002.'),
('Izhmash', '1807.'),
('Streyr Arms', '1864.'),
('Heckler & Koch', '1949.'),
('FN Herstal', '1889.'),
('Colt Manufacturing Company', '1855.'),
('KBP Instrument Design Bureau', '1927.');

insert into Metci (naziv, proizvodac) values
('7.62x51mm NATO', 6),
('.45 ACP', 7),
('12.7x55mm', 8),
('5.56x45mm NATO', 6);


insert into Oruzja (naziv, kalibar, tezina, proizvodac, datumproizvodnje, tippaljbe) values
('Kel-Tech RFB', 1, 3700, 1, '2003.', 'Semi-Automatic'),
('KRISS Vector .45 ACP', 2, 2700, 2, '2009', 'Automatic'),
('ShAK-12', 3, 6000, 3, '2010', 'Automatic'),
('Streyr AUG 5.56x45', 4, 3600, 4, '1977', 'Automatic'),
('H&K HK416', 4, 3120, 5, '2004', 'Automatic');

select w.naziv as Oruzje, w.tezina as Tezina, w.tippaljbe as TipPaljbe, b.naziv as Kalibar, p.naziv as Proizvodac
from Oruzja w
inner join Metci b on w.kalibar = b.sifra
inner join Proizvodaci p on w.proizvodac = p.sifra;


select m.naziv as Metak, p.naziv as Proizvodac
from Metci m
inner join Proizvodaci p on m.proizvodac = p.sifra;