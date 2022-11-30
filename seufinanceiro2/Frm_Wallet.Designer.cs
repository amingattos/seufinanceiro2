namespace UI
{
    partial class Frm_Wallet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_delete_wallet = new System.Windows.Forms.Button();
            this.btn_edit_wallet = new System.Windows.Forms.Button();
            this.btn_new_wallet = new System.Windows.Forms.Button();
            this.listView_Wallets = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_txtSaldoDisp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_txt_SaldoTotal = new System.Windows.Forms.Label();
            this.lbl_Saldo_Total = new System.Windows.Forms.Label();
            this.btn_move = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid_Wallet_Select = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Wallet_Select)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.btn_delete_wallet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_edit_wallet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_new_wallet, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_delete_wallet
            // 
            this.btn_delete_wallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete_wallet.Location = new System.Drawing.Point(519, 3);
            this.btn_delete_wallet.Name = "btn_delete_wallet";
            this.btn_delete_wallet.Size = new System.Drawing.Size(254, 49);
            this.btn_delete_wallet.TabIndex = 5;
            this.btn_delete_wallet.Text = "&Apagar Carteira";
            this.btn_delete_wallet.UseVisualStyleBackColor = true;
            // 
            // btn_edit_wallet
            // 
            this.btn_edit_wallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edit_wallet.Location = new System.Drawing.Point(261, 3);
            this.btn_edit_wallet.Name = "btn_edit_wallet";
            this.btn_edit_wallet.Size = new System.Drawing.Size(252, 49);
            this.btn_edit_wallet.TabIndex = 4;
            this.btn_edit_wallet.Text = "&Editar Carteira";
            this.btn_edit_wallet.UseVisualStyleBackColor = true;
            // 
            // btn_new_wallet
            // 
            this.btn_new_wallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_wallet.Location = new System.Drawing.Point(3, 3);
            this.btn_new_wallet.Name = "btn_new_wallet";
            this.btn_new_wallet.Size = new System.Drawing.Size(252, 49);
            this.btn_new_wallet.TabIndex = 3;
            this.btn_new_wallet.Text = "&Nova Carteira";
            this.btn_new_wallet.UseVisualStyleBackColor = true;
            // 
            // listView_Wallets
            // 
            this.listView_Wallets.Location = new System.Drawing.Point(12, 118);
            this.listView_Wallets.Name = "listView_Wallets";
            this.listView_Wallets.Size = new System.Drawing.Size(259, 320);
            this.listView_Wallets.TabIndex = 1;
            this.listView_Wallets.UseCompatibleStateImageBehavior = false;
            this.listView_Wallets.View = System.Windows.Forms.View.Details;
            this.listView_Wallets.SelectedIndexChanged += new System.EventHandler(this.listView_Wallets_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_move, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(277, 118);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 66);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_txtSaldoDisp);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(144, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 60);
            this.panel2.TabIndex = 6;
            // 
            // lbl_txtSaldoDisp
            // 
            this.lbl_txtSaldoDisp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_txtSaldoDisp.AutoSize = true;
            this.lbl_txtSaldoDisp.Location = new System.Drawing.Point(22, 9);
            this.lbl_txtSaldoDisp.Name = "lbl_txtSaldoDisp";
            this.lbl_txtSaldoDisp.Size = new System.Drawing.Size(94, 15);
            this.lbl_txtSaldoDisp.TabIndex = 3;
            this.lbl_txtSaldoDisp.Text = "Saldo Disponível";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "5000";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_txt_SaldoTotal);
            this.panel1.Controls.Add(this.lbl_Saldo_Total);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 60);
            this.panel1.TabIndex = 0;
            // 
            // lbl_txt_SaldoTotal
            // 
            this.lbl_txt_SaldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_txt_SaldoTotal.AutoSize = true;
            this.lbl_txt_SaldoTotal.Location = new System.Drawing.Point(35, 9);
            this.lbl_txt_SaldoTotal.Name = "lbl_txt_SaldoTotal";
            this.lbl_txt_SaldoTotal.Size = new System.Drawing.Size(64, 15);
            this.lbl_txt_SaldoTotal.TabIndex = 3;
            this.lbl_txt_SaldoTotal.Text = "Saldo Total";
            // 
            // lbl_Saldo_Total
            // 
            this.lbl_Saldo_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Saldo_Total.AutoSize = true;
            this.lbl_Saldo_Total.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Saldo_Total.Location = new System.Drawing.Point(39, 24);
            this.lbl_Saldo_Total.Name = "lbl_Saldo_Total";
            this.lbl_Saldo_Total.Size = new System.Drawing.Size(56, 28);
            this.lbl_Saldo_Total.TabIndex = 4;
            this.lbl_Saldo_Total.Text = "5000";
            this.lbl_Saldo_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_move
            // 
            this.btn_move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_move.Location = new System.Drawing.Point(289, 3);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(219, 60);
            this.btn_move.TabIndex = 7;
            this.btn_move.Text = "&Movimentar";
            this.btn_move.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo Total";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "5000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGrid_Wallet_Select
            // 
            this.dataGrid_Wallet_Select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Wallet_Select.Location = new System.Drawing.Point(277, 190);
            this.dataGrid_Wallet_Select.Name = "dataGrid_Wallet_Select";
            this.dataGrid_Wallet_Select.RowTemplate.Height = 25;
            this.dataGrid_Wallet_Select.Size = new System.Drawing.Size(511, 248);
            this.dataGrid_Wallet_Select.TabIndex = 2;
            // 
            // Frm_Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid_Wallet_Select);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.listView_Wallets);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Wallet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteira";
            this.Load += new System.EventHandler(this.Frm_Wallet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Wallet_Select)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView listView_Wallets;
        private Button btn_delete_wallet;
        private Button btn_edit_wallet;
        private Button btn_new_wallet;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label lbl_txtSaldoDisp;
        private Label label4;
        private Panel panel1;
        private Label lbl_txt_SaldoTotal;
        private Label lbl_Saldo_Total;
        private Label label1;
        private Label label2;
        private Button btn_move;
        private DataGridView dataGrid_Wallet_Select;
    }
}