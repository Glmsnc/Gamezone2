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
    class NivelUsuarioDAO
    {
        ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();

        internal ConexaoBdDAO ConexaoBdDAO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal NivelUsuarioM NivelUsuarioM
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public List<NivelUsuarioM> selectNivelUsuario()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbNivelUsuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            NivelUsuarioM nu = new NivelUsuarioM();
            List<NivelUsuarioM> lnum = new List<NivelUsuarioM>();
            while (dr.Read())
            {
                nu.IdNivelUsuario = Convert.ToInt32(dr["idNivelUsuario"]);
                nu.DescricaoNivelUsuario = dr["descricaoNivelUsuario"].ToString();
                lnum.Add(nu);
    
            }

            return lnum;
        }
        public DataTable selectNivel()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbNivelUsuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter();

            sqladp.SelectCommand = comando;
            DataTable tbnivel = new DataTable();
            sqladp.Fill(tbnivel);
            conn.Close();
            return tbnivel;

        }

        public void deletNivel(int idNivel)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "delete from tbNivelUsuario where idNivelUsuario = @idUsuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idUsuario", idNivel);
            comando.ExecuteNonQuery();
            conn.Close();
        }
    }
}
