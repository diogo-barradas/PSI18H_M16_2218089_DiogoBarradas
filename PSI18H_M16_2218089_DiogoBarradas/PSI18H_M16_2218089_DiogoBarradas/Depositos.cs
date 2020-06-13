using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI18H_M16_2218089_DiogoBarradas
{
    public partial class Depositos : Form
    {
        public Depositos()
        {
            InitializeComponent();
            panel8.Visible = false;
            Saldo.Text = valorzero.ToString();
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
            if (textBox1.Text == " Montante" || textBox1.Text == "")
            {
                MessageBox.Show("Digite um valor !");
            }
            else
            {
                double addvalor = double.Parse(textBox1.Text);
                double valorfinal = valorzero += addvalor;
                Saldo.Text = valorfinal.ToString();
                textBox1.Text = " Montante";
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