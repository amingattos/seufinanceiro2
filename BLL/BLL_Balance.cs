using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    internal class BLL_Balance
    {
        DAL_ConnDB_Sql dAL_ConnDB_Sql = new DAL_ConnDB_Sql();

        public string Insert(DTO_Balance dTO_Balance)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@id_type_balance", dTO_Balance.Id_Balance_Type);
                dAL_ConnDB_Sql.AddParameters("@id_wallet_balance", dTO_Balance.Id_Wallet_Balance);
                dAL_ConnDB_Sql.AddParameters("@value_balance", dTO_Balance.Value_Balance);
                dAL_ConnDB_Sql.AddParameters("@date_balance", dTO_Balance.Date_Balance);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "BalanceInsert");

                return "Valor Adicionado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Update(DTO_Balance dTO_Balance)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@id_balance", dTO_Balance.Id_Balance);
                dAL_ConnDB_Sql.AddParameters("@id_type_balance", dTO_Balance.Id_Balance_Type);
                dAL_ConnDB_Sql.AddParameters("@id_wallet_balance", dTO_Balance.Id_Wallet_Balance);
                dAL_ConnDB_Sql.AddParameters("@value_balance", dTO_Balance.Value_Balance);
                dAL_ConnDB_Sql.AddParameters("@date_balance", dTO_Balance.Date_Balance);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "BalanceUpdate");

                return "Alterado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Delete(DTO_Balance dTO_Balance)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@id_balance", dTO_Balance.Id_Balance);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "BalanceDelete");

                return "Apagado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string FindAll(DTO_Balance dTO_Balance)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "BalanceFindAll");

                return "Encontrado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }       
        public string FindAllBalanceWallet(DTO_Balance dTO_Balance)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@id_wallet_balance", dTO_Balance.Id_Wallet_Balance);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "BalanceFindWallet");

                return "Encontrado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }       
        public string FindAllValue(DTO_Balance dTO_Balance)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@value_balance", dTO_Balance.Value_Balance);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "BalanceFindValue");

                return "Encontrado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }       
        public string FindAllDate(DTO_Balance dTO_Balance)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@date_balance", dTO_Balance.Date_Balance);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "BalanceFindDate");

                return "Encontrado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
