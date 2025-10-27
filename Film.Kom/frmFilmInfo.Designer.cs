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
            pnlTabBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            pnlTabTextData.SuspendLayout();
            pnlTabText.SuspendLayout();
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
            lblPlot.Font = new Font("Georgia", 10F);
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
            btnReservering.BackColor = Color.DarkRed;
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
            // frmFilmInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 525);
            Controls.Add(pnlTabBackground);
            Name = "frmFilmInfo";
            Text = "frmFilmInfo";
            Load += frmFilmInfo_Load_1;
            pnlTabBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            pnlTabTextData.ResumeLayout(false);
            pnlTabText.ResumeLayout(false);
            pnlTabText.PerformLayout();
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
    }
}