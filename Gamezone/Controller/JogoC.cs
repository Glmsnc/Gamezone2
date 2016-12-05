using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.Model;
using Gamezone.DAO;
using System.Data;
using System.Data.SqlClient;

namespace Gamezone.Controller
{
    class JogoC
    {
        public String cadastrarJogo(JogoM jogoM)
        {
            JogoDAO jogoDAO = new JogoDAO();
            String mensagem="";
            bool resultado;

            try
            {
                if (jogoM.NomeJogo.Length < 3)
                {
                    mensagem += "O campo nome deve possuir ao menos 3 caracteres";
                }

                if (jogoM.DescricaoJogo.Length < 10)
                {
                    mensagem += "\nO campo descrição deve possuir ao menos 10 caracteres";
                }

                if (jogoM.ValorJogo <=0)
                {
                    mensagem += "\nDigite um preço válido para o jogo.";
                }

                if (jogoM.TamanhoGBJogo <= 0)
                {
                    mensagem += "\nDigite um valor válido para o tamanho do jogo.";
                }

                if (jogoM.QtdEstoqueJogo <= 0)
                {
                    mensagem += "\nDigite um valor válido para a quantidade no estoque.";
                }

                if (mensagem.Equals(""))
                {
                    resultado = jogoDAO.cadastrarJogo(jogoM);
                    if (resultado == true)
                    {
                        return "Jogo cadastrado com sucesso.";
                    }
                    else
                    {
                        return "Falha ao cadastrar o jogo.";
                    }
                }
                else
                {
                    return mensagem;
                }
            }
            catch
            {
                return "Falha ao cadastrar o jogo.";
            }
        }



        public DataTable jogosCadastrados()
        {
            JogoDAO jogoDAO = new JogoDAO();
            return jogoDAO.jogosCadastrados();
        }

    }
}
