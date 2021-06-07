using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        
        private void standardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Cal.UserControl1 standard = new Cal.UserControl1();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(standard);

            this.Width = standard.Width + 10;
            this.Height = standard.Height + 70;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cal.UserControl2 scien = new Cal.UserControl2();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(scien);

            this.Width = scien.Width + 10;
            this.Height = scien.Height + 70;
        }
    }
}
