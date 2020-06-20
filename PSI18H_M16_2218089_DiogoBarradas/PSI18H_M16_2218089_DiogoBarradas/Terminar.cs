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
    public partial class Terminar : Form
    {
        public Terminar()
        {
            InitializeComponent();
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
            if (MessageBox.Show("Tem a certeza que deseja adicionar uma nova conta?", "Adicionar Conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Registar registo = new Registar();
                registo.ShowDialog();
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
    }
}
