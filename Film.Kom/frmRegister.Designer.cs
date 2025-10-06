namespace Film.Kom
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            pnlButton = new TableLayoutPanel();
            btnRegister = new Button();
            txtPassword = new TextBox();
            pnlWachtwoord = new TableLayoutPanel();
            lblPassword = new Label();
            lblErrorMessage = new Label();
            txtUsername = new TextBox();
            pnlLoginInfo = new TableLayoutPanel();
            pnlEmail = new TableLayoutPanel();
            lblUsername = new Label();
            pnlTabLogo = new TableLayoutPanel();
            pictLogo = new PictureBox();
            pnlTabMail = new TableLayoutPanel();
            txtMail = new TextBox();
            lblMail = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtPasswordRepeat = new TextBox();
            lblPasswordRepeat = new Label();
            lblName = new Label();
            lblRegisterTitle = new Label();
            pnlLoginTitel2 = new TableLayoutPanel();
            pnlLoginTitel1 = new TableLayoutPanel();
            pnlLoginSecundary = new TableLayoutPanel();
            pnlLoginMain = new TableLayoutPanel();
            pnlButton.SuspendLayout();
            pnlWachtwoord.SuspendLayout();
            pnlLoginInfo.SuspendLayout();
            pnlEmail.SuspendLayout();
            pnlTabLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictLogo).BeginInit();
            pnlTabMail.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlLoginTitel2.SuspendLayout();
            pnlLoginTitel1.SuspendLayout();
            pnlLoginSecundary.SuspendLayout();
            pnlLoginMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButton
            // 
            pnlButton.ColumnCount = 3;
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            pnlButton.Controls.Add(btnRegister, 1, 1);
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
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(113, 0, 1);
            btnRegister.Dock = DockStyle.Fill;
            btnRegister.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(156, 16);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 56);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registreer \r\n    \r\n";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.KeyDown += LoginEnter_KeyDown;
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
            // pnlWachtwoord
            // 
            pnlWachtwoord.BackColor = Color.FromArgb(219, 2, 5);
            pnlWachtwoord.ColumnCount = 3;
            pnlWachtwoord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlWachtwoord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlWachtwoord.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlWachtwoord.Controls.Add(txtPassword, 1, 1);
            pnlWachtwoord.Controls.Add(lblPassword, 1, 0);
            pnlWachtwoord.Dock = DockStyle.Fill;
            pnlWachtwoord.Location = new Point(3, 288);
            pnlWachtwoord.Name = "pnlWachtwoord";
            pnlWachtwoord.RowCount = 2;
            pnlWachtwoord.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlWachtwoord.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlWachtwoord.Size = new Size(613, 89);
            pnlWachtwoord.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(65, 0);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(482, 26);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Wachtwoord:";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Dock = DockStyle.Fill;
            lblErrorMessage.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(4, 570);
            lblErrorMessage.Margin = new Padding(4, 0, 4, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(611, 101);
            lblErrorMessage.TabIndex = 8;
            lblErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
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
            // pnlLoginInfo
            // 
            pnlLoginInfo.ColumnCount = 1;
            pnlLoginInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginInfo.Controls.Add(pnlEmail, 0, 1);
            pnlLoginInfo.Controls.Add(pnlButton, 0, 5);
            pnlLoginInfo.Controls.Add(pnlTabLogo, 0, 0);
            pnlLoginInfo.Controls.Add(pnlWachtwoord, 0, 3);
            pnlLoginInfo.Controls.Add(pnlTabMail, 0, 2);
            pnlLoginInfo.Controls.Add(lblErrorMessage, 0, 6);
            pnlLoginInfo.Controls.Add(tableLayoutPanel2, 0, 4);
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
            pnlEmail.Controls.Add(lblUsername, 1, 0);
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
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(65, 0);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(482, 26);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Gebruikersnaam:";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTabLogo
            // 
            pnlTabLogo.ColumnCount = 3;
            pnlTabLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabLogo.Controls.Add(pictLogo, 1, 0);
            pnlTabLogo.Dock = DockStyle.Fill;
            pnlTabLogo.Location = new Point(3, 3);
            pnlTabLogo.Name = "pnlTabLogo";
            pnlTabLogo.RowCount = 1;
            pnlTabLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabLogo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabLogo.Size = new Size(613, 89);
            pnlTabLogo.TabIndex = 9;
            // 
            // pictLogo
            // 
            pictLogo.Dock = DockStyle.Fill;
            pictLogo.Image = (Image)resources.GetObject("pictLogo.Image");
            pictLogo.Location = new Point(207, 3);
            pictLogo.Name = "pictLogo";
            pictLogo.Size = new Size(198, 83);
            pictLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictLogo.TabIndex = 0;
            pictLogo.TabStop = false;
            // 
            // pnlTabMail
            // 
            pnlTabMail.BackColor = Color.FromArgb(219, 2, 5);
            pnlTabMail.ColumnCount = 3;
            pnlTabMail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTabMail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlTabMail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTabMail.Controls.Add(txtMail, 1, 1);
            pnlTabMail.Controls.Add(lblMail, 1, 0);
            pnlTabMail.Dock = DockStyle.Fill;
            pnlTabMail.ForeColor = SystemColors.ButtonFace;
            pnlTabMail.Location = new Point(3, 193);
            pnlTabMail.Name = "pnlTabMail";
            pnlTabMail.RowCount = 2;
            pnlTabMail.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlTabMail.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlTabMail.Size = new Size(613, 89);
            pnlTabMail.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Dock = DockStyle.Fill;
            txtMail.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(64, 29);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(484, 57);
            txtMail.TabIndex = 0;
            txtMail.TextAlign = HorizontalAlignment.Center;
            txtMail.KeyDown += LoginEnter_KeyDown;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Dock = DockStyle.Fill;
            lblMail.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(65, 0);
            lblMail.Margin = new Padding(4, 0, 4, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(482, 26);
            lblMail.TabIndex = 1;
            lblMail.Text = "Mailadres:";
            lblMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(219, 2, 5);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(txtPasswordRepeat, 1, 1);
            tableLayoutPanel2.Controls.Add(lblPasswordRepeat, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 383);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(613, 89);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // txtPasswordRepeat
            // 
            txtPasswordRepeat.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordRepeat.Dock = DockStyle.Fill;
            txtPasswordRepeat.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPasswordRepeat.Location = new Point(64, 29);
            txtPasswordRepeat.Multiline = true;
            txtPasswordRepeat.Name = "txtPasswordRepeat";
            txtPasswordRepeat.PasswordChar = '*';
            txtPasswordRepeat.Size = new Size(484, 57);
            txtPasswordRepeat.TabIndex = 2;
            txtPasswordRepeat.TextAlign = HorizontalAlignment.Center;
            txtPasswordRepeat.KeyDown += LoginEnter_KeyDown;
            // 
            // lblPasswordRepeat
            // 
            lblPasswordRepeat.AutoSize = true;
            lblPasswordRepeat.Dock = DockStyle.Fill;
            lblPasswordRepeat.Font = new Font("Rockwell", 14.25F);
            lblPasswordRepeat.ForeColor = SystemColors.ButtonFace;
            lblPasswordRepeat.Location = new Point(65, 0);
            lblPasswordRepeat.Margin = new Padding(4, 0, 4, 0);
            lblPasswordRepeat.Name = "lblPasswordRepeat";
            lblPasswordRepeat.Size = new Size(482, 26);
            lblPasswordRepeat.TabIndex = 3;
            lblPasswordRepeat.Text = "Wachtwoord herhalen:";
            lblPasswordRepeat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Rockwell", 22.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(607, 67);
            lblName.TabIndex = 2;
            lblName.Text = "Vilm.kom";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.AutoSize = true;
            lblRegisterTitle.Dock = DockStyle.Fill;
            lblRegisterTitle.Font = new Font("Rockwell", 22.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterTitle.ForeColor = SystemColors.ButtonHighlight;
            lblRegisterTitle.Location = new Point(3, 67);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(607, 68);
            lblRegisterTitle.TabIndex = 1;
            lblRegisterTitle.Text = "Account aanmaken";
            lblRegisterTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginTitel2
            // 
            pnlLoginTitel2.ColumnCount = 1;
            pnlLoginTitel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginTitel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlLoginTitel2.Controls.Add(lblName, 0, 0);
            pnlLoginTitel2.Controls.Add(lblRegisterTitle, 0, 1);
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
            pnlLoginMain.TabIndex = 4;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1901, 1055);
            Controls.Add(pnlLoginMain);
            Name = "frmRegister";
            Text = "frmRegister";
            pnlButton.ResumeLayout(false);
            pnlWachtwoord.ResumeLayout(false);
            pnlWachtwoord.PerformLayout();
            pnlLoginInfo.ResumeLayout(false);
            pnlLoginInfo.PerformLayout();
            pnlEmail.ResumeLayout(false);
            pnlEmail.PerformLayout();
            pnlTabLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictLogo).EndInit();
            pnlTabMail.ResumeLayout(false);
            pnlTabMail.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnlLoginTitel2.ResumeLayout(false);
            pnlLoginTitel2.PerformLayout();
            pnlLoginTitel1.ResumeLayout(false);
            pnlLoginSecundary.ResumeLayout(false);
            pnlLoginMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        //private PictureBox picLogo;
        private Button btnRegister;
        private TableLayoutPanel pnlButton;
        private TextBox txtPassword;
        //private Label label3;
        private TableLayoutPanel pnlWachtwoord;
        private Label lblErrorMessage;
        private TextBox txtUsername;
        private TableLayoutPanel pnlLoginInfo;
        private TableLayoutPanel pnlEmail;
        private Label lblUsername;
        private Label lblName;
        private Label lblRegisterTitle;
        private TableLayoutPanel pnlLoginTitel2;
        private TableLayoutPanel pnlLoginTitel1;
        private TableLayoutPanel pnlLoginSecundary;
        private TableLayoutPanel pnlLoginMain;
        private TableLayoutPanel pnlTabLogo;
        private PictureBox pictLogo;
        private TableLayoutPanel pnlTabMail;
        private TextBox txtMail;
        private Label lblMail;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtPasswordRepeat;
        private Label lblPasswordRepeat;
        private Label lblPassword;
    }
}