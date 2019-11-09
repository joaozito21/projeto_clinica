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
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Consulta con = new Consulta();
            con.InserirDados(mascData.Text, edtMot.Text, edtNomeCli.Text, edtNomeAni.Text, edtNomeVet.Text);
        }
    }
}
