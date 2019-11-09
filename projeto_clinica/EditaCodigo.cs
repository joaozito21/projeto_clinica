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
    public partial class EditaAnimal : Form
    {
        int id_ani;
        List<Animais> lista = new List<Animais>();
        public EditaAnimal(int id)
        {
            id_ani = id;
            Animais ani = new Animais();
            List<Animais> lis = new List<Animais>();
            lis = ani.CarregarAnimal(id);
            lista = lis;
            InitializeComponent();
            CarregaDados();
        }

        public void CarregaDados()
        {
            edtNomeANI.Text = lista[0].nome_ani;
            RacAni.Text = lista[0].raca_ani;
            EdtEspAni.Text = lista[0].esp_ani;
            MascData.Text = lista[0].data_ani;
            EdtNomeCli.Text = lista[0].Nome_dono;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Animais ANI = new Animais();
            ANI.AlterarDados(EdtNomeCli.Text, edtNomeANI.Text, RacAni.Text
                             , EdtEspAni.Text, MascData.Text, id_ani);
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Animais ani = new Animais();
            ani.ExlcuirDados(id_ani.ToString());
            this.Close();
        }
    }
}
