﻿using System;
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
    public partial class Menu : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Menu()
        {
            InitializeComponent();
            panel1.Visible = false;
            Slidepanel.Height = button1.Height;
            Slidepanel.Top = button1.Top;
        }

        //Minimizar App
        private void MinimizarApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Maximizar App
        private void MaximizarApp_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        //Fechar App
        private void FecharApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Arrastar Janela
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        //Arrastar Janela
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        //Arrastar Janela
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        //Abrir e fechar Painel 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
            Slidepanel.Height = button1.Height;
            Slidepanel.Top = button1.Top;
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
        }

        //MDI
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            openChildForm(new Consultar());
            Slidepanel.Height = button2.Height;
            Slidepanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            openChildForm(new Depositos());
            Slidepanel.Height = button3.Height;
            Slidepanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
            Slidepanel.Height = button4.Height;
            Slidepanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
            Slidepanel.Height = button5.Height;
            Slidepanel.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
            Slidepanel.Height = button6.Height;
            Slidepanel.Top = button6.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
            Slidepanel.Height = button7.Height;
            Slidepanel.Top = button7.Top;
        }

        private void FecharApp_MouseHover(object sender, EventArgs e)
        {
            FecharApp.Image = Properties.Resources.FecharFinal1;
        }

        private void FecharApp_MouseLeave(object sender, EventArgs e)
        {
            FecharApp.Image = Properties.Resources.FecharFinal2;
        }

        private void MaximizarApp_MouseHover(object sender, EventArgs e)
        {
            MaximizarApp.Image = Properties.Resources.MaximizarFinal;
        }

        private void MaximizarApp_MouseLeave(object sender, EventArgs e)
        {
            MaximizarApp.Image = Properties.Resources.MaximizarFinal1;
        }

        private void MinimizarApp_MouseHover(object sender, EventArgs e)
        {
            MinimizarApp.Image = Properties.Resources.MinimizarFinal;
        }

        private void MinimizarApp_MouseLeave(object sender, EventArgs e)
        {
            MinimizarApp.Image = Properties.Resources.MinimizarFinal1;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBox2, "Selecione uma opção do menu !");
        }

    }
}