using MySql.Data.MySqlClient;
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
    public partial class addingAdmin : Form
    {
        ConnectionState connect = new ConnectionState();
        MySqlConnection cn;
        MySqlCommand command;
        MySqlDataReader dr;
        string connectionString = "Server = 127.0.0.1; User Id = root; Password=root;Database= carRental;";

        public addingAdmin()
        {
            InitializeComponent();
            cn = new MySqlConnection(connectionString);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            { 
                cn.Open();
                command = new MySqlCommand("INSERT INTO admin_table (admin_id,admin_fname,admin_mname,admin_lname,admin_pos) VALUES (@admin_id,@admin_fname,@admin_mname,@admin_lname,@admin_pos)",cn);
                command.Parameters.AddWithValue("admin_id", textBox1.Text);
                command.Parameters.AddWithValue("admin_fname", textBox2.Text);
                command.Parameters.AddWithValue("admin_mname", textBox3.Text);
                command.Parameters.AddWithValue("admin_lname", textBox4.Text);
                command.Parameters.AddWithValue("admin_pos", textBox5.Text);
                command.ExecuteNonQuery();
                cn.Close();

            } catch {
                MessageBox.Show("Error!");

            }
            MessageBox.Show("Successfully Added!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
