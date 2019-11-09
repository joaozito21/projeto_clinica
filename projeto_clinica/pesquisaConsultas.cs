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
    public partial class pesquisaConsultas : Form
    {
        public pesquisaConsultas()
        {
            InitializeComponent();
        }
        public void DadosListView()
        {
            listView1.Items.Clear();
            SqlDataReader dados;
            Consulta CLI = new Consulta();
            if (textBox1.Text.Length == 0)
                dados = CLI.CarregaConLis();
            else
                dados = CLI.CarregaConLis(textBox1.Text);


            if (dados != null)
            {
                while (dados.Read())
                {
                    ListViewItem lv = new ListViewItem(dados.GetInt32(0).ToString());
                    lv.SubItems.Add(dados.GetString(1));
                    lv.SubItems.Add(dados.GetString(2));
                    lv.SubItems.Add(dados.GetString(3));
                    lv.SubItems.Add(dados.GetString(4));
                    lv.SubItems.Add(dados.GetString(5));
                    listView1.Items.Add(lv);
                }
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DadosListView();
        }

        private void PesquisaConsultas_Load(object sender, EventArgs e)
        {
            DadosListView();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            EditaConsulta edt = new EditaConsulta(int.Parse(EdtIdCli.Text));
            edt.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MarcaExame mar = new MarcaExame(int.Parse(textBox2.Text));
            mar.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PagamentoConsulta pag = new PagamentoConsulta(int.Parse(textBox3.Text));
            pag.Show();
            DadosListView();
        }
    }
}
