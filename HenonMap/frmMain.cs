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
            this.plotView2.Model = new OxyPlot.PlotModel { Title = "Adjustable Alpha Multiple Beta Hénon Map" };
            this.plotView3.Model = new OxyPlot.PlotModel { Title = "Multiple Alpha Adjustable Beta Hénon Map" };
            this.plotView4.Model = new OxyPlot.PlotModel { Title = "Alpha against X Hénon Map" };
            this.plotView5.Model = new OxyPlot.PlotModel { Title = "Beta against X Hénon Map" };
            this.plotView6x.Model = new OxyPlot.PlotModel { Title = "Alpha against X Hénon Map" };
            this.plotView6y.Model = new OxyPlot.PlotModel { Title = "Alpha against Y Hénon Map" };

            // Select default tabPage
            this.initDrawing();
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
                    break;
                case 2:
                    this.drawFixedAlpha();
                    break;
                case 3:
                    this.drawFixedBeta();
                    break;
                case 4:
                    this.drawAlphaPlot();
                    break;
                case 5:
                    this.drawBetaPlot();
                    break;
                case 6:
                    this.drawDouble();
                    break;
                default:
                    break;
            }
        }

        // Window Client Size Changed
        private void tabPage6_SizeChanged(object sender, EventArgs e)
        {
            int rwidth = this.tabPage6.Size.Width / 2;
            int lwidth = this.tabPage6.Size.Width - rwidth;
            this.plotView6x.Width = lwidth;
            this.plotView6y.Left = lwidth;
            this.plotView6y.Width = rwidth;
        }

        // #1 defaultMap parameter changes
        private void textBox1a_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox1a.Text); }
            catch { }
            if (val != this.alpha1)
            {
                this.alpha1 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 5000) tmp = 5000;
                else if (tmp < -5000) tmp = -5000;
                this.trackBar1a.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void textBox1b_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox1b.Text); }
            catch { }
            if (val != this.beta1)
            {
                this.beta1 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 5000) tmp = 5000;
                else if (tmp < -5000) tmp = -5000;
                this.trackBar1b.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar1a_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox1a.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar1a.Value)
            {
                this.alpha1 = Convert.ToDouble(this.trackBar1a.Value) / 1000.0;
                this.textBox1a.Text = Convert.ToString(this.alpha1);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar1b_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox1b.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar1b.Value)
            {
                this.beta1 = Convert.ToDouble(this.trackBar1b.Value) / 1000.0;
                this.textBox1b.Text = Convert.ToString(this.beta1);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        // #2 fixedAlpha parameter changes
        private void textBox2a_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox2a.Text); }
            catch { }
            if (val != this.alpha2)
            {
                this.alpha2 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 5000) tmp = 5000;
                else if (tmp < -5000) tmp = -5000;
                this.trackBar2a.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar2a_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox2a.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar2a.Value)
            {
                this.alpha2 = Convert.ToDouble(this.trackBar2a.Value) / 1000.0;
                this.textBox2a.Text = Convert.ToString(this.alpha2);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void textBox2b_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox2b.Text); }
            catch { }
            if (val != this.steps2)
            {
                this.steps2 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 1000) tmp = 1000;
                else if (tmp < 0) tmp = 0;
                this.trackBar2b.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar2b_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox2b.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar2b.Value)
            {
                this.steps2 = Convert.ToDouble(this.trackBar2b.Value) / 1000.0;
                this.textBox2b.Text = Convert.ToString(this.steps2);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        // #3 fixedBeta parameter changes
        private void textBox3a_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox3a.Text); }
            catch { }
            if (val != this.steps3)
            {
                this.steps3 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 1000) tmp = 1000;
                else if (tmp < 0) tmp = 0;
                this.trackBar3a.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar3a_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox3a.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar3a.Value)
            {
                this.steps3 = Convert.ToDouble(this.trackBar3a.Value) / 1000.0;
                this.textBox3a.Text = Convert.ToString(this.steps3);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void textBox3b_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox3b.Text); }
            catch { }
            if (val != this.beta3)
            {
                this.beta3 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 5000) tmp = 5000;
                else if (tmp < -5000) tmp = -5000;
                this.trackBar3b.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar3b_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox3b.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar3b.Value)
            {
                this.beta3 = Convert.ToDouble(this.trackBar3b.Value) / 1000.0;
                this.textBox3b.Text = Convert.ToString(this.beta3);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        // #4 alphaPlot parameter change
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox4.Text); }
            catch { }
            if (val != this.beta4)
            {
                this.beta4 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 5000) tmp = 5000;
                else if (tmp < -5000) tmp = -5000;
                this.trackBar4.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox4.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar4.Value)
            {
                this.beta4 = Convert.ToDouble(this.trackBar4.Value) / 1000.0;
                this.textBox4.Text = Convert.ToString(this.beta4);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        // #5 betaPlot parameter change
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox5.Text); }
            catch { }
            if (val != this.alpha5)
            {
                this.alpha5 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 5000) tmp = 5000;
                else if (tmp < -5000) tmp = -5000;
                this.trackBar5.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox5.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar5.Value)
            {
                this.alpha5 = Convert.ToDouble(this.trackBar5.Value) / 1000.0;
                this.textBox5.Text = Convert.ToString(this.alpha5);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

        // #6 doublePlot parameter change
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox6.Text); }
            catch { }
            if (val != this.beta6)
            {
                this.beta6 = val;
                int tmp = Convert.ToInt32(val * 1000);
                if (tmp > 5000) tmp = 5000;
                else if (tmp < -5000) tmp = -5000;
                this.trackBar6.Value = tmp;
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            double val = 0;
            try { val = Convert.ToDouble(this.textBox6.Text); }
            catch { }
            if (Convert.ToInt32(val * 1000) != this.trackBar6.Value)
            {
                this.beta6 = Convert.ToDouble(this.trackBar6.Value) / 1000.0;
                this.textBox6.Text = Convert.ToString(this.beta6);
            }
            tabControl1_SelectedIndexChanged(sender, e);
        }

    }
}
