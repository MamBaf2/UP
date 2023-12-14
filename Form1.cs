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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //базовая цена, скидка, множитель для обратного билета
            double basePrice = 1000; 
            double discount = 0.05; 
            double returnTicketMultiplier = 2;

            // Получение выбранных данных из элементов управления на форме
            
            int routeChoice = cmbVarR.SelectedIndex + 1; //выбор рейса 
            int wagonTypeChoice = cmbTypeV.SelectedIndex + 1; // тип вагона 
            
            int adultCount = Convert.ToInt32(numAdults.Value); // Количество взрослых 
            int childCount = Convert.ToInt32(numChild.Value); // Количество детей 
            
            bool hasLinen = chkBel.Checked; // бельё 
            bool hasFood = chkPit.Checked; //питание
            bool hasLuggage = chkBag.Checked; // багаж
            bool isReturnTicket = chkObrB.Checked; // обратный билет(проверка)

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
            
            MessageBox.Show($"Стоимость билета: {totalPrice} руб.");
        }
    }
}
