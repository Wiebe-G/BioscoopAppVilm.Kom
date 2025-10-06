namespace Film.Kom
{
    partial class frmLogin
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
            pnlLoginMain = new TableLayoutPanel();
            pnlLoginSecundary = new TableLayoutPanel();
            pnlLoginTitel1 = new TableLayoutPanel();
            pnlLoginTitel2 = new TableLayoutPanel();
            label2 = new Label();
            lblLoginTitel2 = new Label();
            pnlLoginInfo = new TableLayoutPanel();
            pnlEmail = new TableLayoutPanel();
            txtUsername = new TextBox();
            label1 = new Label();
            pnlWachtwoord = new TableLayoutPanel();
            txtPassword = new TextBox();
            label3 = new Label();
            pnlButton = new TableLayoutPanel();
            btnLogin = new Button();
            lblErrorMessage = new Label();
            picLogo = new PictureBox();
            btnMakeAccount = new Button();
            pnlLoginMain.SuspendLayout();
            pnlLoginSecundary.SuspendLayout();
            pnlLoginTitel1.SuspendLayout();
            pnlLoginTitel2.SuspendLayout();
            pnlLoginInfo.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlWachtwoord.SuspendLayout();
            pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLoginMain
            // 
            pnlLoginMain.BackColor = Color.Black;
            pnlLoginMain.ColumnCount = 3;
            pnlLoginMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pnlLoginMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            pnlLoginMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            pnlLoginMain.Controls.Add(pnlLoginSecundary, 1, 1);
            pnlLoginMain.Dock = DockStyle.Fill;
            pnlLoginMain.Location = new Point(0, 0);
            pnlLoginMain.Name = "pnlLoginMain";
            pnlLoginMain.RowCount = 3;
            pnlLoginMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.93901F));
            pnlLoginMain.RowStyles.Add(new RowStyle(SizeType.Percent, 78.99323F));
            pnlLoginMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlLoginMain.Size = new Size(1901, 1055);
            pnlLoginMain.TabIndex = 3;
            // 
            // pnlLoginSecundary
            // 
            pnlLoginSecundary.BackColor = SystemColors.ButtonHighlight;
            pnlLoginSecundary.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            pnlLoginSecundary.ColumnCount = 1;
            pnlLoginSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlLoginSecundary.Controls.Add(pnlLoginTitel1, 0, 0);
            pnlLoginSecundary.Controls.Add(pnlLoginInfo, 0, 1);
            pnlLoginSecundary.Dock = DockStyle.Fill;
            pnlLoginSecundary.Location = new Point(636, 118);
            pnlLoginSecundary.Name = "pnlLoginSecundary";
            pnlLoginSecundary.RowCount = 2;
            pnlLoginSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 17.86834F));
            pnlLoginSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 82.13166F));
            pnlLoginSecundary.Size = new Size(627, 827);
            pnlLoginSecundary.TabIndex = 0;
            // 
            // pnlLoginTitel1
            // 
            pnlLoginTitel1.BackColor = Color.FromArgb(113, 0, 1);
            pnlLoginTitel1.ColumnCount = 1;
            pnlLoginTitel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginTitel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlLoginTitel1.Controls.Add(pnlLoginTitel2, 0, 0);
            pnlLoginTitel1.Dock = DockStyle.Fill;
            pnlLoginTitel1.Location = new Point(4, 4);
            pnlLoginTitel1.Name = "pnlLoginTitel1";
            pnlLoginTitel1.RowCount = 1;
            pnlLoginTitel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlLoginTitel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 174F));
            pnlLoginTitel1.Size = new Size(619, 141);
            pnlLoginTitel1.TabIndex = 0;
            // 
            // pnlLoginTitel2
            // 
            pnlLoginTitel2.ColumnCount = 1;
            pnlLoginTitel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginTitel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlLoginTitel2.Controls.Add(label2, 0, 0);
            pnlLoginTitel2.Controls.Add(lblLoginTitel2, 0, 1);
            pnlLoginTitel2.Dock = DockStyle.Fill;
            pnlLoginTitel2.Location = new Point(3, 3);
            pnlLoginTitel2.Name = "pnlLoginTitel2";
            pnlLoginTitel2.RowCount = 2;
            pnlLoginTitel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlLoginTitel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlLoginTitel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            pnlLoginTitel2.Size = new Size(613, 135);
            pnlLoginTitel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Rockwell", 22.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(607, 67);
            label2.TabIndex = 2;
            label2.Text = "Vilm.kom";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoginTitel2
            // 
            lblLoginTitel2.AutoSize = true;
            lblLoginTitel2.Dock = DockStyle.Fill;
            lblLoginTitel2.Font = new Font("Rockwell", 22.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitel2.ForeColor = SystemColors.ButtonHighlight;
            lblLoginTitel2.Location = new Point(3, 67);
            lblLoginTitel2.Name = "lblLoginTitel2";
            lblLoginTitel2.Size = new Size(607, 68);
            lblLoginTitel2.TabIndex = 1;
            lblLoginTitel2.Text = "Inloggen";
            lblLoginTitel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginInfo
            // 
            pnlLoginInfo.ColumnCount = 1;
            pnlLoginInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginInfo.Controls.Add(pnlEmail, 0, 1);
            pnlLoginInfo.Controls.Add(pnlWachtwoord, 0, 3);
            pnlLoginInfo.Controls.Add(pnlButton, 0, 5);
            pnlLoginInfo.Controls.Add(lblErrorMessage, 0, 2);
            pnlLoginInfo.Controls.Add(picLogo, 0, 0);
            pnlLoginInfo.Dock = DockStyle.Fill;
            pnlLoginInfo.Location = new Point(4, 152);
            pnlLoginInfo.Name = "pnlLoginInfo";
            pnlLoginInfo.RowCount = 7;
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            pnlLoginInfo.Size = new Size(619, 671);
            pnlLoginInfo.TabIndex = 1;
            // 
            // pnlEmail
            // 
            pnlEmail.BackColor = Color.FromArgb(219, 2, 5);
            pnlEmail.ColumnCount = 3;
            pnlEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlEmail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlEmail.Controls.Add(txtUsername, 1, 1);
            pnlEmail.Controls.Add(label1, 1, 0);
            pnlEmail.Dock = DockStyle.Fill;
            pnlEmail.ForeColor = SystemColors.ButtonFace;
            pnlEmail.Location = new Point(3, 98);
            pnlEmail.Name = "pnlEmail";
            pnlEmail.RowCount = 2;
            pnlEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlEmail.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlEmail.Size = new Size(613, 89);
            pnlEmail.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(64, 29);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(484, 57);
            txtUsername.TabIndex = 0;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.KeyDown += LoginEnter_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(482, 26);
            label1.TabIndex = 1;
            label1.Text = "Gebruikersnaam:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlWachtwoord
            // 
            pnlWachtwoord.BackColor = Color.FromArgb(219, 2, 5);
            pnlWachtwoord.ColumnCount = 3;
            pnlWachtwoord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlWachtwoord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlWachtwoord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlWachtwoord.Controls.Add(txtPassword, 1, 1);
            pnlWachtwoord.Controls.Add(label3, 1, 0);
            pnlWachtwoord.Dock = DockStyle.Fill;
            pnlWachtwoord.Location = new Point(3, 288);
            pnlWachtwoord.Name = "pnlWachtwoord";
            pnlWachtwoord.RowCount = 2;
            pnlWachtwoord.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlWachtwoord.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlWachtwoord.Size = new Size(613, 89);
            pnlWachtwoord.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(64, 29);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(484, 57);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.KeyDown += LoginEnter_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Rockwell", 14.25F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(65, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(482, 26);
            label3.TabIndex = 3;
            label3.Text = "Wachtwoord:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlButton
            // 
            pnlButton.ColumnCount = 2;
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlButton.Controls.Add(btnLogin, 0, 1);
            pnlButton.Controls.Add(btnMakeAccount, 1, 1);
            pnlButton.Dock = DockStyle.Fill;
            pnlButton.Location = new Point(3, 478);
            pnlButton.Name = "pnlButton";
            pnlButton.RowCount = 3;
            pnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlButton.Size = new Size(613, 89);
            pnlButton.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(113, 0, 1);
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(3, 16);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 56);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            btnLogin.KeyDown += LoginEnter_KeyDown;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Dock = DockStyle.Fill;
            lblErrorMessage.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(4, 190);
            lblErrorMessage.Margin = new Padding(4, 0, 4, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(611, 95);
            lblErrorMessage.TabIndex = 8;
            lblErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(613, 89);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnMakeAccount
            // 
            btnMakeAccount.BackColor = Color.FromArgb(113, 0, 1);
            btnMakeAccount.Dock = DockStyle.Fill;
            btnMakeAccount.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMakeAccount.ForeColor = SystemColors.ButtonFace;
            btnMakeAccount.Location = new Point(309, 16);
            btnMakeAccount.Name = "btnMakeAccount";
            btnMakeAccount.Size = new Size(301, 56);
            btnMakeAccount.TabIndex = 1;
            btnMakeAccount.Text = "Account aanmaken";
            btnMakeAccount.UseVisualStyleBackColor = false;
            btnMakeAccount.Click += btnMakeAccount_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1901, 1055);
            Controls.Add(pnlLoginMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = "Login-Vilm.kom";
            pnlLoginMain.ResumeLayout(false);
            pnlLoginSecundary.ResumeLayout(false);
            pnlLoginTitel1.ResumeLayout(false);
            pnlLoginTitel2.ResumeLayout(false);
            pnlLoginTitel2.PerformLayout();
            pnlLoginInfo.ResumeLayout(false);
            pnlLoginInfo.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlWachtwoord.ResumeLayout(false);
            pnlWachtwoord.PerformLayout();
            pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlLoginMain;
        private System.Windows.Forms.TableLayoutPanel pnlLoginSecundary;
        private System.Windows.Forms.TableLayoutPanel pnlLoginTitel1;
        private System.Windows.Forms.TableLayoutPanel pnlLoginTitel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoginTitel2;
        private System.Windows.Forms.TableLayoutPanel pnlLoginInfo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TableLayoutPanel pnlEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel pnlWachtwoord;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel pnlButton;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblErrorMessage;
        private Button btnMakeAccount;
    }
}
