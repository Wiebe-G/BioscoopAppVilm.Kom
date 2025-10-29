namespace Film.Kom
{
    partial class frmPayment
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
            pnlTabPaymentBG = new TableLayoutPanel();
            pnlTabPaymentInfo = new TableLayoutPanel();
            lblFilmLeft = new Label();
            lblRoomLeft = new Label();
            lblSeatLeft = new Label();
            lblPriceLeft = new Label();
            lblFilmInfo = new Label();
            lblRoomInfo = new Label();
            lblSeatInfo = new Label();
            lblPriceInfo = new Label();
            pnlTabPaymentBG.SuspendLayout();
            pnlTabPaymentInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabPaymentBG
            // 
            pnlTabPaymentBG.BackColor = Color.DarkRed;
            pnlTabPaymentBG.ColumnCount = 2;
            pnlTabPaymentBG.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            pnlTabPaymentBG.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pnlTabPaymentBG.Controls.Add(pnlTabPaymentInfo, 1, 0);
            pnlTabPaymentBG.Dock = DockStyle.Fill;
            pnlTabPaymentBG.Location = new Point(0, 0);
            pnlTabPaymentBG.Name = "pnlTabPaymentBG";
            pnlTabPaymentBG.RowCount = 1;
            pnlTabPaymentBG.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabPaymentBG.Size = new Size(1191, 513);
            pnlTabPaymentBG.TabIndex = 0;
            // 
            // pnlTabPaymentInfo
            // 
            pnlTabPaymentInfo.ColumnCount = 2;
            pnlTabPaymentInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabPaymentInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabPaymentInfo.Controls.Add(lblFilmLeft, 0, 0);
            pnlTabPaymentInfo.Controls.Add(lblRoomLeft, 0, 1);
            pnlTabPaymentInfo.Controls.Add(lblSeatLeft, 0, 2);
            pnlTabPaymentInfo.Controls.Add(lblPriceLeft, 0, 3);
            pnlTabPaymentInfo.Controls.Add(lblFilmInfo, 1, 0);
            pnlTabPaymentInfo.Controls.Add(lblRoomInfo, 1, 1);
            pnlTabPaymentInfo.Controls.Add(lblSeatInfo, 1, 2);
            pnlTabPaymentInfo.Controls.Add(lblPriceInfo, 1, 3);
            pnlTabPaymentInfo.Dock = DockStyle.Fill;
            pnlTabPaymentInfo.Location = new Point(797, 3);
            pnlTabPaymentInfo.Name = "pnlTabPaymentInfo";
            pnlTabPaymentInfo.RowCount = 4;
            pnlTabPaymentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabPaymentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabPaymentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabPaymentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabPaymentInfo.Size = new Size(391, 507);
            pnlTabPaymentInfo.TabIndex = 0;
            // 
            // lblFilmLeft
            // 
            lblFilmLeft.AutoSize = true;
            lblFilmLeft.Dock = DockStyle.Fill;
            lblFilmLeft.Location = new Point(3, 0);
            lblFilmLeft.Name = "lblFilmLeft";
            lblFilmLeft.Size = new Size(189, 126);
            lblFilmLeft.TabIndex = 0;
            lblFilmLeft.Text = "Film:";
            lblFilmLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoomLeft
            // 
            lblRoomLeft.AutoSize = true;
            lblRoomLeft.Dock = DockStyle.Fill;
            lblRoomLeft.Location = new Point(3, 126);
            lblRoomLeft.Name = "lblRoomLeft";
            lblRoomLeft.Size = new Size(189, 126);
            lblRoomLeft.TabIndex = 1;
            lblRoomLeft.Text = "Zaal:";
            lblRoomLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatLeft
            // 
            lblSeatLeft.AutoSize = true;
            lblSeatLeft.Dock = DockStyle.Fill;
            lblSeatLeft.Location = new Point(3, 252);
            lblSeatLeft.Name = "lblSeatLeft";
            lblSeatLeft.Size = new Size(189, 126);
            lblSeatLeft.TabIndex = 2;
            lblSeatLeft.Text = "Stoel:";
            lblSeatLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPriceLeft
            // 
            lblPriceLeft.AutoSize = true;
            lblPriceLeft.Dock = DockStyle.Fill;
            lblPriceLeft.Location = new Point(3, 378);
            lblPriceLeft.Name = "lblPriceLeft";
            lblPriceLeft.Size = new Size(189, 129);
            lblPriceLeft.TabIndex = 3;
            lblPriceLeft.Text = "Prijs:";
            lblPriceLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmInfo
            // 
            lblFilmInfo.AutoSize = true;
            lblFilmInfo.Dock = DockStyle.Fill;
            lblFilmInfo.Location = new Point(198, 0);
            lblFilmInfo.Name = "lblFilmInfo";
            lblFilmInfo.Size = new Size(190, 126);
            lblFilmInfo.TabIndex = 4;
            lblFilmInfo.Text = "Placehouder 1";
            lblFilmInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoomInfo
            // 
            lblRoomInfo.AutoSize = true;
            lblRoomInfo.Dock = DockStyle.Fill;
            lblRoomInfo.Location = new Point(198, 126);
            lblRoomInfo.Name = "lblRoomInfo";
            lblRoomInfo.Size = new Size(190, 126);
            lblRoomInfo.TabIndex = 5;
            lblRoomInfo.Text = "Placehouder zaal";
            lblRoomInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSeatInfo
            // 
            lblSeatInfo.AutoSize = true;
            lblSeatInfo.Dock = DockStyle.Fill;
            lblSeatInfo.Location = new Point(198, 252);
            lblSeatInfo.Name = "lblSeatInfo";
            lblSeatInfo.Size = new Size(190, 126);
            lblSeatInfo.TabIndex = 6;
            lblSeatInfo.Text = "Stoel placeholder";
            lblSeatInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPriceInfo
            // 
            lblPriceInfo.AutoSize = true;
            lblPriceInfo.Dock = DockStyle.Fill;
            lblPriceInfo.Location = new Point(198, 378);
            lblPriceInfo.Name = "lblPriceInfo";
            lblPriceInfo.Size = new Size(190, 129);
            lblPriceInfo.TabIndex = 7;
            lblPriceInfo.Text = "Prijs placeholder";
            lblPriceInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 513);
            Controls.Add(pnlTabPaymentBG);
            Name = "frmPayment";
            Text = "frmPayment";
            pnlTabPaymentBG.ResumeLayout(false);
            pnlTabPaymentInfo.ResumeLayout(false);
            pnlTabPaymentInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabPaymentBG;
        private TableLayoutPanel pnlTabPaymentInfo;
        private Label lblFilmLeft;
        private Label lblRoomLeft;
        private Label lblSeatLeft;
        private Label lblPriceLeft;
        private Label lblFilmInfo;
        private Label lblRoomInfo;
        private Label lblSeatInfo;
        private Label lblPriceInfo;
    }
}