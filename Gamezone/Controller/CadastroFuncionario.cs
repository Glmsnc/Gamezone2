using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.DAO;
namespace Gamezone.Controller
{
    class CadastroFuncionario
    {
        internal FuncionarioDAO FuncionarioDAO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int cadUsuario(String nome, String cpf, int idCargo)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            if (nome.Length < 5)
            {
                return 1;
            }
            else if (cpf.Length < 5)
            {
                return 2;
            }
            else if (dao.selectFuncionario(cpf,0)!=null)
            {
                return 3;
            }
            else
            {
                dao.cadastroFuncionario(nome, cpf, idCargo);
                return 0;
            }
        }
    }
}

