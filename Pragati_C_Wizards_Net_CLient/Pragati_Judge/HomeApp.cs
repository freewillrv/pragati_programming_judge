using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Pragati_Judge
{
    public partial class HomeApp : Form
    {
        public delegate void NotificationDisplayDelegate(string arr);
        public delegate void RefreshDelegate();   
        Team presentTeam;
        List<Problem> unslvdProb;
        public HomeApp(string teamName, int score, int id)
        {
            presentTeam = new Team(id, score, teamName);
            InitializeComponent();            
        }

        protected override void Dispose(bool disposing)
        {                        
            if (disposing && (components != null))
            {
                try
                {
                    msgDetector.CancelAsync();
                    msgDetector.Dispose();
                    listRefresher.CancelAsync();
                    listRefresher.Dispose();
                }
                catch (Exception) { }
                notifyJudge.Dispose();               
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void appExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewInstructions(object sender, EventArgs e)
        {
            (new InstructionsFrm()).Show();
        }

        private void openSUbmitSOlFrm(object sender, EventArgs e)
        {
            if (lstProblms.SelectedItems.Count != 0)
                (new SumitSolFrm(presentTeam.ID,lstProblms.SelectedIndices[0])).ShowDialog();
            else
                (new SumitSolFrm(presentTeam.ID)).ShowDialog();            
            refreshSubmissionList();
            tabPage1.Select();
        }
        private void notify(string arr)
        {
            notifyJudge.ShowBalloonTip(5000, "I Judge : Pragati", arr, ToolTipIcon.Info);
        }

        private void HomeApp_Load(object sender, EventArgs e)
        {
            notifyJudge.ShowBalloonTip(5000, "I Judge : Pragati", " Welcome " + presentTeam.Name + " , wish you all the best! ", ToolTipIcon.Info);
            try
            {
                msgDetector.RunWorkerAsync();
                listRefresher.RunWorkerAsync();
            }
            catch (Exception) { }
            notifyJudge.ShowBalloonTip(5000, "I Judge : Pragati", " Welcome " + presentTeam.Name + " , wish you all the best! ", ToolTipIcon.Info);
            refreshSubmissionList();
            refreshProblemsList();
        }

        private void refreshProblemsList()
        {
            lstProblms.Items.Clear();
            unslvdProb = (new DbaseHandler()).getUnsolvedProblems(presentTeam.ID);
            populateQuestionList(unslvdProb);
        }

        private void populateQuestionList(List<Problem> arr)
        {
            string[] prob = new string[2];
            foreach (Problem p in unslvdProb)
            {
                prob[0] = p.Name;
                prob[1] = p.Marks+"";
                lstProblms.Items.Add(new ListViewItem(prob));
            }
        }

        private void refreshSubmissionList()
        {          
            lstSubmissions.Items.Clear();
            List<System.Windows.Forms.ListViewItem> arr = (new DbaseHandler()).getSubmissions(presentTeam.ID);
            if (arr != null)
            {
                foreach (ListViewItem lst in arr)
                    lstSubmissions.Items.Add(lst);                
            }
                
        }

        private void displayScoreCard(object sender, EventArgs e)
        {
            this.Hide();
            (new ScoreCard()).ShowDialog();
            this.Show();
        }

        private void msgDetector_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(2000);
                    this.Invoke(new RefreshDelegate(refreshSubmissionList));
                    List<Message> msgs = new List<Message>();
                    msgs = (new DbaseHandler()).getMessages(presentTeam.ID);
                    if (msgs != null)
                    {
                        foreach (Message m in msgs)
                        {
                            Object[] arr = new Object[1];
                            arr[0] = m.Text;
                            this.Invoke(new NotificationDisplayDelegate(notify), arr);
                            System.Threading.Thread.Sleep(5000);
                        }
                    }

                }
            }
            catch (Exception)
            {
                
                
            }
        }
        

        private void aboutIJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new About()).ShowDialog();
        }

        private void lstProblms_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Problem p in unslvdProb)
                {
                    if (p.Name.Equals(lstProblms.SelectedItems[0].Text))
                    {
                        txtProbDes.Text = p.Description;
                        break;
                    }
                }
            }
            catch (Exception) { }

        }

        private void tbHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshProblemsList();
            refreshSubmissionList();
        }

        private void listRefresher_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(5000);
                    this.Invoke(new RefreshDelegate(refreshSubmissionList));
                    System.Threading.Thread.Sleep(5000);
                    this.Invoke(new RefreshDelegate(refreshProblemsList));

                }
            }
            catch (Exception){}
        }

        private void refreshLists(object sender, EventArgs e)
        {
            refreshSubmissionList();
            refreshProblemsList();
        }
    }
}
