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
    public partial class cadastro_exames : Form
    {
        public cadastro_exames()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Exame exa = new Exame();
            exa.CadastrarDados(DescExa.Text, double.Parse(valExa.Text));
            this.Close();
        }
    }
}
