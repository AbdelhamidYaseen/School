use yaseenabdelhamid;
ALTER TABLE Albums ADD COLUMN Album_Id INT, ADD CONSTRAINT fk_Albums_Artiest FOREIGN KEY (Album_Id) references Artiesten(id);