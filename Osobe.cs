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

namespace Ednevnik410b
{
    public partial class Osobe : Form
    {
        int index;
        SqlDataAdapter da;
        DataTable tabela;

        public Osobe()
        {
            InitializeComponent();
        }

        public void load_data()
        {
            SqlConnection veza = konekcija.povezi();
            da = new SqlDataAdapter("select * from osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
        }

        public void ispisi_podatke()
        {
            if (index == 0) button5.Enabled = false;
            else button5.Enabled = true;
            if (index == tabela.Rows.Count - 1) button6.Enabled = false;
            else button6.Enabled = true;
            textBox0.Text = tabela.Rows[index][0].ToString();
            textBox1.Text = tabela.Rows[index][1].ToString();
            textBox2.Text = tabela.Rows[index][2].ToString();
            textBox3.Text = tabela.Rows[index][3].ToString();
            textBox4.Text = tabela.Rows[index][4].ToString();
            textBox5.Text = tabela.Rows[index][5].ToString();
            textBox6.Text = tabela.Rows[index][6].ToString();
            textBox7.Text = tabela.Rows[index][7].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
            index = 0;
            ispisi_podatke();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            index++;
            ispisi_podatke();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            index--;
            ispisi_podatke();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = 0;
            ispisi_podatke();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index = tabela.Rows.Count - 1;
            ispisi_podatke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naredba = "insert into osoba (ime, prezime, adresa, jmbg, email, pass, uloga) values (";
            naredba = naredba + "'" + textBox1.Text + "'" + ',';
            naredba = naredba + "'" + textBox2.Text + "'" + ',';
            naredba = naredba + "'" + textBox3.Text + "'" + ',';
            naredba = naredba + "'" + textBox4.Text + "'" + ',';
            naredba = naredba + "'" + textBox5.Text + "'" + ',';
            naredba = naredba + "'" + textBox6.Text + "'" + ',';
            naredba = naredba + textBox7.Text + ')';
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            load_data();
            index = tabela.Rows.Count - 1;
            ispisi_podatke();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string naredba = "UPDATE osoba ";
            naredba = naredba + "SET ime='" + textBox1.Text + "',";
            naredba = naredba + "prezime='" + textBox2.Text + "',";
            naredba = naredba + "adresa='" + textBox3.Text + "',";
            naredba = naredba + "jmbg='" + textBox4.Text + "',";
            naredba = naredba + "email='" + textBox5.Text + "',";
            naredba = naredba + "pass='" + textBox6.Text + "'";
            naredba = naredba + " WHERE id=" + textBox0.Text;
            SqlConnection veza = konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            load_data();
            ispisi_podatke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (index == tabela.Rows.Count - 1)
                {
                    index--;
                }
                string naredba = "DELETE FROM osoba WHERE id=" + textBox0.Text;
                SqlConnection veza = konekcija.povezi();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                load_data();
                ispisi_podatke();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.GetType().ToString());
            }
        }

        private void Osobe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}