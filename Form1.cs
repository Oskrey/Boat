using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int x0, y0;
            x0= Convert.ToInt32(textBoxX0.Text);
            y0 = Convert.ToInt32(textBoxY0.Text);
            double ε, α, δ, β;
            ε = Convert.ToDouble(textBoxε.Text);
            α = Convert.ToDouble(textBoxα.Text);
            δ = Convert.ToDouble(textBoxδ.Text);
            β = Convert.ToDouble(textBoxβ.Text);
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            x.Add(x0);
            y.Add(y0);
            for (int i = 0; i < 450; i++)
            { x.Add()}

        }
    }
}
