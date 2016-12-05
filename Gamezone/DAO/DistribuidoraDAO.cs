using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gamezone.DAO
{
    class DistribuidoraDAO
    {
        ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();

      
        public DataTable selectDistribuidoraT()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idDistribuidora,descricaoDistribuidora'Distribuidora' FROM tbDistribuidora";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter();

            sqladp.SelectCommand = comando;
            DataTable tbdistribuidora = new DataTable();
            sqladp.Fill(tbdistribuidora);
            conn.Close();
            return tbdistribuidora;

        }

        public bool deletDistribuidora(int idDistribuidora)
        {
            
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "delete from tbDistribuidora where idDistribuidora = @id";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@id", idDistribuidora);
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

        public bool alterarDistribuidora(DistribuidoraM distribuidoraM)
        {
            ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();
            SqlConnection conn = conexaoBdDAO.conexaoSQL();

            String sql = "UPDATE tbDistribuidora SET descricaoDistribuidora = @Desc where idDistribuidora = @idDistribuidora";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Desc", distribuidoraM.DescricaoDistribuidora);
                cmd.Parameters.AddWithValue("@idDistribuidora", distribuidoraM.IdDistribuidora);
                conn.Open();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool cadastroDistribuidora(DistribuidoraM distribuidoraM)
        {

            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT * FROM tbDistribuidora WHERE descricaoDistribuidora = @Desc";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@Desc", distribuidoraM.DescricaoDistribuidora);

                conn.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    return false;
                }
                else
                {
                    comando.Cancel();
                    dr.Close();

                    sql = "INSERT INTO tbDistribuidora(descricaoDistribuidora) VALUES(@Desc)";
                    SqlCommand comando2 = new SqlCommand(sql, conn);
                    comando2.Parameters.AddWithValue("@Desc", distribuidoraM.DescricaoDistribuidora);

                    comando2.ExecuteNonQuery();
                    return true;
                }
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

        public DataTable pesquisarDistribuidora(String pesquisa)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idDistribuidora,descricaoDistribuidora'Distribuidora' FROM tbDistribuidora"
                         + " WHERE descricaoDistribuidora LIKE '" + pesquisa + "%'";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                //comando.Parameters.AddWithValue("@pesquisa", pesquisa);

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

        public List<DistribuidoraM> distribuidorasCadastradas()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idDistribuidora,descricaoDistribuidora FROM tbDistribuidora";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                List<DistribuidoraM> listDistribuidora = new List<DistribuidoraM>();

                while (dr.Read())
                {
                    DistribuidoraM distribuidoraM = new DistribuidoraM();
                    distribuidoraM.IdDistribuidora = Convert.ToInt32(dr["idDistribuidora"]);
                    distribuidoraM.DescricaoDistribuidora = dr["descricaoDistribuidora"].ToString();

                    listDistribuidora.Add(distribuidoraM);
                }
                return listDistribuidora;
            }
            catch
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
