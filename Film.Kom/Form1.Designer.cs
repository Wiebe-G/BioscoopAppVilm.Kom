namespace BetaalMethod
{
    partial class PnlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PnlForm));
            PnlForm2 = new Panel();
            TxtPas = new TextBox();
            label5 = new Label();
            button1 = new Button();
            BtnIndienen = new Button();
            PicPaypal = new PictureBox();
            PicMasterKaart = new PictureBox();
            PicVisa = new PictureBox();
            TxtVervaldatumYY = new TextBox();
            TxtVervaldatumMM = new TextBox();
            Txtkaarthouder = new TextBox();
            TxtCreditcard = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Lblhouder = new Label();
            PicChip = new PictureBox();
            PicMastercard = new PictureBox();
            LblCreditcard = new Label();
            label9 = new Label();
            LblVervaldatumMM = new Label();
            LblVervaldatumYY = new Label();
            LblNum4 = new Label();
            LblNum3 = new Label();
            LblNum2 = new Label();
            LblNum1 = new Label();
            label1 = new Label();
            LblPas = new Label();
            label7 = new Label();
            panel2 = new Panel();
            PnlForm2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicPaypal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicMasterKaart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicVisa).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicChip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicMastercard).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PnlForm2
            // 
            PnlForm2.BackColor = Color.FromArgb(255, 128, 128);
            PnlForm2.Controls.Add(TxtPas);
            PnlForm2.Dock = DockStyle.Fill;
            PnlForm2.Location = new Point(5, 5);
            PnlForm2.Name = "PnlForm2";
            PnlForm2.Size = new Size(842, 601);
            PnlForm2.TabIndex = 0;
            PnlForm2.Click += PnlForm2_Click;
            PnlForm2.Paint += PnlForm2_Paint;
            PnlForm2.MouseDown += PnlForm2_MouseDown;
            PnlForm2.ParentChanged += PnlForm2_ParentChanged;
            // 
            // TxtPas
            // 
            TxtPas.BackColor = Color.FromArgb(64, 64, 64);
            TxtPas.BorderStyle = BorderStyle.FixedSingle;
            TxtPas.ForeColor = Color.White;
            TxtPas.Location = new Point(662, 450);
            TxtPas.Name = "TxtPas";
            TxtPas.Size = new Size(76, 33);
            TxtPas.TabIndex = 25;
            TxtPas.Text = "Pas nr.";
            TxtPas.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(265, 52);
            label5.Name = "label5";
            label5.Size = new Size(289, 35);
            label5.TabIndex = 31;
            label5.Text = "Payment / Betalen";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(110, 513);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(112, 45);
            button1.TabIndex = 30;
            button1.Text = "Cancel";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnIndienen
            // 
            BtnIndienen.BackColor = Color.DodgerBlue;
            BtnIndienen.FlatAppearance.BorderSize = 0;
            BtnIndienen.FlatStyle = FlatStyle.Popup;
            BtnIndienen.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnIndienen.Location = new Point(226, 513);
            BtnIndienen.Margin = new Padding(0);
            BtnIndienen.Name = "BtnIndienen";
            BtnIndienen.Size = new Size(517, 45);
            BtnIndienen.TabIndex = 29;
            BtnIndienen.Text = "INDIENEN";
            BtnIndienen.UseVisualStyleBackColor = false;
            // 
            // PicPaypal
            // 
            PicPaypal.Image = (Image)resources.GetObject("PicPaypal.Image");
            PicPaypal.Location = new Point(667, 401);
            PicPaypal.Margin = new Padding(0);
            PicPaypal.Name = "PicPaypal";
            PicPaypal.Size = new Size(72, 45);
            PicPaypal.SizeMode = PictureBoxSizeMode.StretchImage;
            PicPaypal.TabIndex = 28;
            PicPaypal.TabStop = false;
            // 
            // PicMasterKaart
            // 
            PicMasterKaart.Image = (Image)resources.GetObject("PicMasterKaart.Image");
            PicMasterKaart.Location = new Point(589, 401);
            PicMasterKaart.Margin = new Padding(0);
            PicMasterKaart.Name = "PicMasterKaart";
            PicMasterKaart.Size = new Size(72, 45);
            PicMasterKaart.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMasterKaart.TabIndex = 27;
            PicMasterKaart.TabStop = false;
            // 
            // PicVisa
            // 
            PicVisa.Image = (Image)resources.GetObject("PicVisa.Image");
            PicVisa.Location = new Point(511, 401);
            PicVisa.Margin = new Padding(0);
            PicVisa.Name = "PicVisa";
            PicVisa.Size = new Size(72, 45);
            PicVisa.SizeMode = PictureBoxSizeMode.StretchImage;
            PicVisa.TabIndex = 26;
            PicVisa.TabStop = false;
            // 
            // TxtVervaldatumYY
            // 
            TxtVervaldatumYY.BackColor = Color.FromArgb(64, 64, 64);
            TxtVervaldatumYY.BorderStyle = BorderStyle.FixedSingle;
            TxtVervaldatumYY.ForeColor = Color.White;
            TxtVervaldatumYY.Location = new Point(356, 455);
            TxtVervaldatumYY.Name = "TxtVervaldatumYY";
            TxtVervaldatumYY.Size = new Size(280, 33);
            TxtVervaldatumYY.TabIndex = 24;
            TxtVervaldatumYY.Text = "VERVALDATUM JJ";
            // 
            // TxtVervaldatumMM
            // 
            TxtVervaldatumMM.BackColor = Color.FromArgb(64, 64, 64);
            TxtVervaldatumMM.BorderStyle = BorderStyle.FixedSingle;
            TxtVervaldatumMM.ForeColor = Color.White;
            TxtVervaldatumMM.Location = new Point(109, 455);
            TxtVervaldatumMM.Name = "TxtVervaldatumMM";
            TxtVervaldatumMM.Size = new Size(228, 33);
            TxtVervaldatumMM.TabIndex = 23;
            TxtVervaldatumMM.Text = "VERVALDATUM MM";
            // 
            // Txtkaarthouder
            // 
            Txtkaarthouder.BackColor = Color.FromArgb(64, 64, 64);
            Txtkaarthouder.BorderStyle = BorderStyle.FixedSingle;
            Txtkaarthouder.ForeColor = Color.White;
            Txtkaarthouder.Location = new Point(110, 407);
            Txtkaarthouder.Name = "Txtkaarthouder";
            Txtkaarthouder.Size = new Size(387, 33);
            Txtkaarthouder.TabIndex = 22;
            Txtkaarthouder.Text = "KAARTHOUDER";
            // 
            // TxtCreditcard
            // 
            TxtCreditcard.BackColor = Color.FromArgb(64, 64, 64);
            TxtCreditcard.BorderStyle = BorderStyle.FixedSingle;
            TxtCreditcard.ForeColor = Color.White;
            TxtCreditcard.Location = new Point(109, 357);
            TxtCreditcard.Name = "TxtCreditcard";
            TxtCreditcard.Size = new Size(627, 33);
            TxtCreditcard.TabIndex = 21;
            TxtCreditcard.Text = "CREDIT-NUMMER";
            TxtCreditcard.TextChanged += TxtCreditcard_TextChanged_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Firebrick;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(Lblhouder);
            panel3.Controls.Add(PicChip);
            panel3.Controls.Add(PicMastercard);
            panel3.Controls.Add(LblCreditcard);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(LblVervaldatumMM);
            panel3.Controls.Add(LblVervaldatumYY);
            panel3.Controls.Add(LblNum4);
            panel3.Controls.Add(LblNum3);
            panel3.Controls.Add(LblNum2);
            panel3.Controls.Add(LblNum1);
            panel3.ForeColor = Color.DodgerBlue;
            panel3.Location = new Point(180, 107);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3);
            panel3.Size = new Size(347, 188);
            panel3.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 34);
            label6.Name = "label6";
            label6.Size = new Size(39, 16);
            label6.TabIndex = 19;
            label6.Text = "Credit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(248, 118);
            label4.Name = "label4";
            label4.Size = new Size(18, 22);
            label4.TabIndex = 20;
            label4.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(169, 119);
            label3.Name = "label3";
            label3.Size = new Size(18, 22);
            label3.TabIndex = 19;
            label3.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 118);
            label2.Name = "label2";
            label2.Size = new Size(18, 22);
            label2.TabIndex = 18;
            label2.Text = "-";
            // 
            // Lblhouder
            // 
            Lblhouder.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lblhouder.ForeColor = Color.White;
            Lblhouder.Location = new Point(14, 153);
            Lblhouder.Name = "Lblhouder";
            Lblhouder.Size = new Size(220, 22);
            Lblhouder.TabIndex = 12;
            Lblhouder.Text = "Naam";
            // 
            // PicChip
            // 
            PicChip.Image = (Image)resources.GetObject("PicChip.Image");
            PicChip.Location = new Point(18, 55);
            PicChip.Name = "PicChip";
            PicChip.Size = new Size(76, 50);
            PicChip.SizeMode = PictureBoxSizeMode.StretchImage;
            PicChip.TabIndex = 11;
            PicChip.TabStop = false;
            // 
            // PicMastercard
            // 
            PicMastercard.Image = (Image)resources.GetObject("PicMastercard.Image");
            PicMastercard.Location = new Point(249, 17);
            PicMastercard.Name = "PicMastercard";
            PicMastercard.Size = new Size(72, 45);
            PicMastercard.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMastercard.TabIndex = 10;
            PicMastercard.TabStop = false;
            PicMastercard.Click += PicMastercard_Click_1;
            // 
            // LblCreditcard
            // 
            LblCreditcard.AutoSize = true;
            LblCreditcard.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCreditcard.ForeColor = Color.White;
            LblCreditcard.Location = new Point(17, 17);
            LblCreditcard.Name = "LblCreditcard";
            LblCreditcard.Size = new Size(134, 21);
            LblCreditcard.TabIndex = 9;
            LblCreditcard.Text = "CREDIT-CARD";
            // 
            // label9
            // 
            label9.Font = new Font("Castellar", 15F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(269, 149);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(18, 26);
            label9.TabIndex = 8;
            label9.Text = "/";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblVervaldatumMM
            // 
            LblVervaldatumMM.Font = new Font("Castellar", 15F);
            LblVervaldatumMM.ForeColor = Color.White;
            LblVervaldatumMM.Location = new Point(281, 149);
            LblVervaldatumMM.Margin = new Padding(0);
            LblVervaldatumMM.Name = "LblVervaldatumMM";
            LblVervaldatumMM.Size = new Size(40, 26);
            LblVervaldatumMM.TabIndex = 7;
            LblVervaldatumMM.Text = "00";
            LblVervaldatumMM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblVervaldatumYY
            // 
            LblVervaldatumYY.Font = new Font("Castellar", 15F);
            LblVervaldatumYY.ForeColor = Color.White;
            LblVervaldatumYY.Location = new Point(237, 149);
            LblVervaldatumYY.Margin = new Padding(0);
            LblVervaldatumYY.Name = "LblVervaldatumYY";
            LblVervaldatumYY.Size = new Size(40, 26);
            LblVervaldatumYY.TabIndex = 6;
            LblVervaldatumYY.Text = "00";
            LblVervaldatumYY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNum4
            // 
            LblNum4.Font = new Font("Castellar", 15F);
            LblNum4.ForeColor = Color.White;
            LblNum4.Location = new Point(259, 117);
            LblNum4.Margin = new Padding(0);
            LblNum4.Name = "LblNum4";
            LblNum4.Size = new Size(70, 26);
            LblNum4.TabIndex = 5;
            LblNum4.Text = "0000";
            LblNum4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNum3
            // 
            LblNum3.Font = new Font("Castellar", 15F);
            LblNum3.ForeColor = Color.White;
            LblNum3.Location = new Point(184, 117);
            LblNum3.Margin = new Padding(0);
            LblNum3.Name = "LblNum3";
            LblNum3.Size = new Size(70, 26);
            LblNum3.TabIndex = 4;
            LblNum3.Text = "0000";
            LblNum3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNum2
            // 
            LblNum2.Font = new Font("Castellar", 15F);
            LblNum2.ForeColor = Color.White;
            LblNum2.Location = new Point(101, 117);
            LblNum2.Margin = new Padding(0);
            LblNum2.Name = "LblNum2";
            LblNum2.Size = new Size(70, 26);
            LblNum2.TabIndex = 3;
            LblNum2.Text = "0000";
            LblNum2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblNum1
            // 
            LblNum1.Font = new Font("Castellar", 15F);
            LblNum1.ForeColor = Color.White;
            LblNum1.Location = new Point(22, 117);
            LblNum1.Margin = new Padding(0);
            LblNum1.Name = "LblNum1";
            LblNum1.Size = new Size(70, 26);
            LblNum1.TabIndex = 2;
            LblNum1.Text = "0000";
            LblNum1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 31);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(350, 50);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // LblPas
            // 
            LblPas.Font = new Font("Castellar", 15F);
            LblPas.ForeColor = Color.White;
            LblPas.Location = new Point(252, 102);
            LblPas.Margin = new Padding(0);
            LblPas.Name = "LblPas";
            LblPas.Size = new Size(70, 26);
            LblPas.TabIndex = 1;
            LblPas.Text = "0000";
            LblPas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 154);
            label7.Name = "label7";
            label7.Size = new Size(192, 22);
            label7.TabIndex = 2;
            label7.Text = "**** - **** - **** - ****";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(LblPas);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(300, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 188);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // PnlForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(852, 611);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(BtnIndienen);
            Controls.Add(PicPaypal);
            Controls.Add(PicMasterKaart);
            Controls.Add(PicVisa);
            Controls.Add(TxtVervaldatumYY);
            Controls.Add(TxtVervaldatumMM);
            Controls.Add(Txtkaarthouder);
            Controls.Add(TxtCreditcard);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(PnlForm2);
            Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PnlForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            PnlForm2.ResumeLayout(false);
            PnlForm2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicPaypal).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicMasterKaart).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicVisa).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicChip).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicMastercard).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlForm2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnIndienen;
        private System.Windows.Forms.PictureBox PicPaypal;
        private System.Windows.Forms.PictureBox PicMasterKaart;
        private System.Windows.Forms.PictureBox PicVisa;
        private System.Windows.Forms.TextBox TxtPas;
        private System.Windows.Forms.TextBox TxtVervaldatumYY;
        private System.Windows.Forms.TextBox TxtVervaldatumMM;
        private System.Windows.Forms.TextBox Txtkaarthouder;
        private System.Windows.Forms.TextBox TxtCreditcard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lblhouder;
        private System.Windows.Forms.PictureBox PicChip;
        private System.Windows.Forms.PictureBox PicMastercard;
        private System.Windows.Forms.Label LblCreditcard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblVervaldatumMM;
        private System.Windows.Forms.Label LblVervaldatumYY;
        private System.Windows.Forms.Label LblNum4;
        private System.Windows.Forms.Label LblNum3;
        private System.Windows.Forms.Label LblNum2;
        private System.Windows.Forms.Label LblNum1;
        private Label label1;
        private Label LblPas;
        private Label label7;
        private Panel panel2;
    }
}

