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
            // Создаем и добавляем столбцы в DataGridView
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Понедельник";
            dataGridView1.Columns[1].Name = "Вторник";
            dataGridView1.Columns[2].Name = "Среда";
            dataGridView1.Columns[3].Name = "Четверг";
            dataGridView1.Columns[4].Name = "Пятница";
            dataGridView1.Columns[5].Name = "Суббота";
            dataGridView1.Columns[6].Name = "Воскресенье";

            // Добавляем строки для каждого часа в каждом дне недели
            for (int i = 0; i < 24; i++)
            {
                string[] row = new string[7]; // Создаем массив для каждого часа в день
                for (int j = 0; j < 7; j++)
                {
                    row[j] = ""; // По умолчанию пустые значения для каждого часа
                }
                dataGridView1.Rows.Add(row);
            }

            /* Пример заполнения расписания (замените на ваши данные)
            dataGridView1.Rows[8].Cells[0].Value = "Футбол"; // Футбол в 8:00 на Понедельник
            dataGridView1.Rows[10].Cells[1].Value = "Плавание"; // Плавание в 10:00 на Вторник
            И так далее... */

            // Устанавливаем высоту строк для лучшего отображения данных
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
