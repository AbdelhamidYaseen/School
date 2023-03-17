USE aptunes;
DELIMITER $$
CREATE PROCEDURE `MockAlbumReleasesWithMessage` ()
BEGIN
DECLARE success BOOL DEFAULT false;
CALL MockAlbumReleasesWithSuccess(success);
IF success
	THEN SELECT 'Release Geslaagd!';
ELSE
	SELECT 'Release kon niet worden toegevoegd.';
END IF;

END$$
DELIMITER ;