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
    public partial class Transferências : Form
    {
        MySqlConnection cnn = new MySqlConnection(@"server=127.0.0.1;uid=root;database=psi18h_m16_2218089_diogobarradas");

        public Transferências()
        {
            InitializeComponent();
            panel8.Visible = false;
            tempo.Visible = false;

            cnn.Open();
            string bdtranferencias = $"SELECT Descriçao, Hora, Valor, idDestinatario, ID FROM transferencias WHERE (ID = {Class1.iduser})";
            MySqlCommand cmd = new MySqlCommand(bdtranferencias, cnn);
            MySqlDataAdapter antiga = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            antiga.Fill(table);
            dataGridView1.DataSource = table;


            MySqlCommand command = new MySqlCommand($"SELECT Saldo FROM registo WHERE(ID = {Class1.iduser})", cnn);
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
                if (textBox1.Text == " Montante" || textBox3.Text == " ex.Transferências")
                {
                    MessageBox.Show("Todos os campos são obrigatórios!");
                }
                else
                {
                    double addvalor = double.Parse(textBox1.Text);
                    if (addvalor <= 0)
                    {
                        MessageBox.Show("Introduza um valor válido");
                    }
                    else
                    {
                        if (addvalor > _saldo)
                        {
                            MessageBox.Show("Você não têm fundos");
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

                            MessageBox.Show($"{addvalor}€ foram Transferidos!");
                            tempo.Text = DateTime.Now.ToShortTimeString();//recebe a hora atual

                            cnn.Open();
                            MySqlCommand comando = new MySqlCommand($"INSERT INTO transferencias(Descriçao, Valor, ID, idDestinatario) VALUES (@Descriçao, @Valor, {Class1.iduser}, @idDestinatario)", cnn);
                            comando.Parameters.AddWithValue("@Descriçao", textBox3.Text);
                            comando.Parameters.AddWithValue("@Valor", textBox1.Text);
                            comando.Parameters.AddWithValue("@Hora", tempo.Text);
                            //comando.Parameters.AddWithValue("@idDestinatario", textBox4.Text);

                            comando.ExecuteNonQuery();

                            //atualizar o dataGrid
                            string bdtranferencias = $"SELECT Descriçao, Hora, Valor, idDestinatario, ID FROM transferencias WHERE (ID = {Class1.iduser})";
                            MySqlCommand cmd = new MySqlCommand(bdtranferencias, cnn);
                            MySqlDataAdapter nova = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            nova.Fill(table);
                            dataGridView1.DataSource = table;
                            cnn.Close();
                            textBox1.Text = " Montante";
                            textBox3.Text = " ex.Transferências";
                        }
                    }
                }
            }
            catch (Exception)
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

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == " ex.Transferências")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = " ex.Transferências";
            }
        }
    }
}