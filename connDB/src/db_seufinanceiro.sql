CREATE DATABASE db_seufinanceiro;
CREATE TABLE tbl_usr (
	id_usr INT NOT NULL IDENTITY PRIMARY KEY,
	usr VARCHAR(100) NOT NULL UNIQUE,
	pwd VARCHAR(1000) NOT NULL
);
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

*******************************************
SELECT * FROM TBL_WALLET

