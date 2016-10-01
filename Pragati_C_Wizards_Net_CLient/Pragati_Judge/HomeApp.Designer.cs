namespace Pragati_Judge
{
    partial class HomeApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeApp));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbHome = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstSubmissions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtProbDes = new System.Windows.Forms.TextBox();
            this.lstProblms = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cntxProb = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submitSolutionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitSOlutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scorecardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutIJudgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSubmit = new System.Windows.Forms.ToolStripButton();
            this.tsbScorecard = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.notifyJudge = new System.Windows.Forms.NotifyIcon(this.components);
            this.msgDetector = new System.ComponentModel.BackgroundWorker();
            this.listRefresher = new System.ComponentModel.BackgroundWorker();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tbHome.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.cntxProb.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbHome);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(651, 439);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(651, 510);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.TopToolStripPanel.BackgroundImage = global::Pragati_Judge.Properties.Resources.Drawn_wallpapers_Robot_cyborg_clone_Biorobot_018977_;
            this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::Pragati_Judge.Properties.Resources.Drawn_wallpapers_Robot_cyborg_clone_Biorobot_018977_;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(222, 17);
            this.lblStatus.Text = "Wlcome to MCKV , Wish you all the best.";
            // 
            // tbHome
            // 
            this.tbHome.Controls.Add(this.tabPage1);
            this.tbHome.Controls.Add(this.tabPage2);
            this.tbHome.Location = new System.Drawing.Point(3, 3);
            this.tbHome.Name = "tbHome";
            this.tbHome.SelectedIndex = 0;
            this.tbHome.Size = new System.Drawing.Size(656, 440);
            this.tbHome.TabIndex = 1;
            this.tbHome.SelectedIndexChanged += new System.EventHandler(this.tbHome_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstSubmissions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Submissions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstSubmissions
            // 
            this.lstSubmissions.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lstSubmissions.BackColor = System.Drawing.Color.AliceBlue;
            this.lstSubmissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstSubmissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSubmissions.ForeColor = System.Drawing.Color.Navy;
            this.lstSubmissions.GridLines = true;
            this.lstSubmissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstSubmissions.Location = new System.Drawing.Point(3, 3);
            this.lstSubmissions.MultiSelect = false;
            this.lstSubmissions.Name = "lstSubmissions";
            this.lstSubmissions.Size = new System.Drawing.Size(642, 408);
            this.lstSubmissions.TabIndex = 0;
            this.lstSubmissions.UseCompatibleStateImageBehavior = false;
            this.lstSubmissions.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Problem Name";
            this.columnHeader1.Width = 222;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 266;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No Of Errors";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Marks";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtProbDes);
            this.tabPage2.Controls.Add(this.lstProblms);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unsolved Questions ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtProbDes
            // 
            this.txtProbDes.BackColor = System.Drawing.Color.AliceBlue;
            this.txtProbDes.ForeColor = System.Drawing.Color.Navy;
            this.txtProbDes.Location = new System.Drawing.Point(280, 5);
            this.txtProbDes.Multiline = true;
            this.txtProbDes.Name = "txtProbDes";
            this.txtProbDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProbDes.Size = new System.Drawing.Size(367, 405);
            this.txtProbDes.TabIndex = 1;
            // 
            // lstProblms
            // 
            this.lstProblms.BackColor = System.Drawing.Color.AliceBlue;
            this.lstProblms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lstProblms.ContextMenuStrip = this.cntxProb;
            this.lstProblms.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProblms.ForeColor = System.Drawing.Color.Navy;
            this.lstProblms.GridLines = true;
            this.lstProblms.Location = new System.Drawing.Point(3, 3);
            this.lstProblms.MultiSelect = false;
            this.lstProblms.Name = "lstProblms";
            this.lstProblms.Size = new System.Drawing.Size(271, 408);
            this.lstProblms.TabIndex = 0;
            this.lstProblms.UseCompatibleStateImageBehavior = false;
            this.lstProblms.View = System.Windows.Forms.View.Details;
            this.lstProblms.SelectedIndexChanged += new System.EventHandler(this.lstProblms_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Problem Name";
            this.columnHeader5.Width = 186;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Marks";
            this.columnHeader6.Width = 78;
            // 
            // cntxProb
            // 
            this.cntxProb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitSolutionToolStripMenuItem1});
            this.cntxProb.Name = "cntxProb";
            this.cntxProb.Size = new System.Drawing.Size(159, 26);
            // 
            // submitSolutionToolStripMenuItem1
            // 
            this.submitSolutionToolStripMenuItem1.Name = "submitSolutionToolStripMenuItem1";
            this.submitSolutionToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.submitSolutionToolStripMenuItem1.Text = "Submit Solution";
            this.submitSolutionToolStripMenuItem1.Click += new System.EventHandler(this.openSUbmitSOlFrm);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.BackgroundImage = global::Pragati_Judge.Properties.Resources.Drawn_wallpapers_Robot_cyborg_clone_Biorobot_018977_;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImage = global::Pragati_Judge.Properties.Resources.Drawn_wallpapers_Robot_cyborg_clone_Biorobot_018977_;
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitSOlutionToolStripMenuItem,
            this.scorecardToolStripMenuItem,
            this.refreshListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // submitSOlutionToolStripMenuItem
            // 
            this.submitSOlutionToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.submitSOlutionToolStripMenuItem.Image = global::Pragati_Judge.Properties.Resources.database_go;
            this.submitSOlutionToolStripMenuItem.Name = "submitSOlutionToolStripMenuItem";
            this.submitSOlutionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.submitSOlutionToolStripMenuItem.Text = "Submit Solution";
            this.submitSOlutionToolStripMenuItem.Click += new System.EventHandler(this.openSUbmitSOlFrm);
            // 
            // scorecardToolStripMenuItem
            // 
            this.scorecardToolStripMenuItem.Image = global::Pragati_Judge.Properties.Resources.application_form;
            this.scorecardToolStripMenuItem.Name = "scorecardToolStripMenuItem";
            this.scorecardToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.scorecardToolStripMenuItem.Text = "Scorecard";
            this.scorecardToolStripMenuItem.Click += new System.EventHandler(this.displayScoreCard);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Image = global::Pragati_Judge.Properties.Resources.arrow_refresh;
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.refreshListToolStripMenuItem.Text = "Refresh Lists";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshLists);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Pragati_Judge.Properties.Resources.stop;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.appExit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutIJudgeToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Image = global::Pragati_Judge.Properties.Resources.help;
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.viewInstructions);
            // 
            // aboutIJudgeToolStripMenuItem
            // 
            this.aboutIJudgeToolStripMenuItem.Image = global::Pragati_Judge.Properties.Resources.emoticon_smile;
            this.aboutIJudgeToolStripMenuItem.Name = "aboutIJudgeToolStripMenuItem";
            this.aboutIJudgeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutIJudgeToolStripMenuItem.Text = "About I Judge";
            this.aboutIJudgeToolStripMenuItem.Click += new System.EventHandler(this.aboutIJudgeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::Pragati_Judge.Properties.Resources.Drawn_wallpapers_Robot_cyborg_clone_Biorobot_018977_;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSubmit,
            this.tsbScorecard,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(413, 25);
            this.toolStrip1.TabIndex = 1;
            // 
            // tsbSubmit
            // 
            this.tsbSubmit.ForeColor = System.Drawing.Color.AliceBlue;
            this.tsbSubmit.Image = global::Pragati_Judge.Properties.Resources.database_go;
            this.tsbSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSubmit.Name = "tsbSubmit";
            this.tsbSubmit.Size = new System.Drawing.Size(65, 22);
            this.tsbSubmit.Text = "Submit";
            this.tsbSubmit.ToolTipText = "Submit Solution";
            this.tsbSubmit.Click += new System.EventHandler(this.openSUbmitSOlFrm);
            // 
            // tsbScorecard
            // 
            this.tsbScorecard.ForeColor = System.Drawing.Color.AliceBlue;
            this.tsbScorecard.Image = global::Pragati_Judge.Properties.Resources.application_form;
            this.tsbScorecard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScorecard.Name = "tsbScorecard";
            this.tsbScorecard.Size = new System.Drawing.Size(79, 22);
            this.tsbScorecard.Text = "Scorecard";
            this.tsbScorecard.Click += new System.EventHandler(this.displayScoreCard);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.AliceBlue;
            this.toolStripButton1.Image = global::Pragati_Judge.Properties.Resources.arrow_refresh;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 22);
            this.toolStripButton1.Text = "Refresh Lists";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.AliceBlue;
            this.toolStripButton2.Image = global::Pragati_Judge.Properties.Resources.help;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(89, 22);
            this.toolStripButton2.Text = "Instructions";
            this.toolStripButton2.Click += new System.EventHandler(this.viewInstructions);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ForeColor = System.Drawing.Color.AliceBlue;
            this.toolStripButton3.Image = global::Pragati_Judge.Properties.Resources.emoticon_smile;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton3.Text = "About Us";
            this.toolStripButton3.Click += new System.EventHandler(this.aboutIJudgeToolStripMenuItem_Click);
            // 
            // notifyJudge
            // 
            this.notifyJudge.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyJudge.BalloonTipTitle = "Pragati-2011 Samadhan";
            this.notifyJudge.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyJudge.Icon")));
            this.notifyJudge.Text = "I Judge";
            this.notifyJudge.Visible = true;
            // 
            // msgDetector
            // 
            this.msgDetector.DoWork += new System.ComponentModel.DoWorkEventHandler(this.msgDetector_DoWork);
            // 
            // listRefresher
            // 
            this.listRefresher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.listRefresher_DoWork);
            // 
            // HomeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pragati_Judge.Properties.Resources.Drawn_wallpapers_Robot_cyborg_clone_Biorobot_018977_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(651, 510);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(667, 548);
            this.MinimumSize = new System.Drawing.Size(667, 548);
            this.Name = "HomeApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pragati - 2011 - I Judge";
            this.Load += new System.EventHandler(this.HomeApp_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbHome.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.cntxProb.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutIJudgeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        public System.Windows.Forms.NotifyIcon notifyJudge;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitSOlutionToolStripMenuItem;
        private System.Windows.Forms.ListView lstSubmissions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSubmit;
        private System.Windows.Forms.ToolStripMenuItem scorecardToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbScorecard;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.ComponentModel.BackgroundWorker msgDetector;
        private System.Windows.Forms.TabControl tbHome;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstProblms;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtProbDes;
        private System.Windows.Forms.ContextMenuStrip cntxProb;
        private System.Windows.Forms.ToolStripMenuItem submitSolutionToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker listRefresher;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}