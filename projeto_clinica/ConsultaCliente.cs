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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }
        public void DadosListView()
        {
            listView1.Items.Clear();
            SqlDataReader dados;
            Clientes CLI = new Clientes();
            if (textBox1.Text.Length == 0)
                dados = CLI.CarregaCliLis();
            else
                dados = CLI.CarregaCliLis(textBox1.Text);


            if (dados != null)
            {
                while (dados.Read())
                {
                    ListViewItem lv = new ListViewItem(dados.GetInt32(0).ToString());
                    lv.SubItems.Add(dados.GetString(1));
                    lv.SubItems.Add(dados.GetString(2));
                    lv.SubItems.Add(dados.GetString(3));
                    lv.SubItems.Add(dados.GetString(4));
                    listView1.Items.Add(lv);
                }
            }
        }


        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            DadosListView();

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {
            
        }

        private void BindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             
           cLIENTESBindingSource.Filter = "where NOME_CLI LIKE '%" + textBox1.Text + "%'";
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           EditarCliente edi = new EditarCliente(int.Parse(EdtIdCli.Text));
            edi.ShowDialog();
            DadosListView();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DadosListView();
        }

        private void EdtIdCli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
