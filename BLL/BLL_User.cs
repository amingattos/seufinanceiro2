using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_User
    {
        DAL_ConnDB_Sql dAL_ConnDB_Sql = new DAL_ConnDB_Sql();

        public string Insert(DTO_User dTO_User)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@usr", dTO_User.Usr);
                dAL_ConnDB_Sql.AddParameters("@pwd", dTO_User.Pwd);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "UserInsert");

                return "Usuário criado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }        
        public string Update(DTO_User dTO_User)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@id_usr", dTO_User.Id_usr);
                dAL_ConnDB_Sql.AddParameters("@usr", dTO_User.Usr);
                dAL_ConnDB_Sql.AddParameters("@pwd", dTO_User.Pwd);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "UserUpdate");

                return "Usuário alterado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }       
        public string Delete(DTO_User dTO_User)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@id_usr", dTO_User.Id_usr);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "UserDelete");

                return "Usuário deletado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string FindLogin(DTO_User dTO_User)
        {
            try
            {
                dAL_ConnDB_Sql.ClearParameters();
                dAL_ConnDB_Sql.AddParameters("@usr", dTO_User.Usr);
                dAL_ConnDB_Sql.AddParameters("@pwd", dTO_User.Pwd);
                dAL_ConnDB_Sql.ExecCommandDB(CommandType.StoredProcedure, "UserFindLogin");

                return "Usuário encontrado!";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

    }
}
