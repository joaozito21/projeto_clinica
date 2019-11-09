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
    class Animais
    {
        string caminho = "Data Source=JOAO-PC\\SQLEXPRESS; Initial Catalog=projeto_linguagem;Integrated Security=SSPI;";

        public void AlterarDados(string nome, string nome_ani, string raca, string esp, string dat,int id_cli)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
   
            comando.CommandText = "UPDATE ANIMAIS SET NOME_ANI=@ani_no,RACA_ANI=@ani_rac," +
                "                                  ESPECIE_ANI=@esp,DATA_NASC_ANI=@dat " +
                "                  WHERE id_ani = @id_cli";
            comando.Parameters.Add(new SqlParameter("@ani_no", nome_ani));
            comando.Parameters.Add(new SqlParameter("@ani_rac", raca));
            comando.Parameters.Add(new SqlParameter("@esp", esp));
            comando.Parameters.Add(new SqlParameter("@dat", dat));
            comando.Parameters.Add(new SqlParameter("@id_cli", id_cli));
            comando.ExecuteNonQuery();
            MessageBox.Show("ALTERADO REGISTRO COM SUCESSO", "AVISO");
        }
        public void InserirDados(string nome,string nome_ani,string raca,string esp,string dat)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select ID_CLI from CLIENTES WHERE NOME_CLI  = @NOM";
            comando.Parameters.Add(new SqlParameter("@NOM", nome));
            int id_cli = (int)comando.ExecuteScalar();
            comando.CommandText = "insert into ANIMAIS values(@ani_no,@ani_rac,@esp,@dat,@id_cli)";
            comando.Parameters.Add(new SqlParameter("@ani_no",nome_ani));
            comando.Parameters.Add(new SqlParameter("@ani_rac",raca));
            comando.Parameters.Add(new SqlParameter("@esp", esp));
            comando.Parameters.Add(new SqlParameter("@dat",dat));
            comando.Parameters.Add(new SqlParameter("@id_cli",id_cli));
            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
        }

        public string nome_ani { get; set; }

        public string raca_ani { get; set; }

        public string esp_ani { get; set; }
        public string data_ani { get; set; }

        public string Nome_dono { get; set; }


        public void ExlcuirDados(string ID)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "delete from ANIMAIS WHERE ID_ANI = @id";

            comando.Parameters.Add(new SqlParameter("@id", ID));

            comando.ExecuteNonQuery();
            MessageBox.Show("EXLUIDO COM SUCESSO", "AVISO");

            conexao.Close();
        }

        public SqlDataReader CarregaCliLis(string texto =" ")
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            if (texto == " ")
                comando.CommandText = " select ID_ANI,NOME_ANI,RACA_ANI,ESPECIE_ANI,NOME_CLI from ANIMAIS as ANI " +
                                      " LEFT JOIN CLIENTES AS ClI on ANI.id_cli_ani = CLI.ID_CLI ";
            else
            {
                comando.CommandText = " select ID_ANI,NOME_ANI,RACA_ANI,ESPECIE_ANI,NOME_CLI from ANIMAIS as ANI " +
                                      " LEFT JOIN CLIENTES AS ClI on ANI.id_cli_ani = CLI.ID_CLI " +
                                      "WHERE CLI.NOME_CLI LIKE '%"+ texto +"%'";
            }


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            return LINHA;

        }

        public List<Animais> CarregarAnimal(int id)
        {
            List<Animais> lis = new List<Animais>();
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select ID_ANI,NOME_ANI,RACA_ANI,ESPECIE_ANI,DATA_NASC_ANI,NOME_CLI from ANIMAIS as ANI " +
                                   " LEFT JOIN CLIENTES AS ClI on ANI.id_cli_ani = CLI.ID_CLI " +
                                   "WHERE ANI.ID_ANI = @id";
            comando.Parameters.Add(new SqlParameter("@id", id));


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();

            Animais ani = new Animais();

            if (LINHA.Read())
            {
                ani.nome_ani = LINHA.GetString(1);
                ani.raca_ani = LINHA.GetString(2);
                ani.esp_ani = LINHA.GetString(3);
                ani.data_ani = LINHA.GetString(4);
                ani.Nome_dono = LINHA.GetString(5);
           

                lis.Add(ani);
            }




            return lis;
        }
    }
}
