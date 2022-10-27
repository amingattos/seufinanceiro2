using System.Data.SqlClient;

namespace DTO
{
    internal class Cls_Login
    {
        private string _usr, _pwd;
        private int _id_usr;
        public string Usr
        { get { return _usr; } set { _usr = value; } }
        public string Pws
        { get { return _pwd; } set { _pwd = value; } }
        public int Id_usr
        { get { return _id_usr; } set { _id_usr = value; } }
        public SqlDataReader Logar(string _usr, string _pwd)
        {
            string strQuery = "Select * from tbl_usr where usr = '" + _usr + "' and pwd = '" + _pwd + "'";
            Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();

            return ObjConnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader Existinguser(string _usr, string _pwd)
        {
            string strQuery = "Select count(usr) users from tbl_usr where usr = '" + _usr + "' and pwd = '" + _pwd + "'";

            Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();
            return ObjConnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader LoadSaveLogin(string _usr)
        {
            string strQuery = "Select * from tbl_usr where id_usr = " + _usr + "";

            Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();
            return ObjConnDB.RetornaDataReader(strQuery);
        }
        //public SqlDataReader ContaLogado(string _id_usr)
        //{
        //    string strQuery = "Update tbl_usr set status = 1 where id_usr = " + _id_usr + ";";

        //    Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();
        //    return ObjConnDB.RetornaDataReader(strQuery);
        //}
        public SqlDataReader ContaDeslogado(string _id_usr)
        {
            string strQuery = "Update tbl_usr set status = 0 where id_usr = " + _id_usr + ";";

            Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();
            return ObjConnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader Conta_Conectado()
        {
            string strQuery = "Select id_usr ID from tbl_usr where status = 1";

            Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();
            return ObjConnDB.RetornaDataReader(strQuery);
        }
    }
}
