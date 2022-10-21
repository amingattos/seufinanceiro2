using System.Windows;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Threading;
using System;

namespace seufinanceiro.View
{
    /// <summary>
    /// Interação lógica para UserControl_Dashboard.xam
    /// </summary>
    public partial class UserControl_Inicio : UserControl
    {
        string saldoTotal = "0,00"/*, saldoDespesa = "0,00", saldoReceita = "0,00"*/;
        private int _id_usr;

        readonly DispatcherTimer dispatcherTimer = new DispatcherTimer();
        
        public UserControl_Inicio(int ID_user)
        {
            _id_usr = ID_user;

            InitializeComponent();
            CarregaSaldo();
        }
        public void CarregaSaldo()
        {
            Controller.Cls_Wallet ObjWallet = new Controller.Cls_Wallet();
            SqlDataReader ObjDados_Wallet;
            ObjDados_Wallet = ObjWallet.SaldoTotal_Wallets(_id_usr);
            ObjDados_Wallet.Read();

            saldoTotal = string.Format("{0:0,0.00}", double.Parse(ObjDados_Wallet["saldo_total"].ToString()));

            if (double.Parse(ObjDados_Wallet["saldo_total"].ToString()) >= 0)
            {
                txt_saldo_total.Text = saldoTotal;
            }
        }
    }
}
