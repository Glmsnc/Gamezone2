using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gamezone.DAO
{
    class JogoDAO
    {
        ConexaoBdDAO conexaoBD = new ConexaoBdDAO();

        public DataTable listaCadJogo(int opcao, int id)
        {
            SqlConnection conn = conexaoBD.conexaoSQL();
            String sql;
            sql = "select *from tbJogo";
            SqlCommand comando = new SqlCommand(sql, conn);
            SqlDataAdapter sqladp = new SqlDataAdapter();
            comando.Parameters.AddWithValue("@id", id);
            conn.Open();
            sqladp.SelectCommand = comando;
            DataTable tbJogo = new DataTable();
            sqladp.Fill(tbJogo);
            SqlDataReader dr = comando.ExecuteReader();
            conn.Close();
            return tbJogo;
        }



        public Boolean selectJogo(String id)
        {

            SqlConnection conn = conexaoBD.conexaoSQL();
            String sql = "select *from tbJogo where idJogo = @id";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
                return true;
            else
                return false;
        }

        public bool cadastrarJogo(JogoM jogoM)
        {
            SqlConnection conn = conexaoBD.conexaoSQL();
            String sql = "INSERT INTO tbJogo(nomeJogo,descricaoJogo,idGenero,idPlataforma,idDistribuidora"
                +",valorJogo,idClassificacaoJogo,tamanhoGBJogo,qtdEstoqueJogo)"
                + "VALUES(@nomeJogo,@descricaoJogo,@idGenero,@idPlataforma,@idDistribuidora,@valorJogo,"
                + "@iClassificacaoJogo,@tamanhoGBJogo,@qtdEstoqueJogo)";

            try
            {
                   
                SqlCommand comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@nomeJogo",jogoM.nomeJogo);
                MessageBox.Show("jogoM.nomeJogo" + jogoM.nomeJogo.ToString());
                comando.Parameters.AddWithValue("@descricaoJogo",jogoM.descricaoJogo);
                MessageBox.Show("jogoM.descricaoJogo" + jogoM.descricaoJogo.ToString());
                comando.Parameters.AddWithValue("@idGenero", jogoM.generoM + 1) ;
                MessageBox.Show("jogoM.generoM" + jogoM.generoM. ToString());
                comando.Parameters.AddWithValue("@idPlataforma",jogoM.plataformaM + 1);
                MessageBox.Show("jogoM.plataformaM" + jogoM.plataformaM.ToString());
                comando.Parameters.AddWithValue("@idDistribuidora",jogoM.distribuidoraM + 1);
                MessageBox.Show("ogoM.distribuidoraM"  + jogoM.distribuidoraM.ToString());
                comando.Parameters.AddWithValue("@valorJogo",jogoM.valorJogo);
                MessageBox.Show("Valor " + jogoM.valorJogo.ToString());
                comando.Parameters.AddWithValue("@idClassificacaoJogo",jogoM.classificacaoJogoM+1);
                MessageBox.Show("Classificacao"+jogoM.classificacaoJogoM.ToString());
                comando.Parameters.AddWithValue("@tamanhoGBJogo",jogoM.tamanhoGBJogo);
                MessageBox.Show("qtd" + jogoM.qtdEstoqueJogo.ToString());
                comando.Parameters.AddWithValue("@qtdEstoqueJogo",jogoM.qtdEstoqueJogo);

                
                comando.ExecuteNonQuery();

                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool deleteJogo(int idJogo)
        {
            SqlConnection conn = conexaoBD.conexaoSQL();
            String sql = "select *from tbJogo where idJogo = @idJogo";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idJogo", idJogo);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                return true;
                conn.Close();
            }
            else
            {
                conn.Close();
                sql = "delete from tbJogo where idJogo = @idJogo";
                comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@idJogo", idJogo);
                comando.ExecuteNonQuery();
                conn.Close();
                return false;
            }
        }

        public DataTable pesquisarJogo(String tipoPesquisa, String pesquisa)
        {
            SqlConnection conn = conexaoBD.conexaoSQL();
            String sql = "SELECT idJogo,nomeJogo,descricaoJogo,idGenero,idPlataforma,idDistribuidora,"
                         +"valorJogo,ClassificacaoJogo,tamanhoGBJogo,qtdEstoqueJogo "
                         +"FROM tbJogo WHERE @tipoPesquisa LIKE '@pesquisa%'";
            try
            {
                SqlCommand comando = new SqlCommand(sql,conn);
                comando.Parameters.AddWithValue("@tipoPesquisa",tipoPesquisa);
                comando.Parameters.AddWithValue("@pesquisa", pesquisa);

                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando);
                DataTable dtTableJogo = new DataTable();

                sqlDataAdapter.Fill(dtTableJogo);

                return dtTableJogo;
            }
            catch(Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
