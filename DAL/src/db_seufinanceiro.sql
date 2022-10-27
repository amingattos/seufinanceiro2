CREATE DATABASE db_seufinanceiro;
CREATE TABLE tbl_usr (id_usr INT NOT NULL IDENTITY(1,32156) PRIMARY KEY, usr VARCHAR(100) NOT NULL UNIQUE, pwd VARCHAR(1000) NOT NULL);
CREATE TABLE tbl_type_balance (id_type_balance INT NOT NULL IDENTITY PRIMARY KEY, type_balance VARCHAR(100) NOT NULL UNIQUE, status_balance BIT);
CREATE TABLE tbl_wallet (id_wallet INT NOT NULL IDENTITY PRIMARY KEY, id_usr_wallet INT NOT NULL FOREIGN KEY REFERENCES tbl_usr(id_usr), name_wallet VARCHAR (50) NOT NULL, account_balance_wallet MONEY NOT NULL);
CREATE TABLE tbl_balance (id_balance INT NOT NULL IDENTITY PRIMARY KEY,id_type_balance INT NOT NULL FOREIGN KEY REFERENCES tbl_type_balance(id_type_balance), id_wallet_balance INT NOT NULL FOREIGN KEY REFERENCES tbl_wallet(id_wallet), value_balance MONEY NOT NULL, date_balance DATE NOT NULL);
CREATE TABLE tbl_settings (id_settings INT NOT NULL IDENTITY PRIMARY KEY, id_usr_login INT NOT NULL FOREIGN KEY REFERENCES tbl_usr(id_usr) UNIQUE, auto_pwd_settings BIT NOT NULL, themes_settings INT NOT NULL, notification_settings BIT NOT NULL);

INSERT INTO tbl_usr VALUES ('developer','dev');
INSERT tbl_settings VALUES(1, 0, 0, 0);
INSERT tbl_wallet VALUES (1, 'Sua Carteira', 1001.50);
INSERT tbl_wallet VALUES (1, 'Nubank_3', 308000.00);

SELECT SUM(account_balance_wallet) saldo_total FROM tbl_wallet WHERE id_usr_wallet = 1;
SELECT * FROM tbl_wallet WHERE id_usr_wallet = 1;
SELECT * FROM tbl_wallet WHERE id_wallet = 1;

--INSERT tbl_type_balance VALUES ('CRIAÇÃO DO SISTEMA', NULL);
--INSERT tbl_balance VALUES (1, 3, 0, '2022-04-22'); // Colocar no sistema

-- SELECT * FROM tbl_wallet, tbl_usr, tbl_balance, tbl_type_balance
-- select * from tbl_usr
-- select * from tbl_balance
-- select * from tbl_wallet
-- SELECT * FROM tbl_type_balance

Insert tbl_usr values ('teste', '123', 0)
select * from tbl_usr