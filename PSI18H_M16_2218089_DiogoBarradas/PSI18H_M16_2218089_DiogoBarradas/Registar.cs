﻿using System;
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
    public partial class Registar : Form
    {
        public Registar()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection(@"server=127.0.0.1;uid=root;database=psi18h_m16_2218089_diogobarradas");

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Morada")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Morada";
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

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Email")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Email";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Idade")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Idade";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Username")
            {
                textBox5.Text = "";
            }
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Username";
            }
        }

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

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Morada" || textBox2.Text == "OPIN" || textBox3.Text == "Email" || textBox4.Text == "Idade" || textBox5.Text == "Username" || textBox2.Text.Length != 4) 
            {
                MessageBox.Show("Todos os campos são obrigatórios!\nPIN = 4 Digitos");
            }
            else
            {
                try
                {
                    int Idadeuser = int.Parse(textBox4.Text);
                    if (Idadeuser < 18)
                    {
                        MessageBox.Show("A Idade minima deve ser 18 ");
                    }
                    else
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("INSERT INTO registo(PIN, Idade, Email, Morada, Username) VALUES(@PIN, @Idade, @Email, @Morada, @Username)", connection);

                        command.Parameters.AddWithValue("@Username", textBox5.Text);
                        command.Parameters.AddWithValue("@PIN", textBox2.Text);
                        command.Parameters.AddWithValue("@Idade", textBox4.Text);
                        command.Parameters.AddWithValue("@Email", textBox3.Text);
                        command.Parameters.AddWithValue("@Morada", textBox1.Text);

                        command.ExecuteNonQuery();

                        MessageBox.Show($"O seu id é 0000"); //Apareca o ID do utilizador que acabou de criar

                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }              
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Este utilizador já existe!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Reveja os seus Dados");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
