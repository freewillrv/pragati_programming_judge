using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pragati_Judge
{
    public partial class Splash : Form
    {
        public Splash()
        {
            this.Opacity = 0.2;            
            InitializeComponent();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += .1;
        }

        private void timeT_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            fadeTimer.Start();
            timeT.Start();
        }

        
    }
}