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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //кнопка построить
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Чтение значений из текстовых полей и преобразование их в числа с плавающей запятой
            double Xmin = double.Parse(txtMin.Text);
            double Xmax = double.Parse(txtMax.Text);
            double Step = double.Parse(txtStep.Text);
            double y1 = double.Parse(txtY.Text);
            double z = double.Parse(txtZ.Text);
            // Определение количества точек для графика (округление деления) +1 для начальной точки
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            // Создание массивов для значений X и Y
            double[] X = new double[count];
            double[] y = new double[count];
            // Цикл для заполнения массивов значениями
            for (int i = 0; i < count; i++)
            {
                // Вычисление каждого значения X, мы устанавливаем значение X[i] в Xmin, увеличивая его на Step с каждой итерацией
                X[i] = Xmin + Step * i;
                // Вычисляем значение функции y в точке X. 
                y[i] = Math.Pow(2, Math.Pow(y1, X[i])) + Math.Pow(3, X[i]) * Math.Pow(y1, X[i]) - (y1 * (Math.Atan(z) - Math.PI / 6)) / (Math.Abs(X[i]) + (1 / (Math.Pow(y1, 2) + 1)));
            }
            // Настройка оси X на графике
             chart1.ChartAreas[0].AxisX.Minimum = Xmin;
             chart1.ChartAreas[0].AxisX.Maximum = Xmax;
             chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Отображение массивов X и Y на графике
             chart1.Series[0].Points.DataBindXY(X, y);
        }
        //Проверка вводимых значений шага
        private void txtStep_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStep.Text, out int number))
            {
                txtStep.Text = "";
            }
            else if (number < 1)
            {
                MessageBox.Show("Шаг должен быть  не меньше 1");
                txtStep.Text = "";
            }
        }
        //Проверка вводимых значений коэф Y
        private void txtY_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtY.Text, out int number))
            {
                txtY.Text = "";
            }
            else if (number > 3 || number < 1)
            {
                txtY.Text = "";
            }
        }
        //Проверка вводимых значений коэф Z
        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtZ.Text, out int number))
            {
                txtZ.Text = "";
            }
            else if (number > 3 || number < 1)
            {
                txtZ.Text = "";
            }
        }
    }
}

