using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace projeto_clinica
{
    public partial class PesquisarExame : Form
    {
        public PesquisarExame()
        {
            InitializeComponent();
        }
        public void DadosListView()
        {
            listView1.Items.Clear();
            SqlDataReader dados;
            Exame exa = new Exame();
            if (textBox1.Text.Length == 0)
                dados = exa.CarregaExaLis();
            else
                dados = exa.CarregaExaLis(textBox1.Text);


            if (dados != null)
            {
                while (dados.Read())
                {
                    ListViewItem lv = new ListViewItem(dados.GetInt32(0).ToString());
                    lv.SubItems.Add(dados.GetString(1));
                    lv.SubItems.Add(dados.GetString(2));
                    lv.SubItems.Add(dados.GetDecimal(3).ToString());
                
                    listView1.Items.Add(lv);
                }
            }
        }

        private void PesquisarExame_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projeto_linguagemDataSet1.teste'. Você pode movê-la ou removê-la conforme necessário.
            this.testeTableAdapter.Fill(this.projeto_linguagemDataSet1.teste);
            DadosListView();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DadosListView();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PagamentoExame test = new PagamentoExame(int.Parse(textBox2.Text));
            test.Show();
        }
    }
}
