namespace SharpBrowser
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseOtherTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnDownloads = new System.Windows.Forms.Button();
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.PanelToolbar = new System.Windows.Forms.Panel();
            this.TabPages = new FarsiLibrary.Win.FATabStrip();
            this.tabStrip1 = new FarsiLibrary.Win.FATabStripItem();
            this.tabStripAdd = new FarsiLibrary.Win.FATabStripItem();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_aidrive = new System.Windows.Forms.Button();
            this.btn_5d = new System.Windows.Forms.Button();
            this.btn_4d = new System.Windows.Forms.Button();
            this.btn_3d = new System.Windows.Forms.Button();
            this.btn_zdd = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_2d = new System.Windows.Forms.Button();
            this.btn_1d = new System.Windows.Forms.Button();
            this.btn_pd = new System.Windows.Forms.Button();
            this.lb_speed = new System.Windows.Forms.Label();
            this.btn_gift = new System.Windows.Forms.Button();
            this.lb_Toumingdu = new System.Windows.Forms.Label();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.BtnNextSearch = new System.Windows.Forms.Button();
            this.BtnPrevSearch = new System.Windows.Forms.Button();
            this.BtnCloseSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.menuStripTab.SuspendLayout();
            this.PanelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).BeginInit();
            this.TabPages.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.PanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTab
            // 
            this.menuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCloseTab,
            this.menuCloseOtherTabs});
            this.menuStripTab.Name = "menuStripTab";
            this.menuStripTab.Size = new System.Drawing.Size(182, 48);
            // 
            // menuCloseTab
            // 
            this.menuCloseTab.Name = "menuCloseTab";
            this.menuCloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.menuCloseTab.Size = new System.Drawing.Size(181, 22);
            this.menuCloseTab.Text = "Close tab";
            this.menuCloseTab.Click += new System.EventHandler(this.menuCloseTab_Click);
            // 
            // menuCloseOtherTabs
            // 
            this.menuCloseOtherTabs.Name = "menuCloseOtherTabs";
            this.menuCloseOtherTabs.Size = new System.Drawing.Size(181, 22);
            this.menuCloseOtherTabs.Text = "Close other tabs";
            this.menuCloseOtherTabs.Click += new System.EventHandler(this.menuCloseOtherTabs_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(878, 0);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(25, 30);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Location = new System.Drawing.Point(878, -2);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(25, 30);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForward.ForeColor = System.Drawing.Color.White;
            this.BtnForward.Image = ((System.Drawing.Image)(resources.GetObject("BtnForward.Image")));
            this.BtnForward.Location = new System.Drawing.Point(29, 0);
            this.BtnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(25, 30);
            this.BtnForward.TabIndex = 1;
            this.BtnForward.UseVisualStyleBackColor = true;
            this.BtnForward.Click += new System.EventHandler(this.bForward_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.Location = new System.Drawing.Point(2, 0);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(25, 30);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnDownloads
            // 
            this.BtnDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDownloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDownloads.ForeColor = System.Drawing.Color.White;
            this.BtnDownloads.Image = ((System.Drawing.Image)(resources.GetObject("BtnDownloads.Image")));
            this.BtnDownloads.Location = new System.Drawing.Point(906, 0);
            this.BtnDownloads.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDownloads.Name = "BtnDownloads";
            this.BtnDownloads.Size = new System.Drawing.Size(25, 30);
            this.BtnDownloads.TabIndex = 4;
            this.BtnDownloads.Tag = "Downloads";
            this.BtnDownloads.UseVisualStyleBackColor = true;
            this.BtnDownloads.Click += new System.EventHandler(this.bDownloads_Click);
            // 
            // TxtURL
            // 
            this.TxtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtURL.Location = new System.Drawing.Point(60, 5);
            this.TxtURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(812, 22);
            this.TxtURL.TabIndex = 5;
            this.TxtURL.Click += new System.EventHandler(this.txtUrl_Click);
            this.TxtURL.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.TxtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtURL_KeyDown);
            // 
            // PanelToolbar
            // 
            this.PanelToolbar.BackColor = System.Drawing.Color.White;
            this.PanelToolbar.Controls.Add(this.TxtURL);
            this.PanelToolbar.Controls.Add(this.BtnDownloads);
            this.PanelToolbar.Controls.Add(this.BtnForward);
            this.PanelToolbar.Controls.Add(this.BtnBack);
            this.PanelToolbar.Controls.Add(this.BtnRefresh);
            this.PanelToolbar.Controls.Add(this.BtnStop);
            this.PanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelToolbar.Location = new System.Drawing.Point(0, 0);
            this.PanelToolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelToolbar.Name = "PanelToolbar";
            this.PanelToolbar.Size = new System.Drawing.Size(934, 30);
            this.PanelToolbar.TabIndex = 6;
            // 
            // TabPages
            // 
            this.TabPages.ContextMenuStrip = this.menuStripTab;
            this.TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPages.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabStrip1,
            this.tabStripAdd});
            this.TabPages.Location = new System.Drawing.Point(0, 30);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedItem = this.tabStrip1;
            this.TabPages.Size = new System.Drawing.Size(934, 605);
            this.TabPages.TabIndex = 4;
            this.TabPages.Text = "faTabStrip1";
            this.TabPages.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.OnTabsChanged);
            this.TabPages.TabStripItemClosed += new System.EventHandler(this.OnTabClosed);
            this.TabPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPages_MouseClick);
            // 
            // tabStrip1
            // 
            this.tabStrip1.IsDrawn = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.Selected = true;
            this.tabStrip1.Size = new System.Drawing.Size(932, 575);
            this.tabStrip1.TabIndex = 0;
            this.tabStrip1.Title = "Loading...";
            // 
            // tabStripAdd
            // 
            this.tabStripAdd.CanClose = false;
            this.tabStripAdd.IsDrawn = true;
            this.tabStripAdd.Name = "tabStripAdd";
            this.tabStripAdd.Size = new System.Drawing.Size(932, 575);
            this.tabStripAdd.TabIndex = 1;
            this.tabStripAdd.Title = "+";
            // 
            // PanelStatus
            // 
            this.PanelStatus.Controls.Add(this.tableLayoutPanel2);
            this.PanelStatus.Controls.Add(this.lb_Toumingdu);
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelStatus.Location = new System.Drawing.Point(0, 635);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(934, 36);
            this.PanelStatus.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btn_aidrive, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_5d, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_4d, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_3d, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_zdd, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.trackBar1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_2d, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_1d, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_pd, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_speed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_gift, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 36);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btn_aidrive
            // 
            this.btn_aidrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_aidrive.Location = new System.Drawing.Point(142, 3);
            this.btn_aidrive.Name = "btn_aidrive";
            this.btn_aidrive.Size = new System.Drawing.Size(40, 30);
            this.btn_aidrive.TabIndex = 0;
            this.btn_aidrive.Text = "AI自动驾驶";
            this.btn_aidrive.UseVisualStyleBackColor = true;
            this.btn_aidrive.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_5d
            // 
            this.btn_5d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5d.Location = new System.Drawing.Point(839, 3);
            this.btn_5d.Name = "btn_5d";
            this.btn_5d.Size = new System.Drawing.Size(92, 30);
            this.btn_5d.TabIndex = 12;
            this.btn_5d.Text = "5档";
            this.btn_5d.UseVisualStyleBackColor = true;
            this.btn_5d.Click += new System.EventHandler(this.btn_5d_Click);
            // 
            // btn_4d
            // 
            this.btn_4d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4d.Location = new System.Drawing.Point(746, 3);
            this.btn_4d.Name = "btn_4d";
            this.btn_4d.Size = new System.Drawing.Size(87, 30);
            this.btn_4d.TabIndex = 11;
            this.btn_4d.Text = "4档";
            this.btn_4d.UseVisualStyleBackColor = true;
            this.btn_4d.Click += new System.EventHandler(this.btn_4d_Click);
            // 
            // btn_3d
            // 
            this.btn_3d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3d.Location = new System.Drawing.Point(653, 3);
            this.btn_3d.Name = "btn_3d";
            this.btn_3d.Size = new System.Drawing.Size(87, 30);
            this.btn_3d.TabIndex = 10;
            this.btn_3d.Text = "3档";
            this.btn_3d.UseVisualStyleBackColor = true;
            this.btn_3d.Click += new System.EventHandler(this.btn_3d_Click);
            // 
            // btn_zdd
            // 
            this.btn_zdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zdd.Location = new System.Drawing.Point(188, 3);
            this.btn_zdd.Name = "btn_zdd";
            this.btn_zdd.Size = new System.Drawing.Size(87, 30);
            this.btn_zdd.TabIndex = 1;
            this.btn_zdd.Text = "自动挡";
            this.btn_zdd.UseVisualStyleBackColor = true;
            this.btn_zdd.Click += new System.EventHandler(this.btn_zdd_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(281, 3);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(134, 30);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_2d
            // 
            this.btn_2d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2d.Location = new System.Drawing.Point(560, 3);
            this.btn_2d.Name = "btn_2d";
            this.btn_2d.Size = new System.Drawing.Size(87, 30);
            this.btn_2d.TabIndex = 7;
            this.btn_2d.Text = "2档";
            this.btn_2d.UseVisualStyleBackColor = true;
            this.btn_2d.Click += new System.EventHandler(this.btn_2d_Click);
            // 
            // btn_1d
            // 
            this.btn_1d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1d.Location = new System.Drawing.Point(467, 3);
            this.btn_1d.Name = "btn_1d";
            this.btn_1d.Size = new System.Drawing.Size(87, 30);
            this.btn_1d.TabIndex = 8;
            this.btn_1d.Text = "1档";
            this.btn_1d.UseVisualStyleBackColor = true;
            this.btn_1d.Click += new System.EventHandler(this.btn_1d_Click);
            // 
            // btn_pd
            // 
            this.btn_pd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_pd.Location = new System.Drawing.Point(421, 3);
            this.btn_pd.Name = "btn_pd";
            this.btn_pd.Size = new System.Drawing.Size(40, 30);
            this.btn_pd.TabIndex = 5;
            this.btn_pd.Text = "P档";
            this.btn_pd.UseVisualStyleBackColor = true;
            this.btn_pd.Click += new System.EventHandler(this.btn_pd_Click);
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Location = new System.Drawing.Point(49, 0);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(0, 15);
            this.lb_speed.TabIndex = 13;
            // 
            // btn_gift
            // 
            this.btn_gift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gift.Location = new System.Drawing.Point(3, 3);
            this.btn_gift.Name = "btn_gift";
            this.btn_gift.Size = new System.Drawing.Size(40, 30);
            this.btn_gift.TabIndex = 14;
            this.btn_gift.Text = "支持一下";
            this.btn_gift.UseVisualStyleBackColor = true;
            this.btn_gift.Click += new System.EventHandler(this.btn_gift_Click);
            // 
            // lb_Toumingdu
            // 
            this.lb_Toumingdu.AutoSize = true;
            this.lb_Toumingdu.Location = new System.Drawing.Point(656, 2);
            this.lb_Toumingdu.Name = "lb_Toumingdu";
            this.lb_Toumingdu.Size = new System.Drawing.Size(0, 15);
            this.lb_Toumingdu.TabIndex = 1;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.BtnNextSearch);
            this.PanelSearch.Controls.Add(this.BtnPrevSearch);
            this.PanelSearch.Controls.Add(this.BtnCloseSearch);
            this.PanelSearch.Controls.Add(this.TxtSearch);
            this.PanelSearch.Location = new System.Drawing.Point(625, 41);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(307, 40);
            this.PanelSearch.TabIndex = 9;
            this.PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSearch.ForeColor = System.Drawing.Color.White;
            this.BtnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
            this.BtnNextSearch.Location = new System.Drawing.Point(239, 4);
            this.BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNextSearch.Name = "BtnNextSearch";
            this.BtnNextSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnNextSearch.TabIndex = 9;
            this.BtnNextSearch.Tag = "Find next (Enter)";
            this.BtnNextSearch.UseVisualStyleBackColor = true;
            this.BtnNextSearch.Click += new System.EventHandler(this.BtnNextSearch_Click);
            // 
            // BtnPrevSearch
            // 
            this.BtnPrevSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevSearch.ForeColor = System.Drawing.Color.White;
            this.BtnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
            this.BtnPrevSearch.Location = new System.Drawing.Point(206, 4);
            this.BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPrevSearch.Name = "BtnPrevSearch";
            this.BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnPrevSearch.TabIndex = 8;
            this.BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
            this.BtnPrevSearch.UseVisualStyleBackColor = true;
            this.BtnPrevSearch.Click += new System.EventHandler(this.BtnPrevSearch_Click);
            // 
            // BtnCloseSearch
            // 
            this.BtnCloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCloseSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
            this.BtnCloseSearch.Location = new System.Drawing.Point(272, 4);
            this.BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCloseSearch.Name = "BtnCloseSearch";
            this.BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnCloseSearch.TabIndex = 7;
            this.BtnCloseSearch.Tag = "Close (Esc)";
            this.BtnCloseSearch.UseVisualStyleBackColor = true;
            this.BtnCloseSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(10, 6);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(181, 25);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 671);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.TabPages);
            this.Controls.Add(this.PanelToolbar);
            this.Controls.Add(this.PanelStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripTab.ResumeLayout(false);
            this.PanelToolbar.ResumeLayout(false);
            this.PanelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).EndInit();
            this.TabPages.ResumeLayout(false);
            this.PanelStatus.ResumeLayout(false);
            this.PanelStatus.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

		private FarsiLibrary.Win.FATabStrip TabPages;
        private FarsiLibrary.Win.FATabStripItem tabStrip1;
        private FarsiLibrary.Win.FATabStripItem tabStripAdd;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip menuStripTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseOtherTabs;
		private System.Windows.Forms.Button BtnForward;
		private System.Windows.Forms.Button BtnBack;
		private System.Windows.Forms.Button BtnStop;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.Button BtnDownloads;
		private System.Windows.Forms.TextBox TxtURL;
		private System.Windows.Forms.Panel PanelToolbar;
		private System.Windows.Forms.Panel PanelStatus;
		private System.Windows.Forms.Panel PanelSearch;
		private System.Windows.Forms.TextBox TxtSearch;
		private System.Windows.Forms.Button BtnCloseSearch;
		private System.Windows.Forms.Button BtnPrevSearch;
		private System.Windows.Forms.Button BtnNextSearch;
        private System.Windows.Forms.Label lb_Toumingdu;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_zdd;
        private System.Windows.Forms.Button btn_pd;
        private System.Windows.Forms.Button btn_2d;
        private System.Windows.Forms.Button btn_1d;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_5d;
        private System.Windows.Forms.Button btn_4d;
        private System.Windows.Forms.Button btn_3d;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.Button btn_gift;
        private System.Windows.Forms.Button btn_aidrive;
    }
}

