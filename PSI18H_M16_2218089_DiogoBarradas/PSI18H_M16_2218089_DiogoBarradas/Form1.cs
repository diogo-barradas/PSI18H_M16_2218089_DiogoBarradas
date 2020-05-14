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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(1000);
            this.Hide();
            Form2 register = new Form2();
            register.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Data.Text = "Time: " + DateTime.Now.ToString("MM-dd-yyyy, HH:mm");
        }

    }
}