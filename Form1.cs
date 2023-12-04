using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace УП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //метод Факториала (перестановки)
        private int Factorial(int n) 
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        //метод размещения
        private int Place(int n, int m)
        {
            int numerator = Factorial(n);
            int denominator = Factorial(n - m);
            return numerator / denominator;
        }
        //метод Сочетания
        private int Combination(int n, int m)
        {
            int numerator = Factorial(n);
            int denominator = Factorial(n - m) * Factorial(m);
            return numerator / denominator;
        }
        private int n, m;
        private void btnCombin_Click(object sender, EventArgs e)
        {
            check(); // вызываем метод проверки перед вычислением Combination
            int result = Combination(n, m);
            lblCombin.Text = result.ToString();
            ClearFields();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            check();
            int result = Place(n, m);
            lblPlace.Text = result.ToString();
            ClearFields();
        }

        private void btnPermut_Click(object sender, EventArgs e)
        {
            check();
            int result = Factorial(n);
            lblPermut.Text = result.ToString();
            ClearFields();
        }
        //метод очистки 
        private void ClearFields()
        {
            txtN.Text = "";
            txtM.Text = "";
        }
        private void ClearLbl()
        {
            lblCombin.Text = "";
            lblPermut.Text = "";
            lblPlace.Text = "";
        }
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            txtN.MaxLength = 5;
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            txtM.MaxLength = 5;
        }
        private void check()
        {
            bool nParsed = int.TryParse(txtN.Text, out n);
            bool mParsed = int.TryParse(txtM.Text, out m);

            if (!nParsed || n <= 0 || !mParsed || m <= 0)
            {
                string errorMessage = "";

                if (!nParsed || n <= 0)
                {
                    errorMessage += "Неверное число n. ";
                }

                if (!mParsed || m <= 0)
                {
                    errorMessage += "Неверное число m. ";
                }
                MessageBox.Show(errorMessage.Trim(), "Ошибка");
                return;
            }
        }
    }
}

