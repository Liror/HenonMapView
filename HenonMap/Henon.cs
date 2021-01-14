using System;
using System.Text;
using System.Collections.Generic;

namespace HenonMap
{
    partial class frmMain
    {
        // Special point for period search
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            public bool Compare(Point other)
            {
                if (this.X + COMP_RANGE > other.X && this.X - COMP_RANGE < other.X)
                {
                    if (this.Y + COMP_RANGE > other.Y && this.Y - COMP_RANGE < other.Y)
                        return true;
                }
                return false;
            }
        }

        // Fixed point calculation
        // src: http://www.cmsim.eu/papers_pdf/october_2013_papers/5_CMSIM-Journal_2013_Aybar_etal_4_529-538.pdf
        private Point UnstableFixedPoint(double alpha, double beta)
        {
            double tmp = Math.Sqrt(4 * alpha + (beta - 1) * (beta - 1));
            Point pt = new Point();
            pt.X = (beta - 1 - tmp) / (2 * alpha);
            pt.Y = beta * (beta - 1 - tmp) / (2 * alpha);
            return pt;
        }
        private Point StableFixedPoint(double alpha, double beta)
        {
            double tmp = Math.Sqrt(4 * alpha + (beta - 1) * (beta - 1));
            Point pt = new Point();
            pt.X = (beta - 1 + tmp) / (2 * alpha);
            pt.Y = beta * (beta - 1 + tmp) / (2 * alpha);
            return pt;
        }

        // Constants
        private const double DEFAULT_X = 0.01;
        private const double DEFAULT_Y = 0.0;
        private const double DEFAULT_ALPHA = 1.4;
        private const double DEFAULT_BETA = 0.3;
        private const double DEFAULT_STEP = 0.1;
        private const double POINT_SIZE = 1.0;
        private const double COMP_RANGE = 0.000001;
        private const int NUM_ITERATIONS = 11000;
        private const int LAST_DISPLAY = 10000;
        private const int NUM_ITERATIONS_BIFURCATION = 1100;
        private const int LAST_DISPLAY_BIFURCATION = 1000;
        private const double STEP_BIFURCATION = 0.001;
        private const int PURE_ITERATIONS = 1000;
        private const int MAX_PERIOD = 100;
        private const double DEFAULT_HEATMAP_STEP = 0.002;
        private const double DEFAULT_STARTINGMAP_STEP = 0.02;
        private const double DEFAULT_DISTANCE_FIXPOINT = 0.01;

        // Variables
        private bool showFixedPoints = true;
        private OxyPlot.Series.ScatterSeries scatterSeries1 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries2 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries3 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries4 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries5 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries6x = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries6y = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries7 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries8 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries9 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private double alpha1 = DEFAULT_ALPHA;
        private double beta1 = DEFAULT_BETA;
        private double alpha2 = DEFAULT_ALPHA;
        private double steps2 = DEFAULT_STEP;
        private double steps3 = DEFAULT_STEP;
        private double beta3 = DEFAULT_BETA;
        private double beta4 = DEFAULT_BETA;
        private double alpha5 = DEFAULT_ALPHA;
        private double beta6 = DEFAULT_BETA;
        private double alpha7 = DEFAULT_ALPHA;
        private double beta7 = DEFAULT_BETA;
        private double steps8 = DEFAULT_HEATMAP_STEP;
        private double alpha9 = DEFAULT_ALPHA;
        private double beta9 = DEFAULT_BETA;
        private double steps9 = DEFAULT_STARTINGMAP_STEP;

        // Initializers
        private void initDrawing()
        {
            // Initializer values
            this.scatterSeries1.TrackerFormatString += "\niteration: {Tag}";
            this.scatterSeries2.TrackerFormatString += "\niteration: {Tag}";
            this.scatterSeries3.TrackerFormatString += "\niteration: {Tag}";
            this.scatterSeries4.TrackerFormatString += "\niteration: {Tag}";
            this.scatterSeries5.TrackerFormatString += "\niteration: {Tag}";
            this.scatterSeries6x.TrackerFormatString += "\niteration: {Tag}";
            this.scatterSeries6y.TrackerFormatString += "\niteration: {Tag}";
            this.scatterSeries7.TrackerFormatString += "\ny: {Tag}";
            this.scatterSeries8.TrackerFormatString += "\nperiod: {Tag}";
            this.scatterSeries9.TrackerFormatString += "\nperiod: {Tag}";
            this.textBox1a.Text = Convert.ToString(this.alpha1);
            this.textBox1b.Text = Convert.ToString(this.beta1);
            this.trackBar1a.Value = Convert.ToInt32(this.alpha1 * 1000);
            this.trackBar1b.Value = Convert.ToInt32(this.beta1 * 1000);
            this.textBox2a.Text = Convert.ToString(this.alpha2);
            this.textBox2b.Text = Convert.ToString(this.steps2);
            this.trackBar2a.Value = Convert.ToInt32(this.alpha2 * 1000);
            this.trackBar2b.Value = Convert.ToInt32(this.steps2 * 1000);
            this.textBox3a.Text = Convert.ToString(this.steps3);
            this.textBox3b.Text = Convert.ToString(this.beta3);
            this.trackBar3a.Value = Convert.ToInt32(this.steps3 * 1000);
            this.trackBar3b.Value = Convert.ToInt32(this.beta3 * 1000);
            this.textBox4.Text = Convert.ToString(this.beta4);
            this.trackBar4.Value = Convert.ToInt32(this.beta4 * 1000);
            this.textBox5.Text = Convert.ToString(this.alpha5);
            this.trackBar5.Value = Convert.ToInt32(this.alpha5 * 1000);
            this.textBox6.Text = Convert.ToString(this.beta6);
            this.trackBar6.Value = Convert.ToInt32(this.beta6 * 1000);
            this.textBox7a.Text = Convert.ToString(this.alpha7);
            this.textBox7b.Text = Convert.ToString(this.beta7);
            this.trackBar7a.Value = Convert.ToInt32(this.alpha7 * 1000);
            this.trackBar7b.Value = Convert.ToInt32(this.beta7 * 1000);
            this.textBox9a.Text = Convert.ToString(this.alpha9);
            this.textBox9b.Text = Convert.ToString(this.beta9);
            this.trackBar9a.Value = Convert.ToInt32(this.alpha9 * 1000);
            this.trackBar9b.Value = Convert.ToInt32(this.beta9 * 1000);

            // Initialize colors
            this.plotView7.Model.DefaultColors = new List<OxyPlot.OxyColor> { OxyPlot.OxyColors.Purple, };

            // Initialize axis
            var axisTwo = new OxyPlot.Axes.RangeColorAxis { Key = "customColorsPB" };
            axisTwo.AddRange(0.0, 1.5, OxyPlot.OxyColors.Purple);
            axisTwo.AddRange(1.5, 3.5, OxyPlot.OxyColors.Black);
            var customAxis1 = new OxyPlot.Axes.RangeColorAxis { Key = "customColorsARGB1" };
            customAxis1.AddRange(0.0, 1.5, OxyPlot.OxyColor.FromArgb(8, 255, 0, 0));
            customAxis1.AddRange(1.5, 2.5, OxyPlot.OxyColor.FromArgb(8, 0, 255, 0));
            customAxis1.AddRange(2.5, 3.5, OxyPlot.OxyColors.Black);
            var customAxis2 = new OxyPlot.Axes.RangeColorAxis { Key = "customColorsARGB2" };
            customAxis2.AddRange(0.0, 1.5, OxyPlot.OxyColor.FromArgb(8, 255, 0, 0));
            customAxis2.AddRange(1.5, 2.5, OxyPlot.OxyColor.FromArgb(8, 0, 255, 0));
            customAxis2.AddRange(2.5, 3.5, OxyPlot.OxyColors.Black);
            var customAxis3 = new OxyPlot.Axes.RangeColorAxis { Key = "customColorsARGB3" };
            customAxis3.AddRange(0.0, 1.5, OxyPlot.OxyColor.FromArgb(8, 255, 0, 0));
            customAxis3.AddRange(1.5, 2.5, OxyPlot.OxyColor.FromArgb(8, 0, 255, 0));
            var customAxis4 = new OxyPlot.Axes.RangeColorAxis { Key = "customColorsARGB4" };
            customAxis4.AddRange(0.0, 1.5, OxyPlot.OxyColor.FromArgb(8, 255, 0, 0));
            customAxis4.AddRange(1.5, 2.5, OxyPlot.OxyColor.FromArgb(8, 0, 255, 0));
            this.plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -0.7, Maximum = 0.7, Title = "y" });
            this.plotView1.Model.Axes.Add(axisTwo);
            this.plotView2.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView2.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -0.7, Maximum = 0.7, Title = "y" });
            this.plotView2.Model.Axes.Add(new OxyPlot.Axes.LinearColorAxis { Title = "beta", Position = OxyPlot.Axes.AxisPosition.Right, Palette = OxyPlot.OxyPalettes.Jet(1000), Minimum = -1.0, Maximum = 1.0 });
            this.plotView3.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView3.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -0.7, Maximum = 0.7, Title = "y" });
            this.plotView3.Model.Axes.Add(new OxyPlot.Axes.LinearColorAxis { Title = "alpha", Position = OxyPlot.Axes.AxisPosition.Right, Palette = OxyPlot.OxyPalettes.Jet(1000), Minimum = 0.0, Maximum = 2.0 });
            this.plotView4.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0.0, Maximum = 2.0, Title = "alpha" });
            this.plotView4.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView4.Model.Axes.Add(customAxis1);
            this.plotView5.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.0, Maximum = 1.0, Title = "beta" });
            this.plotView5.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView5.Model.Axes.Add(customAxis2);
            this.plotView6x.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0.0, Maximum = 1.5, Title = "alpha" });
            this.plotView6x.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView6x.Model.Axes.Add(customAxis3);
            this.plotView6y.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0.0, Maximum = 1.5, Title = "alpha" });
            this.plotView6y.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -0.5, Maximum = 0.5, Title = "y" });
            this.plotView6y.Model.Axes.Add(customAxis4);
            this.plotView7.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0, AbsoluteMinimum = 0, Maximum = PURE_ITERATIONS, AbsoluteMaximum = PURE_ITERATIONS, Title = "n iterations" });
            this.plotView7.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView8.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.0, Maximum = 2.5, Title = "alpha" });
            this.plotView8.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -1.2, Maximum = 1.2, Title = "beta" });
            this.plotView8.Model.Axes.Add(new OxyPlot.Axes.LinearColorAxis { Title = "period", Position = OxyPlot.Axes.AxisPosition.Right, Palette = OxyPlot.OxyPalettes.Jet(101), Minimum = 0.0, Maximum = 100.0 });
            this.plotView9.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -5.0, Maximum = 5.0, Title = "x" });
            this.plotView9.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -3.0, Maximum = 5.0, Title = "y" });
            this.plotView9.Model.Axes.Add(new OxyPlot.Axes.LinearColorAxis { Title = "period", Position = OxyPlot.Axes.AxisPosition.Right, Palette = OxyPlot.OxyPalettes.Jet(101), Minimum = 0.0, Maximum = 100.0, LowColor = OxyPlot.OxyColors.Black });
        }

        // #1 default Map
        // defaultMap -> Standardplot with default parameters (adjustable)
        private void drawDefaultMap()
        {
            // Clear old data
            this.scatterSeries1.Points.Clear();
            this.plotView1.Model.Series.Clear();

            // Initialize data
            double x = DEFAULT_X;
            double y = DEFAULT_Y;
            double alpha = this.alpha1;
            double beta = this.beta1;

            // Fixed Points
            if (this.showFixedPoints)
            {
                double size = POINT_SIZE > 3.0 ? POINT_SIZE : 3.0;
                double colorValue = 3.0;
                Point pt = this.UnstableFixedPoint(alpha, beta);
                this.scatterSeries1.Points.Add(new OxyPlot.Series.ScatterPoint(pt.X, pt.Y, size, colorValue, "Fixed Point"));
                pt = this.StableFixedPoint(alpha, beta);
                this.scatterSeries1.Points.Add(new OxyPlot.Series.ScatterPoint(pt.X, pt.Y, size, colorValue, "Fixed Point"));
                x = pt.X + DEFAULT_DISTANCE_FIXPOINT;
                y = pt.Y + DEFAULT_DISTANCE_FIXPOINT;
            }

            // Iteration
            for (int i = 0; i < NUM_ITERATIONS; ++i)
            {
                // Henon function
                double x_new = 1.0 - alpha * x * x + y;
                y = beta * x;
                x = x_new;

                // Add point to plot
                double size = POINT_SIZE;
                double colorValue = 1.0;
                if (i > NUM_ITERATIONS - LAST_DISPLAY)
                {
                    OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(x, y, size, colorValue, i);
                    this.scatterSeries1.Points.Add(pt);
                }
            }

            // Add series to plot
            this.plotView1.Model.Series.Add(this.scatterSeries1);
            this.plotView1.Refresh();
        }

        // #2 multiple beta Map
        // fixedAlpha -> X-Y Diagram with colored beta graphs (alpha adjustable)
        private void drawFixedAlpha()
        {
            // Clear old data
            this.scatterSeries2.Points.Clear();
            this.plotView2.Model.Series.Clear();

            // Outer iteration multiple beta
            if (this.steps2 <= 0.0)
                this.steps2 = 0.01;
            for (double beta = -1.0; beta < 1.0; beta += this.steps2)
            {
                // Initialize data
                double alpha = this.alpha2;
                double x = DEFAULT_X;
                double y = DEFAULT_Y;

                // Iteration
                for (int i = 0; i < NUM_ITERATIONS; ++i)
                {
                    // Henon function
                    double x_new = 1.0 - alpha * x * x + y;
                    y = beta * x;
                    x = x_new;

                    // Add point to plot
                    double size = POINT_SIZE;
                    if (i > NUM_ITERATIONS - LAST_DISPLAY && !(x > 10 || x < -10))
                    {
                        OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(x, y, size, beta, i);
                        this.scatterSeries2.Points.Add(pt);
                    }
                }
            }

            // Add series to plot
            this.plotView2.Model.Series.Add(this.scatterSeries2);
            this.plotView2.Model.Axes[0].Reset();
            this.plotView2.Refresh();
        }

        // #3 multiple alpha Map
        // fixedBeta -> X-Y Diagram with colored alpha graphs (beta adjustable)
        private void drawFixedBeta()
        {
            // Clear old data
            this.scatterSeries3.Points.Clear();
            this.plotView3.Model.Series.Clear();

            // Outer iteration multiple beta
            if (this.steps3 <= 0.0)
                this.steps3 = 0.01;
            for (double alpha = 0.0; alpha < 2.0; alpha += this.steps3)
            {
                // Initialize data
                double beta = this.beta3;
                double x = DEFAULT_X;
                double y = DEFAULT_Y;

                // Iteration
                for (int i = 0; i < NUM_ITERATIONS; ++i)
                {
                    // Henon function
                    double x_new = 1.0 - alpha * x * x + y;
                    y = beta * x;
                    x = x_new;

                    // Add point to plot
                    double size = POINT_SIZE;
                    if (i > NUM_ITERATIONS - LAST_DISPLAY && !(x > 10 || x < -10))
                    {
                        OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(x, y, size, alpha, i);
                        this.scatterSeries3.Points.Add(pt);
                    }
                }
            }

            // Add series to plot
            this.plotView3.Model.Series.Add(this.scatterSeries3);
            this.plotView3.Refresh();
        }

        // #4 alpha plot Map
        // alphaPlot -> X and alpha in axis = Bifurcation diagram for alpha (Color with ARGB)
        private void drawAlphaPlot()
        {
            // Clear old data
            this.scatterSeries4.Points.Clear();
            this.plotView4.Model.Series.Clear();

            // Outer iteration multiple beta
            for (double alpha = -5.0; alpha < 5.0; alpha += STEP_BIFURCATION)
            {
                // Initialize data
                double beta = this.beta4;
                double x = DEFAULT_X;
                double y = DEFAULT_Y;

                // Fixed Points
                if (this.showFixedPoints)
                {
                    double size = POINT_SIZE;
                    double colorValue = 3.0;
                    Point pt = this.UnstableFixedPoint(alpha, beta);
                    this.scatterSeries4.Points.Add(new OxyPlot.Series.ScatterPoint(alpha, pt.X, size, colorValue, "Fixed Point"));
                    pt = this.StableFixedPoint(alpha, beta);
                    this.scatterSeries4.Points.Add(new OxyPlot.Series.ScatterPoint(alpha, pt.X, size, colorValue, "Fixed Point"));
                    x = pt.X + DEFAULT_DISTANCE_FIXPOINT;
                    y = pt.Y + DEFAULT_DISTANCE_FIXPOINT;
                }

                // Iteration
                for (int i = 0; i < NUM_ITERATIONS_BIFURCATION; ++i)
                {
                    // Henon function
                    double x_new = 1.0 - alpha * x * x + y;
                    y = beta * x;
                    x = x_new;

                    // Add point to plot
                    double size = POINT_SIZE;
                    double colorValue = 1.0;
                    if (i > NUM_ITERATIONS_BIFURCATION - LAST_DISPLAY_BIFURCATION && !(x > 10 || x < -10))
                    {
                        OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(alpha, x, size, colorValue, i);
                        this.scatterSeries4.Points.Add(pt);
                    }
                }
            }

            // Add series to plot
            this.plotView4.Model.Series.Add(this.scatterSeries4);
            this.plotView4.Refresh();
        }

        // #5 beta plot Map
        // betaPlot -> X and beta in axis = Bifurcation diagram for beta (Color with ARGB)
        private void drawBetaPlot()
        {
            // Clear old data
            this.scatterSeries5.Points.Clear();
            this.plotView5.Model.Series.Clear();

            // Outer iteration multiple beta
            for (double beta = -5.0; beta < 5.0; beta += STEP_BIFURCATION)
            {
                // Initialize data
                double alpha = this.alpha5;
                double x = DEFAULT_X;
                double y = DEFAULT_Y;

                // Fixed Points
                if (this.showFixedPoints)
                {
                    double size = POINT_SIZE;
                    double colorValue = 3.0;
                    Point pt = this.UnstableFixedPoint(alpha, beta);
                    this.scatterSeries5.Points.Add(new OxyPlot.Series.ScatterPoint(beta, pt.X, size, colorValue, "Fixed Point"));
                    pt = this.StableFixedPoint(alpha, beta);
                    this.scatterSeries5.Points.Add(new OxyPlot.Series.ScatterPoint(beta, pt.X, size, colorValue, "Fixed Point"));
                    x = pt.X + DEFAULT_DISTANCE_FIXPOINT;
                    y = pt.Y + DEFAULT_DISTANCE_FIXPOINT;
                }

                // Iteration
                for (int i = 0; i < NUM_ITERATIONS_BIFURCATION; ++i)
                {
                    // Henon function
                    double x_new = 1.0 - alpha * x * x + y;
                    y = beta * x;
                    x = x_new;

                    // Add point to plot
                    double size = POINT_SIZE;
                    double colorValue = 1.0;
                    if (i > NUM_ITERATIONS_BIFURCATION - LAST_DISPLAY_BIFURCATION && !(x > 10 || x < -10))
                    {
                        OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(beta, x, size, colorValue, i);
                        this.scatterSeries5.Points.Add(pt);
                    }
                }
            }

            // Add series to plot
            this.plotView5.Model.Series.Add(this.scatterSeries5);
            this.plotView5.Refresh();
        }

        // #6 double plot Map
        // doublePlot -> X-param and Y-param plots side-by-side for bifurcation diagram of alpha (Color with ARGB)
        private void drawDouble()
        {
            // Clear old data
            this.scatterSeries6x.Points.Clear();
            this.scatterSeries6y.Points.Clear();
            this.plotView6x.Model.Series.Clear();
            this.plotView6y.Model.Series.Clear();

            // Outer iteration multiple beta
            for (double alpha = -5.0; alpha < 5.0; alpha += STEP_BIFURCATION)
            {
                // Initialize data
                double beta = this.beta6;
                double x = DEFAULT_X;
                double y = DEFAULT_Y;

                // Iteration
                for (int i = 0; i < NUM_ITERATIONS_BIFURCATION; ++i)
                {
                    // Henon function
                    double x_new = 1.0 - alpha * x * x + y;
                    y = beta * x;
                    x = x_new;

                    // Add point to plot
                    double size = POINT_SIZE;
                    double colorValue = 1.0;
                    if (i > NUM_ITERATIONS_BIFURCATION - LAST_DISPLAY_BIFURCATION)
                    {
                        if (!(x > 10 || x < -10))
                        {
                            OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(alpha, x, size, colorValue, i);
                            this.scatterSeries6x.Points.Add(pt);
                        }
                        if (!(y > 10 || y < -10))
                        {
                            OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(alpha, y, size, colorValue, i);
                            this.scatterSeries6y.Points.Add(pt);
                        }
                    }
                }
            }

            // Add series to plot
            this.plotView6x.Model.Series.Add(this.scatterSeries6x);
            this.plotView6y.Model.Series.Add(this.scatterSeries6y);
            this.plotView6x.Refresh();
            this.plotView6y.Refresh();
        }

        // #7 1D oteration periodic Map
        // 1Diteration -> x plot against n (period)
        private void drawIterationMap()
        {
            // Clear old data
            this.scatterSeries7.Points.Clear();
            this.plotView7.Model.Series.Clear();

            // Initialize data
            double x = DEFAULT_X;
            double y = DEFAULT_Y;
            double alpha = this.alpha7;
            double beta = this.beta7;

            // Iteration
            for (int i = 0; i < PURE_ITERATIONS; ++i)
            {
                // Henon function
                double x_new = 1.0 - alpha * x * x + y;
                y = beta * x;
                x = x_new;

                // Add point to plot
                double size = POINT_SIZE > 2.0 ? POINT_SIZE : 2.0;
                double colorValue = 100.0;
                OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(i, x, size, colorValue, y);
                this.scatterSeries7.Points.Add(pt);
            }

            // Add series to plot
            this.plotView7.Model.Series.Add(this.scatterSeries7);
            this.plotView7.Refresh();
        }

        // #8 Alpha-Beta Heatmap Map
        // heatMap -> plot the period as a color for all alpha & beta parameter values
        private void drawHeatMap()
        {
            // Clear old data
            this.scatterSeries8.Points.Clear();
            this.plotView8.Model.Series.Clear();

            // Alpha-Beta double iteration
            for (double alpha = -5.0; alpha <= 5.0; alpha += this.steps8)
            {
                for (double beta = -5.0; beta <= 5.0; beta += this.steps8)
                {
                    // Initialize data
                    double x = DEFAULT_X;
                    double y = DEFAULT_Y;
                    Point[] pt_list = new Point[LAST_DISPLAY_BIFURCATION];

                    // Fixed Points
                    if (this.showFixedPoints)
                    {
                        Point point = this.StableFixedPoint(alpha, beta);
                        x = point.X + DEFAULT_DISTANCE_FIXPOINT;
                        y = point.Y + DEFAULT_DISTANCE_FIXPOINT;
                    }
                    else
                    {
                        x = DEFAULT_X;
                        y = DEFAULT_Y;
                    }

                    // Iteration
                    for (int i = 0; i < NUM_ITERATIONS_BIFURCATION; ++i)
                    {
                        // Henon function
                        double x_new = 1.0 - alpha * x * x + y;
                        y = beta * x;
                        x = x_new;

                        // Save points for period analysis
                        if (i >= NUM_ITERATIONS_BIFURCATION - LAST_DISPLAY_BIFURCATION)
                        {
                            Point p = new Point { X = x, Y = y };
                            pt_list[i - NUM_ITERATIONS_BIFURCATION + LAST_DISPLAY_BIFURCATION] = p;
                        }
                        // Shortcut for escaped points
                        if (x > 10 || x < -10)
                            break;
                    }

                    // Shortcut for escaped points
                    if (x > 10 || x < -10)
                        continue;

                    // Find period (100 = no period found)
                    int period = 1;
                    try
                    {
                        for (; period < MAX_PERIOD; ++period)
                        {
                            bool found = true;
                            for (int j = 0; j < period; ++j)
                            {
                                for (int i = 0; i < 5; ++i)
                                {
                                    if (!pt_list[LAST_DISPLAY_BIFURCATION - i * period - j - 1].Compare(pt_list[LAST_DISPLAY_BIFURCATION - (i + 1) * period - j - 1]))
                                    {
                                        found = false;
                                        i = MAX_PERIOD;
                                    }
                                }
                                if (!found)
                                    j = period;
                            }
                            if (found)
                                break;
                        }
                    }
                    catch
                    {
                        period = MAX_PERIOD;
                    }

                    // Add point to plot (if not escaped)
                    double size = POINT_SIZE;
                    OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(alpha, beta, size, period, period);
                    this.scatterSeries8.Points.Add(pt);
                }
            }

            // Add series to plot
            this.plotView8.Model.Series.Add(this.scatterSeries8);
            this.plotView8.Refresh();
        }

        // #9 x-y Starting Point Heatmap Map
        // startingMap -> plot the period for given alpha and beta value for all possible starting points
        private void drawStartingMap()
        {
            // Clear old data
            this.scatterSeries9.Points.Clear();
            this.plotView9.Model.Series.Clear();

            // Fixed Points
            if (this.showFixedPoints)
            {
                double size = POINT_SIZE > 3.0 ? POINT_SIZE : 3.0;
                double colorValue = -10.0;
                Point pt = this.UnstableFixedPoint(this.alpha9, this.beta9);
                this.scatterSeries9.Points.Add(new OxyPlot.Series.ScatterPoint(pt.X, pt.Y, size, colorValue, "Fixed Point"));
                pt = this.StableFixedPoint(this.alpha9, this.beta9);
                this.scatterSeries9.Points.Add(new OxyPlot.Series.ScatterPoint(pt.X, pt.Y, size, colorValue, "Fixed Point"));
            }

            // X-Y double iteration
            for (double y_s = -5.0; y_s <= 5.0; y_s += this.steps9)
            {
                for (double x_s = -5.0; x_s <= 5.0; x_s += this.steps9)
                {
                    // Initialize data
                    double x = x_s;
                    double y = y_s;
                    double alpha = this.alpha9;
                    double beta = this.beta9;
                    Point[] pt_list = new Point[LAST_DISPLAY_BIFURCATION];

                    // Iteration
                    for (int i = 0; i < NUM_ITERATIONS_BIFURCATION; ++i)
                    {
                        // Henon function
                        double x_new = 1.0 - alpha * x * x + y;
                        y = beta * x;
                        x = x_new;

                        // Save points for period analysis
                        if (i >= NUM_ITERATIONS_BIFURCATION - LAST_DISPLAY_BIFURCATION)
                        {
                            Point p = new Point { X = x, Y = y };
                            pt_list[i - NUM_ITERATIONS_BIFURCATION + LAST_DISPLAY_BIFURCATION] = p;
                        }
                        // Shortcut for escaped points
                        if (x > 10 || x < -10)
                            break;
                    }

                    // Shortcut for escaped points
                    if (x > 10 || x < -10)
                        continue;

                    // Find period (100 = no period found)
                    int period = 1;
                    try
                    {
                        for (; period < MAX_PERIOD; ++period)
                        {
                            bool found = true;
                            for (int j = 0; j < period; ++j)
                            {
                                for (int i = 0; i < 5; ++i)
                                {
                                    if (!pt_list[LAST_DISPLAY_BIFURCATION - i * period - j - 1].Compare(pt_list[LAST_DISPLAY_BIFURCATION - (i + 1) * period - j - 1]))
                                    {
                                        found = false;
                                        i = MAX_PERIOD;
                                    }
                                }
                                if (!found)
                                    j = period;
                            }
                            if (found)
                                break;
                        }
                    }
                    catch
                    {
                        period = MAX_PERIOD;
                    }

                    // Add point to plot (if not escaped)
                    double size = POINT_SIZE;
                    OxyPlot.Series.ScatterPoint pt = new OxyPlot.Series.ScatterPoint(x_s, y_s, size, period, period);
                    this.scatterSeries9.Points.Add(pt);
                }
            }

            // Add series to plot
            this.plotView9.Model.Series.Add(this.scatterSeries9);
            this.plotView9.Refresh();
        }

    }
}
