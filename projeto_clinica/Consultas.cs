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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            Veterinario VET = new Veterinario();
            Clientes CLI = new Clientes();
            List<string> vets = new List<string>();
            List<string> clis = new List<string>();
            vets = VET.CarregaVettLis();
            clis = CLI.CarregaclisLis();
            InitializeComponent();
            for (int i = 0; i <= vets.Count() - 1; i++)
            {
                edtNomeVet.Items.Add(vets[i]);

            }
            for (int i = 0; i <= clis.Count() - 1; i++)
            {
                etdNomeCli.Items.Add(clis[i]);

            }
            if (etdNomeCli.Items.Count > 0)
                etdNomeCli.TabIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.InserirDados(mascData.Text, edtMot.Text, etdNomeCli.Text, edtNomeAni.Text, edtNomeVet.Text);
        }

        private void EtdNomeCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animais anis = new Animais();
            List<string> ani = new List<string>();
            ani = anis.CarregaaniLis(etdNomeCli.Text);
            for (int i = 0; i <= ani.Count() - 1; i++)
            {
                edtNomeAni.Items.Add(ani[i]);

            }
        }
    }
}
