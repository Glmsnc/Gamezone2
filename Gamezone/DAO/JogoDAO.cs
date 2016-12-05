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
        
        public bool cadastrarJogo(JogoM jogoM)
        {
            SqlConnection conn = conexaoBD.conexaoSQL();
            String sql = "INSERT INTO tbJogo(nomeJogo,descricaoJogo,idGenero,idPlataforma,idDistribuidora,valorJogo,ClassificacaoJogo,tamanhoGBJogo,qtdEstoqueJogo) VALUES(@nomeJogo,@descricaoJogo,@idGenero,@idPlataforma,@idDistribuidora,@valorJogo,@ClassificacaoJogo,@tamanhoGBJogo,@qtdEstoqueJogo)";


            try
            {
                SqlCommand comando = new SqlCommand(sql,conn);
                comando.Parameters.AddWithValue("@nomeJogo",jogoM.NomeJogo);
                comando.Parameters.AddWithValue("@descricaoJogo", jogoM.DescricaoJogo);
                comando.Parameters.AddWithValue("@idGenero",jogoM.GeneroM.IdGenero);
                comando.Parameters.AddWithValue("@idPlataforma",jogoM.PlataformaM.IdPlataforma);
                comando.Parameters.AddWithValue("@idDistribuidora",jogoM.DistribuidoraM.IdDistribuidora);
                comando.Parameters.AddWithValue("@valorJogo",jogoM.ValorJogo);
                comando.Parameters.AddWithValue("@ClassificacaoJogo",jogoM.ClassificacaoJogoM);
                comando.Parameters.AddWithValue("@tamanhoGBJogo",jogoM.TamanhoGBJogo);
                comando.Parameters.AddWithValue("@qtdEstoqueJogo",jogoM.QtdEstoqueJogo);

                conn.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
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

        public DataTable jogosCadastrados()
        {
            SqlConnection conn = conexaoBD.conexaoSQL();
            String sql = "SELECT J.idJogo'cod. Jogo',J.nomeJogo'Nome',J.descricaoJogo'Descrição',G.descricaoGenero'Gênero'"
                        + ",P.descricaoPlataforma'Plataforma',D.descricaoDistribuidora'Distribuidora',"
                         + "format(J.valorJogo, 'C', 'pt-br')'Preço',J.ClassificacaoJogo'Faixa etária',J.tamanhoGBJogo'Tamanho(GB)'"
                         + ",J.qtdEstoqueJogo FROM tbJogo J INNER JOIN tbGenero G ON J.idGenero = G.idGenero"
                         + " INNER JOIN tbPlataforma P ON J.idPlataforma = P.idPlataforma INNER JOIN tbDistribuidora D ON J.idDistribuidora = D.idDistribuidora";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando);
                DataTable dtTableJogo = new DataTable();

                sqlDataAdapter.Fill(dtTableJogo);

                return dtTableJogo;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable pesquisarJogo(String campo,String pesquisa)
        {
            SqlConnection conn = conexaoBD.conexaoSQL();
            try
            {
                
                String sql;
                SqlCommand comando = null;

                if (campo.Equals("idJogo"))
                {
                    sql = "SELECT J.idJogo'cod. Jogo',J.nomeJogo'Nome',J.descricaoJogo'Descrição',G.descricaoGenero'Gênero'"
                       + ",P.descricaoPlataforma'Plataforma',D.descricaoDistribuidora'Distribuidora',"
                        + "format(J.valorJogo, 'C', 'pt-br')'Preço',J.ClassificacaoJogo'Faixa etária',J.tamanhoGBJogo'Tamanho(GB)'"
                        + ",J.qtdEstoqueJogo FROM tbJogo J INNER JOIN tbGenero G ON J.idGenero = G.idGenero"
                        + " INNER JOIN tbPlataforma P ON J.idPlataforma = P.idPlataforma INNER JOIN tbDistribuidora D" 
                        +" ON J.idDistribuidora = D.idDistribuidora WHERE J.idJogo = @pesquisa";

                    comando = new SqlCommand(sql, conn);
                    comando.Parameters.AddWithValue("@pesquisa",pesquisa);
                }
                else
                {
                     sql = "SELECT idJogo'cod. Jogo',nomeJogo'Nome',descricaoJogo'Descrição',idGenero'Gênero'"
                            + ",idPlataforma'Plataforma',idDistribuidora'Distribuidora',"
                             + "format(valorJogo, 'C', 'pt-br')'Preço',ClassificacaoJogo'Faixa etária',tamanhoGBJogo'Tamanho(GB)'"
                             + ",qtdEstoqueJogo FROM tbJogo WHERE @campo LIKE (@pesquisa)";

                    comando = new SqlCommand(sql, conn);
                    comando.Parameters.AddWithValue("@campo", campo);
                    comando.Parameters.AddWithValue("@pesquisa", pesquisa+"%");
                }

                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(comando);
                DataTable dtTableJogo = new DataTable();

                sqlDataAdapter.Fill(dtTableJogo);

                return dtTableJogo;
            }
            catch (Exception e)
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
