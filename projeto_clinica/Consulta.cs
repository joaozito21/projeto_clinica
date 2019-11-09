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
    class Consulta
    {
        string caminho = "Data Source=JOAO-PC\\SQLEXPRESS; Initial Catalog=projeto_linguagem;Integrated Security=SSPI;";

        public string data_con { get; set; }
        public string motivo_con { get; set; }
        public string nome_cli_con { get; set; }
        public string nome_ani_con { get; set; }
        public string nome_vet_con { get; set; }


        public void AlterarDados(string id, string dat, string mot, string nomeCli, string nomeAni,
                                string nomeVet)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select ID_CLI from CLIENTES WHERE NOME_CLI  = @NOM";
            comando.Parameters.Add(new SqlParameter("@NOM", nomeCli));
            int id_cli = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            comando.CommandText = " select ID_ANI from ANIMAIS WHERE id_cli_ani  = @id_cli and NOME_ANI = @ANI ";
            comando.Parameters.Add(new SqlParameter("@id_cli", id_cli));
            comando.Parameters.Add(new SqlParameter("@ANI", nomeAni));
            int id_ani = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            comando.CommandText = " select ID_VET from VETERINARIOS WHERE NOME_VET  = @VET";
            comando.Parameters.Add(new SqlParameter("@VET", nomeVet));
            int id_vet = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            comando.CommandText = "UPDATE Consultas SET data_con =@data_con,motivo_con = @motivo_con,nome_cli_con=" +
                "                  @id_cli,nome_ani_con=@id_ani,nome_vet_con=@id_vet " +
                "                   WHERE id_con = @id";

            comando.Parameters.Add(new SqlParameter("@id", id));

            comando.Parameters.Add(new SqlParameter("@data_con", dat));
            comando.Parameters.Add(new SqlParameter("@motivo_con", mot));
            comando.Parameters.Add(new SqlParameter("@id_cli", id_cli));
            comando.Parameters.Add(new SqlParameter("@id_ani", id_ani));
            comando.Parameters.Add(new SqlParameter("@id_vet", id_vet));
           
            comando.ExecuteNonQuery();
            MessageBox.Show("ALTERADO COM SUCESSO", "AVISO");

            conexao.Close();
        }

        public SqlDataReader CarregaConLis(string texto = " ")
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            if (texto == " ")
                comando.CommandText = " select id_con,data_con,motivo_con,NOME_CLI,NOME_ANI,NOME_VET from Consultas  " +

    " inner join CLIENTES on Consultas.nome_cli_con = CLIENTES.ID_CLI "+

   " inner join ANIMAIS on Consultas.nome_ani_con = ANIMAIS.ID_ANI "+

   " inner join VETERINARIOS on Consultas.nome_vet_con = VETERINARIOS.ID_VET   " +
       "    where confPag = 0 ";
            else
            {

                comando.CommandText = " select id_con,data_con,motivo_con,NOME_CLI,NOME_ANI,NOME_VET from Consultas  " +

    " inner join CLIENTES on Consultas.nome_cli_con = CLIENTES.ID_CLI " +

   " inner join ANIMAIS on Consultas.nome_ani_con = ANIMAIS.ID_ANI " +

   " inner join VETERINARIOS on Consultas.nome_vet_con = VETERINARIOS.ID_VET"+
                     "  WHERE    confPag = 0  and    NOME_CLI LIKE '%" + texto+"%'";
            }


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            return LINHA;

        }
        public void InserirDados(string dat,string mot,string nomeCli,string nomeAni,string nomeVet)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select ID_CLI from CLIENTES WHERE NOME_CLI  = @NOM";
            comando.Parameters.Add(new SqlParameter("@NOM", nomeCli));
            int id_cli = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            comando.CommandText = " select ID_ANI from ANIMAIS WHERE id_cli_ani  = @id_cli and NOME_ANI = @ANI ";
            comando.Parameters.Add(new SqlParameter("@id_cli", id_cli));
            comando.Parameters.Add(new SqlParameter("@ANI", nomeAni));
            int id_ani = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            comando.CommandText = " select ID_VET from VETERINARIOS WHERE NOME_VET  = @VET";
            comando.Parameters.Add(new SqlParameter("@VET", nomeVet));
            int id_vet = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            comando.CommandText = "insert into CONSULTAS values(@dat,@mot,@id_cli,@id_ani,@id_vet,0)";
            comando.Parameters.Add(new SqlParameter("@id_ani",id_ani));
            comando.Parameters.Add(new SqlParameter("@id_vet",id_vet));
            comando.Parameters.Add(new SqlParameter("@mot", mot));
            comando.Parameters.Add(new SqlParameter("@dat", dat));
            comando.Parameters.Add(new SqlParameter("@id_cli", id_cli));
            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
        }

        public List<Consulta> Carregarcliente(int id)
        {
            List<Consulta> lis = new List<Consulta>();
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = " select data_con,motivo_con,NOME_CLI,NOME_ANI,NOME_VET from Consultas  " +

    " inner join CLIENTES on Consultas.nome_cli_con = CLIENTES.ID_CLI " +

   " inner join ANIMAIS on Consultas.nome_ani_con = ANIMAIS.ID_ANI " +

   " inner join VETERINARIOS on Consultas.nome_vet_con = VETERINARIOS.ID_VET" +
         "   where id_con = @id";
            comando.Parameters.Add(new SqlParameter("@id", id));


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();

            Consulta clie = new Consulta();

            if (LINHA.Read())
            {
                clie.data_con = LINHA.GetString(0);
                clie.motivo_con = LINHA.GetString(1);
                clie.nome_cli_con = LINHA.GetString(2);
                clie.nome_ani_con = LINHA.GetString(3);
                clie.nome_vet_con = LINHA.GetString(4);
             

                lis.Add(clie);
            }




            return lis;
        }

    }

}
