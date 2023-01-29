use yaseenabdelhamid;
set sql_safe_updates = 0;
update (Nummers inner join Albums
on Albums.Album = Nummers.Album) inner join Artiesten
on Nummers.Artiesten_Id = Artiesten.Id
set Albums.Album_Id = Nummers.Artiesten_Id;
set sql_safe_updates = 1;