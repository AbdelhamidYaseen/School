use yaseenabdelhamid;
insert into Boeken values ("De geschiedenis van Rock 'n Roll", 'De Hasque', '2011');
drop table if exists Liedjes;
CREATE TABLE Liedjes(Titel VARCHAR(100), Duurtijd int);
-- het liedje duurt vijf minuten
insert into Liedjes values ("Ain't talkin' 'bout Love", 5 * 60);