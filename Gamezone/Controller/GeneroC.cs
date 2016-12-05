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

        public List<GeneroM> generosCadastrados()
        {
            GeneroDAO generoDAO = new GeneroDAO();
            return generoDAO.generosCadastrados();
        }

        public String excluirGenero(int idGenero)
        {

            GeneroDAO generoDAO = new GeneroDAO();
            bool resultado;

            resultado = generoDAO.deletGenero(idGenero);

            if (resultado == true)
            {
                return "Gênero excluído com sucesso.";
            }
            else
            {
                return "Falha ao excluir o gênero.";
            }
        }
        public String editarGenero(GeneroM generoM)
        {

            GeneroDAO generoDAO = new GeneroDAO();

            bool resultado;
            if (generoM.DescricaoGenero.Length >= 2)
            {
                resultado = generoDAO.alterarGenero(generoM);

                if (resultado == true)
                {
                    return "Gênero editado com sucesso.";
                }
                else
                {
                    return "Falha ao editar o gênero.";
                }
            }
            else
            {
                return "Digite pelo menos 2 caracteres para a plataforma";
            }

        }
    }
}
