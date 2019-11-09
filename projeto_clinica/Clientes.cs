using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace projeto_clinica
{
    class Clientes
    {
        string caminho = "Data Source=JOAO-PC\\SQLEXPRESS; Initial Catalog=projeto_linguagem;Integrated Security=SSPI;";

        public string nome_cli { get; set;}
        public string endereco_cli { get; set; }
        public string est_cli { get; set; }
        public string sex_cli { get; set; }
        public string cpf_cli { get; set; }
        public string cid_cli { get; set; }
        public string dat_cli { get; set; }
        public string tel_cli { get; set; }
        public void CadastrarDados(string nome,string end,string est,string sex,string cid,string dat,string tel)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "insert into CLIENTES values(@nome,@endereco,@est,@sex,@cpf,@cid,@dat,@tel)";


            comando.Parameters.Add(new SqlParameter("@nome", nome));
            comando.Parameters.Add(new SqlParameter("@endereco",end));
            comando.Parameters.Add(new SqlParameter("@est",est));
            comando.Parameters.Add(new SqlParameter("@sex",sex));
            comando.Parameters.Add(new SqlParameter("@cpf"," "));
            comando.Parameters.Add(new SqlParameter("@Cid",cid));
            comando.Parameters.Add(new SqlParameter("@dat",dat));
            comando.Parameters.Add(new SqlParameter("@tel", tel));
            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
            conexao.Close();
        }

        public void AlterarDados(string nome, string end, string est, string sex, string cid, 
                                string dat, string tel,string ID)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "UPDATE CLIENTES SET NOME_CLI =@nome,ENDERECO_CLI = @endereco,ESTADO_CLI=" +
                "                  @est,SEXO_CLI=@sex,CIDADE_CLI=@cid,DATA_NASC_CLI=@dat," +
                "                  TEL_CLI=@tel WHERE ID_CLI = @id";

            comando.Parameters.Add(new SqlParameter("@id",ID));

            comando.Parameters.Add(new SqlParameter("@nome", nome));
            comando.Parameters.Add(new SqlParameter("@endereco", end));
            comando.Parameters.Add(new SqlParameter("@est", est));
            comando.Parameters.Add(new SqlParameter("@sex", sex));
            comando.Parameters.Add(new SqlParameter("@Cid", cid));
            comando.Parameters.Add(new SqlParameter("@dat", dat));
            comando.Parameters.Add(new SqlParameter("@tel", tel));
            comando.ExecuteNonQuery();
            MessageBox.Show("ALTERADO COM SUCESSO", "AVISO");

            conexao.Close();
        }

        public void ExlcuirDados( string ID)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "delete from CLIENTES WHERE ID_CLI = @id";

            comando.Parameters.Add(new SqlParameter("@id", ID));

            comando.ExecuteNonQuery();
            MessageBox.Show("EXLUIDO COM SUCESSO", "AVISO");

            conexao.Close();
        }


        public List<Clientes> Carregarcliente(int id)
        {
            List<Clientes> lis = new List<Clientes>();
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "select * from CLIENTES WHERE id_cli = @id";
            comando.Parameters.Add(new SqlParameter("@id",id));

            
            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();

            Clientes clie = new Clientes();
                
            if (LINHA.Read())
            {
                clie.nome_cli = LINHA.GetString(1);
                clie.endereco_cli = LINHA.GetString(2);
                clie.est_cli = LINHA.GetString(3);
                clie.sex_cli = LINHA.GetString(4);
                clie.cpf_cli = LINHA.GetString(5);
                clie.cid_cli = LINHA.GetString(6);
                clie.dat_cli = LINHA.GetString(7);
                clie.tel_cli = LINHA.GetString(8);

                lis.Add(clie);
            }




            return lis;
        }

        public SqlDataReader CarregaCliLis(string texto = " ")
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            if (texto == " ")
                comando.CommandText = " select ID_CLI,NOME_CLI,ENDERECO_CLI,ESTADO_CLI,TEL_CLI from CLIENTES";
            else
            {
                comando.CommandText = "select ID_CLI,NOME_CLI,ENDERECO_CLI,ESTADO_CLI,TEL_CLI from CLIENTES " +
                                      "WHERE NOME_CLI LIKE  '%"+ texto+"%'";
            }


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            return LINHA;

        }





    }
}
