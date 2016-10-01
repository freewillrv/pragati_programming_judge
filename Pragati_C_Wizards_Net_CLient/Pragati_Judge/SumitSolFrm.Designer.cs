namespace Pragati_Judge
{
    partial class SumitSolFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProblems = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.sourceExe = new System.Windows.Forms.OpenFileDialog();
            this.cmdSubSol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problem :";
            // 
            // cmbProblems
            // 
            this.cmbProblems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProblems.FormattingEnabled = true;
            this.cmbProblems.Location = new System.Drawing.Point(134, 21);
            this.cmbProblems.Name = "cmbProblems";
            this.cmbProblems.Size = new System.Drawing.Size(221, 21);
            this.cmbProblems.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Solution File Executable :";
            // 
            // txtExePath
            // 
            this.txtExePath.Location = new System.Drawing.Point(134, 55);
            this.txtExePath.Name = "txtExePath";
            this.txtExePath.ReadOnly = true;
            this.txtExePath.Size = new System.Drawing.Size(221, 20);
            this.txtExePath.TabIndex = 2;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(221, 81);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(65, 23);
            this.cmdBrowse.TabIndex = 3;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // sourceExe
            // 
            this.sourceExe.Filter = "Executable C Files| *.exe";
            // 
            // cmdSubSol
            // 
            this.cmdSubSol.Location = new System.Drawing.Point(289, 82);
            this.cmdSubSol.Name = "cmdSubSol";
            this.cmdSubSol.Size = new System.Drawing.Size(65, 23);
            this.cmdSubSol.TabIndex = 3;
            this.cmdSubSol.Text = "Submit";
            this.cmdSubSol.UseVisualStyleBackColor = true;
            this.cmdSubSol.Click += new System.EventHandler(this.submitSolution);
            // 
            // SumitSolFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::Pragati_Judge.Properties.Resources.Drawn_wallpapers_Robot_cyborg_clone_Biorobot_018977_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 114);
            this.Controls.Add(this.cmdSubSol);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtExePath);
            this.Controls.Add(this.cmbProblems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SumitSolFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit Solution";
            this.Load += new System.EventHandler(this.SumitSolFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProblems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.OpenFileDialog sourceExe;
        private System.Windows.Forms.Button cmdSubSol;
    }
}