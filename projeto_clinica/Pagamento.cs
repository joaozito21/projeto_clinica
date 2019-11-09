using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace projeto_clinica
{
    class Pagamento
    {
        string caminho = "Data Source=JOAO-PC\\SQLEXPRESS; Initial Catalog=projeto_linguagem;Integrated Security=SSPI;";
        public decimal quantPago(int id)
        {
           
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select isnull(sum(pag),0) from pagamentos where codCon =" + id; 
        
        


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            decimal din=0;

            if (LINHA != null)
            {
                while (LINHA.Read())

                {    
                    din = LINHA.GetDecimal(0);

                }
            }




            return din;
        }

        public void FecharConsulta(int id)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            ;
            comando.CommandText = "update Consultas set confPag =1 where id_con =" + id;


            comando.ExecuteNonQuery();
        }

        public void InserirDados(string form,decimal val,int id)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            ;
            comando.CommandText = "insert into pagamentos values(@form,@valor,getdate(),@id)";
            comando.Parameters.Add(new SqlParameter("@form", form));
            comando.Parameters.Add(new SqlParameter("@valor",val));
            comando.Parameters.Add(new SqlParameter("@id", id));
           
            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
        }
        public void Consultapaga(string form, decimal val, int id)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            ;
            comando.CommandText = "insert into pagamentos values(@form,@valor,getdate(),@id)";
          

            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
        }


    }


}
