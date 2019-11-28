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
    public partial class relatCon : Form
    {
        public relatCon()
        {
            InitializeComponent();
        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RelatCon_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_linguagemDataSet3.relatPagCon'. Você pode movê-la ou removê-la conforme necessário.
            this.relatPagConTableAdapter.Fill(this.projeto_linguagemDataSet3.relatPagCon);

        }
    }
}
