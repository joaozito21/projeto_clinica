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
    public partial class EditarCliente : Form
    {
        int id_cli;
        List<Clientes> lista = new List<Clientes>();
        public EditarCliente(int id)
        {
            id_cli = id;
            Clientes cli = new Clientes();
            List<Clientes> lis = new List<Clientes>();
            lis = cli.Carregarcliente(id);
            lista = lis;
          
            InitializeComponent();
            CarregaDados();
        }

        public void CarregaDados()
        {
            if (lista.Count > 0)
            {
                edtNome.Text = lista[0].nome_cli;
                edtcidade.Text = lista[0].cid_cli;
                cmbEstado.Text = lista[0].est_cli;
                cmbGenero.Text = lista[0].sex_cli;
                edtend.Text = lista[0].endereco_cli;

                mascData.Text = lista[0].dat_cli;
                mask.Text = lista[0].tel_cli;
            }
            else
            {
                MessageBox.Show("CLIENTE NÃO ENCONTADO", "AVISO");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.AlterarDados(edtNome.Text, edtend.Text, cmbEstado.Text, cmbGenero.Text,
                                edtcidade.Text, mascData.Text, mask.Text, id_cli.ToString());
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.ExlcuirDados(id_cli.ToString());
            this.Close();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Edtcidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Edtend_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Mask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MascData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
