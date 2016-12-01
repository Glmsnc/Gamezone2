using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.DAO;
using Gamezone.Model;
namespace Gamezone.Controller
{
    class AtualizarFuncionario
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

        public int atFuncionario(FuncionarioM funcionario)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            if (funcionario.NomeFuncionario.Length < 5)
            {
                return 1;
            }
            else if (funcionario.CpfFuncionario.Length < 5)
            {
                return 2;
            }
            else if (dao.selectFuncionario(funcionario.CpfFuncionario, 0) != null)
            {
                return 3;
            }
            else
            {
                dao.alterarFuncionario(funcionario);
                return 0;
            }
        }
    }
}
