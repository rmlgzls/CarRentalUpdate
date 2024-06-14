using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Car_Rental_System
{
    public partial class Car1 : Form
    {
        public Car1()
        {
            InitializeComponent();
        }

        public static String rentedCar = "";
        public static bool isRented = false;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void Car1_Load(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox2.Hide();
            pictureBox1.Hide();

            if (isRented == false)
            {
                label7.Hide();
            }
            else
            {
                label7.Show();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car2 car2 = new Car2();
            car2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isRented == false)
            {
                rentedCar = "YARIS CROSS 1.5 V CVT";

                this.Hide();
                Filloutform filloutform = new Filloutform();
                filloutform.Show();
            }
            else
            {
                MessageBox.Show("This car is currently on rent, \n" +
                                "Please choose another Car, Thank you!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
