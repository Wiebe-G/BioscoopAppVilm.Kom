namespace Film.Kom
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            lblUsername = new Label();
            picFilm1 = new PictureBox();
            lblFilm1 = new Label();
            pnlTaakbalk = new TableLayoutPanel();
            picLogo = new PictureBox();
            pnlSearch = new TableLayoutPanel();
            btnSearch = new Button();
            pnlSearchbar = new TableLayoutPanel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlFilter = new TableLayoutPanel();
            cmbFilter = new ComboBox();
            lblFilter = new Label();
            pnlLogin = new TableLayoutPanel();
            btnLogin = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            picFigure = new PictureBox();
            pnlMovie1 = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            picFilm2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlSecundary = new TableLayoutPanel();
            pnlSlideMoviesMain = new TableLayoutPanel();
            label1 = new Label();
            pnlSlideMoviesSecundary = new TableLayoutPanel();
            picSlide = new PictureBox();
            pnlMovies = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            picFilm5 = new PictureBox();
            lblFilm5 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            picFilm4 = new PictureBox();
            lblFilm4 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            picFilm3 = new PictureBox();
            lblFilm3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblFilm2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picFilm1).BeginInit();
            pnlTaakbalk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlSearch.SuspendLayout();
            pnlSearchbar.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlLogin.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFigure).BeginInit();
            pnlMovie1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlSecundary.SuspendLayout();
            pnlSlideMoviesMain.SuspendLayout();
            pnlSlideMoviesSecundary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSlide).BeginInit();
            pnlMovies.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm5).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm4).EndInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm3).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Dock = DockStyle.Fill;
            lblUsername.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ButtonHighlight;
            lblUsername.Location = new Point(52, 21);
            lblUsername.Margin = new Padding(5, 0, 5, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(113, 40);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Gast";
            lblUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picFilm1
            // 
            picFilm1.Dock = DockStyle.Fill;
            picFilm1.Image = (Image)resources.GetObject("picFilm1.Image");
            picFilm1.Location = new Point(5, 4);
            picFilm1.Margin = new Padding(5, 4, 5, 4);
            picFilm1.Name = "picFilm1";
            picFilm1.Size = new Size(256, 387);
            picFilm1.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm1.TabIndex = 0;
            picFilm1.TabStop = false;
            // 
            // lblFilm1
            // 
            lblFilm1.AutoSize = true;
            lblFilm1.Dock = DockStyle.Fill;
            lblFilm1.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilm1.Location = new Point(5, 395);
            lblFilm1.Margin = new Padding(5, 0, 5, 0);
            lblFilm1.Name = "lblFilm1";
            lblFilm1.Size = new Size(256, 63);
            lblFilm1.TabIndex = 1;
            lblFilm1.Text = "film";
            lblFilm1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTaakbalk
            // 
            pnlTaakbalk.ColumnCount = 5;
            pnlTaakbalk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTaakbalk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTaakbalk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            pnlTaakbalk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlTaakbalk.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlTaakbalk.Controls.Add(picLogo, 0, 0);
            pnlTaakbalk.Controls.Add(pnlSearch, 4, 0);
            pnlTaakbalk.Controls.Add(pnlSearchbar, 2, 0);
            pnlTaakbalk.Controls.Add(pnlFilter, 1, 0);
            pnlTaakbalk.Controls.Add(pnlLogin, 3, 0);
            pnlTaakbalk.Dock = DockStyle.Fill;
            pnlTaakbalk.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            pnlTaakbalk.Location = new Point(5, 4);
            pnlTaakbalk.Margin = new Padding(5, 4, 5, 4);
            pnlTaakbalk.Name = "pnlTaakbalk";
            pnlTaakbalk.RowCount = 1;
            pnlTaakbalk.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlTaakbalk.Size = new Size(1904, 149);
            pnlTaakbalk.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.InitialImage = (Image)resources.GetObject("picLogo.InitialImage");
            picLogo.Location = new Point(5, 4);
            picLogo.Margin = new Padding(5, 4, 5, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(370, 141);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // pnlSearch
            // 
            pnlSearch.ColumnCount = 1;
            pnlSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            pnlSearch.Controls.Add(btnSearch, 0, 1);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(1526, 4);
            pnlSearch.Margin = new Padding(5, 4, 5, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.RowCount = 2;
            pnlSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlSearch.Size = new Size(373, 141);
            pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkRed;
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(5, 74);
            btnSearch.Margin = new Padding(5, 4, 5, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(363, 63);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Zoeken";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlSearchbar
            // 
            pnlSearchbar.BackColor = Color.DarkRed;
            pnlSearchbar.ColumnCount = 1;
            pnlSearchbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSearchbar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            pnlSearchbar.Controls.Add(txtSearch, 0, 1);
            pnlSearchbar.Controls.Add(lblSearch, 0, 0);
            pnlSearchbar.Dock = DockStyle.Fill;
            pnlSearchbar.Location = new Point(575, 4);
            pnlSearchbar.Margin = new Padding(5, 4, 5, 4);
            pnlSearchbar.Name = "pnlSearchbar";
            pnlSearchbar.RowCount = 2;
            pnlSearchbar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlSearchbar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlSearchbar.Size = new Size(751, 141);
            pnlSearchbar.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(5, 74);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(741, 63);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Zoeken...";
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.Click += txtSearch_Click;
            txtSearch.KeyDown += Search_Keydown;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(5, 0);
            lblSearch.Margin = new Padding(5, 0, 5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(741, 70);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Zoek hier een film";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFilter
            // 
            pnlFilter.ColumnCount = 1;
            pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            pnlFilter.Controls.Add(cmbFilter, 0, 1);
            pnlFilter.Controls.Add(lblFilter, 0, 0);
            pnlFilter.Dock = DockStyle.Fill;
            pnlFilter.Location = new Point(385, 4);
            pnlFilter.Margin = new Padding(5, 4, 5, 4);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.RowCount = 2;
            pnlFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlFilter.Size = new Size(180, 141);
            pnlFilter.TabIndex = 4;
            // 
            // cmbFilter
            // 
            cmbFilter.BackColor = Color.DarkRed;
            cmbFilter.Dock = DockStyle.Fill;
            cmbFilter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Horror", "Comedy", "Actie", "Romantiek", "Fantasie", "Kinderfilm", "Thriller", "Drama", "Musical", "Oorlog", "Natuur", "Avontuur" });
            cmbFilter.Location = new Point(5, 74);
            cmbFilter.Margin = new Padding(5, 4, 5, 4);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(170, 33);
            cmbFilter.TabIndex = 6;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Dock = DockStyle.Fill;
            lblFilter.Font = new Font("Georgia", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = SystemColors.ButtonHighlight;
            lblFilter.Location = new Point(5, 0);
            lblFilter.Margin = new Padding(5, 0, 5, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(170, 70);
            lblFilter.TabIndex = 7;
            lblFilter.Text = "Filteren";
            lblFilter.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlLogin
            // 
            pnlLogin.ColumnCount = 1;
            pnlLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlLogin.Controls.Add(btnLogin, 0, 1);
            pnlLogin.Controls.Add(tableLayoutPanel2, 0, 0);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(1336, 4);
            pnlLogin.Margin = new Padding(5, 4, 5, 4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.RowCount = 2;
            pnlLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlLogin.Size = new Size(180, 141);
            pnlLogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkRed;
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(5, 74);
            btnLogin.Margin = new Padding(5, 4, 5, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 63);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Inloggen";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.68362F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.31638F));
            tableLayoutPanel2.Controls.Add(picFigure, 0, 1);
            tableLayoutPanel2.Controls.Add(lblUsername, 1, 1);
            tableLayoutPanel2.Location = new Point(5, 4);
            tableLayoutPanel2.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.38462F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.61539F));
            tableLayoutPanel2.Size = new Size(170, 61);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // picFigure
            // 
            picFigure.BackColor = SystemColors.ButtonHighlight;
            picFigure.Dock = DockStyle.Fill;
            picFigure.Image = (Image)resources.GetObject("picFigure.Image");
            picFigure.Location = new Point(5, 25);
            picFigure.Margin = new Padding(5, 4, 5, 4);
            picFigure.Name = "picFigure";
            picFigure.Size = new Size(37, 32);
            picFigure.SizeMode = PictureBoxSizeMode.StretchImage;
            picFigure.TabIndex = 0;
            picFigure.TabStop = false;
            // 
            // pnlMovie1
            // 
            pnlMovie1.ColumnCount = 1;
            pnlMovie1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlMovie1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            pnlMovie1.Controls.Add(picFilm1, 0, 0);
            pnlMovie1.Controls.Add(lblFilm1, 0, 1);
            pnlMovie1.Dock = DockStyle.Fill;
            pnlMovie1.Location = new Point(5, 4);
            pnlMovie1.Margin = new Padding(5, 4, 5, 4);
            pnlMovie1.Name = "pnlMovie1";
            pnlMovie1.RowCount = 2;
            pnlMovie1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.30434F));
            pnlMovie1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.69565F));
            pnlMovie1.Size = new Size(266, 458);
            pnlMovie1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            // 
            // picFilm2
            // 
            picFilm2.Dock = DockStyle.Fill;
            picFilm2.Image = (Image)resources.GetObject("picFilm2.Image");
            picFilm2.Location = new Point(5, 4);
            picFilm2.Margin = new Padding(5, 4, 5, 4);
            picFilm2.Name = "picFilm2";
            picFilm2.Size = new Size(256, 387);
            picFilm2.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm2.TabIndex = 0;
            picFilm2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlSecundary, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlTaakbalk, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 4);
            tableLayoutPanel1.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(1914, 1047);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlSecundary
            // 
            pnlSecundary.ColumnCount = 3;
            pnlSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            pnlSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            pnlSecundary.Controls.Add(pnlSlideMoviesMain, 1, 0);
            pnlSecundary.Dock = DockStyle.Fill;
            pnlSecundary.Location = new Point(5, 161);
            pnlSecundary.Margin = new Padding(5, 4, 5, 4);
            pnlSecundary.Name = "pnlSecundary";
            pnlSecundary.RowCount = 1;
            pnlSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlSecundary.Size = new Size(1904, 882);
            pnlSecundary.TabIndex = 0;
            // 
            // pnlSlideMoviesMain
            // 
            pnlSlideMoviesMain.ColumnCount = 1;
            pnlSlideMoviesMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSlideMoviesMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            pnlSlideMoviesMain.Controls.Add(label1, 0, 0);
            pnlSlideMoviesMain.Controls.Add(pnlSlideMoviesSecundary, 0, 1);
            pnlSlideMoviesMain.Dock = DockStyle.Fill;
            pnlSlideMoviesMain.ForeColor = SystemColors.ButtonHighlight;
            pnlSlideMoviesMain.Location = new Point(195, 4);
            pnlSlideMoviesMain.Margin = new Padding(5, 4, 5, 4);
            pnlSlideMoviesMain.Name = "pnlSlideMoviesMain";
            pnlSlideMoviesMain.RowCount = 2;
            pnlSlideMoviesMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.801843F));
            pnlSlideMoviesMain.RowStyles.Add(new RowStyle(SizeType.Percent, 96.19816F));
            pnlSlideMoviesMain.Size = new Size(1513, 874);
            pnlSlideMoviesMain.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Georgia", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(5, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1494, 32);
            label1.TabIndex = 0;
            label1.Text = "Nu in de bioscoop!";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSlideMoviesSecundary
            // 
            pnlSlideMoviesSecundary.ColumnCount = 1;
            pnlSlideMoviesSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSlideMoviesSecundary.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            pnlSlideMoviesSecundary.Controls.Add(picSlide, 0, 0);
            pnlSlideMoviesSecundary.Controls.Add(pnlMovies, 0, 1);
            pnlSlideMoviesSecundary.Dock = DockStyle.Fill;
            pnlSlideMoviesSecundary.Location = new Point(5, 37);
            pnlSlideMoviesSecundary.Margin = new Padding(5, 4, 5, 4);
            pnlSlideMoviesSecundary.Name = "pnlSlideMoviesSecundary";
            pnlSlideMoviesSecundary.RowCount = 2;
            pnlSlideMoviesSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 43.18456F));
            pnlSlideMoviesSecundary.RowStyles.Add(new RowStyle(SizeType.Percent, 56.81544F));
            pnlSlideMoviesSecundary.Size = new Size(1503, 833);
            pnlSlideMoviesSecundary.TabIndex = 1;
            // 
            // picSlide
            // 
            picSlide.Dock = DockStyle.Fill;
            picSlide.Image = (Image)resources.GetObject("picSlide.Image");
            picSlide.Location = new Point(5, 4);
            picSlide.Margin = new Padding(5, 4, 5, 4);
            picSlide.Name = "picSlide";
            picSlide.Size = new Size(1493, 351);
            picSlide.SizeMode = PictureBoxSizeMode.StretchImage;
            picSlide.TabIndex = 0;
            picSlide.TabStop = false;
            // 
            // pnlMovies
            // 
            pnlMovies.ColumnCount = 9;
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.51852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.851852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.51852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.851852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.51852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.851852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.51852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.851852F));
            pnlMovies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.51852F));
            pnlMovies.Controls.Add(tableLayoutPanel9, 8, 0);
            pnlMovies.Controls.Add(tableLayoutPanel7, 6, 0);
            pnlMovies.Controls.Add(tableLayoutPanel5, 4, 0);
            pnlMovies.Controls.Add(tableLayoutPanel3, 2, 0);
            pnlMovies.Controls.Add(pnlMovie1, 0, 0);
            pnlMovies.Dock = DockStyle.Fill;
            pnlMovies.Location = new Point(5, 363);
            pnlMovies.Margin = new Padding(5, 4, 5, 4);
            pnlMovies.Name = "pnlMovies";
            pnlMovies.RowCount = 1;
            pnlMovies.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMovies.RowStyles.Add(new RowStyle(SizeType.Absolute, 467F));
            pnlMovies.Size = new Size(1493, 466);
            pnlMovies.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel9.Controls.Add(picFilm5, 0, 0);
            tableLayoutPanel9.Controls.Add(lblFilm5, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(1217, 4);
            tableLayoutPanel9.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 86.30434F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 13.69565F));
            tableLayoutPanel9.Size = new Size(271, 458);
            tableLayoutPanel9.TabIndex = 8;
            // 
            // picFilm5
            // 
            picFilm5.Dock = DockStyle.Fill;
            picFilm5.Image = (Image)resources.GetObject("picFilm5.Image");
            picFilm5.Location = new Point(5, 4);
            picFilm5.Margin = new Padding(5, 4, 5, 4);
            picFilm5.Name = "picFilm5";
            picFilm5.Size = new Size(261, 387);
            picFilm5.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm5.TabIndex = 0;
            picFilm5.TabStop = false;
            // 
            // lblFilm5
            // 
            lblFilm5.AutoSize = true;
            lblFilm5.Dock = DockStyle.Fill;
            lblFilm5.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilm5.Location = new Point(5, 395);
            lblFilm5.Margin = new Padding(5, 0, 5, 0);
            lblFilm5.Name = "lblFilm5";
            lblFilm5.Size = new Size(261, 63);
            lblFilm5.TabIndex = 1;
            lblFilm5.Text = "film";
            lblFilm5.TextAlign = ContentAlignment.MiddleCenter;
            lblFilm5.Click += lblFilm5_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel7.Controls.Add(picFilm4, 0, 0);
            tableLayoutPanel7.Controls.Add(lblFilm4, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(914, 4);
            tableLayoutPanel7.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 86.30434F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 13.69565F));
            tableLayoutPanel7.Size = new Size(266, 458);
            tableLayoutPanel7.TabIndex = 6;
            // 
            // picFilm4
            // 
            picFilm4.Dock = DockStyle.Fill;
            picFilm4.Image = (Image)resources.GetObject("picFilm4.Image");
            picFilm4.Location = new Point(5, 4);
            picFilm4.Margin = new Padding(5, 4, 5, 4);
            picFilm4.Name = "picFilm4";
            picFilm4.Size = new Size(256, 387);
            picFilm4.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm4.TabIndex = 0;
            picFilm4.TabStop = false;
            // 
            // lblFilm4
            // 
            lblFilm4.AutoSize = true;
            lblFilm4.Dock = DockStyle.Fill;
            lblFilm4.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilm4.Location = new Point(5, 395);
            lblFilm4.Margin = new Padding(5, 0, 5, 0);
            lblFilm4.Name = "lblFilm4";
            lblFilm4.Size = new Size(256, 63);
            lblFilm4.TabIndex = 1;
            lblFilm4.Text = "film";
            lblFilm4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel5.Controls.Add(picFilm3, 0, 0);
            tableLayoutPanel5.Controls.Add(lblFilm3, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(611, 4);
            tableLayoutPanel5.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 86.30434F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 13.69565F));
            tableLayoutPanel5.Size = new Size(266, 458);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // picFilm3
            // 
            picFilm3.Dock = DockStyle.Fill;
            picFilm3.Image = (Image)resources.GetObject("picFilm3.Image");
            picFilm3.Location = new Point(5, 4);
            picFilm3.Margin = new Padding(5, 4, 5, 4);
            picFilm3.Name = "picFilm3";
            picFilm3.Size = new Size(256, 387);
            picFilm3.SizeMode = PictureBoxSizeMode.StretchImage;
            picFilm3.TabIndex = 0;
            picFilm3.TabStop = false;
            // 
            // lblFilm3
            // 
            lblFilm3.AutoSize = true;
            lblFilm3.Dock = DockStyle.Fill;
            lblFilm3.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilm3.Location = new Point(5, 395);
            lblFilm3.Margin = new Padding(5, 0, 5, 0);
            lblFilm3.Name = "lblFilm3";
            lblFilm3.Size = new Size(256, 63);
            lblFilm3.TabIndex = 1;
            lblFilm3.Text = "film";
            lblFilm3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel3.Controls.Add(picFilm2, 0, 0);
            tableLayoutPanel3.Controls.Add(lblFilm2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(308, 4);
            tableLayoutPanel3.Margin = new Padding(5, 4, 5, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 86.30434F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 13.69565F));
            tableLayoutPanel3.Size = new Size(266, 458);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // lblFilm2
            // 
            lblFilm2.AutoSize = true;
            lblFilm2.Dock = DockStyle.Fill;
            lblFilm2.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilm2.Location = new Point(5, 395);
            lblFilm2.Margin = new Padding(5, 0, 5, 0);
            lblFilm2.Name = "lblFilm2";
            lblFilm2.Size = new Size(256, 63);
            lblFilm2.TabIndex = 1;
            lblFilm2.Text = "film";
            lblFilm2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlMain
            // 
            pnlMain.ColumnCount = 1;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            pnlMain.Controls.Add(tableLayoutPanel1, 0, 0);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(5, 4, 5, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 1;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            pnlMain.Size = new Size(1924, 1055);
            pnlMain.TabIndex = 5;
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pnlMain);
            Name = "frmMainMenu";
            Text = "frmMainMenu";
            ((System.ComponentModel.ISupportInitialize)picFilm1).EndInit();
            pnlTaakbalk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearchbar.ResumeLayout(false);
            pnlSearchbar.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlLogin.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFigure).EndInit();
            pnlMovie1.ResumeLayout(false);
            pnlMovie1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlSecundary.ResumeLayout(false);
            pnlSlideMoviesMain.ResumeLayout(false);
            pnlSlideMoviesMain.PerformLayout();
            pnlSlideMoviesSecundary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSlide).EndInit();
            pnlMovies.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm5).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm4).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFilm3).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion                                                                          

        private Label lblUsername;
        private PictureBox picFilm1;
        private Label lblFilm1;
        private TableLayoutPanel pnlTaakbalk;
        private PictureBox picLogo;
        private TableLayoutPanel pnlSearch;
        private Button btnSearch;
        private TableLayoutPanel pnlSearchbar;
        private TextBox txtSearch;
        private Label lblSearch;
        private TableLayoutPanel pnlFilter;
        private ComboBox cmbFilter;
        private Label lblFilter;
        private TableLayoutPanel pnlLogin;
        private Button btnLogin;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox picFigure;
        private TableLayoutPanel pnlMovie1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox picFilm2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel pnlSecundary;
        private TableLayoutPanel pnlSlideMoviesMain;
        private Label label1;
        private TableLayoutPanel pnlSlideMoviesSecundary;
        private PictureBox picSlide;
        private TableLayoutPanel pnlMovies;
        private TableLayoutPanel tableLayoutPanel9;
        private PictureBox picFilm5;
        private Label lblFilm5;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox picFilm4;
        private Label lblFilm4;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox picFilm3;
        private Label lblFilm3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblFilm2;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel pnlMain;
    }
}