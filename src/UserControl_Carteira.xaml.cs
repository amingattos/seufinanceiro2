using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace seufinanceiro.View
{
    /// <summary>
    /// Interação lógica para UserControl_Carteira.xam
    /// </summary>
    public partial class UserControl_Carteira : UserControl
    {
        private int _id_usr, _id_wallet;
        private string _name_wallet, _balance_wallet;
        public int Id_usr { get { return _id_usr; } set { _id_usr = value; } }
        public int Id_wallet { get { return _id_wallet; } set { _id_wallet = value; } }
        public string Name_wallet { get { return _name_wallet; } set { _name_wallet = value; } }
        public string Balance_wallet { get { return _balance_wallet; } set { _balance_wallet = value; } }

        Controller.Cls_Wallet ObjCls_Wallet = new Controller.Cls_Wallet();
        public ObservableCollection<View.View_Wallet_List> Wallets { get; set; }
        public static List<View.View_Wallet_List> WalletsList { get; set; }

        public UserControl_Carteira(int _id_usr2)
        {
            Id_usr = _id_usr2;

            CarregaWallets();
            InitializeComponent();
            TC_TI_Wallets_1.Visibility = Visibility.Collapsed;
        }

        private void TC_TI_Wallets_0_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        { // Ao clicar no tab pricnipal o focu da carteira selecionada fica null
            if (TC_TI_Wallets_0.IsSelected == true)
            {
                LV_Wallets.SelectedIndex = -1;
                TC_TI_Wallets_1.Visibility = Visibility.Collapsed;
            }
        }

        private void LV_Wallets_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        { // Clicando em uma das carteira será enviado para um novo Tab com as informações dele.

            //MessageBox.Show("" + LV_Wallets.SelectedIndex.ToString());

            if (LV_Wallets.SelectedIndex >= 0)
            {
                TC_TI_Wallets_1.Visibility = Visibility.Visible;
                TC_TI_Wallets_1.IsSelected = true;
            }
        }
        public void CarregaWallets()
        {
            SqlDataReader ReaderWallet;
            ReaderWallet = ObjCls_Wallet.Load_Wallets(_id_usr);

            Wallets = new ObservableCollection<View.View_Wallet_List>();

            while (ReaderWallet.Read())
            {
                Wallets.Add(new View.View_Wallet_List
                {
                    Id_Wallet = int.Parse(ReaderWallet[0].ToString()),
                    Name_Wallet = ReaderWallet[2].ToString(),
                    Balance_Wallet = string.Format("{0:0,0.00}", double.Parse(ReaderWallet[3].ToString()))
                });
            }
        }
    }
}