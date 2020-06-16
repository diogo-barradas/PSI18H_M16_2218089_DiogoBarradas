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

            cnn.Open();
            string bddepositos = "SELECT * FROM depositos";
            MySqlCommand cmd = new MySqlCommand(bddepositos, cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();

            MySqlCommand command = new MySqlCommand($"SELECT Saldo FROM registo WHERE(ID = {Class1.iduser})", cnn);
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            _saldo = reader.GetDouble(0);
            Saldo.Text = _saldo.ToString();
            cnn.Close();
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

        public double _saldo;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " Montante" || textBox2.Text == " HH:MM" || textBox3.Text == " ex.Depósito")
                {
                    MessageBox.Show("Todos os campos são obrigatórios!");
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
                        double saldofinal = _saldo += addvalor;
                        Saldo.Text = saldofinal.ToString();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        try
                        {
                            cnn.Open();
                            adapter.UpdateCommand = cnn.CreateCommand();
                            adapter.UpdateCommand.CommandText = ($"UPDATE registo SET Saldo = {saldofinal} WHERE (ID = {Class1.iduser})");
                            adapter.UpdateCommand.ExecuteNonQuery();
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Notificação");
                        }

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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == " HH:MM")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = " HH:MM";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == " ex.Depósito")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = " ex.Depósito";
            }
        }
    }
}