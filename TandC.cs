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
    public partial class TandC : Form
    {
        public TandC()
        {
            InitializeComponent();
        }

        private void TandC_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
            Guest.SetPanelRadius(panel1, 30);

            panel2.BackColor = Color.FromArgb(200, 255, 255, 255);
            Guest.SetPanelRadius(panel2, 30);

            panel3.BackColor = Color.FromArgb(200, 255, 255, 255);
            Guest.SetPanelRadius(panel3, 30);

            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Hide();
            panel2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            
        }
    }
}
