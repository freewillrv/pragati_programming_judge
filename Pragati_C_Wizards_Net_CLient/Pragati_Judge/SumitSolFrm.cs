using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Pragati_Judge
{
    public partial class SumitSolFrm : Form
    {
        int teamid;
        List<Problem> unsolvedProbs;
        int selectIndex = 0;

        public SumitSolFrm(int teamid,int index)
        {
            this.selectIndex = index;
            this.teamid = teamid;
            InitializeComponent();
        }

        public SumitSolFrm(int teamid)
        {
            this.teamid = teamid;
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = sourceExe.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtExePath.Text = sourceExe.FileName;
            }
        }

        private void SumitSolFrm_Load(object sender, EventArgs e)
        {
            refreshProblemList();
        }

        private void refreshProblemList()
        {
            unsolvedProbs = new List<Problem>();
            unsolvedProbs = (new DbaseHandler()).getUnsolvedProblems(teamid);
            foreach (Problem p in unsolvedProbs)
                cmbProblems.Items.Add(p.ToString());
            cmbProblems.SelectedIndex =(selectIndex < cmbProblems.Items.Count) ? selectIndex : 0;
        }

        private void submitSolution(object sender, EventArgs e)
        {
            Problem p = unsolvedProbs.ElementAt(0);
            if (unsolvedProbs != null && txtExePath.Text.Length != 0)
            {                
                for (int i = 0; i < unsolvedProbs.Count; i++)
                {
                    p = unsolvedProbs.ElementAt(i);
                    if (p.ToString().Equals(cmbProblems.SelectedItem.ToString()))
                        break;
                }
            }

            checkProblemNo(p);
        }

        // Execute program and check output
        private void checkProblemNo(Problem p)
        {
            // Creating temporary input and output files
            createTemporaryFiles(p); 

            // Running the program with inputs and redirecting output
            try
            {
                
                Process myProcess = new Process();
                // Start a new instance of this program but specify the 'spawned' version.
                ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(txtExePath.Text);
                myProcessStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                myProcessStartInfo.UseShellExecute = false;
                myProcessStartInfo.RedirectStandardOutput = true;
                myProcessStartInfo.RedirectStandardInput = true;
                myProcess.StartInfo = myProcessStartInfo;
                bool started = myProcess.Start();
                if (started)
                {
                    StreamReader myStreamReader = myProcess.StandardOutput;
                    string[] arr = File.ReadAllLines("c:\\input");                    
                    myProcess.StandardInput.AutoFlush = true;
                                        
                    foreach (string str in arr)
                        myProcess.StandardInput.WriteLine(str);
                    // Read the standard output of the spawned process.                    
                    while (true)
                    {
                        string myString = myProcess.StandardOutput.ReadLine();
                        if (myString == null)
                            break;
                        Log.log(myString, "c:\\output");
                    }
                    myProcess.WaitForExit(5000);
                    //myProcess.Kill();
                    myProcess.Close();
                }
                
                // Comapare results
                int errors = 5;
                try
                {
                    string[] outP = File.ReadAllLines("c:\\output");
                    string[] valP = File.ReadAllLines("c:\\correct");
                    errors = 5;
                    int esp = 0;
                    if (valP.Length != outP.Length)
                        throw new Exception();
                    
                    for (int i = 0; i < outP.Length && i < valP.Length; i++)
                        if (!valP[i].Equals(outP[i]))
                            errors++;
                    errors = (errors > esp) ? errors : esp;
                }
                catch (Exception)
                {
                    MessageBox.Show(" Time Limit Exceeded ");
                }

                Submission sNew = new Submission(0, teamid, p.ID, System.DateTime.Now.ToString(), errors, p.Marks);
                bool success = (new DbaseHandler()).submitSolution(sNew);
                switch (errors)
                {
                    case 0:
                        MessageBox.Show(" Solution successfully  submitted ", " I Judge - Pragati ", MessageBoxButtons.OK);
                    break;
                    default:
                        MessageBox.Show(" Erronous solution. Degree of error (1-5) : "+ errors, " I Judge - Pragati ", MessageBoxButtons.OK);
                    break;
                }

                this.Dispose();


            }
            catch (Exception w)
            {
                MessageBox.Show(" Error " + w.Message);
            }        
            finally 
            {
                deleteTemporaryFiles();
            }

        }

        private void createTemporaryFiles(Problem p)
        {
            deleteTemporaryFiles();
            File.WriteAllText("c:\\correct", p.Output);
            File.WriteAllText("c:\\input", p.Input);
        }

        private void deleteTemporaryFiles()
        {
            if (File.Exists("c:\\correct"))
                File.Delete("c:\\correct");
            if (File.Exists("c:\\input"))
                File.Delete("c:\\input");
            if (File.Exists("c:\\output"))
                File.Delete("c:\\output");
        }


    }
}
