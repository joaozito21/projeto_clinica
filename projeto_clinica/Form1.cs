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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente con = new ConsultaCliente();
            con.Show();
        }

        private void AnimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAnimal cadAni =new CadastroAnimal();
            cadAni.Show();
        }

        private void AnimaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaAnimais con = new ConsultaAnimais();
            con.Show();
        }

        private void VeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVet vet = new FormVet();
            vet.Show();
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VeterinariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ConsultaVendedor  edtVet = new ConsultaVendedor();
            edtVet.Show();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas con = new Consultas();
            con.Show();
        }

        private void MarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro_exames cad = new cadastro_exames();
            cad.Show();
        }

        private void PesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pesquisaConsultas pesCon = new pesquisaConsultas();
            pesCon.Show();
        }

        private void ExameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisarExame pes = new PesquisarExame();
            pes.Show();
        }
    }
}
