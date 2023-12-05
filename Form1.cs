using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(txtMin.Text);
            double Xmax = double.Parse(txtMax.Text);
            double Step = double.Parse(txtStep.Text);
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            // Создание массивов для значений X-общий, y1 (синус) и y2 (косинус).
            double[] X = new double[count];
            double[] y = new double[count];
            // Цикл для заполнения массивов значениями
            for (int i = 0; i < count; i++)
            {
                // Вычисление каждого значения X, мы устанавливаем значение X[i] в Xmin, увеличивая его на Step с каждой итерацией
                X[i] = Xmin + Step * i;
                // Вычисляем значение функции y1 в точке X. Функция y1(X) = 15.28 * |X|^-1.5 + cos(ln(|X|) + b).
                y[i] = a * Math.Pow(X[i], 2) + b * X[i] + c;
            }

            // Устанавливаем минимальное значение по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            // Устанавливаем максимальное значение по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            // Устанавливаем интервал основной сетки по оси X для первой области диаграммы
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Привязываем данные массива X и y1 к первой серии диаграммы
            chart1.Series[0].Points.DataBindXY(X, y);
            // Привязываем данные массива X и y2 ко второй серии диаграммы
        }
    }
}
