namespace Stoelen_Vilm.kom
{
    partial class frmStoelen_reservation
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoelen_reservation));
            pnlMain = new TableLayoutPanel();
            pnlPosterSpecifications = new TableLayoutPanel();
            picPoster = new PictureBox();
            tblInfo = new TableLayoutPanel();
            lblEindtijd = new Label();
            lblBegintijd = new Label();
            lblSpeelduur = new Label();
            lblZaal = new Label();
            lblNameEindtijd = new Label();
            lblNameBegintijd = new Label();
            lblNameSpeelduur = new Label();
            lblNameZaal = new Label();
            lblNameTitel = new Label();
            lblNameLocatie = new Label();
            lblTitel = new Label();
            lblLocatie = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            picLogo = new PictureBox();
            pnlSecundary = new TableLayoutPanel();
            pnlScreenChairs = new TableLayoutPanel();
            picScreen = new PictureBox();
            tblStoelen = new TableLayoutPanel();
            lblRijB = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblRijA = new Label();
            lblRijC = new Label();
            lblRijD = new Label();
            lblRijE = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            errorProvider1 = new ErrorProvider(components);
            pnlMain.SuspendLayout();
            pnlPosterSpecifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            tblInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlSecundary.SuspendLayout();
            pnlScreenChairs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picScreen).BeginInit();
            tblStoelen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.ColumnCount = 2;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.01402F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.98598F));
            pnlMain.Controls.Add(pnlPosterSpecifications, 1, 1);
            pnlMain.Controls.Add(tableLayoutPanel1, 0, 0);
            pnlMain.Controls.Add(pnlSecundary, 0, 1);
            pnlMain.Controls.Add(tableLayoutPanel2, 1, 0);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 2;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.6422253F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 87.35777F));
            pnlMain.Size = new Size(1664, 791);
            pnlMain.TabIndex = 0;
            // 
            // pnlPosterSpecifications
            // 
            pnlPosterSpecifications.BackColor = Color.DarkRed;
            pnlPosterSpecifications.ColumnCount = 1;
            pnlPosterSpecifications.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlPosterSpecifications.Controls.Add(picPoster, 0, 0);
            pnlPosterSpecifications.Controls.Add(tblInfo, 0, 1);
            pnlPosterSpecifications.Dock = DockStyle.Fill;
            pnlPosterSpecifications.Location = new Point(1335, 103);
            pnlPosterSpecifications.Margin = new Padding(4, 3, 4, 3);
            pnlPosterSpecifications.Name = "pnlPosterSpecifications";
            pnlPosterSpecifications.RowCount = 2;
            pnlPosterSpecifications.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlPosterSpecifications.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlPosterSpecifications.Size = new Size(325, 685);
            pnlPosterSpecifications.TabIndex = 0;
            // 
            // picPoster
            // 
            picPoster.Dock = DockStyle.Fill;
            picPoster.Image = (Image)resources.GetObject("picPoster.Image");
            picPoster.Location = new Point(4, 3);
            picPoster.Margin = new Padding(4, 3, 4, 3);
            picPoster.Name = "picPoster";
            picPoster.Size = new Size(317, 336);
            picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            picPoster.TabIndex = 0;
            picPoster.TabStop = false;
            picPoster.Click += picPoster_Click;
            // 
            // tblInfo
            // 
            tblInfo.ColumnCount = 2;
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tblInfo.Controls.Add(lblEindtijd, 1, 5);
            tblInfo.Controls.Add(lblBegintijd, 1, 4);
            tblInfo.Controls.Add(lblSpeelduur, 1, 3);
            tblInfo.Controls.Add(lblZaal, 1, 2);
            tblInfo.Controls.Add(lblNameEindtijd, 0, 5);
            tblInfo.Controls.Add(lblNameBegintijd, 0, 4);
            tblInfo.Controls.Add(lblNameSpeelduur, 0, 3);
            tblInfo.Controls.Add(lblNameZaal, 0, 2);
            tblInfo.Controls.Add(lblNameTitel, 0, 0);
            tblInfo.Controls.Add(lblNameLocatie, 0, 1);
            tblInfo.Controls.Add(lblTitel, 1, 0);
            tblInfo.Controls.Add(lblLocatie, 1, 1);
            tblInfo.Dock = DockStyle.Fill;
            tblInfo.Location = new Point(3, 344);
            tblInfo.Margin = new Padding(3, 2, 3, 2);
            tblInfo.Name = "tblInfo";
            tblInfo.RowCount = 6;
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblInfo.Size = new Size(319, 339);
            tblInfo.TabIndex = 1;
            // 
            // lblEindtijd
            // 
            lblEindtijd.AutoSize = true;
            lblEindtijd.BackColor = Color.Black;
            lblEindtijd.Dock = DockStyle.Fill;
            lblEindtijd.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEindtijd.ForeColor = SystemColors.ButtonHighlight;
            lblEindtijd.Location = new Point(162, 280);
            lblEindtijd.Name = "lblEindtijd";
            lblEindtijd.Size = new Size(154, 59);
            lblEindtijd.TabIndex = 11;
            lblEindtijd.Text = "(Eindtijd)";
            lblEindtijd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBegintijd
            // 
            lblBegintijd.AutoSize = true;
            lblBegintijd.BackColor = Color.Black;
            lblBegintijd.Dock = DockStyle.Fill;
            lblBegintijd.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBegintijd.ForeColor = SystemColors.ButtonHighlight;
            lblBegintijd.Location = new Point(162, 224);
            lblBegintijd.Name = "lblBegintijd";
            lblBegintijd.Size = new Size(154, 56);
            lblBegintijd.TabIndex = 10;
            lblBegintijd.Text = "(Begintijd)";
            lblBegintijd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSpeelduur
            // 
            lblSpeelduur.AutoSize = true;
            lblSpeelduur.BackColor = Color.Black;
            lblSpeelduur.Dock = DockStyle.Fill;
            lblSpeelduur.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpeelduur.ForeColor = SystemColors.ButtonHighlight;
            lblSpeelduur.Location = new Point(162, 168);
            lblSpeelduur.Name = "lblSpeelduur";
            lblSpeelduur.Size = new Size(154, 56);
            lblSpeelduur.TabIndex = 9;
            lblSpeelduur.Text = "(Speelduur)";
            lblSpeelduur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZaal
            // 
            lblZaal.AutoSize = true;
            lblZaal.BackColor = Color.Black;
            lblZaal.Dock = DockStyle.Fill;
            lblZaal.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZaal.ForeColor = SystemColors.ButtonHighlight;
            lblZaal.Location = new Point(162, 112);
            lblZaal.Name = "lblZaal";
            lblZaal.Size = new Size(154, 56);
            lblZaal.TabIndex = 8;
            lblZaal.Text = "(Zaal)";
            lblZaal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNameEindtijd
            // 
            lblNameEindtijd.AutoSize = true;
            lblNameEindtijd.Dock = DockStyle.Fill;
            lblNameEindtijd.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameEindtijd.Location = new Point(3, 280);
            lblNameEindtijd.Name = "lblNameEindtijd";
            lblNameEindtijd.Size = new Size(153, 59);
            lblNameEindtijd.TabIndex = 3;
            lblNameEindtijd.Text = "Eindtijd :";
            lblNameEindtijd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameBegintijd
            // 
            lblNameBegintijd.AutoSize = true;
            lblNameBegintijd.Dock = DockStyle.Fill;
            lblNameBegintijd.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameBegintijd.Location = new Point(3, 224);
            lblNameBegintijd.Name = "lblNameBegintijd";
            lblNameBegintijd.Size = new Size(153, 56);
            lblNameBegintijd.TabIndex = 4;
            lblNameBegintijd.Text = "Begintijd :";
            lblNameBegintijd.TextAlign = ContentAlignment.MiddleLeft;
            lblNameBegintijd.Click += label5_Click;
            // 
            // lblNameSpeelduur
            // 
            lblNameSpeelduur.AutoSize = true;
            lblNameSpeelduur.Dock = DockStyle.Fill;
            lblNameSpeelduur.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameSpeelduur.Location = new Point(3, 168);
            lblNameSpeelduur.Name = "lblNameSpeelduur";
            lblNameSpeelduur.Size = new Size(153, 56);
            lblNameSpeelduur.TabIndex = 1;
            lblNameSpeelduur.Text = "Speelduur :";
            lblNameSpeelduur.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameZaal
            // 
            lblNameZaal.AutoSize = true;
            lblNameZaal.Dock = DockStyle.Fill;
            lblNameZaal.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameZaal.Location = new Point(3, 112);
            lblNameZaal.Name = "lblNameZaal";
            lblNameZaal.Size = new Size(153, 56);
            lblNameZaal.TabIndex = 5;
            lblNameZaal.Text = "Zaal :";
            lblNameZaal.TextAlign = ContentAlignment.MiddleLeft;
            lblNameZaal.Click += label6_Click;
            // 
            // lblNameTitel
            // 
            lblNameTitel.AutoSize = true;
            lblNameTitel.Dock = DockStyle.Fill;
            lblNameTitel.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameTitel.Location = new Point(3, 0);
            lblNameTitel.Name = "lblNameTitel";
            lblNameTitel.Size = new Size(153, 56);
            lblNameTitel.TabIndex = 2;
            lblNameTitel.Text = "Titel :";
            lblNameTitel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNameLocatie
            // 
            lblNameLocatie.AutoSize = true;
            lblNameLocatie.Dock = DockStyle.Fill;
            lblNameLocatie.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameLocatie.Location = new Point(3, 56);
            lblNameLocatie.Name = "lblNameLocatie";
            lblNameLocatie.Size = new Size(153, 56);
            lblNameLocatie.TabIndex = 0;
            lblNameLocatie.Text = "Locatie :";
            lblNameLocatie.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.BackColor = Color.Black;
            lblTitel.Dock = DockStyle.Fill;
            lblTitel.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.ForeColor = SystemColors.ButtonHighlight;
            lblTitel.Location = new Point(162, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(154, 56);
            lblTitel.TabIndex = 7;
            lblTitel.Text = "(Titel)";
            lblTitel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLocatie
            // 
            lblLocatie.AutoSize = true;
            lblLocatie.BackColor = Color.Black;
            lblLocatie.Dock = DockStyle.Fill;
            lblLocatie.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocatie.ForeColor = SystemColors.ButtonHighlight;
            lblLocatie.Location = new Point(162, 56);
            lblLocatie.Name = "lblLocatie";
            lblLocatie.Size = new Size(154, 56);
            lblLocatie.TabIndex = 6;
            lblLocatie.Text = "(Almelo)";
            lblLocatie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkRed;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.0482922F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.4581871F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2467613F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2467613F));
            tableLayoutPanel1.Controls.Add(picLogo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.Location = new Point(4, 3);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1323, 94);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.InitialImage = (Image)resources.GetObject("picLogo.InitialImage");
            picLogo.Location = new Point(4, 3);
            picLogo.Margin = new Padding(4, 3, 4, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(204, 88);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlSecundary
            // 
            pnlSecundary.ColumnCount = 2;
            pnlSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1140F));
            pnlSecundary.Controls.Add(pnlScreenChairs, 1, 0);
            pnlSecundary.Dock = DockStyle.Fill;
            pnlSecundary.Location = new Point(4, 103);
            pnlSecundary.Margin = new Padding(4, 3, 4, 3);
            pnlSecundary.Name = "pnlSecundary";
            pnlSecundary.RowCount = 1;
            pnlSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlSecundary.RowStyles.Add(new RowStyle(SizeType.Absolute, 689F));
            pnlSecundary.Size = new Size(1323, 685);
            pnlSecundary.TabIndex = 2;
            // 
            // pnlScreenChairs
            // 
            pnlScreenChairs.ColumnCount = 1;
            pnlScreenChairs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlScreenChairs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            pnlScreenChairs.Controls.Add(picScreen, 0, 0);
            pnlScreenChairs.Controls.Add(tblStoelen, 0, 1);
            pnlScreenChairs.Dock = DockStyle.Fill;
            pnlScreenChairs.Location = new Point(187, 3);
            pnlScreenChairs.Margin = new Padding(4, 3, 4, 3);
            pnlScreenChairs.Name = "pnlScreenChairs";
            pnlScreenChairs.RowCount = 2;
            pnlScreenChairs.RowStyles.Add(new RowStyle(SizeType.Percent, 12.68966F));
            pnlScreenChairs.RowStyles.Add(new RowStyle(SizeType.Percent, 87.31035F));
            pnlScreenChairs.Size = new Size(1132, 679);
            pnlScreenChairs.TabIndex = 1;
            // 
            // picScreen
            // 
            picScreen.Dock = DockStyle.Fill;
            picScreen.Image = (Image)resources.GetObject("picScreen.Image");
            picScreen.Location = new Point(4, 3);
            picScreen.Margin = new Padding(4, 3, 4, 3);
            picScreen.Name = "picScreen";
            picScreen.Size = new Size(1124, 80);
            picScreen.SizeMode = PictureBoxSizeMode.StretchImage;
            picScreen.TabIndex = 0;
            picScreen.TabStop = false;
            // 
            // tblStoelen
            // 
            tblStoelen.ColumnCount = 2;
            tblStoelen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.915307F));
            tblStoelen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.0846939F));
            tblStoelen.Controls.Add(lblRijB, 0, 2);
            tblStoelen.Controls.Add(tableLayoutPanel3, 1, 0);
            tblStoelen.Controls.Add(lblRijA, 0, 0);
            tblStoelen.Controls.Add(lblRijC, 0, 4);
            tblStoelen.Controls.Add(lblRijD, 0, 6);
            tblStoelen.Controls.Add(lblRijE, 0, 8);
            tblStoelen.Dock = DockStyle.Fill;
            tblStoelen.Location = new Point(3, 88);
            tblStoelen.Margin = new Padding(3, 2, 3, 2);
            tblStoelen.Name = "tblStoelen";
            tblStoelen.RowCount = 9;
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 17.391304F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 3.2608695F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 17.391304F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 3.2608695F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 17.391304F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 3.2608695F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 17.391304F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 3.2608695F));
            tblStoelen.RowStyles.Add(new RowStyle(SizeType.Percent, 17.391304F));
            tblStoelen.Size = new Size(1126, 589);
            tblStoelen.TabIndex = 1;
            // 
            // lblRijB
            // 
            lblRijB.AutoSize = true;
            lblRijB.Dock = DockStyle.Fill;
            lblRijB.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRijB.ForeColor = Color.White;
            lblRijB.Location = new Point(3, 121);
            lblRijB.Name = "lblRijB";
            lblRijB.Size = new Size(71, 102);
            lblRijB.TabIndex = 4;
            lblRijB.Text = "Rij B";
            lblRijB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(80, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(219, 94);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblRijA
            // 
            lblRijA.AutoSize = true;
            lblRijA.Dock = DockStyle.Fill;
            lblRijA.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRijA.ForeColor = Color.White;
            lblRijA.Location = new Point(3, 0);
            lblRijA.Name = "lblRijA";
            lblRijA.Size = new Size(71, 102);
            lblRijA.TabIndex = 1;
            lblRijA.Text = "Rij A";
            lblRijA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRijC
            // 
            lblRijC.AutoSize = true;
            lblRijC.Dock = DockStyle.Fill;
            lblRijC.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRijC.ForeColor = Color.White;
            lblRijC.Location = new Point(3, 242);
            lblRijC.Name = "lblRijC";
            lblRijC.Size = new Size(71, 102);
            lblRijC.TabIndex = 5;
            lblRijC.Text = "Rij C";
            lblRijC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRijD
            // 
            lblRijD.AutoSize = true;
            lblRijD.Dock = DockStyle.Fill;
            lblRijD.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRijD.ForeColor = Color.White;
            lblRijD.Location = new Point(3, 363);
            lblRijD.Name = "lblRijD";
            lblRijD.Size = new Size(71, 102);
            lblRijD.TabIndex = 2;
            lblRijD.Text = "Rij D";
            lblRijD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRijE
            // 
            lblRijE.AutoSize = true;
            lblRijE.Dock = DockStyle.Fill;
            lblRijE.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRijE.ForeColor = Color.White;
            lblRijE.Location = new Point(3, 484);
            lblRijE.Name = "lblRijE";
            lblRijE.Size = new Size(71, 105);
            lblRijE.TabIndex = 6;
            lblRijE.Text = "Rij E";
            lblRijE.TextAlign = ContentAlignment.MiddleCenter;
            lblRijE.Click += label4_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.DarkRed;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(1334, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(327, 96);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStoelen_reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1664, 791);
            Controls.Add(pnlMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmStoelen_reservation";
            Text = "Reserveren";
            pnlMain.ResumeLayout(false);
            pnlPosterSpecifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            tblInfo.ResumeLayout(false);
            tblInfo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlSecundary.ResumeLayout(false);
            pnlScreenChairs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picScreen).EndInit();
            tblStoelen.ResumeLayout(false);
            tblStoelen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlPosterSpecifications;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TableLayoutPanel pnlSecundary;
        private System.Windows.Forms.TableLayoutPanel pnlScreenChairs;
        private System.Windows.Forms.PictureBox picScreen;
        private TableLayoutPanel tblInfo;
        private ErrorProvider errorProvider1;
        private Label lblNameTitel;
        private Label lblNameLocatie;
        private Label lblNameSpeelduur;
        private Label lblNameEindtijd;
        private Label lblNameBegintijd;
        private Label lblNameZaal;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblEindtijd;
        private Label lblBegintijd;
        private Label lblSpeelduur;
        private Label lblZaal;
        private Label lblTitel;
        private Label lblLocatie;
        private TableLayoutPanel tblStoelen;
        private Label lblRijD;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblRijA;
        private Label lblRijE;
        private Label lblRijB;
        private Label lblRijC;
    }
}

