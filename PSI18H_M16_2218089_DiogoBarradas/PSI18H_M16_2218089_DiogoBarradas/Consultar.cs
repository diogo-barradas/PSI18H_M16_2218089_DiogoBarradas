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
    public partial class Consultar : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dt;


        public Consultar()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = @"server=127.0.0.1;uid=root;database=psi18h_m16_2218089_diogobarradas";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT Descriçao, Hora, Valor FROM depositos", cn);
            dt = cm.ExecuteReader();
            while (dt.Read())
            {
                Lista v = new Lista();
                v.NNomeEmpresa = dt["Descriçao"].ToString();
                v.HHora = dt["Hora"].ToString();
                v.VValor = dt["Valor"].ToString();

                flowLayoutPanel1.Controls.Add(v);
            }
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT Descriçao, Hora, Valor FROM levantamentos", cn);
            dt = cm.ExecuteReader();
            while (dt.Read())
            {
                Lista2 v = new Lista2();
                v.NNomeEmpresa = dt["Descriçao"].ToString();
                v.HHora = dt["Hora"].ToString();
                v.VValor = dt["Valor"].ToString();

                flowLayoutPanel1.Controls.Add(v);
            }
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            cn.Open();
            cm = new MySqlCommand("SELECT Descriçao, Hora, Valor, idRemetente, idDestinatario FROM transferencias", cn);
            dt = cm.ExecuteReader();
            while (dt.Read())
            {
                Lista3 v = new Lista3();
                v.NNomeEmpresa = dt["Descriçao"].ToString();
                v.HHora = dt["Hora"].ToString();
                v.VValor = dt["Valor"].ToString();
                v.IIDremetente = dt["idRemetente"].ToString();
                v.IIDdestinatario = dt["idDestinatario"].ToString();

                flowLayoutPanel1.Controls.Add(v);
            }
            cn.Close();
        }
    }
}