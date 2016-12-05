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
    class DistribuidoraC
    {
        public String cadastrarDistribuidora(DistribuidoraM distribuidoraM)
        {
            DistribuidoraDAO distribuidoraDAO = new DistribuidoraDAO();
            bool resultado;

            if (distribuidoraM.DescricaoDistribuidora.Length >= 2)
            {
                resultado = distribuidoraDAO.cadastroDistribuidora(distribuidoraM);

                if (resultado == true)
                {
                    return "Distribuidora " + distribuidoraM.DescricaoDistribuidora + " cadastrada com sucesso.";
                }
                else
                {
                    return "Falha ao cadastrar, verifique se a distribuidora já foi cadastrada anteriormente.";
                }
            }
            else
            {
                return "Digite pelo menos 2 caracteres para a Distribuidora.";
            }
        }

        public DataTable selecDistribuidora()
        {
            DistribuidoraDAO distribuidoraDAO = new DistribuidoraDAO();
            return distribuidoraDAO.selectDistribuidoraT();
        }

        public DataTable pesquisarDistribuidora(String pesquisa)
        {
            DistribuidoraDAO distribuidoraDAO = new DistribuidoraDAO();
            return distribuidoraDAO.pesquisarDistribuidora(pesquisa);
        }

        public List<DistribuidoraM> distribuidorasCadastradas()
        {
            DistribuidoraDAO distribuidoraDAO = new DistribuidoraDAO();
            return distribuidoraDAO.distribuidorasCadastradas();
        }

        public String excluirDistribuidora(int idDistribuidora)
        {

            DistribuidoraDAO distribuidoraDAO = new DistribuidoraDAO();
            bool resultado;

            resultado = distribuidoraDAO.deletDistribuidora(idDistribuidora);

            if (resultado == true)
            {
                return "Distribuidora excluída com sucesso.";
            }
            else
            {
                return "Falha ao excluir a distribuidora.";
            }
        }
        public String editarDistribuidora(DistribuidoraM distribuidoraM)
        {

            DistribuidoraDAO distribuidoraDAO = new DistribuidoraDAO();

            bool resultado;
            if (distribuidoraM.DescricaoDistribuidora.Length >= 2)
            {
                resultado = distribuidoraDAO.alterarDistribuidora(distribuidoraM);

                if (resultado == true)
                {
                    return "Distribuidora editada com sucesso.";
                }
                else
                {
                    return "Falha ao editar a distribuidora.";
                }
            }
            else
            {
                return "Digite pelo menos 2 caracteres para a distribuidora";
            }

        }
    }
}
