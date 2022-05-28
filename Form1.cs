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

namespace Модель_Лотки_Вальтера
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int x0, y0;
            x0 = Convert.ToInt32(textBoxX0.Text);
            y0 = Convert.ToInt32(textBoxY0.Text);
            double ε, α, δ, β;
            ε = Convert.ToDouble(textBoxε.Text);
            α = Convert.ToDouble(textBoxα.Text);
            δ = Convert.ToDouble(textBoxδ.Text);
            β = Convert.ToDouble(textBoxβ.Text);

            //1 цикл
            List<double> x1 = new List<double>();
            List<double> y1 = new List<double>();
            x1.Add(x0);
            y1.Add(y0);
            for (int i = 1; i < 150; i++)
            {
                x1.Add((ε - α * y1[i - 1]) * x1[i - 1] + x1[i - 1]);
                y1.Add((δ * x1[i] - β) * y1[i - 1] + y1[i - 1]);
            }
            //2 цикл
            List<double> x2 = new List<double>();
            List<double> y2 = new List<double>();
            x2.Add(x0);
            y2.Add(y0 - (y0 / 4));
            for (int i = 1; i < 150; i++)
            {
                x2.Add((ε - α * y2[i - 1]) * x2[i - 1] + x2[i - 1]);
                y2.Add((δ * x2[i] - β) * y2[i - 1] + y2[i - 1]);
            }
            //3 цикл
            List<double> x3 = new List<double>();
            List<double> y3 = new List<double>();
            x3.Add(x0);
            y3.Add(y0 - (y0 / 4)*2);

            for (int i = 1; i < 150; i++)
            {
                x3.Add(((ε - α * y3[i - 1]) * x3[i - 1] + x3[i - 1]));
                y3.Add(((δ * x3[i] - β) * y3[i - 1] + y3[i - 1]));
            }
            dataGridView1.Rows.Add(450);
            for (int i = 0; i < 450; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            List<double> yy = new List<double>();

            for (int i = 0; i < 150;i++)
            {
                yy.Add(i);
                dataGridView1.Rows[i].Cells[1].Value = Math.Round(x1[i],4);
                dataGridView1.Rows[i].Cells[2].Value = Math.Round(y1[i], 4);
            }
            for (int i = 0; i < 150; i++)
            {
                dataGridView1.Rows[i+150].Cells[1].Value = Math.Round(x2[i], 4);
                dataGridView1.Rows[i + 150].Cells[2].Value = Math.Round(y2[i], 4);
            }
            for (int i = 0; i < 150; i++)
            {
                dataGridView1.Rows[i+300].Cells[1].Value = Math.Round(x3[i], 4);
                dataGridView1.Rows[i + 300].Cells[2].Value = Math.Round(y3[i], 4);
            }


            chart4.Series.Clear();

            chart4.Series.Add(new Series("1 цикл")
            {
                ChartType = SeriesChartType.Line
            });

            chart4.Series["1 цикл"].Points.DataBindXY(x1, y1);

            chart4.Series.Add(new Series("2 цикл")
            {
                ChartType = SeriesChartType.Line
            });

            chart4.Series["2 цикл"].Points.DataBindXY(x2, y2);

            chart4.Series.Add(new Series("3 цикл")
            {
                ChartType = SeriesChartType.Line
            });
            chart4.Series["3 цикл"].Points.DataBindXY(x3, y3);

            обычнаяДиаграмма(chart1, x1, y1);
            обычнаяДиаграмма(chart2, x2, y2);
            обычнаяДиаграмма(chart3, x3, y3);
        }
        void обычнаяДиаграмма(Chart chart, List<double> x1, List<double> y1)
        {
            chart.Series.Clear();
            
            chart.Series.Add(new Series("Жертвы")
            {
                ChartType = SeriesChartType.Line
            });
            chart.Series["Жертвы"].Points.DataBindY(x1);

            chart.Series.Add(new Series("Хищники")
            {
                ChartType = SeriesChartType.Line
            });
            chart.Series["Хищники"].Points.DataBindY(y1);
            chart.Series["Хищники"].YAxisType = AxisType.Secondary;
        }
        
    }
}
