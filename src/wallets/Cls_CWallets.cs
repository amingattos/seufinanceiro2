using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;

namespace seufinanceiro.Controller
{
    internal class Cls_CWallets
    {
        readonly Cls_Wallet ObjCls_Wallets = new Cls_Wallet();

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

        public string GetButtons(WrapPanel WP_Wallets)
        {
            string ret = "";
            try
            {
                SqlDataReader ObjWallet;
                ObjWallet = ObjCls_Wallets.Load_Wallet(_id_usr_wallet);

                string id, name, balance;

                while(ObjWallet.Read())
                {
                    id = ObjWallet[0].ToString();
                    name = ObjWallet[2].ToString();
                    balance = string.Format("{0:0,0.00}", double.Parse(ObjWallet[3].ToString()));

                    View.UserControl_Wallets UC_Wallets = new View.UserControl_Wallets();

                    UC_Wallets.Id = id;
                    UC_Wallets.Name_Wallet = name;
                    UC_Wallets.Balance_Wallet = balance;

                    if(name != string.Empty)
                    {
                        WP_Wallets.Children.Add(UC_Wallets);
                    }

                    ret = "Carteira buscada com sucesso.. :";
                }
            }
            catch (Exception ex)
            {
                ret = ex.Message;
                throw;
            }
            return ret;
        }
    }
}
