use yaseenabdelhamid;
drop table if exists Boeken;
create table Boeken(Titel varchar(100), Uitgeverij varchar(100), Jaartal smallint unsigned);
insert into Boeken (Titel, Uitgeverij, Jaartal) values ('Fabels', 'Editions Minuit', 2021-50);