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
            //цикл от 1 до n
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
        //кнопка Сочетание
        private void btnCombin_Click(object sender, EventArgs e)
        {
            // Проверка корректности введенных данных перед вычислением(отрицательная проверка)
            if (!check()) return;
            //получение данных из текст поля
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            int result = Combination(n, m);
            // Отображение результата на форме
            lblCombin.Text = result.ToString();
            ClearFields();
        }
        //кнопка Размещение
        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            // Вычисление результата
            int result = Place(n, m);
            lblPlace.Text = result.ToString();
            ClearFields();
        }
        //кнопка перестановки
        private void btnPermut_Click(object sender, EventArgs e)
        {
            if (!checkFac()) return;
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
        //текстовое поле n
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            //макс кол-во символов
            txtN.MaxLength = 2;
            //проверка текста на числа
            if (!int.TryParse(txtN.Text, out int number))
            {
                txtN.Text = "";
            }
            //проверка диапазона
            else if (number > 15 || number < 1)
            {
                MessageBox.Show("Введите число от 1 до 15 ");
                txtN.Text = "";
            }
        }
        private void txtM_TextChanged(object sender, EventArgs e)
        {
            txtM.MaxLength = 2;
            if (!int.TryParse(txtM.Text, out int number))
            {
                txtM.Text = "";
            }
            else if (number > 15 || number < 1)
            {
                MessageBox.Show("Число должно быть от 1 до 15.");
                txtM.Text = "";
            }
        }
        private bool check()
        {
            //если поле пустое
            if (string.IsNullOrWhiteSpace(txtN.Text) || string.IsNullOrWhiteSpace(txtM.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка");
                return false;
            }

            int n, m;
            return true;
        }
        private bool checkFac()
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("Поля не должны быть пустыми", "Ошибка");
                return false;
            }
            return true;
        }
    }

}

