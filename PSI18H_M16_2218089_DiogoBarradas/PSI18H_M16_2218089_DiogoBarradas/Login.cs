using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PSI18H_M16_2218089_DiogoBarradas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection(@"server=127.0.0.1;uid=root;database=psi18h_m16_2218089_diogobarradas");

        //Faz desaparecer o texto da textbox ao clicar
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "ID")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "ID";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "OPIN")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "OPIN";
            }
        }

        //Gerir a checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        //abrir novo form 
        private void button8_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text; // Aparece o username do utilizador com aquele ID

            MySqlCommand command = new MySqlCommand("SELECT * FROM registo WHERE ID=@ID AND PIN=@PIN", connection);

            command.Parameters.AddWithValue("@ID",  textBox1.Text);
            command.Parameters.AddWithValue("@PIN", textBox2.Text);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show($"Bem-vindo {user}!");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("O ID e o PIN fornecidos não correspondem às informações em nossos registros.Verifique-as e tente novamente.");
                }

                connection.Close();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Sem Conexão");
            }
        }

        //abrir novo form 
        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Registar regist = new Registar();
            regist.ShowDialog();
        }
    }
}
