using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManagementAngajati
{
    public partial class Salariu : Form
    {
        public Salariu()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProiectBD\BazaDeDate\BazaDeDateAngajat.mdf;Integrated Security=True;Connect Timeout=30");

        int SalariuZi = 0;
        int total = 0;
        void PreparareDate()
        {
            con.Open();

            if (IdAngajatTbSal.Text == "")
            {
                MessageBox.Show("Introduceti id-ul");
            }

            else
            {
                string query = "SELECT * FROM TabelAngajat WHERE IdAngajat = '" + IdAngajatTbSal.Text + "';";
                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    NumeAngajatTbSal.Text = dr["NumeAngajat"].ToString();
                    PozitieAngajatTbSal.Text = dr["PozitieAngajat"].ToString();
                }              
            }

            con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PreparareDate();
        }
        private void Salariu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acasa acasa = new Acasa();
            acasa.Show();
            this.Hide();
        }   
        
        private void vizualizare()
        {
            if (PozitieAngajatTbSal.Text == "")
            {
                MessageBox.Show("Selecteaza un angajat");
            }
            else if (ZileMunciteSal.Text == "" || Convert.ToInt32(ZileMunciteSal.Text) > 28)
            {
                MessageBox.Show("Introduceti un numar valid de zile");
            }
            else
            {
                if (PozitieAngajatTbSal.Text == "Manager")
                {
                    SalariuZi = 300;
                }
                else if (PozitieAngajatTbSal.Text == "Developer Senior")
                {
                    SalariuZi = 240;
                }
                else if (PozitieAngajatTbSal.Text == "Developer Junior")
                {
                    SalariuZi = 180;
                }
                else if (PozitieAngajatTbSal.Text == "Contabil")
                {
                    SalariuZi = 150;
                }
                else
                {
                    SalariuZi = 100;
                }
                total = SalariuZi * Convert.ToInt32(ZileMunciteSal.Text);
                AfisSalariu.Text = "Salariu Calculat Pentru:\n\n" + "Id-ul Angajatului: " + IdAngajatTbSal.Text + "\nNumele Angajatului: " + NumeAngajatTbSal.Text + "\nPozitia Angajatului: " + PozitieAngajatTbSal.Text
                    + "\nSalariu de baza: " + SalariuZi + " RON/Zi\nNumar de zile muncite: " + ZileMunciteSal.Text + "\nSalariu pe luna in curs: " + total + " RON";
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            vizualizare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdAngajatTbSal.Text == "")
            {
                MessageBox.Show("Introduceti Id-ul Angajatului");
            }
            else if (NumeAngajatTbSal.Text == "")
            {
                MessageBox.Show("Introduceti Numele Angajatului");
            }
            else if (PozitieAngajatTbSal.Text == "")
            {
                MessageBox.Show("Introduceti Pozitia Angajatului");
            }
            else if (ZileMunciteSal.Text == "" || Convert.ToInt32(ZileMunciteSal.Text) > 28)
            {
                MessageBox.Show("Introduceti un numar valid de zile");
            }
            else
            {
                vizualizare();
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=========Detalii Angajat=========", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Red, new Point(130));
            e.Graphics.DrawString("Id-ul Angajatului: " + IdAngajatTbSal.Text, new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Blue, new Point(80, 100));
            e.Graphics.DrawString("\nNumele Angajatului: " + NumeAngajatTbSal.Text, new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Blue, new Point(80, 120));
            e.Graphics.DrawString("\nPozitia Angajatului: " + PozitieAngajatTbSal.Text, new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Blue, new Point(80, 140));
            e.Graphics.DrawString("\nSalariu de baza: " + SalariuZi + " RON/Zi", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Blue, new Point(80, 160));
            e.Graphics.DrawString("\nNumar de zile muncite: " + ZileMunciteSal.Text + " zile", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Blue, new Point(80, 180));
            e.Graphics.DrawString("\nSalariu pe luna in curs: " + total + " RON", new Font("Times New Roman", 15, FontStyle.Bold), Brushes.Blue, new Point(80, 220));

        }

        private void IdAngajatTbSal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
