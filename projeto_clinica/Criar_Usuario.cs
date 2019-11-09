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
    public partial class Criar_Usuario : Form
    {
        public Criar_Usuario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.CadastrarDados(EdtNome.Text, edtsenha.Text, edtPer.Text, textBox1.Text);
            this.Close();
        }
    }
}
