using System;
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
    public partial class Car2 : Form
    {
        public Car2()
        {
            InitializeComponent();
        }

        public static bool isRented = false;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car1 car1 = new Car1();
            car1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox2.Hide();
            pictureBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox3.Hide();
            pictureBox1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void Car2_Load(object sender, EventArgs e)
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
            Car3 car3 = new Car3();
            car3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (isRented == false)
            {
                Car1.rentedCar = "VIOS 1.5 G CVT";

                this.Hide();
                Filloutform form = new Filloutform();
                form.Show();
            }
            else
            {
                MessageBox.Show("This car is currently on rent, \n" +
                                "Please choose another Car, Thank you!");
            }
            
        }

  
        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
