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
            pnlTabAdmin.Name = "pnlTabAdmin";
            pnlTabAdmin.RowCount = 2;
            pnlTabAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 17F));
            pnlTabAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 83F));
            pnlTabAdmin.Size = new Size(1902, 1033);
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
            pnlTabTop.Location = new Point(3, 3);
            pnlTabTop.Name = "pnlTabTop";
            pnlTabTop.RowCount = 1;
            pnlTabTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabTop.Size = new Size(1896, 169);
            pnlTabTop.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.Logo_van_Rick_oftewel_ChatGPT;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(562, 163);
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
            lblPanelTitleDisplay.Location = new Point(588, 20);
            lblPanelTitleDisplay.Margin = new Padding(20);
            lblPanelTitleDisplay.Name = "lblPanelTitleDisplay";
            lblPanelTitleDisplay.Size = new Size(718, 129);
            lblPanelTitleDisplay.TabIndex = 1;
            lblPanelTitleDisplay.Text = "Admin";
            lblPanelTitleDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBackToProfile
            // 
            btnBackToProfile.BackColor = Color.Gainsboro;
            btnBackToProfile.Dock = DockStyle.Fill;
            btnBackToProfile.Location = new Point(1346, 20);
            btnBackToProfile.Margin = new Padding(20);
            btnBackToProfile.Name = "btnBackToProfile";
            btnBackToProfile.Size = new Size(530, 129);
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
            tabForAdminPanel.Location = new Point(3, 178);
            tabForAdminPanel.Name = "tabForAdminPanel";
            tabForAdminPanel.SelectedIndex = 0;
            tabForAdminPanel.Size = new Size(1896, 852);
            tabForAdminPanel.TabIndex = 1;
            // 
            // tabAddingFilms
            // 
            tabAddingFilms.BackColor = Color.DarkRed;
            tabAddingFilms.Controls.Add(pnlTabForAddingFilms);
            tabAddingFilms.Location = new Point(4, 29);
            tabAddingFilms.Name = "tabAddingFilms";
            tabAddingFilms.Padding = new Padding(3);
            tabAddingFilms.Size = new Size(1888, 819);
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
            pnlTabForAddingFilms.Location = new Point(3, 3);
            pnlTabForAddingFilms.Name = "pnlTabForAddingFilms";
            pnlTabForAddingFilms.RowCount = 3;
            pnlTabForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            pnlTabForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            pnlTabForAddingFilms.Size = new Size(1882, 813);
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
            pnlTabForCenteringInputForAddingFilms.Location = new Point(3, 3);
            pnlTabForCenteringInputForAddingFilms.Name = "pnlTabForCenteringInputForAddingFilms";
            pnlTabForCenteringInputForAddingFilms.RowCount = 1;
            pnlTabForCenteringInputForAddingFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlTabForCenteringInputForAddingFilms.Size = new Size(1876, 115);
            pnlTabForCenteringInputForAddingFilms.TabIndex = 0;
            // 
            // txtInputForAddingFilms
            // 
            txtInputForAddingFilms.Dock = DockStyle.Fill;
            txtInputForAddingFilms.Location = new Point(565, 3);
            txtInputForAddingFilms.Multiline = true;
            txtInputForAddingFilms.Name = "txtInputForAddingFilms";
            txtInputForAddingFilms.PlaceholderText = "Zoek naar een film";
            txtInputForAddingFilms.Size = new Size(744, 109);
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
            pnlTabForCenteringButtonForAddingFilm.Location = new Point(3, 693);
            pnlTabForCenteringButtonForAddingFilm.Name = "pnlTabForCenteringButtonForAddingFilm";
            pnlTabForCenteringButtonForAddingFilm.RowCount = 1;
            pnlTabForCenteringButtonForAddingFilm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabForCenteringButtonForAddingFilm.Size = new Size(1876, 117);
            pnlTabForCenteringButtonForAddingFilm.TabIndex = 1;
            // 
            // btnAddFilmToDatabase
            // 
            btnAddFilmToDatabase.Dock = DockStyle.Fill;
            btnAddFilmToDatabase.Location = new Point(565, 3);
            btnAddFilmToDatabase.Name = "btnAddFilmToDatabase";
            btnAddFilmToDatabase.Size = new Size(744, 111);
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
            pnlTabInfoForAddingMovie.Location = new Point(3, 124);
            pnlTabInfoForAddingMovie.Name = "pnlTabInfoForAddingMovie";
            pnlTabInfoForAddingMovie.RowCount = 1;
            pnlTabInfoForAddingMovie.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabInfoForAddingMovie.Size = new Size(1876, 563);
            pnlTabInfoForAddingMovie.TabIndex = 2;
            // 
            // picFilmPoster
            // 
            picFilmPoster.Dock = DockStyle.Fill;
            picFilmPoster.Image = (Image)resources.GetObject("picFilmPoster.Image");
            picFilmPoster.Location = new Point(96, 3);
            picFilmPoster.Name = "picFilmPoster";
            picFilmPoster.Size = new Size(556, 557);
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
            pnlTabAllFilmInfo.Location = new Point(658, 3);
            pnlTabAllFilmInfo.Name = "pnlTabAllFilmInfo";
            pnlTabAllFilmInfo.RowCount = 4;
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlTabAllFilmInfo.Size = new Size(1119, 557);
            pnlTabAllFilmInfo.TabIndex = 1;
            // 
            // lblFilmRuntime
            // 
            lblFilmRuntime.AutoSize = true;
            lblFilmRuntime.BackColor = Color.Gainsboro;
            lblFilmRuntime.Dock = DockStyle.Fill;
            lblFilmRuntime.ForeColor = SystemColors.ControlText;
            lblFilmRuntime.Location = new Point(10, 149);
            lblFilmRuntime.Margin = new Padding(10);
            lblFilmRuntime.Name = "lblFilmRuntime";
            lblFilmRuntime.Size = new Size(539, 119);
            lblFilmRuntime.TabIndex = 1;
            lblFilmRuntime.Text = "Runtime";
            lblFilmRuntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmGenre
            // 
            lblFilmGenre.AutoSize = true;
            lblFilmGenre.BackColor = Color.Gainsboro;
            lblFilmGenre.Dock = DockStyle.Fill;
            lblFilmGenre.Location = new Point(10, 288);
            lblFilmGenre.Margin = new Padding(10);
            lblFilmGenre.Name = "lblFilmGenre";
            lblFilmGenre.Size = new Size(539, 119);
            lblFilmGenre.TabIndex = 2;
            lblFilmGenre.Text = "Genre";
            lblFilmGenre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmPlot
            // 
            lblFilmPlot.AutoSize = true;
            lblFilmPlot.BackColor = Color.Gainsboro;
            lblFilmPlot.Dock = DockStyle.Fill;
            lblFilmPlot.Location = new Point(10, 427);
            lblFilmPlot.Margin = new Padding(10);
            lblFilmPlot.Name = "lblFilmPlot";
            lblFilmPlot.Size = new Size(539, 120);
            lblFilmPlot.TabIndex = 3;
            lblFilmPlot.Text = "Plot";
            lblFilmPlot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmRated
            // 
            lblFilmRated.AutoSize = true;
            lblFilmRated.BackColor = Color.Gainsboro;
            lblFilmRated.Dock = DockStyle.Fill;
            lblFilmRated.Location = new Point(569, 10);
            lblFilmRated.Margin = new Padding(10);
            lblFilmRated.Name = "lblFilmRated";
            lblFilmRated.Size = new Size(540, 119);
            lblFilmRated.TabIndex = 4;
            lblFilmRated.Text = "Rated";
            lblFilmRated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFilmTitle
            // 
            lblFilmTitle.AutoSize = true;
            lblFilmTitle.BackColor = Color.Gainsboro;
            lblFilmTitle.Dock = DockStyle.Fill;
            lblFilmTitle.Location = new Point(10, 10);
            lblFilmTitle.Margin = new Padding(10);
            lblFilmTitle.Name = "lblFilmTitle";
            lblFilmTitle.Padding = new Padding(10);
            lblFilmTitle.Size = new Size(539, 119);
            lblFilmTitle.TabIndex = 0;
            lblFilmTitle.Text = "Film Titel";
            lblFilmTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFilmPlaytime
            // 
            txtFilmPlaytime.BackColor = Color.Gainsboro;
            txtFilmPlaytime.Dock = DockStyle.Fill;
            txtFilmPlaytime.Location = new Point(569, 149);
            txtFilmPlaytime.Margin = new Padding(10);
            txtFilmPlaytime.Multiline = true;
            txtFilmPlaytime.Name = "txtFilmPlaytime";
            txtFilmPlaytime.PlaceholderText = "Speeltijd";
            txtFilmPlaytime.Size = new Size(540, 119);
            txtFilmPlaytime.TabIndex = 5;
            txtFilmPlaytime.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFilmRoom
            // 
            txtFilmRoom.BackColor = Color.Gainsboro;
            txtFilmRoom.Dock = DockStyle.Fill;
            txtFilmRoom.Location = new Point(569, 288);
            txtFilmRoom.Margin = new Padding(10);
            txtFilmRoom.Multiline = true;
            txtFilmRoom.Name = "txtFilmRoom";
            txtFilmRoom.PlaceholderText = "Zaal";
            txtFilmRoom.Size = new Size(540, 119);
            txtFilmRoom.TabIndex = 6;
            txtFilmRoom.TextAlign = HorizontalAlignment.Center;
            // 
            // tabEditFilms
            // 
            tabEditFilms.BackColor = Color.DarkRed;
            tabEditFilms.Controls.Add(pnlTabFilms);
            tabEditFilms.Location = new Point(4, 29);
            tabEditFilms.Name = "tabEditFilms";
            tabEditFilms.Padding = new Padding(3);
            tabEditFilms.Size = new Size(1888, 819);
            tabEditFilms.TabIndex = 1;
            tabEditFilms.Text = "Films bewerken";
            // 
            // pnlTabFilms
            // 
            pnlTabFilms.ColumnCount = 2;
            pnlTabFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlTabFilms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTabFilms.Dock = DockStyle.Fill;
            pnlTabFilms.Location = new Point(3, 3);
            pnlTabFilms.Name = "pnlTabFilms";
            pnlTabFilms.RowCount = 1;
            pnlTabFilms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTabFilms.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlTabFilms.Size = new Size(1882, 813);
            pnlTabFilms.TabIndex = 0;
            // 
            // tabEditUsers
            // 
            tabEditUsers.BackColor = Color.Maroon;
            tabEditUsers.Controls.Add(pnlTabUsers);
            tabEditUsers.Location = new Point(4, 29);
            tabEditUsers.Name = "tabEditUsers";
            tabEditUsers.Padding = new Padding(3);
            tabEditUsers.Size = new Size(1888, 819);
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
            pnlTabUsers.Location = new Point(3, 3);
            pnlTabUsers.Name = "pnlTabUsers";
            pnlTabUsers.RowCount = 2;
            pnlTabUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabUsers.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabUsers.Size = new Size(1882, 813);
            pnlTabUsers.TabIndex = 0;
            // 
            // tabShowOrders
            // 
            tabShowOrders.BackColor = Color.DarkRed;
            tabShowOrders.Controls.Add(pnlTabOrders);
            tabShowOrders.Location = new Point(4, 29);
            tabShowOrders.Name = "tabShowOrders";
            tabShowOrders.Padding = new Padding(3);
            tabShowOrders.Size = new Size(1888, 819);
            tabShowOrders.TabIndex = 3;
            tabShowOrders.Text = "Reserveringen zien";
            // 
            // pnlTabOrders
            // 
            pnlTabOrders.ColumnCount = 1;
            pnlTabOrders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlTabOrders.Dock = DockStyle.Fill;
            pnlTabOrders.Location = new Point(3, 3);
            pnlTabOrders.Name = "pnlTabOrders";
            pnlTabOrders.RowCount = 2;
            pnlTabOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            pnlTabOrders.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            pnlTabOrders.Size = new Size(1882, 813);
            pnlTabOrders.TabIndex = 0;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pnlTabAdmin);
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
    }
}