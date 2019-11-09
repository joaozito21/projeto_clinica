using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_clinica
{
    public partial class PagamentoConsulta : Form
    {
        int id_pag;
        decimal SOM;
        string TEXTO;
        public PagamentoConsulta(int id)
        {
            id_pag = id;
            InitializeComponent();
            Pagamento pag = new Pagamento();
            if (pag.quantPago(id_pag) != null)
                SOM = 100 - pag.quantPago(id_pag);
            else
                SOM = 100;
            TEXTO = SOM.ToString();
            label2.Text=TEXTO;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (SOM > decimal.Parse(textBox1.Text))
            {
                Pagamento PAG = new Pagamento();
                PAG.InserirDados(cmbFormaPagamento.Text, decimal.Parse(textBox1.Text), id_pag);

            }
            else
            {
                Pagamento PAG = new Pagamento();
                PAG.InserirDados(cmbFormaPagamento.Text,SOM, id_pag);
                PAG.FecharConsulta(id_pag);

            }

        }
    }
}
