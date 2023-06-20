USE `exameneerstezit`;
DELIMITER $$
CREATE DEFINER=`root`@`%` PROCEDURE `ExporteerFilmsNaarTekstbestand`(OUT csv text)
BEGIN
	declare huidigeFilm varchar(45);
	declare huidigeGenres varchar(45);
	declare done bool default false;
    
	declare CsvCursor cursor for
	select Titel
	from Films
	inner join Verhuringen on Film.Id = Film_Id
	inner join Categorieen on Categorieen.Id = Categorieen_Id;
    
    declare continue handler for not found
	begin
	  set csv = substring(csv,1,char_length(csv) - 1);
	  set done = true;
	end;
	
    set csv = "";
	open CsvCursor;
	concatLoop: loop
	  fetch CsvCursor into huidigeFilm, huidigeGenres;
	  if done
		then leave concatLoop;
	  end if;
	  set csv = concat(csv,
					'"', replace(huidigeFilm,'"', '""'),   '"', ",",
                   '"', replace(huidigeGenres,'"', '""'), '"', ",","\n");
	end loop;
END$$
DELIMITER $$ ;




