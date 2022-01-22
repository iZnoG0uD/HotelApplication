using HotelApplication.Handler;
using System;
using System.Windows.Forms;

namespace HotelApplication.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandlerAuth auth = new HandlerAuth();
            string date = dateTimePicker1.Value.Date.ToString().Split()[0].Replace('.', '/');
            var message = auth.Register(textBox2.Text, textBox3.Text, textBox1.Text, date);
            MessageBox.Show(message);
            if (message == "Вы успеншо зарегались.") Close();
        }
    }
}
