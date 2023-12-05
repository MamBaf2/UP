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
            if (!check()) return;
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            int result = Combination(n, m);
            lblCombin.Text = result.ToString();
            ClearFields();
        }
        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            int result = Place(n, m);
            lblPlace.Text = result.ToString();
            ClearFields();
        }
        private void btnPermut_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            int n = int.Parse(txtN.Text);
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
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            txtN.MaxLength = 2;
        }
        private void txtM_TextChanged(object sender, EventArgs e)
        {
            txtM.MaxLength = 2;
        }
        private bool check()
        {
            if (string.IsNullOrWhiteSpace(txtN.Text) || string.IsNullOrWhiteSpace(txtM.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка");
                return false;
            }

            int n, m;
            if (!int.TryParse(txtN.Text, out n) || !int.TryParse(txtM.Text, out m) || n <= 0 || m <= 0)
            {
                MessageBox.Show("Поля должны содержать только положительные целые числа", "Ошибка");
                return false;
            }
            return true;
        }
    }
}

