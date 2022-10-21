﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace seufinanceiro.Controller
{
    internal class Cls_Wallet
    {
        private int _id_wallet, _id_usr_wallet;
        private string _name_wallet;
        private decimal _balance_wallet;
        public string Name_Wallet
        {
            get { return _name_wallet; }
            set { _name_wallet = value; }
        }
        public int Id_Wallet
        {
            get { return _id_wallet; }
            set { _id_wallet = value; }
        }
        public int Id_usr_wallet
        { get { return _id_usr_wallet; } set { _id_usr_wallet = value; } }
        public decimal Balance_Wallet
        {
            get { return _balance_wallet; }
            set { _balance_wallet = value; }
        }
        public void Create_Wallet(int id_usr_wallet)
        {   // Quando cria uma conta automaticamente cria uma carteira para iniciar.
            string strQuery = "INSERT tbl_wallet VALUES (" + id_usr_wallet + ", 'Sua Carteira', 0);";

            Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
            ObjconnDB.ExecutaComando(strQuery);
        }
        public void New_Wallet(int id_usr_wallet, string _name_wallet)
        {   // Caso o usuário queira criar mais carteiras.
            string strQuery = "INSERT tbl_wallet VALUES (" + id_usr_wallet + "," + _name_wallet + ", 0);";

            Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
            ObjconnDB.ExecutaComando(strQuery);
        }
        public void Update_Name_Wallet(int id_usr_wallet, int _id_wallet, string _name_wallet)
        {   // Opção para mudar o nome da CARTEIRA
            string strQuery = "UPDATE tbl_wallet SET name_wallet = '" + _name_wallet + "' " +
                "WHERE " + _id_wallet + " AND " + id_usr_wallet + ";";

            Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
            ObjconnDB.ExecutaComando(strQuery);
        }
        public SqlDataReader SaldoTotal_Wallets(int _id_usr_wallet)
        {   // Carrega todas as carteiras e soma o valor de todas
            string strQuery = "SELECT SUM(account_balance_wallet) saldo_total FROM tbl_wallet WHERE id_usr_wallet = " + _id_usr_wallet + ";";

            Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
            ObjconnDB.ExecutaComando(strQuery);

            return ObjconnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader Load_Wallets(int _id_usr_wallet)
        {   // Carrega todas as carteiras com ID do user.
            string strQuery = "SELECT * FROM tbl_wallet WHERE id_usr_wallet = " + _id_usr_wallet + ";";

            Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
            ObjconnDB.ExecutaComando(strQuery);

            return ObjconnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader Load_OneWallet(int _id_wallet)
        {   // Carrega carteira específica selecionada
            string strQuery = "SELECT * FROM tbl_wallet WHERE id_wallet = " + _id_wallet + ";";

            Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
            ObjconnDB.ExecutaComando(strQuery);

            return ObjconnDB.RetornaDataReader(strQuery);
        }
    }
}
