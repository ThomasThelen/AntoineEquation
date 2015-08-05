using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
namespace AntoineEquation
{
    public partial class AntoineMain : Form
    {
        public AntoineMain()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ErrorCheck()==0)
            {
                return;
            }
            double stepsize = Math.Abs((Convert.ToDouble(temperatureFinal.Text) - Convert.ToDouble(temperatureInitial.Text)) / 50);
            double[] Pressure = new double[49];
            double[] Temperature = new double[49];
            if (unitsTemp.SelectedItem.ToString() == "Celcius")
            {
                Temperature[0] = Convert.ToDouble(temperatureInitial.Text) + 273.15;
                Temperature[48] = Convert.ToDouble(temperatureFinal.Text) + 273.15;
            }

            else if (unitsTemp.SelectedItem.ToString() == "Kelvin" && unitsAntoine.SelectedItem.ToString() == "Celcius")
            {
                Temperature[0] = Convert.ToDouble(temperatureInitial.Text) - 273.15;
                Temperature[49] = Convert.ToDouble(temperatureFinal.Text) - 273.15;
            }

            else if (unitsTemp.SelectedItem.ToString() == "Celcius" && unitsAntoine.SelectedItem.ToString() == "Celcius" || unitsTemp.SelectedItem.ToString() == "Kelvin" && unitsAntoine.SelectedItem.ToString() == "Kelvin")
            {
                Temperature[0] = Convert.ToDouble(temperatureInitial.Text);
                Temperature[48] = Convert.ToDouble(temperatureFinal.Text);
            }



            
            this.ClientSize = new System.Drawing.Size(890, 399);
            // Create the chart
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            Title title1 = new Title();
            PTDiagram = new Chart();
            chartArea1.Name = "ChartArea1";
            PTDiagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            PTDiagram.Legends.Add(legend1);
            PTDiagram.Location = new System.Drawing.Point(383, 64);
            PTDiagram.Name = "PTDiagram";
            PTDiagram.Titles.Add("P-T Diagram");
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "P/T";
            PTDiagram.Series.Add(series1);
            PTDiagram.Size = new System.Drawing.Size(439, 299);
            PTDiagram.TabIndex = 12;
            PTDiagram.Text = "chart1";
            title1.Name = "P-T Diagram";
            PTDiagram.Titles.Add(title1);
            PTDiagram.Click += new System.EventHandler(this.PTDiagram_Click);
            Controls.Add(this.PTDiagram);
            chartArea1.AxisX.Title = unitsAntoine.Text;
            chartArea1.AxisY.Title = unitsPressure.Text;



           
            PTDiagram.Series[0].ChartType =  System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Plot the data from Antoine's Equation
            Tuple<double[],double[]> points = Tuple.Create(Temperature, Pressure);
            for (int i = 0; i < 48; i++)
            {
                Temperature[i+1] = Temperature[i]+stepsize;
                Pressure[i] = Math.Pow(10, Convert.ToDouble(aBox.Text) - (Convert.ToDouble(bBox.Text) / (Convert.ToDouble(cBox.Text) + Temperature[i])));
                PTDiagram.Series[0].Points.AddXY(points.Item1[i], points.Item2[i]);
            }
            pBox.Text = Pressure[0].ToString();
            pBox2.Text = Pressure[47].ToString();
            button2.Show();




                }
        public int ErrorCheck()
        {
            if (unitsTemp.SelectedItem == null)
            {
                MessageBox.Show("Please enter the temperature units");
                return 0;
            }


            if (unitsAntoine.SelectedItem == null)
            {
                MessageBox.Show("Please enter the coefficient units");
                return 0;
            }

            if (String.IsNullOrWhiteSpace(aBox.Text) == true || String.IsNullOrWhiteSpace(bBox.Text) == true || String.IsNullOrWhiteSpace(cBox.Text) == true)
            {
                MessageBox.Show("Please enter the remaining coefficients");
                return 0;
            }


            if (String.IsNullOrWhiteSpace(temperatureInitial.Text) == true || String.IsNullOrWhiteSpace(temperatureFinal.Text) == true)
            {
                MessageBox.Show("Please enter the remaining Temperature");
                return 0;
            }
            else
                return 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog chartSaveDialog = new SaveFileDialog();
            chartSaveDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            chartSaveDialog.Title = "Save the P-T diagram";
            chartSaveDialog.ShowDialog();
            System.IO.FileStream fs =(System.IO.FileStream)chartSaveDialog.OpenFile();
            switch (chartSaveDialog.FilterIndex)
            {
                case 1:
                    PTDiagram.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case 2:
                    PTDiagram.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case 3:
                    PTDiagram.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
        }
            
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm HelpForm = new HelpForm();
            HelpForm.Show(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PTDiagram_Click(object sender, EventArgs e)
        {

        }

        private void nISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebForm webForm = new WebForm();
            webForm.Show();
        }

        private void literatureSourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LiteratureForm literatureForm = new LiteratureForm();
            literatureForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
