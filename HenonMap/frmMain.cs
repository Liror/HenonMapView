using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenonMap
{
    public partial class frmMain : Form
    {
        // Constructor / Initializer
        public frmMain()
        {
            // Create plots components
            InitializeComponent();
            this.plotView1.Model = new OxyPlot.PlotModel { Title = "Default Hénon Map" };

            // Select default tabPage
            this.tabControl1.SelectTab(0);
            this.tabControl1_SelectedIndexChanged(this.tabControl1, null);
        }

        // Plot Changed
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Activate current plotView (focus)
            switch (this.tabControl1.SelectedIndex + 1)
            {
                case 1:
                    this.drawDefaultMap();
                    this.plotView1.Focus();
                    break;

                default:
                    break;
            }
        }

    }
}
