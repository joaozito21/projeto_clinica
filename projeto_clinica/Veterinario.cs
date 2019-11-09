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
    class Veterinario
    {
        string caminho = "Data Source=JOAO-PC\\SQLEXPRESS; Initial Catalog=projeto_linguagem;Integrated Security=SSPI;";

        public string nome_vet { get; set; }

        public string crmv { get; set; }

        public string end_vet { get; set; }

        public string est_vet { get; set; }

        public string sex_vet { get; set; }

        public string cid_vet { get; set; }

        public string dat_vet { get; set; }

        public string tel_vet { get; set; }

        public SqlDataReader CarregaCliLis(string texto = " ")
        {

            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            if (texto == " ")
                comando.CommandText = " select ID_VET,NOME_VET,ENDERECO_VET,CRMV from VETERINARIOS";
            else
            {
                comando.CommandText = "select ID_VET,NOME_VET,ENDERECO_VET,CRMV from VETERINARIOS " +
                                      "WHERE NOME_VET LIKE  '%" + texto + "%'";
            }


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();
            return LINHA;

        }


        public List<Veterinario> CarregarVeterinario(int id)
        {
            List<Veterinario> lis = new List<Veterinario>();
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "select * from VETERINARIOS WHERE id_vet = @id";
            comando.Parameters.Add(new SqlParameter("@id", id));


            comando.CommandType = CommandType.Text;
            SqlDataReader LINHA = comando.ExecuteReader();

            Veterinario vet = new Veterinario();

            if (LINHA.Read())
            {
                vet.nome_vet = LINHA.GetString(1);
                vet.crmv = LINHA.GetString(2);
                vet.end_vet = LINHA.GetString(3);
                vet.est_vet = LINHA.GetString(4);
                vet.sex_vet = LINHA.GetString(5);
                vet.cid_vet = LINHA.GetString(6);
                vet.dat_vet = LINHA.GetString(7);
                vet.tel_vet = LINHA.GetString(8);

                lis.Add(vet);
            }




            return lis;
        }


        public void AlterarDados(string nome, string end, string est, string sex,
            string cid, string dat, string tel,string crmv,string id_vet)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "UPDATE VETERINARIOS SET NOME_VET=@NOME,CRMV=@CRMV," +
                "                                  ENDERECO_VET=@END,ESTADO_VET=@esp, " +
                "                                  SEXO_VET = @sex,CIDADE_VET =@cid," +
                "                                  data_nasc_vet =@dat,tel_vet=@tel  " +
                "                  WHERE id_vet = @id_vet";
            comando.Parameters.Add(new SqlParameter("@NOME",nome));
            comando.Parameters.Add(new SqlParameter("@END", end));
            comando.Parameters.Add(new SqlParameter("@esp", est));
            comando.Parameters.Add(new SqlParameter("@sex", sex));
            comando.Parameters.Add(new SqlParameter("@cid", cid));
            comando.Parameters.Add(new SqlParameter("@dat", dat));
            comando.Parameters.Add(new SqlParameter("@id_vet",int.Parse(id_vet)));
            comando.Parameters.Add(new SqlParameter("@tel", tel));
            comando.Parameters.Add(new SqlParameter("@crmv",crmv));

            comando.ExecuteNonQuery();
            MessageBox.Show("ALTERADO REGISTRO COM SUCESSO", "AVISO");
        }
        public void ExcluirVet(int id_vet)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = "delete from VETERINARIOS" +
             
                "                  WHERE id_vet = @ID";
            comando.Parameters.Add(new SqlParameter("@ID", id_vet));
           

            comando.ExecuteNonQuery();
            MessageBox.Show("EXCLUIR REGISTRO COM SUCESSO", "AVISO");
        }

        public void CadastrarDados(string nome, string end, string est, string sex, string cid, string dat, string tel,string CRMV)
        {
            SqlConnection conexao = new SqlConnection(caminho);

            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "insert into VETERINARIOS values(@nome,@CRMV,@endereco,@est,@sex,@cid,@dat,@tel)";


            comando.Parameters.Add(new SqlParameter("@nome", nome));
            comando.Parameters.Add(new SqlParameter("@endereco", end));
            comando.Parameters.Add(new SqlParameter("@est", est));
            comando.Parameters.Add(new SqlParameter("@sex", sex));
            comando.Parameters.Add(new SqlParameter("@cpf", " "));
            comando.Parameters.Add(new SqlParameter("@Cid", cid));
            comando.Parameters.Add(new SqlParameter("@dat", dat));
            comando.Parameters.Add(new SqlParameter("@tel", tel));
            comando.Parameters.Add(new SqlParameter("@CRMV", CRMV));
            comando.ExecuteNonQuery();
            MessageBox.Show("INSERIDO REGISTRO COM SUCESSO", "AVISO");
            conexao.Close();
        }
    }
}
