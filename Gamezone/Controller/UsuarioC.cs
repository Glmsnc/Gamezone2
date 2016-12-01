using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.DAO;
using Gamezone.Model;

namespace Gamezone.Controller
{
    class UsuarioC
    {
        public int loginValido(String login, String senha) {

            UsuarioM usuarioM = new UsuarioM();
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            usuarioM.LoginUsuario = login;
            usuarioM.SenhaUsuario = senha;

            if (usuarioDAO.loginValido(usuarioM) == true)
            {
                return UsuarioLogadoM.NivelFuncionarioM.IdNivelUsuario;
            }
            else
            {
                return 0;
            }
        }

        public void deslogarUsuario()
        {
            UsuarioLogadoM.IdUsuario = 0;
            UsuarioLogadoM.LoginUsuario = null;
            UsuarioLogadoM.SenhaUsuario = null;
            UsuarioLogadoM.FuncionarioM = null;
            UsuarioLogadoM.NivelFuncionarioM = null;
        }

        
    }
}
