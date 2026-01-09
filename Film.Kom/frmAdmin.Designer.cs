namespace Film.Kom
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            pnlTabAdmin = new TableLayoutPanel();
            pnlTabTop = new TableLayoutPanel();
            picLogo = new PictureBox();
            lblPanelTitleDisplay = new Label();
            btnBackToProfile = new Button();
            tabForAdminPanel = new TabControl();
            tabAddingFilms = new TabPage();
            pnlTabForAddingFilms = new TableLayoutPanel();
            pnlTabForCenteringInputForAddingFilms = new TableLayoutPanel();
            txtInputForAddingFilms = new TextBox();
            pnlTabForCenteringButtonForAddingFilm = new TableLayoutPanel();
            btnAddFilmToDatabase = new Button();
            pnlTabInfoForAddingMovie = new TableLayoutPanel();
            picFilmPoster = new PictureBox();
            pnlTabAllFilmInfo = new TableLayoutPanel();
            lblFilmRuntime = new Label();
            lblFilmGenre = new Label();
            lblFilmPlot = new Label();
            lblFilmRated = new Label();
            lblFilmTitle = new Label();
            txtFilmPlaytime = new TextBox();
            txtFilmRoom = new TextBox();
            tabEditFilms = new TabPage();
            pnlTabFilms = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            picPoster = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtZoek = new TextBox();
            btnZoek = new Button();
            pnlFilmInfo = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtNieuweTitel = new RichTextBox();
            txtNieuweZaal = new RichTextBox();
            lblHuidigeZaal = new Label();
            txtNieuweSpeeltijd = new RichTextBox();
            lblHuidigeSpeeltijd = new Label();
            txtNieuwePlot = new RichTextBox();
            lblHuidigePlot = new Label();
            txtNieuweGenre = new RichTextBox();
            lblHuidigeGenre = new Label();
            txtNieuweRuntime = new RichTextBox();
            lblHuidigeRuntime = new Label();
            lblHuidigeTitel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnGereed = new Button();
            richTextBox1 = new RichTextBox();
            tabEditUsers = new TabPage();
            pnlTabUsers = new TableLayoutPanel();
            tabShowOrders = new TabPage();
            pnlTabOrders = new TableLayoutPanel();
            pnlTabAdmin.SuspendLayout();
            pnlTabTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tabForAdminPanel.SuspendLayout();
            tabAddingFilms.SuspendLayout();
            pnlTabForAddingFilms.SuspendLayout();
            pnlTabForCenteringInputForAddingFilms.SuspendLayout();
            pnlTabForCenteringButtonForAddingFilm.SuspendLayout();
            pnlTabInfoForAddingMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilmPoster).BeginInit();
            pnlTabAllFilmInfo.SuspendLayout();
            tabEditFilms.SuspendLayout();
            pnlTabFilms.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPoster).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            pnlFilmInfo.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabEditUsers.SuspendLayout();
            tabShowOrders.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTabAdmin
            // 
            pnlTabAdmin.BackColor = Color.DarkRed;
            pnlTabAdmin.ColumnCount = 1;
            pnlTabAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabAdmin.Controls.Add(pnlTabTop, 0, 0);
            pnlTabAdmin.Controls.Add(tabForAdminPanel, 0, 1);
            pnlTabAdmin.Dock = DockStyle.Fill;
            pnlTabAdmin.Location = new Point(0, 0);
            pnlTabAdmin.Margin = new Padding(3, 2, 3, 2);
            pnlTabAdmin.Name = "pnlTabAdmin";
            pnlTabAdmin.RowCount = 2;
            pnlTabAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            pnlTabAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 83F));
            pnlTabAdmin.Size = new Size(1664, 775);
            pnlTabAdmin.TabIndex = 0;
            // 
            // pnlTabTop
            // 
            pnlTabTop.BackColor = SystemColors.ActiveCaptionText;
            pnlTabTop.ColumnCount = 3;
            pnlTabTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabTop.Controls.Add(picLogo, 0, 0);
            pnlTabTop.Controls.Add(lblPanelTitleDisplay, 1, 0);
            pnlTabTop.Controls.Add(btnBackToProfile, 2, 0);
            pnlTabTop.Dock = DockStyle.Fill;
            pnlTabTop.Location = new Point(3, 2);
            pnlTabTop.Margin = new Padding(3, 2, 3, 2);
            pnlTabTop.Name = "pnlTabTop";
            pnlTabTop.RowCount = 1;
            pnlTabTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabTop.Size = new Size(1658, 127);
            pnlTabTop.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.Logo_van_Rick_oftewel_ChatGPT;
            picLogo.Location = new Point(3, 2);
            picLogo.Margin = new Padding(3, 2, 3, 2);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(491, 123);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblPanelTitleDisplay
            // 
            lblPanelTitleDisplay.AutoSize = true;
            lblPanelTitleDisplay.BackColor = Color.Gainsboro;
            lblPanelTitleDisplay.Dock = DockStyle.Fill;
            lblPanelTitleDisplay.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPanelTitleDisplay.Location = new Point(515, 15);
            lblPanelTitleDisplay.Margin = new Padding(18, 15, 18, 15);
            lblPanelTitleDisplay.Name = "lblPanelTitleDisplay";
            lblPanelTitleDisplay.Size = new Size(627, 97);
            lblPanelTitleDisplay.TabIndex = 1;
            lblPanelTitleDisplay.Text = "Admin";
            lblPanelTitleDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBackToProfile
            // 
            btnBackToProfile.BackColor = Color.Gainsboro;
            btnBackToProfile.Dock = DockStyle.Fill;
            btnBackToProfile.Location = new Point(1178, 15);
            btnBackToProfile.Margin = new Padding(18, 15, 18, 15);
            btnBackToProfile.Name = "btnBackToProfile";
            btnBackToProfile.Size = new Size(462, 97);
            btnBackToProfile.TabIndex = 2;
            btnBackToProfile.Text = "Terug naar profiel";
            btnBackToProfile.UseVisualStyleBackColor = false;
            btnBackToProfile.Click += btnBackToProfile_Click;
            // 
            // tabForAdminPanel
            // 
            tabForAdminPanel.Controls.Add(tabAddingFilms);
            tabForAdminPanel.Controls.Add(tabEditFilms);
            tabForAdminPanel.Controls.Add(tabEditUsers);
            tabForAdminPanel.Controls.Add(tabShowOrders);
            tabForAdminPanel.Dock = DockStyle.Fill;
            tabForAdminPanel.Location = new Point(3, 133);
            tabForAdminPanel.Margin = new Padding(3, 2, 3, 2);
            tabForAdminPanel.Name = "tabForAdminPanel";
            tabForAdminPanel.SelectedIndex = 0;
            tabForAdminPanel.Size = new Size(1658, 640);
            tabForAdminPanel.TabIndex = 1;
            // 
            // tabAddingFilms
            // 
            tabAddingFilms.BackColor = Color.DarkRed;
            tabAddingFilms.Controls.Add(pnlTabForAddingFilms);
            tabAddingFilms.Location = new Point(4, 24);
            tabAddingFilms.Margin = new Padding(3, 2, 3, 2);
            tabAddingFilms.Name = "tabAddingFilms";
            tabAddingFilms.Padding = new Padding(3, 2, 3, 2);
            tabAddingFilms.Size = new Size(1650, 612);
            tabAddingFilms.TabIndex = 0;
            tabAddingFilms.Text = "Films toevoegen";
            // 
            // pnlTabForAddingFilms
            // 
            pnlTabForAddingFilms.ColumnCount = 1;
            pnlTabForAddingFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabForAddingFilms.Controls.Add(pnlTabForCenteringInputForAddingFilms, 0, 0);
            pnlTabForAddingFilms.Controls.Add(pnlTabForCenteringButtonForAddingFilm, 0, 2);
            pnlTabForAddingFilms.Controls.Add(pnlTabInfoForAddingMovie, 0, 1);
            pnlTabForAddingFilms.Dock = DockStyle.Fill;
            pnlTabForAddingFilms.Location = new Point(3, 2);
            pnlTabForAddingFilms.Margin = new Padding(3, 2, 3, 2);
            pnlTabForAddingFilms.Name = "pnlTabForAddingFilms";
            pnlTabForAddingFilms.RowCount = 3;
            pnlTabForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlTabForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabForAddingFilms.Size = new Size(1644, 608);
            pnlTabForAddingFilms.TabIndex = 0;
            // 
            // pnlTabForCenteringInputForAddingFilms
            // 
            pnlTabForCenteringInputForAddingFilms.AutoScroll = true;
            pnlTabForCenteringInputForAddingFilms.ColumnCount = 3;
            pnlTabForCenteringInputForAddingFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabForCenteringInputForAddingFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabForCenteringInputForAddingFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabForCenteringInputForAddingFilms.Controls.Add(txtInputForAddingFilms, 1, 0);
            pnlTabForCenteringInputForAddingFilms.Dock = DockStyle.Fill;
            pnlTabForCenteringInputForAddingFilms.Location = new Point(3, 2);
            pnlTabForCenteringInputForAddingFilms.Margin = new Padding(3, 2, 3, 2);
            pnlTabForCenteringInputForAddingFilms.Name = "pnlTabForCenteringInputForAddingFilms";
            pnlTabForCenteringInputForAddingFilms.RowCount = 1;
            pnlTabForCenteringInputForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabForCenteringInputForAddingFilms.Size = new Size(1638, 87);
            pnlTabForCenteringInputForAddingFilms.TabIndex = 0;
            // 
            // txtInputForAddingFilms
            // 
            txtInputForAddingFilms.Dock = DockStyle.Fill;
            txtInputForAddingFilms.Location = new Point(494, 2);
            txtInputForAddingFilms.Margin = new Padding(3, 2, 3, 2);
            txtInputForAddingFilms.Multiline = true;
            txtInputForAddingFilms.Name = "txtInputForAddingFilms";
            txtInputForAddingFilms.PlaceholderText = "Zoek naar een film";
            txtInputForAddingFilms.Size = new Size(649, 83);
            txtInputForAddingFilms.TabIndex = 0;
            txtInputForAddingFilms.TextAlign = HorizontalAlignment.Center;
            txtInputForAddingFilms.KeyDown += BtnSearch_Keydown;
            // 
            // pnlTabForCenteringButtonForAddingFilm
            // 
            pnlTabForCenteringButtonForAddingFilm.ColumnCount = 3;
            pnlTabForCenteringButtonForAddingFilm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabForCenteringButtonForAddingFilm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTabForCenteringButtonForAddingFilm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabForCenteringButtonForAddingFilm.Controls.Add(btnAddFilmToDatabase, 1, 0);
            pnlTabForCenteringButtonForAddingFilm.Dock = DockStyle.Fill;
            pnlTabForCenteringButtonForAddingFilm.Location = new Point(3, 518);
            pnlTabForCenteringButtonForAddingFilm.Margin = new Padding(3, 2, 3, 2);
            pnlTabForCenteringButtonForAddingFilm.Name = "pnlTabForCenteringButtonForAddingFilm";
            pnlTabForCenteringButtonForAddingFilm.RowCount = 1;
            pnlTabForCenteringButtonForAddingFilm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabForCenteringButtonForAddingFilm.Size = new Size(1638, 88);
            pnlTabForCenteringButtonForAddingFilm.TabIndex = 1;
            // 
            // btnAddFilmToDatabase
            // 
            btnAddFilmToDatabase.Dock = DockStyle.Fill;
            btnAddFilmToDatabase.Location = new Point(494, 2);
            btnAddFilmToDatabase.Margin = new Padding(3, 2, 3, 2);
            btnAddFilmToDatabase.Name = "btnAddFilmToDatabase";
            btnAddFilmToDatabase.Size = new Size(649, 84);
            btnAddFilmToDatabase.TabIndex = 0;
            btnAddFilmToDatabase.Text = "Bevestig en voeg toe aan database";
            btnAddFilmToDatabase.UseVisualStyleBackColor = true;
            btnAddFilmToDatabase.Click += btnAddFilmToDatabase_Click;
            // 
            // pnlTabInfoForAddingMovie
            // 
            pnlTabInfoForAddingMovie.ColumnCount = 4;
            pnlTabInfoForAddingMovie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            pnlTabInfoForAddingMovie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlTabInfoForAddingMovie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            pnlTabInfoForAddingMovie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            pnlTabInfoForAddingMovie.Controls.Add(picFilmPoster, 1, 0);
            pnlTabInfoForAddingMovie.Controls.Add(pnlTabAllFilmInfo, 2, 0);
            pnlTabInfoForAddingMovie.Dock = DockStyle.Fill;
            pnlTabInfoForAddingMovie.Location = new Point(3, 93);
            pnlTabInfoForAddingMovie.Margin = new Padding(3, 2, 3, 2);
            pnlTabInfoForAddingMovie.Name = "pnlTabInfoForAddingMovie";
            pnlTabInfoForAddingMovie.RowCount = 1;
            pnlTabInfoForAddingMovie.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabInfoForAddingMovie.Size = new Size(1638, 421);
            pnlTabInfoForAddingMovie.TabIndex = 2;
            // 
            // picFilmPoster
            // 
            picFilmPoster.Dock = DockStyle.Fill;
            picFilmPoster.Image = (Image)resources.GetObject("picFilmPoster.Image");
            picFilmPoster.Location = new Point(84, 2);
            picFilmPoster.Margin = new Padding(3, 2, 3, 2);
            picFilmPoster.Name = "picFilmPoster";
            picFilmPoster.Size = new Size(485, 417);
            picFilmPoster.SizeMode = PictureBoxSizeMode.Zoom;
            picFilmPoster.TabIndex = 0;
            picFilmPoster.TabStop = false;
            // 
            // pnlTabAllFilmInfo
            // 
            pnlTabAllFilmInfo.ColumnCount = 2;
            pnlTabAllFilmInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAllFilmInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlTabAllFilmInfo.Controls.Add(lblFilmRuntime, 0, 1);
            pnlTabAllFilmInfo.Controls.Add(lblFilmGenre, 0, 2);
            pnlTabAllFilmInfo.Controls.Add(lblFilmPlot, 0, 3);
            pnlTabAllFilmInfo.Controls.Add(lblFilmRated, 1, 0);
            pnlTabAllFilmInfo.Controls.Add(lblFilmTitle, 0, 0);
            pnlTabAllFilmInfo.Controls.Add(txtFilmPlaytime, 1, 1);
            pnlTabAllFilmInfo.Controls.Add(txtFilmRoom, 1, 2);
            pnlTabAllFilmInfo.Dock = DockStyle.Fill;
            pnlTabAllFilmInfo.Location = new Point(575, 2);
            pnlTabAllFilmInfo.Margin = new Padding(3, 2, 3, 2);
            pnlTabAllFilmInfo.Name = "pnlTabAllFilmInfo";
            pnlTabAllFilmInfo.RowCount = 4;
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.Size = new Size(976, 417);
            pnlTabAllFilmInfo.TabIndex = 1;
            // 
            // lblFilmRuntime
            // 
            lblFilmRuntime.AutoSize = true;
            lblFilmRuntime.BackColor = Color.Gainsboro;
            lblFilmRuntime.Dock = DockStyle.Fill;
            lblFilmRuntime.ForeColor = SystemColors.ControlText;
            lblFilmRuntime.Location = new Point(9, 112);
            lblFilmRuntime.Margin = new Padding(9, 8, 9, 8);
            lblFilmRuntime.Name = "lblFilmRuntime";
            lblFilmRuntime.Size = new Size(470, 88);
            lblFilmRuntime.TabIndex = 1;
            lblFilmRuntime.Text = "Runtime";
            lblFilmRuntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmGenre
            // 
            lblFilmGenre.AutoSize = true;
            lblFilmGenre.BackColor = Color.Gainsboro;
            lblFilmGenre.Dock = DockStyle.Fill;
            lblFilmGenre.Location = new Point(9, 216);
            lblFilmGenre.Margin = new Padding(9, 8, 9, 8);
            lblFilmGenre.Name = "lblFilmGenre";
            lblFilmGenre.Size = new Size(470, 88);
            lblFilmGenre.TabIndex = 2;
            lblFilmGenre.Text = "Genre";
            lblFilmGenre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmPlot
            // 
            lblFilmPlot.AutoSize = true;
            lblFilmPlot.BackColor = Color.Gainsboro;
            lblFilmPlot.Dock = DockStyle.Fill;
            lblFilmPlot.Location = new Point(9, 320);
            lblFilmPlot.Margin = new Padding(9, 8, 9, 8);
            lblFilmPlot.Name = "lblFilmPlot";
            lblFilmPlot.Size = new Size(470, 89);
            lblFilmPlot.TabIndex = 3;
            lblFilmPlot.Text = "Plot";
            lblFilmPlot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmRated
            // 
            lblFilmRated.AutoSize = true;
            lblFilmRated.BackColor = Color.Gainsboro;
            lblFilmRated.Dock = DockStyle.Fill;
            lblFilmRated.Location = new Point(497, 8);
            lblFilmRated.Margin = new Padding(9, 8, 9, 8);
            lblFilmRated.Name = "lblFilmRated";
            lblFilmRated.Size = new Size(470, 88);
            lblFilmRated.TabIndex = 4;
            lblFilmRated.Text = "Rated";
            lblFilmRated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmTitle
            // 
            lblFilmTitle.AutoSize = true;
            lblFilmTitle.BackColor = Color.Gainsboro;
            lblFilmTitle.Dock = DockStyle.Fill;
            lblFilmTitle.Location = new Point(9, 8);
            lblFilmTitle.Margin = new Padding(9, 8, 9, 8);
            lblFilmTitle.Name = "lblFilmTitle";
            lblFilmTitle.Padding = new Padding(9, 8, 9, 8);
            lblFilmTitle.Size = new Size(470, 88);
            lblFilmTitle.TabIndex = 0;
            lblFilmTitle.Text = "Film Titel";
            lblFilmTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFilmPlaytime
            // 
            txtFilmPlaytime.BackColor = Color.Gainsboro;
            txtFilmPlaytime.Dock = DockStyle.Fill;
            txtFilmPlaytime.Location = new Point(497, 112);
            txtFilmPlaytime.Margin = new Padding(9, 8, 9, 8);
            txtFilmPlaytime.Multiline = true;
            txtFilmPlaytime.Name = "txtFilmPlaytime";
            txtFilmPlaytime.PlaceholderText = "Speeltijd";
            txtFilmPlaytime.Size = new Size(470, 88);
            txtFilmPlaytime.TabIndex = 5;
            txtFilmPlaytime.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilmRoom
            // 
            txtFilmRoom.BackColor = Color.Gainsboro;
            txtFilmRoom.Dock = DockStyle.Fill;
            txtFilmRoom.Location = new Point(497, 216);
            txtFilmRoom.Margin = new Padding(9, 8, 9, 8);
            txtFilmRoom.Multiline = true;
            txtFilmRoom.Name = "txtFilmRoom";
            txtFilmRoom.PlaceholderText = "Zaal";
            txtFilmRoom.Size = new Size(470, 88);
            txtFilmRoom.TabIndex = 6;
            txtFilmRoom.TextAlign = HorizontalAlignment.Center;
            // 
            // tabEditFilms
            // 
            tabEditFilms.BackColor = Color.DarkRed;
            tabEditFilms.Controls.Add(pnlTabFilms);
            tabEditFilms.Location = new Point(4, 24);
            tabEditFilms.Margin = new Padding(3, 2, 3, 2);
            tabEditFilms.Name = "tabEditFilms";
            tabEditFilms.Padding = new Padding(3, 2, 3, 2);
            tabEditFilms.Size = new Size(1650, 612);
            tabEditFilms.TabIndex = 1;
            tabEditFilms.Text = "Films bewerken";
            // 
            // pnlTabFilms
            // 
            pnlTabFilms.ColumnCount = 2;
            pnlTabFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5328465F));
            pnlTabFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.4671555F));
            pnlTabFilms.Controls.Add(tableLayoutPanel1, 0, 0);
            pnlTabFilms.Controls.Add(pnlFilmInfo, 1, 0);
            pnlTabFilms.Dock = DockStyle.Fill;
            pnlTabFilms.Location = new Point(3, 2);
            pnlTabFilms.Margin = new Padding(3, 2, 3, 2);
            pnlTabFilms.Name = "pnlTabFilms";
            pnlTabFilms.RowCount = 1;
            pnlTabFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabFilms.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabFilms.Size = new Size(1644, 608);
            pnlTabFilms.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(picPoster, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.112957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.88705F));
            tableLayoutPanel1.Size = new Size(348, 602);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // picPoster
            // 
            picPoster.Dock = DockStyle.Fill;
            picPoster.Location = new Point(3, 100);
            picPoster.Name = "picPoster";
            picPoster.Size = new Size(342, 499);
            picPoster.SizeMode = PictureBoxSizeMode.CenterImage;
            picPoster.TabIndex = 0;
            picPoster.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.77778F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel2.Controls.Add(txtZoek, 0, 0);
            tableLayoutPanel2.Controls.Add(btnZoek, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(342, 91);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // txtZoek
            // 
            txtZoek.Dock = DockStyle.Fill;
            txtZoek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtZoek.Location = new Point(3, 3);
            txtZoek.Multiline = true;
            txtZoek.Name = "txtZoek";
            txtZoek.Size = new Size(260, 85);
            txtZoek.TabIndex = 0;
            txtZoek.Text = "Welke film wil je bewerken?";
            // 
            // btnZoek
            // 
            btnZoek.Dock = DockStyle.Fill;
            btnZoek.Location = new Point(269, 3);
            btnZoek.Name = "btnZoek";
            btnZoek.Size = new Size(70, 85);
            btnZoek.TabIndex = 1;
            btnZoek.Text = "Zoek";
            btnZoek.UseVisualStyleBackColor = true;
            btnZoek.Click += btnZoek_Click;
            // 
            // pnlFilmInfo
            // 
            pnlFilmInfo.ColumnCount = 2;
            pnlFilmInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.6324F));
            pnlFilmInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3676014F));
            pnlFilmInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            pnlFilmInfo.Controls.Add(tableLayoutPanel3, 0, 0);
            pnlFilmInfo.Controls.Add(tableLayoutPanel4, 1, 0);
            pnlFilmInfo.Dock = DockStyle.Fill;
            pnlFilmInfo.Location = new Point(357, 3);
            pnlFilmInfo.Name = "pnlFilmInfo";
            pnlFilmInfo.RowCount = 1;
            pnlFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlFilmInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlFilmInfo.Size = new Size(1284, 602);
            pnlFilmInfo.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txtNieuweTitel, 1, 0);
            tableLayoutPanel3.Controls.Add(txtNieuweZaal, 1, 5);
            tableLayoutPanel3.Controls.Add(lblHuidigeZaal, 0, 5);
            tableLayoutPanel3.Controls.Add(txtNieuweSpeeltijd, 1, 4);
            tableLayoutPanel3.Controls.Add(lblHuidigeSpeeltijd, 0, 4);
            tableLayoutPanel3.Controls.Add(txtNieuwePlot, 1, 3);
            tableLayoutPanel3.Controls.Add(lblHuidigePlot, 0, 3);
            tableLayoutPanel3.Controls.Add(txtNieuweGenre, 1, 2);
            tableLayoutPanel3.Controls.Add(lblHuidigeGenre, 0, 2);
            tableLayoutPanel3.Controls.Add(txtNieuweRuntime, 1, 1);
            tableLayoutPanel3.Controls.Add(lblHuidigeRuntime, 0, 1);
            tableLayoutPanel3.Controls.Add(lblHuidigeTitel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666622F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666737F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1055, 596);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtNieuweTitel
            // 
            txtNieuweTitel.Dock = DockStyle.Fill;
            txtNieuweTitel.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNieuweTitel.Location = new Point(530, 3);
            txtNieuweTitel.Name = "txtNieuweTitel";
            txtNieuweTitel.Size = new Size(522, 93);
            txtNieuweTitel.TabIndex = 14;
            txtNieuweTitel.Text = "";
            // 
            // txtNieuweZaal
            // 
            txtNieuweZaal.Dock = DockStyle.Fill;
            txtNieuweZaal.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNieuweZaal.Location = new Point(530, 498);
            txtNieuweZaal.Name = "txtNieuweZaal";
            txtNieuweZaal.Size = new Size(522, 95);
            txtNieuweZaal.TabIndex = 13;
            txtNieuweZaal.Text = "";
            // 
            // lblHuidigeZaal
            // 
            lblHuidigeZaal.AutoSize = true;
            lblHuidigeZaal.BackColor = Color.White;
            lblHuidigeZaal.Dock = DockStyle.Fill;
            lblHuidigeZaal.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHuidigeZaal.Location = new Point(3, 495);
            lblHuidigeZaal.Name = "lblHuidigeZaal";
            lblHuidigeZaal.Size = new Size(521, 101);
            lblHuidigeZaal.TabIndex = 12;
            lblHuidigeZaal.Text = "Huidige Zaal";
            lblHuidigeZaal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNieuweSpeeltijd
            // 
            txtNieuweSpeeltijd.Dock = DockStyle.Fill;
            txtNieuweSpeeltijd.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNieuweSpeeltijd.Location = new Point(530, 399);
            txtNieuweSpeeltijd.Name = "txtNieuweSpeeltijd";
            txtNieuweSpeeltijd.Size = new Size(522, 93);
            txtNieuweSpeeltijd.TabIndex = 11;
            txtNieuweSpeeltijd.Text = "";
            // 
            // lblHuidigeSpeeltijd
            // 
            lblHuidigeSpeeltijd.AutoSize = true;
            lblHuidigeSpeeltijd.BackColor = Color.White;
            lblHuidigeSpeeltijd.Dock = DockStyle.Fill;
            lblHuidigeSpeeltijd.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHuidigeSpeeltijd.Location = new Point(3, 396);
            lblHuidigeSpeeltijd.Name = "lblHuidigeSpeeltijd";
            lblHuidigeSpeeltijd.Size = new Size(521, 99);
            lblHuidigeSpeeltijd.TabIndex = 10;
            lblHuidigeSpeeltijd.Text = "Huidige Speeltijd";
            lblHuidigeSpeeltijd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNieuwePlot
            // 
            txtNieuwePlot.Dock = DockStyle.Fill;
            txtNieuwePlot.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNieuwePlot.Location = new Point(530, 300);
            txtNieuwePlot.Name = "txtNieuwePlot";
            txtNieuwePlot.Size = new Size(522, 93);
            txtNieuwePlot.TabIndex = 7;
            txtNieuwePlot.Text = "";
            // 
            // lblHuidigePlot
            // 
            lblHuidigePlot.AutoSize = true;
            lblHuidigePlot.BackColor = Color.White;
            lblHuidigePlot.Dock = DockStyle.Fill;
            lblHuidigePlot.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHuidigePlot.Location = new Point(3, 297);
            lblHuidigePlot.Name = "lblHuidigePlot";
            lblHuidigePlot.Size = new Size(521, 99);
            lblHuidigePlot.TabIndex = 6;
            lblHuidigePlot.Text = "Huidige Plot";
            lblHuidigePlot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNieuweGenre
            // 
            txtNieuweGenre.Dock = DockStyle.Fill;
            txtNieuweGenre.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNieuweGenre.Location = new Point(530, 201);
            txtNieuweGenre.Name = "txtNieuweGenre";
            txtNieuweGenre.Size = new Size(522, 93);
            txtNieuweGenre.TabIndex = 5;
            txtNieuweGenre.Text = "";
            // 
            // lblHuidigeGenre
            // 
            lblHuidigeGenre.AutoSize = true;
            lblHuidigeGenre.BackColor = Color.White;
            lblHuidigeGenre.Dock = DockStyle.Fill;
            lblHuidigeGenre.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHuidigeGenre.Location = new Point(3, 198);
            lblHuidigeGenre.Name = "lblHuidigeGenre";
            lblHuidigeGenre.Size = new Size(521, 99);
            lblHuidigeGenre.TabIndex = 4;
            lblHuidigeGenre.Text = "Huidige Genre";
            lblHuidigeGenre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNieuweRuntime
            // 
            txtNieuweRuntime.Dock = DockStyle.Fill;
            txtNieuweRuntime.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNieuweRuntime.Location = new Point(530, 102);
            txtNieuweRuntime.Name = "txtNieuweRuntime";
            txtNieuweRuntime.Size = new Size(522, 93);
            txtNieuweRuntime.TabIndex = 3;
            txtNieuweRuntime.Text = "";
            // 
            // lblHuidigeRuntime
            // 
            lblHuidigeRuntime.AutoSize = true;
            lblHuidigeRuntime.BackColor = Color.White;
            lblHuidigeRuntime.Dock = DockStyle.Fill;
            lblHuidigeRuntime.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHuidigeRuntime.Location = new Point(3, 99);
            lblHuidigeRuntime.Name = "lblHuidigeRuntime";
            lblHuidigeRuntime.Size = new Size(521, 99);
            lblHuidigeRuntime.TabIndex = 2;
            lblHuidigeRuntime.Text = "Huidige Runtime";
            lblHuidigeRuntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHuidigeTitel
            // 
            lblHuidigeTitel.AutoSize = true;
            lblHuidigeTitel.BackColor = Color.White;
            lblHuidigeTitel.Dock = DockStyle.Fill;
            lblHuidigeTitel.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHuidigeTitel.Location = new Point(3, 0);
            lblHuidigeTitel.Name = "lblHuidigeTitel";
            lblHuidigeTitel.Size = new Size(521, 99);
            lblHuidigeTitel.TabIndex = 0;
            lblHuidigeTitel.Text = "Huidige Titel";
            lblHuidigeTitel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6067419F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.9063644F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.8614235F));
            tableLayoutPanel4.Controls.Add(btnGereed, 1, 3);
            tableLayoutPanel4.Controls.Add(richTextBox1, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel4.Location = new Point(1064, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15.9395971F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 24.1610737F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.90604F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5167789F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 21.3087254F));
            tableLayoutPanel4.Size = new Size(217, 596);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btnGereed
            // 
            btnGereed.BackColor = Color.LightGray;
            btnGereed.Dock = DockStyle.Fill;
            btnGereed.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGereed.Location = new Point(34, 307);
            btnGereed.Name = "btnGereed";
            btnGereed.Size = new Size(155, 158);
            btnGereed.TabIndex = 0;
            btnGereed.Text = "Gereed";
            btnGereed.UseVisualStyleBackColor = false;
            btnGereed.Click += btnGereed_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.LightGray;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(34, 98);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(155, 138);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Door op \"Gereed\" te klikken word in 1 keer alles bijgewerkt in de database. Ook de lege velden, dus vul altijd wat in. ";
            // 
            // tabEditUsers
            // 
            tabEditUsers.BackColor = Color.Maroon;
            tabEditUsers.Controls.Add(pnlTabUsers);
            tabEditUsers.Location = new Point(4, 24);
            tabEditUsers.Margin = new Padding(3, 2, 3, 2);
            tabEditUsers.Name = "tabEditUsers";
            tabEditUsers.Padding = new Padding(3, 2, 3, 2);
            tabEditUsers.Size = new Size(1650, 612);
            tabEditUsers.TabIndex = 2;
            tabEditUsers.Text = "Gebruikers bewerken";
            // 
            // pnlTabUsers
            // 
            pnlTabUsers.AutoScroll = true;
            pnlTabUsers.AutoSize = true;
            pnlTabUsers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTabUsers.BackColor = Color.DarkRed;
            pnlTabUsers.ColumnCount = 2;
            pnlTabUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlTabUsers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabUsers.Dock = DockStyle.Fill;
            pnlTabUsers.Location = new Point(3, 2);
            pnlTabUsers.Margin = new Padding(3, 2, 3, 2);
            pnlTabUsers.Name = "pnlTabUsers";
            pnlTabUsers.RowCount = 2;
            pnlTabUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabUsers.Size = new Size(1644, 608);
            pnlTabUsers.TabIndex = 0;
            // 
            // tabShowOrders
            // 
            tabShowOrders.BackColor = Color.DarkRed;
            tabShowOrders.Controls.Add(pnlTabOrders);
            tabShowOrders.Location = new Point(4, 24);
            tabShowOrders.Margin = new Padding(3, 2, 3, 2);
            tabShowOrders.Name = "tabShowOrders";
            tabShowOrders.Padding = new Padding(3, 2, 3, 2);
            tabShowOrders.Size = new Size(1650, 612);
            tabShowOrders.TabIndex = 3;
            tabShowOrders.Text = "Reserveringen zien";
            // 
            // pnlTabOrders
            // 
            pnlTabOrders.ColumnCount = 1;
            pnlTabOrders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabOrders.Dock = DockStyle.Fill;
            pnlTabOrders.Location = new Point(3, 2);
            pnlTabOrders.Margin = new Padding(3, 2, 3, 2);
            pnlTabOrders.Name = "pnlTabOrders";
            pnlTabOrders.RowCount = 2;
            pnlTabOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabOrders.Size = new Size(1644, 608);
            pnlTabOrders.TabIndex = 0;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(pnlTabAdmin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdmin";
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            pnlTabAdmin.ResumeLayout(false);
            pnlTabTop.ResumeLayout(false);
            pnlTabTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tabForAdminPanel.ResumeLayout(false);
            tabAddingFilms.ResumeLayout(false);
            pnlTabForAddingFilms.ResumeLayout(false);
            pnlTabForCenteringInputForAddingFilms.ResumeLayout(false);
            pnlTabForCenteringInputForAddingFilms.PerformLayout();
            pnlTabForCenteringButtonForAddingFilm.ResumeLayout(false);
            pnlTabInfoForAddingMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFilmPoster).EndInit();
            pnlTabAllFilmInfo.ResumeLayout(false);
            pnlTabAllFilmInfo.PerformLayout();
            tabEditFilms.ResumeLayout(false);
            pnlTabFilms.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPoster).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnlFilmInfo.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tabEditUsers.ResumeLayout(false);
            tabEditUsers.PerformLayout();
            tabShowOrders.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlTabAdmin;
        private TableLayoutPanel pnlTabTop;
        private PictureBox picLogo;
        private Label lblPanelTitleDisplay;
        private Button btnBackToProfile;
        private TabControl tabForAdminPanel;
        private TabPage tabAddingFilms;
        private TabPage tabEditFilms;
        private TableLayoutPanel pnlTabForAddingFilms;
        private TableLayoutPanel pnlTabForCenteringInputForAddingFilms;
        private TextBox txtInputForAddingFilms;
        private TableLayoutPanel pnlTabForCenteringButtonForAddingFilm;
        private Button btnAddFilmToDatabase;
        private TableLayoutPanel pnlTabInfoForAddingMovie;
        private PictureBox picFilmPoster;
        private TableLayoutPanel pnlTabAllFilmInfo;
        private Label lblFilmRuntime;
        private Label lblFilmGenre;
        private Label lblFilmPlot;
        private Label lblFilmRated;
        private Label lblFilmTitle;
        private TextBox txtFilmPlaytime;
        private TextBox txtFilmRoom;
        private TabPage tabEditUsers;
        private TableLayoutPanel pnlTabUsers;
        private TableLayoutPanel pnlTabFilms;
        private TabPage tabShowOrders;
        private TableLayoutPanel pnlTabOrders;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox picPoster;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtZoek;
        private Button btnZoek;
        private TableLayoutPanel pnlFilmInfo;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnGereed;
        private Label lblHuidigeTitel;
        private RichTextBox richTextBox1;
        private RichTextBox txtNieuwePlot;
        private Label lblHuidigePlot;
        private RichTextBox txtNieuweGenre;
        private Label lblHuidigeGenre;
        private RichTextBox txtNieuweRuntime;
        private Label lblHuidigeRuntime;
        private RichTextBox txtNieuweZaal;
        private Label lblHuidigeZaal;
        private RichTextBox txtNieuweSpeeltijd;
        private Label lblHuidigeSpeeltijd;
        private RichTextBox txtNieuweTitel;
    }
}