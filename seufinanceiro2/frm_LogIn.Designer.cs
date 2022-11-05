namespace UI
{
    partial class Frm_LogIn
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
            this.cb_SavePass = new System.Windows.Forms.CheckBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.txtB_User = new System.Windows.Forms.TextBox();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_SavePass
            // 
            this.cb_SavePass.AutoSize = true;
            this.cb_SavePass.Location = new System.Drawing.Point(12, 225);
            this.cb_SavePass.Name = "cb_SavePass";
            this.cb_SavePass.Size = new System.Drawing.Size(83, 19);
            this.cb_SavePass.TabIndex = 3;
            this.cb_SavePass.Text = "checkBox1";
            this.cb_SavePass.UseVisualStyleBackColor = true;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(12, 295);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(289, 62);
            this.btn_LogIn.TabIndex = 4;
            this.btn_LogIn.Text = "button1";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            // 
            // txtB_User
            // 
            this.txtB_User.Location = new System.Drawing.Point(12, 95);
            this.txtB_User.Multiline = true;
            this.txtB_User.Name = "txtB_User";
            this.txtB_User.Size = new System.Drawing.Size(289, 40);
            this.txtB_User.TabIndex = 1;
            // 
            // txtB_Password
            // 
            this.txtB_Password.Location = new System.Drawing.Point(12, 166);
            this.txtB_Password.Multiline = true;
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.Size = new System.Drawing.Size(289, 40);
            this.txtB_Password.TabIndex = 2;
            // 
            // Frm_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.txtB_User);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.cb_SavePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cb_SavePass;
        private Button btn_LogIn;
        private TextBox txtB_User;
        private TextBox txtB_Password;
    }
}