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
    public partial class CadastroAnimal : Form
    {
        public CadastroAnimal()
        {
            InitializeComponent();
        }

        private void CadastroAnimal_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Animais ANI = new Animais();
            ANI.InserirDados(edtCli.Text,edtNome.Text,EdtRac.Text,edtEsp.Text,mascData.Text);
            this.Close();
        }
    }
}
