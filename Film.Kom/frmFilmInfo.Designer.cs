namespace Film.Kom
{
    partial class frmFilmInfo
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
            pnlTabBackground = new TableLayoutPanel();
            picPoster = new PictureBox();
            pnlTabTextData = new TableLayoutPanel();
            pnlTabText = new TableLayoutPanel();
            lblTitle = new Label();
            lblRating = new Label();
            lblPlot = new Label();
            btnReservering = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            label1 = new Label();
            pnlTabBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            pnlTabTextData.SuspendLayout();
            pnlTabText.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTabBackground
            // 
            pnlTabBackground.ColumnCount = 2;
            pnlTabBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            pnlTabBackground.Controls.Add(picPoster, 0, 0);
            pnlTabBackground.Controls.Add(pnlTabTextData, 1, 0);
            pnlTabBackground.Dock = DockStyle.Fill;
            pnlTabBackground.Location = new Point(0, 0);
            pnlTabBackground.Name = "pnlTabBackground";
            pnlTabBackground.RowCount = 1;
            pnlTabBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabBackground.Size = new Size(1285, 525);
            pnlTabBackground.TabIndex = 0;
            // 
            // picPoster
            // 
            picPoster.BackColor = Color.DarkRed;
            picPoster.Dock = DockStyle.Fill;
            picPoster.Location = new Point(3, 3);
            picPoster.Name = "picPoster";
            picPoster.Size = new Size(379, 519);
            picPoster.TabIndex = 0;
            picPoster.TabStop = false;
            // 
            // pnlTabTextData
            // 
            pnlTabTextData.BackColor = Color.DarkRed;
            pnlTabTextData.ColumnCount = 1;
            pnlTabTextData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabTextData.Controls.Add(pnlTabText, 0, 1);
            pnlTabTextData.Controls.Add(btnReservering, 0, 2);
            pnlTabTextData.Controls.Add(tableLayoutPanel1, 0, 0);
            pnlTabTextData.Dock = DockStyle.Fill;
            pnlTabTextData.Location = new Point(388, 3);
            pnlTabTextData.Name = "pnlTabTextData";
            pnlTabTextData.RowCount = 3;
            pnlTabTextData.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabTextData.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabTextData.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            pnlTabTextData.Size = new Size(894, 519);
            pnlTabTextData.TabIndex = 1;
            // 
            // pnlTabText
            // 
            pnlTabText.ColumnCount = 1;
            pnlTabText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabText.Controls.Add(lblTitle, 0, 0);
            pnlTabText.Controls.Add(lblRating, 0, 2);
            pnlTabText.Controls.Add(lblPlot, 0, 1);
            pnlTabText.Dock = DockStyle.Fill;
            pnlTabText.Location = new Point(3, 106);
            pnlTabText.Name = "pnlTabText";
            pnlTabText.RowCount = 3;
            pnlTabText.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            pnlTabText.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            pnlTabText.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            pnlTabText.Size = new Size(888, 253);
            pnlTabText.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.DarkRed;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(882, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titel van de film";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Dock = DockStyle.Fill;
            lblRating.Font = new Font("Georgia", 12F);
            lblRating.ForeColor = SystemColors.Control;
            lblRating.Location = new Point(3, 206);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(882, 47);
            lblRating.TabIndex = 1;
            lblRating.Text = "Rating";
            lblRating.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlot
            // 
            lblPlot.AutoSize = true;
            lblPlot.Dock = DockStyle.Fill;
            lblPlot.Font = new Font("Georgia", 12F);
            lblPlot.ForeColor = SystemColors.Control;
            lblPlot.Location = new Point(3, 45);
            lblPlot.Name = "lblPlot";
            lblPlot.Size = new Size(882, 161);
            lblPlot.TabIndex = 0;
            lblPlot.Text = "Plot";
            lblPlot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReservering
            // 
            btnReservering.BackColor = Color.Maroon;
            btnReservering.Dock = DockStyle.Fill;
            btnReservering.ForeColor = SystemColors.Control;
            btnReservering.Location = new Point(3, 365);
            btnReservering.Name = "btnReservering";
            btnReservering.Size = new Size(888, 151);
            btnReservering.TabIndex = 2;
            btnReservering.Text = "Reserveer";
            btnReservering.UseVisualStyleBackColor = false;
            btnReservering.Click += btnReservering_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLogin, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(888, 97);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Logo_van_Rick_oftewel_ChatGPT;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.Dock = DockStyle.Right;
            btnLogin.Location = new Point(716, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 91);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(298, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 97);
            label1.TabIndex = 2;
            label1.Text = "Reserveer voor\r\n↓\r\n";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // frmFilmInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 525);
            Controls.Add(pnlTabBackground);
            Name = "frmFilmInfo";
            Text = "frmFilmInfo";
            Load += frmFilmInfo_Load;
            pnlTabBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            pnlTabTextData.ResumeLayout(false);
            pnlTabText.ResumeLayout(false);
            pnlTabText.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabBackground;
        private PictureBox picPoster;
        private TableLayoutPanel pnlTabTextData;
        private Label lblTitle;
        private TableLayoutPanel pnlTabText;
        private Label lblPlot;
        private Label lblRating;
        private Button btnReservering;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label label1;
    }
}