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
    public partial class PagamentoExame : Form
    {
        int id_pag;
        decimal SOM,tot;
        string TEXTO;
        public PagamentoExame(int ids)
        {
            id_pag = ids;
           
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (SOM > decimal.Parse(textBox1.Text))
            {
                Exame PAG = new Exame();
                PAG.InserirDados(cmbFormaPagamento.Text, decimal.Parse(textBox1.Text), id_pag);

            }
            else
            {
                Exame PAG = new Exame();
                PAG.InserirDados(cmbFormaPagamento.Text, SOM, id_pag);
                PAG.FecharExame(id_pag);

            }
            this.Close();
        }

        private void PagamentoExame_Load(object sender, EventArgs e)
        {
            Exame pag = new Exame();
             tot = pag.precoTot(id_pag);

            SOM = 0;
            SOM = tot - pag.quantPago(id_pag);
            //MessageBox.Show(tot + "---" + pag.quantPago(id_pag).ToString());


            //TEXTO = SOM.ToString();
            label2.Text = SOM.ToString();
        }
    }
}
