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
    public partial class Donativos : Form
    {
        public Donativos()
        {
            InitializeComponent();
            webBrowser1.Visible = false;
            pictureBox5.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            webBrowser1.Visible = false;
            pictureBox5.Visible = false;
        }

        //abrir site Nariz Vermelho
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.narizvermelho.pt/");
            webBrowser1.Visible = true;
            pictureBox5.Visible = true;
        }

        //abrir site Crescer
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://crescer.org/");
            webBrowser1.Visible = true;
            pictureBox5.Visible = true;
        }

        //abrir site medicos do mundo
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://www.medicosdomundo.pt/");
            webBrowser1.Visible = true;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = false;
            pictureBox5.Visible = false;
        }
    }
}
