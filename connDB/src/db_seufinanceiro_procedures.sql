CREATE PROCEDURE UserInsert
	@usr VARCHAR(100),
	@pwd VARCHAR(1000)
AS BEGIN
	INSERT INTO tbl_usr (usr, pwd) VALUES (@usr, @pwd)
END

CREATE PROCEDURE UserUpdate
	@id_usr INT,
	@usr VARCHAR(100),
	@pwd VARCHAR(1000)
AS BEGIN
	UPDATE tbl_usr set usr = @usr, pwd = @pwd
	WHERE id_usr = @id_usr
END

CREATE PROCEDURE UserDelete
	@id_usr INT
AS BEGIN
	DELETE FROM	tbl_usr
	WHERE id_usr = @id_usr
END

CREATE PROCEDURE UserFindLogin
	@usr VARCHAR(100),
	@pwd VARCHAR(1000)
AS BEGIN
	SELECT id_usr, usr, pwd FROM tbl_usr WHERE usr = @usr and pwd = @pwd
END

--*******************************************
drop procedure 
EXEC 




--*******************************************
CREATE TABLE tbl_type_balance (
	id_type_balance INT NOT NULL PRIMARY KEY,
	type_balance VARCHAR(100) NOT NULL UNIQUE,
	status_balance CHAR NOT NULL
);
CREATE TABLE tbl_wallet (
	id_wallet INT NOT NULL IDENTITY PRIMARY KEY,
	id_usr_wallet INT NOT NULL FOREIGN KEY REFERENCES tbl_usr(id_usr),
	name_wallet VARCHAR (50) NOT NULL
);
CREATE TABLE tbl_balance (
	id_balance INT NOT NULL IDENTITY PRIMARY KEY,
	id_type_balance INT NOT NULL FOREIGN KEY REFERENCES tbl_type_balance(id_type_balance),
	id_wallet_balance INT NOT NULL FOREIGN KEY REFERENCES tbl_wallet(id_wallet),
	value_balance MONEY NOT NULL,
	date_balance DATE NOT NULL
);
CREATE TABLE tbl_settings (
	id_settings INT NOT NULL IDENTITY PRIMARY KEY,
	id_usr_login INT NOT NULL FOREIGN KEY REFERENCES tbl_usr(id_usr) UNIQUE,
	auto_pwd_settings BIT NOT NULL,
	themes_settings INT NOT NULL,
	notification_settings BIT NOT NULL
);