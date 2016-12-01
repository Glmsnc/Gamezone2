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
    class UsuarioDAO
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

        public UsuarioM UsuarioM
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public bool loginValido(UsuarioM usuarioM) {

            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "SELECT * FROM tbUsuario U INNER JOIN tbFuncionario F ON U.idFuncionario = F.idFuncionario"
                         +" INNER JOIN tbNivelUsuario N ON U.idNivelUsuario = N.idNivelUsuario WHERE U.loginUsuario"
                         +" COLLATE Latin1_General_CS_AS = @loginUsuario COLLATE Latin1_General_CS_AS AND "
                         +"U.senhaUsuario COLLATE Latin1_General_CS_AS = @senhaUsuario COLLATE Latin1_General_CS_AS";
            try
            {
                SqlCommand comando = new SqlCommand(sql,conn);
                comando.Parameters.AddWithValue("@loginUsuario",usuarioM.LoginUsuario);
                comando.Parameters.AddWithValue("@senhaUsuario",usuarioM.SenhaUsuario);
                conn.Open();
                SqlDataReader dr = comando.ExecuteReader();
                
                if (dr.Read())
                {
                    FuncionarioM funcionarioM = new FuncionarioM();
                    NivelUsuarioM nivelUsuarioM = new NivelUsuarioM();
                   
                    UsuarioLogadoM.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                    UsuarioLogadoM.LoginUsuario = dr["loginUsuario"].ToString();
                    UsuarioLogadoM.SenhaUsuario = dr["senhaUsuario"].ToString();
                    funcionarioM.IdFuncionario = Convert.ToInt32(dr["idFuncionario"]);
                    funcionarioM.NomeFuncionario = dr["nomeFuncionario"].ToString();
                    funcionarioM.CpfFuncionario = dr["cpfFuncionario"].ToString();
                    funcionarioM.CargoFuncionarioM.IdCargoFuncionario = Convert.ToInt32(dr["idCargoFuncionario"]);
                    nivelUsuarioM.IdNivelUsuario = Convert.ToInt32(dr["idNivelUsuario"]);
                    nivelUsuarioM.DescricaoNivelUsuario = dr["descricaoNivelUsuario"].ToString();
                    UsuarioLogadoM.FuncionarioM = funcionarioM;
                    UsuarioLogadoM.NivelFuncionarioM = nivelUsuarioM;

                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public void cadastroUsuario(int id, String nome, String senha, int nivel)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "insert into tbUsuario values(@login,@senha,@nivel,@idFunc)";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@login", nome);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@nivel", nivel);
            comando.Parameters.AddWithValue("@idFunc", id);
            comando.ExecuteNonQuery();
        }

        public UsuarioM selectUsuario(int cod, String login)
        {
            UsuarioM um = new UsuarioM();
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select *from tbUsuario where idUsuario = @cod or loginUsuario = @login";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@login", login);
            SqlDataReader dr = comando.ExecuteReader();
            if (dr.Read())
            {
                um.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                um.FuncionarioM.IdFuncionario = Convert.ToInt32(dr["idFuncionario"]);
                um.NivelFuncionarioM.IdNivelUsuario = Convert.ToInt32(dr["idNivelUsuario"]);
                um.LoginUsuario = dr["loginUsuario"].ToString();
                um.SenhaUsuario = dr["senhaUsuario"].ToString();

            }

            return um;

        }

        public DataTable selectTodoUsuario()
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "select idUsuario,nomeFuncionario,descricaoCargoFuncionario,descricaoNivelUsuario,loginUsuario,senhaUsuario from tbUsuario u inner join tbNivelUsuario n on u.idNivelUsuario = n.idNivelUsuario inner join tbFuncionario f on u.idFuncionario=f.idFuncionario inner join tbCargoFuncionario cf on f.idCargoFuncionario = cf.idCargoFuncionario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataAdapter sqladp = new SqlDataAdapter();

            sqladp.SelectCommand = comando;
            DataTable tbusuario = new DataTable();
            sqladp.Fill(tbusuario);
            conn.Close();
            return tbusuario;

        }

        public void deletUsuario(int idUsuario)
        {
            SqlConnection conn = conexaoBdDAO.conexaoSQL();
            String sql = "delete from tbUsuario where idUsuario = @idUsuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            conn.Open();
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public bool alterarUsuario(UsuarioM usuarioM)
        {

            SqlConnection conn = conexaoBdDAO.conexaoSQL();

            String sql = "UPDATE tbUsuario SET loginUsuario = @login, senhaUsuario = @senhaUsuario, idNivelUsuario = @idNivel, idFuncionario = @idFuncionario WHERE idUsuario = @idUsuario";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", usuarioM.LoginUsuario);
                cmd.Parameters.AddWithValue("@senhaUsuario", usuarioM.SenhaUsuario);
                cmd.Parameters.AddWithValue("@idNivel", usuarioM.NivelFuncionarioM.IdNivelUsuario);
                cmd.Parameters.AddWithValue("@idFuncionario", usuarioM.FuncionarioM.IdFuncionario);
                cmd.Parameters.AddWithValue("@idUsuario", usuarioM.IdUsuario);
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
