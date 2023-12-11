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
        private bool currentPlayerX = true; // Переменная для отслеживания текущего игрока (true - X, false - O)
        private int moveCount = 0; // Переменная для подсчета количества ходов
        public Form1()
        {
            InitializeComponent();
            InitializeButtons(); //инициализируем
        }
        private void InitializeButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Click += Button_Click; // Привязываем обработчик события нажатия на кнопку
                }
            }
        }

        // Обработчик события нажатия на кнопку
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "") // Проверяем, что кнопка пуста (еще не была нажата)
            {
                if (currentPlayerX)
                    button.Text = "X"; // Устанавливаем X на кнопку
                else
                    button.Text = "O"; // Устанавливаем O на кнопку

                currentPlayerX = !currentPlayerX; // Меняем текущего игрока

                moveCount++; // Увеличиваем количество ходов

                CheckForWinner(); // Проверяем наличие победителя

                if (moveCount == 9)
                {
                    MessageBox.Show("Ничья!"); // Если ходы закончились и нет победителя
                    ResetGame(); // Сбрасываем игру
                }
            }
        }

        // Метод для проверки победителя
        private void CheckForWinner()
        {
            // Проверяем все возможные комбинации для победы в игре
            if (CheckCombination(button1, button2, button3) ||
                CheckCombination(button4, button5, button6) ||
                CheckCombination(button7, button8, button9) ||
                CheckCombination(button1, button4, button7) ||
                CheckCombination(button2, button5, button8) ||
                CheckCombination(button3, button6, button9) ||
                CheckCombination(button1, button5, button9) ||
                CheckCombination(button3, button5, button7))
            {
                string winner = currentPlayerX ? "O" : "X"; // Определяем победителя
                MessageBox.Show($"Игрок {winner} выиграл!"); // Выводим сообщение о победе
                ResetGame(); // Сбрасываем игру
            }
        }

        // Метод для проверки комбинации кнопок на победу
        private bool CheckCombination(Button b1, Button b2, Button b3)
        {
            return (b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text);
        }

        // Метод для сброса игры
        private void ResetGame()
        {
            foreach (Control control in Controls)
            {
                if (control is Button button)
                {
                    button.Text = ""; // Очищаем текст на кнопках
                }
            }

            currentPlayerX = true; // Устанавливаем первого игрока (X) как текущего
            moveCount = 0; // Сбрасываем количество ходов
        }
    }
}
