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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double basePrice = 1000; // Базовая цена билета в рублях
            double discount = 0.05; // Скидка для детей и пенсионеров
            double returnTicketMultiplier = 2; // Множитель для обратного билета

            // Получение выбранных данных из элементов управления на форме
            int routeChoice = cmbVarR.SelectedIndex + 1; // Выбранный индекс в комбо-боксе для рейса
            int wagonTypeChoice = cmbTypeV.SelectedIndex + 1; // Выбранный индекс в комбо-боксе для типа вагона
            int adultCount = Convert.ToInt32(numAdults.Value); // Количество взрослых из Numeric Up Down
            int childCount = Convert.ToInt32(numChild.Value); // Количество детей из Numeric Up Down
            bool hasLinen = chkBel.Checked; // Указание на наличие белья через флажок
            bool hasFood = chkPit.Checked; // Указание на наличие питания через флажок
            bool hasLuggage = chkBag.Checked; // Указание на наличие багажа через флажок
            bool isReturnTicket = chkObrB.Checked; // Проверка, выбран ли обратный билет

            // Расчет стоимости билета на основе количества пассажиров и базовой цены
            double totalPassengers = adultCount + childCount;
            double totalPrice = basePrice * totalPassengers;

            // Применение скидки для детей и пенсионеров
            double discountAmount = totalPrice * discount * childCount;
            totalPrice -= discountAmount;

            // Учет наличия багажа - если есть, добавляется 1% к стоимости билета за каждый багаж
            if (hasLuggage)
            {
                totalPrice += totalPrice * 0.01;
            }
            // Учет обратного билета - удвоение стоимости, если выбран
            if (isReturnTicket)
            {
                totalPrice *= returnTicketMultiplier;
            }
            // Отображение стоимости билета в диалоговом окне
            MessageBox.Show($"Стоимость билета: {totalPrice} руб.");
        }
    }
}
