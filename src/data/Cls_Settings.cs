using System.Data.SqlClient;

namespace seufinanceiro.Controller
{
    internal class Cls_Settings
    {
        private bool _auto_pwd, _notification;
        private int _id_usr, _themes;
        string updateSaveLogin = "1";
        //string _save = "1";

        public bool Auto_pwd // Salva o login
        { get { return _auto_pwd; } set { _auto_pwd = value; } }
        public bool Notification // Notificações
        { get { return _notification; } set { _notification = value; } }
        public int Id_usr // ID do usuario
        { get { return _id_usr; } set { _id_usr = value; } }
        public int Themes // Temas
        { get { return _themes; } set { _themes = value; } }

        public SqlDataReader LoginSalvo()
        {
            string strQuery = "Select count(auto_pwd_settings) SaveLogin from tbl_settings where auto_pwd_settings = 1";
            Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();

            return ObjConnDB.RetornaDataReader(strQuery);
        }
        public SqlDataReader IDUserSave()
        {
            string strQuery = "Select * from tbl_settings where auto_pwd_settings = 1";
            Model.Cls_ConnDB_Sql ObjConnDB = new Model.Cls_ConnDB_Sql();

            return ObjConnDB.RetornaDataReader(strQuery);
        }
        public void Create_Settings(string _id_usr)
        {
            string strQuery = "INSERT tbl_settings VALUES('" + _id_usr + "', 0, 0, 0)";

            Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
            ObjconnDB.ExecutaComando(strQuery);
        }
        public void SaveLoginAuto(string _id_usr, string _save)
        {  // INSERT tbl_settings VALUES(1, 1, 0, 0)
            string strQuery;

            switch (updateSaveLogin)
            {
                case "1":  // Limpa todos os campo auto_pwd_settings para 0.
                    if (_save == "1")
                    {
                        strQuery = "Update tbl_settings set auto_pwd_settings = 0";
                        Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
                        ObjconnDB.ExecutaComando(strQuery);

                        updateSaveLogin = "2";
                        SaveLoginAuto(_id_usr, _save);
                    }
                    else if (_save == "2")
                    {
                        strQuery = "Update tbl_settings set auto_pwd_settings = 0";
                        Model.Cls_ConnDB_Sql ObjconnDB = new Model.Cls_ConnDB_Sql();
                        ObjconnDB.ExecutaComando(strQuery);
                    }

                    break;

                case "2": // Coloca 1 no campo onde tem o id_usr_login.
                    strQuery = "Update tbl_settings set auto_pwd_settings = 1 where id_usr_login = '" + _id_usr + "' ";
                    Model.Cls_ConnDB_Sql ObjconnDB2 = new Model.Cls_ConnDB_Sql();
                    ObjconnDB2.ExecutaComando(strQuery);

                    break;
            }
        }
    }
}
