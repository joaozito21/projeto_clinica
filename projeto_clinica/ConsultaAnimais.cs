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
    public partial class ConsultaAnimais : Form
    {
        public ConsultaAnimais()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
         
        }

        public void DadosListView()
        {
            listView1.Items.Clear();
            SqlDataReader dados;
            Animais ani = new Animais();
            if (textBox1.Text.Length == 0)
                dados = ani.CarregaCliLis();
            else
                dados = ani.CarregaCliLis(textBox1.Text);


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

        private void ConsultaAnimais_Load(object sender, EventArgs e)
        {
            DadosListView();    
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            DadosListView();
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            string text = listView1.SelectedItems[0].Text.ToString();
            MessageBox.Show(text);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            EditaAnimal EDIANI = new EditaAnimal(int.Parse(EDTIDani.Text));
            EDIANI.Show();
        }
    }
}
