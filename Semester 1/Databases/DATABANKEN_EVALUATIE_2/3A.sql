/*
Maak tussenverbindtabel 
ALBUM ---> REFEREERT NAAR "Artiesten_Id"
||
LIEDJE
Hou Tracknummer bij van liedje
*/
USE yaseenabdelhamid;
/*create table*/
CREATE TABLE IF NOT EXISTS 
LiedjeOpAlbum
(
/*create tracknumber*/
Tracknummer INT NOT NULL
, 
/*connect with Liedje*/
CONSTRAINT fk_LiedjesOpAlbum_Liedjes 
FOREIGN KEY (Tracknummer) REFERENCES Liedjes(Id)
, 
/*create Artiest*/
Artiest_Id INT
, 
/*connect with Albums*/
CONSTRAINT fk_LiedjeOpAlbums_Albums 
FOREIGN KEY (Artiest_Id) REFERENCES Albums(Id)
)
;
