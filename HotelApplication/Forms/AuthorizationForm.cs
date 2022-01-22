﻿using HotelApplication.Handler;
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
    public partial class AuthorizationForm : Form
    {
        HandlerAuth auth = new HandlerAuth();

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Выполняет вход пользователя.
        /// </summary>
        private void setIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auth.SetIn(login.Text, password.Text));
            Hide();
            PrivateOfficeForm privateOfficeForm = new PrivateOfficeForm();
            privateOfficeForm.ShowDialog();
            Close();
        }

        private void setUp_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            Show();
        }
    }
}
