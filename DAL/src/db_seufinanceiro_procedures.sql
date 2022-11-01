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
	UPDATE tbl_usr set usr = @usr, pwd = @pwd WHERE id_usr = @id_usr
END
CREATE PROCEDURE UserDelete
	@id_usr INT
AS BEGIN
	DELETE FROM	tbl_usr WHERE id_usr = @id_usr
END
CREATE PROCEDURE UserFindLogin
	@usr VARCHAR(100),
	@pwd VARCHAR(1000)
AS BEGIN
	SELECT id_usr, usr, pwd FROM tbl_usr WHERE usr = @usr and pwd = @pwd
END

--**************************************************************************--

CREATE PROCEDURE TypeBalanceInsert
	@type_balance INT,
	@status_balance CHAR
AS BEGIN
	INSERT INTO tbl_type_balance (type_balance, status_balance) VALUES (@type_balance, @status_balance)
END
CREATE PROCEDURE TypeBalanceUpdate
	@id_type_balance INT,
	@type_balance INT,
	@status_balance CHAR
AS BEGIN
	UPDATE tbl_type_balance set type_balance = @type_balance, status_balance = @status_balance WHERE id_type_balance = @id_type_balance
END
CREATE PROCEDURE TypeBalanceDelete
	@id_type_balance INT
AS BEGIN
	DELETE FROM	tbl_type_balance WHERE id_type_balance = @id_type_balance
END
CREATE PROCEDURE TypeBalanceFind
	@id_type_balance INT,
	@type_balance INT,
	@status_balance CHAR
AS BEGIN
	SELECT * FROM tbl_type_balance
END

--**************************************************************************--

CREATE PROCEDURE WalletInsert
	@id_usr_wallet INT,
	@name_wallet VARCHAR(50),
	@account_balance_wallet MONEY
AS BEGIN
	INSERT INTO tbl_wallet (id_usr_wallet, name_wallet, account_balance_wallet) VALUES (@id_usr_wallet, @name_wallet, @account_balance_wallet)
END

CREATE PROCEDURE WalletUpdate
	@id_wallet INT,
	@name_wallet VARCHAR(50),
	@account_balance_wallet MONEY
AS BEGIN
	UPDATE tbl_wallet set name_wallet = @name_wallet, account_balance_wallet = @account_balance_wallet WHERE id_wallet = @id_wallet
END

CREATE PROCEDURE WalletDelete
	@id_wallet INT
AS BEGIN
	DELETE FROM	tbl_wallet WHERE @id_wallet = id_wallet
END

CREATE PROCEDURE WalletFindAll
	@id_usr_wallet INT
AS BEGIN
	SELECT * FROM tbl_wallet WHERE id_usr_wallet = @id_usr_wallet
END

CREATE PROCEDURE WalletFindName
	@id_usr_wallet INT,
	@name_wallet VARCHAR(50)
AS BEGIN
	SELECT * FROM tbl_wallet WHERE name_wallet LIKE '%' + @name_wallet + '%' AND id_usr_wallet = @id_usr_wallet
END

CREATE PROCEDURE WalletFindId
	@id_wallet INT
AS BEGIN
	SELECT * FROM tbl_wallet WHERE id_wallet = @id_wallet
END

--**************************************************************************--

CREATE PROCEDURE BalanceInsert
	@id_type_balance INT,
	@id_wallet_balance INT,
	@value_balance MONEY,
	@date_balance DATE
AS BEGIN
	INSERT INTO tbl_balance (id_type_balance, id_wallet_balance, value_balance, date_balance) VALUES (@id_type_balance, @id_wallet_balance, @value_balance, @date_balance)
END

CREATE PROCEDURE BalanceUpdate
	@id_balance INT,
	@id_type_balance INT,
	@id_wallet_balance INT,
	@value_balance MONEY,
	@date_balance DATE
AS BEGIN 
	UPDATE tbl_balance set id_type_balance = @id_type_balance, id_wallet_balance = @id_wallet_balance, value_balance = @value_balance, date_balance = @date_balance WHERE id_balance = @id_balance
END

CREATE PROCEDURE BalanceDelete
	@id_balance INT
AS BEGIN
	DELETE FROM	tbl_balance WHERE id_balance = @id_balance
END

CREATE PROCEDURE BalanceFindAll
AS BEGIN
	SELECT * FROM tbl_balance
END

CREATE PROCEDURE BalanceFindWallet
	@id_wallet_balance INT
AS BEGIN
	SELECT * FROM tbl_balance WHERE id_wallet_balance LIKE '%' + @id_wallet_balance + '%'
END

CREATE PROCEDURE BalanceFindValue
	@value_balance MONEY
AS BEGIN
	SELECT * FROM tbl_balance WHERE value_balance LIKE '%' + @value_balance + '%'
END

CREATE PROCEDURE BalanceFindDate
	@date_balance DATE
AS BEGIN
	SELECT * FROM tbl_balance WHERE date_balance = @date_balance
END

--*******************************************
drop procedure 
EXEC 


--*******************************************
CREATE TABLE tbl_settings (
	id_settings INT NOT NULL IDENTITY PRIMARY KEY,
	id_usr_login INT NOT NULL FOREIGN KEY REFERENCES tbl_usr(id_usr) UNIQUE,
	auto_pwd_settings BIT NOT NULL,
	themes_settings INT NOT NULL,
	notification_settings BIT NOT NULL
);