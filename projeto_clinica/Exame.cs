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
    class Exame
    {
        string caminho = "Data Source=JOAO-PC\\SQLEXPRESS; Initial Catalog=projeto_linguagem;Integrated Security=SSPI;";

        public void CadastrarDados(string nome,double valor)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "insert into cat_exame values(@desc,@valor)";


            comando.Parameters.Add(new SqlParameter("@desc", nome));
            comando.Parameters.Add(new SqlParameter("@valor",valor));
           
            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
            conexao.Close();
        }

        public void MarcaExame(string data, string id,int id_Con)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select id_cat_exame from cat_exame WHERE desc_cat_exame  = @VET";
            comando.Parameters.Add(new SqlParameter("@VET", id));
            int id_vet = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            comando.CommandText = "insert into exame values(@data,0,@idexame,@id)";


            comando.Parameters.Add(new SqlParameter("@data", data));
            comando.Parameters.Add(new SqlParameter("@idexame", id_vet));
            comando.Parameters.Add(new SqlParameter("@id", id_Con));

            comando.ExecuteNonQuery();
            MessageBox.Show("MARCADO EXAME COM SUCESSO", "AVISO");
            conexao.Close();
        }

        public List<string> CarregaEXAMELis()
        {

            SqlConnection conexao = new SqlConnection(caminho);
            List<string> LISTA =new List<string>();
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "SELECT desc_cat_exame FROM	cat_exame";




            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            if (LINHA != null)
            {
                while (LINHA.Read())
                {
                   LISTA.Add( LINHA.GetString(0));
                }
            }

            return LISTA;

        }

        public SqlDataReader CarregaExaLis(string texto = " ")
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            if (texto == " ")
                comando.CommandText = " select exame.id_exame,CLIENTES.NOME_CLI,exame.data_exa,cat_exame.valor FROM exame " +
       " INNER JOIN Consultas on exame.id_con = Consultas.id_con  " +

       " inner join CLIENTES on  Consultas.nome_cli_con = CLIENTES.ID_CLI  " +

       " inner join cat_exame on exame.id_cat_exa = cat_exame.id_cat_exame";
            else
            {

                comando.CommandText = "select exame.id_exame,CLIENTES.NOME_CLI,exame.data_exa,cat_exame.valor FROM exame "+
                                     " INNER JOIN Consultas on exame.id_con = Consultas.id_con "+
                                     " inner join CLIENTES on  Consultas.nome_cli_con = CLIENTES.ID_CLI"+
                                     "  inner join cat_exame on exame.id_cat_exa = cat_exame.id_cat_exame "+
                                      " where CLIENTES.NOME_CLI like '%"+texto+"%'";
            }


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            return LINHA;

        }

        public decimal quantPago(int id)
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select isnull(sum(pag),0) from pagamentosExa where codCon =" + id;




            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            decimal din = 0;

            if (LINHA != null)
            {
                while (LINHA.Read())

                {
                    din = LINHA.GetDecimal(0);

                }
            }




            return din;
        }

        public decimal precoTot(int id)
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select cat_exame.valor from exame inner join cat_exame on exame.id_cat_exa = cat_exame.id_cat_exame " +
                "                  where exame.id_exame  =" + id;




            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            decimal din = 0;

            if (LINHA != null)
            {
                while (LINHA.Read())

                {
                    din = LINHA.GetDecimal(0);

                }
            }




            return din;
        }

        public void InserirDados(string form, decimal val, int id)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            ;
            comando.CommandText = "insert into pagamentosExa values(@form,@valor,getdate(),@id)";
            comando.Parameters.Add(new SqlParameter("@form", form));
            comando.Parameters.Add(new SqlParameter("@valor", val));
            comando.Parameters.Add(new SqlParameter("@id", id));

            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
        }

        public void FecharExame(int id)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            ;
            comando.CommandText = "update exame set pag_exame =1 where id_exame =" + id;


            comando.ExecuteNonQuery();
        }



    }
}
