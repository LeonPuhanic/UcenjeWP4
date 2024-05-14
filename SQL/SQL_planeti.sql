use master;
go
drop database if exists SQLvjezba;
create database SQLvjezba;
go
use SQLvjezba;

create table planet(
sifra int primary key not null,
naziv varchar(50),
masa int,
velicina int
)