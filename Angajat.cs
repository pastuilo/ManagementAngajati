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
    public partial class Angajat : Form
    {
        public Angajat()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProiectBD\BazaDeDate\BazaDeDateAngajat.mdf;Integrated Security=True;Connect Timeout=30");
        private void populare()
        {
            con.Open();
            string query = "SELECT * FROM TabelAngajat";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);

            AngajatDGV.DataSource = dataSet.Tables[0];

            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IdAngajatTb.Text == "")
            {
                MessageBox.Show("Lipseste Id-ul");

            }
            else if(NumeAngajatTb.Text == "")
            {
                MessageBox.Show("Lipseste Numele Angajatului");

            }
            else if(AdresaAngajatTb.Text == "")
            {
                MessageBox.Show("Lipseste Adresa Angajatului");

            }
            else if(TelefonAngajatTb.Text == "" || TelefonAngajatTb.Text.Length > 10 || TelefonAngajatTb.Text.Length < 10)
            {
                MessageBox.Show("Numar de telefon invalid");
            }
            else
            {           
                try
                {
                    con.Open();
                    string query = "INSERT INTO TabelAngajat Values('" + IdAngajatTb.Text + "','" + NumeAngajatTb.Text + "','" + AdresaAngajatTb.Text + "','"
                        + PozitieAngajatTb.SelectedItem.ToString() + "','" + DataAngajariiAngajatTb.Value.Date + "','" + TelefonAngajatTb.Text + "','"
                        + EducatieAngajatTb.SelectedItem.ToString() + "','" + SexAngajatTb.SelectedItem.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Angajat adaugat cu succes");
                    con.Close();

                    populare();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Nu s-a putut adauga angajat");
                }
            }
        }

        private void IdAngajatTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Angajat_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Acasa acasa = new Acasa();
            acasa.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populare();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdAngajatTb.Text == "")
            {
                MessageBox.Show("Introduceti id-ul angajatului");
            }           
            else
            {
                try
                {
                    con.Open();

                    string query = "DELETE FROM TabelAngajat WHERE IdAngajat = '" + IdAngajatTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Angajat sters cu succes");
                    con.Close();

                    populare();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Nu s-a putut sterge angajat");
                }
            }

        }

        private void AngajatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            DataGridViewRow selectedRow = AngajatDGV.Rows[index];

            IdAngajatTb.Text = selectedRow.Cells[0].Value.ToString();
            NumeAngajatTb.Text = selectedRow.Cells[1].Value.ToString();
            AdresaAngajatTb.Text = selectedRow.Cells[2].Value.ToString();

            PozitieAngajatTb.Text = selectedRow.Cells[3].Value.ToString();
            TelefonAngajatTb.Text = selectedRow.Cells[5].Value.ToString();
            EducatieAngajatTb.Text = selectedRow.Cells[6].Value.ToString();

            SexAngajatTb.Text = selectedRow.Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdAngajatTb.Text == "")
            {
                MessageBox.Show("Lipseste Id-ul");
            }
            else if (NumeAngajatTb.Text == "")
            {
                MessageBox.Show("Lipseste Numele Angajatului");
            }
            else if (AdresaAngajatTb.Text == "")
            {
                MessageBox.Show("Lipseste Adresa Angajatului");
            }
            else if (TelefonAngajatTb.Text == "" || TelefonAngajatTb.Text.Length > 10 || TelefonAngajatTb.Text.Length < 10)
            {
                MessageBox.Show("Numar de telefon invalid");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE TabelAngajat SET NumeAngajat = '" + NumeAngajatTb.Text + "', AdresaAngajat = '" + AdresaAngajatTb.Text + "', PozitieAngajat = '"
                        + PozitieAngajatTb.SelectedItem.ToString() + "', DataAngajariiAngajat = '" + DataAngajariiAngajatTb.Value.Date + "', TelefonAngajat = '" + TelefonAngajatTb.Text
                        + "', EducatieAngajat = '" + EducatieAngajatTb.SelectedItem.ToString() + "', SexAngajat = '" + SexAngajatTb.SelectedItem.ToString() 
                        + "' WHERE IdAngajat = '" + IdAngajatTb.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Angajat editat cu succes");
                    con.Close();

                    populare();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Nu s-a putut edita angajat");
                }
            }
        }

        private void TelefonAngajatTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
