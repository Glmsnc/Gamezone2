using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.Model;
using Gamezone.DAO;
using System.Data.SqlClient;
using System.Data;

namespace Gamezone.Controller
{
    class PlataformaC
    {
        public String cadastrarPlataforma(PlataformaM plataformaM)
        {
            PlataformaDAO plataformaDAO = new PlataformaDAO();
            bool resultado;

            if (plataformaM.DescricaoPlataforma.Length >= 2)
            {
                resultado = plataformaDAO.cadastroPlataforma(plataformaM);

                if (resultado == true)
                {
                    return "Plataforma " + plataformaM.DescricaoPlataforma + " cadastrada com sucesso.";
                }
                else
                {
                    return "Falha ao cadastrar, verifique se a plataforma já foi cadastrada anteriormente.";
                }
            }
            else
            {
                return "Digite pelo menos 2 caracteres para a Plataforma.";
            }
        }

        public DataTable selecPlataforma()
        {
            PlataformaDAO plataformaDAO = new PlataformaDAO();
            return plataformaDAO.selectPlataformaT();
        }

        public DataTable pesquisarPlataforma(String pesquisa)
        {
            PlataformaDAO plataformaDao = new PlataformaDAO();
            return plataformaDao.pesquisarPlataforma(pesquisa);
        }

        public String excluirPlataforma(int idPlataforma)
        {

            PlataformaDAO plataformaDAO = new PlataformaDAO();
            bool resultado;

            resultado = plataformaDAO.deletPlataforma(idPlataforma);

            if (resultado == true)
            {
                return "Plataforma excluída com sucesso.";
            }
            else
            {
                return "Falha ao excluir a plataforma.";
            }
        }
           public String editarPlataforma(PlataformaM M)
        {

            PlataformaDAO plataformaDAO = new PlataformaDAO();
           
            bool resultado;
            if (M.DescricaoPlataforma.Length >= 2)
            {
                resultado = plataformaDAO.alterarPlataforma(M);

                if (resultado == true)
                {
                    return "Plataforma Editada com sucesso.";
                }
                else
                {
                    return "Falha ao editar a plataforma.";
                }
            }
            else {
                return "Digite pelo menos 2 caracteres para a plataforma";
            }
          
        }
       
    }
}
