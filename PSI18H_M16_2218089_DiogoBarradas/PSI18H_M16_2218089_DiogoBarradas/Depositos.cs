using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PSI18H_M16_2218089_DiogoBarradas
{
    public partial class Depositos : Form
    {
        MySqlConnection cnn = new MySqlConnection(@"server=127.0.0.1;uid=root;database=psi18h_m16_2218089_diogobarradas");

        public Depositos()
        {
            InitializeComponent();
            panel8.Visible = false;
            Saldo.Text = valorzero.ToString();

            cnn.Open();
            string bddepositos = "SELECT * FROM depositos";
            MySqlCommand cmd = new MySqlCommand(bddepositos, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private bool olho = false;

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (olho == false)
            {
                pictureBox9.Image = Properties.Resources.eye;
                olho = true;
                panel8.Visible = true;
            }
            else
            {
                pictureBox9.Image = Properties.Resources.eye1;
                olho = false;
                panel8.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double valorzero = 00.00;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " Montante" || textBox1.Text == "")
                {
                    MessageBox.Show("Digite um valor !");
                }
                else
                {
                    double addvalor = double.Parse(textBox1.Text);
                    if(addvalor <= 0)
                    {
                        MessageBox.Show("Introduza um valor válido");
                    }
                    else
                    {
                        double valorfinal = valorzero += addvalor;
                        Saldo.Text = valorfinal.ToString();
                        textBox1.Text = " Montante";
                        MessageBox.Show($"{addvalor}€ foram Depositados!");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Digite somente numeros!");
            }  
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == " Montante")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = " Montante";
            }
        }
    }
}