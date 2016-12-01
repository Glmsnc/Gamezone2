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
    class GeneroC
    {
        public String cadastrarGenero(GeneroM generoM)
        {
            GeneroDAO generoDAO = new GeneroDAO();
            bool resultado;

            if (generoM.DescricaoGenero.Length >= 3)
            {
                resultado = generoDAO.cadastroGenero(generoM);

                if (resultado == true)
                {
                    return "Gênero " + generoM.DescricaoGenero + " cadastrado com sucesso.";
                }
                else
                {
                    return "Falha ao cadastrar, verifique se o gênero já foi cadastrado anteriormente.";
                }
            }
            else {
                return "Digite pelo menos 3 caracteres para o Gênero.";
            }  
        }

        public DataTable selectGenero() {

            GeneroDAO generoDAO = new GeneroDAO();
            return  generoDAO.selectGeneroT();
        }

        public DataTable pesquisarGenero(String pesquisa)
        {
            GeneroDAO generoDAO = new GeneroDAO();
            return generoDAO.pesquisarGenero(pesquisa);
        }
    }
}
