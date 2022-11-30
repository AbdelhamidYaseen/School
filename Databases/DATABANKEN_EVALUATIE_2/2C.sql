USE yaseenabdelhamid;
ALTER TABLE Nummers
ADD COLUMN Artiesten_Id INT
,
ADD CONSTRAINT fk_Nummers_Artiesten
FOREIGN KEY (Artiesten_Id)
REFERENCES Artiesten(id)
;