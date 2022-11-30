using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Wallets
    {
        DAL_ConnDB_Sql dALConnDB_Sql = new DAL_ConnDB_Sql();

        public string Insert(DTO_Wallet dTO_Wallet)
        {
            try
            {
                dALConnDB_Sql.ClearParameters();
                dALConnDB_Sql.AddParameters("@id_usr_wallet", dTO_Wallet.Id_usr_wallet);
                dALConnDB_Sql.AddParameters("@name_wallet", dTO_Wallet.Name_wallet);
                dALConnDB_Sql.AddParameters("@account_balance_wallet", dTO_Wallet.Account_Balance_Wallet);
                dALConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "WalletInsert");

                return "Carteira criada!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Update(DTO_Wallet dTO_Wallet)
        {
            try
            {
                dALConnDB_Sql.ClearParameters();
                dALConnDB_Sql.AddParameters("@id_wallet", dTO_Wallet.Id_wallet);
                dALConnDB_Sql.AddParameters("@name_wallet", dTO_Wallet.Name_wallet);
                dALConnDB_Sql.AddParameters("@account_balance_wallet", dTO_Wallet.Account_Balance_Wallet);
                dALConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "WalletUpdate");

                return "Carteira alterada!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Delete(DTO_Wallet dTO_Wallet)
        {
            try
            {
                dALConnDB_Sql.ClearParameters();
                dALConnDB_Sql.AddParameters("@id_wallet", dTO_Wallet.Id_wallet);
                dALConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "WalletDelete");

                return "Carteira deletado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }        
        public DTO_WalletCollection ConsultAll(int id)
        {
            try
            {
                DTO_WalletCollection dTO_WalletCollection = new DTO_WalletCollection();

                dALConnDB_Sql.ClearParameters();
                dALConnDB_Sql.AddParameters("@id_usr_wallet", id);
                DataTable dtWallet = dALConnDB_Sql.ExecConsultDB(CommandType.StoredProcedure, "WalletFindAll");

                foreach (DataRow row in dtWallet.Rows)
                {
                    DTO_Wallet dTO_Wallet = new DTO_Wallet();
                    dTO_Wallet.Id_wallet = Convert.ToInt32(row["id_wallet"]);
                    dTO_Wallet.Id_usr_wallet = Convert.ToInt32(row["id_usr_wallet"]);
                    dTO_Wallet.Name_wallet = Convert.ToString(row["name_wallet"]);
                    dTO_Wallet.Account_Balance_Wallet = Convert.ToDecimal(row["account_balance_wallet"]);

                    dTO_WalletCollection.Add(dTO_Wallet);
                }

                return dTO_WalletCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar carteiras. Detalhes: \n" + ex.Message);
            }
        }
        public DTO_WalletCollection ConsultById(int id)
        {
            try
            {
                DTO_WalletCollection dTO_WalletCollection = new DTO_WalletCollection();

                dALConnDB_Sql.ClearParameters();
                dALConnDB_Sql.AddParameters("@id_wallet", id);
                DataTable dtWallet = dALConnDB_Sql.ExecConsultDB(CommandType.StoredProcedure, "WalletFindId");

                foreach (DataRow row in dtWallet.Rows)
                {
                    DTO_Wallet dTO_Wallet = new DTO_Wallet();
                    dTO_Wallet.Id_wallet = Convert.ToInt32(row["id_wallet"]);
                    dTO_Wallet.Id_usr_wallet = Convert.ToInt32(row["id_usr_wallet"]);
                    dTO_Wallet.Name_wallet = Convert.ToString(row["name_wallet"]);
                    dTO_Wallet.Account_Balance_Wallet = Convert.ToDecimal(row["account_balance_wallet "]);

                    dTO_WalletCollection.Add(dTO_Wallet);
                }

                return dTO_WalletCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a carteira por Id. Detalhes: \n" + ex.Message);
            } 
        }
        public DTO_WalletCollection ConsultByName(string name, int id)
        {
            try
            {
                DTO_WalletCollection dTO_WalletCollection = new DTO_WalletCollection();

                dALConnDB_Sql.ClearParameters();
                dALConnDB_Sql.AddParameters("@name_wallet", name);
                dALConnDB_Sql.AddParameters("@id_usr_wallet", id);
                DataTable dtWallet = dALConnDB_Sql.ExecConsultDB(CommandType.StoredProcedure, "WalletFindName");

                foreach (DataRow row in dtWallet.Rows)
                {
                    DTO_Wallet dTO_Wallet = new DTO_Wallet();
                    dTO_Wallet.Id_wallet = Convert.ToInt32(row["id_wallet"]);
                    dTO_Wallet.Id_usr_wallet = Convert.ToInt32(row["id_usr_wallet"]);
                    dTO_Wallet.Name_wallet = Convert.ToString(row["name_wallet"]);
                    dTO_Wallet.Account_Balance_Wallet = Convert.ToDecimal(row["account_balance_wallet "]);

                    dTO_WalletCollection.Add(dTO_Wallet);
                }

                return dTO_WalletCollection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a carteira por nome. Detalhes: \n" + ex.Message);
            }
        }
    }
}