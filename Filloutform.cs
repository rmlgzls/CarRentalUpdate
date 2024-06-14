using Guna.UI2.WinForms.Suite;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Car_Rental_System
{
    public partial class Filloutform : Form
    {

        ConnectionState connect = new ConnectionState();
        MySqlConnection cn;
        MySqlCommand command;
        MySqlDataReader dr;
        string connectionString = "Server = 127.0.0.1; User Id = root; Password=root;Database= carRental;";

        public Filloutform()
        {
            InitializeComponent();
            cn = new MySqlConnection(connectionString);
        }

        public static String lname, fname, mi, address, contactNo, email,
               driverLicenceNo, driverLicenseAdd, pDate, rDate,
               carRented, age, carPlatenum;

        public static DateTime pickupDate;
        public static DateTime returnDate;

        private void Filloutform_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(220, 1, 25, 79);
            

            label13.Hide();

            if(Car1.rentedCar == "YARIS CROSS 1.5 V CVT")
            {
                label14.Text = "YARIS CROSS 1.5 V CVT";
                pictureBox1.Show();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
            }
            else if(Car1.rentedCar == "VIOS 1.5 G CVT")
            {
                label14.Text = "VIOS 1.5 G CVT";
                pictureBox1.Hide();
                pictureBox2.Show();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
            }
            else if (Car1.rentedCar == "RAIZE 1.0 Turbo CVT")
            {
                label14.Text = "RAIZE 1.0 Turbo CVT";
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Show();
                pictureBox4.Hide();
                pictureBox5.Hide();
            }
            else if (Car1.rentedCar == "MAZDA BT-50")
            {
                label14.Text = "MAZDA BT-50";
                pictureBox1.Hide();
                pictureBox2.Show();
                pictureBox3.Hide();
                pictureBox4.Show();
                pictureBox5.Hide();
            }
            else if (Car1.rentedCar == "MAZDA 6")
            {
                label14.Text = "MAZDA 6";
                pictureBox1.Hide();
                pictureBox2.Show();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            textBox8.Text = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            pickupDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox9.Text = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            returnDate = dateTimePicker2.Value;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TandC term = new TandC();
            term.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!checkBox1.Checked)
            {
                label13.Show();
            }
            else
            {
                if (textBox1 == null)
                {

                }



                // Inside a method or event handler:
                MessageBox.Show("Succesfully Submit!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lname = textBox1.Text;
                fname = textBox2.Text;
                mi = textBox3.Text;
                age = textBox4.Text;
                int.Parse(age);
                address = textBox5.Text;
                contactNo = textBox6.Text;
                email = textBox7.Text;
                driverLicenceNo = textBox10.Text;
                driverLicenseAdd = textBox11.Text;
                pDate = textBox8.Text;
                rDate = textBox9.Text;



                carRented = Car1.rentedCar;


                if (Car1.rentedCar == "YARIS CROSS 1.5 V CVT")
                {
                    Car1.isRented = true;
                }
                else if (Car1.rentedCar == "VIOS 1.5 G CVT")
                {
                    Car2.isRented = true;
                }
                else if (Car1.rentedCar == "RAIZE 1.0 Turbo CVT")
                {
                    Car3.isRented = true;
                }
                else if (Car1.rentedCar == "MAZDA BT-50")
                {
                    Car4.isRented = true;
                }
                else if (Car1.rentedCar == "MAZDA 6")
                {
                    Car5.isRented = true;
                }

                Receipt rec = new Receipt();
                rec.Show();

            }

            try //fill_table connection to db
            {
                cn.Open();
                command = new MySqlCommand("INSERT INTO fill_table (lname,fname,mi,age,address,contactNo,email,driverLicenceNo,driverLicenseAdd,pDate,rDate,carRented) VALUES (@lname,@fname,@mi,@age,@address,@contactNo,@email,@driverLicenceNo,@driverLicenseAdd,@pDate,@rDate,@carRented)", cn);
                command.Parameters.AddWithValue("lname", textBox1.Text);
                command.Parameters.AddWithValue("fname", textBox2.Text);
                command.Parameters.AddWithValue("mi", textBox3.Text);
                command.Parameters.AddWithValue("age", textBox4.Text);
                command.Parameters.AddWithValue("address", textBox5.Text);
                command.Parameters.AddWithValue("contactNo", textBox6.Text);
                command.Parameters.AddWithValue("email", textBox7.Text);
                command.Parameters.AddWithValue("driverLicenceNo", textBox10.Text);
                command.Parameters.AddWithValue("driverLicenseAdd", textBox11.Text);
                command.Parameters.AddWithValue("pDate", textBox8.Text);
                command.Parameters.AddWithValue("rDate", textBox9.Text);
                command.Parameters.AddWithValue("carRented", carRented);
                command.ExecuteNonQuery();
                cn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
           

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Car1.rentedCar == "YARIS CROSS 1.5 V CVT")
            {
                this.Hide();
                Car1 car1 = new Car1();
                car1.Show();
                Car1.rentedCar = null;
            }
            else if (Car1.rentedCar == "VIOS 1.5 G CVT")
            {
                this.Hide();
                Car2 car2 = new Car2();
                car2.Show();
                Car1.rentedCar = null;
            }
            else if (Car1.rentedCar == "RAIZE 1.0 Turbo CVT")
            {
                this.Hide();
                Car3 car3 = new Car3();
                car3.Show();
                Car1.rentedCar = null;
            }
            else if (Car1.rentedCar == "MAZDA BT-50")
            {
                this.Hide();
                Car4 car4 = new Car4();
                car4.Show();
                Car1.rentedCar = null;
            }
            else if (Car1.rentedCar == "MAZDA 6")
            {
                this.Hide();
                Car5 car5 = new Car5();
                car5.Show();
                Car1.rentedCar = null;
            }
        }
    }
}
