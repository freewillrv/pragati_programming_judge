namespace Pragati_Judge
{
    partial class ScoreCard
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
                scoreUpdater.CancelAsync();
                scoreUpdater.Dispose();
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
            this.lstScore = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.tmScore = new System.Windows.Forms.Timer(this.components);
            this.scoreUpdater = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lstScore
            // 
            this.lstScore.BackColor = System.Drawing.Color.AliceBlue;
            this.lstScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstScore.ForeColor = System.Drawing.Color.Navy;
            this.lstScore.GridLines = true;
            this.lstScore.Location = new System.Drawing.Point(0, 0);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(291, 461);
            this.lstScore.TabIndex = 0;
            this.lstScore.UseCompatibleStateImageBehavior = false;
            this.lstScore.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Team";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 112;
            // 
            // tmScore
            // 
            this.tmScore.Interval = 2000;
            this.tmScore.Tick += new System.EventHandler(this.tmScore_Tick);
            // 
            // scoreUpdater
            // 
            this.scoreUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.scoreUpdater_DoWork);
            // 
            // ScoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 461);
            this.Controls.Add(this.lstScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ScoreCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreCard";
            this.Load += new System.EventHandler(this.ScoreCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstScore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer tmScore;
        private System.ComponentModel.BackgroundWorker scoreUpdater;
    }
}