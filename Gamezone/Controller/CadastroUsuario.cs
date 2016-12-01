using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamezone.Model;
using Gamezone.DAO;
namespace Gamezone.Controller
{
    class CadastroUsuario
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

        public int cadUsuario(int id,int nivel, String login, String senha)
        {
            UsuarioDAO dao = new UsuarioDAO();
            if (login.Length < 5 || senha.Length < 5)
            {
                return 1;
            }
            else if (login == senha)
            {
                return 2;
            }
           // else if (//dao.selectUsuario(id, login) == null)
               // return 3;
            else
            {
                //dao.cadastroUsuario(id, login, senha, nivel);
                return 0;
            }
            

        }
    }
}
