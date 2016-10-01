using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pragati_Judge
{
    public partial class ScoreCard : Form
    {
        public delegate void RefreshScorecardDelegate();   
        public ScoreCard()
        {
            InitializeComponent();
        }

        private void ScoreCard_Load(object sender, EventArgs e)
        {            
            refreshScoreCard();
            scoreUpdater.RunWorkerAsync();
        }

        private void tmScore_Tick(object sender, EventArgs e)
        {
            refreshScoreCard();
        }

        private void refreshScoreCard()
        {
            lstScore.Items.Clear();            
            List<System.Windows.Forms.ListViewItem> arr = (new DbaseHandler()).getScore();
            if (arr != null)
            {
                foreach (ListViewItem lst in arr)
                    lstScore.Items.Add(lst);
            }
        }

        private void scoreUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    System.Threading.Thread.Sleep(2000);
                    this.Invoke(new RefreshScorecardDelegate(refreshScoreCard));
                }
                catch (Exception) { break; }
            }
        }
    }
}
