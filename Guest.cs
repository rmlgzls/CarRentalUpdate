using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        const String Username = "user1";
        const String Password = "user1";

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guest_Load(object sender, EventArgs e)
        {
            SetPanelRadius(panel1, 30);
            SetTboxRadius(textBox1, 40);
            SetTboxRadius(textBox2, 40);

            panel1.BackColor = Color.FromArgb(220, 1, 25, 79);

            label4.Hide();
            label5.Hide();
        }

        public static void SetTboxRadius(TextBox tbox, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            // Create a rounded rectangle path
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(tbox.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(tbox.Width - radius, tbox.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, tbox.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Set the TextBox's region to the rounded rectangle path
            tbox.Region = new Region(path);
        }

        public static void SetPanelRadius(Panel pan, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            // Create a rounded rectangle path
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pan.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pan.Width - radius, pan.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pan.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Set the TextBox's region to the rounded rectangle path
            pan.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String userName, password;
            userName = textBox1.Text;
            password = textBox2.Text;

            if(password == Password && userName == Username)
            {
               
                this.Hide();
                Car1 car1 = new Car1();
                car1.Show();
            }
            else
            {
                if(userName != Username && password == Password)
                {
                    label4.Show();
                    label5.Hide();
                }
                else if(password != Password && userName == Username) 
                {
                    label5.Show();
                    label4.Hide();
                }
                else
                {
                    label5.Show();
                    label4.Show();
                }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
