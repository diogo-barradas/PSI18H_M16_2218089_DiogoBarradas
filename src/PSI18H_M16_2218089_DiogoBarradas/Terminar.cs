﻿using System;
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
    public partial class Terminar : Form
    {
        public Terminar()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        MySqlConnection connection = new MySqlConnection(@"server=127.0.0.1;uid=root;database=psi18h_m16_2218089_diogobarradas");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja sair da aplicação?", "Fechar Bank$Acc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Sessao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja terminar sessão?", "Terminar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
                
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
                Sessao.Visible = true;
                Sair.Visible = true;
                Eliminar.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                Sessao.Visible = false;
                Sair.Visible = false;
                Eliminar.Visible = false;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja excluir permanentemente a sua conta?", "Excluir a minha Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                connection.Open();

                MySqlCommand comand = new MySqlCommand($"DELETE FROM depositos WHERE(ID = {Class1.iduser})", connection);
                comand.ExecuteNonQuery();

                MySqlCommand comad = new MySqlCommand($"DELETE FROM levantamentos WHERE(ID = {Class1.iduser})", connection);
                comad.ExecuteNonQuery();

                MySqlCommand cmad = new MySqlCommand($"DELETE FROM transferencias WHERE(ID = {Class1.iduser})", connection);
                cmad.ExecuteNonQuery();

                MySqlCommand command = new MySqlCommand($"DELETE FROM registo WHERE(ID = {Class1.iduser})", connection);
                command.ExecuteNonQuery();

                connection.Close();

                Thread.Sleep(700);
                MessageBox.Show("A sua conta foi Eliminada!");

                //voltar ao login
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }         
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.closefinal5;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.FecharFinal1;
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
            if (textBox1.Text == "Morada" || textBox2.Text == "OPIN" || textBox4.Text == "Idade" || textBox2.Text.Length != 4)
            {
                MessageBox.Show("Todos os campos são obrigatórios!\nPIN = 4 Digitos/Letras");
            }
            else
            {
                connection.Open();
                try
                {
                    int Idadeuser = int.Parse(textBox4.Text);
                    if (Idadeuser < 18)
                    {
                        MessageBox.Show("A Idade minima é 18!");
                    }
                    else
                    {
                        MySqlCommand coand = new MySqlCommand($"UPDATE registo SET Morada=@Morada, PIN=@PIN, Idade=@Idade WHERE (ID = {Class1.iduser})",connection);
                        coand.Parameters.AddWithValue("@Morada", textBox1.Text);
                        coand.Parameters.AddWithValue("@PIN", textBox2.Text);
                        coand.Parameters.AddWithValue("@Idade", textBox4.Text);
                        coand.ExecuteNonQuery();
                        MessageBox.Show("Os seus dados foram atualizados!");

                        panel2.Visible = false;
                        Sessao.Visible = true;
                        Sair.Visible = true;
                        Eliminar.Visible = true;
                        Adicionar.Visible = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Reveja os seus Dados!");
                }
                finally
                {
                    connection.Close();
                }
            }         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Sessao.Visible = true;
            Sair.Visible = true;
            Eliminar.Visible = true;
            Adicionar.Visible = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
