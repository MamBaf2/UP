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
        //кнопка перехода ко второй форме
        private void btnForm_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        //кнопка построить
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Чтение значений из текстовых полей и преобразование их в числа с плавающей запятой
            double Xmin = double.Parse(txtMin.Text);
            double Xmax = double.Parse(txtMax.Text);
            double Step = double.Parse(txtStep.Text);
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            // Определение количества точек для графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            // Создание массивов для значений X и Y
            double[] X = new double[count];
            double[] y = new double[count];
            // Цикл для заполнения массивов значениями
            for (int i = 0; i < count; i++)
            {
                // Вычисление каждого значения X, мы устанавливаем значение X[i] в Xmin, увеличивая его на Step с каждой итерацией
                X[i] = Xmin + Step * i;
                // Вычисление значения функции для каждого X[i]
                y[i] = a * Math.Pow(X[i], 2) + b * X[i] + c;
            }

            // Настройка оси X на графике
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Привязка значений массивов X и Y к графику
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
        //Проверка вводимых значений коэф А
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int number))
            {
                txtA.Text = "";
            }
            else if (number > 10 || number < 1)
            {
                MessageBox.Show("Коэфицента А должен быть больше 1 и меньше 10");
                txtA.Text = "";
            }

        }
        //Проверка вводимых значений коэф B
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtB.Text, out int number))
            {
                txtB.Text = "";
            }
            else if (number > 10 || number < 1)
            {
                MessageBox.Show("Коэфицента B должен быть больше 1 и меньше 10");
                txtB.Text = "";
            }
        }
        //Проверка вводимых значений коэф C
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtC.Text, out int number))
            {
                txtC.Text = "";
            }
            else if (number > 10 || number < 1)
            {
                MessageBox.Show("Коэфицента C должен быть больше 1 и меньше 10");
                txtC.Text = "";
            }
        }
    }
}
