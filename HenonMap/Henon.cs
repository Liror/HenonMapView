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
    partial class frmMain
    {

        private void drawDefaultMap()
        {
            this.plotView1.Model.Series.Clear();


            var scatterSeries = new OxyPlot.Series.ScatterSeries { MarkerType = OxyPlot.MarkerType.Circle };
            scatterSeries.TrackerFormatString += "\nIteration: {Tag}";

            double x = 0.01;
            double y = 0;
            double alpha = 1.4; // 1.3
            double beta = 0.3;


            for (int i = 0; i < 10000; i++)
            {
                double x_new = 1.0 - alpha * x * x + y;
                y = beta * x;
                x = x_new;
                var size = 1;
                var colorValue = 100;
                if (i > 1000)
                {
                    var tmp = new OxyPlot.Series.ScatterPoint(x, y, size, colorValue);
                    tmp.Tag = i;
                    scatterSeries.Points.Add(tmp);
                }
            }

            this.plotView1.Model.Series.Add(scatterSeries);
            //this.plotView1.Model.Axes.Add(new OxyPlot.Axes.LinearColorAxis { Position = OxyPlot.Axes.AxisPosition.Right, Palette = OxyPlot.OxyPalettes.Jet(200) });
        }


    }
}

// Oxyplot Scatter Series
// https://oxyplot.readthedocs.io/en/latest/models/series/ScatterSeries.html

// Oxyplot coloring!
// https://stackoverflow.com/questions/44192118/custom-color-range-with-oxyplot-scatterplot

/***
#defaultMap -> Standardplot mit Standardwerten (alpha & beta über Regler)
#fixedAlpha & #fixedBeta -> X-Y Diagramm mit Parametern in Farbe sprich plotten der Zyklen mit je einer Farbe pro Parameterwart (anderer param über Regler=fixed)
#alphaPlot -> X und alpha auf Axen (beta über Regler) = Bifurcation Diagram for alpha (Color with ARGB)
#betaPlot -> X und beta auf Axen (alpha über Regler) = Bifurcation Diagram for beta (Color with ARGB)
#doublePlot -> X-param und Y-param Plots nebeneinander für (normales) Bifurkationsdiagramm gegen alpha (beta über Regler)
#1Diteration -> Nur X-Plot gegen n (Widerholungen) = Vereinfachung ohne Y = 'Periodendiagramm'
#1Dalpha -> Nur X-Plot gegen alpha (beta über Regler) = Vereinfachung ohne Y = Bifurcation Diagram for alpha (Color with ARGB) -> Periodenanalyse für verschiedene Farben?
***/
