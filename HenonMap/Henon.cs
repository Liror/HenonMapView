using System;
using System.Text;

namespace HenonMap
{
    partial class frmMain
    {
        // Constants
        private const double DEFAULT_X = 0.01;
        private const double DEFAULT_Y = 0.0;
        private const double DEFAULT_ALPHA = 1.4;
        private const double DEFAULT_BETA = 0.3;
        private const double DEFAULT_STEP = 0.1;
        private const double POINT_SIZE = 1.0;
        private const int NUM_ITERATIONS = 11000;
        private const int LAST_DISPLAY = 10000;
        private const int NUM_ITERATIONS_BIFURCATION = 1100;
        private const int LAST_DISPLAY_BIFURCATION = 1000;
        private const double STEP_BIFURCATION = 0.001;

        // Variables
        private OxyPlot.Series.ScatterSeries scatterSeries1 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries2 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries3 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries4 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private OxyPlot.Series.ScatterSeries scatterSeries5 = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
        private double alpha1 = DEFAULT_ALPHA;
        private double beta1 = DEFAULT_BETA;
        private double alpha2 = DEFAULT_ALPHA;
        private double steps2 = DEFAULT_STEP;
        private double steps3 = DEFAULT_STEP;
        private double beta3 = DEFAULT_BETA;
        private double beta4 = DEFAULT_BETA;
        private double alpha5 = DEFAULT_ALPHA;

        // Initializers
        private void initDrawing()
        {
            // Initializer values
            this.scatterSeries1.TrackerFormatString += "\nIteration: {Tag}";
            this.scatterSeries2.TrackerFormatString += "\nIteration: {Tag}";
            this.scatterSeries3.TrackerFormatString += "\nIteration: {Tag}";
            this.scatterSeries4.TrackerFormatString += "\nIteration: {Tag}";
            this.scatterSeries5.TrackerFormatString += "\nIteration: {Tag}";
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

            // Initialize axis
            var customAxis1 = new OxyPlot.Axes.RangeColorAxis { Key = "customColorsARGB1" };
            customAxis1.AddRange(0.0, 1.5, OxyPlot.OxyColor.FromArgb(8, 255, 0, 0));
            customAxis1.AddRange(1.5, 2.5, OxyPlot.OxyColor.FromArgb(8, 0, 255, 0));
            var customAxis2 = new OxyPlot.Axes.RangeColorAxis { Key = "customColorsARGB2" };
            customAxis2.AddRange(0.0, 1.5, OxyPlot.OxyColor.FromArgb(8, 255, 0, 0));
            customAxis2.AddRange(1.5, 2.5, OxyPlot.OxyColor.FromArgb(8, 0, 255, 0));
            this.plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -0.7, Maximum = 0.7, Title = "y" });
            this.plotView2.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView2.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -0.7, Maximum = 0.7, Title = "y" });
            this.plotView2.Model.Axes.Add(new OxyPlot.Axes.LinearColorAxis { Title = "beta", Position = OxyPlot.Axes.AxisPosition.Right, Palette = OxyPlot.OxyPalettes.Jet(1000), Minimum = 0.0, Maximum = 2.0 });
            this.plotView3.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView3.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -0.7, Maximum = 0.7, Title = "y" });
            this.plotView3.Model.Axes.Add(new OxyPlot.Axes.LinearColorAxis { Title = "alpha", Position = OxyPlot.Axes.AxisPosition.Right, Palette = OxyPlot.OxyPalettes.Jet(1000), Minimum = 0.0, Maximum = 2.0 });
            this.plotView4.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = 0.0, Maximum = 1.5, Title = "alpha" });
            this.plotView4.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView4.Model.Axes.Add(customAxis1);
            this.plotView5.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -1.0, Maximum = 0.5, Title = "beta" });
            this.plotView5.Model.Axes.Add(new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Left, Minimum = -1.5, Maximum = 1.5, Title = "x" });
            this.plotView5.Model.Axes.Add(customAxis2);
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

            // Iteration
            for (int i = 0; i < NUM_ITERATIONS; ++i)
            {
                // Henon function
                double x_new = 1.0 - alpha * x * x + y;
                y = beta * x;
                x = x_new;

                // Add point to plot
                double size = POINT_SIZE;
                double colorValue = 100.0;
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
            for (double beta = 0.0; beta < 2.0; beta += this.steps2)
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
                    if (i > NUM_ITERATIONS - LAST_DISPLAY)
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
                    if (i > NUM_ITERATIONS - LAST_DISPLAY)
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
                    if (i > NUM_ITERATIONS_BIFURCATION - LAST_DISPLAY_BIFURCATION && !(x>10 || x<-10))
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

    }
}

// Oxyplot Scatter Series
// https://oxyplot.readthedocs.io/en/latest/models/series/ScatterSeries.html

// Oxyplot coloring!
// https://stackoverflow.com/questions/44192118/custom-color-range-with-oxyplot-scatterplot

/***
#doublePlot -> X-param und Y-param Plots nebeneinander für (normales) Bifurkationsdiagramm gegen alpha (beta über Regler)
#1Diteration -> Nur X-Plot gegen n (Widerholungen) = Vereinfachung ohne Y = 'Periodendiagramm'
#1Dalpha -> Nur X-Plot gegen alpha (beta über Regler) = Vereinfachung ohne Y = Bifurcation Diagram for alpha (Color with ARGB) -> Periodenanalyse für verschiedene Farben?
***/
