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
    public partial class ConsultaVendedor : Form
    {
        public ConsultaVendedor()
        {
            InitializeComponent();
        }



        public void DadosListView()
        {
            listView1.Items.Clear();
            SqlDataReader dados;
            Veterinario vet = new Veterinario();
            if (textBox1.Text.Length == 0)
                dados = vet.CarregaCliLis();
            else
                dados = vet.CarregaCliLis(textBox1.Text);


            if (dados != null)
            {
                while (dados.Read())
                {
                    ListViewItem lv = new ListViewItem(dados.GetInt32(0).ToString());
                    lv.SubItems.Add(dados.GetString(1));
                    lv.SubItems.Add(dados.GetString(3));
                    lv.SubItems.Add(dados.GetString(2));
                 //   lv.SubItems.Add(dados.GetString(4));
                    listView1.Items.Add(lv);
                }
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            EditarVeterinario vet = new EditarVeterinario(int.Parse(EDTvet.Text));
            vet.Show();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DadosListView();
        }

        private void ConsultaVendedor_Load(object sender, EventArgs e)
        {
            DadosListView();
        }
    }
}
