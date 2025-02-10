using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_hibernating
{
    public partial class FrmMain : Form
    {
        public const string msg = "The program is already running!, The small icon in the bottom right corner allows you to view the process";
        public FrmMain()
        {
            InitializeComponent();
            this.exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            this.Load += FrmMain_Load;
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{msg}", "Welcome to the tool", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SleepPrevention.RestoreSleep();
            Environment.Exit(Environment.ExitCode);
        }
    }
}
