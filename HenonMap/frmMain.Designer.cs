namespace HenonMap
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trackBar1a = new System.Windows.Forms.TrackBar();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.trackBar1b = new System.Windows.Forms.TrackBar();
            this.label1a = new System.Windows.Forms.Label();
            this.label1b = new System.Windows.Forms.Label();
            this.textBox1a = new System.Windows.Forms.TextBox();
            this.textBox1b = new System.Windows.Forms.TextBox();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.textBox2b = new System.Windows.Forms.TextBox();
            this.textBox2a = new System.Windows.Forms.TextBox();
            this.label2b = new System.Windows.Forms.Label();
            this.label2a = new System.Windows.Forms.Label();
            this.trackBar2b = new System.Windows.Forms.TrackBar();
            this.trackBar2a = new System.Windows.Forms.TrackBar();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            this.textBox3b = new System.Windows.Forms.TextBox();
            this.textBox3a = new System.Windows.Forms.TextBox();
            this.label3b = new System.Windows.Forms.Label();
            this.label3a = new System.Windows.Forms.Label();
            this.trackBar3b = new System.Windows.Forms.TrackBar();
            this.trackBar3a = new System.Windows.Forms.TrackBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1a)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3a)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 682);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1b);
            this.tabPage1.Controls.Add(this.textBox1a);
            this.tabPage1.Controls.Add(this.label1b);
            this.tabPage1.Controls.Add(this.label1a);
            this.tabPage1.Controls.Add(this.trackBar1b);
            this.tabPage1.Controls.Add(this.trackBar1a);
            this.tabPage1.Controls.Add(this.plotView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Default Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // trackBar1a
            // 
            this.trackBar1a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1a.LargeChange = 100;
            this.trackBar1a.Location = new System.Drawing.Point(70, 566);
            this.trackBar1a.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1a.Maximum = 5000;
            this.trackBar1a.Minimum = -5000;
            this.trackBar1a.Name = "trackBar1a";
            this.trackBar1a.Size = new System.Drawing.Size(1049, 45);
            this.trackBar1a.TabIndex = 1;
            this.trackBar1a.ValueChanged += new System.EventHandler(this.trackBar1a_ValueChanged);
            // 
            // plotView1
            // 
            this.plotView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Margin = new System.Windows.Forms.Padding(0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(1256, 566);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2b);
            this.tabPage2.Controls.Add(this.textBox2a);
            this.tabPage2.Controls.Add(this.label2b);
            this.tabPage2.Controls.Add(this.label2a);
            this.tabPage2.Controls.Add(this.trackBar2b);
            this.tabPage2.Controls.Add(this.trackBar2a);
            this.tabPage2.Controls.Add(this.plotView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fixed Alpha";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3b);
            this.tabPage3.Controls.Add(this.textBox3a);
            this.tabPage3.Controls.Add(this.label3b);
            this.tabPage3.Controls.Add(this.label3a);
            this.tabPage3.Controls.Add(this.trackBar3b);
            this.tabPage3.Controls.Add(this.trackBar3a);
            this.tabPage3.Controls.Add(this.plotView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1256, 656);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fixed Beta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1256, 656);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Alpha Plot";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1256, 656);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Beta Plot";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1256, 656);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Double Plot";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1256, 656);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "1D Iteration";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1256, 656);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "1D Alpha";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // trackBar1b
            // 
            this.trackBar1b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1b.LargeChange = 100;
            this.trackBar1b.Location = new System.Drawing.Point(70, 611);
            this.trackBar1b.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1b.Maximum = 5000;
            this.trackBar1b.Minimum = -5000;
            this.trackBar1b.Name = "trackBar1b";
            this.trackBar1b.Size = new System.Drawing.Size(1049, 45);
            this.trackBar1b.TabIndex = 2;
            this.trackBar1b.ValueChanged += new System.EventHandler(this.trackBar1b_ValueChanged);
            // 
            // label1a
            // 
            this.label1a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1a.AutoSize = true;
            this.label1a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1a.Location = new System.Drawing.Point(3, 566);
            this.label1a.Name = "label1a";
            this.label1a.Size = new System.Drawing.Size(59, 24);
            this.label1a.TabIndex = 3;
            this.label1a.Text = "Alpha";
            // 
            // label1b
            // 
            this.label1b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1b.AutoSize = true;
            this.label1b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1b.Location = new System.Drawing.Point(6, 611);
            this.label1b.Name = "label1b";
            this.label1b.Size = new System.Drawing.Size(47, 24);
            this.label1b.TabIndex = 4;
            this.label1b.Text = "Beta";
            // 
            // textBox1a
            // 
            this.textBox1a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1a.Location = new System.Drawing.Point(1122, 566);
            this.textBox1a.Name = "textBox1a";
            this.textBox1a.Size = new System.Drawing.Size(131, 26);
            this.textBox1a.TabIndex = 5;
            this.textBox1a.TextChanged += new System.EventHandler(this.textBox1a_TextChanged);
            // 
            // textBox1b
            // 
            this.textBox1b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1b.Location = new System.Drawing.Point(1122, 611);
            this.textBox1b.Name = "textBox1b";
            this.textBox1b.Size = new System.Drawing.Size(131, 26);
            this.textBox1b.TabIndex = 6;
            this.textBox1b.TextChanged += new System.EventHandler(this.textBox1b_TextChanged);
            // 
            // plotView2
            // 
            this.plotView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView2.Location = new System.Drawing.Point(0, 0);
            this.plotView2.Margin = new System.Windows.Forms.Padding(0);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(1256, 566);
            this.plotView2.TabIndex = 0;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBox2b
            // 
            this.textBox2b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2b.Location = new System.Drawing.Point(1122, 611);
            this.textBox2b.Name = "textBox2b";
            this.textBox2b.Size = new System.Drawing.Size(131, 26);
            this.textBox2b.TabIndex = 12;
            this.textBox2b.TextChanged += new System.EventHandler(this.textBox2b_TextChanged);
            // 
            // textBox2a
            // 
            this.textBox2a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2a.Location = new System.Drawing.Point(1122, 566);
            this.textBox2a.Name = "textBox2a";
            this.textBox2a.Size = new System.Drawing.Size(131, 26);
            this.textBox2a.TabIndex = 11;
            this.textBox2a.TextChanged += new System.EventHandler(this.textBox2a_TextChanged);
            // 
            // label2b
            // 
            this.label2b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2b.AutoSize = true;
            this.label2b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2b.Location = new System.Drawing.Point(6, 611);
            this.label2b.Name = "label2b";
            this.label2b.Size = new System.Drawing.Size(57, 24);
            this.label2b.TabIndex = 10;
            this.label2b.Text = "Steps";
            // 
            // label2a
            // 
            this.label2a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2a.AutoSize = true;
            this.label2a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2a.Location = new System.Drawing.Point(3, 566);
            this.label2a.Name = "label2a";
            this.label2a.Size = new System.Drawing.Size(59, 24);
            this.label2a.TabIndex = 9;
            this.label2a.Text = "Alpha";
            // 
            // trackBar2b
            // 
            this.trackBar2b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2b.LargeChange = 100;
            this.trackBar2b.Location = new System.Drawing.Point(70, 611);
            this.trackBar2b.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar2b.Maximum = 1000;
            this.trackBar2b.Name = "trackBar2b";
            this.trackBar2b.Size = new System.Drawing.Size(1049, 45);
            this.trackBar2b.TabIndex = 8;
            this.trackBar2b.ValueChanged += new System.EventHandler(this.trackBar2b_ValueChanged);
            // 
            // trackBar2a
            // 
            this.trackBar2a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2a.LargeChange = 100;
            this.trackBar2a.Location = new System.Drawing.Point(70, 566);
            this.trackBar2a.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar2a.Maximum = 5000;
            this.trackBar2a.Minimum = -5000;
            this.trackBar2a.Name = "trackBar2a";
            this.trackBar2a.Size = new System.Drawing.Size(1049, 45);
            this.trackBar2a.TabIndex = 7;
            this.trackBar2a.ValueChanged += new System.EventHandler(this.trackBar2a_ValueChanged);
            // 
            // plotView3
            // 
            this.plotView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView3.Location = new System.Drawing.Point(0, 0);
            this.plotView3.Margin = new System.Windows.Forms.Padding(0);
            this.plotView3.Name = "plotView3";
            this.plotView3.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView3.Size = new System.Drawing.Size(1256, 566);
            this.plotView3.TabIndex = 0;
            this.plotView3.Text = "plotView3";
            this.plotView3.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView3.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView3.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBox3b
            // 
            this.textBox3b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3b.Location = new System.Drawing.Point(1122, 611);
            this.textBox3b.Name = "textBox3b";
            this.textBox3b.Size = new System.Drawing.Size(131, 26);
            this.textBox3b.TabIndex = 18;
            this.textBox3b.TextChanged += new System.EventHandler(this.textBox3b_TextChanged);
            // 
            // textBox3a
            // 
            this.textBox3a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3a.Location = new System.Drawing.Point(1122, 566);
            this.textBox3a.Name = "textBox3a";
            this.textBox3a.Size = new System.Drawing.Size(131, 26);
            this.textBox3a.TabIndex = 17;
            this.textBox3a.TextChanged += new System.EventHandler(this.textBox3a_TextChanged);
            // 
            // label3b
            // 
            this.label3b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3b.AutoSize = true;
            this.label3b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3b.Location = new System.Drawing.Point(6, 611);
            this.label3b.Name = "label3b";
            this.label3b.Size = new System.Drawing.Size(47, 24);
            this.label3b.TabIndex = 16;
            this.label3b.Text = "Beta";
            // 
            // label3a
            // 
            this.label3a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3a.AutoSize = true;
            this.label3a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3a.Location = new System.Drawing.Point(3, 566);
            this.label3a.Name = "label3a";
            this.label3a.Size = new System.Drawing.Size(57, 24);
            this.label3a.TabIndex = 15;
            this.label3a.Text = "Steps";
            // 
            // trackBar3b
            // 
            this.trackBar3b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3b.LargeChange = 100;
            this.trackBar3b.Location = new System.Drawing.Point(70, 611);
            this.trackBar3b.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar3b.Maximum = 5000;
            this.trackBar3b.Minimum = -5000;
            this.trackBar3b.Name = "trackBar3b";
            this.trackBar3b.Size = new System.Drawing.Size(1049, 45);
            this.trackBar3b.TabIndex = 14;
            this.trackBar3b.ValueChanged += new System.EventHandler(this.trackBar3b_ValueChanged);
            // 
            // trackBar3a
            // 
            this.trackBar3a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3a.LargeChange = 100;
            this.trackBar3a.Location = new System.Drawing.Point(70, 566);
            this.trackBar3a.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar3a.Maximum = 1000;
            this.trackBar3a.Name = "trackBar3a";
            this.trackBar3a.Size = new System.Drawing.Size(1049, 45);
            this.trackBar3a.TabIndex = 13;
            this.trackBar3a.ValueChanged += new System.EventHandler(this.trackBar3a_ValueChanged);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "frmMain";
            this.Text = "Hénon Map";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1a)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3a)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TrackBar trackBar1a;
        private System.Windows.Forms.TrackBar trackBar1b;
        private System.Windows.Forms.TextBox textBox1b;
        private System.Windows.Forms.TextBox textBox1a;
        private System.Windows.Forms.Label label1b;
        private System.Windows.Forms.Label label1a;
        private System.Windows.Forms.TextBox textBox2b;
        private System.Windows.Forms.TextBox textBox2a;
        private System.Windows.Forms.Label label2b;
        private System.Windows.Forms.Label label2a;
        private System.Windows.Forms.TrackBar trackBar2b;
        private System.Windows.Forms.TrackBar trackBar2a;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.Windows.Forms.TextBox textBox3b;
        private System.Windows.Forms.TextBox textBox3a;
        private System.Windows.Forms.Label label3b;
        private System.Windows.Forms.Label label3a;
        private System.Windows.Forms.TrackBar trackBar3b;
        private System.Windows.Forms.TrackBar trackBar3a;
        private OxyPlot.WindowsForms.PlotView plotView3;

    }
}
