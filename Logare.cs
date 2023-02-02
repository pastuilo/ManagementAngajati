using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementAngajati
{
    public partial class Logare : Form
    {
        public Logare()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UserID.Text == "")
            {
                MessageBox.Show("Introduceti Id-ul");
            }
            else if(UserPass.Text == "")
            {
                MessageBox.Show("Introduceti parola");
            }
            else if(UserID.Text == "admin" && UserPass.Text == "root")
            {
                Acasa acasa = new Acasa();
                acasa.Show();
                MessageBox.Show("Logare reusita");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Id sau parola gresita");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserID.Text = "";
            UserPass.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
