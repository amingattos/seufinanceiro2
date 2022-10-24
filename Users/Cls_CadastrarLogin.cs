using System.Data.SqlClient;

namespace seufinanceiro.Controller
{
    internal class Cls_CadastrarLogin
    {
        private string _usr, _pwd;
        public string Usr
        { get { return _usr; } set { _usr = value; } }

        public string Pws
        { get { return _pwd; } set { _pwd = value; } }

        public SqlDataReader CadastrarLogin(string _usr, string _pwd)
        {
            string strQuery = "Insert tbl_usr values ('" + _usr + "','" + _pwd + "')";
            Cls_ConnDB_Sql ObjConnDB = new Cls_ConnDB_Sql();

            return ObjConnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader Exist_User(string _usr)
        {
            string strQuery = "Select count(usr) users from tbl_usr where usr = '" + _usr + "'";

            Cls_ConnDB_Sql ObjConnDB = new Cls_ConnDB_Sql();
            return ObjConnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader LoadID_Usr(string _usr)
        {
            string strQuery = "Select id_usr from tbl_usr where usr = '" + _usr + "'";

            Cls_ConnDB_Sql ObjConnDB = new Cls_ConnDB_Sql();
            return ObjConnDB.RetornaDataReader(strQuery);
        }
    }
}
