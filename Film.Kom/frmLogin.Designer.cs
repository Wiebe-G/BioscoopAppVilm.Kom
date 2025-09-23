namespace Film.Kom
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTabLogin = new TableLayoutPanel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            pnlTabLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabLogin
            // 
            pnlTabLogin.ColumnCount = 2;
            pnlTabLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabLogin.Controls.Add(txtUsername, 1, 0);
            pnlTabLogin.Controls.Add(txtPassword, 1, 1);
            pnlTabLogin.Controls.Add(btnLogin, 1, 2);
            pnlTabLogin.Controls.Add(lblUsername, 0, 0);
            pnlTabLogin.Controls.Add(lblPassword, 0, 1);
            pnlTabLogin.Dock = DockStyle.Fill;
            pnlTabLogin.Location = new Point(0, 0);
            pnlTabLogin.Name = "pnlTabLogin";
            pnlTabLogin.RowCount = 3;
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            pnlTabLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabLogin.Size = new Size(1127, 492);
            pnlTabLogin.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlDark;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(566, 3);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(558, 190);
            txtUsername.TabIndex = 0;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlDark;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(566, 199);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(558, 190);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlDark;
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Location = new Point(566, 395);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(558, 94);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = SystemColors.ControlDark;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Location = new Point(3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(557, 196);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Gebruikersnaam: ";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = SystemColors.ControlDark;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(3, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(557, 196);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Wachtwoord:";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 492);
            Controls.Add(pnlTabLogin);
            Name = "frmLogin";
            Text = "Inloggen";
            pnlTabLogin.ResumeLayout(false);
            pnlTabLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
    }
}
