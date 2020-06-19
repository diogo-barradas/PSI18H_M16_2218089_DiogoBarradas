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
    public partial class FormAdmin : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        MySqlConnection cnn = new MySqlConnection(@"server=127.0.0.1;uid=root;database=psi18h_m16_2218089_diogobarradas");

        public FormAdmin()
        {
            InitializeComponent();

            cnn.Open();
            string tabela = $"SELECT * FROM registo;";
            MySqlCommand cmd = new MySqlCommand(tabela, cnn);
            MySqlDataAdapter antiga = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            antiga.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //atualizar o dataGrid
            cnn.Open();
            string bduser = $"SELECT * FROM registo;";
            MySqlCommand cmd = new MySqlCommand(bduser, cnn);
            MySqlDataAdapter nova = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            nova.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //atualizar o dataGrid
            cnn.Open();
            string bddeposito = $"SELECT * FROM depositos;";
            MySqlCommand cmd = new MySqlCommand(bddeposito, cnn);
            MySqlDataAdapter nova = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            nova.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //atualizar o dataGrid
            cnn.Open();
            string bdlevantar = $"SELECT * FROM levantamentos;";
            MySqlCommand cmd = new MySqlCommand(bdlevantar, cnn);
            MySqlDataAdapter nova = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            nova.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //atualizar o dataGrid
            cnn.Open();
            string bdtrans = $"SELECT * FROM transferencias;";
            MySqlCommand cmd = new MySqlCommand(bdtrans, cnn);
            MySqlDataAdapter nova = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            nova.Fill(table);
            dataGridView1.DataSource = table;
            cnn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu guest = new Menu();
            guest.ShowDialog();
        }

        //Arrastar Janela
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.FecharFinal2;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.MaximizarFinal1;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.MinimizarFinal1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.exitfinal;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.exitfinal1;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.MinimizarFinal;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.MaximizarFinal;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.FecharFinal1;
        }
    }
}