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
    public partial class EditaConsulta : Form
    {
        int id_con;
        List<Consulta> lista = new List<Consulta>();
        public EditaConsulta(int id)
        {
            id_con = id;
            Consulta cli = new Consulta();
            List<Consulta> lis = new List<Consulta>();
            lis = cli.Carregarcliente(id);
            lista = lis;

            InitializeComponent();
            CarregaDados();
        }
        public void CarregaDados()
        {
            if (lista.Count > 0)
            {
                edtNomeCli.Text = lista[0].nome_cli_con;
                edtNomeAni.Text = lista[0].nome_ani_con;
                edtNomeVet.Text = lista[0].nome_vet_con;
                mascData.Text = lista[0].data_con;
                edtMot.Text = lista[0].motivo_con;

            }
            else
            {
                MessageBox.Show("CLIENTE NÃO ENCONTADO", "AVISO");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.AlterarDados(id_con.ToString(),mascData.Text,edtMot.Text,edtNomeCli.Text
                                ,edtNomeAni.Text,edtNomeVet.Text);
            this.Close();
        }
    }
}
