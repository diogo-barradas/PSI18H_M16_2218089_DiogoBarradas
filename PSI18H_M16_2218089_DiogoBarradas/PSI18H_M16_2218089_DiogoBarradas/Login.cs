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

namespace PSI18H_M16_2218089_DiogoBarradas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
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
