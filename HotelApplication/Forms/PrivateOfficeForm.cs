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
    public partial class PrivateOfficeForm : Form
    {
        public PrivateOfficeForm()
        {
            InitializeComponent();
            label1.Text += User.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            Hide();
            orderForm.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            Hide();
            historyForm.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListRoomsForm listRoomsForm = new ListRoomsForm();
            Hide();
            listRoomsForm.ShowDialog();
            Show();
        }
    }
}
