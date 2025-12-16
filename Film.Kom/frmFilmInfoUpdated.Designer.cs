namespace Film.Kom
{
    partial class frmFilmInfoUpdated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmInfoUpdated));
            pnlMain = new TableLayoutPanel();
            pnlSecond = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            pnlLogo = new TableLayoutPanel();
            pnlButtons = new TableLayoutPanel();
            pnlMaininfo = new TableLayoutPanel();
            picPoster = new PictureBox();
            pnlSecondinfo = new TableLayoutPanel();
            pnlTabReservering = new TableLayoutPanel();
            btnReservering = new Button();
            lblRating = new Label();
            lblPlot = new Label();
            picLogo = new PictureBox();
            btnLogin = new Button();
            pnlMain.SuspendLayout();
            pnlSecond.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlMaininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            pnlSecondinfo.SuspendLayout();
            pnlTabReservering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.ColumnCount = 1;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlMain.Controls.Add(pnlSecond, 0, 0);
            pnlMain.Controls.Add(pnlMaininfo, 0, 1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 2;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6234388F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 88.376564F));
            pnlMain.Size = new Size(1904, 1041);
            pnlMain.TabIndex = 0;
            // 
            // pnlSecond
            // 
            pnlSecond.BackColor = Color.Black;
            pnlSecond.ColumnCount = 3;
            pnlSecond.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlSecond.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlSecond.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlSecond.Controls.Add(tableLayoutPanel1, 1, 0);
            pnlSecond.Controls.Add(pnlLogo, 0, 0);
            pnlSecond.Controls.Add(pnlButtons, 2, 0);
            pnlSecond.Dock = DockStyle.Fill;
            pnlSecond.Location = new Point(3, 3);
            pnlSecond.Name = "pnlSecond";
            pnlSecond.RowCount = 1;
            pnlSecond.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlSecond.Size = new Size(1898, 115);
            pnlSecond.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(382, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1132, 109);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Georgia", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1126, 109);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titel film";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            pnlLogo.ColumnCount = 2;
            pnlLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlLogo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlLogo.Controls.Add(picLogo, 0, 0);
            pnlLogo.Dock = DockStyle.Fill;
            pnlLogo.Location = new Point(3, 3);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.RowCount = 1;
            pnlLogo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlLogo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlLogo.Size = new Size(373, 109);
            pnlLogo.TabIndex = 3;
            // 
            // pnlButtons
            // 
            pnlButtons.ColumnCount = 3;
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            pnlButtons.Controls.Add(btnLogin, 2, 0);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(1520, 3);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.RowCount = 1;
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlButtons.Size = new Size(375, 109);
            pnlButtons.TabIndex = 4;
            // 
            // pnlMaininfo
            // 
            pnlMaininfo.ColumnCount = 2;
            pnlMaininfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.61749F));
            pnlMaininfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.3825073F));
            pnlMaininfo.Controls.Add(picPoster, 0, 0);
            pnlMaininfo.Controls.Add(pnlSecondinfo, 1, 0);
            pnlMaininfo.Dock = DockStyle.Fill;
            pnlMaininfo.Location = new Point(3, 124);
            pnlMaininfo.Name = "pnlMaininfo";
            pnlMaininfo.RowCount = 1;
            pnlMaininfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMaininfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlMaininfo.Size = new Size(1898, 914);
            pnlMaininfo.TabIndex = 1;
            // 
            // picPoster
            // 
            picPoster.Dock = DockStyle.Fill;
            picPoster.Image = (Image)resources.GetObject("picPoster.Image");
            picPoster.Location = new Point(3, 3);
            picPoster.Name = "picPoster";
            picPoster.Size = new Size(688, 908);
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            picPoster.TabIndex = 0;
            picPoster.TabStop = false;
            // 
            // pnlSecondinfo
            // 
            pnlSecondinfo.BackColor = Color.DarkRed;
            pnlSecondinfo.ColumnCount = 1;
            pnlSecondinfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSecondinfo.Controls.Add(pnlTabReservering, 0, 2);
            pnlSecondinfo.Controls.Add(lblRating, 0, 1);
            pnlSecondinfo.Controls.Add(lblPlot, 0, 0);
            pnlSecondinfo.Dock = DockStyle.Fill;
            pnlSecondinfo.Location = new Point(697, 3);
            pnlSecondinfo.Name = "pnlSecondinfo";
            pnlSecondinfo.RowCount = 3;
            pnlSecondinfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSecondinfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSecondinfo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            pnlSecondinfo.Size = new Size(1198, 908);
            pnlSecondinfo.TabIndex = 1;
            // 
            // pnlTabReservering
            // 
            pnlTabReservering.ColumnCount = 3;
            pnlTabReservering.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.55705F));
            pnlTabReservering.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.05369F));
            pnlTabReservering.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabReservering.Controls.Add(btnReservering, 1, 1);
            pnlTabReservering.Dock = DockStyle.Fill;
            pnlTabReservering.Location = new Point(3, 606);
            pnlTabReservering.Margin = new Padding(3, 2, 3, 2);
            pnlTabReservering.Name = "pnlTabReservering";
            pnlTabReservering.RowCount = 2;
            pnlTabReservering.RowStyles.Add(new RowStyle(SizeType.Percent, 73.3333359F));
            pnlTabReservering.RowStyles.Add(new RowStyle(SizeType.Percent, 26.666666F));
            pnlTabReservering.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            pnlTabReservering.Size = new Size(1192, 300);
            pnlTabReservering.TabIndex = 5;
            // 
            // btnReservering
            // 
            btnReservering.BackColor = Color.Maroon;
            btnReservering.Dock = DockStyle.Fill;
            btnReservering.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            btnReservering.ForeColor = SystemColors.Control;
            btnReservering.Location = new Point(403, 222);
            btnReservering.Margin = new Padding(3, 2, 3, 2);
            btnReservering.Name = "btnReservering";
            btnReservering.Size = new Size(388, 76);
            btnReservering.TabIndex = 3;
            btnReservering.Text = "Reserveer";
            btnReservering.UseVisualStyleBackColor = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Dock = DockStyle.Fill;
            lblRating.Font = new Font("Georgia", 14.25F, FontStyle.Bold);
            lblRating.ForeColor = SystemColors.Control;
            lblRating.Location = new Point(3, 302);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(1192, 302);
            lblRating.TabIndex = 2;
            lblRating.Text = "Rating";
            lblRating.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlot
            // 
            lblPlot.AutoSize = true;
            lblPlot.Dock = DockStyle.Fill;
            lblPlot.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlot.ForeColor = SystemColors.Control;
            lblPlot.Location = new Point(3, 0);
            lblPlot.Name = "lblPlot";
            lblPlot.Size = new Size(1192, 302);
            lblPlot.TabIndex = 1;
            lblPlot.Text = "Plot";
            lblPlot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.Logo_van_Rick_oftewel_ChatGPT;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(180, 105);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Location = new Point(251, 2);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 105);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // frmFilmInfoUpdated
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pnlMain);
            Name = "frmFilmInfoUpdated";
            Text = "frmFilmInfoUpdated";
            pnlMain.ResumeLayout(false);
            pnlSecond.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlMaininfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            pnlSecondinfo.ResumeLayout(false);
            pnlSecondinfo.PerformLayout();
            pnlTabReservering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlMain;
        private TableLayoutPanel pnlSecond;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private TableLayoutPanel pnlLogo;
        private TableLayoutPanel pnlButtons;
        private TableLayoutPanel pnlMaininfo;
        private PictureBox picPoster;
        private TableLayoutPanel pnlSecondinfo;
        private Label lblPlot;
        private Label lblRating;
        private TableLayoutPanel pnlTabReservering;
        private Button btnReservering;
        private PictureBox picLogo;
        private Button btnLogin;
    }
}