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
    class PlataformaDAO
    {
        ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();

        public bool cadastroPlataforma(PlataformaM plataformaM)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT * FROM tbPlataforma WHERE descricaoPlataforma = @Desc";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@Desc", plataformaM.DescricaoPlataforma);

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

                    sql = "INSERT INTO tbPlataforma(descricaoPlataforma) VALUES(@Desc)";
                    SqlCommand comando2 = new SqlCommand(sql, conn);
                    comando2.Parameters.AddWithValue("@Desc", plataformaM.DescricaoPlataforma);

                    comando2.ExecuteNonQuery();
                    return true;
                }
            }
            catch(SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<PlataformaM> plataformasCadastradas()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idPlataforma,descricaoPlataforma FROM tbPlataforma";

            try
            {
                SqlCommand comando = new SqlCommand(sql,conn);

                conn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                List<PlataformaM> listPlataforma = new List<PlataformaM>();

                while (dr.Read())
                {
                    PlataformaM plataformaM = new PlataformaM();
                    plataformaM.IdPlataforma = Convert.ToInt32(dr["idPlataforma"]);
                    plataformaM.DescricaoPlataforma = dr["descricaoPlataforma"].ToString();

                    listPlataforma.Add(plataformaM);
                }
                return listPlataforma;
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
       
        public DataTable selectPlataformaT()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idPlataforma,descricaoPlataforma'Plataforma' FROM tbPlataforma ";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter();

            sqladp.SelectCommand = comando;
            DataTable tbPlataforma = new DataTable();
            sqladp.Fill(tbPlataforma);
            conn.Close();
            return tbPlataforma;

        }

        public bool deletPlataforma(int idPlataforma)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            try
            {
                
                String sql = "delete from tbPlataforma where idPlataforma = @id";
                SqlCommand comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@id", idPlataforma);
                comando.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally {
                conn.Close();
            }
        }

        public DataTable pesquisarPlataforma(String pesquisa)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idPlataforma,descricaoPlataforma'Plataforma' FROM tbPlataforma"
                         + " WHERE descricaoPlataforma LIKE '"+pesquisa+"%'";
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
        public bool alterarPlataforma(PlataformaM Plataforma)
        {
            ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();
            SqlConnection conn = conexaoBdDAO.conexaoSQL();

            String sql = "UPDATE tbPlataforma SET descricaoPlataforma = @Desc where idPlataforma = @idPlataforma";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Desc", Plataforma.DescricaoPlataforma);
                cmd.Parameters.AddWithValue("@idPlataforma", Plataforma.IdPlataforma);
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

    }
}
