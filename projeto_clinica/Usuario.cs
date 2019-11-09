using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace projeto_clinica
{
    class Usuario
    {
        string caminho = "Data Source=JOAO-PC\\SQLEXPRESS; Initial Catalog=projeto_linguagem;Integrated Security=SSPI;";

        public string GerarMD5(string valor)

        {
            MD5 md5Hasher = MD5.Create();
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(valor));
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < valorCriptografado.Length; i++)
            {

                strBuilder.Append(valorCriptografado[i].ToString("x2"));

            }
            return strBuilder.ToString();

        }
        public void CadastrarDados(string nome,string senha ,string perSeg,string resPerSeg)
        {
            string senhacrip;
           
            senhacrip = GerarMD5(senha); 
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "insert into Usuarios values(@nome,@senha,@PerSeg,@RespPegSeg)";


            comando.Parameters.Add(new SqlParameter("@nome", nome));
            comando.Parameters.Add(new SqlParameter("@senha",senhacrip));
            comando.Parameters.Add(new SqlParameter("@PerSeg",perSeg));
            comando.Parameters.Add(new SqlParameter("@RespPegSeg",resPerSeg));

            comando.ExecuteNonQuery();

            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
            conexao.Close();
        }

        public bool Carregarcliente(string nome,string sen)
        {
            
            SqlConnection conexao = new SqlConnection(caminho);
            try
            {
                string TEXTO = GerarMD5(sen);
                conexao.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "select * from Usuarios WHERE Nome_usuario = @nome and Senha = @sen ";
                comando.Parameters.Add(new SqlParameter("@nome", nome));
                comando.Parameters.Add(new SqlParameter("@sen",TEXTO));

                comando.CommandType = CommandType.Text;
                SqlDataReader LINHA = comando.ExecuteReader();



                if (LINHA.Read())
                {
                    return true;
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return false;
        }

    }
}
