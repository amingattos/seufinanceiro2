﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void menu_Inicio_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Carteira_Click(object sender, EventArgs e)
        {
            Frm_Wallet frm_Wallet = new Frm_Wallet();
            frm_Wallet.MdiParent = this;
            frm_Wallet.Show();
        }
    }
}
