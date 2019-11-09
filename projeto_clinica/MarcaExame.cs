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
    public partial class MarcaExame : Form
    {
        int con;
        public MarcaExame(int id_con)

        {
            con = id_con;
            Exame exa = new Exame();
            List<string> tes = new List<string>();
            tes = exa.CarregaEXAMELis();
            InitializeComponent();
            for(int i=0;i<=tes.Count()-1;i++)
                {
                comboBox1.Items.Add(tes[i]);

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Exame exa = new Exame();
            exa.MarcaExame(maskedTextBox1.Text, comboBox1.Text, con);
        }
    }
}
