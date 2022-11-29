use yaseenabdelhamid;
alter table Albums add column Album_Id int, add constraint fk_Albums_Artiest foreign key (Album_Id) references Artiesten(id);