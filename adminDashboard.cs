﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingCar addingCar = new AddingCar();
            addingCar.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addingAdmin addingAdmin = new addingAdmin();
            addingAdmin.Show();
        }
    }
}
