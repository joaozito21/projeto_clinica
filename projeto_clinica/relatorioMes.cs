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
    public partial class relatorioMes : Form
    {
        public relatorioMes()
        {
            InitializeComponent();
        }

        private void RelatorioMes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_linguagemDataSet2.relatPagExa'. Você pode movê-la ou removê-la conforme necessário.
            this.relatPagExaTableAdapter.Fill(this.projeto_linguagemDataSet2.relatPagExa);

        }
    }
}
