using HotelApplication.Handler;
using HotelApplication.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApplication.Forms
{
    public partial class OrderForm : Form
    {
        HandlerOrder handlerOrder;

        public OrderForm()
        {
            InitializeComponent();
            handlerOrder = new HandlerOrder();
            SetInfo();
        }

        /// <summary>
        ///     Вставляет все комнаты в колонку выберите комнату.
        /// </summary>
        private void SetInfo()
        {
            textBox1.Text = User.FullName;
            List<string[]> rooms = handlerOrder.GetAllRooms();
            foreach (var room in rooms)
            {
                comboBox1.Items.Add("Номер комнаты: " + room[1] + ", Престиж: " + room[2] + "");
            }

        }

        private void book_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.Date.ToString().Split()[0].Replace('.', '/');
            string numberRoom = comboBox1.Text.Split(' ')[2].Replace(',', ' ');
            string message = handlerOrder.BookRoom(textBox1.Text, numberRoom, date);
            MessageBox.Show(message);
            if (message == "Вы успеншо забронировали.") Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
