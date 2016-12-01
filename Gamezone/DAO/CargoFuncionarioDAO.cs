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
    class CargoFuncionarioDAO
    {
        ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();

        public CargoFuncionarioM CargoFuncionarioM
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public CargoFuncionarioM selectCargoFuncID(int id)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbCargoFuncionario where idCargoFuncionario = @idCargo";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idCargo", id);
            SqlDataReader dr = comando.ExecuteReader();
            CargoFuncionarioM cfm = new CargoFuncionarioM();
            if (dr.Read())
            {
                cfm = new CargoFuncionarioM();
                cfm.IdCargoFuncionario = Convert.ToInt32(dr["idCargoFuncionario"]);
                cfm.DescricaoCargoFuncionario = dr["descricaoCargoFuncionario"].ToString();
            }
            conn.Close();
            return cfm;

        }
        public List<CargoFuncionarioM> selectCargoFunc()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbCargoFuncionario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = comando.ExecuteReader();

            List<CargoFuncionarioM> lista = new List<CargoFuncionarioM>();
            while (dr.Read())
            {
                CargoFuncionarioM cfm = new CargoFuncionarioM();
                cfm.IdCargoFuncionario = Convert.ToInt32(dr["idCargoFuncionario"]);
                cfm.DescricaoCargoFuncionario = dr["descricaoCargoFuncionario"].ToString();
                lista.Add(cfm);
            }
            conn.Close();
            return lista;
        }

        public DataTable selectCargo()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbCargoFuncionario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter();

            sqladp.SelectCommand = comando;
            DataTable tbcargo = new DataTable();
            sqladp.Fill(tbcargo);
            conn.Close();
            return tbcargo;

        }

        public bool deletCargo(int idCargo)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbFuncionario where idCargoFuncionario = @idUsuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idUsuario", idCargo);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                return true;
                conn.Close();
            }
            else
            {
                conn.Close();
                sql = "delete from tbCargoFuncionario where idCargoFuncionario = @idUsuario";
                comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@idUsuario", idCargo);
                comando.ExecuteNonQuery();
                conn.Close();
                return false;
            }
        }

        public bool cadastroCargo(String desc)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbCargoFuncionario where descricaoCargoFuncionario= @idUsuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idUsuario", desc);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
                return true;
            else
            {
                conn.Close();
                sql = "insert into tbCargoFuncionario values(@idUsuario)";
                comando = new SqlCommand(sql, conn);
                conn.Open();
                comando.Parameters.AddWithValue("@idUsuario", desc);
                comando.ExecuteNonQuery();
                return false;
                conn.Close();
            }


        }
        public bool alterarCargo(CargoFuncionarioM cargo)
        {

            SqlConnection conn = conexaoBdDAO.conexaoSQL();

            String sql;
            sql = "select *from tbCargoFuncionario where descricaoCargoFuncionario= @cargo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cargo", cargo.DescricaoCargoFuncionario);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return true;
            else
            {
                conn.Close();
                sql = "update tbCargoFuncionario set descricaoCargoFuncionario = @cargo where idCargoFuncionario = @id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cargo", cargo.DescricaoCargoFuncionario);
                cmd.Parameters.AddWithValue("@id", cargo.IdCargoFuncionario);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return false;
            }

        }

    }
}
