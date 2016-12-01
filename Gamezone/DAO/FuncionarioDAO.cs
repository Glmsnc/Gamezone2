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
    class FuncionarioDAO
    {/// <summary>
    /// 
    /// </summary>
        ConexaoBdDAO conexaoBdDAO = new ConexaoBdDAO();

        public FuncionarioM FuncionarioM
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public DataTable listaCadUser(int opcao, int id)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql;
            //parametro pra pegar somente alguns registros
            if (opcao == 1)
                sql = "select * from tbFuncionario where idFuncionario not in (select idFuncionario from tbUsuario where idUsuario != @id)";
            else
                sql = "select * from tbFuncionario";
            SqlCommand comando = new SqlCommand(sql, conn);
            SqlDataAdapter sqladp = new SqlDataAdapter();
            comando.Parameters.AddWithValue("@id", id);
            conn.Open();
            sqladp.SelectCommand = comando;
            DataTable tbfuncionario = new DataTable();
            sqladp.Fill(tbfuncionario);
            SqlDataReader dr = comando.ExecuteReader();
            conn.Close();
            return tbfuncionario;
        }



        public FuncionarioM selectFuncionario(String cpf, int id)
        {
            FuncionarioM func = null;
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select * from tbFuncionario where cpfFuncionario = @cpf or idFuncionario = @id";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                func = new FuncionarioM();
                func.IdFuncionario = Convert.ToInt32(dr["idFuncionario"]);
                func.CargoFuncionarioM.IdCargoFuncionario = Convert.ToInt32(dr["idCargoFuncionario"]);
                func.CpfFuncionario = dr["cpfFuncionario"].ToString();
                func.NomeFuncionario = dr["nomeFuncionario"].ToString();
            }
            return func;

        }

        public void cadastroFuncionario(String nome, String cpf, int idCargo)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "insert into tbFuncionario values(@nome,@cpf,@idCargo)";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@idCargo", idCargo);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void deleteFuncionario(int idFuncionario)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "delete from tbUsuario where idFuncionario = @idUsuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idUsuario", idFuncionario);
            comando.ExecuteNonQuery();
            conn.Close();
            sql = "delete from tbFuncionario where idFuncionario = @idUsuario";
            comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idUsuario", idFuncionario);
            comando.ExecuteNonQuery();
            conn.Close();

        }
        public bool alterarFuncionario(FuncionarioM func)
        {

            SqlConnection conn = conexaoBdDAO.conexaoSQL();

            String sql = "UPDATE tbFuncionario SET nomeFuncionario = @nome, cpfFuncionario = @cpf, idCargoFuncionario = @idCargo where idFuncionario = @idFunc";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", func.NomeFuncionario);
                cmd.Parameters.AddWithValue("@cpf", func.CpfFuncionario);
                cmd.Parameters.AddWithValue("@idCargo", func.CargoFuncionarioM.IdCargoFuncionario);
                cmd.Parameters.AddWithValue("@idFunc", func.IdFuncionario);
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
