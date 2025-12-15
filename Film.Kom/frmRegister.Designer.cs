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
            btnBackToLogin = new Button();
            txtPassword = new TextBox();
            pnlWachtwoord = new TableLayoutPanel();
            lblPassword = new Label();
            lblErrorMessage = new Label();
            txtUsername = new TextBox();
            pnlLoginInfo = new TableLayoutPanel();
            pnlTabusername = new TableLayoutPanel();
            lblUsername = new Label();
            pnlTabLogo = new TableLayoutPanel();
            pictLogo = new PictureBox();
            pnlTabMail = new TableLayoutPanel();
            txtMail = new TextBox();
            lblMail = new Label();
            pnlTabRepeatpass = new TableLayoutPanel();
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
            pnlTabusername.SuspendLayout();
            pnlTabLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictLogo).BeginInit();
            pnlTabMail.SuspendLayout();
            pnlTabRepeatpass.SuspendLayout();
            pnlLoginTitel2.SuspendLayout();
            pnlLoginTitel1.SuspendLayout();
            pnlLoginSecundary.SuspendLayout();
            pnlLoginMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButton
            // 
            pnlButton.ColumnCount = 2;
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            pnlButton.Controls.Add(btnRegister, 0, 1);
            pnlButton.Controls.Add(btnBackToLogin, 1, 1);
            pnlButton.Dock = DockStyle.Fill;
            pnlButton.Location = new Point(3, 362);
            pnlButton.Margin = new Padding(3, 2, 3, 2);
            pnlButton.Name = "pnlButton";
            pnlButton.RowCount = 3;
            pnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlButton.Size = new Size(534, 68);
            pnlButton.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(113, 0, 1);
            btnRegister.Dock = DockStyle.Fill;
            btnRegister.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(3, 12);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(261, 43);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Registreer \r\n    \r\n";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.KeyDown += LoginEnter_KeyDown;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.FromArgb(113, 0, 1);
            btnBackToLogin.Dock = DockStyle.Fill;
            btnBackToLogin.Font = new Font("Rockwell", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToLogin.ForeColor = SystemColors.ButtonFace;
            btnBackToLogin.Location = new Point(270, 12);
            btnBackToLogin.Margin = new Padding(3, 2, 3, 2);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(261, 43);
            btnBackToLogin.TabIndex = 6;
            btnBackToLogin.Text = "Terug naar login\r\n";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(56, 22);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(421, 44);
            txtPassword.TabIndex = 3;
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
            pnlWachtwoord.Location = new Point(3, 218);
            pnlWachtwoord.Margin = new Padding(3, 2, 3, 2);
            pnlWachtwoord.Name = "pnlWachtwoord";
            pnlWachtwoord.RowCount = 2;
            pnlWachtwoord.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlWachtwoord.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlWachtwoord.Size = new Size(534, 68);
            pnlWachtwoord.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(57, 0);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(419, 20);
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
            lblErrorMessage.Location = new Point(4, 432);
            lblErrorMessage.Margin = new Padding(4, 0, 4, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(532, 72);
            lblErrorMessage.TabIndex = 8;
            lblErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(56, 22);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(421, 44);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.KeyDown += LoginEnter_KeyDown;
            // 
            // pnlLoginInfo
            // 
            pnlLoginInfo.ColumnCount = 1;
            pnlLoginInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginInfo.Controls.Add(pnlTabusername, 0, 1);
            pnlLoginInfo.Controls.Add(pnlButton, 0, 5);
            pnlLoginInfo.Controls.Add(pnlTabLogo, 0, 0);
            pnlLoginInfo.Controls.Add(pnlWachtwoord, 0, 3);
            pnlLoginInfo.Controls.Add(pnlTabMail, 0, 2);
            pnlLoginInfo.Controls.Add(lblErrorMessage, 0, 6);
            pnlLoginInfo.Controls.Add(pnlTabRepeatpass, 0, 4);
            pnlLoginInfo.Dock = DockStyle.Fill;
            pnlLoginInfo.Location = new Point(4, 114);
            pnlLoginInfo.Margin = new Padding(3, 2, 3, 2);
            pnlLoginInfo.Name = "pnlLoginInfo";
            pnlLoginInfo.RowCount = 7;
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            pnlLoginInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            pnlLoginInfo.Size = new Size(540, 504);
            pnlLoginInfo.TabIndex = 1;
            // 
            // pnlTabusername
            // 
            pnlTabusername.BackColor = Color.FromArgb(219, 2, 5);
            pnlTabusername.ColumnCount = 3;
            pnlTabusername.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTabusername.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlTabusername.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTabusername.Controls.Add(txtUsername, 1, 1);
            pnlTabusername.Controls.Add(lblUsername, 1, 0);
            pnlTabusername.Dock = DockStyle.Fill;
            pnlTabusername.ForeColor = SystemColors.ButtonFace;
            pnlTabusername.Location = new Point(3, 74);
            pnlTabusername.Margin = new Padding(3, 2, 3, 2);
            pnlTabusername.Name = "pnlTabusername";
            pnlTabusername.RowCount = 2;
            pnlTabusername.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlTabusername.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlTabusername.Size = new Size(534, 68);
            pnlTabusername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(57, 0);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(419, 20);
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
            pnlTabLogo.Location = new Point(3, 2);
            pnlTabLogo.Margin = new Padding(3, 2, 3, 2);
            pnlTabLogo.Name = "pnlTabLogo";
            pnlTabLogo.RowCount = 1;
            pnlTabLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabLogo.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            pnlTabLogo.Size = new Size(534, 68);
            pnlTabLogo.TabIndex = 9;
            // 
            // pictLogo
            // 
            pictLogo.Dock = DockStyle.Fill;
            pictLogo.Image = (Image)resources.GetObject("pictLogo.Image");
            pictLogo.Location = new Point(181, 2);
            pictLogo.Margin = new Padding(3, 2, 3, 2);
            pictLogo.Name = "pictLogo";
            pictLogo.Size = new Size(172, 64);
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
            pnlTabMail.Location = new Point(3, 146);
            pnlTabMail.Margin = new Padding(3, 2, 3, 2);
            pnlTabMail.Name = "pnlTabMail";
            pnlTabMail.RowCount = 2;
            pnlTabMail.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlTabMail.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlTabMail.Size = new Size(534, 68);
            pnlTabMail.TabIndex = 2;
            // 
            // txtMail
            // 
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Dock = DockStyle.Fill;
            txtMail.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMail.Location = new Point(56, 22);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Multiline = true;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(421, 44);
            txtMail.TabIndex = 2;
            txtMail.Text = "\\";
            txtMail.TextAlign = HorizontalAlignment.Center;
            txtMail.KeyDown += LoginEnter_KeyDown;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Dock = DockStyle.Fill;
            lblMail.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(57, 0);
            lblMail.Margin = new Padding(4, 0, 4, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(419, 20);
            lblMail.TabIndex = 1;
            lblMail.Text = "Mailadres:";
            lblMail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTabRepeatpass
            // 
            pnlTabRepeatpass.BackColor = Color.FromArgb(219, 2, 5);
            pnlTabRepeatpass.ColumnCount = 3;
            pnlTabRepeatpass.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTabRepeatpass.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlTabRepeatpass.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTabRepeatpass.Controls.Add(txtPasswordRepeat, 1, 1);
            pnlTabRepeatpass.Controls.Add(lblPasswordRepeat, 1, 0);
            pnlTabRepeatpass.Dock = DockStyle.Fill;
            pnlTabRepeatpass.Location = new Point(3, 290);
            pnlTabRepeatpass.Margin = new Padding(3, 2, 3, 2);
            pnlTabRepeatpass.Name = "pnlTabRepeatpass";
            pnlTabRepeatpass.RowCount = 2;
            pnlTabRepeatpass.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlTabRepeatpass.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlTabRepeatpass.Size = new Size(534, 68);
            pnlTabRepeatpass.TabIndex = 4;
            // 
            // txtPasswordRepeat
            // 
            txtPasswordRepeat.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordRepeat.Dock = DockStyle.Fill;
            txtPasswordRepeat.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPasswordRepeat.Location = new Point(56, 22);
            txtPasswordRepeat.Margin = new Padding(3, 2, 3, 2);
            txtPasswordRepeat.Multiline = true;
            txtPasswordRepeat.Name = "txtPasswordRepeat";
            txtPasswordRepeat.PasswordChar = '*';
            txtPasswordRepeat.Size = new Size(421, 44);
            txtPasswordRepeat.TabIndex = 4;
            txtPasswordRepeat.TextAlign = HorizontalAlignment.Center;
            txtPasswordRepeat.KeyDown += LoginEnter_KeyDown;
            // 
            // lblPasswordRepeat
            // 
            lblPasswordRepeat.AutoSize = true;
            lblPasswordRepeat.Dock = DockStyle.Fill;
            lblPasswordRepeat.Font = new Font("Rockwell", 14.25F);
            lblPasswordRepeat.ForeColor = SystemColors.ButtonFace;
            lblPasswordRepeat.Location = new Point(57, 0);
            lblPasswordRepeat.Margin = new Padding(4, 0, 4, 0);
            lblPasswordRepeat.Name = "lblPasswordRepeat";
            lblPasswordRepeat.Size = new Size(419, 20);
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
            lblName.Size = new Size(528, 51);
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
            lblRegisterTitle.Location = new Point(3, 51);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new Size(528, 51);
            lblRegisterTitle.TabIndex = 1;
            lblRegisterTitle.Text = "Account aanmaken";
            lblRegisterTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginTitel2
            // 
            pnlLoginTitel2.ColumnCount = 1;
            pnlLoginTitel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginTitel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            pnlLoginTitel2.Controls.Add(lblName, 0, 0);
            pnlLoginTitel2.Controls.Add(lblRegisterTitle, 0, 1);
            pnlLoginTitel2.Dock = DockStyle.Fill;
            pnlLoginTitel2.Location = new Point(3, 2);
            pnlLoginTitel2.Margin = new Padding(3, 2, 3, 2);
            pnlLoginTitel2.Name = "pnlLoginTitel2";
            pnlLoginTitel2.RowCount = 2;
            pnlLoginTitel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlLoginTitel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlLoginTitel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            pnlLoginTitel2.Size = new Size(534, 102);
            pnlLoginTitel2.TabIndex = 0;
            // 
            // pnlLoginTitel1
            // 
            pnlLoginTitel1.BackColor = Color.FromArgb(113, 0, 1);
            pnlLoginTitel1.ColumnCount = 1;
            pnlLoginTitel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginTitel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            pnlLoginTitel1.Controls.Add(pnlLoginTitel2, 0, 0);
            pnlLoginTitel1.Dock = DockStyle.Fill;
            pnlLoginTitel1.Location = new Point(4, 3);
            pnlLoginTitel1.Margin = new Padding(3, 2, 3, 2);
            pnlLoginTitel1.Name = "pnlLoginTitel1";
            pnlLoginTitel1.RowCount = 1;
            pnlLoginTitel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlLoginTitel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            pnlLoginTitel1.Size = new Size(540, 106);
            pnlLoginTitel1.TabIndex = 0;
            // 
            // pnlLoginSecundary
            // 
            pnlLoginSecundary.BackColor = SystemColors.ButtonHighlight;
            pnlLoginSecundary.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            pnlLoginSecundary.ColumnCount = 1;
            pnlLoginSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlLoginSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            pnlLoginSecundary.Controls.Add(pnlLoginTitel1, 0, 0);
            pnlLoginSecundary.Controls.Add(pnlLoginInfo, 0, 1);
            pnlLoginSecundary.Dock = DockStyle.Fill;
            pnlLoginSecundary.Location = new Point(557, 88);
            pnlLoginSecundary.Margin = new Padding(3, 2, 3, 2);
            pnlLoginSecundary.Name = "pnlLoginSecundary";
            pnlLoginSecundary.RowCount = 2;
            pnlLoginSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 17.86834F));
            pnlLoginSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 82.13166F));
            pnlLoginSecundary.Size = new Size(548, 621);
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
            pnlLoginMain.Margin = new Padding(3, 2, 3, 2);
            pnlLoginMain.Name = "pnlLoginMain";
            pnlLoginMain.RowCount = 3;
            pnlLoginMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.93901F));
            pnlLoginMain.RowStyles.Add(new RowStyle(SizeType.Percent, 78.99323F));
            pnlLoginMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            pnlLoginMain.Size = new Size(1663, 791);
            pnlLoginMain.TabIndex = 4;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 791);
            Controls.Add(pnlLoginMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmRegister";
            Text = "frmRegister";
            pnlButton.ResumeLayout(false);
            pnlWachtwoord.ResumeLayout(false);
            pnlWachtwoord.PerformLayout();
            pnlLoginInfo.ResumeLayout(false);
            pnlLoginInfo.PerformLayout();
            pnlTabusername.ResumeLayout(false);
            pnlTabusername.PerformLayout();
            pnlTabLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictLogo).EndInit();
            pnlTabMail.ResumeLayout(false);
            pnlTabMail.PerformLayout();
            pnlTabRepeatpass.ResumeLayout(false);
            pnlTabRepeatpass.PerformLayout();
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
        private TableLayoutPanel pnlTabusername;
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
        private TableLayoutPanel pnlTabRepeatpass;
        private TextBox txtPasswordRepeat;
        private Label lblPasswordRepeat;
        private Label lblPassword;
        private Button btnBackToLogin;
    }
}