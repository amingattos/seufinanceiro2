using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Frm_Wallet : Form
    {
        public Frm_Wallet()
        {
            InitializeComponent();
        }

        private void Frm_Wallet_Load(object sender, EventArgs e)
        {
            Load_Wallet();
        }

        private void Load_Wallet()
        {
            BLL_Wallets bLL_Wallets = new BLL_Wallets();

            DTO_WalletCollection dTO_WalletCollection = new DTO_WalletCollection();
            dTO_WalletCollection = bLL_Wallets.ConsultAll(1);

            GenerateGrid();

            foreach (var item in dTO_WalletCollection)
            {
                listView_Wallets.Items.Add(new ListViewItem(new string[] { item.Name_wallet, item.Account_Balance_Wallet.ToString("C")}));
            }

            dataGrid_Wallet_Select.DataSource = null;
            dataGrid_Wallet_Select.DataSource = dTO_WalletCollection;

            //dataGrid_Wallet_Select.Update();
            //dataGrid_Wallet_Select.Refresh();
        }
        private void GenerateGrid()
        {
            listView_Wallets.Columns.Add("Carteira", 128);
            listView_Wallets.Columns.Add("Saldo Disp.", 127);

            listView_Wallets.FullRowSelect = true;
            //listView_Wallets.GridLines = true;
            //listView_Wallets.CheckBoxes = true;

        }

        private void listView_Wallets_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ao Selecionar colocar as infos da carteira na tela
        }
    }
}
