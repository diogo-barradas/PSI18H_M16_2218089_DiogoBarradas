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
            Application.Exit();
        }

        private void Sessao_Click(object sender, EventArgs e)
        {
            //FECHAR O MENU POR BAIXO 
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            //FECHAR O MENU POR BAIXO 
            this.Close();
            Registar registo = new Registar();
            registo.ShowDialog();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
