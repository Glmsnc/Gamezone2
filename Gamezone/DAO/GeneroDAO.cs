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
    class GeneroDAO
    {
        ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();

        internal GeneroM GeneroM
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        //id
        public List<GeneroM> selectGenero()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbGenero";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            GeneroM nu = new GeneroM();
            List<GeneroM> lnum = new List<GeneroM>();
            while (dr.Read())
            {
                nu.IdGenero = Convert.ToInt32(dr["idGenero"]);
                nu.DescricaoGenero = dr["descricaoGenero"].ToString();
                lnum.Add(nu);

            }

            return lnum;
        }
        public DataTable selectGeneroT()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idGenero,descricaoGenero'Gênero' FROM tbGenero";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter();

            sqladp.SelectCommand = comando;
            DataTable tbGenero = new DataTable();
            sqladp.Fill(tbGenero);
            conn.Close();
            return tbGenero;

        }

        public bool deletGenero(int idGenero)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "delete from tbGenero where idGenero = @id";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@id", idGenero);
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
        
        public bool cadastroGenero(GeneroM generoM)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT * FROM tbGenero WHERE descricaoGenero = @Desc";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.AddWithValue("@Desc", generoM.DescricaoGenero);

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

                    sql = "INSERT INTO tbGenero(descricaoGenero) VALUES(@Desc)";
                    SqlCommand comando2 = new SqlCommand(sql, conn);
                    comando2.Parameters.AddWithValue("@Desc", generoM.DescricaoGenero);

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

        public DataTable pesquisarGenero(String pesquisa)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT idGenero,descricaoGenero'Gênero' FROM tbGenero"
                         + " WHERE descricaoGenero LIKE '" + pesquisa + "%'";
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

        public bool alterarGenero(GeneroM generoM)
        {
            ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();
            SqlConnection conn = conexaoBdDAO.conexaoSQL();

            String sql = "UPDATE tbGenero SET descricaoGenero = @Desc where idGenero = @idGenero";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Desc", generoM.DescricaoGenero);
                cmd.Parameters.AddWithValue("@idGenero", generoM.IdGenero);
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