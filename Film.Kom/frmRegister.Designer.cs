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
            pnlTabRegister = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            picLogo = new PictureBox();
            pnlTabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlTabRegister
            // 
            pnlTabRegister.ColumnCount = 2;
            pnlTabRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabRegister.Controls.Add(label2, 0, 1);
            pnlTabRegister.Controls.Add(label3, 0, 2);
            pnlTabRegister.Controls.Add(label4, 0, 3);
            pnlTabRegister.Controls.Add(label1, 0, 4);
            pnlTabRegister.Controls.Add(picLogo, 0, 0);
            pnlTabRegister.Dock = DockStyle.Fill;
            pnlTabRegister.Location = new Point(0, 0);
            pnlTabRegister.Name = "pnlTabRegister";
            pnlTabRegister.RowCount = 6;
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4144144F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1171169F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1171169F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1171169F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1171169F));
            pnlTabRegister.RowStyles.Add(new RowStyle(SizeType.Percent, 17.1171169F));
            pnlTabRegister.Size = new Size(1130, 507);
            pnlTabRegister.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 159);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 245);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 331);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(559, 67);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 507);
            Controls.Add(pnlTabRegister);
            Name = "frmRegister";
            Text = "frmRegister";
            pnlTabRegister.ResumeLayout(false);
            pnlTabRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabRegister;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private PictureBox picLogo;
    }
}