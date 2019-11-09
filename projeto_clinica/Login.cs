using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace projeto_clinica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string GerarMD5(string valor)

        {
            MD5 md5Hasher = MD5.Create();
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < valorCriptografado.Length; i++){

                strBuilder.Append(valorCriptografado[i].ToString("x2"));

            }
             return strBuilder.ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            if (us.Carregarcliente(textBox1.Text, EdtSenha.Text))
            {
                Form1 fp = new Form1();
                fp.Show();
            }
            else
            {
                MessageBox.Show("usuario e senha incorretos");
            }
        
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSenha.Checked)
                EdtSenha.UseSystemPasswordChar = false;
            else
                EdtSenha.UseSystemPasswordChar = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Criar_Usuario ch = new Criar_Usuario();
            ch.Show();
          
        }
    }
}
