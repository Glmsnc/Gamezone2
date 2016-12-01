using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.DAO;
using Gamezone.Model;

namespace Gamezone.Controller
{
    class AtualizarUsuario
    {
        internal UsuarioDAO UsuarioDAO
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int atUsuario(UsuarioM usuarioM)
        {
            UsuarioDAO dao = new UsuarioDAO();
            if (usuarioM.LoginUsuario.Length < 5 || usuarioM.SenhaUsuario.Length < 5)
            {
                return 1;
            }
            else if (usuarioM.LoginUsuario == usuarioM.SenhaUsuario)
            {
                return 2;
            }
            else if (dao.selectUsuario(usuarioM.IdUsuario, usuarioM.LoginUsuario) != null)
                return 3;
            else
            {
                dao.alterarUsuario(usuarioM);
                return 0;
            }


        }
    }
}
