namespace UI
{
    partial class Frm_Principal
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
            this.statusStrip_Principal = new System.Windows.Forms.StatusStrip();
            this.lbl_version = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip_Principal = new System.Windows.Forms.MenuStrip();
            this.menu_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Inicio_Novo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Inicio_Novo_Carteira = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Inicio_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Carteira = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Opcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Principal.SuspendLayout();
            this.menuStrip_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip_Principal
            // 
            this.statusStrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_version});
            this.statusStrip_Principal.Location = new System.Drawing.Point(0, 659);
            this.statusStrip_Principal.Name = "statusStrip_Principal";
            this.statusStrip_Principal.Size = new System.Drawing.Size(984, 22);
            this.statusStrip_Principal.TabIndex = 1;
            this.statusStrip_Principal.Text = "statusStrip1";
            // 
            // lbl_version
            // 
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(69, 17);
            this.lbl_version.Text = "Version 0.1a";
            // 
            // menuStrip_Principal
            // 
            this.menuStrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Inicio,
            this.menu_Carteira,
            this.menu_Opcoes});
            this.menuStrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Principal.Name = "menuStrip_Principal";
            this.menuStrip_Principal.Size = new System.Drawing.Size(984, 24);
            this.menuStrip_Principal.TabIndex = 3;
            this.menuStrip_Principal.Text = "menuStrip1";
            // 
            // menu_Inicio
            // 
            this.menu_Inicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Inicio_Novo,
            this.menu_Inicio_Sair});
            this.menu_Inicio.Name = "menu_Inicio";
            this.menu_Inicio.Size = new System.Drawing.Size(48, 20);
            this.menu_Inicio.Text = "Início";
            // 
            // menu_Inicio_Novo
            // 
            this.menu_Inicio_Novo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Inicio_Novo_Carteira,
            this.depósitoToolStripMenuItem,
            this.pagamentoToolStripMenuItem,
            this.pIXToolStripMenuItem,
            this.transferênciaToolStripMenuItem});
            this.menu_Inicio_Novo.Name = "menu_Inicio_Novo";
            this.menu_Inicio_Novo.Size = new System.Drawing.Size(180, 22);
            this.menu_Inicio_Novo.Text = "Novo";
            // 
            // menu_Inicio_Novo_Carteira
            // 
            this.menu_Inicio_Novo_Carteira.Name = "menu_Inicio_Novo_Carteira";
            this.menu_Inicio_Novo_Carteira.Size = new System.Drawing.Size(180, 22);
            this.menu_Inicio_Novo_Carteira.Text = "Carteira";
            // 
            // depósitoToolStripMenuItem
            // 
            this.depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            this.depósitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.depósitoToolStripMenuItem.Text = "Depósito";
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            // 
            // pIXToolStripMenuItem
            // 
            this.pIXToolStripMenuItem.Name = "pIXToolStripMenuItem";
            this.pIXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pIXToolStripMenuItem.Text = "PIX";
            // 
            // transferênciaToolStripMenuItem
            // 
            this.transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            this.transferênciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transferênciaToolStripMenuItem.Text = "Transferência";
            // 
            // menu_Inicio_Sair
            // 
            this.menu_Inicio_Sair.Name = "menu_Inicio_Sair";
            this.menu_Inicio_Sair.Size = new System.Drawing.Size(180, 22);
            this.menu_Inicio_Sair.Text = "Sair";
            this.menu_Inicio_Sair.Click += new System.EventHandler(this.menu_Inicio_Sair_Click);
            // 
            // menu_Carteira
            // 
            this.menu_Carteira.Name = "menu_Carteira";
            this.menu_Carteira.Size = new System.Drawing.Size(60, 20);
            this.menu_Carteira.Text = "Carteira";
            // 
            // menu_Opcoes
            // 
            this.menu_Opcoes.Name = "menu_Opcoes";
            this.menu_Opcoes.Size = new System.Drawing.Size(59, 20);
            this.menu_Opcoes.Text = "Opções";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.statusStrip_Principal);
            this.Controls.Add(this.menuStrip_Principal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_Principal;
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seu Financeiro 2.0";
            this.statusStrip_Principal.ResumeLayout(false);
            this.statusStrip_Principal.PerformLayout();
            this.menuStrip_Principal.ResumeLayout(false);
            this.menuStrip_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip_Principal;
        private ToolStripStatusLabel lbl_version;
        private MenuStrip menuStrip_Principal;
        private ToolStripMenuItem menu_Carteira;
        private ToolStripMenuItem menu_Opcoes;
        private ToolStripMenuItem menu_Inicio;
        private ToolStripMenuItem menu_Inicio_Novo;
        private ToolStripMenuItem menu_Inicio_Novo_Carteira;
        private ToolStripMenuItem depósitoToolStripMenuItem;
        private ToolStripMenuItem pagamentoToolStripMenuItem;
        private ToolStripMenuItem pIXToolStripMenuItem;
        private ToolStripMenuItem transferênciaToolStripMenuItem;
        private ToolStripMenuItem menu_Inicio_Sair;
    }
}