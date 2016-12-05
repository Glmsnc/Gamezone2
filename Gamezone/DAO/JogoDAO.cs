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
            String sql = "INSERT INTO tbJogo(nomeJogo,descricaoJogo,idGenero,idPlataforma,idDistribuidora,"
                +"valorJogo,ClassificacaoJogo,tamanhoGBJogo,qtdEstoqueJogo) "
                +"VALUES(@nomeJogo,@descricaoJogo,@idGenero,@idPlataforma,@idDistribuidora,@valorJogo,"
                + "@ClassificacaoJogo,@tamanhoGBJogo,@qtdEstoqueJogo)";

            try
            {
                SqlCommand comando = new SqlCommand(sql,conn);
                comando.Parameters.AddWithValue("@nomeJogo",jogoM.NomeJogo);
                comando.Parameters.AddWithValue("@descricaoJogo",jogoM.DescricaoJogo);
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
            catch
            {
                return false;
            }
            finally
            {\
                conn.Close();
            }
        }
    }
}
