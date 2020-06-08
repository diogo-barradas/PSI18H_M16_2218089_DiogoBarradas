using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSI18H_M16_2218089_DiogoBarradas
{
    public partial class Lista3 : UserControl
    {
        public Lista3()
        {
            InitializeComponent();
        }

        private string _NomeEmpresa;
        private string _Hora;
        private string _Valor;
        private string _IDdestinatario;
        private string _IDremetente;

        public string NNomeEmpresa
        {
            get { return _NomeEmpresa; }
            set { _NomeEmpresa = value; Nome.Text = value; }
        }

        public string HHora
        {
            get { return _Hora; }
            set { _Hora = value; Hora.Text = value; }
        }

        public string VValor
        {
            get { return _Valor; }
            set { _Valor = value; Valor.Text = value; }
        }

        public string IIDdestinatario
        {
            get { return _IDdestinatario; }
            set { _IDdestinatario = value; IDdestinatario.Text = value; }
        }
        public string IIDremetente
        {
            get { return _IDremetente; }
            set { _IDremetente = value; IDremetente.Text = value; }
        }
    }
}
