using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Car_Rental_System
{
    public partial class AddingCar : Form
    {

        ConnectionState connect = new ConnectionState();
        MySqlConnection cn;
        MySqlCommand command;
        MySqlDataReader dr;
        string connectionString = "Server = 127.0.0.1; User Id = root; Password=root;Database= carRental;";

        public AddingCar()
        {
            InitializeComponent();
            cn = new MySqlConnection(connectionString);

        }
        public static string carPlatenum, modelName, brand, length, width, height, fuelType, seatsCapacity, price_perDay;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddingCar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carPlatenum = textBox1.Text;
            modelName = textBox2.Text;
            brand = textBox3.Text;
            length = textBox4.Text;
            width = textBox5.Text;
            height = textBox6.Text;
            fuelType = textBox7.Text;
            seatsCapacity = textBox8.Text;
           
            price_perDay = textBox9.Text;
            int.Parse(price_perDay);




            try
            {
                cn.Open();
                command = new MySqlCommand("INSERT INTO car_table (carPlatenum, modelName, brand, length,width,height,fuelType,seatsCapacity,price_perDay) VALUES (@carPlatenum, @modelName, @brand, @length,@width,@height,@fuelType,@seatsCapacity,@price_perDay)", cn);
                command.Parameters.AddWithValue("carPlatenum",textBox1.Text);
                command.Parameters.AddWithValue("modelName", textBox2.Text);
                command.Parameters.AddWithValue("brand", textBox3.Text);
                command.Parameters.AddWithValue("length", textBox4.Text);
                command.Parameters.AddWithValue("width", textBox5.Text);
                command.Parameters.AddWithValue("height", textBox6.Text);
                command.Parameters.AddWithValue("fuelType", textBox7.Text);
                command.Parameters.AddWithValue("seatsCapacity", textBox8.Text);
                command.Parameters.AddWithValue("price_perDay", textBox9.Text);
                
                command.ExecuteNonQuery();
                cn.Close();
                
            } 
            
            catch(Exception )  {
                MessageBox.Show("Error!");
            }
            MessageBox.Show("Successfully Added!");
            textBox1.Clear();
            textBox2.Clear();
             textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();


        }
    }
}
